using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TNGS.NetRoutines;
using TNGS.NetAppBll;

namespace Carm.Shr
{
    public partial class ElegirMarca : Form
    {
        StatMsg m_smResult = new StatMsg();
        public string codMarcaElegido;

        public ElegirMarca(string p_strTitutlo = "Marca a Importar", string p_strCodMarcaDefault = "")
        {
            InitializeComponent();

            this.Text = p_strTitutlo;

            // Recuperamos las marcas y llenamos la combo
            Bel.LEMarcas l_leMarcas = Bll.Tablas.MrcUpFull(false, m_smResult);

            cdcMarcas.FillFromStrLEntidad(l_leMarcas, "mrc_rcd_cod", "mrc_des_des", "deleted");
            if (AppRuts.MsgRuts_AnalizeError(null, m_smResult)) return;
            cdcMarcas.AddStrCD("", "", 0);
            cdcMarcas.SelectedStrCode = p_strCodMarcaDefault;
        }

        private void gbAceptar_Click(object sender, EventArgs e)
        {
            // Conseguimos el valor elegido, validamos y cerramos el form.
            string codMarca = cdcMarcas.SelectedStrCode;

            if (codMarca == "")
                this.DialogResult = DialogResult.Cancel;
            else
            {
                this.DialogResult = DialogResult.OK;
                this.codMarcaElegido = codMarca;
            }
            this.Close();
        }
    }
}
