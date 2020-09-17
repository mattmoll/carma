using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TNGS.NetRoutines;
using TNGS.NetApp;


namespace Carm.Ad
{
    public partial class CargaContacto : Form
    {
        // Miembros
        string m_strNombre,m_strCargo, m_strTel, m_strTel2, m_strInterno, m_strCel,m_strSecretaria,m_strEmail,m_strTitulo;
        int m_intNumCliente,m_intNumCont;
        StatMsg m_smResult = new StatMsg();
        bool m_boolEsNueva;
        Bel.ECliContacto m_eCliContacto;

        // Constructor para el modo de entidad nueva.
        private CargaContacto()
        {
            InitializeComponent();
        }

        // Constructor para el modo de entidad nueva. Que llama al constructor base.
        public CargaContacto(int p_intNumeroCli):this()
        {
            // Guardamos el numero del cliente y ponemos la variable global de modo en Nueva Entidad.
            m_intNumCliente = p_intNumeroCli;
            m_boolEsNueva = true;
            teTitulo.Text = "Señor";
        }

        // Constructor para el modo de busqueda por contacto.
        public CargaContacto(bool p_boolDummy)
            : this()
        {
            GBAccept.Visible = GBCancel.Visible = false;
            gbBusqueda.Visible = true;

            // Habilitamos el empty de todos los campos.
            teNNombre.EmptyValid = true;
            teNCargo.EmptyValid = true;
            teTitulo.EmptyValid = true;
            teNCelular.EmptyValid = true;
            teNTelefono.EmptyValid = true;
        }

        // Constructor para el modo de modificacion de entidad. Que llama al constructor base.
        public CargaContacto(Bel.ECliContacto p_eCliContacto)
            : this()
        {
            // Cargamos en los miembros y en pantalla la informacion del parametro.
            m_intNumCliente = p_eCliContacto.Numcliente;
            m_intNumCont = p_eCliContacto.Numcontacto;
            m_strNombre = teNNombre.Text=p_eCliContacto.Nombre;
            m_strTitulo = teTitulo.Text = p_eCliContacto.Titulo;
            m_strCargo = teNCargo.Text= p_eCliContacto.Cargo;
            m_strCel =teNCelular.Text = p_eCliContacto.Celular;
            m_strTel =teNTelefono.Text = p_eCliContacto.Telefono1;
            m_strTel2 = teTel2.Text = p_eCliContacto.Telefono2;
            m_strInterno = teInterno.Text = p_eCliContacto.Interno;
            m_strSecretaria =teNSecretaria.Text = p_eCliContacto.Secretaria;
            m_strEmail =teNEmail.Text= p_eCliContacto.Email;

            m_boolEsNueva = false;

        }

        // Evento del boton aceptar que graba la entidad.
        private void GBAccept_Click(object sender, EventArgs e)
        {
            if (NoPasaValidacion())
            {
                MsgRuts.ShowMsg(this, "Debe ingresar como minimo los datos obligatorios para un contacto");
                return;
            }

            // Creamos la entidad y le cargamos los datos.
            Bel.ECliContacto l_eCliContacto = Bel.ECliContacto.NewEmpty();
            l_eCliContacto.Numcliente = m_intNumCliente;
            cargaDatosDelForm(l_eCliContacto);

            // Si la entidad es nueva conseguimos el siguiente codigo, sino le cargamos el que tenia.
            if (m_boolEsNueva)
                l_eCliContacto.Numcontacto = App.TaloGet("nroCliCont", m_smResult).Valor;
            else
                l_eCliContacto.Numcontacto = m_intNumCont;

            finalizarExitosamente(l_eCliContacto);

        }

        private void finalizarExitosamente(Bel.ECliContacto l_eCliContacto)
        {
            // Guardamos en el miembro la entidad resultado.
            m_eCliContacto = l_eCliContacto;

            // Cargamos el resultado del form como erroneo y cerramos.
            DialogResult = System.Windows.Forms.DialogResult.OK;

            this.Close();
        }

        private void cargaDatosDelForm(Bel.ECliContacto p_eCliContacto)
        {
            p_eCliContacto.Nombre = teNNombre.Text.Trim();
            p_eCliContacto.Titulo = teTitulo.Text.Trim();
            p_eCliContacto.Secretaria = teNSecretaria.Text.Trim();
            p_eCliContacto.Telefono1 = teNTelefono.Text.Trim();
            p_eCliContacto.Celular = teNCelular.Text.Trim();
            p_eCliContacto.Telefono2 = teTel2.Text.Trim();
            p_eCliContacto.Interno = teInterno.Text.Trim();
            p_eCliContacto.Cargo = teNCargo.Text.Trim();
            p_eCliContacto.Email = teNEmail.Text.Trim();
        }

        // Metodo que chequea si ingreso los campos minimos.
        private bool NoPasaValidacion()
        {
            return (((teNNombre.Text.Trim() == "") || (teNCargo.Text.Trim() == "") || (teTitulo.Text.Trim() == "")) ||
                   ((teNCelular.Text.Trim() == "") && (teNTelefono.Text.Trim() == "")));
        }

        // Eventos de cambio de texto de los text edit de celular y telefono que se encargan de que uno de los dos datos sea obligatorio.
        private void teCelular_TextChanged(object sender, EventArgs e)
        {
            teNTelefono.EmptyValid = (teNCelular.Text.Trim() != "");
        }
        private void teTel1_TextChanged(object sender, EventArgs e)
        {
            teNCelular.EmptyValid = (teNTelefono.Text.Trim() != "");
        }

        // Evento del boton Cancel.
        private void GBCancel_Click(object sender, EventArgs e)
        {
            // Cargamos el resultado del form como erroneo y cerramos.
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        // Metodo que actualiza una entidad cli contacto qeu recibe por parametro.
        public void ActualizaContacto(ref Bel.ECliContacto p_eCliContacto)
        {
            // Si el resultado fue exitoso y se grabaron los cambios del form, entonces actualizamos la entidad
            if (m_eCliContacto != null)
            {
                // Actualizamos la entidad parametro a partir de los miembros con los datos nuevos.
                p_eCliContacto.Nombre = m_eCliContacto.Nombre;
                p_eCliContacto.Titulo = m_eCliContacto.Titulo;
                p_eCliContacto.Secretaria = m_eCliContacto.Secretaria;
                p_eCliContacto.Telefono1 = m_eCliContacto.Telefono1;
                p_eCliContacto.Celular =m_eCliContacto.Celular;
                p_eCliContacto.Telefono2 = m_eCliContacto.Telefono2;
                p_eCliContacto.Interno = m_eCliContacto.Interno;
                p_eCliContacto.Cargo = m_eCliContacto.Cargo ;
                p_eCliContacto.Email = m_eCliContacto.Email;
            }
        }

        // Propiedad que expone el miembro CliContacto.
        public Bel.ECliContacto Contacto
        {
            get { return m_eCliContacto; }
        }

        // Evento del click de buscar que carga la entidad 
        private void gbBusqueda_Click(object sender, EventArgs e)
        {
            // Creamos la entidad y le cargamos los datos.
            Bel.ECliContacto l_eCliContacto = Bel.ECliContacto.NewEmpty();
            cargaDatosDelForm(l_eCliContacto);

            finalizarExitosamente(l_eCliContacto);
        }

    }
}
