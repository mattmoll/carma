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

namespace Carm.
{
    //----------------------------------------------------------------------------
    //                         TNG Software UIL Generator
    //----------------------------------------------------------------------------
    // Fecha                     : 06/08/2020 23:57
    // Sistema                   : Carm
    // Interface para la Entidad : Vendedor
    // Tipo de Interface         : Mantenimiento de Tabla Clasificadora
    //----------------------------------------------------------------------------
    // © 1996-2020 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    /// <summary>
    /// Formulario para Mantenimiento de la Tabla:Vendedores
    /// </summary>
    public partial class Vendedores : DockContent
    {
        #region Miembros de la Clase
            private Bel.EVendedor m_entVendedor= null;
            private StatMsg m_smResult= null;
            private ACLInfo m_aclInfo= null;
            private string m_strSort= "";
        #endregion

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public Vendedores()
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
        private void Vendedores_Load(object sender, System.EventArgs e)
        {
            // Inicializamos el form
            App.ShowMsg("Inicializando el formulario...");

            // Llenamos las Combos (por Tablas)
            Bel.LESupervisores l_lentSupervisores= Bll.Supervisores.UpFull(false, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;
            cmbCodsuperv.FillFromStrLEntidad(l_lentSupervisores, "sup_cd6_cod", "sup_nom_apellido", "deleted");

            Bel.LETipoVendedores l_lentTipoVendedores= Bll.Tablas.TvdUpFull(false, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;
            cmbCodtvend.FillFromStrLEntidad(l_lentTipoVendedores, "tvn_rcd_cod", "tvn_des_des", "deleted");

            Bel.LEX l_lentX= Bll.Tablas.DomUpFull(false, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;
            cmbCoddominio.FillFromStrLEntidad(l_lentX, "X", "X", "X");

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
        private void Vendedores_FormClosed(object sender, FormClosedEventArgs e)
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
                    App.SetStrURegistry(false, "GridFormat", "VendedoresGrdSort", m_strSort);
                    return;
                }
            }

            // Si es boton derecho
            if (e.Button == MouseButtons.Right) {
                // Si cambio el sort simple
                if (m_strSort != "") {
                    // Quitamos el orden, grabamos y recargamos
                    m_strSort= "";
                    App.SetStrURegistry(false, "GridFormat", "VendedoresGrdSort", m_strSort);
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
            App.SetStrURegistry(false, "GridFormat", "VendedoresGrdWidths", grdDatos.ColWitdhs);
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
            grdDatos.ExportToExcel(false, false, "", "Vendedores", m_smResult);
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
                           "Lista de Vendedores", "");
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
            m_entVendedor= Bel.EVendedor.NewEmpty();
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
            m_entVendedor= Bll.Tablas.VenGet((xxxx) grdDatos.GetMatrixValueObj(l_iRow, 1),
                                             false, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            // Tenemos la entidad. Pasamos a modo de edicion y damos foco
            // al campo que corresponda
            SwitchTo(FormModes.Edit, GridOps.DontFill);
            if (m_entVendedor.EstaBorrada) {
                cmdCancelar.Focus();
            }
            else {
                txtNombre.Focus();
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
                                      /*App.Usuario.Usuario +*/ "VendedoresPurge") == DialogResult.No) return;

            // Purgamos la tabla
            App.ShowMsg("Compactando la tabla...");
            Bll.Tablas.VenPurge(m_smResult);
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
            Bll.Tablas.VenEnabled(m_entVendedor.EstaBorrada,
                                  m_entVendedor.Cod,
                                  m_entVendedor.FxdVersion,
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
            m_entVendedor.Cod= txtCod.Text;
            m_entVendedor.Apellido= txtApellido.Text;
            m_entVendedor.Nombre= txtNombre.Text;
            m_entVendedor.Usuario= txtUsuario.Text;
            m_entVendedor.Tel1= txtTel1.Text;
            m_entVendedor.Celular= txtCelular.Text;
            m_entVendedor.Tel2= txtTel2.Text;
            m_entVendedor.Fecnacim= txtFecnacim.Fecha;
            m_entVendedor.Direccion= txtDireccion.Text;
            m_entVendedor.Email= txtEmail.Text;
            m_entVendedor.Contrasenia= txtContrasenia.Text;
            m_entVendedor.Codsuperv= cmbCodsuperv.SelectedStrCode;
            m_entVendedor.Codtvend= cmbCodtvend.SelectedStrCode;
            m_entVendedor.Horarios= txtHorarios.Text;
            m_entVendedor.Mailremitente= txtMailremitente.Text;
            m_entVendedor.Nombreamostrar= txtNombreamostrar.Text;
            m_entVendedor.Coddominio= cmbCoddominio.SelectedStrCode;
            m_entVendedor.Historico= txtHistorico.Text;

            // Tratamos de grabar la entidad
            App.ShowMsg("Grabando...");
            Bll.Tablas.VenSave(m_entVendedor, m_smResult);
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
            Bel.LEVendedores l_lentVendedores= Bll.Tablas.VenUpFull(false, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            // Asignamos a la grilla
            App.InitAdvance("Cargando:");
            grdDatos.Focus();
            grdDatos.FillFromLEntidad(l_lentVendedores, "deleted");
            grdDatos.ColWitdhs= App.GetStrURegistry(false, "GridFormat", "VendedoresGrdWidths", "");
            grdDatos.GridOrder= App.GetStrURegistry(false, "GridFormat", "VendedoresGrdSort", "");
            App.EndAdvance();

            // Fijamos el evento de cambio de ancho de la grilla
            if (l_lentVendedores.Count > 0)
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
            txtApellido.NormalDisable= true;
            txtApellido.Enabled= false;
            txtNombre.NormalDisable= true;
            txtNombre.Enabled= false;
            txtUsuario.NormalDisable= true;
            txtUsuario.Enabled= false;
            txtTel1.NormalDisable= true;
            txtTel1.Enabled= false;
            txtCelular.NormalDisable= true;
            txtCelular.Enabled= false;
            txtTel2.NormalDisable= true;
            txtTel2.Enabled= false;
            txtFecnacim.NormalDisable= true;
            txtFecnacim.Enabled= false;
            txtDireccion.NormalDisable= true;
            txtDireccion.Enabled= false;
            txtEmail.NormalDisable= true;
            txtEmail.Enabled= false;
            txtContrasenia.NormalDisable= true;
            txtContrasenia.Enabled= false;
            cmbCodsuperv.NormalDisable= true;
            cmbCodsuperv.Enabled= false;
            cmbCodtvend.NormalDisable= true;
            cmbCodtvend.Enabled= false;
            txtHorarios.NormalDisable= true;
            txtHorarios.Enabled= false;
            txtMailremitente.NormalDisable= true;
            txtMailremitente.Enabled= false;
            txtNombreamostrar.NormalDisable= true;
            txtNombreamostrar.Enabled= false;
            cmbCoddominio.NormalDisable= true;
            cmbCoddominio.Enabled= false;
            txtHistorico.NormalDisable= true;
            txtHistorico.Enabled= false;
            cmdCancelar.Enabled= false;
            cmdGrabar.Enabled= false;
            cmdDesHab.Enabled= false;
            cmdHab.Enabled= false;

            // Blanqueamos los campos
            txtCod.Text= "";
            txtApellido.Text= "";
            txtNombre.Text= "";
            txtUsuario.Text= "";
            txtTel1.Text= "";
            txtCelular.Text= "";
            txtTel2.Text= "";
            txtFecnacim.Fecha= new DateTime(1900,1,1,0,0,0);
            txtDireccion.Text= "";
            txtEmail.Text= "";
            txtContrasenia.Text= "";
            cmbCodsuperv.SelectedStrCode= "";
            cmbCodtvend.SelectedStrCode= "";
            txtHorarios.Text= "";
            txtMailremitente.Text= "";
            txtNombreamostrar.Text= "";
            cmbCoddominio.SelectedStrCode= "";
            txtHistorico.Text= "";

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
            txtCod.Text= m_entVendedor.Cod;
            txtApellido.Text= m_entVendedor.Apellido;
            txtNombre.Text= m_entVendedor.Nombre;
            txtUsuario.Text= m_entVendedor.Usuario;
            txtTel1.Text= m_entVendedor.Tel1;
            txtCelular.Text= m_entVendedor.Celular;
            txtTel2.Text= m_entVendedor.Tel2;
            txtFecnacim.Fecha= m_entVendedor.Fecnacim;
            txtDireccion.Text= m_entVendedor.Direccion;
            txtEmail.Text= m_entVendedor.Email;
            txtContrasenia.Text= m_entVendedor.Contrasenia;
            cmbCodsuperv.SelectedStrCode= m_entVendedor.Codsuperv;
            cmbCodtvend.SelectedStrCode= m_entVendedor.Codtvend;
            txtHorarios.Text= m_entVendedor.Horarios;
            txtMailremitente.Text= m_entVendedor.Mailremitente;
            txtNombreamostrar.Text= m_entVendedor.Nombreamostrar;
            cmbCoddominio.SelectedStrCode= m_entVendedor.Coddominio;
            txtHistorico.Text= m_entVendedor.Historico;

            // Habilitamos el frame
            txtCod.NormalDisable= false;
            txtCod.Enabled= m_entVendedor.EsNueva;
            txtApellido.NormalDisable= false;
            txtApellido.Enabled= m_entVendedor.EsNueva;
            txtNombre.NormalDisable= false;
            txtNombre.Enabled= !m_entVendedor.EstaBorrada;
            txtUsuario.NormalDisable= false;
            txtUsuario.Enabled= !m_entVendedor.EstaBorrada;
            txtTel1.NormalDisable= false;
            txtTel1.Enabled= !m_entVendedor.EstaBorrada;
            txtCelular.NormalDisable= false;
            txtCelular.Enabled= !m_entVendedor.EstaBorrada;
            txtTel2.NormalDisable= false;
            txtTel2.Enabled= !m_entVendedor.EstaBorrada;
            txtFecnacim.NormalDisable= false;
            txtFecnacim.Enabled= !m_entVendedor.EstaBorrada;
            txtDireccion.NormalDisable= false;
            txtDireccion.Enabled= !m_entVendedor.EstaBorrada;
            txtEmail.NormalDisable= false;
            txtEmail.Enabled= !m_entVendedor.EstaBorrada;
            txtContrasenia.NormalDisable= false;
            txtContrasenia.Enabled= !m_entVendedor.EstaBorrada;
            cmbCodsuperv.NormalDisable= false;
            cmbCodsuperv.Enabled= !m_entVendedor.EstaBorrada;
            cmbCodtvend.NormalDisable= false;
            cmbCodtvend.Enabled= !m_entVendedor.EstaBorrada;
            txtHorarios.NormalDisable= false;
            txtHorarios.Enabled= !m_entVendedor.EstaBorrada;
            txtMailremitente.NormalDisable= false;
            txtMailremitente.Enabled= !m_entVendedor.EstaBorrada;
            txtNombreamostrar.NormalDisable= false;
            txtNombreamostrar.Enabled= !m_entVendedor.EstaBorrada;
            cmbCoddominio.NormalDisable= false;
            cmbCoddominio.Enabled= !m_entVendedor.EstaBorrada;
            txtHistorico.NormalDisable= false;
            txtHistorico.Enabled= !m_entVendedor.EstaBorrada;
            cmdCancelar.Enabled= true;
            cmdGrabar.Enabled= !m_entVendedor.EstaBorrada;
            cmdDesHab.Enabled= ((!m_entVendedor.EsNueva) &&(!m_entVendedor.EstaBorrada));
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
