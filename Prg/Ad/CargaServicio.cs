using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Carm.Shr;
using TNGS.NetRoutines;
using TNGS.NetApp;
using Carm.Bel;

namespace Carm.Ad
{
    public partial class CargaServicio : Form
    {

        // Miembros
        StatMsg m_smResult = new StatMsg();
        private int m_intNumeroCli;
        private Bel.LECliServicios m_lentCliServicio;
        private Bel.LEPlnServicios m_lentPlnServicios;
        private ListaEntidades m_lentServicios;


        // Constructor que genera los planes fijos y c
        public CargaServicio(int p_intNroCliente, string p_strCodTipoContrato = "")
        {
            InitializeComponent();

            m_intNumeroCli = p_intNroCliente;

            if (p_strCodTipoContrato == "")
                estadoFormCompetencia();
            else
                estadoFormClientePropio(p_strCodTipoContrato);
                
        }

        private void estadoFormClientePropio(string p_strCodTipoContrato)
        {
            /* TODO No mas marca.
            ListaEntidades l_lePlanes = Bll.Planes.GetPlanesFromTCont(p_strCodTipoContrato, p_strCodMarca, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            cdcPlanes.FillFromStrLEntidad(l_lePlanes, EPlan.CodCmp, EPlan.DesCmp, "deleted");
            // Agregamos los planes fijos a la combo de planes.
            GeneraPlanesFijos();
            */
        }


        private void estadoFormCompetencia()
        {
            // Deshabilitamos la combo de planes, y cargamos la lista de todos los servicios.
            cdcPlanes.Enabled = false;
            cargamosTodosLosServicios();
        }

        #region Eventos


        // Evento de cambio de seleccion de la combo de planes
        private void cdcPlanes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string l_strCodPlan = cdcPlanes.SelectedStrCode;

            // Si el plan es vacio.
            if (l_strCodPlan == "")
            {
                // Limpiamos el minireport.
                mrServicios.WithCheckBoxes = false;
                mrServicios.Clear();
                return;
            }

            // Si es el plan libre, cargamos todos lo servicios.
            if (l_strCodPlan == "-1")
                cargamosTodosLosServicios();
            else
            {
                // Conseguimos los Servicios asociados a un plan.
                m_lentPlnServicios = Bll.Planes.PlsFGet(l_strCodPlan, true, m_smResult);
                if (MsgRuts.AnalizeError(this, m_smResult)) return;

                m_lentPlnServicios.ChangeCaption("pls_nro_cprestlibres", "V1cCN1");
                m_lentPlnServicios.ChangeCaption("pls_imp_valorprestacion", "V1vCN1");
                m_lentPlnServicios.ChangeCaption("deleted", "");
                mrServicios.Clear();
                mrServicios.WithCheckBoxes = false;
                mrServicios.LoadData(m_lentPlnServicios,
                                     "",
                                     "",
                                     "SIMA",
                                     "",
                                     "",
                                     "Servicios",
                                     "@M-M@@M-M@N@M-M@0;160;0;156;0;0;@M-M@",
                                     m_smResult);

            }
        }

