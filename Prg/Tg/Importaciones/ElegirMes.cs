using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TNGS.NetRoutines;
using TNGS.NetApp;

namespace Carm.Tg
{
    public partial class ElegirMes : Form
    {
        public DateTime fechaElegida = new DateTime(1900,1,31);

        public ElegirMes()
        {
            InitializeComponent();

            // Cargamos el año actual y la lsita de meses.
            neAño.Numero = DateTime.Today.Year;
            cdcMeses.AddIntCD(1, "Enero", 0);
            cdcMeses.AddIntCD(2, "Febrero", 0);
            cdcMeses.AddIntCD(3, "Marzo", 0);
            cdcMeses.AddIntCD(4, "Abril", 0);
            cdcMeses.AddIntCD(5, "Mayo", 0);
            cdcMeses.AddIntCD(6, "Junio", 0);
            cdcMeses.AddIntCD(7, "Julio", 0);
            cdcMeses.AddIntCD(8, "Agosto", 0);
            cdcMeses.AddIntCD(9, "Septiembre", 0);
            cdcMeses.AddIntCD(10, "Octubre", 0);
            cdcMeses.AddIntCD(11, "Noviembre", 0);
            cdcMeses.AddIntCD(12, "Diciembre", 0);
            cdcMeses.Sorted = true;
        }

        private void gbAceptar_Click(object sender, EventArgs e)
        {
            int month = cdcMeses.SelectedIntCode;
            if (month == -1)
                this.DialogResult = DialogResult.Cancel;
            else
            {
                fechaElegida = new DateTime(neAño.Numero, cdcMeses.SelectedIntCode, 1);
                this.DialogResult = DialogResult.OK;
            }

            this.Close();
        }

        private void ElegirMes_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Si no eligio un mes (el dia 31 esta fijado en el inicio del form), no lo dejamos salir.
            if (fechaElegida.Day == 31)
            {
                MsgRuts.ShowMsg(this, "No puede cerrar la ventana sin haber elegido un mes. Si desea cancelar la importacion elija un mes cualquiera y cierre la pantalla siguiente.");
                e.Cancel = true;
            }
        }
    }
}
