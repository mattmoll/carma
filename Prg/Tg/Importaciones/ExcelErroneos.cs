using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TNGS.NetRoutines;
using TNGS.NetApp;

namespace Carm.Tg
{
    public partial class ExcelErroneos : Form
    {
        // Miembros
        private ListaEntidades m_leListaEntidades;
        private CargadorExcel m_cdCargadorEspecifico;
        StatMsg m_smResult = new StatMsg();


        // Constructor
        public ExcelErroneos(ListaEntidades p_leListaEntidades, CargadorExcel p_ceCargadorEspecifico)
        {
            InitializeComponent();

            m_leListaEntidades = p_leListaEntidades;
            m_cdCargadorEspecifico = p_ceCargadorEspecifico;
        }

        // Evento de cerrado del form.
        private void ExcelErroneos_FormClosing(object sender, FormClosingEventArgs e)
        {
            //----Confirmar eliminación
            DialogResult l_drConfir = MsgRuts.ShowMsg(this,"¿Ya exportó la planilla y la guardo correctamente? Una vez cerrada esta ventana no se podran recuperar los clientes erroneos.", MessageBoxButtons.YesNo);

            if (l_drConfir == DialogResult.No)
                e.Cancel = true;
        }

        // Evento del load que carga los clientes erroneos en pantalla.
        private void ExcelErroneos_Load(object sender, EventArgs e)
        {
            // Captionamos.
            m_cdCargadorEspecifico.captionamos(m_leListaEntidades);
            m_leListaEntidades.ChangeCaption("Error", "V1ErrorCN1");

            // Llenamos el minireport.
            mrListaErroneos.LoadData(m_leListaEntidades,
                                   "",
                                   "",
                                   "Carm",
                                   "",
                                   "",
                                   "Erroneos",
                                   "",
                                   m_smResult);

            flblCantidadError.Text = m_leListaEntidades.Count.ToString();
        }


    }
}
