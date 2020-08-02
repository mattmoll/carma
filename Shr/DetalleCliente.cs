using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TNGS.NetRoutines;
using TNGS.NetAppBll;
using TNGS.NetControls;
using WeifenLuo.WinFormsUI.Docking;

namespace Carm.Shr
{
    public partial class DetalleCliente : Form
    {
        // Miembros
        int m_intNroCliente = 0;
        StatMsg m_smResult = new StatMsg();
        Bel.ECliente m_eCliente = null;
        Bel.LECliContactos m_leContactos = null;
        Bel.LECliEntrevistas m_leEntrevistas = null;
        Bel.LECliLlamadas m_leLlamadas = null;
        Bel.LECliNotas m_leNotas = null;
        Bel.LECliServicios m_leServicios = null;
        

        // Eventos de todos los botones.
        public event ObjArrayEventHandler ModifyInterview;
        public event ObjArrayEventHandler NewInterview;
        public event ObjArrayEventHandler ModifyInstData;
        public event ObjArrayEventHandler ModifyContData;
        public event ObjArrayEventHandler ModifyUbicData;
        public event ObjArrayEventHandler ModifyOtherData;
        public event ObjArrayEventHandler ModifyContact;
        public event ObjArrayEventHandler NewContact;
        public event ObjArrayEventHandler DeleteContact;
        public event ObjArrayEventHandler NewCall;
        public event ObjArrayEventHandler DataError;
        public event ObjArrayEventHandler NewService;
        public event ObjArrayEventHandler ChangeCompetencia;
        //public event ObjArrayEventHandler NewUso;

        // Constructor 
        public DetalleCliente(int p_intNroCliente)
        {
            InitializeComponent();
            
            //Aplicamos permisos
            AppRuts.App_ApplySecurity(this);

            // Guardamos el parametro en el miembro.
            m_intNroCliente = p_intNroCliente;
        }

        // Metodo publico que se encarga de cargar todo en las pestañas y reportar error si lo hubo.
        public void CargaDatos()
        {
            
            // Seleccionamos la tab de entrevistas.
            DetalleCli.SelectedTab = TabCliente;

            AppRuts.App_ShowMsg("Cargando");
            
            // Nos traemos las Entrevistas del Cliente.
            ReCargaEntrevistas();

            // Traemos el cliente a partir del numero.
            TraeCliente();

            AppRuts.App_HideMsg();

            // Validamos que no haya errores.
            if (AppRuts.MsgRuts_AnalizeError(this,m_smResult))
                return;


            // Ocultamos los botones de los que no se haya capturado los eventos.
            VisibilidadBotones();

            // Cargamos el minirepor de entrevistas.
            CargaMiniRepEntrevistas();

            // Llenamos los campos del cliente a partir del miembro.
            LlenamosCamposDelCliente();

            // Cargamos los contactos en el miembro y cargamos el minireport.
            m_leContactos = m_eCliente.CliContactos;
            CargaMiniRepContactos();

            //Cargamos las llamadas en el miembro y cargamos el minireport.
            m_leLlamadas = m_eCliente.CliLlamadas;
            CargaMiniRepLlamadas();

            // Cargamos los servicios en el miembro y cargamos el minireport.
            m_leServicios = m_eCliente.CliServicios;
            CargaMiniRepServicios();

            // Cargamos las notas en el miembro y cargamos el minireport.
            m_leNotas = m_eCliente.CliNotas;
            CargaMiniRepNotas();

            // Llamamos al metodo que tiene la logica del control post it para mostrar las notas.
            LogicaPostIt();

            // Escondemos botones del minireport.
            EscondeBotones();

        }
       
        #region Codigo General a las pestañas

        // Metodo que trae el cliente a partir del numero.
        private void TraeCliente()
        {
            // Nos traemos la entidad Cliente con todos sus datos.
            m_eCliente = Bll.Clientes.Get(m_intNroCliente, false, m_smResult);
        }

        // Nos colgamos del evento de cambio de pestaña para forzar el escondido de un boton y asi se actualiza que botones esconde
        // y me muestra solo los de filtro.
        private void DetalleCli_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Escondemos los botones.
            EscondeBotones();   

            // Vemos que minireport hay que actualizar en base a en que tab este parado.
            switch(DetalleCli.SelectedIndex)
            {
                case 0:{ReCargaEntrevistas();break;}
                case 2: { ReCargaContactos(); break; }
                case 3: { RecargaLlamadas(); break; }
                case 4: { ReCargaServicios(); break; }
                case 5: { ReCargaNotas(); break; }
            }
        }

        // Metodo que actualiza la entidad cliente que esta en el miembro en la base.
        private void ActualizaCliente()
        {
            // Guardamos la entidad cliente en la base.
            Bll.Clientes.Save(m_eCliente, m_smResult);

            if (AppRuts.MsgRuts_AnalizeError(this,m_smResult))
                return;
        }

        // Metodo privado que se encargar de las visibilidades y enables de los botones.
        private void VisibilidadBotones()
        {
            // Enables de la pestaña de entrevistas.
            GBEntModif.Enabled = (ModifyInterview != null);
            GBEntNueva.Enabled = (NewInterview != null);
            IGEntOps.Enabled = ((ModifyInterview != null) || (NewInterview != null));

            // Visibilidades de la pestaña Cliente.
            GBEditCliInst.Visible = (ModifyInstData != null);
            GBEditCliCont.Visible = (ModifyContData != null);
            GBEditCliOtros.Visible = (ModifyOtherData != null);
            GBEditCliUbic.Visible = (ModifyUbicData != null);

            // Enables de la pestaña de contactos.
            GBConNuevo.Enabled = (NewContact != null);
            GBConModif.Enabled = (ModifyContact != null);
            GBConBorrar.Enabled = (DeleteContact != null);

            //Enables de la pestaña de llamadas
            gbLlamadaNueva.Enabled = (NewCall != null);

        }

