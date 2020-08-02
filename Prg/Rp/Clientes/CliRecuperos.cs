using Carm.Bel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using TNGS.NetApp;
using TNGS.NetAppSupport;
using TNGS.NetControls;
using TNGS.NetRoutines;
using WeifenLuo.WinFormsUI.Docking;

namespace Carm.Rp
{
    public partial class CliRecuperos : ReporteBase
    {
        // Miembros
        RadioButton rbDetalle = new RadioButton();
        RadioButton rbGeneral = new RadioButton();
        DateEdit deFechaIni = new DateEdit();
        DateEdit deFechaFin = new DateEdit();
        CDCombo cdcMarcas = new CDCombo();

        // Constructor
        public CliRecuperos() : base("CliRecuperos") 
        {
            InitializeComponent();
        }

        public override void buildPanel()
        {
            // Añadimos las fechas, la combo y el grupo de radio buttons al panel.
            this.panelBuilder.AddControlWithLabel("Fecha Inicio", deFechaIni)
                             .AddControlWithLabel("Fecha Fin", deFechaFin)
                             .AddGroupOfRadioButtons("Modo", new RadioButton[] { rbDetalle, rbGeneral }, new string[] { "Detalle", "General" });
        }

        override public ListaEntidades realizarBusqueda(ref string p_strNombreEmpresa, ref string p_strPrograma,
                                                        ref string p_strNombreReporte, ref string p_strDetalleReporte,
                                                        ref int p_intCorteDeControl)
        {
            // Validamos
            if ((deFechaIni.Fecha == DateTimeRuts.Empty) || (deFechaFin.Fecha == DateTimeRuts.Empty))
                ControlReporte.cancelarBusqueda("Es obligatorio cargar las fechas de inicio y fin de busqueda");

            // Cargamos los valores de referencia para el llenado del report.
            p_strNombreReporte = "Recuperos Clientes";

            ListaEntidades l_leRecuperos;

            string l_strCodMarcaIni, l_strCodMarcaFin;

            // Logica de los limites de busqueda 
            if (cdcMarcas.SelectedStrCode.Trim() == "")
            {
                l_strCodMarcaIni = " 0";
                l_strCodMarcaFin = "zz";
            }
            else
                l_strCodMarcaIni = l_strCodMarcaFin = cdcMarcas.SelectedStrCode;

            // Obtenemos la lista entidad correspondiente segun el reporte pedido.
            if (rbDetalle.Checked)
                l_leRecuperos = Bll.Clientes.CllZRecuperosDetalle(deFechaIni.Fecha, deFechaFin.Fecha, l_strCodMarcaIni, l_strCodMarcaFin,  m_smResult);
            else
                l_leRecuperos = Bll.Clientes.CllZRecuperosGral(deFechaIni.Fecha, deFechaFin.Fecha, l_strCodMarcaIni, l_strCodMarcaFin, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return null;

            // Captionamos comunes a los dos reportes.
            l_leRecuperos.ChangeCaption(ECategoriaLlamada.DesCmp, "V1CategoríaCN1");
            l_leRecuperos.ChangeCaption(EMotivosLlamada.DesCmp, "V1MotivoCN1");
            l_leRecuperos.ChangeCaption(ECliLlamada.AbonoanteriorCmp, "V1Abono Anterior2S2");
            l_leRecuperos.ChangeCaption(ECliLlamada.AbonorecuperadoCmp, "V1Abono Recupero2S2");
            l_leRecuperos.ChangeCaption("rentabilidad", "V1Diferencia2S2");

            // Terminamos la configuracion particular de cada reporte.
            if (rbDetalle.Checked)
            {
                p_intCorteDeControl = 0;
                l_leRecuperos.ChangeCaption(ECliente.RsocialCmp, "V1Razón SocialCN1");
                l_leRecuperos.ChangeCaption(ECliente.NroavalonCmp, "V1Nro. AvalonNN2");
                l_leRecuperos.ChangeCaption(ECliLlamada.FrealizadaCmp, "V1Fecha RealizadaFN1");
            }
            else
            {
                p_intCorteDeControl = 2;
                l_leRecuperos.ChangeCaption("cantclientes", "V1Cantidad ClientesNS2");
            }

            return l_leRecuperos;
        }
    }
}
