using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TNGS.NetRoutines;
using TNGS.NetApp;
using Carm.Bel;

namespace Carm.Ad
{
    public partial class CargaFamiliar : Form
    { 
        StatMsg statMessage = new StatMsg();
        private int nroCliente;
        private int nroIntegrante;

        public CargaFamiliar(int nroCliente, int nroIntegrante)
        {
            InitializeComponent();
            this.nroCliente = nroCliente;
            this.nroIntegrante = nroIntegrante;
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void gbCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            btnExit_Click(sender, e);
        }

        private void gbAccept_Click(object sender, EventArgs e)
        {
            if (!ValidarControles())
                return;

            Bel.ECliGrupoFamiliar familiar = getFamiliarFromScreen();
            
            Bll.Clientes.CgfSave(familiar, statMessage);
            if (MsgRuts.AnalizeError(this, statMessage)) return;

            MsgRuts.ShowMsg(this, "El familiar ha sido guardado satisfactoriamente");

            this.DialogResult = DialogResult.OK;
            btnExit_Click(sender, e);
        }

        private ECliGrupoFamiliar getFamiliarFromScreen()
        {
            var familiar = Bel.ECliGrupoFamiliar.NewEmpty();
            familiar.Numcliente = this.nroCliente;
            familiar.Numintegrante = this.nroIntegrante;
            familiar.Nombre = teNombre.Text;
            familiar.Apellido = teApellido.Text;
            familiar.Codparentesco = cdcParentesco.SelectedStrCode;
            familiar.Dni = neDocumento.Numero.ToString();
            familiar.Fechanacimiento = deFechaNacimiento.Fecha;
            familiar.Obrasocial = teObraSocial.Text;
            return familiar;
        }

        private bool ValidarControles()
        {
            string listaCamposObligatorios;
            if (camposObligatoriosIncompletos(out listaCamposObligatorios))
            {
                MsgRuts.ShowMsg(this, "Falta ingresar alguno de los campos obligatorios: " + listaCamposObligatorios);
                return false;
            }

            if (
                   (!teNombre.IsValid)
                   || (!teApellido.IsValid)
                   || (!neDocumento.IsValid)
                   || (!cdcParentesco.IsValid)
                   || (!deFechaNacimiento.IsValid)
                   || (!teObraSocial.IsValid)
               )
            {
                MsgRuts.ShowMsg(this, "Revise los campos ingresados, hay valores invalidos (resaltado en rojo).");
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool camposObligatoriosIncompletos(out string listaCamposObligatorios)
        {
            listaCamposObligatorios = "Parentesco, Nombre, Apellido, Documento, Fecha de Nacimiento.";

            return ((teNombre.Text == "") ||
                ((teApellido.Text == "") && (cdcParentesco.SelectedStrCode == "")) ||
                ((neDocumento.Numero.ToString() == "") && (deFechaNacimiento.Fecha.Year == 1900)));
        }

        private void CargaFamiliar_Load(object sender, EventArgs e)
        {
            ListaEntidades parentescos = Bll.Tablas.PrtUpFull(true, statMessage);
            if (MsgRuts.AnalizeError(this, statMessage)) return;

            cdcParentesco.FillFromStrLEntidad(parentescos, EParentesco.CodCmp, EParentesco.DesCmp);
            cdcParentesco.AddStrCD("", "");
            cdcParentesco.SelectedStrCode = "";
        }
    }
}