        // Metodo que esconde los botones de excel para que se actualizen y se escondan todos los seteados.
        private void EscondeBotones()
        {
            mrEntrevistas.ShowExcel = true;
            mrEntrevistas.ShowExcel = false;
            mrContactos.ShowExcel = true;
            mrContactos.ShowExcel = false;
            mrLlamadas.ShowExcel = true;
            mrLlamadas.ShowExcel = false;
            mrNotas.ShowExcel = true;
            mrNotas.ShowExcel = false;
            mrServicios.ShowExcel = true;
            mrServicios.ShowExcel = false;
        }

        #endregion 

        #region Pestaña Cliente:

        #region Eventos de los botones de edit

        // Metodo que activa el modo edit de los text de campos institucionales.
        private void GBEditCliInst_Click(object sender, EventArgs e)
        {

            if (ModifyInstData != null)
            {
                // Llenamos el array de objects con todos los parametros necesarios para el form y llamamos al evento.
                ObjArrayEventArgs a = new ObjArrayEventArgs(new object[] { m_eCliente,
                                                                           true});
                ModifyInstData(this, a);

                // Si el resultado del form no fue ok, entonces no actualizamos nada.
                if (!(bool)a.Data[1])
                    return;

                // Actualizamos el cliente.
                m_eCliente=Bll.Clientes.fUpdateInstData(m_eCliente.Numero,
                                                        m_eCliente.Rsocial, 
                                                        m_eCliente.Nombrefant, 
                                                        m_eCliente.Codtinst, 
                                                        m_eCliente.Nroavalon,
                                                        m_smResult);

                // Cargamos los datos nuevos en pantalla
                TEInstRSocial.Text = m_eCliente.Rsocial;
                TEInstNFant.Text = m_eCliente.Nombrefant;
                TEInstTInst.Text = m_eCliente.Cli_des_tinst;
                neNroAvalon.Numero = m_eCliente.Nroavalon;

                
            }
            
            

        }

        // Metodo que activa el modo edit de los text de campos contacto
        private void GBEditCliCont_Click(object sender, EventArgs e)
        {

            if (ModifyContData != null)
            {
                // Llenamos el array de objects con todos los parametros necesarios para el form y llamamos al evento.
                ObjArrayEventArgs a = new ObjArrayEventArgs(new object[] { teCel.Text.Trim(),
                                                                           TEContTel.Text.Trim(),
                                                                           TEContTel2.Text.Trim(),
                                                                           teEmail.Text.Trim(),
                                                                           TEContFax.Text.Trim(),
                                                                           TEContUrl.Text.Trim() });
                ModifyContData(this, a);

                // Actualizamos el cliente.
                m_eCliente = Bll.Clientes.fUpdateContData(m_eCliente.Numero,
                                                          (string)a.Data[0],
                                                          (string)a.Data[1],
                                                          (string)a.Data[2],
                                                          (string)a.Data[3],
                                                          (string)a.Data[4],
                                                          (string)a.Data[5],
                                                          m_smResult);

                // Cargamos las modificaciones en pantalla.
                teCel.Text = m_eCliente.Celular;
                TEContTel.Text = m_eCliente.Telefono1;
                TEContTel2.Text = m_eCliente.Telefono2;
                teEmail.Text = m_eCliente.Email;
                TEContFax.Text = m_eCliente.Fax;
                TEContUrl.Text = m_eCliente.Url;

            }
           


        }

        // Metodo que activa el modo edit de los text de campos Ubicacion.
        private void GBEditCliUbic_Click(object sender, EventArgs e)
        {
            if (ModifyUbicData != null)
            {
                // Llenamos el array de objects con todos los parametros necesarios para el form y llamamos al evento.
                ObjArrayEventArgs a = new ObjArrayEventArgs(new object[] { TEUbDir.Text.Trim(),
                                                                           neUbAltura.Numero,
                                                                           TEUbLoc.Text.Trim(),
                                                                           TEUbPiso.Text.Trim(),
                                                                           TEUbOficina.Text.Trim(),
                                                                           TEUbPartido.Text.Trim(),
                                                                           TEUbProv.Text.Trim(),
                                                                           TEUbZona.Text.Trim(),
                                                                           m_eCliente.Codlocalidad,
                                                                           m_eCliente.Cli_rcd_codzona,
                                                                           });
                ModifyUbicData(this, a);

                // Actualizamos el cliente.
                m_eCliente = Bll.Clientes.fUpdateUbicData(m_eCliente.Numero,
                                                          (string)a.Data[0],
                                                          (int)a.Data[1],
                                                          (string)a.Data[8],
                                                          (string)a.Data[3],
                                                          (string)a.Data[4],
                                                          m_smResult);

                // Actualizamos los datos en pantalla.
                TEUbDir.Text = m_eCliente.Direccion;
                neUbAltura.Numero = m_eCliente.Altura;
                TEUbLoc.Text = m_eCliente.Cli_des_loc;
                TEUbOficina.Text = m_eCliente.Oficina;
                TEUbPartido.Text = m_eCliente.Cli_ede_partido;
                TEUbPiso.Text = m_eCliente.Piso;
                TEUbProv.Text = m_eCliente.Cli_des_prov;
                TEUbZona.Text = m_eCliente.Cli_des_zona;
            }
        }

