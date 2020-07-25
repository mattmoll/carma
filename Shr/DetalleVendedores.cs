using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TNGS.NetRoutines;
using TNGS.NetAppBll;
using WeifenLuo.WinFormsUI.Docking;
using Carm.Bel;

namespace Carm.Shr
{
    public partial class DetalleVendedores : Form
    {
        // Miembros
        string m_strCodVend;
        StatMsg m_smResult = new StatMsg();

        public DetalleVendedores(string p_strCodVend)
        {
            InitializeComponent();

            // Guardamos el parametro en el miembro.
            m_strCodVend = p_strCodVend;
        }

        // Metodo publico que se encarga de cargar todo en las pestañas y reportar error si lo hubo.
        public void CargaDatos()
        {
            
            // Seleccionamos la tab de entrevistas.
            DetalleVend.SelectedTab = tabVendedor;
            AppRuts.App_ShowMsg("Cargando");

            ListaEntidades l_leClientes = null;
            ListaEntidades l_leEntrevistas = null;
            ListaEntidades l_leLlamadas = null;
            Bel.EVendedor l_eVendedor = null;
            ListaEntidades l_leSolicitudes = null;

            // Traer datos del vendedor
            pTraerVendedor(ref l_eVendedor);
            // Traer reservas actuales
            pTraerReservas(ref l_leClientes);
            // Traer entrevistas
            pTraerEntrevistas(ref l_leEntrevistas);
            // Traer llamadas realizadas
            pTraerLlamadas(ref l_leLlamadas);
            // Traer reservas anteriores
            pTraerSolicitudes(ref l_leSolicitudes);

            // Validamos que no haya errores.
            if (AppRuts.MsgRuts_AnalizeError(this,m_smResult))
                return;

            // Mostrar datos del vendedor
            pLlenarCamposVendedor(l_eVendedor);
            // Mostrar reservas actuales
            pLlenarReservas(l_leClientes);
            // Mostrar entrevistas
            pLlenarEntrevistas(l_leEntrevistas);
            // Mostrar llamadas realizadas
            pLlenarLlamadas(l_leLlamadas);
            // Mostrar reservas anteriores
            pLlenarSolicitudes(l_leSolicitudes);

            AppRuts.App_HideMsg();

            // Validamos que no haya errores.
            if (AppRuts.MsgRuts_AnalizeError(this,m_smResult))
                return;
        }

        #region Carga y muestra de datos

        // Traer vendedor
        private void pTraerVendedor(ref Bel.EVendedor p_eVendedor)
        {
            p_eVendedor = Bll.Vendedores.Get(m_strCodVend, false, m_smResult);
        }
        // Llenar datos asociados del vendedor
        private void pLlenarCamposVendedor(Bel.EVendedor l_eVendedor)
        {
            // Datos personales
            teCodVend.Text = l_eVendedor.Cod;
            txtUsuario.Text = l_eVendedor.Usuario;
            txtNombre.Text = l_eVendedor.Nombre;
            txtApellido.Text = l_eVendedor.Apellido;
            txtTel1.Text = l_eVendedor.Tel1;
            txtTel2.Text = l_eVendedor.Tel2;
            monthCalendar1.SelectionStart = l_eVendedor.Fecnacim;
            txtDireccion.Text = l_eVendedor.Direccion;
            txtEmail.Text = l_eVendedor.Email;
            txtHorarios.Text = l_eVendedor.Horarios;
            // Datos institucionales
            txtSuperv.Text = l_eVendedor.Vnd_nom_superv;
            txtJefeVtas.Text = l_eVendedor.Vnd_des_jvta;
            txtTvend.Text = l_eVendedor.Vnd_des_tipovnd;
            txtMarca.Text = l_eVendedor.Vnd_des_marca;
            txtBaseop.Text = l_eVendedor.Vnd_des_baseop;
        }

        // Traer reservas
        private void pTraerReservas(ref ListaEntidades l_leClientes)
        {
            l_leClientes = Bll.Clientes.GetReservados(m_strCodVend, m_smResult);
        }
        // Llenar miniReport de reservas
        private void pLlenarReservas(ListaEntidades l_leClientes)
        {
            l_leClientes.ClearCaptions();

            l_leClientes.ChangeCaption(ECliente.NumeroCmp, "V1NúmeroCN2");                         /*0*/
            l_leClientes.ChangeCaption(ECliente.RsocialCmp, "V1Razón SocialCN2");                  /*1*/
            l_leClientes.ChangeCaption(ECliente.NombrefantCmp, "V1Nombre FantasíaCN2");            /*2*/
            l_leClientes.ChangeCaption("cli_ent_pendientes", "V1Entrev. PendientesCN2");         /*3*/
            l_leClientes.ChangeCaption("cli_des_tipoinst", "V1Tipo de instituciónCN2");          /*4*/
            l_leClientes.ChangeCaption("cli_des_rubro", "V1RubroCN2");                           /*5*/
            l_leClientes.ChangeCaption("cli_ent_pendientesvenc", "V1Entrev. IncompletasCN2");    /*6*/
            l_leClientes.ChangeCaption("cli_ede_direccion", "V1DireccionCN2");                   /*7*/
            l_leClientes.ChangeCaption("cli_ede_localidad", "V1LocalidadCN2");                   /*8*/
            l_leClientes.ChangeCaption("cli_des_zona", "V1ZonaCN2");                             /*9*/
            l_leClientes.ChangeCaption("cli_ent_realizadas", "V1Entrev. RealizadasCN2");         /*10*/
            l_leClientes.ChangeCaption("cli_fec_finires", "V1Fecha de inicio de reservaCN2");    /*11*/
            l_leClientes.ChangeCaption("cli_fec_ffinres", "V1Fecha fin de reservaCN2");          /*12*/  

            //---Cargar en miniReport
            mrReservasAct.LoadData(l_leClientes, "Clientes", "", "SIMA", "", "", "Reservas actuales", m_smResult);
        }

