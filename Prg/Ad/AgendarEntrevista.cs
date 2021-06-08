using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TNGS.NetApp;
using TNGS.NetRoutines;
using Carm.Bll;
using Carm.Bel;
using WeifenLuo.WinFormsUI.Docking;

namespace Carm.Ad
{
    public partial class AgendarEntrevista : Form
    {
        StatMsg statMessage = new StatMsg();
        int nroCliente;

        public AgendarEntrevista(int nroCliente)
        {
            InitializeComponent();
            this.nroCliente = nroCliente;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gbAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            btnExit_Click(sender, e);
        }

        private void gbCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            btnExit_Click(sender, e);
        }
    }
}