        // Metodo que activa el modo edit de los text de campos otros.
        private void GBEditCliOtros_Click(object sender, EventArgs e)
        {
            if (ModifyOtherData != null)
            {
                // Llenamos el array de objects con todos los parametros necesarios para el form y llamamos al evento.
                ObjArrayEventArgs a = new ObjArrayEventArgs(new object[] { NEOtrosCantEmp.Numero,
                                                                           cueCuil.Text,
                                                                           TEOtrosHorarios.Text.Trim(),
                                                                           teObservaciones.Text.Trim()});
                ModifyOtherData(this, a);

                // Actualizamos la entidad cliente.
                m_eCliente = Bll.Clientes.fUpdateOtherData(m_eCliente.Numero,
                                                           (int)a.Data[0],
                                                           (string)a.Data[1],
                                                           (string)a.Data[2],
                                                           (string)a.Data[3],
                                                           (string)a.Data[4],
                                                           m_smResult);

                // Cargamos los datos en la pantalla.
                NEOtrosCantEmp.Numero = m_eCliente.Cantempleados;
                TEOtrosHorarios.Text = m_eCliente.Horarios;
                cueCuil.Text = m_eCliente.Cuil;
                teObservaciones.Text = m_eCliente.Observacion;
            }
        }

        #endregion 

        // Evento del boton datos erroneos que se fija si alguien capturo el evento de DataError y si es asi lo ejecuta.
        private void gbDatosErroneos_Click(object sender, EventArgs e)
        {
            if (DataError != null)
            {
                // Llenamos el array de objects con todos los parametros necesarios para el form y llamamos al evento.
                ObjArrayEventArgs a = new ObjArrayEventArgs(new object[] {m_eCliente.Numero,
                                                                          true});
                DataError(this, a);

                // Si el resultado del form no fue ok, entonces no actualizamos nada.
                if (!(bool)a.Data[1])
                    return;

                AppRuts.App_ShowMsg("Grabando");
                // Si salio todo bien grabamos la nueva nota.
                Bll.Clientes.ClnSave((Bel.ECliNota)a.Data[0], m_smResult);
                AppRuts.App_HideMsg();

                // Actualizamos la lista de notas.
                ReCargaNotas();

                AppRuts.App_ShowMsg("Grabando");
                // Marcamos el cliente como erroneo.
                Bll.Clientes.TieneDatosErroneos(m_eCliente.Numero, m_smResult);
                AppRuts.App_HideMsg();

                AppRuts.MsgRuts_ShowMsg(this, "Se ha marcado que los datos del cliente son erroneos con su respectiva nota aclaratoria!");
                
            }
        }

        // Evento del click del boton Fue arreglado que valida y marca al cliente como correcto.
        private void gbFueArreglado_Click(object sender, EventArgs e)
        {
            ReCargaNotas();

            // Filtramos la lista de notas para que queden solo las que no estan borradas y sean de tipo error.
            m_leNotas.Filter("cln_cd1_borrada = \'N\' and cln_cd1_tipo =\'0\' ");

            // Validamos si tiene una nota de error.
            if (m_leNotas.Count == 1)
            {
                AppRuts.MsgRuts_ShowMsg(this, "No se puede marcar al cliente como corregido porque tiene una nota de tipo error," +
                                        " remuevala antes de poder marcarlo como corregido");
                return;
            }

            // Validamos si tiene muchas notas de error.
            if (m_leNotas.Count > 1)
            {
                AppRuts.MsgRuts_ShowMsg(this, "No se puede marcar al cliente como corregido porque aun tiene notas de tipo error," +
                                        " remuevalas antes de poder marcarlo como corregido");
                return;
            }

            AppRuts.App_ShowMsg("Grabando");
            Bll.Clientes.FueArreglado(m_intNroCliente, m_smResult);
            AppRuts.App_HideMsg();

            AppRuts.MsgRuts_ShowMsg(this, "El cliente fue marcado como arreglado exitosamente!");

        }

        // Evento del click del boton Dejo Empresa que le cambia el estado al cliente.
        private void gbDejoEmpresa_Click(object sender, EventArgs e)
        {
            // Pedimos una confirmacion
            if (AppRuts.MsgRuts_AskUser(this, "Está a punto de dar de baja de la empresa a un cliente. ¿Está seguro?") == AskUserResults.No) return;

            AppRuts.App_ShowMsg("Grabando");
            EParametro l_eCantDiasCancel = AppRuts.ParaGet("DIASCANCEL",false,m_smResult);
            if (AppRuts.MsgRuts_AnalizeError(this, m_smResult))
            {
                AppRuts.App_HideMsg();
                return;
            }
            Bll.Clientes.BajaYBorraServicios(m_intNroCliente, l_eCantDiasCancel.VInt, "", m_smResult);
            if (!AppRuts.MsgRuts_AnalizeError(this, m_smResult))
                AppRuts.MsgRuts_ShowMsg(this,"El cliente fue dado de baja de la empresa exitosamente!");

            AppRuts.App_HideMsg();
        }

        // Metodo que llena todos los campos de la pestaña del cliente a partir de la entidad en el miembro.
        private void LlenamosCamposDelCliente()
        {
            // Campos Institucionales
            neCliNumero.Numero = m_eCliente.Numero;
            TEInstRSocial.Text = m_eCliente.Rsocial;
            TEInstNFant.Text = m_eCliente.Nombrefant;
            TEInstTInst.Text = m_eCliente.Cli_des_tinst;
            teInstMayorista.Text = m_eCliente.Cli_cd1_esmayo;
            neNroAvalon.Numero = m_eCliente.Nroavalon;
            dceAbono.Decimal = m_eCliente.Abono;

            // Campos Contacto
            TEContFax.Text = m_eCliente.Fax;
            teCel.Text = m_eCliente.Celular;
            TEContTel.Text = m_eCliente.Telefono1;
            TEContTel2.Text = m_eCliente.Telefono2;
            teEmail.Text = m_eCliente.Email;
            TEContUrl.Text = m_eCliente.Url;

            // Campos Ubicacion
            TEUbLoc.Text = m_eCliente.Cli_des_loc;
            TEUbPartido.Text = m_eCliente.Cli_ede_partido;
            TEUbProv.Text = m_eCliente.Cli_des_prov;
            TEUbZona.Text = m_eCliente.Cli_des_zona;
            TEUbDir.Text = m_eCliente.Direccion;
            neUbAltura.Numero = m_eCliente.Altura;
            TEUbOficina.Text = m_eCliente.Oficina;
            TEUbPiso.Text = m_eCliente.Piso;

            //Campos Otros
            NEOtrosCantEmp.Text = m_eCliente.Cantempleados.ToString();
            TEOtrosHorarios.Text = m_eCliente.Horarios;
            cueCuil.Text = m_eCliente.Cuil;
            teCliAlta.Text = m_eCliente.Alta;
            teCargador.Text = m_eCliente.Cargador;
            teObservaciones.Text = m_eCliente.Observacion;
            
        }

