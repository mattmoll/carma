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
    // Fecha                    : 03/01/2023 23:43
    // Sistema                  : Carm
    // Clase para Administrar   : Shr
    //----------------------------------------------------------------------------
    // © 1996-2023 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    /// <summary>
    /// Clase para acceso directo a los Parametros RO
    /// </summary>
    public static partial class ROParam
    {
        //---------------------------------------------------------------
        // Propiedades de la clase 
        //---------------------------------------------------------------

        #region Propiedades con los parametros
        /// <summary>
        /// Parametro: CONTROLJOB
        /// </summary>
        public static EParametro Controljob
        {
            get {return LEParametrosRO.Datos["CONTROLJOB"];}
        }

        /// <summary>
        /// Parametro: COOLDOWN
        /// </summary>
        public static EParametro Cooldown
        {
            get {return LEParametrosRO.Datos["COOLDOWN"];}
        }

        /// <summary>
        /// Parametro: DIASCANCEL
        /// </summary>
        public static EParametro Diascancel
        {
            get {return LEParametrosRO.Datos["DIASCANCEL"];}
        }

        /// <summary>
        /// Parametro: EMPRESA
        /// </summary>
        public static EParametro Empresa
        {
            get {return LEParametrosRO.Datos["EMPRESA"];}
        }

        /// <summary>
        /// Parametro: MAIL
        /// </summary>
        public static EParametro Mail
        {
            get {return LEParametrosRO.Datos["MAIL"];}
        }

        /// <summary>
        /// Parametro: PASSCREDG
        /// </summary>
        public static EParametro Passcredg
        {
            get {return LEParametrosRO.Datos["PASSCREDG"];}
        }

        /// <summary>
        /// Parametro: PORTCORREO
        /// </summary>
        public static EParametro Portcorreo
        {
            get {return LEParametrosRO.Datos["PORTCORREO"];}
        }

        /// <summary>
        /// Parametro: SAFEMAIL
        /// </summary>
        public static EParametro Safemail
        {
            get {return LEParametrosRO.Datos["SAFEMAIL"];}
        }

        /// <summary>
        /// Parametro: SRVCORREO
        /// </summary>
        public static EParametro Srvcorreo
        {
            get {return LEParametrosRO.Datos["SRVCORREO"];}
        }

        /// <summary>
        /// Parametro: TRESERVTA
        /// </summary>
        public static EParametro Treservta
        {
            get {return LEParametrosRO.Datos["TRESERVTA"];}
        }

        /// <summary>
        /// Parametro: USRCREDG
        /// </summary>
        public static EParametro Usrcredg
        {
            get {return LEParametrosRO.Datos["USRCREDG"];}
        }

        #endregion
    }
}
