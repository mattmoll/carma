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

            ListaEntidades l_leEntrevistas = null;
            ListaEntidades l_leLlamadas = null;
            Bel.EVendedor l_eVendedor = null;

            // Traer datos del vendedor
            pTraerVendedor(ref l_eVendedor);
            // Traer entrevistas
            pTraerEntrevistas(ref l_leEntrevistas);
            // Traer llamadas realizadas
            pTraerLlamadas(ref l_leLlamadas);

            // Validamos que no haya errores.
            if (AppRuts.MsgRuts_AnalizeError(this,m_smResult))
                return;

            // Mostrar datos del vendedor
            pLlenarCamposVendedor(l_eVendedor);
            // Mostrar entrevistas
            pLlenarEntrevistas(l_leEntrevistas);
            // Mostrar llamadas realizadas
            pLlenarLlamadas(l_leLlamadas);

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
            txtHorarios.Text = l_eVendedor.Horarios;
            // Datos institucionales
            txtSuperv.Text = l_eVendedor.Vnd_nom_superv;
            txtTvend.Text = l_eVendedor.Vnd_des_tipovnd;
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


        #endregion

        private void DetalleVendedores_Load(object sender, EventArgs e)
        {

        }
    }
}