        #endregion 

        #region Pestaña Entrevistas:

        // Evento de cambio de Celda
        private void mrEntrevistas_CurrentCellChange(object sender, EventArgs e)
        {
            object l_oNumEntrev = mrEntrevistas.GetMatrixValueObj(0);

            // Validamos que sea distinto de nulo.
            if (l_oNumEntrev == DBNull.Value)
                return;

            // Deshabilitamos el boton de modificar entrevista si esta parado en una entrevista ya cerrada.
            GBEntModif.Enabled = ((string)mrEntrevistas.GetMatrixValueObj(1)) == "S";
        }

        // Evento del boton Nueva entrevista, que dispara la ventana de Agendar entrevista con el cliente al que le pedimos el detalle.
        private void GBEntNueva_Click(object sender, EventArgs e)
        {
            if (NewInterview != null)
            {
                // Llenamos el array de objects con todos los parametros necesarios para el form y llamamos al evento.
                ObjArrayEventArgs a = new ObjArrayEventArgs(new object[] { m_eCliente.Numero,
                                                                           m_eCliente.Codvend,
                                                                           m_eCliente.Direccion,
                                                                           true // Indica si el resultado del form fue exitoso o no( hay que actualizar)
                                                                           });
                NewInterview(this, a);

                // Si el estado de la modificacion fue exitoso, actualizamos, sino no hacemos nada.
                if ((bool)a.Data[5])
                {
                    ReCargaEntrevistas();
                    CargaMiniRepEntrevistas();
                }
                
            }
        }

        // Evento del boton modificiar una entrevista que me permite modificar datos de una entrevista (del vendedor).
        private void GBEntModif_Click(object sender, EventArgs e)
        {
            // Si alguien esta colgado del evento creamos el parametro array de objetos con la entrevista, direccion del cliente,
            // Fecha de inicio de reserva y fecha de fin de reserva. Y llamamos al evento.
            if (ModifyInterview != null)
            {
                // Validamos que este parado en un campo valido
                object l_oNumero = mrEntrevistas.GetMatrixValueObj(0);
                if ((l_oNumero == DBNull.Value) || (l_oNumero == null))
                    return;
            
                // Creamos la entidad cliEntrevista vacia y la llenamos para pasarsela al form y que permita modificarla.
                Bel.ECliEntrevista l_eclEntrevista = Bll.Clientes.CleGet(m_intNroCliente, (int) l_oNumero, false,
                                                                         m_smResult);

                // Llenamos todos los datos de la entidad cli Entrevista.
                /*
                l_eclEntrevista.Numcliente = m_intNroCliente;
                l_eclEntrevista.Numentrev = (int)l_oNumero;
                l_eclEntrevista.Fcoordinada = (DateTime)mrEntrevistas.GetMatrixValueObj(3);
                l_eclEntrevista.Nombre = (string)mrEntrevistas.GetMatrixValueObj(5);
                l_eclEntrevista.Telefono = (string)mrEntrevistas.GetMatrixValueObj(7);
                l_eclEntrevista.Cargo = (string)mrEntrevistas.GetMatrixValueObj(8);
                l_eclEntrevista.Titulo = (string)mrEntrevistas.GetMatrixValueObj(9);
                l_eclEntrevista.Celular = (string)mrEntrevistas.GetMatrixValueObj(10);
                l_eclEntrevista.Email = (string)mrEntrevistas.GetMatrixValueObj(11);
                l_eclEntrevista.Direccion = (string)mrEntrevistas.GetMatrixValueObj(12);
                 */



                ObjArrayEventArgs a= new ObjArrayEventArgs(new object[] { l_eclEntrevista,
                                                                          (string)mrEntrevistas.GetMatrixValueObj(6), // Si esta Borrada (S/N)
                                                                          true });
                ModifyInterview(this, a);

                // Si el estado de la modificacion fue exitoso, actualizamos, sino no hacemos nada.
                if ((bool)a.Data[4])
                {
                    // Actualizamos el listado de entrevistas y lo cargamos en el minireport.
                    ReCargaEntrevistas();
                    CargaMiniRepEntrevistas();
                }
            }

            
        }

        // Evento del boton ver detalle que muestra en una ventana dialogue el detalle de la entrevista,
        private void gbVerDetalle_Click(object sender, EventArgs e)
        {
            // Validamos que este parado en un campo valido
            object l_oNumero = mrEntrevistas.GetMatrixValueObj(0);
            if ((l_oNumero == DBNull.Value) || (l_oNumero == null))
                return;

            int l_iNumero = (int)l_oNumero;
            string l_strInforme = String.Format("{0} \n {1}","Informe:",
                                                m_leEntrevistas[m_eCliente.Numero, l_iNumero].Informe);

            AppRuts.MsgRuts_ShowMsg(this, l_strInforme);
        }

        // Metodo que recarga el miembro lista entidades entrevistas trayendolas de la base.
        private void ReCargaEntrevistas()
        {
            // Nos traemos las Entrevistas del Cliente.
            m_leEntrevistas = Bll.Clientes.CleGetEntrevistasCli(m_intNroCliente, m_smResult);
        }

