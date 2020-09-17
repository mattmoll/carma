using System;
using System.Windows.Forms;
using TNGS.NetApp;
using TNGS.NetRoutines;
using Carm.Bll;
using Carm.Bel;
using System.Collections.Generic;
using Carm.Shr;

namespace Carm.Ad
{
    public partial class ResultadoLlamada : Form
    {
        StatMsg m_smResult = new StatMsg();
        int m_intNumCliente;
        DateTime m_dtFIniReserva;
        ECliLlamada m_eLlamadaProgramada;
        LEMotivosLlamadas m_leMotLlam = null;
        LECategoriasLlamada m_leCatLlam = null;
        DialogResult m_dialog = DialogResult.Cancel;
        private bool m_boolEsVendedor;
        private string m_strUsuarioLlamadaProgramada = "";
        public int numeroGestion { get; set; }

        public ResultadoLlamada(int p_intNumCliente, DateTime p_dtFIniRes, bool p_boolSoloSalientes)
        {
            InitializeComponent();

            // Pasar parámetros a miembros
            m_intNumCliente = p_intNumCliente;       
            mcCalendar.MinDate = p_dtFIniRes;
            DateTime l_dtNow = Bll.Clientes.fGetDate(m_smResult);  
            if (MsgRuts.AnalizeError(this, m_smResult)) return;
            mcCalendar.MaxDate = l_dtNow.AddDays(1); 
            teHora.Hora = l_dtNow;

            if (p_boolSoloSalientes)
                pnlLlamado.Visible = true;

            m_boolEsVendedor = p_boolSoloSalientes;
            m_dtFIniReserva = p_dtFIniRes;
        }

