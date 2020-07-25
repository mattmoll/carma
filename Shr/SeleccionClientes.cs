using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using WeifenLuo.WinFormsUI.Docking;
using System.Linq;
using TNGS.NetRoutines;
using TNGS.NetControls;
using TNGS.NetAppBll;
using Sima;
using Carm.Bll;
using Carm.Shr;
using Carm.Bel;

namespace Carm.Shr
{
    public partial class SeleccionClientes : Form
    {
        public enum formMode { cambioVisibilidad = 0, seleccionClientesMails, cambioVendidos };

        StatMsg m_smResult = new StatMsg();
        BusquedaSecretaria m_bsBusqueda = new BusquedaSecretaria();
        formMode modoFormulario;

        private enum cambioVisibilidad { habilitar, deshabilitar };

        public SeleccionClientes(formMode modoFormulario = formMode.cambioVisibilidad)
        {
            InitializeComponent();

            // Aplicamos los nieves de seguridad
            AppRuts.App_ApplySecurity(this);

            this.modoFormulario = modoFormulario;

            if (modoFormulario == formMode.cambioVisibilidad)
                mpPanelesOperativos.SelectedPage = mppCambioVisibilidades;
            else if (modoFormulario == formMode.seleccionClientesMails)
            {
                mpPanelesOperativos.SelectedPage = mppSeleccionarClientes;
                listaClientesSeleccionados = new List<ECliente>();
            }
            else
                mpPanelesOperativos.SelectedPage = mppCambioVendido;
        }

        private void updateClientCount()
        {
            flCantidad.Text = String.Format("Se recuperaron {0} Clientes/s", mrClientes.Count);
        }

        public SeleccionClientes(int dummy)
            : this(formMode.cambioVendidos)
        {

        }

        private void CambioMarcasXCliente_Load(object sender, EventArgs e)
        {
            // Cargamos las marcas
            ListaEntidades l_leMarcas = Bll.Tablas.MrcUpFull(false, m_smResult);
            if (AppRuts.MsgRuts_AnalizeError(this, m_smResult)) return;
            cdcMarcas.FillFromStrLEntidad(l_leMarcas, Bel.EMarca.CodCmp, Bel.EMarca.DesCmp, "deleted");
            cdcMarcas.AddStrCD("", "", 0);
            cdcMarcas.SelectedStrCode = "";

            // Disparamos el formulario de busqueda.
            BusquedaClientes l_frmBusqueda = new BusquedaClientes(m_bsBusqueda);
            l_frmBusqueda.ShowDialog(this);
            if (l_frmBusqueda.DialogResult == DialogResult.OK)
            {
                m_bsBusqueda = l_frmBusqueda.filtrosBusqueda;
                cargarClientes();
            }

            // No poner codigo aca!! El unico estado valido es dentro del dialogResult = OK.
            
        }


        #region Operaciones

        private void gbAgregarFiltros_Click(object sender, EventArgs e)
        {
            BusquedaClientes l_fArmaFiltros;

            // Instanciamos el form con el objeto busqueda
            l_fArmaFiltros = new BusquedaClientes(m_bsBusqueda);
            l_fArmaFiltros.ShowDialog();

            // Recuperamos la busqueda armada en el form.
            if (l_fArmaFiltros.DialogResult == DialogResult.OK)
            {
                // Cargamos los filtros.
                m_bsBusqueda = l_fArmaFiltros.filtrosBusqueda;

                // Actualizamos la grilla.
                cargarClientes();
            }
        }

        private void gbAgregarVisibilidad_Click(object sender, EventArgs e)
        {
            string l_strWarning = "";
            bool l_boolMostrarWarning = false;
            if (mrClientes.Count > 5000)
            {
                l_strWarning = "Esta operacion podria demorar algunos minutos, ¿desea realizarla de todas maneras?";
                l_boolMostrarWarning = true;
            }
            else if (mrClientes.Count > 1000)
            {
                l_boolMostrarWarning = true;
                l_strWarning = "Esta operacion podria demorar un poco, ¿desea realizarla de todas maneras?";
            }

            if (l_boolMostrarWarning)
                if (AppRuts.MsgRuts_AskUser(this, l_strWarning) == AskUserResults.No)
                    return;

            cambiarVisibilidad(cambioVisibilidad.habilitar);
            AppRuts.MsgRuts_ShowMsg(this, "Se ha habilitado la visibilidad de los clientes seleccionados para la empresa: " + cdcMarcas.SelectedItem.ToString());

           
            reiniciarForm();
        }

        private void gbQuitarVisibilidad_Click(object sender, EventArgs e)
        {
            cambiarVisibilidad(cambioVisibilidad.deshabilitar);
            AppRuts.MsgRuts_ShowMsg(this, "Se ha deshabilitado la visibilidad de los clientes seleccionados para la empresa: " + cdcMarcas.SelectedItem.ToString());

            reiniciarForm();
        }

