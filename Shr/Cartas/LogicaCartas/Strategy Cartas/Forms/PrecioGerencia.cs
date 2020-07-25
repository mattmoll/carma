using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Carm.Shr
{
    public partial class PrecioGerencia : FormBase
    {
        // Esta clase es derivada de FormBase que tiene el miembro resultado y el metodo dameString
        // por lo tanto solo debemos llenar esa string con la logica particular.
        
        public PrecioGerencia()
        {
            InitializeComponent();
        }

        // Guardamos el resultado en el miembro.
        private void gbConfirm_Click(object sender, EventArgs e)
        {
            base.m_strResultado = dePrecioSL.Decimal.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