        // Metodo que carga el minireport con lo que haya en el miembro de entrevistas.
        private void CargaMiniRepEntrevistas()
        {
            m_leEntrevistas.ChangeCaption("cle_nro_numcliente", "");
            m_leEntrevistas.ChangeCaption("cle_cd6_codvend", "");
            m_leEntrevistas.ChangeCaption("deleted", "");
            m_leEntrevistas.ChangeCaption("cle_nro_numentrev", "V1Num.NN2");
            m_leEntrevistas.ChangeCaption("cle_cd1_pend", "V1Pend.CN2");

            // Llenamos el minireport con la lista entidades.
            mrEntrevistas.LoadData(m_leEntrevistas,
                                      "",
                                      "",
                                      "SIMA",
                                      "",
                                      "",
                                      "Entrevistas",
                                      "",
                                      m_smResult);
            // Esa era el viejo setteado de los tamaños, pero estaba mal, por si algun dia lo quiero arreglar. actualmente se hace solo.
            //"@M-M@@M-M@N@M-M@40;110;100;90;80;80;80;80;83;110;115;50;60;@M-M@"

            EventArgs a = EventArgs.Empty;
            mrEntrevistas_CurrentCellChange(this,a);
        }

        private void mrEntrevistas_GetColor(object sender, GetColorEventArgs e)
        {
            try
            {
                //---Si es la columna de entrevista borrada y el valor es "S", pintar de rojo
                if (e.Columna == "Borrada")
                {
                    if (((string)e.Registro[e.ColIndex]).Trim() == "S")
                        e.SetColor(Color.Red);
                }
                
            }
            catch (Exception)
            {

            }
        }


        #endregion 

        #region Pestaña Contactos:

        // Evento del set color que pinta de rojo el campo de activo si dice "N"
        private void mrContactos_GetColor(object sender, GetColorEventArgs e)
        {
            try
            {
                //---Si es la columna de Activo y el valor es "N", pintar de rojo
                if (e.Columna == "Activo")
                {
                    if (((string)e.Registro[e.ColIndex]).Trim() == "N")
                        e.SetColor(Color.Red);
                }
                
            }
            catch (Exception)
            {

            }
        }

        // Evento del click del boton nuevo contacto.
        private void GBConNuevo_Click(object sender, EventArgs e)
        {
            if (NewInterview != null)
            {
                // Llenamos el array de objects con todos los parametros necesarios para el form y llamamos al evento.
                ObjArrayEventArgs a = new ObjArrayEventArgs(new object[] { m_eCliente.Numero,
                                                                           true // Indica si el resultado del form fue exitoso o no( hay que actualizar)
                                                                           });

                NewContact(this, a);

                // Si el estado del borrado fue exitoso, actualizamos, sino no hacemos nada.
                if ((bool)a.Data[1])
                {
                    // Grabamos la entidad en la base.
                    GrabaContacto((Bel.ECliContacto)a.Data[0]);

                    // Actualizamos el mini report de Contactos. con las modificaciones.
                    ReCargaContactos();
                }
            }
        }

        // Evento del boton modificar un contacto.
        private void GBConModif_Click(object sender, EventArgs e)
        {
            if (ModifyContact != null)
            {
                // Conseguimos el numero del contacto.
                object l_oNumContacto = mrContactos.GetMatrixValueObj(0);

                // Validamos que sea distinto de nulo.
                if ((l_oNumContacto == DBNull.Value) || (l_oNumContacto == null))
                    return;

                int l_intNumeroCli = m_eCliente.Numero;
                int l_intNumeroContacto = (int)l_oNumContacto;

                // Llenamos el array de objects con todos los parametros necesarios para el form y llamamos al evento.
                ObjArrayEventArgs a = new ObjArrayEventArgs(new object[] { m_leContactos[l_intNumeroCli,l_intNumeroContacto],
                                                                           (string)mrContactos.GetMatrixValueObj(4), // Si esta Activo o no.
                                                                           true // Indica si el resultado del form fue exitoso o no( hay que actualizar)
                                                                           });

                ModifyContact(this, a);

                // Si el estado del borrado fue exitoso, actualizamos, sino no hacemos nada.
                if ((bool)a.Data[2])
                {
                    // Actualizamos el contacto.
                    GrabaContacto((Bel.ECliContacto)a.Data[0]);

                    // Actualizamos el mini report de Contactos. con las modificaciones.
                    ReCargaContactos();
                }
            }
        }

        // Evento del boton borrar un contacto
        private void GBConBorrar_Click(object sender, EventArgs e)
        {
            if (DeleteContact != null)
            {
                // Conseguimos el numero del contacto.
                object l_oNumContacto = mrContactos.GetMatrixValueObj(0);

                // Validamos que sea distinto de nulo.
                if ((l_oNumContacto == DBNull.Value) || (l_oNumContacto == null))
                    return;

                int l_intNumeroCli = m_eCliente.Numero;
                int l_intNumeroContacto= (int)l_oNumContacto;

                // Llenamos el array de objects con todos los parametros necesarios para el form y llamamos al evento.
                ObjArrayEventArgs a = new ObjArrayEventArgs(new object[] { l_intNumeroCli,
                                                                           l_intNumeroContacto,
                                                                           (string)mrContactos.GetMatrixValueObj(1), // Nombre del contacto
                                                                           (string)mrContactos.GetMatrixValueObj(4), // Si esta Activo o no ('S' / 'N')
                                                                           m_leContactos[l_intNumeroCli,l_intNumeroContacto].FxdVersion, // Version
                                                                           true // Indica si el resultado del form fue exitoso o no( hay que actualizar)
                                                                           });

                DeleteContact(this, a);


                // Si el estado del borrado fue exitoso, actualizamos, sino no hacemos nada.
                if ((bool)a.Data[5])
                {
                    // Actualizamos el mini report de Contactos. con las modificaciones.
                    ReCargaContactos();
                }

            }

        }

