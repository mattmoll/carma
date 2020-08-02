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
    public partial class VndEntrevistas : ReporteBase
    {
        // Miembros
        CDCombo cdcVendedores = new CDCombo();
        DateEdit deFechaIni = new DateEdit();
        DateEdit deFechaFin = new DateEdit();

        // Constructor
        public VndEntrevistas() : base("VndEntrevistas")
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
                             .AddControlWithLabel("Vendedor", cdcVendedores);

            
        }

        override public ListaEntidades realizarBusqueda(ref string p_strNombreEmpresa, ref string p_strPrograma,
                                                        ref string p_strNombreReporte, ref string p_strDetalleReporte,
                                                        ref int p_intCorteDeControl)
        {
            // Validamos
            if ((deFechaIni.Fecha == DateTimeRuts.Empty) || (deFechaFin.Fecha == DateTimeRuts.Empty))
                ControlReporte.cancelarBusqueda("Es obligatorio cargar las fechas de inicio y fin de busqueda");

            // Cargamos los valores por referencia para luego cargar el reporte.
            p_strNombreReporte = "Entrevistas de Vendedores";
            p_intCorteDeControl = 0;

            // Declaramos y definimos las 2 variables para los limites de la busqueda
            string l_strCodIniVendedor, l_strCodFinVendedor;

            // Logica de los limites de busqueda 
            if (cdcVendedores.SelectedStrCode.Trim() == "")
            {
                l_strCodIniVendedor = "     0";
                l_strCodFinVendedor = "zzzzzz";
            }
            else
                l_strCodIniVendedor = l_strCodFinVendedor = cdcVendedores.SelectedStrCode;

            // Llamamos al metodo que resuelve la busqueda

            ListaEntidades l_leEntrevistas = Bll.Vendedores.ZEntrevistasBasico(deFechaIni.Fecha,
                                                                               deFechaFin.Fecha, l_strCodIniVendedor,
                                                                               l_strCodFinVendedor, m_smResult);


            if (MsgRuts.AnalizeError(this, m_smResult)) return null;

            //Cambiamos los captions 
            l_leEntrevistas.ChangeCaption("cle_des_nombre", "V1EntrevistadoCN1");
            l_leEntrevistas.ChangeCaption("ren_des_des", "V1ResultadoCN1");
            l_leEntrevistas.ChangeCaption("vnd_apeynom", "V1VendedorCN1");

            return l_leEntrevistas;
        }

    }
}
