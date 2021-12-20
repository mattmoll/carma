using System;
using System.Data;
using System.Windows.Forms;
using TNGS.NetApp;
using TNGS.NetControls;
using TNGS.NetOffice;
using TNGS.NetRoutines;

namespace Carm.Tg
{
    public partial class CargaExcel : Form
    {
        // Miembros
        StatMsg m_smResult = new StatMsg();
        DataTable m_dtRelaciones = null;
        private bool m_bCancel = false;
        CargadorCliente cargadorCliente;

        // Constructor
        public CargaExcel()
        {
            InitializeComponent();

            cargadorCliente = new CargadorCliente();
        }

        #region Eventos

        // Evento del load del form
        private void CargaExcel_Load(object sender, EventArgs e)
        {
            // Creamos la tabla de equivalencias
            m_dtRelaciones = new DataTable("Equivalencias");

            m_dtRelaciones.Columns.Add("codexcel", typeof(int));
            m_dtRelaciones.Columns.Add("codbase", typeof(int));
            m_dtRelaciones.Columns.Add("desexcel", typeof(string));
            m_dtRelaciones.Columns.Add("desbase", typeof(string));

            Shr.ElegirMarca formElegirMarca = new Shr.ElegirMarca();
            formElegirMarca.ShowDialog(this);

            if(formElegirMarca.DialogResult == DialogResult.OK)
            {
                cargadorCliente.CodMarca = formElegirMarca.codMarcaElegido;
            }

            SwitchTo(FormModes.Operations);
        }

        // Evento del boton de confirmacion del path de la planilla.
        private void cmdConfirmar_Click(object sender, EventArgs e)
        {
            // Validamos 
            if (txtPlanilla.Text.Trim().Length == 0)
            {
                // Error
                MsgRuts.ShowMsg(this, "Debe especificarse una planilla.");
                return;
            }

            // Abrimos el Excel
            App.ShowMsg("Leyendo el excel...");
            WRPXlsx l_wrExcel;
            try
            {
                l_wrExcel = new WRPXlsx(txtPlanilla.Text, m_smResult);
                if (MsgRuts.AnalizeError(this, m_smResult)) return;
            }
            catch (Exception)
            {
                MsgRuts.ShowMsg(this,"La planilla excel que está tratando de importar está en formato viejo o está en uso (abierta con el excel)");
                return;
            }

            ExcelWorksheet l_oHoja = l_wrExcel.GetSheet(1, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;


            // Recorremos las primeras 30 columnas
            string l_strTitulo = "", l_strCodeList = "";
            object l_oValue = null;

            for (int l_iCol = 1; l_iCol != 30; l_iCol++)
            {
                // Obtenemos el dato de la primera fila
                l_oValue = l_wrExcel.GetCell(ref l_oHoja, 1, l_iCol, m_smResult);
                if (MsgRuts.AnalizeError(this, m_smResult)) return;

                l_strTitulo = "";
                if (l_oValue != null) l_strTitulo = l_oValue.ToString();
                if ((l_strTitulo == null) || (l_strTitulo.Trim() == "")) break;

                // Lo agregamos a la lista
                cdlExcel.AddIntCD(l_iCol, l_strTitulo, 0);
                l_strCodeList += (l_iCol.ToString() + "@@");
                l_strCodeList += (l_strTitulo + "@@");
            }

            // Cerramos el excel
            App.HideMsg();

            // Cargamos las opciones de la base (REVISAR SI ESOS CAMPOS ESTAN BIEN, SON LOS QUE ME PARECIERON)
            cargadorCliente.llenarListaCampos(cdlBases);

            // Pasamos a modo proceso
            SwitchTo(FormModes.Process);
            gbCancelar.Focus();
        }

        // Evento de busqueda de la planilla de excel a cargar.
        private void cmdFind_Click(object sender, EventArgs e)
        {
            // Pedimos los datos
            if (dlgExcel.ShowDialog(this) == DialogResult.Cancel) return;
            txtPlanilla.Text = dlgExcel.FileName;
        }

        // Evento del boton de borrado de una relacion.
        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            // Si no hay item seleccionado -> salimos
            int l_iRow = grdRelaciones.CurrentRowIndex;
            if (l_iRow == -1) return;

            // Obtenemos los indices del item a borrar
            string l_strIExcel = grdRelaciones.GetMatrixValue(l_iRow, 0).Trim();
            if (l_strIExcel == "") l_strIExcel = "0";

            string l_strIBase = grdRelaciones.GetMatrixValue(l_iRow, 1).Trim();
            if (l_strIBase == "") l_strIBase = "0";

            // Convertimos a entero
            int l_iExcel = Convert.ToInt32(l_strIExcel);
            int l_iBase = Convert.ToInt32(l_strIBase);

            // Buscamos en la tabla de relaciones
            foreach (DataRow l_drItem in m_dtRelaciones.Rows)
            {
                // comparamos
                if (((int)l_drItem["codexcel"] == l_iExcel) && ((int)l_drItem["codbase"] == l_iBase))
                {
                    // tenemos que borrarlo
                    if (MsgRuts.AskUser(this,
                        String.Format("¿Confirma el borrado de la relación: \r\n{0}-{1}?",
                        (string)l_drItem["desexcel"],
                        (string)l_drItem["desbase"])) == DialogResult.No) return;

                    // Agregamos los items a las listas
                    cdlExcel.AddIntCD((int)l_drItem["codexcel"], (string)l_drItem["desexcel"], 0);
                    cdlBases.AddIntCD((int)l_drItem["codbase"], (string)l_drItem["desbase"], 0);

                    // Borramos el item
                    m_dtRelaciones.Rows.Remove(l_drItem);

                    // Recargamos la grilla
                    FillGrid();
                    return;
                }
            }
        }