        private void gbEnviarCarta_Click(object sender, EventArgs e)
        {
            if (mrContactos.Count == 0)
            {
                AppRuts.MsgRuts_ShowMsg(this, "No se puede enviar mail si no hay ningun contacto cargado.");
                return;
            }

            Bel.ECliContacto l_eCliContacto = (Bel.ECliContacto)mrContactos.DameEntidadSeleccionada();
            if (l_eCliContacto.Email.Trim() == "")
            {
                AppRuts.MsgRuts_ShowMsg(this, "No se puede enviar mail a este contacto porque no tiene una cuenta de correo asociada");
                return;
            }
        }

        // Metodo que actualiza el miembro de contactos y recarga el minireport.
        private void ReCargaContactos()
        {
            AppRuts.App_ShowMsg("Cargando");
            // Nos traemos los contactos asociados a este cliente.
            m_leContactos = Bll.Clientes.ClcFGet(m_intNroCliente, false, m_smResult);
            AppRuts.App_HideMsg();

            // Validamos que este todo bien.
            if (AppRuts.MsgRuts_AnalizeError(this, m_smResult))
                return;

            // Cargamos los contactos.
            CargaMiniRepContactos();
        }

        // Metodo que hace los captions y carga el minireport de contactos.
        private void CargaMiniRepContactos()
        {
            // Borramos los captions del numero del cliente y la razon social.
            m_leContactos.ChangeCaption("clc_nro_numcliente", "");
            m_leContactos.ChangeCaption("clc_nro_numcontacto", "V1NúmeroNN2");
            m_leContactos.ChangeCaption("clc_des_rsocial", "");
            m_leContactos.ChangeCaption("deleted", "");

            // Llenamos el minireport con la lista entidades.
            mrContactos.LoadData(m_leContactos,
                                 "",
                                 "",
                                 "SIMA",
                                 "",
                                 "",
                                 "Contactos",
                                 "@M-M@@M-M@N@M-M@50;90;90;90;67;80;80;80;80;101;90;@M-M@",
                                 m_smResult);
        }

        // Metodo que graba en la base el contacto que recibe por parametro.
        private void GrabaContacto(Bel.ECliContacto p_eCliContacto)
        {
            Bll.Clientes.ClcSave(p_eCliContacto, m_smResult);
        }


        #endregion 

        #region Pestaña Llamadas:

        // Metodo que se encarga de llenar el minireport de llamadas a partir de la lista entidad de llamadas.
        private void CargaMiniRepLlamadas()
        {
            // Ajustamos los captions necesarios.
            m_leLlamadas.ChangeCaption("cll_nro_numcliente", "");
            m_leLlamadas.ChangeCaption("cll_nro_numllamada", "V1NumNN2");
            m_leLlamadas.ChangeCaption("cll_cod_codmotivo", "");
            m_leLlamadas.ChangeCaption("cll_nom_codusuario", "V1UsuarioCN2");
            m_leLlamadas.ChangeCaption("cll_cd1_baja", "V1Produjo BajaCN2");
            m_leLlamadas.ChangeCaption("deleted", "");

            // Llenamos el minireport con la lista entidades.
            mrLlamadas.LoadData(m_leLlamadas,
                                "",
                                "",
                                "SIMA",
                                "",
                                "",
                                "Llamadas",
                                "", // @M-M@@M-M@N@M-M@80;140;140;338;120;80;@M-M@   le saque los tamaños porque le quedaba chico al resultado.
                                m_smResult);
        }

        // Metodo que actualiza las llamadas yendo a buscar nuevamente el cliente con sus respectivas llamadas.
        private void RecargaLlamadas()
        {
            // Conseguimos las llamadas del cliente.
            m_leLlamadas = Bll.Clientes.CllFGet(m_eCliente.Numero, false, m_smResult);
        }

        /*  POR AHORA NO HAY BOTON DE MODIFICACION DE LLAMADAS, PERO SI ALGUN DIA LO HAY, ACA HAY PLANTILLA
         * 
        // Evento del boton modificar llamada
        private void gbLlamadaModif_Click(object sender, EventArgs e)
        {
            if (ModifyCall != null)
            {
                // Validamos que este parado en un campo valido
                object l_oNumeroLlamada = mrLlamadas.GetMatrixValueObj(0);
                if (l_oNumeroLlamada == DBNull.Value)
                    return;

                int l_intNumeroCli = m_eCliente.Numero;
                int l_intNumeroLlamada = (int)l_oNumeroLlamada;


                // Llenamos el array de objects con todos los parametros necesarios para el form y llamamos al evento.
                ObjArrayEventArgs a = new ObjArrayEventArgs(new object[] { m_leLlamadas[l_intNumeroCli,l_intNumeroLlamada],
                                                                           true // Indica si el resultado del form fue exitoso o no( hay que actualizar)
                                                                           });
                ModifyCall(this, a);

                // Si el estado de la modificacion fue exitoso, actualizamos, sino no hacemos nada.
                if (Convert.ToBoolean(a.Data[1]))
                {
                    // ACA vamos a llamar al metodo de bll de clientes donde actualice la llamada y vamos a recargar el minireport.
                }

            }

        }
        */

        // Evento del boton nueva llamada
        private void gbLlamadaNueva_Click(object sender, EventArgs e)
        {
            if (NewCall != null)
            {
                // Llenamos el array de objects con todos los parametros necesarios para el form y llamamos al evento.
                ObjArrayEventArgs a = new ObjArrayEventArgs(new object[] { m_eCliente.Numero,
                                                                           true // Indica si el resultado del form fue exitoso o no( hay que actualizar)
                                                                           });

                NewCall(this, a);

                // Si el estado de la modificacion fue exitoso, actualizamos, sino no hacemos nada.
                if ((bool)a.Data[2])
                {
                    // Actualizamos en memoria y pantalla.
                    RecargaLlamadas();
                    CargaMiniRepLlamadas();
                }

            }
        }
        

        #endregion

        #region Pestaña Servicios:

