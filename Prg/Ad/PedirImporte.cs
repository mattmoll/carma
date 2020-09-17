using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Carm.Ad
{
    public partial class PedirImporte : Form
    {
        public decimal importe { get; private set; }

        public PedirImporte()
        {
            InitializeComponent();
        }

        public PedirImporte(string p_strNombre): this()
        {
            fullLabel1.Text = p_strNombre;
        }

        private void gbAceptar_Click(object sender, EventArgs e)
        {
            importe = dceAbono.Decimal;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void gbCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