        // Evento del boton de nueva relacion.
        private void gbNuevo_Click(object sender, EventArgs e)
        {
            // Vemos si estan seleccionados los campos
            if (cdlExcel.SelectedIntCode == 0)
            {
                // Error
                MsgRuts.ShowMsg(this, "Debe seleccionarse un campo del Excel");
                return;
            }

            if (cdlBases.SelectedIntCode == 0)
            {
                // Error
                MsgRuts.ShowMsg(this, "Debe seleccionarse un campo de la base");
                return;
            }

            // Obtenemos los nuevos datos
            int l_iExcel = cdlExcel.SelectedIntCode;
            int l_iBase = cdlBases.SelectedIntCode;

            // Recorremos la lista para ver que no haya repetidos
            foreach (DataRow l_drItem in m_dtRelaciones.Rows)
            {
                // Comparamos el campo excel
                if ((int)l_drItem["codexcel"] == l_iExcel)
                {
                    // ya existe
                    MsgRuts.ShowMsg(this, "El campo Excel ya está seleccionado");
                    return;
                }

                // Comparamos el campo base
                if ((int)l_drItem["codbase"] == l_iBase)
                {
                    // ya existe
                    MsgRuts.ShowMsg(this, "El campo de la Base ya está seleccionado");
                    return;
                }
            }

            // Es valido. La agregamos
            DataRow l_drNew = m_dtRelaciones.NewRow();

            l_drNew["codexcel"] = l_iExcel;
            l_drNew["desexcel"] = cdlExcel.Text;
            l_drNew["codbase"] = l_iBase;
            l_drNew["desbase"] = cdlBases.Text;
            m_dtRelaciones.Rows.Add(l_drNew);

            // Quitamos el item de las listas
            RemoveListItem(cdlExcel, l_iExcel);
            RemoveListItem(cdlBases, l_iBase);

            // Recargamos la grilla
            FillGrid();
        }

        // Evento del click del boton de vista previa.
        private void cmdVPrevia_Click(object sender, EventArgs e)
        {
            // Buscamos solo 7 registros
            ListaEntidades l_leListaEntidades = MakeExcel(7);
            if (l_leListaEntidades == null) return;

            // Llenamos la grilla
            grdVPrevia.Enabled = true;
            grdVPrevia.FillFromLEntidad(l_leListaEntidades);
            cmdImportar.Enabled = true;
        }

