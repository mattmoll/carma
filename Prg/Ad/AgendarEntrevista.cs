using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TNGS.NetApp;
using TNGS.NetRoutines;
using Carm.Bll;
using Carm.Bel;
using WeifenLuo.WinFormsUI.Docking;

namespace Carm.Ad
{
    public partial class AgendarEntrevista : Form
    {
        LECliContactos m_leContactos;
        int m_intNumCliente;
        int m_intNumEntrev;
        string m_strCodVend;
        bool m_boolNuevaEnt;
        StatMsg m_smResult = new StatMsg();

        /// <summary>
        /// Pantalla para agendar nuevas entrevistas.
        /// </summary>
        /// <param name="p_intNumCliente">Número de cliente</param>
        /// <param name="p_strCodVend">Código de vendedor</param>
        /// <param name="p_strDireccion">Dirección</param>
        /// <param name="p_dateFIniRes">Fecha de inicio de reserva</param>
        /// <param name="p_dateFFinRes">Fecha de fin de reserva</param>
        public AgendarEntrevista(int p_intNumCliente, string p_strCodVend, string p_strDireccion, DateTime p_dateFIniRes, DateTime p_dateFFinRes)
        {
            InitializeComponent();
            
            //---Pasar parámetros a miembros
            m_intNumCliente = p_intNumCliente;                 /*Número de cliente*/
            m_intNumEntrev = 0;                                /*Número de entrevista*/
            monthCalendar1.MinDate = p_dateFIniRes;            /*Fecha de inicio de reserva*/
            monthCalendar1.MaxDate = p_dateFFinRes;            /*Fecha de fin de reserva*/
            teDireccion.Text = p_strDireccion;                 /*Dirección*/
            m_strCodVend = p_strCodVend;                       /*Código de vendedor*/          

            m_boolNuevaEnt = true;
        }

        /// <summary>
        /// Pantalla para editar entrevistas
        /// </summary>
        /// <param name="p_intNumCliente">Entrevista a editar</param>
        /// <param name="p_strCodVend">Código de vendedor</param>
        /// <param name="p_dateFIniRes">Fecha de inicio de reserva</param>
        /// <param name="p_dateFFinRes">Fecha de fin de reserva</param>
        public AgendarEntrevista(ECliEntrevista p_CliEntrevista, string p_strCodVend, DateTime p_dateFIniRes, DateTime p_dateFFinRes)
        {
            InitializeComponent();

            m_intNumCliente = p_CliEntrevista.Numcliente;                           /*Número de cliente*/
            m_intNumEntrev = p_CliEntrevista.Numentrev;                             /*Número de entrevista*/
            teNNombre.Text = p_CliEntrevista.Nombre;                                /*Nombre*/
            m_strCodVend = p_strCodVend;                                            /*Código de vendedor*/
            teCargo.Text = p_CliEntrevista.Cargo;                                   /*Cargo*/
            teTitulo.Text = p_CliEntrevista.Titulo;                                 /*Título*/
            teCelular.Text = p_CliEntrevista.Celular;                               /*Celular*/
            teEmail.Text = p_CliEntrevista.Email;                                   /*Email*/
            teSecretaria.Text = p_CliEntrevista.Secretaria;                         /*Secretaria*/
            teTelefono.Text = p_CliEntrevista.Telefono;                             /*Teléfono*/
            monthCalendar1.SelectionStart = p_CliEntrevista.Fcoordinada;            /*Fecha*/
            teHora.Hora = p_CliEntrevista.Fcoordinada;                              /*Hora*/
            teObservaciones.Text = p_CliEntrevista.Observaciones;                   /*Observ*/
            teDireccion.Text = p_CliEntrevista.Direccion;                           /*Dirección*/

            monthCalendar1.MinDate = DateTime.Today;                                /*Fecha de inicio de reserva*/
            monthCalendar1.MaxDate = p_dateFFinRes;                                 /*Fecha de fin de reserva*/     

            m_boolNuevaEnt = false;

            SwitchTo(FormModes.Edit2);
        }

        private void AgendarEntrevista_Load(object sender, EventArgs e)
        {
            App.ShowMsg("Cargando...");

            if (m_boolNuevaEnt)
                // Flag que indica si es una nueva entrevista
                SwitchTo(FormModes.Edit);
            else
                // Flag que indica si es o no una nueva entrevista
                SwitchTo(FormModes.Edit2);

            //---Trae los contactos de un cliente
            m_leContactos = Bll.Clientes.ClcFGet(m_intNumCliente, true, m_smResult);
            m_leContactos.AddExprColumn("Deleted", typeof(decimal), "0");
            cmbContactos.FillFromIntLEntidad(m_leContactos, "clc_nro_numcontacto", "clc_des_nombre", "Deleted");

            //---Si no tiene contactos, deshabilitamos la selección
            if (m_leContactos.Count == 0)
            {
                rbContExist.Enabled = false;
                rbContNuevo.Checked = true;
            }

            App.HideMsg();
        }

        private void cmbContactos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //---Completar los textEdit con los datos del contacto del cliente seleccionado
            ECliContacto cliCont = m_leContactos[m_intNumCliente, cmbContactos.SelectedIntCode];

