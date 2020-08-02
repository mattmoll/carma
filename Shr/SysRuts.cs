#region Usings
using System;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using TNGS.NetAppBll;
using TNGS.NetRoutines;
using Carm;
#endregion

namespace Carm.Shr
{
    //----------------------------------------------------------------------------
    //                         TNG Software BLL Generator
    //----------------------------------------------------------------------------
    // Fecha                    : 23/10/2013 15:50
    // Sistema                  : Sima
    // Clase para Administrar   : Shr
    //----------------------------------------------------------------------------
    // © 1996-2013 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    //****************************************************************************
    //    Agregue en esta clase los metodos fijos que desea incorporar 
    //****************************************************************************
    /// <summary>
    /// Clase con las rutinas del sistema
    /// </summary>
    public static partial class SysRuts
    {
        //---------------------------------------------------------------
        // Metodos públicos de la clase 
        //---------------------------------------------------------------

        #region Ventana About
        /// <summary>
        /// Arma la información de la ventana de "Acerca de"
        /// </summary>
        /// <param name="p_strTitle">Titulo del programa</param>
        /// <param name="p_bmpEEgg">Imagen Eastern Egg</param>
        public static AboutInfo MakeAboutInfo(string p_strTitle,
                                              Bitmap p_bmpEEgg)
        {
            // Llenamos la información de la ventana About...
            AboutInfo l_aiData = new AboutInfo();

            l_aiData.FrmColor = Color.FromArgb(255,255,255);
            l_aiData.ConIcono = true;
            l_aiData.ConLogo = true;
            l_aiData.Copyright = String.Format("© Copyright 2003-{0:yy} by TNGS\r\n" +
                                              "www.tngs.com.ar    email: info@\r\n\r\n" +
                                              "Programa de la solucion Carm.",
                                              DateTime.Now);
            l_aiData.ConScroll = true;
            l_aiData.ScrollColor = Color.FromArgb(255,255,255);
            l_aiData.ScrollTxt= "[C][O][3]" + p_strTitle + "\r\n" +
                                "[I][N][2]Desarrolladores:\r\n" +
                                "[F][1][C]Moll Matias (Contacto: matias_moll@yahoo.com.ar)\r\n" +
                                "[N][2][I]Diseño:\r\n" +
                                "[F][1][C]Moll Marcelo \r\n\r\n" +
                                "[F][1][C]Moll Matias (Contacto: matias_moll@yahoo.com.ar)\r\n\r\n" +
                                "[I]" +
                                AboutInfo.AboutCopyright +       // No Remover!!. Son los copyrights de los elementos licenciados
                                "Advertencia: Los códigos fuentes de este programa están protegidos por las leyes de derecho de autor para todo el territorio argentino.\r\n\r\n";
            l_aiData.EECode = "<Alt\tT: Secuncia del EEgg>"; //"Menu, Alt\tT, Alt\tN, Alt\tG, Alt\tS, Alt\tY\tA\t";
            l_aiData.EEImage = p_bmpEEgg;
            return l_aiData;
        }


        #endregion

        /// <summary>
        /// Permite seleccionar las localidades Pais
        /// </summary>
        /// <param name="p_frmParent">Formulario Parent</param>
        /// <param name="p_bEnabCanc">Habilita ESC para cancelar</param>
        public static Bel.ELocalidad fGetLocalidadesPais(Form p_frmParent,
                                                         bool p_bEnabCanc)
        {
            // Mostramos la búsqueda de localidades
            BusqLocalidades l_frmBLoc = new BusqLocalidades(p_bEnabCanc);
            if (l_frmBLoc.ShowDialog(p_frmParent) == DialogResult.Cancel)
                return null;

            // Devolvemos la localidad seleciconada
            return l_frmBLoc.Localidad;
        }

        #region Incio/Fin del programa

        /// <summary>
        /// Metodo que se ejecuta antes del App.Init
        /// </summary>
        /// <returns>T- Todo OK / F- Cancelar el programa</returns>
        public static bool PreInit()
        {
            // Todo ok
            return true;
        }

        /// <summary>
        /// Metodo que se ejecuta antes del App.Run
        /// </summary>
        /// <returns>T- Todo OK / F- Cancelar el programa</returns>
        public static bool PreRun()
        {
            // Todo ok
            return true;
        }

        /// <summary>
        /// Metodo de arranque del programa (llamado inicial)
        /// </summary>
        public static void AutoExecIni(string p_strPrgCode)
        {
        }

        /// <summary>
        /// Metodo de arranque del programa (llamado final)
        /// </summary>
        public static void AutoExecEnd(string p_strPrgCode)
        {
        }

        /// <summary>
        /// Metodo de fin del programa (llamado inicial)
        /// </summary>
        public static void EndExecIni(string p_strPrgCode)
        {
        }

        /// <summary>
        /// Metodo de fin del programa (llamado final)
        /// </summary>
        public static void EndExecEnd(string p_strPrgCode)
        {
        }
        #endregion

        //---------------------------------------------------------------
        // Metodos privados de la clase 
        //---------------------------------------------------------------

    }
}
