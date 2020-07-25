using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TNGS.NetRoutines;

namespace Carm.Shr
{
    public partial class Contacto : FormBase
    {
        Bel.ECliente cliente;

        // Esta clase es derivada de FormBase que tiene el miembro resultado y el metodo dameString
        // por lo tanto solo debemos llenar esa string con la logica particular.
        public Contacto()
        {
            InitializeComponent();
        }

        public override void inyectClient(Bel.ECliente p_eCliente)
        {
            cliente = p_eCliente;
        }

        // Guardamos en el miembro el valor cargado.
        private void gbConfirm_Click(object sender, EventArgs e)
        {
            base.m_strResultado = cdcContactos.SelectedItem.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Contacto_Load(object sender, EventArgs e)
        {
            StatMsg l_smResult = new StatMsg();
            Bel.LECliContactos contactos = Bel.LECliContactos.NewEmpty();
            if (cliente != null)
            {
                contactos = Bll.Clientes.ClcFGet(cliente.Numero, true, l_smResult);
                if (l_smResult.NOk) return;
            }

            cdcContactos.FillFromIntLEntidad(contactos, Bel.ECliContacto.NumcontactoCmp, Bel.ECliContacto.NombreCmp, "deleted");
        }
    }
}
