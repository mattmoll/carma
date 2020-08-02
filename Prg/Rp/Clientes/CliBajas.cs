using System;
using System.Windows.Forms;
using TNGS.NetApp;
using TNGS.NetControls;
using TNGS.NetRoutines;
using WeifenLuo.WinFormsUI.Docking;
using Carm.Bel;
using TNGS.NetAppSupport;

namespace Carm.Rp
{
    public partial class CliBajas : ReporteBase
    {
        // Miembros
        RadioButton rbDetalle = new RadioButton();
        RadioButton rbGeneral = new RadioButton();
        DateEdit deFechaIni = new DateEdit();
        DateEdit deFechaFin = new DateEdit();
        CDCombo cdcMarcas = new CDCombo();

        // Constructor
        public CliBajas(): base("CliBajas") 
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
            p_strNombreReporte = "Bajas Clientes";

            string l_strCodMarcaIni, l_strCodMarcaFin;

            // Logica de los limites de busqueda 
            if (cdcMarcas.SelectedStrCode.Trim() == "")
            {
                l_strCodMarcaIni = " 0";
                l_strCodMarcaFin = "zz";
            }
            else
                l_strCodMarcaIni = l_strCodMarcaFin = cdcMarcas.SelectedStrCode;

            ListaEntidades l_leBajas;
            // Obtenemos la lista entidad correspondiente segun el reporte pedido.
             
            if (rbDetalle.Checked)
                l_leBajas = Bll.Clientes.CllZBajasDetalle(deFechaIni.Fecha, deFechaFin.Fecha, l_strCodMarcaIni, l_strCodMarcaFin, m_smResult);
            else
                l_leBajas = Bll.Clientes.CllZBajasGral(deFechaIni.Fecha, deFechaFin.Fecha, l_strCodMarcaIni, l_strCodMarcaFin, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return null;


            // Captionamos comunes a los dos reportes. 
            l_leBajas.ChangeCaption(ECategoriaLlamada.DesCmp, "V1CategoríaCN1");
            l_leBajas.ChangeCaption(EMotivosLlamada.DesCmp, "V1MotivoCN1");


            // Terminamos la configuracion particular de cada reporte.
            if (rbDetalle.Checked)
            {
                p_intCorteDeControl = 0;
                l_leBajas.ChangeCaption("cls_imp_abono", "V1Abono2S1");
                l_leBajas.ChangeCaption(ECliLlamada.FrealizadaCmp, "V1Fecha RealizadaCN1");
                l_leBajas.ChangeCaption(ECliLlamada.CodusuarioCmp, "V1UsuarioCN1");
                l_leBajas.ChangeCaption(ECliente.NroavalonCmp, "V1Nro. AvalonNN1");
                l_leBajas.ChangeCaption(ECliente.RsocialCmp, "V1Razon SocialCN1");
            }
            else
            {
                p_intCorteDeControl = 1;
                l_leBajas.ChangeCaption("cantclientes", "V1Cantidad ClientesNS2");
                l_leBajas.ChangeCaption("cls_imp_abono", "V1Total Abonos2S1");
                l_leBajas.ChangeCaption("cls_nro_capitas", "V1Cantidad CapitasNS2");
            }

            return l_leBajas;
        }

    }
}
