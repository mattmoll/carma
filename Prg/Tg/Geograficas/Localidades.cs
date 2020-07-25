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

namespace Carm.Tg
{
    //----------------------------------------------------------------------------
    //                         TNG Software UIL Generator
    //----------------------------------------------------------------------------
    // Fecha                     : 28/10/2008 14:26
    // Sistema                   : Cedi
    // Interface para la Entidad : Localidad
    // Tipo de Interface         : Mantenimiento de Tabla Clasificadora
    //----------------------------------------------------------------------------
    // © 1996-2008 by TNG Software                                      Gndr 4.84
    //----------------------------------------------------------------------------

    /// <summary>
    /// Formulario para Mantenimiento de la Tabla:Localidades
    /// </summary>
    public partial class Localidades : DockContent
    {
        #region Miembros de la Clase
            private Bel.ELocalidad m_entLocalidad= null;
            private StatMsg m_smResult= null;
            private ACLInfo m_aclInfo= null;
            private string m_strSort= "";
            private bool m_bNoAct= false;
        #endregion

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public Localidades()
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
            frmData.SkinFixed= App.WithSkin;
            frmEdicion.SkinFixed= App.WithSkin;
            frmOper.SkinFixed= App.WithSkin;
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
        private void Localidades_Load(object sender, System.EventArgs e)
        {
            // Inicializamos el form
            App.ShowMsg("Inicializando el formulario...");

            // Llenamos las Combos (por Tablas)
            Bel.LEZonas l_lentZonas= Bll.Tablas.ZnsUpFull(false, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;
            cmbZona.FillFromStrLEntidad(l_lentZonas, "zns_rcd_cod", "zns_des_nombre", "deleted");

            m_bNoAct= true;
            // Traemos las provincias y las cargamos.
            ListaEntidades l_leProvincias = Bll.Tablas.LocGetProvincias(m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;
            cmbProvincia.FillFromStrLEntidad(l_leProvincias, "loc_des_provincia", "loc_des_provincia", "deleted");
            cmbProvincia.SelectedStrCode= "";
            m_bNoAct= false;

            // Llenamos las combos fijas
            cmbDirecta.AddStrCD("S", "SI", 0);
            cmbDirecta.AddStrCD("N", "NO", 0);

            // Pasamos a modo Operaciones, llenamos la grilla y 
            // damos foco al primer campo
            SwitchTo(FormModes.Operations, GridOps.DontFill);
            cmbProvincia.SelectedIndex= 0;
            grdDatos.Focus();

            // Todo listo
            App.HideMsg();
        }

        /// <summary>
        /// Cierre del formulario
        /// </summary>
        private void Localidades_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Liberamos el menu
            App.LockMenu(false);
        }

        /// <summary>
        /// Cambio la provincia
        /// </summary>
        private void cmbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Validamos
            if (m_bNoAct) return;

            // Cargamos la lista de partidos
            ListaEntidades l_lentPart= Bll.Tablas.LocGetPartidos(cmbProvincia.Text, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;
            m_bNoAct= true;
            cmbPartido.FillFromStrLEntidad(l_lentPart, "loc_ede_partido", "loc_ede_partido", "deleted");
            cmbPartido.SelectedStrCode= "";
            m_bNoAct= false;

            // Forzamos el primero
            grdDatos.Clear();
            if (l_lentPart.Count > 0)
                cmbPartido.SelectedIndex= 0;
        }

        /// <summary>
        /// Cambio el partido
        /// </summary>
        private void cmbPartido_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Validamos
            if (m_bNoAct) return;

            // Cargamos la grilla
            FillGrid();
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
            gbModificar_Click(this, EventArgs.Empty);
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
                    App.SetStrURegistry(false, "GridFormat", App.Usuario.Usuario + "LocalidadesGrdSort", m_strSort);
                    return;
                }
            }

