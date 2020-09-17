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

namespace Carm.Ad
{
    public partial class ResultadoEntrevista : Form
    {
        int m_intNumCliente;
        ListaEntidades m_leEntrevistas;
        LEResEntrevistas m_leResultados;
        StatMsg m_smResult = new StatMsg();

        // Constructor
        public ResultadoEntrevista(int p_intNumCliente)
        {
            InitializeComponent();
             
            //---Pasar número de cliente a miembro
            m_intNumCliente = p_intNumCliente;
        }

        // Evento del load del form.
        private void ResultadoEntrevista_Load(object sender, EventArgs e)
        {
            //Actualizamos las entrevistas incompletas y cargamos los resultados posibles de una entrevista.
            ActualizaMiniReport();
            LlenaCombo();

            SwitchTo(FormModes.Selection);
        }

        // Metodo que carga el minireport a partir de las entrevista incompletas.
        private void ActualizaMiniReport()
        {
            App.ShowMsg("Cargando...");

            
            // Traemos las entrevistas incompletas del cliente. (ACA NO VALIDA POR VENDEDOR, ESTO PUEDE TRAER PROBLEMAS MAS ADELANTE, VER EL TEMA DE BORRADO DE RESERVAS)
            m_leEntrevistas = Bll.Clientes.CleGetEntrevistasIncom(m_intNumCliente, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            // Si no tiene entrevistas incompletas, retorna
            if (m_leEntrevistas.Count == 0)
            {
                MsgRuts.ShowMsg(this, "No le quedan más entrevistas por completar.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

            // Captionamos.
            m_leEntrevistas.ChangeCaption("cle_nro_numentrev", "V1Núm. de entrevistaCN2");/*0*/
            m_leEntrevistas.ChangeCaption("cli_ede_rsocial", "V1Razón socialCN2");/*1*/
            m_leEntrevistas.ChangeCaption("cle_fyh_fcoordinada", "V1Fecha coordinadaCN2");/*2*/
            m_leEntrevistas.ChangeCaption("cle_des_nombre", "V1Nombre del contactoCN2");/*3*/
            m_leEntrevistas.ChangeCaption("cle_des_cargo", "V1CargoCN2");/*4*/
            m_leEntrevistas.ChangeCaption("cli_ent_vencidas", "V1VencidaCN2");/*5*/
            m_leEntrevistas.ChangeCaption("cli_fec_ffinres", "V1Fecha fin de reservaFN2");/*6*/

            // Cargamos las entrevistas
            mrCliEntrevistas.LoadData(m_leEntrevistas, 
                                      "", 
                                      "", 
                                      "SIMA", 
                                      "", 
                                      "", 
                                      "Entrevistas incompletas", 
                                      m_smResult);

            App.HideMsg();
        }

        // Metodo que carga la combo de resultados.
        private void LlenaCombo()
        {
            App.ShowMsg("Cargando...");
            // Cargamos resultados de entrevistas en la combo.
            m_leResultados = Bll.Tablas.RenUpFull(false, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;
            m_leResultados.AddExprColumn("Deleted", typeof(decimal), "0");
            cdcResultados.FillFromStrLEntidad(m_leResultados, "ren_rcd_cod", "ren_des_des", "Deleted");
            cdcResultados.AddStrCD("", "", 0);
            App.HideMsg();

            // Si no tiene resultados de entrevistas cargados, retorna
            if (m_leResultados.Count == 0)
            {
                MsgRuts.ShowMsg(this, "No tiene Resultados de Entrevistas cargados, agréguelos en las Tablas Generales", MessageBoxButtons.OK);
                this.Close();
            }

        }

        // Metodo que graba una entrevista con las respectivas validaciones.
        private void GrabaEntrevista()
        {
            // Validamos que haya elegido un resultado
            if (cdcResultados.Text.Trim() == "")
            {
                MsgRuts.ShowMsg(this, "Debe elegir un resultado para poder grabar una entrevista");
                return;
            }

            // Conseguimos el numero de entrevista.
            object l_oNumEntrev = mrCliEntrevistas.GetMatrixValueObj(0);
            if (l_oNumEntrev == DBNull.Value) return;
            int l_intNumEntrev = Convert.ToInt32(l_oNumEntrev);

            // Armamos fecha y hora de la entrevista
            DateTime l_dtFecYHor = new DateTime(mcFechaEntrev.SelectionStart.Year,
                                                mcFechaEntrev.SelectionStart.Month,
                                                mcFechaEntrev.SelectionStart.Day,
                                                teHora.Hora.Hour,
                                                teHora.Hora.Minute,
                                                teHora.Hora.Second);

            //---Si tiene que poner un motivo y es válido, actualizar la entrevista con el resultado
            if ((!teMotivo.Enabled) || (teMotivo.IsValid))
                Clientes.CleSaveCompletarEntrev(l_dtFecYHor,
                                                l_intNumEntrev,
                                                teMotivo.Text.Trim(),
                                                teInforme.Text.Trim(),
                                                cdcResultados.SelectedStrCode.Trim().PadLeft(2),
                                                m_smResult);

            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            MsgRuts.ShowMsg(this, "La entrevista se ha completado con éxito");
        }

        // Evento del minireport que pide su color.
        private void mrCliEntrevistas_GetColor(object sender, GetColorEventArgs e)
        {
            try
            {
                //---Si es la columna de Vencida y el valor es "S", pintar de rojo
                if (e.Columna == "Vencida")
                {
                    if (((string)e.Registro[e.ColIndex]).Trim() == "S")
                        e.SetColor(Color.Red);
                }
            }
            catch (Exception)
            {

            }
        }

        // Evento del boton modificar que nos elije una entrevista y nos pasa al otro estado del form para cargarle resultado.
        private void gbModificar_Click(object sender, EventArgs e)
        {
            SwitchTo(FormModes.Edit);

            //Validar matrixValueObj(2)
            object l_oBeneficio = mrCliEntrevistas.GetMatrixValueObj(2);
            if (l_oBeneficio == DBNull.Value) return;
            DateTime l_dtFechaCoor = Convert.ToDateTime(l_oBeneficio);

            //Iniciar calendario con la fecha coordinada
            mcFechaEntrev.MinDate = l_dtFechaCoor;
            mcFechaEntrev.SelectionEnd = l_dtFechaCoor;

            // Parche para que no explote en los casos en que quedaron entrevistas pendientes
            // Permite que la fecha maxima sea la de hoy en vez de la de fin de reserva
            // aunque nunca deberia haber una entrevista luego de que finalice la reserva.

            DateTime l_dtFecha = (DateTime)mrCliEntrevistas.GetMatrixValueObj(6);

            // Si la fecha coordinada es del mismo dia o mayor a la fecha de fin de reserva
            // entonces el maximo es el dia de hoy, sino es la fecha de fin de reserva.
            if (l_dtFecha < l_dtFechaCoor.AddDays(1))
                mcFechaEntrev.MaxDate = DateTime.Today;
            else
                //Fecha fin de reserva como máximo del calendario
                mcFechaEntrev.MaxDate = l_dtFecha;

            //Completar hora con la hora coordinada
            teHora.Hora = l_dtFechaCoor;
        }

        // Evento del boton guardar que graba el resultaod de una entrevista.
        private void gbGuardar_Click(object sender, EventArgs e)
        {
            // Grabamos la entrevista.
            GrabaEntrevista();

            // Pasamos a modo selección
            SwitchTo(FormModes.Selection);
            ActualizaMiniReport();
        }

        // Evento del boton de contrato que dispara la ventana de carga de servicio, borra las entrev pend. y marca cliente como vendido.
        private void gbContrato_Click(object sender, EventArgs e)
        {
            // Validamos que haya elegido un resultado
            if (cdcResultados.Text.Trim() == "")
            {
                MsgRuts.ShowMsg(this, "Debe elegir un resultado para poder grabar una entrevista");
                return;
            }

            // Si tiene que poner un motivo y no es válido, reportamos el error
            if ((teMotivo.Enabled) && !(teMotivo.IsValid))
            {
                MsgRuts.ShowMsg(this,"Es obligatorio cargar un motivo si se cambia la fecha de la entrevista");
                return;
            }
            Bel.ECliente l_eCliente = Bll.Clientes.Get(m_intNumCliente, false, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult))return;

            // Creamos el form de carga de venta
            CargaVenta l_frmCargaVenta = new CargaVenta(l_eCliente);
            l_frmCargaVenta.ShowDialog(this);

            // Si salio todo bien grabamos el resultado de la entrevista y cancelamos las pendientes.
            if (l_frmCargaVenta.DialogResult == DialogResult.OK)
            {
                // Armamos fecha y hora de la entrevista
                DateTime l_dtFecYHor = new DateTime(mcFechaEntrev.SelectionStart.Year,
                                                    mcFechaEntrev.SelectionStart.Month,
                                                    mcFechaEntrev.SelectionStart.Day,
                                                    teHora.Hora.Hour,
                                                    teHora.Hora.Minute,
                                                    teHora.Hora.Second);
                // Conseguimos el numero de entrevista.
                object l_oNumEntrev = mrCliEntrevistas.GetMatrixValueObj(0);
                if ((l_oNumEntrev == DBNull.Value) ||(l_oNumEntrev == null)) return;
                int l_intNumEntrev = Convert.ToInt32(l_oNumEntrev);

                // Obtenemos el vendedor
                Bel.EVendedor l_eVendedor = Bll.Vendedores.fGetVendedorFromUsu(m_smResult);
                if (MsgRuts.AnalizeError(this, m_smResult)) return;


                /* TODO NO marca.
                // Llamamos al metodo que tiene toda la logica de la generacion del contrato.
                Bll.Clientes.fResultadoEntrevistaYBorradoPendientes(
                                                            l_dtFecYHor,
                                                            l_intNumEntrev,
                                                            teMotivo.Text.Trim(),
                                                            teInforme.Text.Trim(),
                                                            " " + cdcResultados.SelectedStrCode,
                                                            m_intNumCliente,
                                                            l_eVendedor.Codmarca,
                                                            m_smResult);
                                                            */
                // Validamos que no haya errores.
                if (MsgRuts.AnalizeError(this, m_smResult))
                    return;

                // Pasamos a modo selección
                SwitchTo(FormModes.Selection);
                ActualizaMiniReport();
            }
 

        }

        // Evento del boton de cancelar que vuelve al modo de la grilla.
        private void gbCancelar_Click(object sender, EventArgs e)
        {
            //---Pasar a modo selección
            SwitchTo(FormModes.Selection);
        }

        // Evento del cambio de indice de la combo que valida si hay que activar guardar o genera contrato. 
        private void cdcResultados_SelectedIndexChanged(object sender, EventArgs e)
        {
            int l_intIndice = cdcResultados.SelectedIndex == 0 ? cdcResultados.SelectedIndex : cdcResultados.SelectedIndex - 1;
            m_leResultados.Sort("ren_rcd_cod desc");
            //---Habilitar botones de contrato o guardar, según el resultado genere contrato
            if ((cdcResultados.SelectedIndex != -1) && (m_leResultados[l_intIndice].Codfiltro.Trim() == "S") && (mrCliEntrevistas.Count == 1))
            {
                gbContrato.Enabled = true;
                gbGuardar.Enabled = false;
            }
            else
            {
                gbContrato.Enabled = false;
                gbGuardar.Enabled = true;
            }
        }

        // Evento del cambio de fecha en el calendario.
        private void mcFechaEntrev_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Conseguimos la fecha coordinada.
            object l_oFechaCoor = mrCliEntrevistas.GetMatrixValueObj(2);
            if (l_oFechaCoor == DBNull.Value) return;
            DateTime l_dtFechaCoor = Convert.ToDateTime(l_oFechaCoor);

            // Si cambia el día de realización, habilitar textEdit de motivo
            if (mcFechaEntrev.SelectionStart == l_dtFechaCoor)
                teMotivo.Enabled = false;
            else
                teMotivo.Enabled = true;
        }

        // Evento de cerrado del form que valida que no queden entrevistas vencidas por completar.
        private void ResultadoEntrevista_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Clientes.fTieneEntrevistasVencidas(m_leEntrevistas, m_smResult))
            {
                if (MsgRuts.AnalizeError(this, m_smResult)) return;

                //---Confirmación al cerrar ResultadoEntrevista
                if (MsgRuts.ShowMsg(this, "Aún le quedan entrevistas vencidas para completar, ¿Desea seguir completándolas?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    e.Cancel = true;
                else
                    this.DialogResult = DialogResult.Cancel;
            }

        }

        /// <summary>
        /// Cambia el modo del formulario
        /// </summary>
        private void SwitchTo(FormModes p_fmNewMode)
        {
            // Fijamos el nuevo modo del formulario
            switch (p_fmNewMode)
            {
                case FormModes.Selection: { Selection(); break; }
                case FormModes.Edit: { EditMode(); break; }
                default: { MsgRuts.ShowMsg(this, "Invalid mode"); break; }
            }
        }

        /// <summary>
        /// Modo para seleccionar entrevista
        /// </summary>
        private void Selection()
        {
            //---Deshabilitar edición de entrevista y habilitar selección
            imgGResultado.Enabled = false;
            gbModificar.Enabled = true;

            //Limpiamos los campos.
            teInforme.Clear();
            teMotivo.Clear();
            teHora.Text = "99:99";
            cdcResultados.SelectedIndex = -1;
            mcFechaEntrev.MaxSelectionCount = 1;
        }

        /// <summary>
        /// Modo para editar entrevista
        /// </summary>
        private void EditMode()
        {
            //---Habilitar edición de entrevista y deshabilitar selección
            imgGResultado.Enabled = true;
            gbModificar.Enabled = false;
        }
    }
}
