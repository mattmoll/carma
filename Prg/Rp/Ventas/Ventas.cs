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


namespace Carm.Rp
{
    public partial class Ventas : ReporteBase
    {
        // Miembros
        NumberEdit neAnio = new NumberEdit();
        CDCombo cdcMarcas = new CDCombo();

        public Ventas() : base("Facturacion", p_bFillDataMode: true)
        {
            InitializeComponent();
        }

        public override void buildPanel()
        {
            // Añadimos las fechas, la combo y el grupo de radio buttons al panel.
            this.panelBuilder.AddControlWithLabel("Año (aaaa)", neAnio);
        }

        // Sobreescribimos el metodo de busqueda y devolvemos la listaEntidades a mostrar.
        public override ListaEntidades realizarBusqueda(ref string p_strEmpresa,
                                                        ref string p_strPrograma,
                                                        ref string p_strTituloSolapa,
                                                        ref string p_strTituloGrid,
                                                        ref string p_strTituloPrint,
                                                        ref string p_strDetalle,
                                                        ref string p_strXlsName,
                                                        ref string p_strMSort,
                                                        ref string p_strMSortText,
                                                        ref string p_strMCCut,
                                                        ref Report.GraphicModes p_gmConfig,
                                                        ref object[] p_aoExtraData)
        {
            // Validamos
            if (neAnio.Numero < 1980)
                ControlReporte.cancelarBusqueda("Ingrese un año valido para realizar la busqueda");

            string l_strCodMarcaIni = "", l_strCodMarcaFin = "";
            // Logica de los limites de busqueda 
            if (cdcMarcas.SelectedStrCode.Trim() == "")
            {
                l_strCodMarcaIni = "  ";
                l_strCodMarcaFin = "zz";
            }
            else
                l_strCodMarcaIni = l_strCodMarcaFin = cdcMarcas.SelectedStrCode;

            ListaEntidades l_lentRet;

            // Disparamos la busqueda
            l_lentRet = Bll.Clientes.ClvZVentasPorMes(neAnio.Numero, l_strCodMarcaIni, l_strCodMarcaFin, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return null;

            // Cargamos las strings necesarias
            p_strTituloSolapa = "Listado de Ventas por Mes";
            p_strDetalle = String.Format("Listados de Ventas por Mes en el Año: {0}, para la empresa: {1}.", neAnio.Numero, cdcMarcas.SelectedItem.ToString());
            

            l_lentRet.ChangeCaption("Mes", "V2MesCN1X");
            l_lentRet.ChangeCaption("CantidadClientes", "V1Cantidad ClientesNS2");
            l_lentRet.ChangeCaption("AbonosClientes", "V2Abonos Clientes2S20");

            p_gmConfig = Report.GraphicModes.PivotInv;
            
            p_strEmpresa = PrgRuts.getEmpresa();

            return l_lentRet;
        }
    }
}
