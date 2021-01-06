using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Carm.Shr;
using TNGS.NetRoutines;
using TNGS.NetApp;
using Carm.Bel;

namespace Carm.Ad
{
    public partial class CargaServicio : Form
    {

        // Miembros
        StatMsg m_smResult = new StatMsg();
        private int m_intNumeroCli;
        private Bel.LECliServicios m_lentCliServicio;
        private Bel.LEPlnServicios m_lentPlnServicios;
        private ListaEntidades m_lentServicios;


        // Constructor que genera los planes fijos y c
        public CargaServicio(int p_intNroCliente, string p_strCodTipoContrato = "")
        {
            InitializeComponent();

            m_intNumeroCli = p_intNroCliente;
                
        }




        #region Eventos




        // Evento del boton aceptar que llena la entidad.
        private void GBAccept_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        // Evento del boton cancelar que pone el dialog resul en cancel.
        private void GBCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


        #endregion 

        #region Metodos

     

        #endregion 


        // Propiedades:
        public int NumeroCli { set { m_intNumeroCli = value; } }
        public Bel.LECliServicios Servicios { get { return m_lentCliServicio; } }

    }
}
