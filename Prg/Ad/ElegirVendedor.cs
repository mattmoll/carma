using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Carm.Bll;
using Carm.Bel;
using TNGS.NetApp;
using TNGS.NetRoutines;

namespace Carm.Ad.Forms
{
    public partial class ElegirVendedor : Form
    {
        public string CodVendedorSeleccionado { get; private set; }
        StatMsg m_smResult = new StatMsg();
        string m_strFiltro = "";

        public ElegirVendedor()
        {
            InitializeComponent();
            CodVendedorSeleccionado = "";
        }

        private void ElegirVendedor_Load(object sender, EventArgs e)
        {
            App.ShowMsg("Cargando...");

            // Trae todos los vendedores existentes
            LEVendedores l_leVendedores = Vendedores.UpFull(false, m_smResult);
            l_leVendedores.AddExprColumn("Deleted", typeof(decimal), "0");
            if (m_strFiltro != "")
                l_leVendedores.Filter(m_strFiltro);
            cmbVendedores.FillFromStrLEntidad(l_leVendedores, Bel.EVendedor.CodCmp, Bel.EVendedor.UsuarioCmp, "Deleted");
            
            App.HideMsg();
        }

        private void bDetalle_Click(object sender, EventArgs e)
        {
            Shr.DetalleVendedores l_detVend = new Shr.DetalleVendedores(cmbVendedores.SelectedStrCode.ToString());
            //Carga los datos en el formulario y mostrarlo
            l_detVend.CargaDatos();
            l_detVend.ShowDialog();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

            //Guardar el codigo elegido en la property.
            CodVendedorSeleccionado = cmbVendedores.SelectedStrCode;
            this.Close();
        }

        private void ElegirVendedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CodVendedorSeleccionado == "")
                this.DialogResult = DialogResult.Cancel;
        }

        private void gbCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            CodVendedorSeleccionado = "";
            this.Close();
        }
    }
}
