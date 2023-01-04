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
    // Fecha                     : 03/01/2023 23:31
    // Sistema                   : Carm
    // Interface para la Entidad : PlnServicio
    // Tipo de Interface         : Mantenimiento de Tabla Padre-Hijo
    //----------------------------------------------------------------------------
    // © 1996-2023 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    /// <summary>
    /// Formulario para Mantenimiento de la Tabla:PlnServicios
    /// </summary>
    public partial class PlnServicios : DockContent
    {
        #region Miembros de la Clase
            private Bel.EPlnServicio m_entPlnServicio= null;
            private StatMsg m_smResult= null;
            private ACLInfo m_aclInfo= null;
            private string m_strSort= "";
        #endregion

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public PlnServicios()
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
        private void PlnServicios_Load(object sender, System.EventArgs e)
        {
            // Inicializamos el form
            App.ShowMsg("Inicializando el formulario...");

            Bel.LEPlanes l_lentPlanes= Bll.Planes.UpFull(true, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;
            cmbPlan.FillFromStrLEntidad(l_lentPlanes, "pln_cod_cod", "pln_des_des", "deleted");

            // Llenamos las Combos (por Tablas)
            Bel.LEServicios l_lentServicios= Bll.Servicios.UpFull(false, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;
            cmbCodservicio.FillFromStrLEntidad(l_lentServicios, "srv_cod_cod", "srv_des_des", "deleted");

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
        private void PlnServicios_Closed(object sender, System.EventArgs e)
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
                    App.SetStrURegistry(false, "GridFormat", "PlnServiciosGrdSort", m_strSort);
                    return;
                }
            }

            // Si es boton derecho
            if (e.Button == MouseButtons.Right) {
                // Si cambio el sort simple
                if (m_strSort != "") {
                    // Quitamos el orden, grabamos y recargamos
                    m_strSort= "";
                    App.SetStrURegistry(false, "GridFormat", "PlnServiciosGrdSort", m_strSort);
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
            App.SetStrURegistry(false, "GridFormat", "PlnServiciosGrdWidths", grdDatos.ColWitdhs);
        }

        /// <summary>
        /// Cambio la combo con codigos Padre
        /// </summary>
        private void cmbPlan_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            // Si se selecciono un codigo
            if (cmbPlan.SelectedIndex != -1) {
                // Llenamos la grilla
                FillGrid();
            }
            else {
                // Limpiamos la grilla
                grdDatos.Clear();
            }

            // Damos foco a la grilla
            grdDatos.Focus();
        }

        //--------------------------------------------------------------
        // Operaciones
        //--------------------------------------------------------------

        /// <summary>
        /// Llama al formulario de mantenimiento de la tabla Padre
        /// </summary>
        private void cmdModPadre_Click(object sender, System.EventArgs e)
        {
            // Mostramos el formulario de ABM del padre
            App.SetACL(m_aclInfo);
            Planes l_frmPadre= new Planes();

            l_frmPadre.Visible = false;
            l_frmPadre.MdiParent= null;
            l_frmPadre.StartPosition= FormStartPosition.CenterParent;
            l_frmPadre.ShowDialog(this);
            App.SetACL(null);

            // Bloqueamos el menu
            App.LockMenu(true);

            // Recargamos la combo
            App.ShowMsg("Recargando los datos...");

            Bel.LEPlanes l_lentPlanes= Bll.Planes.UpFull(true, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;
            cmbPlan.FillFromStrLEntidad(l_lentPlanes, "pln_cod_cod", "pln_des_des", "deleted");
            cmbPlan.Focus();
            App.HideMsg();
        }

        /// <summary>
        /// Exporta la grilla en Excel
        /// </summary>
        private void cmdExcel_Click(object sender, System.EventArgs e)
        {
            App.ShowMsg("Generando planilla...");
            App.InitAdvance("Excel:");
            grdDatos.ExportToExcel(false, false, "", "PlnServicios", m_smResult);
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
                           "Lista de PlnServicios", "");
            App.EndAdvance();
            App.HideMsg();
        }

        /// <summary>
        /// Genera un Nuevo registro en la tabla
        /// </summary>
        private void cmdNuevo_Click(object sender, System.EventArgs e)
        {
            // Si no hay padre -> salimos
            if (cmbPlan.SelectedIndex == -1) return;

            // Creamos una nueva entidad, pasamos a modo de edicion y
            // damos foco al primer campo
            m_entPlnServicio= Bel.EPlnServicio.NewEmpty();
            m_entPlnServicio.Codplan= cmbPlan.SelectedStrCode;
            SwitchTo(FormModes.Edit, GridOps.DontFill);
            cmbCodservicio.Focus();
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
            m_entPlnServicio= Bll.Planes.PlsGet(cmbPlan.SelectedStrCode,
                                                (string) grdDatos.GetMatrixValueObj(l_iRow, 2),
                                                false, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            // Tenemos la entidad. Pasamos a modo de edicion y damos foco
            // al campo que corresponda
            SwitchTo(FormModes.Edit, GridOps.DontFill);
            if (m_entPlnServicio.EstaBorrada) {
                cmdCancelar.Focus();
            }
            else {
                cmbCodservicio.Focus();
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
                                      /*App.Usuario.Usuario +*/ "PlnServiciosPurge") == DialogResult.No) return;

            // Purgamos la tabla
            App.ShowMsg("Compactando la tabla...");
            Bll.Planes.PlsPurge(m_smResult);
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
            Bll.Planes.PlsEnabled(m_entPlnServicio.EstaBorrada,
                                  m_entPlnServicio.Codplan,
                                  m_entPlnServicio.Codservicio,
                                  m_entPlnServicio.FxdVersion,
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
            m_entPlnServicio.Codplan= cmbPlan.SelectedStrCode;
            m_entPlnServicio.Codservicio= cmbCodservicio.SelectedStrCode;

            // Tratamos de grabar la entidad
            App.ShowMsg("Grabando...");
            Bll.Planes.PlsSave(m_entPlnServicio, m_smResult);
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
            Bel.LEPlnServicios l_lentPlnServicios= Bll.Planes.PlsFGet(cmbPlan.SelectedStrCode,
                                                                      false, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            // Asignamos a la grilla
            App.InitAdvance("Cargando:");
            grdDatos.Focus();
            grdDatos.FillFromLEntidad(l_lentPlnServicios, "deleted");
            grdDatos.ColWitdhs= App.GetStrURegistry(false, "GridFormat", "PlnServiciosGrdWidths", "");
            grdDatos.GridOrder= App.GetStrURegistry(false, "GridFormat", "PlnServiciosGrdSort", "");
            App.EndAdvance();

            // Fijamos el evento de cambio de ancho de la grilla
            if (l_lentPlnServicios.Count > 0)
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
            cmbCodservicio.NormalDisable= true;
            cmbCodservicio.Enabled= false;
            cmdCancelar.Enabled= false;
            cmdGrabar.Enabled= false;
            cmdDesHab.Enabled= false;
            cmdHab.Enabled= false;

            // Blanqueamos los campos
            cmbCodservicio.SelectedStrCode= "";

            // Habilitamos la grilla y los controles operativos
            cmbPlan.Enabled= true;
            cmdModPadre.Enabled= true;
            cmdNuevo.Enabled= true;
            cmdModificar.Enabled= true;
            cmdSalir.Enabled= true;
            cmdPrint.Enabled= true;
            cmdExcel.Enabled= true;
            grdDatos.Enabled= true;

            // Procesamos los comandos ACL
            cmdNuevo.Visible= ((m_aclInfo[0].VStr == "S") || (m_aclInfo[1].VStr == "S"));
            cmdModificar.Visible= ((m_aclInfo[0].VStr == "S") || (m_aclInfo[3].VStr == "S"));

            // El ESC sale del formulario
            CancelButton= cmdSalir;
        }

        /// <summary>
        /// Pone el formulario en modo: Edicion
        /// </summary>
        private void EditMode()
        {
            // Llenamos los campos a partir de la entidad a editar
            cmbCodservicio.SelectedStrCode= m_entPlnServicio.Codservicio;

            // Habilitamos el frame
            cmbCodservicio.NormalDisable= false;
            cmbCodservicio.Enabled= m_entPlnServicio.EsNueva;
            cmdCancelar.Enabled= true;
            cmdGrabar.Enabled= !m_entPlnServicio.EstaBorrada;
            cmdDesHab.FixedImage= (m_entPlnServicio.EstaBorrada) ? FixedGlassButtons.Enable 
                                                                 : FixedGlassButtons.Disable;
            cmdDesHab.Enabled= ((!m_entPlnServicio.EsNueva) && (!m_entPlnServicio.EstaBorrada));
            cmdHab.Enabled= !cmdDesHab.Enabled;

            // Procesamos los comandos ACL
            cmdHab.Visible= ((m_aclInfo[0].VStr == "S") || (m_aclInfo[4].VStr == "S"));
            cmdDesHab.Visible= ((m_aclInfo[0].VStr == "S") || (m_aclInfo[2].VStr == "S"));

            // Dehabilitamos la grilla y los controles operativos
            cmbPlan.Enabled= false;
            cmdModPadre.Enabled= false;
            cmdNuevo.Enabled= false;
            cmdModificar.Enabled= false;
            cmdSalir.Enabled= false;
            cmdPrint.Enabled= false;
            cmdExcel.Enabled= false;
            grdDatos.Enabled= false;

            // El ESC sale de la edicion
            CancelButton= cmdCancelar;
        }
    }
}
