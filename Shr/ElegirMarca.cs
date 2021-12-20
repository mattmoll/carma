using System;
using System.Windows.Forms;
using TNGS.NetAppBll;
using TNGS.NetRoutines;

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

            cdcMarcas.FillFromStrLEntidad(l_leMarcas, Bel.EMarca.CodCmp, Bel.EMarca.DesCmp, "deleted");
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
