#region Usings
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Xml;
using TNGS.NetRoutines;
using TNGS.NetAppBll;
using TNGS.NetControls;
using Carm.Bll;
#endregion

namespace Carm.Shr
{
    //----------------------------------------------------------------------------
    //                         TNG Software SHR Generator
    //----------------------------------------------------------------------------
    // Fecha                    : 19/07/2021 08:58
    // Sistema                  : Carm
    // Clase para Administrar   : Shr
    //----------------------------------------------------------------------------
    // © 1996-2021 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    /// <summary>
    /// Clase con las rutinas del sistema
    /// </summary>
    public static partial class SysRuts
    {
        //--------------------------------------------------------------------
        // Metodos públicos de la clase
        //--------------------------------------------------------------------

        #region Metodos del AutoComplete
        /// <summary>
        /// Fija el Autocomplete de un campo
        /// </summary>
        /// <param name="p_txtControl">Control de texto</param>
        /// <param name="p_strCode">Codigo del Campo en la Registry</param>
        public static void LoadAutoComplete(TextEdit p_txtControl,
                                            string p_strCode)
        {
            // Fijamos el texto de autocomplete
            p_txtControl.SetAutoCompete(AutoCompleteMode.Suggest, GetACItems(p_strCode));
        }

        /// <summary>
        /// Guarda un nuevo valor en el autocomplete de un campo
        /// </summary>
        /// <param name="p_txtControl">Control de texto</param>
        /// <param name="p_strCode">Codigo del Campo en la Registry</param>
        public static void SaveAutoComplete(TextEdit p_txtControl,
                                            string p_strCode)
        {
            // Agregamos el item y recargamos
            if (AddACItem(p_strCode, p_txtControl.Text))
                p_txtControl.SetNewACList(GetACItems(p_strCode));
        }
        #endregion

        //--------------------------------------------------------------------
        // Metodos privados de la clase
        //--------------------------------------------------------------------

        #region Metodos del AutoComplete
        /// <summary>
        /// Devuelve la lista de Autocomplete de un campo
        /// </summary>
        /// <param name="p_strCode">Codigo del Campo en la Registry</param>
        /// <returns>Lista de autocomplete</returns>
        private static ItemsString GetACItems(string p_strCode)
        {
            // Devolvemos la lista de valores
            return new ItemsString(AppRuts.VRGetStrRegistry(true, "AutoComplete", p_strCode, ""));
        }

        /// <summary>
        /// Agrega un itema a la lista de Autocomplete de un campo
        /// </summary>
        /// <param name="p_strCode">Codigo del campo</param>
        /// <param name="p_strItem">Item a agregar</param>
        private static bool AddACItem(string p_strCode,
                                      string p_strItem)
        {
            // Si el items tiene datos
            if (p_strItem.Trim() != "") {
                // Recuperamos la lista
                ItemsString l_istrLista= GetACItems(p_strCode);

                // Si el item no esta
                if (!l_istrLista.Contains(p_strItem.Trim())) {
                    // Lo agregamos y regrabamos la lista
                    l_istrLista.AddItem(p_strItem.Trim());
                    AppRuts.VRSetStrRegistry(true, "AutoComplete", p_strCode, l_istrLista.ToString());
                    return true;
                }
            }

            // No tocamos la lista
            return false;
        }
        #endregion

        //---------------------------------------------------------------
        // Propiedades de la clase 
        //---------------------------------------------------------------
    }

    #region Clase: CarmStatMsg
    /// <summary>
    /// Clase con las rutinas del sistema
    /// </summary>
    public sealed class CarmStatMsg
    {
        #region Miembros de la clase
            StatMsg m_smResult= new StatMsg();
        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        public CarmStatMsg()
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public CarmStatMsg(string p_strUilMethod)
        {
        }

        //-------------------------------------------------------
        // Metodos publicos de la clase
        //-------------------------------------------------------

        //-------------------------------------------------------
        // Propiedades internas de la clase
        //-------------------------------------------------------

        /// <summary>
        /// Fija/Recupera el StatMsg interno
        /// </summary>
        internal StatMsg StatMsg
        {
            get {return m_smResult;}
            set {m_smResult= value;}
        }

        //-------------------------------------------------------
        // Propiedades publicas de la clase
        //-------------------------------------------------------

        /// <summary>
        /// Estado NOT OK del resultado
        /// </summary>
        public bool NOk
        {
            get {return m_smResult.NOk;}
        }

        /// <summary>
        /// Valor del Código Stat
        /// </summary>
        public int Stat
        {
            get {return m_smResult.Stat;}
        }

        /// <summary>
        /// Texto del mensaje
        /// </summary>
        public string Msg
        {
            get {return m_smResult.Msg;}
        }

        /// <summary>
        /// Texto del detalle
        /// </summary>
        public string Detail
        {
            get {return m_smResult.Detail;}
        }
    }
    #endregion
}