            // Si es boton derecho
            if (e.Button == MouseButtons.Right) {
                // Si cambio el sort simple
                if (m_strSort != "") {
                    // Quitamos el orden, grabamos y recargamos
                    m_strSort= "";
                    App.SetStrURegistry(false, "GridFormat", App.Usuario.Usuario + "LocalidadesGrdSort", m_strSort);
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
            App.SetStrURegistry(false, "GridFormat", App.Usuario.Usuario + "LocalidadesGrdWidths", grdDatos.ColWitdhs);
        }

        //--------------------------------------------------------------
        // Operaciones
        //--------------------------------------------------------------

        /// <summary>
        /// Permitir agregar partido
        /// </summary>
        private void cmdNewPart_Click(object sender, EventArgs e)
        {
            // Dehabilitamos todo
            cmbProvincia.Enabled= false;
            cmbPartido.Enabled= false;
            cmdNewPart.Enabled= false;
            cmdExcel.Enabled= false;
            cmdPrint.Enabled= false;
            grdDatos.Enabled= false;
            gbNuevo.Enabled= false;
            gbModificar.Enabled= false;

            // Habilitamos edicion
            txtNewPartido.Enabled= true;
            cmdSvNPart.Enabled= true;
            cmdCanNPart.Enabled= true;
            txtNewPartido.Focus();
        }

        /// <summary>
        /// Cancelar nuevo partido
        /// </summary>
        private void cmdCanNPart_Click(object sender, EventArgs e)
        {
            // Habilitamos todo
            cmbProvincia.Enabled= true;
            cmbPartido.Enabled= true;
            cmdExcel.Enabled= true;
            cmdPrint.Enabled= true;
            grdDatos.Enabled= true;
            cmdNewPart.Enabled= true;
            gbNuevo.Enabled= true;
            gbModificar.Enabled= true;

            // Habilitamos edicion
            txtNewPartido.Enabled= false;
            txtNewPartido.Text= "";
            cmdSvNPart.Enabled= false;
            cmdCanNPart.Enabled= false;
            cmbPartido.Focus();
        }

        /// <summary>
        /// Confirmaron el nuevo partido
        /// </summary>
        private void cmdSvNPart_Click(object sender, EventArgs e)
        {
            // Validamos
            string l_strPartido= txtNewPartido.Text.Trim();
            if (l_strPartido.Length < 4) {
                // Error
                MsgRuts.ShowMsg(this, "Deben ingresarse al menos 4 caracteres");
                return;
            }

            // Lo agregamos
            cmbPartido.AddStrCD(l_strPartido, l_strPartido, 0);
            cmbPartido.SelectedStrCode= l_strPartido;
            cmdCanNPart_Click(sender, e);
        }

        /// <summary>
        /// Exporta la grilla en Excel
        /// </summary>
        private void cmdExcel_Click(object sender, System.EventArgs e)
        {
            App.ShowMsg("Generando planilla...");
            App.InitAdvance("Excel:");
            grdDatos.ExportToExcel(false, false, "", "Localidades", m_smResult);
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
                           "Lista de Localidades", "");
            App.EndAdvance();
            App.HideMsg();
        }

        /// <summary>
        /// Genera un Nuevo registro en la tabla
        /// </summary>
        private void gbNuevo_Click(object sender, System.EventArgs e)
        {
            // Creamos una nueva entidad, pasamos a modo de edicion y
            // damos foco al primer campo
            m_entLocalidad= Bel.ELocalidad.NewEmpty();
            m_entLocalidad.Codpost = txtCodPostal.Text;
            m_entLocalidad.Provincia= cmbProvincia.Text;
            m_entLocalidad.Partido= cmbPartido.Text;
            SwitchTo(FormModes.Edit, GridOps.DontFill);
            txtCodPostal.Focus();
        }

