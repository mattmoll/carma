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
        Bel.LEListasDePrecios m_listasDePrecios;

        // Constructores para el caso de que el cliente ya esta reservado, y el caso en que se lo quiere vender para un vendedor.
        public CargaVenta(ECliente p_eCliente)
        {
            InitializeComponent();
            m_intNumeroCliente = p_eCliente.Numero;

            Bel.LEPlanes l_lentPlanes = Bll.Planes.UpFull(true, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;
            cdcPlan.FillFromStrLEntidad(l_lentPlanes, "pln_cod_cod", "pln_des_des", "deleted");

            m_listasDePrecios = Bll.Tablas.LprUpFull(true, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

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

            // Cargamos la lista de tipos de contratos.
            ListaEntidades l_leTipoContratos = Bll.Tablas.TcnUpFull(true, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            cdcPlan.FillFromStrLEntidad(l_leTipoContratos, ETipoCont.CodCmp, ETipoCont.DesCmp, "deleted");
        }

        private void gbCargaServicios_Click(object sender, EventArgs e)
        {
            CargaServicio l_frmCargaServicio = new CargaServicio(m_intNumeroCliente, cdcPlan.SelectedStrCode);
            l_frmCargaServicio.ShowDialog(this);

            //if (l_frmCargaServicio.DialogResult == DialogResult.OK)
                //m_leCliServicios = l_frmCargaServicio.Servicios;
        }

        private void GBAccept_Click(object sender, EventArgs e)
        {
            DateTime l_dtNow = Bll.Clientes.fGetDate(m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;
            /*
            Bel.ECliVenta l_eCliVenta = Bel.ECliVenta.NewFilled(m_intNumeroCliente, l_dtNow, m_strCodVendedor, 
                                                                cdcTContratos.SelectedStrCode, dceAbono.Decimal, 
                                                                neCCapitas.Numero, dceVCapita.Decimal);
            Bll.Clientes.fGrabaVenta(l_eCliVenta, m_leCliServicios, neNroAvalon.Numero, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;
            */

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void GBCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cdcPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_listasDePrecios.Filter("");

            Bel.LEPlnServicios servicios = Bll.Planes.PlsFGet(cdcPlan.SelectedStrCode, true, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            mrServicios.fill(servicios, "Servicios del Plan", m_smResult);

            m_listasDePrecios.Filter($"{EListaDePrecios.CodplanCmp} = {cdcPlan.SelectedStrCode}");
            cdcListaDePrecios.FillFromStrLEntidad(m_listasDePrecios, EListaDePrecios.CodCmp, EListaDePrecios.DesCmp);
        }

        private void neCantPersonas_Leave(object sender, EventArgs e)
        {
            UpdatePrecioFinal();
        }

        private void UpdatePrecioFinal()
        {
            if (cdcListaDePrecios.SelectedStrCode == String.Empty || neCantPersonas.Numero == 0)
                return;

            var listaSeleccionada = m_listasDePrecios[cdcListaDePrecios.SelectedStrCode];

            if (neCantPersonas.Numero > 10)
            {
                dcePrecioFinal.Decimal = listaSeleccionada.Precio10p;
            }

            switch (neCantPersonas.Numero)
            {
                case 1: dcePrecioFinal.Decimal = listaSeleccionada.Precio1p; break;
                case 2: dcePrecioFinal.Decimal = listaSeleccionada.Precio2p; break;
                case 3: dcePrecioFinal.Decimal = listaSeleccionada.Precio3p; break;
                case 4: dcePrecioFinal.Decimal = listaSeleccionada.Precio4p; break;
                case 5: dcePrecioFinal.Decimal = listaSeleccionada.Precio5p; break;
                case 6: dcePrecioFinal.Decimal = listaSeleccionada.Precio6p; break;
                case 7: dcePrecioFinal.Decimal = listaSeleccionada.Precio7p; break;
                case 8: dcePrecioFinal.Decimal = listaSeleccionada.Precio8p; break;
                case 9: dcePrecioFinal.Decimal = listaSeleccionada.Precio9p; break;
                case 10: dcePrecioFinal.Decimal = listaSeleccionada.Precio10p; break;
                default: break;
            }
        }

        private void cdcListaDePrecios_Leave(object sender, EventArgs e)
        {
            UpdatePrecioFinal();
        }
    }
}
