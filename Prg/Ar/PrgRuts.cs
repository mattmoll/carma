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

namespace Sima.Ar
{
    /// <summary>
    /// Rutinas generales del programa
    /// </summary>
    public partial class PrgRuts
    {
        #region Miembros estaticos de la clase
        private static AprobacionReservas m_frmMain = null;
        #endregion


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
            // Inicializamos el formulario
            m_frmMain.InitialUpdate();

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

        /// <summary>
        /// Rutina de armado de la ventana principal
        /// </summary>
        public static void MakeMainFrame()
        {
            // Creamos el formulario de Oficinas
            m_frmMain = new AprobacionReservas();
        }

        #endregion

        #region Información del About

        /// <summary>
        /// Registramos la informacion del ABOUT
        /// </summary>
        public static void MakeAboutInfo()
        {
            // Fijamos la información del About
            App.AboutInfo = SysRuts.MakeAboutInfo("Aprobacion de Solicitudes",
                                                 (Bitmap)App.Imagen("AppEEgg"));
        }

        #endregion

        //--------------------------------------------------------------------
        // Metodos privados de la clase
        //--------------------------------------------------------------------

        //--------------------------------------------------------------------
        // Propiedades de la clase
        //--------------------------------------------------------------------

    }
}
