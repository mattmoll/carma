#region Usings
using System;
using System.Resources;
using TNGS.NetRoutines;
using TNGS.NetApp;
using Carm;
#endregion

namespace Carm.Rp
{
    /// <summary>
    /// Clase que contiene el Punto de arranque del sistema
    /// </summary>
    public sealed partial class Arranque
    {
        /// <summary>
        /// Metodo que se ejecuta antes del App.Init
        /// </summary>
        /// <returns>T- Todo OK / F- Cancelar el programa</returns>
        public static bool PreInit()
        {
            App.TitleWithBuild = false;

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
    }
}
