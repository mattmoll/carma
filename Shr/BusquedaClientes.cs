﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Carm.Bll;
using TNGS.NetAppBll;
using TNGS.NetRoutines;
using TNGS.NetControls;

namespace Carm.Shr
{
    public partial class BusquedaClientes : Form
    {
        // Miembros
        StatMsg m_smResult = new StatMsg();
        Bel.LEFranquicias m_leFranquicias;
        Bel.LERubros m_leRubros;
        Bel.LEZonas m_leZonas;
        ListaEntidades m_leTiposInsts;
        ListaEntidades m_leLocalidades;

        Bll.BusquedaSecretaria m_bsBusqueda;

        // Constructor 
        public BusquedaClientes(Bll.BusquedaSecretaria p_bsUltimaBusqueda)
        {
            InitializeComponent();

            // Pasamos a los miembros los parametros.
            m_bsBusqueda = p_bsUltimaBusqueda;
        }

        // Evento de load del form que se encarga de cargar todo en pantalla
        private void BusquedaClientesSecretaria_Load(object sender, EventArgs e)
        {
            AppRuts.App_ShowMsg("Cargando...");

            ListaEntidades l_leMarcas = Tablas.MrcUpFull(false, m_smResult);
            if (AppRuts.MsgRuts_AnalizeError(this, m_smResult)) return;
            cargaCombo(l_leMarcas, cdcMarcas, Bel.EMarca.CodCmp, Bel.EMarca.DesCmp);

            // Trae todas las franquicias existentes a un comboBox
            m_leFranquicias = Tablas.FrqUpFull(false, m_smResult);
            if (AppRuts.MsgRuts_AnalizeError(this, m_smResult)) return;
            cargaCombo(m_leFranquicias, cmbFranquicias, Bel.EFranquicia.CodCmp, Bel.EFranquicia.DesCmp);

            // Trae todas los rubros existentes a un comboBox
            m_leRubros = Tablas.RbrUpFull(false, m_smResult);
            if (AppRuts.MsgRuts_AnalizeError(this, m_smResult)) return;
            filtraRubros();
            cargaCombo(m_leRubros,cmbRubros,Bel.ERubro.CodCmp, Bel.ERubro.DesCmp);

            // Trae todas las tipos de instituciones existentes a una comboBox.
            m_leTiposInsts = Tablas.TinUpFull(false, m_smResult);
            if (AppRuts.MsgRuts_AnalizeError(this, m_smResult)) return;
            filtraTiposInst();
            cargaCombo(m_leTiposInsts, cmbTiposInsts, Bel.ETipoInst.CodCmp, Bel.ETipoInst.DesCmp);

            // Trae todas las zonas existentes a un comboBox
            m_leZonas = Tablas.ZnsUpFull(false, m_smResult);
            if (AppRuts.MsgRuts_AnalizeError(this, m_smResult)) return;
            cargaCombo(m_leZonas, cmbZonas, Bel.EZona.CodCmp, Bel.EZona.NombreCmp);

            // Mostramos en pantalla los filtros cargados.
            neNumero.Text = m_bsBusqueda.Numero;
            neNumeroAvalon.Text = m_bsBusqueda.NumeroAvalon;
            teRSocial.Text = m_bsBusqueda.Rsocial;
            teNombreFant.Text = m_bsBusqueda.NFant;
            teCargador.Text = m_bsBusqueda.Cargador;
            teCodVend.Text = m_bsBusqueda.CodVend;
            cdcMarcas.SelectedStrCode = m_bsBusqueda.Marca.PadLeft(2, ' ');
            cmbFranquicias.SelectedStrCode = m_bsBusqueda.Franq.PadLeft(4, ' ');
            cmbRubros.SelectedStrCode = m_bsBusqueda.Rubro.PadLeft(2, ' ');
            cmbTiposInsts.SelectedStrCode = m_bsBusqueda.TInst.PadLeft(4, ' ');
            cmbZonas.SelectedStrCode = m_bsBusqueda.Zona.PadLeft(2, ' ');
            cmbLocalidades.SelectedStrCode = m_bsBusqueda.Loc.PadLeft(8, ' ');
            teDir.Text = m_bsBusqueda.Dir;
            neAltura.Text = m_bsBusqueda.Altura;
            teTelefono.Text = m_bsBusqueda.Telefono;

            // Chequeamos los radiobuttons correspondientes a cada filtro.
            checkRadioButton(m_bsBusqueda.Reservado, rbResSi, rbResNo, rbResAmbos);
            checkRadioButton(m_bsBusqueda.ConError, rbErrSi, rbErrNo, rbErrAmbos);
            checkRadioButton(m_bsBusqueda.Vendido, rbVndSi, rbVndNo, rbVndAmbos);
            checkRadioButton(m_bsBusqueda.Mayorista, rbMaySi, rbMayNo, rbMayAmbos);
            checkRadioButton(m_bsBusqueda.Competencia, rbCompetenciaSi, rbCompetenciaNo, rbCompetenciaAmbos);
            checkRadioButton(m_bsBusqueda.MailCargado, rbMailCargadoSi, rbMailCargadoNo, rbMailCargadoAmbos);
            checkRadioButton(m_bsBusqueda.Deudor, rbDeudoresSi, rbDeudoresNo, rbDeudoresAmbos);

            AppRuts.App_HideMsg();
        }

