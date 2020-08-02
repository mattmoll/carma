using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TNGS.NetApp;
using TNGS.NetAppSupport;
using TNGS.NetControls;
using TNGS.NetRoutines;
using WeifenLuo.WinFormsUI.Docking;
using Carm.Bel;

namespace Carm.Rp
{
    public partial class CliReclamos : ReporteBase
    {
        // Miembros
        RadioButton rbDetalle = new RadioButton();
        RadioButton rbGeneral = new RadioButton();
        DateEdit deFechaIni = new DateEdit();
        DateEdit deFechaFin = new DateEdit();
        CDCombo cdcMarcas = new CDCombo();

        // Constructor
        public CliReclamos() : base("CliReclamos") 
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
            p_strNombreReporte = "Reclamos Clientes";

            string l_strCodMarcaIni, l_strCodMarcaFin;

            // Logica de los limites de busqueda 
            if (cdcMarcas.SelectedStrCode.Trim() == "")
            {
                l_strCodMarcaIni = " 0";
                l_strCodMarcaFin = "zz";
            }
            else
                l_strCodMarcaIni = l_strCodMarcaFin = cdcMarcas.SelectedStrCode;

            ListaEntidades l_leReclamos;
            // Obtenemos la lista entidad correspondiente segun el reporte pedido.
             
            if (rbDetalle.Checked)
                l_leReclamos = Bll.Clientes.CllZReclamosDetalle(deFechaIni.Fecha, deFechaFin.Fecha, l_strCodMarcaIni, l_strCodMarcaFin, m_smResult);
            else
                l_leReclamos = Bll.Clientes.CllZReclamosGral(deFechaIni.Fecha, deFechaFin.Fecha, l_strCodMarcaIni, l_strCodMarcaFin, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return null;


            // Captionamos comunes a los dos reportes. 
            l_leReclamos.ChangeCaption(ECategoriaLlamada.DesCmp, "V1CategoríaCN1");
            l_leReclamos.ChangeCaption(EMotivosLlamada.DesCmp, "V1MotivoCN1");


            // Terminamos la configuracion particular de cada reporte.
            if (rbDetalle.Checked)
            {
                p_intCorteDeControl = 0;
                l_leReclamos.ChangeCaption(ECliente.RsocialCmp, "V1Razón SocialCN1");
                l_leReclamos.ChangeCaption(ECliente.NroavalonCmp, "V1Nro. AvalonNN2");
                l_leReclamos.ChangeCaption(ECliLlamada.FrealizadaCmp, "V1Fecha RealizadaFN1");
                l_leReclamos.ChangeCaption(ECliLlamada.CodusuarioCmp, "V1UsuarioCN1");
                l_leReclamos.ChangeCaption("comentario", "V1ComentarioCN1");
            }
            else
            {
                p_intCorteDeControl = 2;
                l_leReclamos.ChangeCaption("cantclientes", "V1Cantidad ClientesNS2");
                l_leReclamos.ChangeCaption("cantreclamos", "V1Cantidad ReclamosNS2");
            }

            return l_leReclamos;
        }

    }
}
