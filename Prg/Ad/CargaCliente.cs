using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TNGS;
using TNGS.NetApp;
using TNGS.NetRoutines;
using TNGS.NetControls;
using WeifenLuo.WinFormsUI.Docking;
using Carm.Bel;
using Carm.Shr;

namespace Carm.Ad
{
    public partial class CargaCliente : Form
    {
        private StatMsg statMessage;
        private Bel.ECliente cliente;

        public CargaCliente()
        {
            InitializeComponent();

            statMessage = new StatMsg();
            this.cliente = Bel.ECliente.NewEmpty();
        }

        public CargaCliente(Bel.ECliente cliente): this()
        {
            this.cliente = cliente;
        }

        private void CargaCliente_Load(object sender, EventArgs e)
        {
            ListaEntidades tipoInstituciones = Bll.Tablas.TinUpFull(false, statMessage);
            if (MsgRuts.AnalizeError(this, statMessage)) return;

            cdcTipoCliente.FillFromStrLEntidad(tipoInstituciones, ETipoInst.CodCmp, ETipoInst.DesCmp, "deleted");
            cdcTipoCliente.AddStrCD("", "", 0);

            ListaEntidades franquicias = Bll.Tablas.FrqUpFull(false, statMessage);
            if (MsgRuts.AnalizeError(this, statMessage)) return;

            // When new client, hide everything except main data.
            if (cliente == null)
                ftDetalleCliente.hidePages(new List<TabPage>() { tabContactos, tabEntrev, tabLlamadas, tabNotas, tabServicios });
            else
                cargarClienteEnPantalla(cliente);
        }

        private bool ValidarControles()
        {
            if (
                   (!teAnotaciones.IsValid)
                   || (!teNombreFantasia.IsValid)
                   || (!teRazonSocial.IsValid)
                   || (!cdcTipoCliente.IsValid)
                   || (!teDireccion.IsValid)
                   || (!neAltura.IsValid)
                   || (!tePisoDepto.IsValid)
                   || (!teCelular.IsValid)
                   || (!teTelefono.IsValid)
                   || (!teEmail.IsValid)
                   || (!teLocalidad.IsValid)
                   || (!tePartido.IsValid)
               )
            {
                MsgRuts.ShowMsg(this, "Revise los campos ingresados, hay valores invalidos.");
                return false;
            }
            else
            {
                return true;
            }


        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (!ValidarControles())
                return;

            cargarDatosEnCliente(cliente);

            Bll.Clientes.Save(cliente, statMessage);
            if (MsgRuts.AnalizeError(this, statMessage)) return;

            MsgRuts.ShowMsg(this, "El Cliente ha sido guardado satisfactoriamente");
            
            this.Close();
        }

        private void cargarDatosEnCliente(ECliente cliente)
        {
            cliente.Rsocial = teRazonSocial.Text;
            cliente.Nombrefant = teNombreFantasia.Text;
            cliente.Codtinst = cdcTipoCliente.SelectedStrCode;
            cliente.Direccion = teDireccion.Text;
            cliente.Altura = neAltura.Numero;
            cliente.Piso = tePisoDepto.Text;
            cliente.Celular = teCelular.Text;
            cliente.Telefono1 = teTelefono.Text;
            cliente.Email = teEmail.Text;
            cliente.Observacion = teAnotaciones.Text;

            // Datos base de alta
            cliente.Alta = "N";
            cliente.Fingsima = DateTime.Now;
            cliente.Cargador = App.Usuario.Usuario;
        }

        private void cargarClienteEnPantalla(ECliente cliente)
        {
            teRazonSocial.Text = cliente.Rsocial;
            teNombreFantasia.Text = cliente.Nombrefant;
            cdcTipoCliente.SelectedStrCode = cliente.Codtinst;
            teDireccion.Text = cliente.Direccion;
            neAltura.Numero = cliente.Altura;
            tePisoDepto.Text = cliente.Piso;
            teCelular.Text = cliente.Celular;
            teTelefono.Text = cliente.Telefono1;
            teEmail.Text = cliente.Email;
            teLocalidad.Text = cliente.Codlocalidad;
            teAnotaciones.Text = cliente.Observacion;

            mrLlamadas.fill(cliente.CliLlamadas, "Llamadas", statMessage);
            mrEntrevistas.fill(cliente.CliEntrevistas, "Entrevistas", statMessage);
            mrContactos.fill(cliente.CliContactos, "Contactos", statMessage);
            mrServicios.fill(cliente.CliServicios, "Servicios", statMessage);
            mrNotas.fill(cliente.CliNotas, "Notas", statMessage);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gbCargarLocalidad_Click(object sender, EventArgs e)
        {
            // Llamamos al metodo que levanta la ventana para las localidades del pais, el true es para permitirle que no elija ninguna.
            Bel.ELocalidad l_eLocalidad = SysRuts.fGetLocalidadesPais(this, true);
            if (l_eLocalidad != null)
            {
                // Cargamos los valores resultantes en pantalla.
                teLocalidad.Text = l_eLocalidad.Nombre;
                tePartido.Text = l_eLocalidad.Partido;

                cliente.Codlocalidad = l_eLocalidad.Codpost;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gbCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