        #region Eventos

        // Evento del click del boton que dispara la busqueda definida en pantalla
        private void gbBuscar_Click(object sender, EventArgs e)
        {
            // Obtenemos las condiciones especificadas por el usuario.
            cargarDatosDePantallaAModelo();
            

            //Si todos los campos están vacios, tirar mensaje de error y cancelar búsqueda
            if (m_bsBusqueda.busquedaVacia())
            {
                AppRuts.MsgRuts_ShowMsg(this, "Debe especificar al menos un parámetro para la búsqueda, no es factible traer todos los clientes sin filtro alguno.");
                return;
            }

            this.DialogResult = DialogResult.OK;

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
            m_bsBusqueda.Marca = cdcMarcas.SelectedStrCode.ToString().Trim();
            m_bsBusqueda.Franq = cmbFranquicias.SelectedStrCode.ToString().Trim();
            m_bsBusqueda.Rubro = cmbRubros.SelectedStrCode.ToString().Trim();
            m_bsBusqueda.TInst = cmbTiposInsts.SelectedStrCode.ToString().Trim();
            m_bsBusqueda.Zona = cmbZonas.SelectedStrCode.ToString().Trim();
            m_bsBusqueda.Loc = cmbLocalidades.SelectedStrCode.ToString().Trim();
            m_bsBusqueda.Dir = teDir.Text.Trim();
            m_bsBusqueda.Altura = neAltura.Numero.ToString().Trim();
            m_bsBusqueda.Telefono = teTelefono.Text.Trim();
        }

        // Evento que captura el presionado de una tecla en todos los campos y dispara la busqueda si corresponde.
        private void Every_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Si es el enter, disparamos la busqueda.
            if (e.KeyChar == '\r')
            {
                gbBuscar_Click(sender, e);
            }
        }

        // Evento de cambio del index de la combo de rubros que trae las t inst correspondientes
        private void cmbRubros_SelectedIndexChanged(object sender, EventArgs e)
        {
            AppRuts.App_ShowMsg("Cargando...");

            // Cuando cambia de rubro, traer los tipos de institución pertenecientes
            m_leTiposInsts = Tablas.TinGetTiposInstRubro(cmbRubros.SelectedStrCode, m_smResult);
            if (AppRuts.MsgRuts_AnalizeError(this, m_smResult)) return;
            m_leTiposInsts.AddExprColumn("Deleted", typeof(decimal), "0");
            filtraTiposInst();
            cmbTiposInsts.FillFromStrLEntidad(m_leTiposInsts, "tin_cod_cod", "tin_des_des", "Deleted");
            cmbTiposInsts.AddStrCD("", "", 0);
            cmbTiposInsts.SelectedStrCode = "";

            AppRuts.App_HideMsg();
        }

        // Evento de cambio del indez de la combo de zonas que trae las localidades correspondientes
        private void cmbZonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            AppRuts.App_ShowMsg("Cargando...");

            // Cuando cambia de zona, traer las localidades pertenecientes
            m_leLocalidades = Tablas.LocGetLocalidadesZona(cmbZonas.SelectedStrCode, m_smResult);
            if (AppRuts.MsgRuts_AnalizeError(this, m_smResult)) return;
            m_leLocalidades.AddExprColumn("Deleted", typeof(decimal), "0");
            cmbLocalidades.FillFromStrLEntidad(m_leLocalidades, "loc_ecd_codpost", "loc_ede_nombre", "Deleted");
            cmbLocalidades.AddStrCD("", "", 0);
            cmbLocalidades.SelectedStrCode = "";

