using Carm.Bll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TNGS.NetApp;
using TNGS.NetRoutines;

namespace Carm.Ad
{
    public partial class Home : Form
    {
        Bll.BusquedaAdministracion estadoBusqueda;
        StatMsg statMessage = new StatMsg();

        public Home()
        {
            InitializeComponent();
			
			App.SetMainWindow(this, null, (ToolStrip)null, null, null, null, null, null);

            estadoBusqueda = new Bll.BusquedaAdministracion();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Home_Activated(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void gbBusqueda_Click(object sender, EventArgs e)
        {
            BusquedaClientes busquedaForm = new BusquedaClientes(estadoBusqueda);
            busquedaForm.ShowDialog(this);

            // Recuperamos la busqueda armada en el form.
            if (busquedaForm.DialogResult == DialogResult.OK)
            {
                // Cargamos los filtros.
                estadoBusqueda = busquedaForm.filtrosBusqueda;

                // Actualizamos la grilla.
                realizarBusqueda();
            }
        }

        private void gbDetalle_Click(object sender, EventArgs e)
        {
            int nroCliente = getClientNumberSelected();
            if (nroCliente == 0) return;

            Bel.ECliente cliente = Bll.Clientes.Get(nroCliente, true, statMessage);
            if (MsgRuts.AnalizeError(this, statMessage)) return;

            CargaCliente clienteForm = new CargaCliente(cliente);
            clienteForm.ShowDialog(this);
        }

        private void gbLlamada_Click(object sender, EventArgs e)
        {
            int nroCliente = getClientNumberSelected();
            if (nroCliente == 0) return;

            Llamada formLlamada = new Llamada(nroCliente);
            formLlamada.ShowDialog(this);
        }

        private void gbVenta_Click(object sender, EventArgs e)
        {

        }

        private void gbBorrarCliente_Click(object sender, EventArgs e)
        {
            int nroCliente = getClientNumberSelected();
            if (nroCliente == 0) return;

            if (MsgRuts.AskUser(this, "Atención!!!!\r\n" +
                                      "Está a punto de borrar físicamente un cliente, sus contactos" +
                                      " y su historial de llamadas y entrevistas. ¿Está seguro?")
                                      == DialogResult.No) return;

            Bll.Clientes.fBorraCliente(nroCliente, statMessage);
            if (MsgRuts.AnalizeError(this, statMessage)) return;

            MsgRuts.ShowMsg(this, "El cliente fue borrado exitosamente!");
            gbActualizar_Click(this, null);
        }

        private void gbCargarCliente_Click(object sender, EventArgs e)
        {
            CargaCliente cargaClienteForm = new CargaCliente();
            cargaClienteForm.ShowDialog(this);
        }


        private void realizarBusqueda()
        {
            App.ShowMsg("Cargando...");

            // Traer los clientes que cumplan con los filtros miembros
            ListaEntidades listaClientes = Bll.Clientes.fGetClientesSecretaria(estadoBusqueda, statMessage);
            if (MsgRuts.AnalizeError(this, statMessage)) return;

            cargaMiniReport(listaClientes);

            App.HideMsg();
        }

        private void cargaMiniReport(ListaEntidades listaClientes)
        {
            // Cargar en miniReport
            mrClientes.LoadData(listaClientes, "", "", "SIMA", "", "", "Clientes", statMessage);

            // Cargamos en pantalla la cantidad de registros encontrados.
            lblCantReg.Text = listaClientes.Count.ToString().Trim();
        }

        private void cmdExcel_Click(object sender, EventArgs e)
        {
            App.ShowMsg("Generando planilla...");
            App.InitAdvance("Excel");

            mrClientes.ExportToExcel();

            App.EndAdvance();
            App.HideMsg();
        }

        private void gbActualizar_Click(object sender, EventArgs e)
        {
            // Si todos los campos están vacios, tirar mensaje de error y cancelar búsqueda
            if (estadoBusqueda.busquedaVacia())
            {
                MsgRuts.ShowMsg(this, "Debe especificar al menos un parámetro para la búsqueda");
                gbAgregarFiltros_Click(this, e);
            }
            else
            {
                realizarBusqueda();
            }
        }

        private void gbAgregarFiltros_Click(object sender, EventArgs e)
        {
            // Instanciamos el form con el objeto busqueda
            BusquedaClientes busquedaForm = new BusquedaClientes(estadoBusqueda);
            busquedaForm.ShowDialog();

            // Recuperamos la busqueda armada en el form.
            if (busquedaForm.DialogResult == DialogResult.OK)
            {
                estadoBusqueda = busquedaForm.filtrosBusqueda;
                realizarBusqueda();
            }
        }

        private void gbRemoverFiltros_Click(object sender, EventArgs e)
        {
            // Delegamos en el objeto busqueda que limpie sus filtros.
            estadoBusqueda.limpiarBusqueda();

            mrClientes.Clear();
            lblCantReg.Text = "";
        }

        private int getClientNumberSelected()
        {
            object objNroCliente = mrClientes.GetMatrixValueObj(0);
            if ((objNroCliente == null) || (objNroCliente == DBNull.Value)) return 0;

            return (int)objNroCliente;
        }

        private void gbEntrevista_Click(object sender, EventArgs e)
        {
            int nroCliente = getClientNumberSelected();
            if (nroCliente == 0) return;

            AgendarEntrevista agendarEntrevista = new AgendarEntrevista(nroCliente);
            agendarEntrevista.ShowDialog(this);
        }
    }
}