            /*Cargo*/       teCargo.Text = cliCont.Cargo;
            /*Título*/      teTitulo.Text = cliCont.Titulo;
            /*Celular*/     teCelular.Text = cliCont.Celular;
            /*Email*/       teEmail.Text = cliCont.Email;
            /*Secretaria*/  teSecretaria.Text = cliCont.Secretaria;
            /*Teléfono*/    teTelefono.Text = cliCont.Telefono1;
        }

        private void rbContExist_CheckedChanged(object sender, EventArgs e)
        {
            //---Si selecciona contacto existente, habilitar selección de contacto, si no, habilitar alta de contacto
            if (rbContExist.Checked)
            {
                imgGNuevoCont.Enabled = false;
                imgGSelecCont.Enabled = true;
            }
            else
            {
                imgGNuevoCont.Enabled = true;
                imgGSelecCont.Enabled = false;
            }
        }

        private void gbCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void gbAceptar_Click(object sender, EventArgs e)
        {
            //---Si ingresa una hora y dirección válida
            if ((teHora.IsValid) && (teDireccion.IsValid))
            {
                //---Si selecciona contacto nuevo
                if (rbContNuevo.Checked)
                {
                    //---Si completó bien los datos del contacto nuevo
                    if ((teNNombre.IsValid) && (teNCargo.IsValid) && ((teNCelular.IsValid) || (teNTelefono.IsValid)) && (teNTitulo.IsValid))
                    {
                        // Recuperamos los datos de la pantalla.
                        ECliContacto l_ECliContacto = ECliContacto.NewEmpty();
                        l_ECliContacto.Numcliente = m_intNumCliente;
                        l_ECliContacto.Numcontacto = -1;
                        l_ECliContacto.Nombre = teNNombre.Text;
                        l_ECliContacto.Cargo = teNCargo.Text;
                        l_ECliContacto.Titulo = teNTitulo.Text;
                        l_ECliContacto.Celular = teNCelular.Text;
                        l_ECliContacto.Telefono1 = teNTelefono.Text;
                        l_ECliContacto.Email = teNEmail.Text;
                        l_ECliContacto.Secretaria = teNSecretaria.Text;

                        //---Si lo quiere agregar
                        if ((cbAgregarContacto.Checked) && (m_boolNuevaEnt))
                        {
                            //---Guardar nuevo contacto
                            Clientes.ClcSave(l_ECliContacto, m_smResult);
                            if (MsgRuts.AnalizeError(this, m_smResult)) return;
                        }

                        //---Armar fecha y hora de la entrevista
                        DateTime l_dtFecYHor = new DateTime(monthCalendar1.SelectionStart.Year,
                                                            monthCalendar1.SelectionStart.Month,
                                                            monthCalendar1.SelectionStart.Day,
                                                            teHora.Hora.Hour,
                                                            teHora.Hora.Minute,
                                                            teHora.Hora.Second);
                        //---Guardar nueva entrevista con el contacto nuevo
                        Bll.Clientes.fSaveEntrevista(m_intNumCliente, m_intNumEntrev, m_strCodVend, l_dtFecYHor,
                                                     l_ECliContacto, teDireccion.Text,
                                                     teObservaciones.Text, m_smResult);

                        if (MsgRuts.AnalizeError(this, m_smResult)) return;

                        MsgRuts.ShowMsg(this,"La entrevista ha sido agendada.");

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                        MsgRuts.ShowMsg(this,"Faltan datos", MessageBoxButtons.OK);
                }
                else
                {
                    //---Armar fecha y hora de la entrevista
                    DateTime l_dtFecYHor = new DateTime(monthCalendar1.SelectionStart.Year,
                                    monthCalendar1.SelectionStart.Month,
                                    monthCalendar1.SelectionStart.Day,
                                    teHora.Hora.Hour,
                                    teHora.Hora.Minute,
                                    teHora.Hora.Second);
                    //---Guardar nueva entrevista con el contacto seleccionado
                    Bll.Clientes.fSaveEntrevista(m_intNumCliente, m_intNumEntrev, m_strCodVend, l_dtFecYHor, 
                          ECliContacto.NewFilled(m_intNumCliente, -1,  cmbContactos.SelectedItem.ToString(), teCargo.Text, teTitulo.Text, 
                                                 teCelular.Text, teTelefono.Text, "", "",  teEmail.Text,teSecretaria.Text), 
                                                 teDireccion.Text, 
                                                 teObservaciones.Text, m_smResult);
                    if (MsgRuts.AnalizeError(this, m_smResult)) return;

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
                MsgRuts.ShowMsg(this,"Faltan datos", MessageBoxButtons.OK);
        }

        /// <summary>
        /// Cambia el modo del formulario
        /// </summary>
        private void SwitchTo(FormModes p_fmNewMode)
        {
            // Fijamos el nuevo modo del formulario
            switch (p_fmNewMode)
            {
                case FormModes.Edit: { NewMode(); break; }
                case FormModes.Edit2: { EditMode(); break; }
                default: { MsgRuts.ShowMsg(this, "Invalid mode"); break; }
            }
        }

        /// <summary>
        /// Modo para agregar entrevista
        /// </summary>
        private void NewMode()
        {
        }

        /// <summary>
        /// Modo para editar entrevista
        /// </summary>
        private void EditMode()
        {
            cbAgregarContacto.Visible = false;
            fullLabel11.Text = "Editar contacto:";
            monthCalendar1.Enabled = false;
        }

    }
}