        private void cargamosTodosLosServicios()
        {
            // Traemos los servicios.
            m_lentServicios = Bll.Servicios.GetServiciosFull(m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            // Cargamos en el minireport y activamos los checkboxes.
            m_lentServicios.ChangeCaption("dummy", "V1dCN1");
            m_lentServicios.ChangeCaption("pls_nro_cprestlibres", "V1cCN1");
            m_lentServicios.ChangeCaption("pls_imp_valorprestacion", "V1vCN1");
            mrServicios.Clear();
            mrServicios.WithCheckBoxes = true;
            ActualizaMRPlanLibre();
        }

        // Evento de cambio de celda del minireport que actualiza los 3 campos asociados.
        private void mrServicios_CurrentCellChange(object sender, EventArgs e)
        {
            // Definimos variables que vamos a usar en los dos casos.
            int l_iCPrestLibres;
            decimal l_dceValorprestacion;

            // Si estamos en plan libre.
            if (mrServicios.WithCheckBoxes)
            {
                // Conseguimos el codigo de servicio
                object l_oCodServicio = mrServicios.GetMatrixValueObj(1);
                if ((l_oCodServicio == DBNull.Value) || (l_oCodServicio == null)) return;

                m_lentServicios.Filter(String.Format("srv_cod_cod = {0}", (string)l_oCodServicio));

                // Coneguimos los valores asociados.
                l_iCPrestLibres = Convert.ToInt32(m_lentServicios.InternalData[0]["pls_nro_cprestlibres"]);
                l_dceValorprestacion = Convert.ToDecimal(m_lentServicios.InternalData[0]["pls_imp_valorprestacion"]);

            }
            // Si estamos en un plan fijo
            else
            {
                // Conseguimos el codigo de servicio
                object l_oCodServicio = mrServicios.GetMatrixValueObj(2);
                if ((l_oCodServicio == DBNull.Value) || (l_oCodServicio == null)) return;

                m_lentPlnServicios.Filter(String.Format("pls_cod_codservicio = {0}", (string)l_oCodServicio));

                // Conseguimos los valores asociados.
                l_iCPrestLibres = Convert.ToInt32(m_lentPlnServicios.InternalData[0]["pls_nro_cprestlibres"]);
                l_dceValorprestacion = Convert.ToDecimal(m_lentPlnServicios.InternalData[0]["pls_imp_valorprestacion"]);

            }

            // Nos fijamos en que tipo estamos y cargamos los datos correspondientes.
            switch (l_iCPrestLibres)
            {
                case -2: { rbSinCobro.Checked = true; break; }

                case -1: { rbCoseguro.Checked = true; dceCoseguro.Decimal = l_dceValorprestacion; break; }

                default:
                    {
                        rbPrestLibres.Checked = true;
                        dceValorprestacion.Decimal = l_dceValorprestacion;
                        neCprestlibres.Numero = l_iCPrestLibres;
                        break;
                    }
            }

            // Si estamos en plan libre condicionamos la habilitacion de los campos asociados a los checked
            if (mrServicios.WithCheckBoxes)
            {
                // Conseguimos el checked
                object l_oChecked = mrServicios.GetMatrixValueObj(0);
                if ((l_oChecked == DBNull.Value) || (l_oChecked == null)) return;

                // Si no esta checkeado el item limpiamos los campos y no lo dejamos modificar nada.
                if (!(bool)l_oChecked)
                {
                    // Al checkear esto llama al evento de cambio checked que limpia los campos
                    rbSinCobro.Checked = true;

                    return;
                }
            }


        }

        // Evento del click del boton de update de los datos extra de cada servicio.
        private void gbUpdt_Click(object sender, EventArgs e)
        {
            // Si estamos en plan libre.
            if (mrServicios.WithCheckBoxes)
            {
                // Conseguimos el codigo de servicio.
                object l_oCodServicio = mrServicios.GetMatrixValueObj(1);
                if ((l_oCodServicio == DBNull.Value) || (l_oCodServicio == null)) return;

                // Filtramos la lista entidades con el codigo de servicio para tener la entidad a modificar.
                m_lentServicios.Filter(String.Format("srv_cod_cod = {0}", l_oCodServicio.ToString()));

                // Si esta seleccionado el rb de sin cobro, entonces (cantidad= -2 y valor = 1)
                if (rbSinCobro.Checked)
                {
                    m_lentServicios.InternalData[0][3] = -2;
                    m_lentServicios.InternalData[0][4] = 1;
                }
                // Si esta seleccionado el rb de con Coseguro, entonces (cantidad= -1 y valor = Coseguro)
                else if (rbCoseguro.Checked)
                {
                    m_lentServicios.InternalData[0][3] = -1;
                    m_lentServicios.InternalData[0][4] = dceCoseguro.Decimal;
                }
                // Si esta seleccionado el rb de Prestaciones Libres, entonces (cantidad= cantidad  y valor = valor)
                else if (rbPrestLibres.Checked)
                {
                    m_lentServicios.InternalData[0][3] = neCprestlibres.Numero;
                    m_lentServicios.InternalData[0][4] = dceValorprestacion.Decimal;
                }

                // Aca ya tenemos la entidad actualizada, entonces desfiltramos.
                m_lentServicios.Filter("");
            }
            // Si estamos en cualquier otro plan
            else
            {
                // Conseguimos el codigo de plan
                object l_oCodPlan = mrServicios.GetMatrixValueObj(0);
                if ((l_oCodPlan == DBNull.Value) || (l_oCodPlan == null)) return;

                object l_oCodServicio = mrServicios.GetMatrixValueObj(2);


                // Filtramos la lista entidades con el codigo de plan y codigo de servicio para tener la entidad a modificar.
                m_lentPlnServicios.Filter(String.Format("pls_cod_codplan = {0} and pls_cod_codservicio = {1}",
                                                      l_oCodPlan.ToString(),
                                                      l_oCodServicio.ToString()));

                // Si esta seleccionado el rb de sin cobro, entonces (cantidad= -2 y valor = 1)
                if (rbSinCobro.Checked)
                {
                    m_lentServicios.InternalData[0][3] = -2;
                    m_lentServicios.InternalData[0][4] = 1;
                }
                // Si esta seleccionado el rb de con Coseguro, entonces (cantidad= -1 y valor = Coseguro)
                else if (rbCoseguro.Checked)
                {
                    m_lentServicios.InternalData[0][3] = -1;
                    m_lentServicios.InternalData[0][4] = dceCoseguro.Decimal;
                }
                // Si esta seleccionado el rb de Prestaciones Libres, entonces (cantidad= cantidad  y valor = valor)
                else if (rbPrestLibres.Checked)
                {
                    m_lentServicios.InternalData[0][3] = neCprestlibres.Numero;
                    m_lentServicios.InternalData[0][4] = dceValorprestacion.Decimal;
                }
            }
        }

        // Evento del boton aceptar que llena la entidad.
        private void GBAccept_Click(object sender, EventArgs e)
        {
            // Traemos fecha y hora del momento.
            DateTime l_dtNow = Bll.Clientes.fGetDate(m_smResult);

            // Si hubo error volvemos.
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            // Creamos la lista entidades resultado.
            Bel.LECliServicios l_lentCliServicios = Bel.LECliServicios.NewEmpty();
            Bel.ECliServicio l_entCliServicio;
            int l_intCounter = 1;
            DataView l_dwServicios;
            List<Object[]> l_laoCodsChecked=null;
            string l_strCodigosChecked = "";


            // Si estamos en plan libre.
            if (mrServicios.WithCheckBoxes)
            {
                m_lentServicios.Filter("");
                l_dwServicios = m_lentServicios.InternalData;
                // Conseguimos los codigos de los items que esten checked
                l_laoCodsChecked = mrServicios.GetChecked(new int[]{1});
                // Armamos una string con todos los codigos checked.
                foreach (Object[] l_aoCodChecked in l_laoCodsChecked)
                    l_strCodigosChecked += (string)l_aoCodChecked[0]+ " ,";
            }
            // Estamos en un plan fijo.
            else
                l_dwServicios = m_lentPlnServicios.InternalData;

            // Recorremos la lista de servicios actualizada en memoria.
            foreach (DataRowView l_drvServicio in l_dwServicios)
            {
                // Creamos la entidad
                l_entCliServicio = Bel.ECliServicio.NewEmpty();
                
                // Si estamos en plan libre.
                if (mrServicios.WithCheckBoxes)
                {
                    // Cargamos el codigo de servicio.
                    l_entCliServicio.Codservicio = (string)l_drvServicio["srv_cod_cod"];

                    // Si no encuentra el codigo de servicio en la lista de codigos checked, pasamos al siguiente
                    if (l_strCodigosChecked.IndexOf(l_entCliServicio.Codservicio + " ,") == -1)
                        continue;
                }
                else
                    // Cargamos el codigo de servicio.
                    l_entCliServicio.Codservicio = (string)l_drvServicio["pls_cod_codservicio"];


                // Cargamos los datos fijos (no dependen del servicio).
                l_entCliServicio.Numcliente = m_intNumeroCli;
                l_entCliServicio.Item = l_intCounter;

                // Nos fijamos en que tipo estamos y cargamos los datos correspondientes (asociados a cada servicio)
                switch ((int)l_drvServicio["pls_nro_cprestlibres"])
                {
                    case -2:
                        {
                            l_entCliServicio.Coseguro = 0;
                            l_entCliServicio.Valorprestacion = 0;
                            l_entCliServicio.Cantestprestaciones = 0;
                            break;
                        }

                    case -1:
                        {
                            l_entCliServicio.Coseguro = Convert.ToDecimal(l_drvServicio["pls_imp_valorprestacion"]);
                            l_entCliServicio.Valorprestacion = 0;
                            l_entCliServicio.Cantestprestaciones = 0;
                            break;
                        }

                    default:
                        {
                            l_entCliServicio.Coseguro = 0;
                            l_entCliServicio.Valorprestacion = Convert.ToDecimal(l_drvServicio["pls_imp_valorprestacion"]);
                            l_entCliServicio.Cantestprestaciones = (int)l_drvServicio["pls_nro_cprestlibres"];
                            break;
                        }
                }

                // Agregamos la entidad con los datos cargados.
                l_lentCliServicios.AddEntity(l_entCliServicio);

                // Sumamos uno al contador para el numero de item
                l_intCounter++;
            }
            // Cargamos el resultado en el miembro que despues se expone como propiedad y cargamos resultado del form.
            m_lentCliServicio = l_lentCliServicios;
            this.DialogResult = DialogResult.OK;
        }

        // Evento de cambio de checked del radio button de sin cobrar.
        private void rbSinCobro_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSinCobro.Checked)
            {
                igSinCobro.Enabled = true;

                dceCoseguro.Decimal = 0;
                igCoseguro.Enabled = false;

                dceValorprestacion.Decimal = 0;
                neCprestlibres.Numero = 0;
                igPrestLibres.Enabled = false;
            }
        }

        // Evento de cambio de checked del radio button de coseguro.
        private void rbCoseguro_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCoseguro.Checked)
            {
                igCoseguro.Enabled = true;

                igSinCobro.Enabled = false;

                dceValorprestacion.Decimal = 0;
                neCprestlibres.Numero = 0;
                igPrestLibres.Enabled = false;
            }
        }

        // Evento de cambio de checked del radio button de prestaciones libres.
        private void rbPrestLibres_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPrestLibres.Checked)
            {
                igPrestLibres.Enabled = true;

                igSinCobro.Enabled = false;

                dceCoseguro.Decimal = 0;
                igCoseguro.Enabled = false;
            }
        }

        // Evento del boton cancelar que pone el dialog resul en cancel.
        private void GBCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        // Evento que captura el presionado de una tecla en todos los campos y dispara la busqueda si corresponde.
        private void Every_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Si es el enter, disparamos la busqueda.
            if (e.KeyChar == '\r')
            {
                gbUpdt_Click(sender, e);
            }
        }

        #endregion 

        #region Metodos


        // Metodo que carga la lista entidades en el minireport de servicios.
        private void ActualizaMRPlanLibre()
        {
            mrServicios.LoadData(m_lentServicios,
                                 "",
                                 "",
                                 "SIMA",
                                 "",
                                 "",
                                 "Servicios",
                                 "@M-M@@M-M@N@M-M@60;60;196;0;0;0;@M-M@",
                                 m_smResult);
        }

        // Metodo que genera los planes fijos en la combo.
        private void GeneraPlanesFijos()
        {
            cdcPlanes.AddStrCD("", "", 0);
            cdcPlanes.AddStrCD("-1", "Plan Libre", 0);
        }

     

        #endregion 


        // Propiedades:
        public int NumeroCli { set { m_intNumeroCli = value; } }
        public Bel.LECliServicios Servicios { get { return m_lentCliServicio; } }

    }
}
