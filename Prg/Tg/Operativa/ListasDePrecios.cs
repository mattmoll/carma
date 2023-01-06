#region Usings
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using WeifenLuo.WinFormsUI.Docking;
using TNGS.NetRoutines;
using TNGS.NetControls;
using TNGS.NetApp;
using Carm;
#endregion

namespace Carm.Tg
{
    //----------------------------------------------------------------------------
    //                         TNG Software UIL Generator
    //----------------------------------------------------------------------------
    // Fecha                     : 04/01/2023 00:11
    // Sistema                   : Carm
    // Interface para la Entidad : ListaDePrecios
    // Tipo de Interface         : Mantenimiento de Tabla Clasificadora
    //----------------------------------------------------------------------------
    // © 1996-2023 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    /// <summary>
    /// Formulario para Mantenimiento de la Tabla:ListasDePrecios
    /// </summary>
    public partial class ListasDePrecios : DockContent
    {
        #region Miembros de la Clase
            private Bel.EListaDePrecios m_entListaDePrecios= null;
            private StatMsg m_smResult= null;
            private ACLInfo m_aclInfo= null;
            private string m_strSort= "";
        #endregion

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public ListasDePrecios()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            // Obtenemos los permisos ACL
            m_aclInfo= App.ACLInfo;

            // Aplicamos los nieves de seguridad
            App.ApplySecurity(this);

            // Iniciamos los objetos de la clase
            m_smResult= new StatMsg();

            // Fijamos el modo Skin
            xpnlBase.SkinFixed= App.WithSkin;
            frmEdicion.SkinFixed= App.WithSkin;
            grdDatos.SkinFixed= App.WithSkin;

            // Dockeamos el formulario
            ((MainFrame) App.GetMainWindow()).AddContent(this);

            // Fijamos la imagen del Frm de edicion
            frmEdicion.GroupImage= Icon.ToBitmap();
        }

        //--------------------------------------------------------------
        // Eventos del formulario y los controles
        //--------------------------------------------------------------

