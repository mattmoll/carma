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
using Sima;
using Sima.Shr;

namespace Sima.Ar
{
    //----------------------------------------------------------------------------
    //                         TNG Software PRG Generator
    //----------------------------------------------------------------------------
    // Fecha                    : 27/05/2013 18:25
    // Sistema                  : Sima
    // Programa                 : Aprobacion de Reservas
    //----------------------------------------------------------------------------
    // © 1996-2013 by TNG Software                                      Gndr 5.00
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
    }
}
