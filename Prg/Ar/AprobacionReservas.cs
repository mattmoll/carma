using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI;
using TNGS.NetRoutines;
using TNGS.NetApp;

namespace Sima.Ar
{
    /// <summary>
    /// Formulario para consulta de datos del oficina
    /// </summary>
    public partial class AprobacionReservas : Form
    {
        //Miembros
        private StatMsg m_smResult= null;
        private int m_iTimerCount= 0;

        // Miembros que tenen el cliente el vendedor seleccionado.
        Bel.ECliente m_eClienteSelected = null;
        Bel.EVendedor m_eVendedorSelected = null;
            

        // Constuctor
        public AprobacionReservas()
        {
            InitializeComponent();

            // Inicializar variables
            m_smResult = new StatMsg();

            // Fijamos el formulario de la aplicacion
            App.SetMainWindow(this, null, null, sbpMensaje, sbpConexion, sbpUsuario, sbpPercent, sbpAvance);
        }


        // Eventos del formulario y los controles

        private void grdPendientes_CurrentCellChanged(object sender, EventArgs e)
        {
            // Conseguimos el el numero de row actual seleccionado en la grilla.
            int l_intRow = grdPendientes.CurrentRowIndex;
            if (l_intRow == -1)
                return;

            // Muestra los datos extras de la solicitud.
            MuestraDatosExtras(l_intRow);
        }

        private void Mainframe_Load(object sender, EventArgs e)
        {
            App.HideMsg();
        }

        /// <summary>
        /// Cambio el estado del formulario
        /// </summary>
        private void Mainframe_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized) {
                // Lo minimizaron. Nos ocultamos
                Visible= false;
                FillGrid();
                return;
            }

