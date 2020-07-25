#region Usings

using TNGS.NetRoutines;
using Carm.Bel;
#endregion

namespace Carm.Bll
{
    //----------------------------------------------------------------------------
    //                         TNG Software BLL Generator
    //----------------------------------------------------------------------------
    // Fecha                    : 27/08/2013 21:01
    // Sistema                  : Sima
    // Clase para Administrar   : Planes
    //----------------------------------------------------------------------------
    // © 1996-2013 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    //****************************************************************************
    //    Agregue en esta clase los metodos fijos que desea incorporar 
    //****************************************************************************

    /// <summary>
    /// Mantenimiento de: Planes
    /// </summary>
    public static partial class Planes
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
        /// Agrega o modifica un registro de la tabla: Planes
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entPlan">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void Save_f(DBConn p_dbcAccess,
                                    ref EPlan p_entPlan,
                                    StatMsg p_smResult)
        {

            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: Planes
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

        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: Planes
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
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: Plan
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entPlan">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TInt_f(DBConn p_dbcAccess,
                                    EPlan p_entPlan,
                                    StatMsg p_smResult)
        {

            // *********
            // Agregar acá las validaciones adicionales
            // *********
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: PlnServicios
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entPlnServicio">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void PlsSave_f(DBConn p_dbcAccess,
                                       ref EPlnServicio p_entPlnServicio,
                                       StatMsg p_smResult)
        {

            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: PlnServicios
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCodplan">Código de Plan</param>
        /// <param name="p_strCodservicio">Código de Servicio</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void PlsEnabled_f(DBConn p_dbcAccess,
                                          bool p_bEnable,
                                          string p_strCodplan,
                                          string p_strCodservicio,
                                          ref int p_iFxdVersion,
                                          StatMsg p_smResult)
        {

            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: PlnServicios
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodplan">Código de Plan</param>
        /// <param name="p_strCodservicio">Código de Servicio</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void PlsRemove_f(DBConn p_dbcAccess,
                                         string p_strCodplan,
                                         string p_strCodservicio,
                                         int p_iFxdVersion,
                                         StatMsg p_smResult)
        {
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: PlnServicio
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entPlnServicio">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void PlsTInt_f(DBConn p_dbcAccess,
                                       EPlnServicio p_entPlnServicio,
                                       StatMsg p_smResult)
        {
        }

        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        #endregion
    }
}
