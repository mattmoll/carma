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
            ListaEntidades marcas = Bll.Tablas.MrcUpFull(true, statMessage);
            if (MsgRuts.AnalizeError(this, statMessage)) return;

            cdcMarca.FillFromStrLEntidad(marcas, EMarca.CodCmp, EMarca.DesCmp);
            cdcMarca.AddStrCD("", "");
            cdcMarca.SelectedStrCode = "";

            ListaEntidades rubros = Bll.Tablas.RbrUpFull(true, statMessage);
            if (MsgRuts.AnalizeError(this, statMessage)) return;

            cdcRubro.FillFromStrLEntidad(rubros, ERubro.CodCmp, ERubro.DesCmp);
            cdcRubro.AddStrCD("", "");
            cdcRubro.SelectedStrCode = "";
            

            cdcSexo.AddStrCD("M", "MASCULINO");
            cdcSexo.AddStrCD("F", "FEMENINO");
            cdcSexo.AddStrCD("", "");
            cdcSexo.SelectedStrCode = "";

            LESituacionesIVAs situacionesIVAs = Bll.Tablas.SivUpFull(true, statMessage);
            if (MsgRuts.AnalizeError(this, statMessage)) return;
            cdcSitIva.FillFromStrLEntidad(situacionesIVAs, ESituacionIVA.CodigoCmp, ESituacionIVA.DescripcionCmp);
            cdcSitIva.AddStrCD("", "");
            cdcSitIva.SelectedStrCode = "";

            // When new client, hide everything except main data.
            if (cliente.EsNueva)
                ftDetalleCliente.hidePages(new List<TabPage>() { tabContactos, tabEntrev, tabLlamadas, tabNotas, tabServicios });
            else
                cargarClienteEnPantalla(cliente);
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
                   (!teAnotaciones.IsValid)
                   || (!teNombreFantasia.IsValid)
                   || (!teRazonSocial.IsValid)
                   || (!teDireccion.IsValid)
                   || (!neAltura.IsValid)
                   || (!tePisoDepto.IsValid)
                   || (!teCelular.IsValid)
                   || (!teTelefono.IsValid)
                   || (!teEmail.IsValid)
                   || (!teLocalidadCobro.IsValid)
                   || (!tePartidoCobro.IsValid)
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
            listaCamposObligatorios = "Empresa Prestadora, Denominación (Razon social o Nombre), Localidad Cobro, Telefono o Celular";

            return ((cdcMarca.SelectedStrCode == "") || (teLocalidadCobro.Text == "") ||
                ((teRazonSocial.Text == "") && (teApellido.Text == "")) || 
                ((teTelefono.Text == "") && (teCelular.Text == "")));
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
            cliente.Tipocliente = getTipoCliente();
            cliente.Codmarca = cdcMarca.SelectedStrCode;
            cliente.Situacioniva = cdcSitIva.SelectedStrCode;
            cliente.Cuil = cteCUIT.Text;
            cliente.Direccion = teDireccion.Text;
            cliente.Altura = neAltura.Numero;
            cliente.Piso = tePisoDepto.Text;
            cliente.Celular = teCelular.Text;
            cliente.Telefono1 = teTelefono.Text;
            cliente.Email = teEmail.Text;

            cliente.Rsocial = teRazonSocial.Text;
            cliente.Nombrefant = teNombreFantasia.Text;

            cliente.Nombre = teNombre.Text;
            cliente.Apellido = teApellido.Text;
            cliente.Fechanacimiento = deFechaNacimiento.Fecha;
            cliente.Sexo = cdcSexo.SelectedStrCode;
            cliente.Tarjetacred = teTarjetaCredito.Text;
            cliente.Fueclienteantes = cbFueClienteAntes.Checked ? "S" : "N";

            cliente.Observacion = teAnotaciones.Text;

            // Datos base de alta
            cliente.Alta = "N";
            cliente.Fechaingreso = DateTime.Now;
            cliente.Cargador = App.Usuario.Usuario;
        }

        private string getTipoCliente()
        {
            return rbAreasProtegidas.Checked ? ECliente.CodigoAreasProtegidas : ECliente.CodigoSociosDirectos;
        }

        private void cargarClienteEnPantalla(ECliente cliente)
        {
            rbAreasProtegidas.Checked = cliente.EsAreaProtegida;
            rbSociosDirectos.Checked = cliente.EsSocioDirecto;

            cdcMarca.SelectedStrCode = cliente.Codmarca;
            cdcSitIva.SelectedStrCode = cliente.Situacioniva;
            cteCUIT.Text = cliente.Cuil;
            teDireccion.Text = cliente.Direccion;
            neAltura.Numero = cliente.Altura;
            tePisoDepto.Text = cliente.Piso;
            teCelular.Text = cliente.Celular;
            teTelefono.Text = cliente.Telefono1;
            teEmail.Text = cliente.Email;
            // TODO: Get localidad y partido fields from code. for both.
            teRazonSocial.Text = cliente.Rsocial;
            teNombreFantasia.Text = cliente.Nombrefant;

            teNombre.Text = cliente.Nombre;
            teApellido.Text = cliente.Apellido;
            deFechaNacimiento.Fecha = cliente.Fechanacimiento;
            cdcSexo.SelectedStrCode = cliente.Sexo;
            teTarjetaCredito.Text = cliente.Tarjetacred;

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
                teLocalidadCobro.Text = l_eLocalidad.Nombre;
                tePartidoCobro.Text = l_eLocalidad.Partido;

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

        private void rbAreasProtegidas_CheckedChanged(object sender, EventArgs e)
        {
            if(rbAreasProtegidas.Checked)
            {
                igAreas.Enabled = true;
                igSocios.Enabled = false;
            }
        }

        private void rbSociosDirectos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSociosDirectos.Checked)
            {
                igAreas.Enabled = false;
                igSocios.Enabled = true;
            }
        }

        private void gbBuscarLocalidadCobertura_Click(object sender, EventArgs e)
        {
            // Llamamos al metodo que levanta la ventana para las localidades del pais, el true es para permitirle que no elija ninguna.
            Bel.ELocalidad l_eLocalidad = SysRuts.fGetLocalidadesPais(this, true);
            if (l_eLocalidad != null)
            {
                // Cargamos los valores resultantes en pantalla.
                teLocalidadCobertura.Text = l_eLocalidad.Nombre;
                tePartidoCobertura.Text = l_eLocalidad.Partido;

                cliente.Codloccobertura = l_eLocalidad.Codpost;
            }
        }

        private void tgrpDatosBasicos_Load(object sender, EventArgs e)
        {

        }
    }
}
