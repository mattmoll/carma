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
    // Fecha                     : 22/08/2020 00:21
    // Sistema                   : Carm
    // Interface para la Entidad : Supervisor
    // Tipo de Interface         : Mantenimiento de Tabla Clasificadora
    //----------------------------------------------------------------------------
    // © 1996-2020 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    /// <summary>
    /// Formulario para Mantenimiento de la Tabla:Supervisores
    /// </summary>
    public partial class Supervisores : DockContent
    {
        #region Miembros de la Clase
            private Bel.ESupervisor m_entSupervisor= null;
            private StatMsg m_smResult= null;
            private ACLInfo m_aclInfo= null;
            private string m_strSort= "";
        #endregion

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public Supervisores()
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
        private void Supervisores_Load(object sender, System.EventArgs e)
        {
            // Inicializamos el form
            App.ShowMsg("Inicializando el formulario...");

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
        private void Supervisores_FormClosed(object sender, FormClosedEventArgs e)
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
                    App.SetStrURegistry(false, "GridFormat", "SupervisoresGrdSort", m_strSort);
                    return;
                }
            }

            // Si es boton derecho
            if (e.Button == MouseButtons.Right) {
                // Si cambio el sort simple
                if (m_strSort != "") {
                    // Quitamos el orden, grabamos y recargamos
                    m_strSort= "";
                    App.SetStrURegistry(false, "GridFormat", "SupervisoresGrdSort", m_strSort);
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
            App.SetStrURegistry(false, "GridFormat", "SupervisoresGrdWidths", grdDatos.ColWitdhs);
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
            grdDatos.ExportToExcel(false, false, "", "Supervisores", m_smResult);
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
                           "Lista de Supervisores", "");
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
            m_entSupervisor= Bel.ESupervisor.NewEmpty();
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
            m_entSupervisor= Bll.Supervisores.Get((string) grdDatos.GetMatrixValueObj(l_iRow, 1),
                                                    false, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            // Tenemos la entidad. Pasamos a modo de edicion y damos foco
            // al campo que corresponda
            SwitchTo(FormModes.Edit, GridOps.DontFill);
            if (m_entSupervisor.EstaBorrada) {
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
                                      /*App.Usuario.Usuario +*/ "SupervisoresPurge") == DialogResult.No) return;

            // Purgamos la tabla
            App.ShowMsg("Compactando la tabla...");
            Bll.Supervisores.Purge(m_smResult);
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
            Bll.Supervisores.Enabled(m_entSupervisor.EstaBorrada,
                                  m_entSupervisor.Cod,
                                  m_entSupervisor.FxdVersion,
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
            m_entSupervisor.Cod= txtCod.Text;
            m_entSupervisor.Apellido= txtApellido.Text;
            m_entSupervisor.Nombre= txtNombre.Text;
            m_entSupervisor.Usuario= txtUsuario.Text;
            m_entSupervisor.Tel= txtTel.Text;
            m_entSupervisor.Cel= txtCel.Text;

            // Tratamos de grabar la entidad
            App.ShowMsg("Grabando...");
            Bll.Supervisores.Save(m_entSupervisor, m_smResult);
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
            Bel.LESupervisores l_lentSupervisores= Bll.Supervisores.UpFull(false, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            // Asignamos a la grilla
            App.InitAdvance("Cargando:");
            grdDatos.Focus();
            grdDatos.FillFromLEntidad(l_lentSupervisores, "deleted");
            grdDatos.ColWitdhs= App.GetStrURegistry(false, "GridFormat", "SupervisoresGrdWidths", "");
            grdDatos.GridOrder= App.GetStrURegistry(false, "GridFormat", "SupervisoresGrdSort", "");
            App.EndAdvance();

            // Fijamos el evento de cambio de ancho de la grilla
            if (l_lentSupervisores.Count > 0)
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
            txtTel.NormalDisable= true;
            txtTel.Enabled= false;
            txtCel.NormalDisable= true;
            txtCel.Enabled= false;
            cmdCancelar.Enabled= false;
            cmdGrabar.Enabled= false;
            cmdDesHab.Enabled= false;
            cmdHab.Enabled= false;

            // Blanqueamos los campos
            txtCod.Text= "";
            txtApellido.Text= "";
            txtNombre.Text= "";
            txtUsuario.Text= "";
            txtTel.Text= "";
            txtCel.Text= "";

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
            txtCod.Text= m_entSupervisor.Cod;
            txtApellido.Text= m_entSupervisor.Apellido;
            txtNombre.Text= m_entSupervisor.Nombre;
            txtUsuario.Text= m_entSupervisor.Usuario;
            txtTel.Text= m_entSupervisor.Tel;
            txtCel.Text= m_entSupervisor.Cel;

            // Habilitamos el frame
            txtCod.NormalDisable= false;
            txtCod.Enabled= m_entSupervisor.EsNueva;
            txtApellido.NormalDisable= false;
            txtApellido.Enabled= m_entSupervisor.EsNueva;
            txtNombre.NormalDisable= false;
            txtNombre.Enabled= !m_entSupervisor.EstaBorrada;
            txtUsuario.NormalDisable= false;
            txtUsuario.Enabled= !m_entSupervisor.EstaBorrada;
            txtTel.NormalDisable= false;
            txtTel.Enabled= !m_entSupervisor.EstaBorrada;
            txtCel.NormalDisable= false;
            txtCel.Enabled= !m_entSupervisor.EstaBorrada;
            cmdCancelar.Enabled= true;
            cmdGrabar.Enabled= !m_entSupervisor.EstaBorrada;
            cmdDesHab.Enabled= ((!m_entSupervisor.EsNueva) &&(!m_entSupervisor.EstaBorrada));
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