            if (WindowState == FormWindowState.Normal) {
                // Lo normalizaron. Nos mostramos
                Visible= true;
                FillGrid();
                return;
            }
        }

        /// <summary>
        /// Timer de refresh
        /// </summary>
        private void tmrRefresh_Tick(object sender, EventArgs e)
        {
            // Cada n minutos (configurado)
            if (++m_iTimerCount < udAviso.Value) return;

            // Recargamos la lista
            tmrRefresh.Enabled= false;
            FillGrid();
            m_iTimerCount= 0;
            tmrRefresh.Enabled= true;
        }

        /// <summary>
        /// Dobleclick en el systray
        /// </summary>
        private void niSysTray_DoubleClick(object sender, EventArgs e)
        {
            Visible= true;
            WindowState= FormWindowState.Normal;
        }

        /// <summary>
        /// Cambio el valor del aviso
        /// </summary>
        private void udAviso_ValueChanged(object sender, EventArgs e)
        {
            // No puede ser menor a 0 ni mayor a 60
            if (udAviso.Value < 5) udAviso.Value= 5;
            if (udAviso.Value > 60) udAviso.Value= 60;

            // Guardamos el ultimo tiempo
            App.SetIntURegistry(false, "", "SolicAdviseTime", Convert.ToInt32(udAviso.Value));
        }

        /// <summary>
        /// Pinta de color las solicitudes bloqueadas
        /// </summary>
        private void grdPendientes_GetColor(object sender, GetColorEventArgs e)
        {
            try {
                if (((string) e.Registro[5]).Trim() == "BLOQUEADA")
                    e.SetColor(Color.Aquamarine);
            }
            catch (Exception) {
            }
        }


        // Métodos publicos del formulario

        /// <summary>
        /// Actualizacion inciial del formulario
        /// </summary>
        public void InitialUpdate()
        {
            // Cargamos el ultimo tiempo guardado
            udAviso.Value= App.GetIntURegistry(false, "", "SolicAdviseTime", 5);

            // Mostramos los pendientes
            FillGrid();
        }



        // Operaciones del formulario

        /// <summary>
        /// Filtra la tabla por la columna indicada
        /// </summary>
        private void cmdFiltrar_Click(object sender, EventArgs e)
        {
            // Si hay filtro
            grdPendientes.Focus();
            if (cmdFiltrar.Checked)
                unfilterGrid();
            else {
                // Ponemos el filtro solicitado
                grdPendientes.FilterTable(false);
                if (grdPendientes.CaptionText != "Solicitudes")
                    cmdFiltrar.Checked= true;
            }
        }

        private void unfilterGrid()
        {
            // Lo quitamos
            grdPendientes.UnFilterTable();
            cmdFiltrar.Checked = false;
        }

        /// <summary>
        /// Actualiza la lista de pendientes
        /// </summary>
        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            FillGrid();
            unfilterGrid();
        }

        /// <summary>
        /// Mostrar una solicitud
        /// </summary>
        private void cmdVer_Click(object sender, EventArgs e)
        {
            // Vemos si hay un item seleccionado en la grilla 
            int l_iRow= grdPendientes.CurrentRowIndex;
            if (l_iRow == -1)
            {
                MsgRuts.ShowMsg(this, "Debe seleccionar una solicitud para poder ver su detalle");
                return;
            }

            ActualizaEntsSelected(l_iRow);

            // Vemos si sigue pendiente
            int l_iNroSol= (int) grdPendientes.GetMatrixValueObj(l_iRow, 0);

            Bel.ESolicitud l_entSolicitud= Bll.Solicitudes.Get(l_iNroSol, false, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            if (l_entSolicitud.Estado != "P")  {
                // Error.
                MsgRuts.ShowMsg(this, "La solicitud ya no está pendiente.");
                FillGrid();
                return;
            }
            
            // Mostramos los datos de la solicitud
            Detalle l_DForm= new Detalle(m_eClienteSelected,m_eVendedorSelected); 

            tmrRefresh.Enabled= false;
            DialogResult l_drRet= l_DForm.ShowDialog(this);
            tmrRefresh.Enabled= true;

            if (l_drRet == DialogResult.Cancel) return;
            
        }


        // Métodos privados del formulario

        /// <summary>
        /// Carga de la grilla de pendientes
        /// </summary>
        private void FillGrid()
        {
            // Buscamos las solicitudes pendientes
            if (Visible) {
                App.ShowMsg("Cargando las solicitudes pendientes...");
                Application.DoEvents();
                Application.DoEvents();
                Application.DoEvents();
            }

            // El usuario no esta loggeado aun
            if (App.Usuario == null || App.Usuario.Usuario == "") return;

            ListaEntidades l_lentPend = Bll.Solicitudes.fGetPendientes(m_smResult);

            if (MsgRuts.AnalizeError(this, m_smResult))
            {
                if (Visible) MsgRuts.AnalizeError(this, m_smResult);
                return;
            }

            if (Visible) {
                // Llenamos la grilla
                l_lentPend.ChangeCaption("sol_nro_numero", "V1NúmeroNN2");
                l_lentPend.ChangeCaption("sol_fyh_fgeneracion", "");
                l_lentPend.ChangeCaption("sol_rcd_codtipo", "V1tCN2");
                l_lentPend.ChangeCaption("sol_des_destipo", "V1TipoCN2");
                l_lentPend.ChangeCaption("sol_nro_numcliente", "V1nNN2");
                l_lentPend.ChangeCaption("sol_des_rSocial", "V1Razon SocialCN2");
                l_lentPend.ChangeCaption("sol_des_nomfant", "V1Nombre FantasiaCN2");
                l_lentPend.ChangeCaption("sol_cd6_codvend", "V1cCN2");
                l_lentPend.ChangeCaption("sol_des_codvend", "V1VendedorCN2");
                l_lentPend.ChangeCaption("sol_cd1_estado", "V1eCN2");
                l_lentPend.ChangeCaption("sol_xde_obssol", "V1oCN2");

                

                grdPendientes.FillFromLEntidad(l_lentPend, false);

                grdPendientes.ColWitdhs = "140;0;110;0;214;200;0;200;0;0;0;";
            }

            if (l_lentPend.Count > 0) {
                // Actualizamos cantidad 
                lblCantidad.Text= String.Format("Solicitudes Pendientes: {0}", l_lentPend.Count);
                niSysTray.BalloonTipText= lblCantidad.Text;

                // Mostramos los datos extras de la primera solicitud.
                MuestraDatosExtras(0);

                if (!Visible) niSysTray.ShowBalloonTip(10000);
            }
            else {
                // NO hay solicitudes
                lblCantidad.Text= "No hay solicitudes pendientes";
                niSysTray.BalloonTipText= "";
            }

            // Apagamos el mensaje
            if (Visible) App.HideMsg();
        }


        // Metodo privado que actualiza cuales son las entidades seleccionadas.
        private void ActualizaEntsSelected(int p_intIndexSol)
        {
            // Conseguimos el codigo a partir del metodo que trae un objeto de la grilla
            // pasandole una row y una column.
            object l_intNumClienteS = grdPendientes.GetMatrixValueObj(p_intIndexSol, "n");

            object l_stringCodVendS = grdPendientes.GetMatrixValueObj(p_intIndexSol, "c");
            m_eClienteSelected = Bll.Clientes.Get(Convert.ToInt32(l_intNumClienteS),false, m_smResult);
            m_eVendedorSelected = Bll.Vendedores.Get(l_stringCodVendS.ToString(), false, m_smResult);
        }

        // Metodo privado que actualiza las entidade sy muestra los datos extras en pantalla.
        private void MuestraDatosExtras(int p_intIndexSol)
        {
            // Actualizamos las entidades seleccionadas de vendedor y cliente.
            ActualizaEntsSelected(p_intIndexSol);

            // Cargamos la solucitud.
            TEObsSol.Text = grdPendientes.GetMatrixValueObj(p_intIndexSol, "o").ToString();

            // Cargamos los datos del vendedor
            TEMarca.Text = m_eVendedorSelected.Vnd_des_marca;

            // Cargamos los datos del cliente.
            TEMayo.Text = m_eClienteSelected.Cli_cd1_esmayo;
            TELoc.Text = m_eClienteSelected.Cli_des_loc;

        }

        // Evento del boton aceptar una solicitud de reserva
        private void GBAceptar_Click(object sender, EventArgs e)
        {
            TEGrupo.Text = "";
            TELoc.Text = "";
            TEMarca.Text = "";
            TEMayo.Text = "";
            TEObsSol.Text = "";
            // Vemos si hay un item seleccionado en la grilla 
            int l_iRow = grdPendientes.CurrentRowIndex;

            if (l_iRow == -1)
            {
                MsgRuts.ShowMsg(this, "Debe seleccionar una solicitud para poder rechazarla");
                return;
            }

            // Marcamos el cliente como reservado.
            Bll.Solicitudes.fAprobar(null,
                                     (int)(grdPendientes.GetMatrixValueObj(l_iRow, "Número")),
                                     (grdPendientes.GetMatrixValueObj(l_iRow, "t").ToString()) ,   
                                          m_eClienteSelected.Numero,
                                          m_eVendedorSelected.Cod,
                                          TEObsSol.Text.Trim(),
                                          m_smResult);

            // Actualizamos la grilla.
            FillGrid();

        }

        // Evento de rechazar una solicitud de reserva
        private void GBRechazar_Click(object sender, EventArgs e)
        {
            TEGrupo.Text = "";
            TELoc.Text = "";
            TEMarca.Text = "";
            TEMayo.Text = "";
            TEObsSol.Text = "";
            // Vemos si hay un item seleccionado en la grilla 
            int l_iRow = grdPendientes.CurrentRowIndex;

            if (l_iRow == -1)
            {
                MsgRuts.ShowMsg(this, "Debe seleccionar una solicitud para poder rechazarla");
                return;
            }

            // Rechazamos la solicitud.
            Bll.Solicitudes.fRechazar(Convert.ToInt32(grdPendientes.GetMatrixValueObj(l_iRow, "Número")),TEObsSol.Text.Trim(),
                                      m_smResult);

            //Actualizamos las grilla.
            FillGrid();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.WindowState = FormWindowState.Minimized;
        }

        private void AprobacionReservas_Activated(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }
    }
}