        /// <summary>
        /// Modifica el registro seleccionado de la grilla
        /// </summary>
        private void gbModificar_Click(object sender, System.EventArgs e)
        {
            // Si no hay item seleccionado -> salimos
            int l_iRow= grdDatos.CurrentRowIndex;
            if (l_iRow == -1) return;

            // Obtenemos la entidad del item seleccionado en la grilla
            App.ShowMsg("Recuperando Datos...");
            m_entLocalidad= Bll.Tablas.LocGet((string) grdDatos.GetMatrixValueObj(l_iRow, 1),
                                                  false, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            // Tenemos la entidad. Pasamos a modo de edicion y damos foco
            // al campo que corresponda
            SwitchTo(FormModes.Edit, GridOps.DontFill);
            if (m_entLocalidad.EstaBorrada) {
                gbCancelar.Focus();
            }
            else {
                txtCodPostal.Focus();
            }
            App.HideMsg();
        }

        /// <summary>
        /// Finaliza el formulario
        /// </summary>
        private void gbSalir_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Cancela la edicion
        /// </summary>
        private void gbCancelar_Click(object sender, System.EventArgs e)
        {
            // Pasamos a modo Operaciones y damos foco a la grilla
            SwitchTo(FormModes.Operations, GridOps.DontFill);
            grdDatos.Focus();
        }

        /// <summary>
        /// Habilita/Deshabilita el registro
        /// </summary>
        private void gbChangeHabilitado_Click(object sender, System.EventArgs e)
        {
            // Realizamos la operacion
            App.ShowMsg("Procesando...");
            Bll.Tablas.LocEnabled(m_entLocalidad.EstaBorrada,
                                      m_entLocalidad.Codpost,
                                      m_entLocalidad.FxdVersion,
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
        private void gbGrabar_Click(object sender, System.EventArgs e)
        {
            // Pasamos los datos a la Entidad
            m_entLocalidad.Codpost = txtCodPostal.Text;
            m_entLocalidad.Nombre= txtDescripcion.Text;
            m_entLocalidad.Codzona= cmbZona.SelectedStrCode;
            m_entLocalidad.Directa= cmbDirecta.SelectedStrCode;

            // Tratamos de grabar la entidad
            App.ShowMsg("Grabando...");
            Bll.Tablas.LocSave(m_entLocalidad, m_smResult);
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
            Bel.LELocalidades l_lentLocalidades= 
                Bll.Tablas.LocUpFullByPartido(cmbProvincia.Text, cmbPartido.Text, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            // Asignamos a la grilla
            App.InitAdvance("Cargando:");
            grdDatos.Focus();
            grdDatos.FillFromLEntidad(l_lentLocalidades, "deleted");
            grdDatos.ColWitdhs= App.GetStrURegistry(false, "GridFormat", App.Usuario.Usuario + "LocalidadesGrdWidths", "");
            grdDatos.GridOrder= App.GetStrURegistry(false, "GridFormat", App.Usuario.Usuario + "LocalidadesGrdSort", "");
            App.EndAdvance();

            // Fijamos el evento de cambio de ancho de la grilla
            if (l_lentLocalidades.Count > 0)
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
            txtDescripcion.NormalDisable= true;
            txtDescripcion.Enabled= false;
            cmbZona.NormalDisable= true;
            cmbZona.Enabled= false;
            txtCodPostal.NormalDisable= true;
            txtCodPostal.Enabled= false;
            cmbDirecta.NormalDisable= true;
            cmbDirecta.Enabled= false;
            gbCancelar.Enabled= false;
            gbGrabar.Enabled= false;
            gbDeshabilitar.Enabled= false;

            // Blanqueamos los campos
            txtDescripcion.Text= "";
            cmbZona.SelectedStrCode= "";
            txtCodPostal.Text= "";
            cmbDirecta.SelectedStrCode= "";

            // Habilitamos la grilla y los controles operativos
            cmbProvincia.Enabled= true;
            cmbPartido.Enabled= true;
            cmdNewPart.Enabled= true;
            txtNewPartido.Enabled= false;
            cmdSvNPart.Enabled= false;
            cmdCanNPart.Enabled= false;
            gbNuevo.Enabled= true;
            gbModificar.Enabled= true;
            gbSalir.Enabled= true;
            cmdPrint.Enabled= true;
            cmdExcel.Enabled= true;
            grdDatos.Enabled= true;

            // Procesamos los comandos ACL
            gbNuevo.Visible= ((m_aclInfo[0].VStr == "S") || (m_aclInfo[1].VStr == "S"));
            gbModificar.Visible= ((m_aclInfo[0].VStr == "S") || (m_aclInfo[3].VStr == "S"));

            // El ESC sale del formulario
            CancelButton= gbSalir;
        }

        /// <summary>
        /// Pone el formulario en modo: Edicion
        /// </summary>
        private void EditMode()
        {
            // Llenamos los campos a partir de la entidad a editar
            txtCodPostal.Text= m_entLocalidad.Codpost;
            txtDescripcion.Text = m_entLocalidad.Nombre;
            cmbZona.SelectedStrCode = m_entLocalidad.Codzona;
            
            cmbDirecta.SelectedStrCode= m_entLocalidad.Directa;

            // Habilitamos el frame
            txtDescripcion.NormalDisable= false;
            txtDescripcion.Enabled= !m_entLocalidad.EstaBorrada;
            cmbZona.NormalDisable= false;
            cmbZona.Enabled= !m_entLocalidad.EstaBorrada;
            txtCodPostal.NormalDisable= false;
            txtCodPostal.Enabled= !m_entLocalidad.EstaBorrada;
            cmbDirecta.NormalDisable= false;
            cmbDirecta.Enabled= !m_entLocalidad.EstaBorrada;
            gbCancelar.Enabled= true;
            gbGrabar.Enabled= !m_entLocalidad.EstaBorrada;
            gbDeshabilitar.FixedImage= (m_entLocalidad.EstaBorrada) ? FixedGlassButtons.Enable 
                                                               : FixedGlassButtons.Disable;
            gbDeshabilitar.Enabled= !m_entLocalidad.EsNueva;

            // Procesamos los comandos ACL
            if (m_entLocalidad.EstaBorrada)
                gbDeshabilitar.Visible= ((m_aclInfo[0].VStr == "S") || (m_aclInfo[4].VStr == "S"));
            else
                gbDeshabilitar.Visible= ((m_aclInfo[0].VStr == "S") || (m_aclInfo[2].VStr == "S"));

            // Dehabilitamos la grilla y los controles operativos
            cmbProvincia.Enabled= false;
            cmbPartido.Enabled= false;
            cmdNewPart.Enabled= false;
            txtNewPartido.Enabled= false;
            cmdSvNPart.Enabled= false;
            cmdCanNPart.Enabled= false;
            gbNuevo.Enabled= false;
            gbModificar.Enabled= false;
            gbSalir.Enabled= false;
            cmdPrint.Enabled= false;
            cmdExcel.Enabled= false;
            grdDatos.Enabled= false;

            // El ESC sale de la edicion
            CancelButton= gbCancelar;
        }

    }
}
