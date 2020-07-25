using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Carm.Shr
{
    public partial class FormBase : Form
    {
        // Definimos el miembro resultado y lo cargamos vacio. Entonces si cierran la ventana y no se llena el valor, tendrá vacio.
        protected string m_strResultado = "";
        public string codigoAReemplazar { get; set; }

        public FormBase()
        {
            InitializeComponent();
        }

        // Definimos este metodo para que puedan hacer override las clases derivadas si necesitasen el cliente.
        virtual public void inyectClient(Bel.ECliente p_eCliente)
        {

        }

        virtual public bool debePedirInputNuevamente()
        {
            return false;
        }

        // Devolvemos el resultado.
        public string dameString()
        {
            return m_strResultado;
        }
    }
}