        /// <summary>
        /// Carga del Formulario
        /// </summary>
        private void ListasDePrecios_Load(object sender, System.EventArgs e)
        {
            // Inicializamos el form
            App.ShowMsg("Inicializando el formulario...");

            // Llenamos las Combos (por Tablas)
            Bel.LEPlanes l_lentPlanes= Bll.Planes.UpFull(false, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;
            cmbCodplan.FillFromStrLEntidad(l_lentPlanes, Bel.EPlan.CodCmp, Bel.EPlan.DesCmp, "deleted");

            Bel.LEMarcas l_lentMarcas= Bll.Tablas.MrcUpFull(false, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;
            cmbCodmarca.FillFromStrLEntidad(l_lentMarcas, Bel.EMarca.CodCmp, Bel.EMarca.DesCmp, "deleted");

            // Pasamos a modo Operaciones, llenamos la grilla y 
            // damos foco al primer campo
            SwitchTo(FormModes.Operations, GridOps.Fill);
            grdDatos.Focus();

            // Todo listo
            App.HideMsg();
        }

        /// <summary>
        /// Cierre del formulario
        /// </summary>
        private void ListasDePrecios_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Liberamos el menu
            App.LockMenu(false);
        }

        /// <summary>
        /// Reporte del estado de avance de la grilla
        /// </summary>
        private void grdDatos_Advance(object sender, TNGS.NetRoutines.AdvanceEventArgs e)
        {
            // Marcamos el estado de avance de la operacion en la grilla
            App.Advance(e.Percent);
        }

        /// <summary>
        /// Dobleclick en la grilla
        /// </summary>
        private void grdDatos_DataDClick(object sender, DataDClicEventArgs e)
        {
            // Simulamos modificar
            cmdModificar_Click(this, EventArgs.Empty);
        }

        /// <summary>
        /// Dieron click en el header de la grilla
        /// </summary>
        private void grdDatos_HeaderClick(object sender, MouseEventArgs e)
        {
            // Si es boton izquierdo
            if (e.Button == MouseButtons.Left) {
                // Si cambio el sort simple
                if (m_strSort != grdDatos.GridOrder) {
                    // Grabamos el nuevo sort
                    m_strSort= grdDatos.GridOrder;
                    App.SetStrURegistry(false, "GridFormat", "ListasDePreciosGrdSort", m_strSort);
                    return;
                }
            }

            // Si es boton derecho
            if (e.Button == MouseButtons.Right) {
                // Si cambio el sort simple
                if (m_strSort != "") {
                    // Quitamos el orden, grabamos y recargamos
                    m_strSort= "";
                    App.SetStrURegistry(false, "GridFormat", "ListasDePreciosGrdSort", m_strSort);
                    FillGrid();
                    return;
                }
            }
        }

        /// <summary>
        /// Cambio el ancho de la columnas
        /// </summary>
        private void GrdColumn_WidthChanged(object sender, EventArgs e)
        {
            // Guardamos el ancho de las columnas
            App.SetStrURegistry(false, "GridFormat", "ListasDePreciosGrdWidths", grdDatos.ColWitdhs);
        }

        //--------------------------------------------------------------
        // Operaciones
        //--------------------------------------------------------------

        /// <summary>
        /// Exporta la grilla en Excel
        /// </summary>
        private void cmdExcel_Click(object sender, System.EventArgs e)
        {
            App.ShowMsg("Generando planilla...");
            App.InitAdvance("Excel:");
            grdDatos.ExportToExcel(false, false, "", "ListasDePrecios", m_smResult);
            App.EndAdvance();
            App.HideMsg();
        }

        /// <summary>
        /// Imprime la grilla
        /// </summary>
        private void cmdPrint_Click(object sender, System.EventArgs e)
        {
            App.ShowMsg("Imprimiendo datos...");
            App.InitAdvance("Imprimiendo:");
            grdDatos.Print(Shr.ROParam.Empresa.VStr, App.Programa.Nombre,
                           "Lista de ListasDePrecios", "");
            App.EndAdvance();
            App.HideMsg();
        }

        /// <summary>
        /// Genera un Nuevo registro en la tabla
        /// </summary>
        private void cmdNuevo_Click(object sender, System.EventArgs e)
        {
            // Creamos una nueva entidad, pasamos a modo de edicion y
            // damos foco al primer campo
            m_entListaDePrecios= Bel.EListaDePrecios.NewEmpty();
            SwitchTo(FormModes.Edit, GridOps.DontFill);
            txtCod.Focus();
        }

        /// <summary>
        /// Modifica el registro seleccionado de la grilla
        /// </summary>
        private void cmdModificar_Click(object sender, System.EventArgs e)
        {
            // Si no hay item seleccionado -> salimos
            int l_iRow= grdDatos.CurrentRowIndex;
            if (l_iRow == -1) return;

            // Obtenemos la entidad del item seleccionado en la grilla
            App.ShowMsg("Recuperando Datos...");
            m_entListaDePrecios= Bll.Tablas.LprGet((string) grdDatos.GetMatrixValueObj(l_iRow, 1),
                                                   false, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            // Tenemos la entidad. Pasamos a modo de edicion y damos foco
            // al campo que corresponda
            SwitchTo(FormModes.Edit, GridOps.DontFill);
            if (m_entListaDePrecios.EstaBorrada) {
                cmdCancelar.Focus();
            }
            else {
                cmbCodplan.Focus();
            }
            App.HideMsg();
        }

        /// <summary>
        /// Purga los registros deshabilitados
        /// </summary>
        private void cmdPurgar_Click(object sender, EventArgs e)
        {
            // Pedimos una confirmacion
            if (MsgRuts.AskUser(this, "Atención!!!!\r\n" +
                                      "La compactación de la tabla borra en forma " +
                                      "definitiva los items deshabilitados. " +
                                      "¿Confirma la compactación?",
                                      /*App.Usuario.Usuario +*/ "ListasDePreciosPurge") == DialogResult.No) return;

            // Purgamos la tabla
            App.ShowMsg("Compactando la tabla...");
            Bll.Tablas.LprPurge(m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            // Terminamos
            App.HideMsg();
            MsgRuts.ShowMsg(this, "La tabla ha sido compactada.");
            FillGrid();
        }

        /// <summary>
        /// Finaliza el formulario
        /// </summary>
        private void cmdSalir_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Cancela la edicion
        /// </summary>
        private void cmdCancelar_Click(object sender, System.EventArgs e)
        {
            // Pasamos a modo Operaciones y damos foco a la grilla
            SwitchTo(FormModes.Operations, GridOps.DontFill);
            grdDatos.Focus();
        }

        /// <summary>
        /// Habilita/Deshabilita el registro
        /// </summary>
        private void cmdDesHab_Click(object sender, System.EventArgs e)
        {
            // Realizamos la operacion
            App.ShowMsg("Procesando...");
            Bll.Tablas.LprEnabled(m_entListaDePrecios.EstaBorrada,
                                  m_entListaDePrecios.Cod,
                                  m_entListaDePrecios.FxdVersion,
                                  m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            // Pasamos a modo Operaciones, rellenamos la grilla y 
            // le damos foco
            SwitchTo(FormModes.Operations, GridOps.Fill);
            grdDatos.Focus();
            App.HideMsg();
        }

        /// <summary>
        /// Graba el registro en edicion
        /// </summary>
        private void cmdGrabar_Click(object sender, System.EventArgs e)
        {
            // Pasamos los datos a la Entidad
            m_entListaDePrecios.Cod= txtCod.Text;
            m_entListaDePrecios.Des= txtDes.Text;
            m_entListaDePrecios.Codplan= cmbCodplan.SelectedStrCode;
            m_entListaDePrecios.Codmarca= cmbCodmarca.SelectedStrCode;
            m_entListaDePrecios.Precio1p= txtPrecio1p.Decimal;
            m_entListaDePrecios.Precio2p= txtPrecio2p.Decimal;
            m_entListaDePrecios.Precio3p= txtPrecio3p.Decimal;
            m_entListaDePrecios.Precio4p= txtPrecio4p.Decimal;
            m_entListaDePrecios.Precio5p= txtPrecio5p.Decimal;
            m_entListaDePrecios.Precio6p= txtPrecio6p.Decimal;
            m_entListaDePrecios.Precio7p= txtPrecio7p.Decimal;
            m_entListaDePrecios.Precio8p= txtPrecio8p.Decimal;
            m_entListaDePrecios.Precio9p= txtPrecio9p.Decimal;
            m_entListaDePrecios.Precio10p= txtPrecio10p.Decimal;

            // Tratamos de grabar la entidad
            App.ShowMsg("Grabando...");
            Bll.Tablas.LprSave(m_entListaDePrecios, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            // Pasamos a modo Operaciones, rellenamos la grilla y 
            // le damos foco
            SwitchTo(FormModes.Operations, GridOps.Fill);
            grdDatos.Focus();
            App.HideMsg();
        }

        //--------------------------------------------------------------
        // Metodos privados
        //--------------------------------------------------------------

        /// <summary>
        /// Llena la grilla con los datos de la tabla
        /// </summary>
        private void FillGrid()
        {
            // Recuperamos los datos para la grilla
            App.ShowMsg("Recuperando datos...");
            Bel.LEListasDePrecios l_lentListasDePrecios= Bll.Tablas.LprUpFull(false, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            // Asignamos a la grilla
            App.InitAdvance("Cargando:");
            grdDatos.Focus();
            grdDatos.FillFromLEntidad(l_lentListasDePrecios, "deleted");
            grdDatos.ColWitdhs= App.GetStrURegistry(false, "GridFormat", "ListasDePreciosGrdWidths", "");
            grdDatos.GridOrder= App.GetStrURegistry(false, "GridFormat", "ListasDePreciosGrdSort", "");
            App.EndAdvance();

            // Fijamos el evento de cambio de ancho de la grilla
            if (l_lentListasDePrecios.Count > 0)
                foreach (DataGridColumnStyle l_dcsItem in grdDatos.TableStyles[0].GridColumnStyles)
                    l_dcsItem.WidthChanged += new EventHandler(GrdColumn_WidthChanged);

            // Ya la llenamos
            App.HideMsg();
        }

        /// <summary>
        /// Cambia el modo del formulario
        /// </summary>
        private void SwitchTo(FormModes p_fmNewMode, GridOps p_goNewGState)
        {
            // Fijamos el nuevo modo del formulario
            switch (p_fmNewMode) {
                case FormModes.Operations   : {OperationMode(); break;}
                case FormModes.Edit         : {EditMode(); break;}
                default                     : {MsgRuts.ShowMsg(this, "Invalid mode"); break;}
            }

            // Fijamos el nuevo estado de la grilla
            switch (p_goNewGState) {
                case GridOps.Fill   : {FillGrid(); break;}
                default             : {break;}
            }
        }

        /// <summary>
        /// Pone el formulario en modo: Operaciones
        /// </summary>
        private void OperationMode()
        {
            // Deshabilitamos el frame
            txtCod.NormalDisable= true;
            txtCod.Enabled= false;
            txtDes.NormalDisable= true;
            txtDes.Enabled= false;
            cmbCodplan.NormalDisable= true;
            cmbCodplan.Enabled= false;
            cmbCodmarca.NormalDisable= true;
            cmbCodmarca.Enabled= false;
            txtPrecio1p.NormalDisable= true;
            txtPrecio1p.Enabled= false;
            txtPrecio2p.NormalDisable= true;
            txtPrecio2p.Enabled= false;
            txtPrecio3p.NormalDisable= true;
            txtPrecio3p.Enabled= false;
            txtPrecio4p.NormalDisable= true;
            txtPrecio4p.Enabled= false;
            txtPrecio5p.NormalDisable= true;
            txtPrecio5p.Enabled= false;
            txtPrecio6p.NormalDisable= true;
            txtPrecio6p.Enabled= false;
            txtPrecio7p.NormalDisable= true;
            txtPrecio7p.Enabled= false;
            txtPrecio8p.NormalDisable= true;
            txtPrecio8p.Enabled= false;
            txtPrecio9p.NormalDisable= true;
            txtPrecio9p.Enabled= false;
            txtPrecio10p.NormalDisable= true;
            txtPrecio10p.Enabled= false;
            cmdCancelar.Enabled= false;
            cmdGrabar.Enabled= false;
            cmdDesHab.Enabled= false;
            cmdHab.Enabled= false;

            // Blanqueamos los campos
            txtCod.Text= "";
            txtDes.Text= "";
            cmbCodplan.SelectedStrCode= "";
            cmbCodmarca.SelectedStrCode= "";
            txtPrecio1p.Decimal= 0;
            txtPrecio2p.Decimal= 0;
            txtPrecio3p.Decimal= 0;
            txtPrecio4p.Decimal= 0;
            txtPrecio5p.Decimal= 0;
            txtPrecio6p.Decimal= 0;
            txtPrecio7p.Decimal= 0;
            txtPrecio8p.Decimal= 0;
            txtPrecio9p.Decimal= 0;
            txtPrecio10p.Decimal= 0;

            // Habilitamos la grilla y los controles operativos
            cmdNuevo.Enabled= true;
            cmdModificar.Enabled= true;
            cmdPurgar.Enabled= true;
            cmdSalir.Enabled= true;
            cmdPrint.Enabled= true;
            cmdExcel.Enabled= true;
            grdDatos.Enabled= true;

            // Procesamos los comandos ACL
            cmdNuevo.Visible= ((m_aclInfo[0].VStr == "S") || (m_aclInfo[1].VStr == "S"));
            cmdModificar.Visible= ((m_aclInfo[0].VStr == "S") || (m_aclInfo[3].VStr == "S"));
            cmdPurgar.Visible= ((m_aclInfo[0].VStr == "S") || (m_aclInfo[5].VStr == "S"));

            // El ESC sale del formulario
            CancelButton= cmdSalir;
        }

        /// <summary>
        /// Pone el formulario en modo: Edicion
        /// </summary>
        private void EditMode()
        {
            // Llenamos los campos a partir de la entidad a editar
            txtCod.Text= m_entListaDePrecios.Cod;
            txtDes.Text= m_entListaDePrecios.Des;
            cmbCodplan.SelectedStrCode= m_entListaDePrecios.Codplan;
            cmbCodmarca.SelectedStrCode= m_entListaDePrecios.Codmarca;
            txtPrecio1p.Decimal= m_entListaDePrecios.Precio1p;
            txtPrecio2p.Decimal= m_entListaDePrecios.Precio2p;
            txtPrecio3p.Decimal= m_entListaDePrecios.Precio3p;
            txtPrecio4p.Decimal= m_entListaDePrecios.Precio4p;
            txtPrecio5p.Decimal= m_entListaDePrecios.Precio5p;
            txtPrecio6p.Decimal= m_entListaDePrecios.Precio6p;
            txtPrecio7p.Decimal= m_entListaDePrecios.Precio7p;
            txtPrecio8p.Decimal= m_entListaDePrecios.Precio8p;
            txtPrecio9p.Decimal= m_entListaDePrecios.Precio9p;
            txtPrecio10p.Decimal= m_entListaDePrecios.Precio10p;

            // Habilitamos el frame
            txtCod.NormalDisable= false;
            txtCod.Enabled= m_entListaDePrecios.EsNueva;
            txtDes.NormalDisable= false;
            txtDes.Enabled= m_entListaDePrecios.EsNueva;
            cmbCodplan.NormalDisable= false;
            cmbCodplan.Enabled= !m_entListaDePrecios.EstaBorrada;
            cmbCodmarca.NormalDisable= false;
            cmbCodmarca.Enabled= !m_entListaDePrecios.EstaBorrada;
            txtPrecio1p.NormalDisable= false;
            txtPrecio1p.Enabled= !m_entListaDePrecios.EstaBorrada;
            txtPrecio2p.NormalDisable= false;
            txtPrecio2p.Enabled= !m_entListaDePrecios.EstaBorrada;
            txtPrecio3p.NormalDisable= false;
            txtPrecio3p.Enabled= !m_entListaDePrecios.EstaBorrada;
            txtPrecio4p.NormalDisable= false;
            txtPrecio4p.Enabled= !m_entListaDePrecios.EstaBorrada;
            txtPrecio5p.NormalDisable= false;
            txtPrecio5p.Enabled= !m_entListaDePrecios.EstaBorrada;
            txtPrecio6p.NormalDisable= false;
            txtPrecio6p.Enabled= !m_entListaDePrecios.EstaBorrada;
            txtPrecio7p.NormalDisable= false;
            txtPrecio7p.Enabled= !m_entListaDePrecios.EstaBorrada;
            txtPrecio8p.NormalDisable= false;
            txtPrecio8p.Enabled= !m_entListaDePrecios.EstaBorrada;
            txtPrecio9p.NormalDisable= false;
            txtPrecio9p.Enabled= !m_entListaDePrecios.EstaBorrada;
            txtPrecio10p.NormalDisable= false;
            txtPrecio10p.Enabled= !m_entListaDePrecios.EstaBorrada;
            cmdCancelar.Enabled= true;
            cmdGrabar.Enabled= !m_entListaDePrecios.EstaBorrada;
            cmdDesHab.Enabled= ((!m_entListaDePrecios.EsNueva) &&(!m_entListaDePrecios.EstaBorrada));
            cmdHab.Enabled= !cmdDesHab.Enabled;

            // Procesamos los comandos ACL
            cmdHab.Visible= ((m_aclInfo[0].VStr == "S") || (m_aclInfo[4].VStr == "S"));
            cmdDesHab.Visible= ((m_aclInfo[0].VStr == "S") || (m_aclInfo[2].VStr == "S"));

            // Dehabilitamos la grilla y los controles operativos
            cmdNuevo.Enabled= false;
            cmdModificar.Enabled= false;
            cmdPurgar.Enabled= false;
            cmdSalir.Enabled= false;
            cmdPrint.Enabled= false;
            cmdExcel.Enabled= false;
            grdDatos.Enabled= false;

            // El ESC sale de la edicion
            CancelButton= cmdCancelar;
        }
    }
}
