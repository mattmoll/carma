using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using TNGS.NetRoutines;
using TNGS.NetApp;
using TNGS.NetControls;
using TNGS.NetAppSupport;
using Carm.Bel;

namespace Carm.Rp
{
    public partial class VndVentas : ReporteBase
    {
        // Miembros
        DateEdit deFechaIni = new DateEdit();
        DateEdit deFechaFin = new DateEdit();
        CDCombo cdcVendedores = new CDCombo();
        RadioButton rbResumen = new RadioButton();
        RadioButton rbDetalle = new RadioButton();

        // Constructor
        public VndVentas() : base("VndVentas")
        {
            InitializeComponent();  
        }


        public override void buildPanel()
        {
            // Llenamos la combo de vendedores
             
            Bel.LEVendedores l_leVendedores = Bll.Vendedores.UpFull(false, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;
            cdcVendedores.FillFromStrLEntidad(l_leVendedores, EVendedor.CodCmp, "vnd_ede_nya", "deleted");
            cdcVendedores.AddStrCD("", "-- TODOS --", 0);
            cdcVendedores.SelectedStrCode = "";

            // Añadimos las fechas, la combo y el grupo de radio buttons al panel.
            this.panelBuilder.AddControlWithLabel("Fecha Inicio", deFechaIni)
                             .AddControlWithLabel("Fecha Fin", deFechaFin)
                             .AddControlWithLabel("Vendedores", cdcVendedores)
                             .AddGroupOfRadioButtons("Modo", new RadioButton[] { rbResumen, rbDetalle }, new string[] { "Resumen", "Detalle" });
        }

        override public ListaEntidades realizarBusqueda(ref string p_strNombreEmpresa, ref string p_strPrograma,
                                                        ref string p_strNombreReporte, ref string p_strDetalleReporte,
                                                        ref int p_intCorteDeControl)
        {
            // Validamos
            if ((deFechaIni.Fecha == DateTimeRuts.Empty) || (deFechaFin.Fecha == DateTimeRuts.Empty))
                ControlReporte.cancelarBusqueda("Es obligatorio cargar las fechas de inicio y fin de busqueda");

            p_strNombreReporte = "Ventas";

            ListaEntidades l_leVentas = null;
            string l_strCodVendIni = "";
            string l_strCodVendFin = "";
            if (cdcVendedores.SelectedStrCode.Trim() == "")
            {
                l_strCodVendIni = "     a";
                l_strCodVendFin = "zzzzzz";
            }
            else
            {
                l_strCodVendIni = cdcVendedores.SelectedStrCode;
                l_strCodVendFin = cdcVendedores.SelectedStrCode;
            }

            // Ejecutamos la busqueda.
             
             // Si eligio el formato basico
            if (rbResumen.Checked)
            {
                p_intCorteDeControl = 2;

                l_leVentas = Bll.Vendedores.ZVentas(deFechaIni.Fecha,
                                                    deFechaFin.Fecha,
                                                    l_strCodVendIni,
                                                    l_strCodVendFin,
                                                    m_smResult);
                if (MsgRuts.AnalizeError(this, m_smResult)) return null;

                //Cambiamos los captions 
                l_leVentas.ChangeCaption("codMarcaVendedor", "");
                l_leVentas.ChangeCaption("mrc_des_des", "V1MarcaCN1");
                l_leVentas.ChangeCaption("jvt_nom_apellido", "V1Jefe de VentasCN1");
                l_leVentas.ChangeCaption("sup_nom_nomyape", "V1SupervisoresCN1");
                l_leVentas.ChangeCaption("vnd_des_apellido", "V1VendedorCN1");
                l_leVentas.ChangeCaption("cantidad", "V1Cant. VentasNN2");
                l_leVentas.ChangeCaption("clv_imp_abono", "V1Total Ventas2N2");
            }
            else
            {
                p_intCorteDeControl = 0;

                l_leVentas = Bll.Vendedores.ZVentasDetalle(deFechaIni.Fecha,
                                                           deFechaFin.Fecha,
                                                           l_strCodVendIni,
                                                           l_strCodVendFin,
                                                           m_smResult);
                if (MsgRuts.AnalizeError(this, m_smResult)) return null;

                //Cambiamos los captions 
                l_leVentas.ChangeCaption("cli_nro_numero", "V1Número ClienteNN1");
                l_leVentas.ChangeCaption("cli_nro_nroavalon", "V1Número AvalonNN1");
                l_leVentas.ChangeCaption("cli_ede_rsocial", "V1Razón SocialCN1");
                l_leVentas.ChangeCaption("mrc_des_des", "V1MarcaCN1");
                l_leVentas.ChangeCaption("clv_imp_abono", "V1Abono2S2");
                l_leVentas.ChangeCaption("vnd_des_apellido", "V1Apellido VendedorCN1");
                l_leVentas.ChangeCaption("vnd_des_nombre", "V1Nombre VendedorCN1");
            }

            return l_leVentas;

        }

    }
}
