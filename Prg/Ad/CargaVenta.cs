using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Carm.Shr;
using Carm.Bel;
using TNGS.NetRoutines;
using TNGS.NetApp;


namespace Carm.Ad
{
    public partial class CargaVenta : Form
    {
        StatMsg m_smResult = new StatMsg();
        string m_strCodVendedor = "";
        int m_intNumeroCliente;
        Bel.LECliServicios m_leCliServicios = null;

        // Constructores para el caso de que el cliente ya esta reservado, y el caso en que se lo quiere vender para un vendedor.
        public CargaVenta(ECliente p_eCliente)
        {
            InitializeComponent();
            m_intNumeroCliente = p_eCliente.Numero;
            neNroAvalon.Numero = p_eCliente.Nroavalon;
            if (p_eCliente.Nroavalon != 0)
                neNroAvalon.Enabled = false;

            if (m_strCodVendedor == "")
                m_strCodVendedor = p_eCliente.Codvend;
        }

        public CargaVenta(ECliente p_eCliente, string p_strCodVendedor) : this(p_eCliente)
        {
            // Validamos que el cliente no este reservado. Si esta reservado para un vendedor, no se le puede 
            // cargar la venta a otro vendedor.
            if (p_eCliente.Codvend == "")
                m_strCodVendedor = p_strCodVendedor;
        }


        private void CargaVenta_Load(object sender, EventArgs e)
        {
            // Cargamos la lista de vendedores y de marcas.
            ListaEntidades l_leVendedores = Bll.Vendedores.UpFull(true, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            cdcVendedores.FillFromStrLEntidad(l_leVendedores, EVendedor.CodCmp, EVendedor.UsuarioCmp, "deleted");

            // Si nos pasaron el codigo de vendedor, llenamos los default.
            if (m_strCodVendedor != "")
            {
                cdcVendedores.SelectedStrCode = m_strCodVendedor;
                cdcVendedores.Enabled = false;

                EVendedor vendedor = Bll.Vendedores.Get(m_strCodVendedor, true, m_smResult);
                if (MsgRuts.AnalizeError(this, m_smResult)) return;
            }
            

            // Cargamos la lista de tipos de contratos.
            ListaEntidades l_leTipoContratos = Bll.Tablas.TcnUpFull(true, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            cdcTContratos.FillFromStrLEntidad(l_leTipoContratos, ETipoCont.CodCmp, ETipoCont.DesCmp, "deleted");
        }

        private void gbCargaServicios_Click(object sender, EventArgs e)
        {
            CargaServicio l_frmCargaServicio = new CargaServicio(m_intNumeroCliente, cdcTContratos.SelectedStrCode);
            l_frmCargaServicio.ShowDialog(this);

            if (l_frmCargaServicio.DialogResult == DialogResult.OK)
                m_leCliServicios = l_frmCargaServicio.Servicios;
        }

        private void GBAccept_Click(object sender, EventArgs e)
        {
            DateTime l_dtNow = Bll.Clientes.fGetDate(m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            Bel.ECliVenta l_eCliVenta = Bel.ECliVenta.NewFilled(m_intNumeroCliente, l_dtNow, cdcVendedores.SelectedStrCode, 
                                                                cdcTContratos.SelectedStrCode, dceAbono.Decimal, 
                                                                neCCapitas.Numero, dceVCapita.Decimal);
            Bll.Clientes.fGrabaVenta(l_eCliVenta, m_leCliServicios, neNroAvalon.Numero, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void GBCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}