        // Evento del set color que pinta de rojo el campo de activo si dice "N"
        private void mrServicios_GetColor(object sender, GetColorEventArgs e)
        {
            try
            {
                //---Si es la columna de Activo y el valor es "N", pintar de rojo
                if (e.Columna == "Activo")
                {
                    if (((string)e.Registro[e.ColIndex]).Trim() == "N")
                        e.SetColor(Color.Red);
                }

            }
            catch (Exception)
            {

            }
        }

        // Metodo que carga el minireport de servicios a partir del miembro de servicios.
        private void CargaMiniRepServicios()
        {
            // Borramos los captions del numero del cliente y el deleted
            m_leServicios.ChangeCaption("cls_nro_numcliente", "");
            m_leServicios.ChangeCaption("deleted", "");

            // Llenamos el minireport con la lista entidades.
            mrServicios.LoadData(m_leServicios,
                                 "",
                                 "",
                                 "SIMA",
                                 "",
                                 "",
                                 "Servicios",
                                 "@M-M@@M-M@N@M-M@80;150;150;398;120;@M-M@",
                                 m_smResult);
        }

        // Evento del boton nnuevo servicio.
        private void gbServicioNuevo_Click(object sender, EventArgs e)
        {
            // Si esta capturado el evento lo llamamos. pero esta vez debe resolver el grabado la ventana, no nosotros, por eso no esperamos
            // respuesta (datos de retorno.
            if (NewService != null)
            {
                // Llenamos el array de objects con todos los parametros necesarios para el form y llamamos al evento.
                ObjArrayEventArgs a = new ObjArrayEventArgs(new object[] { m_eCliente.Numero,
                                                                          Bel.LECliServicios.NewEmpty()
                                                                           });
                NewService(this, a);

                if (a.Data[3] != null)
                {
                    Bel.LECliServicios l_leServicios = (Bel.LECliServicios)a.Data[3];
                    Bll.Clientes.fGrabaServicios(m_eCliente.Numero, l_leServicios, m_smResult);
                    if (AppRuts.MsgRuts_AnalizeError(this, m_smResult)) return;

                    ReCargaServicios();
                    CargaMiniRepServicios();
                }
            }
        }

        private void gbCompetencia_Click(object sender, EventArgs e)
        {
            // Si esta capturado el evento lo llamamos. pero esta vez debe resolver el grabado la ventana, no nosotros, por eso no esperamos
            // respuesta (datos de retorno.
            if (ChangeCompetencia != null)
            {
                // Llenamos el array de objects con todos los parametros necesarios para el form y llamamos al evento.
                ObjArrayEventArgs a = new ObjArrayEventArgs(new object[] { "",
                                                                           false
                                                                           });
                ChangeCompetencia(this, a);

                if ((bool)a.Data[1])
                {
                    Bll.Clientes.BajaYBorraServicios(m_eCliente.Numero,0, a.Data[0].ToString(), m_smResult);
                    if (AppRuts.MsgRuts_AnalizeError(this, m_smResult)) return;

                    TraeCliente();
                    LlenamosCamposDelCliente();
                    ReCargaServicios();
                    CargaMiniRepServicios();
                    
                }
            }
        }


        /*
        // Evento del boton de borrar servicio.
        private void gbBorrarServicio_Click(object sender, EventArgs e)
        {
            if (DeleteService != null)
            {
                // Conseguimos la fecha de generacion.
                object l_oFechaGen = mrServicios.GetMatrixValueObj(0);

                // Validamos que sea distinto de nulo.
                if ((l_oFechaGen == DBNull.Value) || (l_oFechaGen == null))
                    return;

                int l_intNumeroCli = m_eCliente.Numero;
                DateTime l_dtFechaGen = (DateTime)l_oFechaGen;
                int l_intVersion = 0;
                //m_leServicios[l_intNumeroCli, l_dtFechaGen,0].FxdVersion;
                 

                // Llenamos el array de objects con todos los parametros necesarios para el form y llamamos al evento.
                ObjArrayEventArgs a = new ObjArrayEventArgs(new object[] { l_intNumeroCli,
                                                                           l_dtFechaGen,
                                                                           (string)mrServicios.GetMatrixValueObj(1), // Si esta Activo o no ('S' / 'N')
                                                                           l_intVersion, // Version
                                                                           true // Indica si el resultado del form fue exitoso o no( hay que actualizar)
                                                                           });

                DeleteService(this, a);


                // Si el estado del borrado fue exitoso, actualizamos, sino no hacemos nada.
                if ((bool)a.Data[4])
                {
                    // Actualizamos el mini report de Contactos. con las modificaciones.
                    ReCargaServicios();
                    CargaMiniRepServicios();
                }

            }

        }
         */

        // Metodo que actualiza el miembro de servicios del cliente.
        private void ReCargaServicios()
        {
            m_leServicios = Bll.Clientes.ClsFGet(m_eCliente.Numero, false, m_smResult);
        }

        #endregion

        #region Pestaña Notas

        // Evento del click del boton de Notas
        private void gbNotas_Click(object sender, EventArgs e)
        {
            // Cambiamos el estado del checked que cambia el color del boton.
            gbNotas.Checked = !gbNotas.Checked;

            // Si esta activo
            if (gbNotas.Checked)
            {
                // Recargamos las notas
                ReCargaNotas();

                // Validamos que haya alguna
                if (m_leNotas.Count == 0)
                    return;

                // Hacemos la logica del post it para que se carguen las notas en pantalla.
                LogicaPostIt();
            }
            else // Si no esta activo, escondemos el control post it.
                nNotas.Visible = false;

        }

