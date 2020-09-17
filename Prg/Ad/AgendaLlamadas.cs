using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TNGS.NetApp;
using TNGS.NetRoutines;

namespace Carm.Ad
{
    public partial class AgendaLlamadas : Form
    {
        StatMsg m_smResult = new StatMsg();

        public AgendaLlamadas()
        {
            InitializeComponent();

            // Obtenemos el codigo de usuario y lo cargamos en pantalla.
            lblTitulo.Text += DBConn.Usuario;
        }

        private void AgendaLlamadas_Load(object sender, EventArgs e)
        {
            // Recuperamos la lista de llamadas programadas y la cargamos a pantalla.
            ListaEntidades l_leLlamadasProgramadas = Bll.Clientes.CllGetProgramadas(DBConn.Usuario, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            // Validamos que haya al menos una.
            if (l_leLlamadasProgramadas.Count < 1)
                MsgRuts.ShowMsg(this, "No se encontraron llamadas programadas");


            // Borramos los captions que no queremos mostrar al usuario.
            l_leLlamadasProgramadas.ChangeCaption("cll_nro_numcliente", "V1ClienteNN2");
            l_leLlamadasProgramadas.ChangeCaption("cll_nro_numllamada", "V1LlamadaNN2");
            l_leLlamadasProgramadas.ChangeCaption("cli_ede_rsocial", "V1Razón SocialCN1");
            l_leLlamadasProgramadas.ChangeCaption("cll_fyh_frealizada", "V1Fecha ProgramadaFN2");
            l_leLlamadasProgramadas.ChangeCaption("clc_des_nombre", "V1ContactoCN1");

            // Cargamos el resultado en el mini report.
            mrLlamadas.LoadData(l_leLlamadasProgramadas, "", "", "SIMA", "", "", "Llamadas Programadas", m_smResult);
        }

        private void gbCompletar_Click(object sender, EventArgs e)
        {
            // Conseguimos el numero de cliente
            object l_oNumCliente = mrLlamadas.GetMatrixValueObj(0);
            if ((l_oNumCliente == null) || (l_oNumCliente == DBNull.Value)) return;
            int l_intNumCliente = (int)l_oNumCliente;

            // Conseguimos el numero de llamada
            object l_oNumLlamada = mrLlamadas.GetMatrixValueObj(1);
            if ((l_oNumLlamada == null) || (l_oNumLlamada == DBNull.Value)) return;
            int l_intNumLlamada = (int)l_oNumLlamada;

            Bel.ECliLlamada l_eLlamadaProgramada = Bll.Clientes.CllGet(l_intNumCliente, l_intNumLlamada, true, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            ResultadoLlamada l_frmResultadoLlamada = new ResultadoLlamada(l_eLlamadaProgramada);
            l_frmResultadoLlamada.ShowDialog(this);


        }

        private void gbActualizar_Click(object sender, EventArgs e)
        {
            AgendaLlamadas_Load(this, e);
        }

        private void gbDetalleCliente_Click(object sender, EventArgs e)
        {
            //Validar numero de cliente
            object l_oNumCliente = mrLlamadas.GetMatrixValueObj(0);
            if ((l_oNumCliente == null) || (l_oNumCliente == DBNull.Value)) return;

            // Conseguimos el numero de cliente.
            int l_intNumCliente = (int)l_oNumCliente;

        }

        private void gbCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
