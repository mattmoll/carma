#region Usings
using System;
using System.Resources;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using System.Reflection;
using System.IO;
using System.Threading;
using TNGS.NetRoutines;
using TNGS.NetApp;
using TNGS.NetAppSupport;
using Sima;
using Sima.Shr;
#endregion

namespace Sima.Ar
{
    //----------------------------------------------------------------------------
    //                         TNG Software PRG Generator
    //----------------------------------------------------------------------------
    // Fecha                    : 17/02/2019 23:06
    // Sistema                  : Sima
    // Programa                 : Aprobacion de Reservas
    //----------------------------------------------------------------------------
    // © 1996-2019 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    //****************************************************************************
    // Atencion!!!
    //    Esta clase fue generada por un programa en forma automática. Cualquier
    //    modificación que se realize sobre ella se perderá en la próxima
    //    regeneración.
    //****************************************************************************

    /// <summary>
    /// Clase que contiene el Punto de arranque del sistema
    /// </summary>
    public sealed partial class Arranque
    {
        /// <summary>
        /// Punto de arranque del sistema
        /// </summary>
        [STAThread]
        static void Main() 
        {
            // Creamos el objeto de reporte de errores
            StatMsg l_smResult= new StatMsg();

            try {
                // Verificamos si ya esta ejecutándose
                if (App.EnEjecucion) {
                    // Mostramos un aviso y nos vamos
                    MessageBox.Show("Ya existe una versión del Aprobacion de Reservas en ejecución", "Atención");
                    return;
                }

                // Incializamos recursos
                ResourceManager l_rmApp= new ResourceManager(typeof(Arranque));

                // Habilitamos el estilo XP
                App.EnableXPStyle();

                // Definimos el skin
                TNGSSkin.ChangeSkin(FixedSkins.Office14);

                // Llamamos al PreInit del Shr y del Programa
                if (!SysRuts.PreInit()) return;
                if (!Arranque.PreInit()) return;

#if (!DEBUG)
                // Mostramos la ventana Splash (con la imagen interna del programa)
                App.ShowSplash((Bitmap)(l_rmApp.GetObject("AppSplash")), false, 296, 
                               (Bitmap)(l_rmApp.GetObject("AppSplashMarquee")));
#endif

                // Inicializamos nuestra clase App
                App.Init("Sima", "Ar",
                         FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location),
                         l_rmApp,
                         Application.StartupPath, 
                         ParOptions.LoadParameters,
                         LOGOptions.WithoutLOG,
                         ValidOptions.Validate,
                         ConStrOptions.Read,
                         true,
                         l_smResult);
            }
            catch (Exception l_expData) {
                // Se produjo un error no capturado
                l_smResult.BllError(l_expData);
            }

            if (l_smResult.NOk) {
                // Cerramos la ventana de Splash
                App.CloseSplash();

                // Errores de inicializacion. Mostramos el error
                MsgRuts.AnalizeError(null, l_smResult);
                return;
            }

            try {
                // Ejecutamos la funcion que construye la pantalla principal
                PrgRuts.MakeMainFrame();

                // Fijamos la imagen de Login/Pasword
                App.FdoLoginPassw= App.Imagen("AppLogPassw");

                // Llamamos al PreRun del Shr y del Programa
                if (!SysRuts.PreRun()) return;
                if (!Arranque.PreRun()) return;

                // Inicializamos la ventana principal y agregamos el handler para
                // procesar los comandos del menu
                App.MnuCommands += new MnuCommandsEventHandler(Arranque_MnuCommandsMF);

                App.Run(LoginModes.Full,
                        IMenuOptions.None,
                        ExitModes.Normal,
                        l_smResult);
            }
            catch (Exception l_expData) {
                // Se produjo un error no capturado
                l_smResult.BllError(l_expData);
            }

            MsgRuts.AnalizeError(null, l_smResult);
        }

        /// <summary>
        /// Handler de los comandos de Menu/Toolbar
        /// </summary>
        public static void Arranque_MnuCommandsMF(object sender, MFOptionEventArgs e)
        {
            // Bloqueamos el menu
            App.LockMenu(true);

            // Procesamos el código 
            switch (e.CmdCode) {
                // *************************************************
                // ** Ejecución automática al inicio del programa
                // **
                case "$$AUTOEXEC$$"  : {SysRuts.AutoExecIni(App.Programa.Codigo); PrgRuts.AutoExec(); SysRuts.AutoExecEnd(App.Programa.Codigo); return;}

                // *************************************************
                // ** Ejecución automática al final del programa
                // **
                case "$$ENDEXEC$$"   : {SysRuts.EndExecIni(App.Programa.Codigo); PrgRuts.EndExec(); SysRuts.EndExecEnd(App.Programa.Codigo); return;}
            }

            // Comando no identificado. Liberamos el menu
            App.LockMenu(false);
            App.HideMsg();
        }
    }
}
