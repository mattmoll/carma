using System;
using System.Resources;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using System.Reflection;
using System.IO;
using TNGS.NetRoutines;
using TNGS.NetApp;
using Sima;
using Sima.Shr;

namespace Sima.Ct
{
    /// <summary>
    /// Rutinas generales del programa
    /// </summary>
    public partial class PrgRuts
    {
        #region Miembros estaticos de la clase
        #endregion

        //--------------------------------------------------------------------
        // Metodos públicos de la clase
        //--------------------------------------------------------------------

        #region Incio/Fin del programa

        /// <summary>
        /// Metodo de arranque del programa
        /// </summary>
        public static void AutoExec()
        {
            // Creamos el DockManager
            ((MainFrame)App.GetMainWindow()).CreateDockManager();
            ((MainFrame)App.GetMainWindow()).DockLeftPortion = 240;

            Cartas cartas = new Cartas();

            ((MainFrame)App.GetMainWindow()).AddContent(cartas);

            // Liberamos el menu
            App.LockMenu(false);
            App.HideMsg();
        }

        /// <summary>
        /// Metodo de fin del programa
        /// </summary>
        public static void EndExec()
        {
        }

        #endregion

        #region Información del About

        /// <summary>
        /// Registramos la informacion del ABOUT
        /// </summary>
        public static void MakeAboutInfo()
        {
            // Fijamos la información del About
            App.AboutInfo = SysRuts.MakeAboutInfo("Constructor de Cartas",
                                                 (Bitmap)App.Imagen("AppEEgg"));
        }

        #endregion

        public static void ReseteaBarraInferior()
        {
            App.EndAdvance();
            App.HideMsg();
        }

        //--------------------------------------------------------------------
        // Metodos privados de la clase
        //--------------------------------------------------------------------

        //--------------------------------------------------------------------
        // Propiedades de la clase
        //--------------------------------------------------------------------


    }
}