        // Traer entrevistas
        private void pTraerEntrevistas(ref ListaEntidades l_leEntrevistas)
        {
            l_leEntrevistas = Bll.Vendedores.GetEntrevistas(m_strCodVend, m_smResult);
        }
        // Llenar miniReport de entrevistas 
        private void pLlenarEntrevistas(ListaEntidades l_leEntrevistas)
        {
            l_leEntrevistas.ClearCaptions();

            l_leEntrevistas.ChangeCaption("cli_ede_rsocial", "V1NúmeroCN2");                   /*0*/
            l_leEntrevistas.ChangeCaption("cle_fyh_fcoordinada", "V1Fecha coordinadaCN2");     /*1*/
            l_leEntrevistas.ChangeCaption("cle_des_estado", "V1EstadoCN2");                    /*2*/
            l_leEntrevistas.ChangeCaption("cle_des_nombre", "V1NombreCN2");                    /*3*/
            l_leEntrevistas.ChangeCaption("cle_des_cargo", "V1CargoCN2");                      /*4*/
            l_leEntrevistas.ChangeCaption("cle_xld_direccion", "V1DirecciónCN2");              /*5*/
            l_leEntrevistas.ChangeCaption("ren_des_des", "V1ResultadoCN2");                    /*6*/   
            
            //---Cargar en miniReport
            mrEntrevPend.LoadData(l_leEntrevistas, "Clientes", "", "SIMA", "", "", "Entrevistas", m_smResult);
        }
            
        // Traer llamadas realizadas
        private void pTraerLlamadas(ref ListaEntidades l_leLlamadas)
        {
            l_leLlamadas = Bll.Vendedores.GetLlamadas(m_smResult);
        }
        // Llenar miniReport de llamadas realizadas
        private void pLlenarLlamadas(ListaEntidades l_leLlamadas)
        {
            l_leLlamadas.ClearCaptions();

            l_leLlamadas.ChangeCaption(ECliente.NumeroCmp, "V1Numero de clienteCN2");     /*0*/
            l_leLlamadas.ChangeCaption(ECliente.RsocialCmp, "V1Razón SocialCN2");         /*1*/
            l_leLlamadas.ChangeCaption(ECategoriaLlamada.TipoCmp, "V1Tipo (E/S)CN2");              /*3*/
            l_leLlamadas.ChangeCaption(EMotivosLlamada.DesCmp, "V1MotivoCN2");                   /*2*/
            l_leLlamadas.ChangeCaption(ECliLlamada.FrealizadaCmp, "V1Fecha realizadaCN2");    /*4*/
            l_leLlamadas.ChangeCaption(ECliLlamada.ResultadoCmp, "V1ResultadoCN2");           /*5*/   

            //---Cargar en miniReport
            mrLlamadas.LoadData(l_leLlamadas, "Clientes", "", "SIMA", "", "", "Llamadas realizadas", m_smResult);
        }

        // Traer reservas anteriores
        private void pTraerSolicitudes(ref ListaEntidades l_leReservasAnt)
        {
            l_leReservasAnt = Bll.Vendedores.GetSolicitudes(m_strCodVend, m_smResult);
        }
        // LLenar miniReport de reservas anteriores
        private void pLlenarSolicitudes(ListaEntidades l_leSolicitudes)
        {
            l_leSolicitudes.ClearCaptions();

            l_leSolicitudes.ChangeCaption("cli_ede_rsocial", "V1Razón socialCN2");                /*0*/
            l_leSolicitudes.ChangeCaption("sol_fyh_fproceso", "V1Fecha de procesoCN2");           /*1*/
            l_leSolicitudes.ChangeCaption("sol_nom_autorizador", "V1AutorizadorCN2");             /*2*/
            l_leSolicitudes.ChangeCaption("sol_des_estado", "V1EstadoCN2");                       /*3*/
            l_leSolicitudes.ChangeCaption("sol_xde_obssol", "V1Observación del solicitanteCN2");   /*4*/
            l_leSolicitudes.ChangeCaption("sol_xde_obsaut", "V1Observación del autorizanteCN2");   /*5*/   
            
            //---Cargar en miniReport
            mrSolicitudes.LoadData(l_leSolicitudes, "Clientes", "", "SIMA", "", "", "Solicitudes", m_smResult);
        }

        #endregion

        private void DetalleVendedores_Load(object sender, EventArgs e)
        {

        }
    }
}
