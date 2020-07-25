using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TNGS.NetControls;
using TNGS.NetRoutines;
using TNGS.NetApp;
using WeifenLuo.WinFormsUI.Docking;
using Sima.Shr;

namespace Sima.Rp
{
    public partial class ReporteBase : DockContent
    {
        // Miembros
        public StatMsg resultado = new StatMsg("ReporteBase");
        public PanelBuilder panelBuilder;
        Size m_szTamaño = new Size(250, 650);

        // Constructor que dockea el formulario
        public ReporteBase()
        {
            InitializeComponent();

            panelBuilder = new PanelBuilder(m_szTamaño, PanelBuilder.Alineacion.Vertical);
        }



        // Evento de carga del formulario que resetea la barra y el statmsg
        private void ReporteBase_Load(object sender, EventArgs e)
        {
            // Dockeamos el form
            if (!this.DesignMode)
                ((MainFrame)App.GetMainWindow()).AddContent(this);

            resultado.UilReset("");
            PrgRuts.ReseteaBarraInferior();
        }

        // Evento de cierre del formulario que cierra todos los documentos dockeados.
        private void ReporteBase_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((MainFrame)App.GetMainWindow()).CloseAllDocuments();
            App.LockMenu(false);
        }


        // Evento del click del boton de busqueda que delega en la subclase y carga el resultado en pantalla
        private void gbBuscar_Click(object sender, EventArgs e)
        {
            App.ShowMsg("Ejecutando Busqueda");

            string l_strNombreReporte = "";
            int l_intCorteDeControl = 0;

            ListaEntidades l_leBusqueda = realizarBusqueda(ref l_strNombreReporte, ref l_intCorteDeControl);

            // Validamos.
            if (l_leBusqueda == null)
            {
                MsgRuts.ShowMsg(this, "No se encontraron datos para la busqueda definida");
                PrgRuts.ReseteaBarraInferior();
                return;
            }

            // Creamos el form y llenamos el report.
            Shr.Reportes l_fReportes = new Shr.Reportes();
            string l_strDetalle = String.Format("Listado de {0}", l_strNombreReporte);

            l_fReportes.CargaReport(l_leBusqueda,
                                    l_strDetalle,
                                    "CEO",
                                    "Reportes y Estadísticas",
                                    l_strNombreReporte,
                                    "",
                                    l_intCorteDeControl,
                                    this.graphicMode);


            // Dockeamos el form de reportes
            ((MainFrame)App.GetMainWindow()).AddContent(l_fReportes);

            PrgRuts.ReseteaBarraInferior();
        }

        // Firma del metodo que deben sobreescribir las subclases para poder ejecutar una busqueda.
        virtual public ListaEntidades realizarBusqueda(ref string p_strNombreReporte, ref int p_intCorteDeControl)
        {
            throw new Exception("No se sobreescribio el metodo realizarBusqueda en la subclase. Contactese con sistemas");
        }

        public void setPanel()
        {
            xpPanelReporteBase.Controls.Add(this.panelBuilder.getPanel);
        }

        public GlassButton botonBusqueda
        {
            get { return this.gbBuscar; }
        }

        // Evento que captura el presionado de una tecla en todos los campos y dispara la busqueda si corresponde.
        private void Every_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Si es el enter, disparamos la busqueda.
            if (e.KeyChar == '\r')
            {
                gbBuscar_Click(sender, e);
            }
        }

        public TNGS.NetControls.Report.GraphicModes graphicMode = Report.GraphicModes.No;


    }
}
