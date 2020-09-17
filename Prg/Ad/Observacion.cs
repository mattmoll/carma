using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TNGS.NetApp;

namespace Carm.Ad
{
    public partial class Observacion : Form
    {
        // Constructor
        public Observacion()
        {
            InitializeComponent();
            this.Obs = "";
        }

        // Evento del boton aceptar que guarda la observacion en la property y cierra el form con estado ok.
        private void gbAccept_Click(object sender, EventArgs e)
        {
            if (teObservacion.Text.Length <= 120)
            {
                Obs = teObservacion.Text.Trim();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MsgRuts.ShowMsg(this, "La observación debe contener 120 caracteres como máximo");
        }

        public string Obs { get; private set; }

        // Evento del boton cancel que cierra el form con estado erroneo.
        private void gbCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
