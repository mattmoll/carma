using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Carm.Shr
{
    public partial class Precio : FormBase
    {
        // Esta clase es derivada de FormBase que tiene el miembro resultado y el metodo dameString
        // por lo tanto solo debemos llenar esa string con la logica particular.
        public Precio()
        {
            InitializeComponent();
        }

        // Guardamos en el miembro el valor cargado.
        private void gbConfirm_Click(object sender, EventArgs e)
        {
            base.m_strResultado = dePrecio.Decimal.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