        // Evento del click del boton de importar.
        private void cmdImportar_Click(object sender, EventArgs e)
        {
            // Cargamos la planilla completa
            ListaEntidades l_leListaEntidades = MakeExcel(-1);
            if (l_leListaEntidades == null) return;

            // Armamos la tabla de equivalencias
            string l_strCampos = "";

            foreach (DataRow l_drItem in m_dtRelaciones.Rows)
            {
                // Agregamos el valor cada columna indicada
                l_strCampos += (((int)l_drItem["codexcel"]).ToString() + "@@");
                l_strCampos += (((int)l_drItem["codbase"]).ToString() + "@@");
                l_strCampos += (((string)l_drItem["desexcel"]) + "@@");
                l_strCampos += (((string)l_drItem["desbase"]) + "@@");
            }

            // Avisamos al usuario cuantos registros vamos a procesar
            if (MsgRuts.AskUser(this, String.Format("Se recuperaron {0} registro(s) para incorporar \r\n" +
                                                    "al sistema. ¿Confirma?", l_leListaEntidades.Count)) == DialogResult.No) return;

            // Reportamos comienzo.
            App.ShowMsg("Grabando...");
            App.InitAdvance("Grabando");

            // Capturamos el evento y llamamos al metodo que tiene la logica.
            Bll.Clientes.Advance += new BllReportEventHandler(Clientes_Advance);
            ListaEntidades l_leClientesRechazados = cargadorCliente.importarYDevolverRechazados(l_leListaEntidades, m_smResult);
            Bll.Clientes.Advance -= new BllReportEventHandler(Clientes_Advance);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            App.EndAdvance();
            App.HideMsg();

            if (l_leClientesRechazados.Count == 0)
            {
                // Todo OK.
                MsgRuts.ShowMsg(this, "Todos los registros se han incorporado al sistema exitosamente.");
                l_leListaEntidades.Dispose();
                Close();
            }
            else
            {
                MsgRuts.ShowMsg(this, "Algunos registros se han incorporado al sistema exitosamente.");
                ExcelErroneos l_fMuestraErroneos = new ExcelErroneos(l_leClientesRechazados, cargadorCliente);
                l_fMuestraErroneos.ShowDialog(this);
            }
        }

        // Evento del click del boton cancelar.
        private void gbCancelar_Click(object sender, EventArgs e)
        {
            // Pasamos a modo operaciones
            SwitchTo(FormModes.Operations);
            txtPlanilla.Focus();
        }

        #endregion

        // Llena la grilla de equivalencias
        private void FillGrid()
        {
            // Recargamos la lista en la grilla
            ListaEntidades l_lentData = new ListaEntidades(m_dtRelaciones);

            l_lentData.ClearCaptions();
            l_lentData.ChangeCaption("codexcel", "V1Indice1NN1");
            l_lentData.ChangeCaption("codbase", "V1Indice2NN1");
            l_lentData.ChangeCaption("desexcel", "V1Campo del ExcelCN1");
            l_lentData.ChangeCaption("desbase", "V1Campo de la BaseCN1");
            grdRelaciones.Enabled = true;
            grdRelaciones.Focus();
            l_lentData.Sort("desbase");
            grdRelaciones.FillFromLEntidad(l_lentData, false);
            l_lentData.Dispose();

            // Borramos la vista previa
            grdVPrevia.Focus();
            grdVPrevia.Clear();
            cmdImportar.Enabled = false;
            cdlExcel.Focus();
        }

