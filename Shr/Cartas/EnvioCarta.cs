using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TNGS.NetRoutines;
using TNGS.NetAppBll;
using Carm.Bel;


namespace Carm.Shr
{
    public partial class EnvioCarta : Form
    {
        StatMsg m_smResult = new StatMsg();

        ListaEntidades m_leModelosCartas;
        VisualizadorCarta m_frmVisualizadorCarta;
        bool esMailMasivo;

        public EnvioCarta(ECliente p_eCliente)
        {
            InitializeComponent();
            m_frmVisualizadorCarta = (m_frmVisualizadorCarta == null) ? new VisualizadorCarta(p_eCliente) : m_frmVisualizadorCarta;
            esMailMasivo = false;
        }

        public EnvioCarta(ECliente p_eCliente, ECliContacto p_eCliContacto) : this(p_eCliente)
        {
            m_frmVisualizadorCarta = new VisualizadorCarta(p_eCliente, p_eCliContacto);
        }

        public EnvioCarta(List<ECliente> p_lstClientes)
        {
            InitializeComponent();
            m_frmVisualizadorCarta = new VisualizadorCarta(p_lstClientes);
            esMailMasivo = true;
        }

        // Carga del form que carga los modelos a memoria.
        private void SeleccionCarta_Load(object sender, EventArgs e)
        {
            // Cargamos todos los modelos de cartas a memoria.
            m_leModelosCartas = Bll.Tablas.MdcGetCartasSinElModelo(m_smResult);
            if (AppRuts.MsgRuts_AnalizeError(this, m_smResult)) return;

            string condicionFiltro;
            condicionFiltro = (esMailMasivo) ? "'S'" : "'N'";

            m_leModelosCartas.Filter(String.Format("{0} = {1}", Bel.EModeloCarta.EsmailmasivoCmp, condicionFiltro));
        }

        // Confirmacion de la seleccion que pasa el modelo elegido al visualizador.
        private void gbConfirmar_Click(object sender, EventArgs e)
        {
            // Recuperamos el modelo de carta elegido y se lo inyectamos al form visualizador antes de dispararlo.
            m_frmVisualizadorCarta.modeloCarta = Bll.Tablas.MdcGet(lstCartas.SelectedStrCode, true, m_smResult);
            if (AppRuts.MsgRuts_AnalizeError(this, m_smResult)) return;

            m_frmVisualizadorCarta.ShowDialog(this);

            if (m_frmVisualizadorCarta.DialogResult == DialogResult.OK)
                AppRuts.MsgRuts_ShowMsg(this, "El envio de mail(s) fue realizado correctamente!");

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Metodo que filtra la lista entidad por el tipo que recibe por parametro y la carga en pantalla.
        private void CargaLista(string p_strTipoCarta)
        {
            // Sacamos el ultimo filtro utilizado.
            m_leModelosCartas.Filter("");
            // Filtramos por el nuevo criterio.
            m_leModelosCartas.Filter(String.Format("mdc_cd1_codtipocarta = \'{0}\'", p_strTipoCarta));
            // Cargamos en pantalla.
            lstCartas.FillFromStrLEntidad(m_leModelosCartas, Bel.EModeloCarta.CodCmp, Bel.EModeloCarta.DesCmp, "deleted");
        }

        private void rbMailing_CheckedChanged(object sender, EventArgs e)
        {
            CargaLista("1");
        }

        private void rbCartasPres_CheckedChanged(object sender, EventArgs e)
        {
            CargaLista("2");
        }

        private void rbPresupuestos_CheckedChanged(object sender, EventArgs e)
        {
            CargaLista("3");
        }

        private void rbCartasInt_CheckedChanged(object sender, EventArgs e)
        {
            CargaLista("4");
        }

    }
}
