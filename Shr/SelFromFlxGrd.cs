using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TNGS.NetRoutines;

namespace Carm.Shr
{
    /// <summary>
    /// Formulario para seleccion del items
    /// </summary>
    public partial class SelFromFlxGrd : Form
    {
        #region Miembros de la clase
            private ItemsString m_istrRta= null;
        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        public SelFromFlxGrd()
        {
            InitializeComponent();
        }

        //---------------------------------------------------------------
        // Eventos de los controles y el formulario
        //---------------------------------------------------------------

        /// <summary>
        /// Presionaron una tecla
        /// </summary>
        private void SelFromFlxGrd_KeyPress(object sender, KeyPressEventArgs e)
        {
            // El ESC cancela
            if (e.KeyChar == 0x1b)
                Close();
        }

        /// <summary>
        /// Doble click en la grilla
        /// </summary>
        private void flxgSelect_DoubleClick(object sender, EventArgs e)
        {
            // Guardamos los datos y finalizamos
            m_istrRta= flxgSelect.ItemSelected;
            Close();
        }

        //---------------------------------------------------------------
        // Metodos publicos de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Permite la seleccion de una lista de ItemsString
        /// </summary>
        /// <param name="p_frmParent">Formulario parent</param>
        /// <param name="p_aistrData">Lista de Items</param>
        /// <param name="p_iLinea">Linea a seleciconar</param>
        /// <returns>Renglon seleccionado o null</returns>
        public static ItemsString ShowData(Form p_frmParent,
                                           ItemsString[] p_aistrData)
        {
            return ShowData(p_frmParent, p_aistrData, 0, -1);
        }

        /// <summary>
        /// Permite la seleccion de una lista de ItemsString
        /// </summary>
        /// <param name="p_frmParent">Formulario parent</param>
        /// <param name="p_aistrData">Lista de Items</param>
        /// <param name="p_iLinea">Linea a seleciconar</param>
        /// <param name="p_iColumna">Columna a resaltar</param>
        /// <returns>Renglon seleccionado o null</returns>
        public static ItemsString ShowData(Form p_frmParent,
                                           ItemsString[] p_aistrData,
                                           int p_iColumna)
        {
            return ShowData(p_frmParent, p_aistrData, 0, p_iColumna);
        }

        /// <summary>
        /// Permite la seleccion de una lista de ItemsString
        /// </summary>
        /// <param name="p_frmParent">Formulario parent</param>
        /// <param name="p_aistrData">Lista de Items</param>
        /// <param name="p_iLinea">Linea a seleciconar</param>
        /// <param name="p_iColumna">Columna a resaltar</param>
        /// <returns>Renglon seleccionado o null</returns>
        public static ItemsString ShowData(Form p_frmParent,
                                           ItemsString[] p_aistrData,
                                           int p_iLinea,
                                           int p_iColumna)
        {
            // Llenamos con los datos y permitimos seleccionar
            SelFromFlxGrd l_frmSelect= new SelFromFlxGrd();

            l_frmSelect.flxgSelect.FillFromDataArray(p_aistrData,"");
            l_frmSelect.flxgSelect.NumFila= p_iLinea;
            l_frmSelect.flxgSelect.Resaltar= p_iColumna;
            l_frmSelect.ShowDialog(p_frmParent);
            return l_frmSelect.m_istrRta;
        }

        /// <summary>
        /// Permite la seleccion de una ListaEntidad
        /// </summary>
        /// <param name="p_frmParent">Formulario parent</param>
        /// <param name="p_lentData">Lista de Items</param>
        /// <returns>Renglon seleccionado o null</returns>
        public static ItemsString ShowData(Form p_frmParent,
                                           ListaEntidades p_lentData)
        {
            return ShowData(p_frmParent, p_lentData, 0, -1);
        }

        /// <summary>
        /// Permite la seleccion de una ListaEntidad
        /// </summary>
        /// <param name="p_frmParent">Formulario parent</param>
        /// <param name="p_lentData">Lista de Items</param>
        /// <param name="p_iColumna">Columna a resaltar</param>
        /// <returns>Renglon seleccionado o null</returns>
        public static ItemsString ShowData(Form p_frmParent,
                                           ListaEntidades p_lentData,
                                           int p_iColumna)
        {
            return ShowData(p_frmParent, p_lentData, 0, p_iColumna);
        }

        /// <summary>
        /// Permite la seleccion de una ListaEntidad
        /// </summary>
        /// <param name="p_frmParent">Formulario parent</param>
        /// <param name="p_lentData">Lista de Items</param>
        /// <param name="p_iLinea">Linea a seleciconar</param>
        /// <param name="p_iColumna">Columna a resaltar</param>
        /// <returns>Renglon seleccionado o null</returns>
        public static ItemsString ShowData(Form p_frmParent,
                                           ListaEntidades p_lentData,
                                           int p_iLinea,
                                           int p_iColumna)
        {
            // Llenamos con los datos y permitimos seleccionar
            SelFromFlxGrd l_frmSelect= new SelFromFlxGrd();

            l_frmSelect.flxgSelect.FillFromLentidad(p_lentData, null);
            l_frmSelect.flxgSelect.NumFila= p_iLinea;    
            l_frmSelect.flxgSelect.Resaltar= p_iColumna;
            l_frmSelect.ShowDialog(p_frmParent);
            return l_frmSelect.m_istrRta;
        }

        //---------------------------------------------------------------
        // Metodos privados de la clase
        //---------------------------------------------------------------

    }
}
