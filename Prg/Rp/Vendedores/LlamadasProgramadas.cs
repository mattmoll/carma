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
    public partial class LlamadasProgramadas : ReporteBase
    {
        // Miembros
        CDCombo cdcVendedores = new CDCombo();
        DateEdit deFechaIni = new DateEdit();
        DateEdit deFechaFin = new DateEdit();

        // Constructor
        public LlamadasProgramadas() : base("LlamadasProgramadas")
        {
            InitializeComponent();
        }
        
        public override void buildPanel()
        {
            Bel.LEVendedores l_leVendedores = Bll.Vendedores.UpFull(false, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;
            cdcVendedores.FillFromStrLEntidad(l_leVendedores, Bel.EVendedor.UsuarioCmp, "vnd_ede_nya", "deleted");

            // Añadimos las fechas, la combo y el grupo de radio buttons al panel.
            this.panelBuilder.AddControlWithLabel("Fecha Inicio", deFechaIni)
                             .AddControlWithLabel("Fecha Fin", deFechaFin)
                             .AddControlWithLabel("Vendedores", cdcVendedores);

            
        }

        override public ListaEntidades realizarBusqueda(ref string p_strNombreEmpresa, ref string p_strPrograma,
                                                        ref string p_strNombreReporte, ref string p_strDetalleReporte,
                                                        ref int p_intCorteDeControl)
        {
            // Validamos
            if ((deFechaIni.Fecha == DateTimeRuts.Empty) || (deFechaFin.Fecha == DateTimeRuts.Empty))
                ControlReporte.cancelarBusqueda("Es obligatorio cargar las fechas de inicio y fin de busqueda");

            // Cargamos los valores de referencia para el llenado del report.
            p_strNombreReporte = "Llamadas Programadas";

            ListaEntidades l_leLlamadasProg;
            // Obtenemos la lista entidad correspondiente segun el reporte pedido.
             
            l_leLlamadasProg = Bll.Vendedores.ZLlamadasProgramadas(cdcVendedores.SelectedStrCode, deFechaIni.Fecha, deFechaFin.Fecha, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return null;

            // Captionamos comunes a los dos reportes. 
            l_leLlamadasProg.ChangeCaption(ECliLlamada.NumclienteCmp, "V1Nro. ClienteNN1");
            l_leLlamadasProg.ChangeCaption(ECliLlamada.NumllamadaCmp, "V1Nro. LlamadaNN1");
            l_leLlamadasProg.ChangeCaption(ECliLlamada.CodusuarioCmp, "V1UsuarioCN1");
            l_leLlamadasProg.ChangeCaption(ECliLlamada.FrealizadaCmp, "V1Fecha ProgramadaFN1");
            l_leLlamadasProg.ChangeCaption("completada", "V1CompletadaCN1");
            l_leLlamadasProg.ChangeCaption(ECliLlamada.ObsprogramadaCmp, "V1Observación Al ProgramarlaCN1");

            return l_leLlamadasProg;
        }

    }
}