        private void gbConfirmarSeleccion_Click(object sender, EventArgs e)
        {
            // Conseguimos los mails de los clientes seleccionados. El 19 es el numero de columna del mini report, que es el mail.
            List<Object[]> l_laoNumerosClientes = mrClientes.GetChecked(new int[] { 1 });

            // Validamos al menos 1 y máximo 50.
            if (l_laoNumerosClientes.Count < 1)
            {
                AppRuts.MsgRuts_ShowMsg(this, "Debe seleccionar al menos un cliente");
                return;
            }

            if (l_laoNumerosClientes.Count > 100)
            {
                AppRuts.MsgRuts_ShowMsg(this, "No es posible realizar envio de mailing a mas de 100 clientes a la vez. Reduzca su selección");
                return;
            }

            // Llenamos la lista de clientes y cerramos exitosamente.
            foreach (var unObjectArrayConNroCliente in l_laoNumerosClientes)
            {
                ECliente l_eCliente = Bll.Clientes.Get((int)unObjectArrayConNroCliente[0], true, m_smResult);
                if (AppRuts.MsgRuts_AnalizeError(this, m_smResult)) return;
                if (l_eCliente == null) continue;
                listaClientesSeleccionados.Add(l_eCliente);
            }

            if (listaClientesSeleccionados.Count == 0)
                this.DialogResult = DialogResult.Cancel;
            else
                this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void gbMarcarVendido_Click(object sender, EventArgs e)
        {
            cambiarVendido(true);
            AppRuts.MsgRuts_ShowMsg(this, "Se ha marcado como vendidos a los clientes seleccionados");

            reiniciarForm();
        }

        private void gbMarcarNoVendido_Click(object sender, EventArgs e)
        {
            cambiarVendido(false);
            AppRuts.MsgRuts_ShowMsg(this, "Se ha marcado como no vendidos a los clientes seleccionados");

            reiniciarForm();
        }

        private void gbCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        #endregion

        private void cargarClientes()
        {
            // Obtenemos y cargamos los clientes con la busqueda definida que recibimos por parametro.
            m_bsBusqueda.aplicarPermisos = false;
            ListaEntidades l_leClientes = Bll.Clientes.fGetClientesSecretaria(m_bsBusqueda, m_smResult);
            if (AppRuts.MsgRuts_AnalizeError(this, m_smResult)) return;

            mrClientes.LoadData(l_leClientes, "Clientes", "", "", "", "", "Clientes Encontrados", m_smResult);
            updateClientCount();
        }

        private void reiniciarForm()
        {
            flCantidad.Text = "";
            m_bsBusqueda = new BusquedaSecretaria();
            cdcMarcas.SelectedStrCode = "";
            mrClientes.Clear();

            this.Close();
        }

        private void cambiarVendido(bool vendido)
        {
            List<Object[]> l_laoCodsChecked = null;

            // Conseguimos los codigos de los items que esten checked
            l_laoCodsChecked = mrClientes.GetChecked(new int[] { 1 });

            string l_strCodMarca = cdcMarcas.SelectedStrCode;
            int l_intNroCliente;

            // Armamos una string con todos los codigos checked.
            foreach (Object[] l_aoCodChecked in l_laoCodsChecked)
            {
                l_intNroCliente = (int)l_aoCodChecked[0];

                Bll.Clientes.CambiarMarcaVendido(vendido ? "S" : "N", l_intNroCliente, m_smResult);
                if (AppRuts.MsgRuts_AnalizeError(this, m_smResult)) return;
            }
        }

        private void cambiarVisibilidad(cambioVisibilidad visibilidad)
        {
            List<Object[]> l_laoCodsChecked = null;

            // Validamos.
            if (cdcMarcas.SelectedStrCode == "")
            {
                AppRuts.MsgRuts_ShowMsg(this, "Debe seleccionar una marca para la cual se asignara visibilidad a los clientes elegidos.");
                return;
            }

            // Conseguimos los codigos de los items que esten checked
            l_laoCodsChecked = mrClientes.GetChecked(new int[] { 1 });

            string l_strCodMarca = cdcMarcas.SelectedStrCode;
            Bel.EMarcaXCliente l_eMarcaXClien;
            int l_intNroCliente;

            // Armamos una string con todos los codigos checked.
            foreach (Object[] l_aoCodChecked in l_laoCodsChecked)
            {
                l_intNroCliente = (int)l_aoCodChecked[0];

                if (visibilidad == cambioVisibilidad.habilitar)
                {
                    l_eMarcaXClien = Bel.EMarcaXCliente.NewEmpty();
                    l_eMarcaXClien.Nrocliente = l_intNroCliente;
                    l_eMarcaXClien.Codmarca = l_strCodMarca;
                    Bll.Tablas.MclSave(l_eMarcaXClien, m_smResult);
                }
                else
                {
                    // Buscamos si ya existe ese registro.
                    l_eMarcaXClien = Bll.Tablas.MclGet(l_intNroCliente, l_strCodMarca, false, m_smResult);
                    if (AppRuts.MsgRuts_AnalizeError(this, m_smResult)) return;

                    // Si lo encontramos, lo borramos.
                    if (l_eMarcaXClien != null)
                        Bll.Tablas.MclRemove(l_eMarcaXClien.Nrocliente, l_eMarcaXClien.Codmarca, l_eMarcaXClien.FxdVersion, m_smResult);
                }
            }
        }

        // Propiedades
        public List<ECliente> listaClientesSeleccionados { get; private set; }

        private void SeleccionClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (modoFormulario != formMode.seleccionClientesMails)
                AppRuts.App_LockMenu(false);
        }

        private void mrClientes_FiltersChanged(object sender, EventArgs e)
        {
            updateClientCount();
        }

        private void gbTildar_Click(object sender, EventArgs e)
        {
            // Tildamos el conjunto de clientes seleccionado.
            int l_iQty = mrClientes.Count;
            if (l_iQty == -1) return;

            int l_iRowInicio = (neNumeroConjunto.Numero - 1) * 50;
            int l_iRowFin = l_iRowInicio + 50;

            if (l_iQty < l_iRowFin)
                l_iRowFin = l_iQty;
           
            for (int l_iRow = l_iRowInicio; l_iRow < l_iRowFin; l_iRow++)
                mrClientes.CheckRow(l_iRow);
            mrClientes.Refresh();
        }
    }
}
