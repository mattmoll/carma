#region Usings
using System;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Xml;
using TNGS.NetRoutines;
#endregion

namespace Carm.Bel
{
    //----------------------------------------------------------------------------
    //                         TNG Software BEL Generator
    //----------------------------------------------------------------------------
    // Fecha                    : 23/08/2013 12:30
    // Sistema                  : Sima
    // Clase para Administrar   : Supervisores
    //----------------------------------------------------------------------------
    // © 1996-2013 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    //****************************************************************************
    //    Agregue en esta clase los metodos fijos que desea incorporar 
    //****************************************************************************

    #region Entidad: Supervisor
    /// <summary>
    /// Clase que representa la Entidad: Supervisor
    ///   - Elementos no producidos por el Generador
    /// </summary>
    public sealed partial class ESupervisor : Entidad
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos públicos de la clase
        //---------------------------------------------------------------

        #endregion

        #region Metodos privados de la clase
        //---------------------------------------------------------------
        // Metodos privados de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Permite agregar datos al XML de la entidad
        /// </summary>
        private void fAddXMLData(ref XmlDocument p_xdocData,
                                 ref XmlNode p_xndEntidad)
        {
        }

        /// <summary>
        /// Permite agregar datos a una entidad generada desde un XML
        /// </summary>
        private static void fNewFromXML(ref DataRow p_drTemp,
                                        XmlNode p_xndData)
        {
        }

        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        #endregion
    }
    #endregion

    #region Lista-Entidad: Supervisores
    /// <summary>
    /// Clase que representa la Lista-Entidad: Supervisores
    ///   - Elementos no producidos por el Generador
    /// </summary>
    public sealed partial class LESupervisores : ListaEntidades
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        #endregion

        #region Metodos privados de la clase
        //---------------------------------------------------------------
        // Metodos privados
        //---------------------------------------------------------------

        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        #endregion
    }
    #endregion

    #region Lista-Entidad-Tipada: Supervisores
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: Supervisores
    ///   - Elementos no producidos por el Generador
    /// </summary>
    public sealed partial class LETSupervisores : LET<ESupervisor>
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        #endregion

        #region Metodos privados de la clase
        //---------------------------------------------------------------
        // Metodos privados
        //---------------------------------------------------------------

        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        #endregion
    }
    #endregion
}
