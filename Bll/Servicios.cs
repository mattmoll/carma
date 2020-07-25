#region Usings

using TNGS.NetRoutines;
using Carm.Bel;
using System;
#endregion

namespace Carm.Bll
{
    //----------------------------------------------------------------------------
    //                         TNG Software BLL Generator
    //----------------------------------------------------------------------------
    // Fecha                    : 27/08/2013 21:01
    // Sistema                  : Sima
    // Clase para Administrar   : Servicios
    //----------------------------------------------------------------------------
    // © 1996-2013 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    //****************************************************************************
    //    Agregue en esta clase los metodos fijos que desea incorporar 
    //****************************************************************************

    /// <summary>
    /// Mantenimiento de: Servicios
    /// </summary>
    public static partial class Servicios
    {
        //---------------------------------------------------------------
        // Metodos públicos de la clase
        //---------------------------------------------------------------

        #region Metodos publicos de la clase
        #endregion

        //---------------------------------------------------------------
        // Metodos privados de la clase
        //---------------------------------------------------------------

        #region Metodos del Generador
        /// <summary>
        /// Agrega o modifica un registro de la tabla: Servicios
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entServicio">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void Save_f(DBConn p_dbcAccess,
                                    ref EServicio p_entServicio,
                                    StatMsg p_smResult)
        {

            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: Servicios
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void Enabled_f(DBConn p_dbcAccess,
                                       bool p_bEnable,
                                       string p_strCod,
                                       ref int p_iFxdVersion,
                                       StatMsg p_smResult)
        {

            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: Servicios
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void Remove_f(DBConn p_dbcAccess,
                                      string p_strCod,
                                      int p_iFxdVersion,
                                      StatMsg p_smResult)
        {

            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: Servicio
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entServicio">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TInt_f(DBConn p_dbcAccess,
                                    EServicio p_entServicio,
                                    StatMsg p_smResult)
        {

            // *********
            // Agregar acá las validaciones adicionales
            // *********
        }

        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        #endregion
    }
}
