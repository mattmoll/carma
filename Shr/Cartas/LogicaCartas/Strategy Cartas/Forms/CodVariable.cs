using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Carm.Shr
{
    public partial class CodVariable : FormBase
    {
        public CodVariable()
        {
            InitializeComponent();
        }

        override public bool debePedirInputNuevamente()
        {
            return true;
        }

        private void gbConfirm_Click(object sender, EventArgs e)
        {
            base.m_strResultado = teReemplazo.Text.Trim();
            this.DialogResult = DialogResult.OK;
            teReemplazo.Text = "";
            this.Close();
        }

        private void CodVariable_Load(object sender, EventArgs e)
        {
            lblCodigoVar.Text = this.codigoAReemplazar;
        }
    }
}