        // Carga la planilla Excel
        private ListaEntidades MakeExcel(int p_iQtyRows)
        {
            // Procesamos el excel
            ListaEntidades l_leListaEntidades = null;
            Entidad l_eEntidad = null;
            cargadorCliente.fillVariablesTipadas(ref l_leListaEntidades, ref l_eEntidad);

            App.ShowMsg("Leyendo el listado...");

            WRPXlsx l_wrExcel = new WRPXlsx(txtPlanilla.Text, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return null;

            ExcelWorksheet l_oHoja = l_wrExcel.GetSheet(1, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return null;


            if (p_iQtyRows == -1)
            {
                // Solo en lectura completa
                MsgRuts.DoACancel += new EventHandler(DoACancel);
                MsgRuts.ShowW4C("Leyendo el listado...");
            }

            // Recorremos las filas
            int l_iRow = 1, l_iValor = 0;
            object l_oValue = null;
            string l_strValor = "";
            decimal l_dValor = 0;
            DateTime l_dtValor;

            try
            {
                while (true)
                {
                    // Si hay que cortar
                    if ((p_iQtyRows != -1) && (l_iRow > p_iQtyRows)) break;
                    if (m_bCancel) break;

                    // Por cada fila del excel recuperamos la primer columna
                    l_oValue = l_wrExcel.GetCell(ref l_oHoja, l_iRow + 1, 1, m_smResult);
                    if (MsgRuts.AnalizeError(this, m_smResult)) return null;

                    l_strValor = "";
                    if (l_oValue != null) l_strValor = l_oValue.ToString();
                    if (l_strValor.Trim() == "") break;

                    // Informamos al usuario
                    if (((l_iRow - 1) % 100) == 0)
                        App.ShowMsg("Leyendo el padrón (" + l_iRow.ToString() + ")...");


                    m_dtRelaciones.DefaultView.Sort = "codbase";

                    foreach (DataRowView l_drvItem in m_dtRelaciones.DefaultView)
                    {
                        // Recuperamos el valor cada columna indicada
                        l_oValue = l_wrExcel.GetCell(ref l_oHoja, l_iRow + 1, (int)l_drvItem["codexcel"], m_smResult);
                        if (MsgRuts.AnalizeError(this, m_smResult)) return null;

                        l_strValor = "";
                        if (l_oValue != null) l_strValor = l_oValue.ToString();

                        l_iValor = Ruts.MakeInteger(l_strValor, 0);
                        l_dValor = Ruts.MakeDecimal(l_strValor, 0);

                        try
                        {
                            l_dtValor = (DateTime)l_oValue;
                        }
                        catch (Exception)
                        {
                            try
                            {
                                l_dtValor = DateTimeRuts.MakeDate(l_strValor);
                            }
                            catch (Exception)
                            {
                                l_dtValor = DateTimeRuts.Empty;
                            }
                        }

                        cargadorCliente.fillAttribute(l_eEntidad, l_iValor, l_strValor, l_dtValor, l_dValor, l_drvItem);
                    }

                    cargadorCliente.valoresFijosAndAdd(l_leListaEntidades, l_eEntidad, (p_iQtyRows == -1));
                    l_iRow++;
                }
            }
            finally
            {
                // Cerramos la ventana de wait
                if (p_iQtyRows == -1)
                {
                    // Solo en lectura completa
                    MsgRuts.CloseW4CorW();
                    MsgRuts.DoACancel -= new EventHandler(DoACancel);
                }
            }

            // Cerramos el excel
            App.HideMsg();

            // Devolvemos la lista captionada
            cargadorCliente.captionamos(l_leListaEntidades);
            return l_leListaEntidades;
        }

        // Remueve un item de la lista de pantalla
        private void RemoveListItem(CDList p_cdlControl,
                                    int p_iIndex)
        {
            foreach (CodDesItems l_cdiItem in p_cdlControl.Items)
            {
                // Si lo encontramos 
                if (l_cdiItem.IntCode == p_iIndex)
                {
                    // Lo removemos
                    p_cdlControl.Items.Remove(l_cdiItem);
                    return;
                }
            }
        }

        // Cambia el modo del formulario
        private void SwitchTo(FormModes p_fmNewMode)
        {
            // Fijamos el nuevo modo del formulario
            switch (p_fmNewMode)
            {
                case FormModes.Operations: { OperationMode(); break; }
                case FormModes.Process: { ProcessMode(); break; }
                default: { MsgRuts.ShowMsg(this, "Invalid mode"); break; }
            }
        }

        // Pone el formulario en modo: Operaciones
        private void OperationMode()
        {
            // Deshabilitamos el frame
            cdlExcel.Enabled = false;
            cdlBases.Enabled = false;
            gbNuevo.Enabled = false;
            cmdBorrar.Enabled = false;
            grdRelaciones.Focus();
            grdRelaciones.Clear();
            grdRelaciones.Enabled = false;
            grdVPrevia.Focus();
            grdVPrevia.Clear();
            grdVPrevia.Enabled = false;
            cmdVPrevia.Enabled = false;
            cmdImportar.Enabled = false;
            gbCancelar.Enabled = false;

            // Blanqueamos los campos
            cdlExcel.Items.Clear();
            cdlBases.Items.Clear();
            txtPlanilla.Text = "";

            // Vaciamos la tabla de relaciones
            m_dtRelaciones.Rows.Clear();

            // Habilitamos los controles operativos
            txtPlanilla.NormalDisable = true;
            txtPlanilla.Enabled = true;
            cmdFind.Enabled = true;
            cmdConfirmar.Enabled = true;

        }

        // Pone el formulario en modo: Edicion
        private void ProcessMode()
        {
            // Habilitamos el frame
            cdlExcel.Enabled = true;
            cdlBases.Enabled = true;
            gbNuevo.Enabled = true;
            cmdBorrar.Enabled = true;
            grdRelaciones.Enabled = true;
            grdVPrevia.Enabled = false;
            cmdVPrevia.Enabled = true;
            cmdImportar.Enabled = false;
            gbCancelar.Enabled = true;

            // Desabilitamos los controles operativos
            txtPlanilla.NormalDisable = false;
            txtPlanilla.Enabled = false;
            cmdFind.Enabled = false;
            cmdConfirmar.Enabled = false;
        }


        void Clientes_Advance(object sender, BllReportEventArgs e)
        {
            App.Advance(e.Percent);
        }

        // Cancelaron la impresion
        void DoACancel(object sender, EventArgs e)
        {
            m_bCancel = true;
        }

    }
}