        // Metodo que se encarga de toda la logica del PostIt mostrando notas si corresponde.
        private void LogicaPostIt()
        {
            // Filtramos la lista de notas para que queden solo las que no estan borradas.
            m_leNotas.Filter("cln_cd1_borrada = \'N\' ");

            // Validamos que haya quedado alguna, sino termina ahi y no hacemos nada.
            if (m_leNotas.Count == 0)
                return;

            // Ordenamos por el tipo de nota para que queden primeras las de error (0=Error, 1=Anotacion).
            m_leNotas.Sort("cln_cd1_tipo");

            // Creamos la lista de notas
            LENotes l_leNotas = LENotes.NewEmpty();

            // Llenamos la lista de notas recorriendo nuestra lista entidad y convirtiendo cada Entidad Nota en Enote.
            foreach (Bel.ECliNota l_eCliNota in m_leNotas)
                l_leNotas.AddEntity(Bll.Clientes.fClnConvertToENote(l_eCliNota));

            // Cargamos las notas en el control y lo mostramos.
            nNotas.Notas = l_leNotas;
            nNotas.Visible = true;

            // Ponemos el boton de notas como activado.
            gbNotas.Checked = true;

        }

        // Evento del boton de remover una nota.
        private void nNotas_Remove(object sender, NoteEventArgs e)
        {
            // Conseguimos la nota.
            ENote l_eNota = nNotas.GetNote(e.Note);

            AppRuts.App_ShowMsg("Grabando");
            // Removemos la nota a partir de los datos que tenemos.
            Bll.Clientes.ClnRemover(DBConn.Usuario,
                                    Bll.Clientes.fGetDate(m_smResult),
                                    m_intNroCliente,
                                    l_eNota.FxdInstante,
                                    m_smResult);
            AppRuts.App_HideMsg();

            // Validamos que no haya errores.
            if (AppRuts.MsgRuts_AnalizeError(this, m_smResult))
                return;

            // Actualizamos las notas.
            ReCargaNotas();
            LogicaPostIt();

            // Si no hay notas escondemos el postit.
            if (m_leNotas.Count == 0)
                EscondePostIt();

        }

        // Metodo que esconde el PostIt.
        private void EscondePostIt()
        {
            nNotas.Notas = null;
            nNotas.Visible = false;
            gbNotas.Checked = false;
        }



        // Evento del set color que pinta de rojo el campo de borrada y de naranja o amarillo el campo Tipo segun corresponda.
        private void mrNotas_GetColor(object sender, GetColorEventArgs e)
        {
            try
            {
                //Si es la columna de Borrada y el valor es "S", pintar de rojo
                if (e.Columna == "Borrada")
                {
                    if (((string)e.Registro[e.ColIndex]).Trim() == "S")
                        e.SetColor(Color.Red);
                }
                //Si es la columna de Activo y el valor es "N", pintar de rojo
                if (e.Columna == "Tipo")
                {
                    if (((string)e.Registro[e.ColIndex]).Trim() == "0")
                        e.SetColor(Color.LightPink);
                    else
                        if (((string)e.Registro[e.ColIndex]).Trim() == "1")
                            e.SetColor(Color.LightGoldenrodYellow);
                }

            }
            catch (Exception)
            {

            }
        }

        // Metodo que actualiza el miembro de contactos y recarga el minireport.
        private void ReCargaNotas()
        {
            AppRuts.App_ShowMsg("Cargando");
            // Nos traemos las notas asociadas a este cliente.
            m_leNotas = Bll.Clientes.ClnFGet(m_intNroCliente, false, m_smResult);
            AppRuts.App_HideMsg();

            // Validamos que este todo bien.
            if (AppRuts.MsgRuts_AnalizeError(this, m_smResult))
                return;

            // Cargamos las notas.
            CargaMiniRepNotas();
        }

        // Metodo que carga en el mini report la lista entidades que haya en el miembro de notas.
        private void CargaMiniRepNotas()
        {
            m_leNotas.ChangeCaption("deleted", "");

            // Ordenamos por el tipo de nota para que queden primeras las de error (0=Error, 1=Anotacion).
            m_leNotas.Sort("cln_cd1_tipo,cln_cd1_borrada");

            // Llenamos el minireport con la lista entidades.
            mrNotas.LoadData(m_leNotas,
                             "",
                             "",
                             "SIMA",
                             "",
                             "",
                             "Notas",
                             "@M-M@@M-M@N@M-M@0;137;244;47;60;135;135;140;@M-M@",
                             m_smResult);
        }

        // Evento del boton Ver Nota que busca la nota seleccionada en el miembro notas y llama a mostrar en pantalla nota.
        private void gbVerNota_Click(object sender, EventArgs e)
        {
            // Conseguimos la fecha y hora de la nota.
            object l_oFecha = mrNotas.GetMatrixValueObj(1);

            // Validamos que sea distinto de nulo.
            if ((l_oFecha == DBNull.Value) || (l_oFecha == null))
                return;

            // Convertimos la fecha de objeto a DateTime
            DateTime l_dtFecha = (DateTime)l_oFecha;

            // Creamos una entidad CliNota.
            Bel.ECliNota l_eCliNotaElegida = null;

            // Copiamos localmente las notas y le quitamos el filtro para tener todas las notas (inclusive las borradas).
            Bel.LECliNotas l_leNotas = m_leNotas;
            l_leNotas.Filter("");

            // Recorremos las notas buscando la que coincida la fecha y hora con la que sacamos del minireport.
            foreach (Bel.ECliNota l_eCliNota in l_leNotas)
            {
                if (l_eCliNota.Fechayhora == l_dtFecha)
                {
                    l_eCliNotaElegida = l_eCliNota;
                    break;
                }
            }

            // Mostramos en panatalla la nota elegida.
            MostrarNotaEnPantalla(Bll.Clientes.fClnConvertToENote(l_eCliNotaElegida));

        }

        // Evento del boton de cerrar notas del control VerNota.
        private void nVerNota_NoteClose(object sender, EventArgs e)
        {
            nVerNota.Notas = null;
            nVerNota.Visible = false;
        }

        // Metodo que muestra en pantalla una nota que recibe por parametro.
        private void MostrarNotaEnPantalla(ENote eNote)
        {
            nVerNota.Notas = null;
            nVerNota.AddNote(eNote);
            nVerNota.Visible = true;
        }


        #endregion

    }
}
