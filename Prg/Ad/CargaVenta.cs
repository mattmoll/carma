using Carm.Bel;
using System;
using System.Windows.Forms;
using TNGS.NetApp;
using TNGS.NetRoutines;

namespace Carm.Ad
{
    public partial class CargaVenta : Form
    {
        StatMsg m_smResult = new StatMsg();
        int m_intNumeroCliente;
        ECliente m_Cliente;
        LEListasDePrecios m_listasDePrecios = LEListasDePrecios.NewEmpty();
        string m_strCodEmptyPlan = "0000";
        string m_strCodEmptyLista = "0000";
        bool planesSeteados = false;
        bool listasSeteadas = false;

        // Constructores para el caso de que el cliente ya esta reservado, y el caso en que se lo quiere vender para un vendedor.
        public CargaVenta(ECliente p_eCliente)
        {
            InitializeComponent();
            m_intNumeroCliente = p_eCliente.Numero;
        }

        private void CargaVenta_Load(object sender, EventArgs e)
        {
            LEPlanes l_lentPlanes = Bll.Planes.UpFull(true, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;
            cdcPlan.FillFromStrLEntidad(l_lentPlanes, EPlan.CodCmp, EPlan.DesCmp, "deleted");
            cdcPlan.AddStrCD(m_strCodEmptyPlan, "Elige un plan");
            cdcPlan.SelectedStrCode = m_strCodEmptyPlan;
            planesSeteados = true;

            cdcListaDePrecios.AddStrCD(m_strCodEmptyLista, "Elige una Lista de Precios");
            listasSeteadas = true;

            m_listasDePrecios = Bll.Tablas.LprUpFull(true, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            m_Cliente = Bll.Clientes.Get(m_intNumeroCliente, true, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            if (m_Cliente.EsAreaProtegida)
                AreasProtegidasMode();
            else
                SociosDirectosMode();
        }

        private bool FaltanDatosParaLaVenta =>
            (m_Cliente.EsAreaProtegida && (PlanSinSeleccionar || dcePrecioFinal.Decimal == 0))
            ||
            (m_Cliente.EsSocioDirecto && (PlanSinSeleccionar || ListaSinSeleccionar || neCantPersonas.Numero == 0));

        private bool PlanSinSeleccionar => cdcPlan.SelectedStrCode == m_strCodEmptyPlan;
        private bool ListaSinSeleccionar => cdcListaDePrecios.SelectedStrCode == m_strCodEmptyLista;

        private void GBAccept_Click(object sender, EventArgs e)
        {
            if (FaltanDatosParaLaVenta)
            {
                MsgRuts.ShowMsg(this, "Debe elegir un plan, una lista de precios e ingresar la cantidad de personas, o el valor de la venta segun corresponda para el tipo de cliente para continuar.");
                return;
            }

            DateTime l_dtNow = Bll.Clientes.fGetDate(m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            var vendedor = Bll.Vendedores.fGetVendedorFromUsu(m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            Bel.ECliVenta l_eCliVenta = ECliVenta.NewFilled(m_intNumeroCliente, l_dtNow, vendedor.Cod, 
                dcePrecioFinal.Decimal, neCantPersonas.Numero, cdcPlan.SelectedStrCode, 
                cdcListaDePrecios.SelectedStrCode);
            Bll.Clientes.fGrabaVenta(l_eCliVenta, 0, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

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

            if (cdcPlan.SelectedStrCode == m_strCodEmptyPlan || !planesSeteados)
            {
                mrServicios.Clear();

                if(listasSeteadas)
                    cdcListaDePrecios.SelectedStrCode = m_strCodEmptyLista;

                return;
            }

            Bel.LEPlnServicios servicios = Bll.Planes.PlsFGet(cdcPlan.SelectedStrCode, true, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            servicios.ChangeCaption("deleted", "");
            mrServicios.fill(servicios, "Servicios del Plan", m_smResult);

            m_listasDePrecios.Filter($"{EListaDePrecios.CodplanCmp} = {cdcPlan.SelectedStrCode}");
            cdcListaDePrecios.FillFromStrLEntidad(m_listasDePrecios, EListaDePrecios.CodCmp, EListaDePrecios.DesCmp);
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

        private void SociosDirectosMode()
        {
            pnlFieldsSocios.Visible = true;
            dcePrecioFinal.ReadOnly = true;
        }

        private void AreasProtegidasMode()
        {
            pnlFieldsSocios.Visible = false;
            dcePrecioFinal.ReadOnly = false;
        }

        private void neCantPersonas_KeyUp(object sender, KeyEventArgs e)
        {
            UpdatePrecioFinal();
        }
    }
}