            AppRuts.App_HideMsg();
        }

        #region Eventos para el cambio de checked de los radiobutton (un evento por cada grupo de radiobuttons)

        private void rbCheckedReservChanged(object sender, EventArgs e)
        {
            m_bsBusqueda.Reservado = cargaValorRadioButton(rbResSi, rbResNo, rbResAmbos);
        }

        private void rbCheckedErronChanged(object sender, EventArgs e)
        {
            m_bsBusqueda.ConError = cargaValorRadioButton(rbErrSi, rbErrNo, rbErrAmbos);
        }

        private void rbCheckedVendChanged(object sender, EventArgs e)
        {
            m_bsBusqueda.Vendido = cargaValorRadioButton(rbVndSi, rbVndNo, rbVndAmbos);
        }

        private void rbCheckedMayorChanged(object sender, EventArgs e)
        {
            m_bsBusqueda.Mayorista = cargaValorRadioButton(rbMaySi, rbMayNo, rbMayAmbos);
        }

        private void rbCheckedCompetenciaChanged(object sender, EventArgs e)
        {
            m_bsBusqueda.Competencia = cargaValorRadioButton(rbCompetenciaSi, rbCompetenciaNo, rbCompetenciaAmbos);
        }

        private void rbCheckedMailCargadoChanged(object sender, EventArgs e)
        {
            m_bsBusqueda.MailCargado = cargaValorRadioButton(rbMailCargadoSi, rbMailCargadoNo, rbMailCargadoAmbos);
        }

        private void rbDeudores_CheckedChanged(object sender, EventArgs e)
        {
            m_bsBusqueda.Deudor = cargaValorRadioButton(rbDeudoresSi, rbDeudoresNo, rbDeudoresAmbos);
        }

        #endregion

        #endregion

        #region Metodos publicos

        public void habilitarBusquedaExistencial()
        {
            gbBusquedaExistencial.Visible = true;
        }

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

        private void filtraRubros()
        {
            // Filtramos el rubro cargadoExcel para que no le aparezca en pantalla
            m_leRubros.Filter("rbr_rcd_cod <> ' 1'");
        }

        private void filtraTiposInst()
        {
            // Filtra el tipo de institucion cargadoExcel para que no le aparezca en pantalla.
            m_leTiposInsts.Filter("tin_cod_cod <> '   1'");
        }

        #endregion


        // Propiedades
        public BusquedaSecretaria filtrosBusqueda
        {
            get { return m_bsBusqueda; }
        }

        private void gbBusquedaExistencial_Click(object sender, EventArgs e)
        {
            // Obtenemos las condiciones especificadas por el usuario.
            cargarDatosDePantallaAModelo();

            //Si todos los campos están vacios, tirar mensaje de error y cancelar búsqueda
            if (m_bsBusqueda.busquedaVacia())
            {
                AppRuts.MsgRuts_ShowMsg(this, "Debe especificar al menos un parámetro para la búsqueda, no es factible traer todos los clientes sin filtro alguno.");
                return;
            }
            
            // Para busqueda existencial necesitamos que no se filtre ningun cliente (deshabilitamos esquema de permisos).
            bool estadoPermisos = m_bsBusqueda.aplicarPermisos;
            m_bsBusqueda.aplicarPermisos = false;
            ListaEntidades l_leClientes = Bll.Clientes.fGetClientesSecretaria(m_bsBusqueda, m_smResult);
            m_bsBusqueda.aplicarPermisos = estadoPermisos;

            // Si no hay clientes.
            if (l_leClientes.Count == 0)
                AppRuts.MsgRuts_ShowMsg(this, "La busqueda que usted realizo no trajo ningun cliente. Por lo tanto el mismo no está cargado, " +
                                       "al menos con esos datos exactos, en la base de datos.");
            else
                AppRuts.MsgRuts_ShowMsg(this, "Existe al menos un cliente que cumple con la busqueda realizada. " +
                                      "Si no puede verlo en las busquedas normales es debido al esquema de permisos.");
            

        }

        private void gbCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}