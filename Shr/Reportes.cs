using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using TNGS.NetRoutines;
using TNGS.NetAppBll;

namespace Carm.Shr
{
    public partial class Reportes : DockContent
    {
        // Miembros
        StatMsg m_smResult = new StatMsg();
        private string m_strKey;

        // Constructor
        public Reportes()
        {
            InitializeComponent();
        }


        // Metodo publico para cargar el reporte a partir de los parametros
        public void CargaReport(ListaEntidades p_leEntidades, 
                                string p_strDescripcion, 
                                string p_strEmpresa,
                                string p_strPrograma,
                                string p_strPrint,
                                string p_strKey,
                                int p_iCorteDeControl,
                                TNGS.NetControls.Report.GraphicModes p_gpGraphicMode)
        {
            // Guardamos la key del state
            m_strKey = p_strKey;

            // Si no quiere corte de control le cargamos el estado de las columnas
            if (p_iCorteDeControl==0)
                rpReporte.LoadData(p_leEntidades,
                               p_strDescripcion,
                               p_strEmpresa,
                               p_strPrograma,
                               p_strPrint,
                               "Reporte",
                               "Reporte",
                               p_gpGraphicMode,
                               AppRuts.GetStrURegistry(false, m_strKey, "GridFormat", ""),
                               m_smResult);
            // Si no hacemos corte de control para que no se repita el primer campo por cada registro
            else if (p_iCorteDeControl == 1)
                rpReporte.LoadData(p_leEntidades,
                               p_strDescripcion,
                               p_strEmpresa,
                               p_strPrograma,
                               p_strPrint,
                               "Reporte",
                               "Reporte",
                               p_gpGraphicMode,
                               new string[] {p_leEntidades.InternalData.Table.Columns[0].ColumnName},
                               m_smResult);
            else if (p_iCorteDeControl == 2)
                rpReporte.LoadData(p_leEntidades,
                               p_strDescripcion,
                               p_strEmpresa,
                               p_strPrograma,
                               p_strPrint,
                               "Reporte",
                               "Reporte",
                               p_gpGraphicMode,
                               new string[] { p_leEntidades.InternalData.Table.Columns[0].ColumnName,
                                              p_leEntidades.InternalData.Table.Columns[1].ColumnName},
                               m_smResult);

        }

        #region Eventos obligatorios del Report
        private void rpReporte_Advance(object sender, AdvanceEventArgs e)
        {
            AppRuts.App_Advance(e.Percent);
        }

        private void rpReporte_ExportGridEnded(object sender, EventArgs e)
        {
            AppRuts.App_EndAdvance();
        }

        private void rpReporte_ExportGridIniting(object sender, CancelEventArgs e)
        {
            AppRuts.App_InitAdvance("Exportando");
        }

        private void rpReporte_PrintGridEnded(object sender, EventArgs e)
        {
            AppRuts.App_EndAdvance();
        }

        private void rpReporte_PrintGridIniting(object sender, CancelEventArgs e)
        {
            AppRuts.App_InitAdvance("Imprimiendo");
        }

        private void rpReporte_ReportLastState(object sender, ReportLastStateEventArgs e)
        {
            AppRuts.SetStrURegistry(false, m_strKey, "GridFormat", e.LastState);
        }
        #endregion

    }
}