        // Este constructor es para llamadas programadas unicamente.
        public ResultadoLlamada(int p_intNumCliente, string p_strCodVendedor)
        {
            InitializeComponent();

            m_intNumCliente = p_intNumCliente;       

            // Obtenemos la fecha de hoy para armar el periodo posible de programacion de la llamada.
            
            DateTime l_dtNow = Bll.Clientes.fGetDate(m_smResult);    
            if (MsgRuts.AnalizeError(this, m_smResult)) return;
            Bel.EVendedor l_eVendedor = Bll.Vendedores.Get(p_strCodVendedor, false, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;
            m_strUsuarioLlamadaProgramada = l_eVendedor.Usuario;

            // Forzamos a que sea una llamada programada y que el usuario no lo pueda modificar.
            cbProgramada.Checked = true;
            cbProgramada.Enabled = false;

            gbBaja.Visible = false;
            gbRecupero.Visible = false;
            gbRegularizoDeuda.Visible = false;
        }

        public ResultadoLlamada(ECliLlamada p_eLlamadaProgramada)
        {
            InitializeComponent();

            m_eLlamadaProgramada = p_eLlamadaProgramada;
            m_intNumCliente = m_eLlamadaProgramada.Numcliente;
        }

        private void ResultadoLlamada_Load(object sender, EventArgs e)
        {
            App.ShowMsg("Cargando...");

            //Aplicamos permisos
            App.ApplySecurity(this);

            cargarContactos();

            //---Trae todas los motivos de llamada existentes
            m_leMotLlam = Tablas.MtlUpFull(false,m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;
            m_leMotLlam.AddExprColumn("Deleted", typeof(decimal), "0");

            // Cargamos todas las categorias existentes
            m_leCatLlam = Tablas.CtlUpFull(false,m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;
            m_leCatLlam.AddExprColumn("Deleted", typeof(decimal), "0");

            // Si solo tenemos que mostrar las llamadas de tipo saliente, entonces filtramos y escondemos los botones
            if (m_boolEsVendedor)
            {
                rbEntrantes.Visible = false;
                rbSalientes.Visible = false;
                m_leCatLlam.Filter("ctl_cd1_tipo = 'S'");
            }

            cdcCategorias.FillFromStrLEntidad(m_leCatLlam, Bel.ECategoriaLlamada.CodCmp, Bel.ECategoriaLlamada.DesCmp, "Deleted");
            cdcMotivos.FillFromStrLEntidad(m_leMotLlam, Bel.EMotivosLlamada.CodCmp, Bel.EMotivosLlamada.DesCmp, "Deleted");

            if (m_eLlamadaProgramada != null)
                FormEstadoCargaResultadoProgramada();

            Bel.ECliente l_eCliente = Bll.Clientes.Get(m_intNumCliente, true, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            cambiarVisibilidadOperacionesCorrespondientes(l_eCliente);

            App.HideMsg();
        }

        #region Operaciones

        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (!validarDatosLlamada())
                return;
            pGuardarLlamada();

            m_dialog = DialogResult.OK;
            this.Close();
        }

        // Evento del click del boton que provoca la baja del cliente y graba la llamada.
        private void gbBaja_Click(object sender, EventArgs e)
        {
            // Pedimos una confirmacion
            if (MsgRuts.AskUser(this, "Está a punto de dar de baja de la empresa a un cliente. ¿Está seguro?") == DialogResult.No) return;

            if (!teResultado.IsValid)
            {
                MsgRuts.ShowMsg(this, "Debe ingresar el resultado de la llamada");
                return;
            }

            // Grabamos la llamada y damos de baja al cliente.
            string l_strEsBaja = "S";
            ECliLlamada l_eCliLlamada = armaLlamada(l_strEsBaja);
            EParametro l_eCantDiasCancel = App.ParaGet("DIASCANCEL", false, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            App.ShowMsg("Grabando");
            Bll.Clientes.fBajaYBorrarServiciosFromLlamada(m_intNumCliente, l_eCantDiasCancel.VInt, l_eCliLlamada, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) { App.HideMsg(); return; }

            MsgRuts.ShowMsg(this, "El cliente fue dado de baja de la empresa exitosamente! \r\n " + 
                        "A continuación podrá cargar servicios que la competencia le brindé al cliente si tiene información sobre los mismos.");
            App.HideMsg();

            CargaServicio l_frmCargaServicios = new CargaServicio(m_intNumCliente);
            l_frmCargaServicios.ShowDialog(this);

            if (l_frmCargaServicios.DialogResult == DialogResult.OK)
            {
                // TODO
                //Bll.Clientes.fGrabaServiciosYMarcaComoCompetencia(m_intNumCliente, l_frmCargaServicios.Servicios, m_smResult);
                if (MsgRuts.AnalizeError(this, m_smResult)) return;

                MsgRuts.ShowMsg(this, "Se han grabado exitosamente los servicios de la competencia");
            }

            m_dialog = DialogResult.OK;
            this.Close();
        }

        // Carga de recupero del cliente con abono nuevo.
        private void gbRecupero_Click(object sender, EventArgs e)
        {
            // Obtenemos el nuevo abono recuperado
            PedirImporte l_frmCargaAbono = new PedirImporte();
            l_frmCargaAbono.ShowDialog();

            // Si cancelo, salimos.
            if (l_frmCargaAbono.DialogResult == DialogResult.Cancel)
                return;

            // Armamos la llamada
            string l_strEsBaja = "N";
            ECliLlamada l_ECliLlamada = armaLlamada(l_strEsBaja);

            // Actualizamos y cargamos los abonos.
            ECliente l_eCliente = Bll.Clientes.Get(m_intNumCliente, false, m_smResult);
            l_ECliLlamada.Abonoanterior = l_eCliente.Abono;
            l_ECliLlamada.Abonorecuperado = l_frmCargaAbono.importe;
            l_eCliente.Abono = l_frmCargaAbono.importe;

            // Persistimos la llamada y marcamos al cliente como recuperado. TODO no mas marca.
            //Clientes.fRecupero(l_eCliente.Numero, l_eCliente.Abono, l_ECliLlamada, l_eCliente.Codmarca, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            MsgRuts.ShowMsg(this, "El cliente fue recuperado exitosamente");

            m_dialog = DialogResult.OK;
            this.Close();
        }

        // Evento del click del boton para carga de contacto nuevo.
        private void gbNuevoContacto_Click(object sender, EventArgs e)
        {
            // Mostramos el formulario de carga de contacto, si sale todo ok grabamos.
            CargaContacto l_frmCargaContacto = new CargaContacto(m_intNumCliente);
            l_frmCargaContacto.ShowDialog(this);
            if (l_frmCargaContacto.DialogResult == DialogResult.OK)
            {
                // Grabamos el contacot y recargamos la combo.
                Bll.Clientes.ClcSave(l_frmCargaContacto.Contacto, m_smResult);
                if (MsgRuts.AnalizeError(this, m_smResult)) return;
                cargarContactos();
            }
        }

        private void gbRegularizoDeuda_Click(object sender, EventArgs e)
        {
            if (!validarDatosLlamada())
                return;

            Bel.ECliente l_eCliente = Bll.Clientes.Get(m_intNumCliente, true, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            l_eCliente.Deuda = 0;

            Bll.Clientes.Save(l_eCliente, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            ECliLlamada llamadaGenerada = pGuardarLlamada();
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            m_dialog = DialogResult.OK;
            this.Close();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        #endregion

        #region Eventos

        private void ResultadoLlamada_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = m_dialog;
        }

        // Evento del checked del radiobutton de llamadas entrantes.
        private void rbEntrantes_CheckedChanged(object sender, EventArgs e)
        {
            pnlLlamado.Visible = true;

            // Borramos el filtro actual, cargamos el nuevo y recargamos la combo.
            m_leCatLlam.Filter("");
            m_leCatLlam.Filter("ctl_cd1_tipo = 'E'");
            cdcCategorias.FillFromStrLEntidad(m_leCatLlam, "ctl_rcd_cod", "ctl_des_des", "Deleted");

        }

        // Evento del checked del radiobutton de llamadas salientes
        private void rbSalientes_CheckedChanged(object sender, EventArgs e)
        {
            pnlLlamado.Visible = true;

            // Borramos el filtro actual, cargamos el nuevo y recargamos la combo.
            m_leCatLlam.Filter("");
            m_leCatLlam.Filter("ctl_cd1_tipo = 'S'");
            cdcCategorias.FillFromStrLEntidad(m_leCatLlam, "ctl_rcd_cod", "ctl_des_des", "Deleted");
        }

        // Evento de cambio de categoria que filtra en la combo de motivos.
        private void cdcCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Quitamos el filtro actual, aplicamos el nuevo filtro y llenamos la combo.
            m_leMotLlam.Filter("");
            m_leMotLlam.Filter("mot_rcd_codcategoria = \'" + cdcCategorias.SelectedStrCode + "\' ");
            cdcMotivos.FillFromStrLEntidad(m_leMotLlam, "mot_cod_cod", "mot_des_des", "Deleted");
        }

        private void cbProgramada_CheckedChanged(object sender, EventArgs e)
        {
            pnlSeleccionTipo.Enabled = !cbProgramada.Checked;
            pnObservacionProg.Visible = cbProgramada.Checked;

            int l_intCantidadDias;

            // Si es una programada
            if (!pnlSeleccionTipo.Enabled)
            {
                limpiarCamposPanel();
                l_intCantidadDias = 60;
            }
            else
                l_intCantidadDias = 1;

            DateTime l_dtNow = Bll.Clientes.fGetDate(m_smResult);     /*Conseguimos la Fecha de hoy*/
            mcCalendar.MaxDate = l_dtNow.AddDays(l_intCantidadDias); 
        }

        #endregion

        #region Metodos Privados

        private bool validarDatosLlamada()
        {
            if (!cdcContactos.IsValid)
            {
                MsgRuts.ShowMsg(this, "Debe ingresar el contacto con el que se comunicó");
                return false;
            }
            // Si no es una llamada programada debe cargar el resultado si o si.
            if ((!cbProgramada.Checked) && (!teResultado.IsValid))
            {
                MsgRuts.ShowMsg(this, "Debe ingresar el resultado de la llamada");
                return false;
            }
            return true;
        }

        private void cargarContactos()
        {
            // Cargamos los contactos del cliente
            Bel.LECliContactos l_leCliContactos = Clientes.ClcFGet(m_intNumCliente, true, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;
            cdcContactos.FillFromIntLEntidad(l_leCliContactos, "clc_nro_numcontacto", "clc_des_nombre", "deleted");
        }

        private void limpiarCamposPanel()
        {
            teResultado.Text = "";
            cdcCategorias.SelectedStrCode = "";
            cdcMotivos.SelectedStrCode = "";
        }

        private ECliLlamada pGuardarLlamada()
        {
            string l_strEsBaja = "N";
            ECliLlamada l_ECliLlamada = armaLlamada(l_strEsBaja);

            //---Guardar entidad nueva
            Clientes.CllSave(l_ECliLlamada, m_smResult);

            if (MsgRuts.AnalizeError(this, m_smResult)) return null;

            return l_ECliLlamada;
        }

        private ECliLlamada armaLlamada(string p_strEsBaja)
        {
            // Armar fecha
            DateTime l_dtFecYHor = new DateTime(mcCalendar.SelectionStart.Year,
                mcCalendar.SelectionStart.Month,
                mcCalendar.SelectionStart.Day,
                teHora.Hora.Hour,
                teHora.Hora.Minute,
                teHora.Hora.Second);

            ECliLlamada l_ECliLlamada;

            if (m_eLlamadaProgramada != null)
                l_ECliLlamada = m_eLlamadaProgramada;
            else
            {
                // Guardar llamada
                l_ECliLlamada = ECliLlamada.NewEmpty();
                l_ECliLlamada.Numcliente = m_intNumCliente;
                l_ECliLlamada.Numllamada = -1;
                l_ECliLlamada.Numcontacto = cdcContactos.SelectedIntCode;
                l_ECliLlamada.Frealizada = l_dtFecYHor;
                l_ECliLlamada.Codusuario = DBConn.Usuario;
                l_ECliLlamada.Baja = p_strEsBaja;
                l_ECliLlamada.Obsprogramada = teObservacionProg.Text;
            }

            // Si es una llamada a programar, no tiene resultado todavia, entonces los campos van vacios.
            if (cbProgramada.Checked)
            {
                l_ECliLlamada.Codmotivo = "";
                l_ECliLlamada.Resultado = "";
                if (m_strUsuarioLlamadaProgramada != "")
                {
                    l_ECliLlamada.Codusuario = m_strUsuarioLlamadaProgramada;
                    l_ECliLlamada.Programador = DBConn.Usuario;
                }
            }
            else
            {
                l_ECliLlamada.Codmotivo = cdcMotivos.SelectedStrCode.ToString();
                l_ECliLlamada.Resultado = teResultado.Text;
            }

            return l_ECliLlamada;
        }

        private void FormEstadoCargaResultadoProgramada()
        {
            // Fijamos los datos con los que se programo la llamada
            teHora.Hora = m_eLlamadaProgramada.Frealizada;
            mcCalendar.SetDate(m_eLlamadaProgramada.Frealizada);
            cdcContactos.SelectedIntCode = m_eLlamadaProgramada.Numcontacto;
            Bel.ECliContacto contacto = Bll.Clientes.ClcGet(m_eLlamadaProgramada.Numcliente, m_eLlamadaProgramada.Numcontacto, false, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            teNTelefono.Text = contacto.getTelefono;

            // Deshabilitamos todo para que no puedan cambiarlo.
            cbProgramada.Visible = false;
            teHora.Enabled = false;
            cdcContactos.Enabled = false;
            teNTelefono.Enabled = false;
            mcCalendar.Enabled = false;
            rbSalientes.Checked = true;
        }

        private void cambiarVisibilidadOperacionesCorrespondientes(ECliente l_eCliente)
        {
            // Se puede recuperar si no es cliente, se puede dar de baja si es cliente.
            gbRecupero.Enabled = !Bll.Clientes.fEsCliente(l_eCliente);
            gbBaja.Enabled = Bll.Clientes.fEsCliente(l_eCliente);
        }

        #endregion

        private void gbReajusteAbono_Click(object sender, EventArgs e)
        {
            // Obtenemos el nuevo abono despues del ajuste
            PedirImporte l_frmCargaAbono = new PedirImporte();
            l_frmCargaAbono.ShowDialog();

            // Si cancelo, salimos.
            if (l_frmCargaAbono.DialogResult == DialogResult.Cancel)
                return;

            ECliLlamada l_ECliLlamada = armaLlamada(p_strEsBaja:"N");
            ECliente l_eCliente = Bll.Clientes.Get(m_intNumCliente, false, m_smResult);
            l_ECliLlamada.Abonoanterior = l_eCliente.Abono;
            l_ECliLlamada.Ajuste = l_frmCargaAbono.importe - l_ECliLlamada.Abonoanterior;

            l_eCliente.Abono = l_frmCargaAbono.importe;

            Bll.Clientes.fGrabarLlamadaYCliente(l_eCliente, l_ECliLlamada, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            MsgRuts.ShowMsg(this, "El abono del cliente fue ajustado correctamente.");

            m_dialog = DialogResult.OK;
            this.Close();
        }

        private void cdcContactos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bel.ECliContacto contacto = Bll.Clientes.ClcGet(m_intNumCliente, cdcContactos.SelectedIntCode, false, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            teNTelefono.Text = contacto.getTelefono;
        }

    }
}
