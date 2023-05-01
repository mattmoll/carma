using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Carm.Bll;
using TNGS.NetApp;
using TNGS.NetRoutines;
using TNGS.NetControls;

namespace Carm.Ad
{
    public partial class BusquedaClientes : Form
    {
        // Miembros
        StatMsg m_smResult = new StatMsg();
        Bel.LEZonas m_leZonas;
        ListaEntidades m_leLocalidades;

        Bll.BusquedaAdministracion m_bsBusqueda;

        // Constructor 
        public BusquedaClientes(Bll.BusquedaAdministracion p_bsUltimaBusqueda)
        {
            InitializeComponent();

            // Pasamos a los miembros los parametros.
            m_bsBusqueda = p_bsUltimaBusqueda;
        }

        // Evento de load del form que se encarga de cargar todo en pantalla
        private void BusquedaClientesSecretaria_Load(object sender, EventArgs e)
        {
            App.ShowMsg("Cargando...");

            ListaEntidades marcas = Bll.Tablas.MrcUpFull(true, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;
            cargaCombo(marcas, cdcMarcas, Bel.EMarca.CodCmp, Bel.EMarca.DesCmp);

            cdcTipoCliente.AddStrCD("AP", "AREAS PROTEGIDAS");
            cdcTipoCliente.AddStrCD("SD", "SOCIOS DIRECTOS");
            cdcTipoCliente.AddStrCD("", "");
            cdcTipoCliente.SelectedStrCode = "";

            // Trae todas las zonas existentes a un comboBox
            m_leZonas = Tablas.ZnsUpFull(false, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;
            cargaCombo(m_leZonas, cmbZonas, Bel.EZona.CodCmp, Bel.EZona.NombreCmp);

            // Mostramos en pantalla los filtros cargados.
            neNumero.Text = m_bsBusqueda.Numero;
            neNumeroAvalon.Text = m_bsBusqueda.NumeroAvalon;
            teRSocial.Text = m_bsBusqueda.Rsocial;
            teNombreFant.Text = m_bsBusqueda.NFant;
            teCargador.Text = m_bsBusqueda.Cargador;
            teCodVend.Text = m_bsBusqueda.CodVend;
            cdcMarcas.SelectedStrCode = m_bsBusqueda.Marca.PadLeft(2, ' ');
            cmbZonas.SelectedStrCode = m_bsBusqueda.Zona.PadLeft(2, ' ');
            cmbLocalidades.SelectedStrCode = m_bsBusqueda.Loc.PadLeft(8, ' ');
            teDir.Text = m_bsBusqueda.Dir;
            neAltura.Text = m_bsBusqueda.Altura;
            teTelefono.Text = m_bsBusqueda.Telefono;
            cdcTipoCliente.SelectedStrCode = m_bsBusqueda.TipoCliente.PadLeft(2, ' ');
            teInicialDesde.Text = m_bsBusqueda.InicialDesde;
            teInicialHasta.Text = m_bsBusqueda.InicialHasta;
            deFechaCargaDesde.Fecha = m_bsBusqueda.FechaCargaDesde;
            deFechaCargaHasta.Fecha = m_bsBusqueda.FechaCargaHasta;
            deFechaProxContactoDesde.Fecha = m_bsBusqueda.FechaProxContactoDesde;
            deFechaProxContactoHasta.Fecha = m_bsBusqueda.FechaProxContactoHasta;

            // Chequeamos los radiobuttons correspondientes a cada filtro.
            checkRadioButton(m_bsBusqueda.Vendido, rbVndSi, rbVndNo, rbVndAmbos);
            checkRadioButton(m_bsBusqueda.Rellamar, rbRellamarSi, rbRellamarNo, rbRellamarAmbos);
            checkRadioButton(m_bsBusqueda.ReintarLlamado, rbReintentarLlamadaSi, rbReintentarLlamadaNo, rbReintentarLlamadaAmbos);
            checkRadioButton(m_bsBusqueda.SinLlamadas, rbSinLlamadasSi, rbSinLlamadasNo, rbSinLlamadasAmbos);

            App.HideMsg();
        }

        #region Eventos
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Obtenemos las condiciones especificadas por el usuario.
            cargarDatosDePantallaAModelo();

            //Si todos los campos están vacios, tirar mensaje de error y cancelar búsqueda
            if (m_bsBusqueda.busquedaVacia())
            {
                MsgRuts.ShowMsg(this, "Debe especificar al menos un parámetro para la búsqueda, no es factible traer todos los clientes sin filtro alguno.");
                return;
            }

            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cargarDatosDePantallaAModelo()
        {
            m_bsBusqueda.Numero = neNumero.Numero.ToString().Trim();
            m_bsBusqueda.NumeroAvalon = neNumeroAvalon.Numero.ToString().Trim();
            m_bsBusqueda.Rsocial = teRSocial.Text.Trim();
            m_bsBusqueda.NFant = teNombreFant.Text.Trim();
            m_bsBusqueda.CodVend = teCodVend.Text.Trim();
            m_bsBusqueda.Cargador = teCargador.Text.Trim();
            m_bsBusqueda.TipoCliente = cdcTipoCliente.SelectedStrCode.Trim();
            m_bsBusqueda.Marca = cdcMarcas.SelectedStrCode.ToString().Trim();
            m_bsBusqueda.Zona = cmbZonas.SelectedStrCode.ToString().Trim();
            m_bsBusqueda.Loc = cmbLocalidades.SelectedStrCode.ToString().Trim();
            m_bsBusqueda.Dir = teDir.Text.Trim();
            m_bsBusqueda.Altura = neAltura.Numero.ToString().Trim();
            m_bsBusqueda.Telefono = teTelefono.Text.Trim();
            m_bsBusqueda.InicialDesde = teInicialDesde.Text.Trim();
            m_bsBusqueda.InicialHasta = teInicialHasta.Text.Trim();
            m_bsBusqueda.FechaCargaDesde = deFechaCargaDesde.Fecha;
            m_bsBusqueda.FechaCargaHasta = deFechaCargaHasta.Fecha;
            m_bsBusqueda.FechaProxContactoDesde = deFechaProxContactoDesde.Fecha;
            m_bsBusqueda.FechaProxContactoHasta = deFechaProxContactoHasta.Fecha;
        }

        // Evento que captura el presionado de una tecla en todos los campos y dispara la busqueda si corresponde.
        private void Every_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Si es el enter, disparamos la busqueda.
            if (e.KeyChar == '\r')
            {
                btnBuscar_Click(sender, e);
            }
        }

        // Evento de cambio del indez de la combo de zonas que trae las localidades correspondientes
        private void cmbZonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            App.ShowMsg("Cargando...");

            // Cuando cambia de zona, traer las localidades pertenecientes
            m_leLocalidades = Tablas.LocGetLocalidadesZona(cmbZonas.SelectedStrCode, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;
            m_leLocalidades.AddExprColumn("Deleted", typeof(decimal), "0");
            cmbLocalidades.FillFromStrLEntidad(m_leLocalidades, "loc_ecd_codpost", "loc_ede_nombre", "Deleted");
            cmbLocalidades.AddStrCD("", "", 0);
            cmbLocalidades.SelectedStrCode = "";

            App.HideMsg();
        }

        #region Eventos para el cambio de checked de los radiobutton (un evento por cada grupo de radiobuttons)

        private void rbCheckedVendChanged(object sender, EventArgs e)
        {
            m_bsBusqueda.Vendido = cargaValorRadioButton(rbVndSi, rbVndNo, rbVndAmbos);
        }

        #endregion

        #endregion


        #region Metodos Privados

        private void cargaCombo(ListaEntidades p_leListaEntidad, CDCombo p_cdcCombo, string p_strCampoCodigo, string p_strCampoDes)
        {
            p_leListaEntidad.AddExprColumn("Deleted", typeof(decimal), "0");
            p_cdcCombo.FillFromStrLEntidad(p_leListaEntidad, p_strCampoCodigo, p_strCampoDes, "Deleted");
            p_cdcCombo.AddStrCD("", "", 0);
            p_cdcCombo.SelectedStrCode = "";
        }

        // Carga el valor correspondiente en el filtro, segun el radiobutton checked.
        private string cargaValorRadioButton(RadioButton p_rbSi, RadioButton p_rbNo, RadioButton p_rbAmbos)
        {
            if (p_rbSi.Checked)
                return "S";
            if (p_rbNo.Checked)
                return "N";
            if (p_rbAmbos.Checked)
                return "A";
            // Si no hubiese ninguno checked devolvemos ambos.
            return "A";
        }

        // Pone en checked el radio button que corresponda segun el valor del filtro que recibe por parametro.
        private void checkRadioButton(string p_strFiltro, RadioButton p_rbSi, RadioButton p_rbNo, RadioButton p_rbAmbos)
        {
            switch (p_strFiltro)
            {
                case "S": { p_rbSi.Checked = true; break; }
                case "N": { p_rbNo.Checked = true; break; }
                case "A": { p_rbAmbos.Checked = true; break; }
            }
        }

        #endregion


        // Propiedades
        public BusquedaAdministracion filtrosBusqueda
        {
            get { return m_bsBusqueda; }
        }

        private void rbRellamar_CheckedChanged(object sender, EventArgs e)
        {
            m_bsBusqueda.Rellamar = cargaValorRadioButton(rbRellamarSi, rbRellamarNo, rbRellamarAmbos);
        }

        private void rbReintentarLlamado_CheckedChanged(object sender, EventArgs e)
        {
            m_bsBusqueda.ReintarLlamado = cargaValorRadioButton(rbReintentarLlamadaSi, rbReintentarLlamadaNo, rbReintentarLlamadaAmbos);
        }
        private void rbSinLlamadas_CheckedChanged(object sender, EventArgs e)
        {
            m_bsBusqueda.SinLlamadas = cargaValorRadioButton(rbSinLlamadasSi, rbSinLlamadasNo, rbSinLlamadasAmbos);
        }
    }
}
