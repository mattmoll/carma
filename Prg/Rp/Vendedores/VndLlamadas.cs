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
using Carm.Shr;
using TNGS.NetControls;
using TNGS.NetAppSupport;


namespace Carm.Rp
{
    public partial class VndLlamadas : ReporteBase
    {

        // Constructor
        public VndLlamadas() : base("VndReservas")
        {
            InitializeComponent();
        }

        public override void buildPanel()
        {
            // Llenamos la combo de vendedores
            Bel.LEVendedores l_leVendedores = Bll.Vendedores.UpFull(false, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;
            cdcVendedores.FillFromStrLEntidad(l_leVendedores, "vnd_cd6_cod", "vnd_ede_nya", "deleted");
            cdcVendedores.AddStrCD("", "-- TODOS --", 0);
            cdcVendedores.SelectedStrCode = "";

            // Llenamos la combo de motivos de llamada
            Bel.LECategoriasLlamada l_leCategoriasLlamadas = Bll.Tablas.CtlUpFull(false, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;
            cdcCategorias.FillFromStrLEntidad(l_leCategoriasLlamadas, Bel.ECategoriaLlamada.CodCmp, Bel.ECategoriaLlamada.DesCmp, "deleted");
            cdcCategorias.AddStrCD("", "-- TODOS --", 0);
            cdcCategorias.SelectedStrCode = "";
        }

        override public ListaEntidades realizarBusqueda(ref string p_strNombreEmpresa, ref string p_strPrograma,
                                                        ref string p_strNombreReporte, ref string p_strDetalleReporte,
                                                        ref int p_intCorteDeControl)
        {
            // Validamos
            if ((deFechaIni.Fecha == DateTimeRuts.Empty) || (deFechaFin.Fecha == DateTimeRuts.Empty))
                ControlReporte.cancelarBusqueda("Es obligatorio cargar las fechas de inicio y fin de busqueda");

            // Cargamos los valores por referencia para luego llenar el reporte.
            p_strNombreReporte = "Llamadas de Vendedores";
            p_intCorteDeControl = 0;

            ListaEntidades l_leLlamadas = null;
            string l_strTipoLlamada;

            // Si quiere ambos tipos de llamadas el valor va vacio
            l_strTipoLlamada = "";

            // Declaramos y definimos las 2 variables para los limites de la busqueda
            string l_strCodCatIni, l_strCodCatFin, l_strCodIniVendedor, l_strCodFinVendedor;
            l_strCodCatIni = l_strCodCatFin = "";

            // Logica de los limites de busqueda 
            if (cdcCategorias.SelectedStrCode.Trim() == "")
            {
                l_strCodCatIni = " 0";
                l_strCodCatFin = "zz";
            }
            else
                l_strCodCatIni = l_strCodCatFin = cdcCategorias.SelectedStrCode;

            // Logica de los limites de busqueda 
            if (cdcVendedores.SelectedStrCode.Trim() == "")
            {
                l_strCodIniVendedor = "     0";
                l_strCodFinVendedor = "zzzzzz";
            }
            else
                l_strCodIniVendedor = l_strCodFinVendedor = cdcVendedores.SelectedStrCode;


            // Llamamos al metodo que resuelve la busqueda
            l_leLlamadas = Bll.Vendedores.ZLlamados(deFechaIni.Fecha,
                                                    deFechaFin.Fecha,
                                                    l_strTipoLlamada,
                                                    l_strCodCatIni,
                                                    l_strCodCatFin,
                                                    l_strCodIniVendedor,
                                                    l_strCodFinVendedor,
                                                    m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return null;

            return l_leLlamadas;
        }

    }
}
