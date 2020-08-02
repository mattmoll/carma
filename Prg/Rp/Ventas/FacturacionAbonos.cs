using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TNGS.NetApp;
using TNGS.NetRoutines;
using WeifenLuo.WinFormsUI.Docking;
using TNGS.NetControls;
using Carm.Bel;
using TNGS.NetAppSupport;

namespace Carm.Rp
{
    public partial class FacturacionAbonos : ReporteBase
    {
        // Miembros
        NumberEdit neAnio = new NumberEdit();
        NumberEdit neMes = new NumberEdit();
        CDCombo cdcMarcas = new CDCombo();


        public FacturacionAbonos()
            : base("FacturacionAbonos", p_bFillDataMode: true)
        {
            InitializeComponent();
        }

        public override void buildPanel()
        {
            // Llenamos la combo de vendedores
             

            // Añadimos las fechas, la combo y el grupo de radio buttons al panel.
            this.panelBuilder.AddControlWithLabel("Año (aaaa) ", neAnio)
                             .AddControlWithLabel("Mes (MM) ", neMes);

            
        }


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
            // Cargamos los valores por referencia para luego cargar el reporte.
            p_strDetalle = "Abonos para el mes: " + neMes.Numero.ToString() + 
                                 " para la Marca: " + cdcMarcas.SelectedItem.ToString();

            // Validamos las fechas
            if (!neMes.IsValid || !neAnio.IsValid)
            {
                MsgRuts.ShowMsg(this, "Es obligatorio definir un año y mes para el pedido del reporte");
                return null;
            }
            string l_strCodMarcaIni, l_strCodMarcaFin;

            if (neMes.Numero > 12)
            {
                MsgRuts.ShowMsg(this, "No existen mas de 12 meses!");
                return null;
            }

            // Logica de los limites de busqueda 
            if (cdcMarcas.SelectedStrCode.Trim() == "")
            {
                l_strCodMarcaIni = " 0";
                l_strCodMarcaFin = "zz";
            }
            else
                l_strCodMarcaIni = l_strCodMarcaFin = cdcMarcas.SelectedStrCode;


            ListaEntidades l_leDetalleVentas = null;

            l_leDetalleVentas = Bll.Clientes.ClvZDetalleVentas(neAnio.Numero,
                                                               neMes.Numero, 
                                                               l_strCodMarcaIni,
                                                               l_strCodMarcaFin,
                                                               m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return null;

            //Cambiamos los captions 
            l_leDetalleVentas.ChangeCaption(ECliVenta.NumclienteCmp, "V1Número ClienteNN2");
            l_leDetalleVentas.ChangeCaption(ECliente.RsocialCmp, "V1Razón SocialCN1");
            l_leDetalleVentas.ChangeCaption(ECliVenta.FechaCmp, "V1FechaFN1");
            l_leDetalleVentas.ChangeCaption("vendedor", "V1VendedorCN1");
            l_leDetalleVentas.ChangeCaption(ECliVenta.AbonoCmp, "V1Abono2N1");

            return l_leDetalleVentas;
        }
    }
}
