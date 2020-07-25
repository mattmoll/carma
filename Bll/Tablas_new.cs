#region Usings
using System;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Xml;
using TNGS.NetAppBll;
using TNGS.NetRoutines;
using Sima;
using Sima.Bel;
#endregion

namespace Sima.Bll
{
    //----------------------------------------------------------------------------
    //                         TNG Software BLL Generator
    //----------------------------------------------------------------------------
    // Fecha                    : 07/06/2016 22:00
    // Sistema                  : Sima
    // Clase para Administrar   : Tablas
    //----------------------------------------------------------------------------
    // © 1996-2016 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    //****************************************************************************
    //    Agregue en esta clase los metodos fijos que desea incorporar 
    //****************************************************************************

    /// <summary>
    /// Mantenimiento de: Tablas
    /// </summary>
    public static partial class Tablas
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
        /// Agrega o modifica un registro de la tabla: BasesOp
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entBasesOp">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void BopSave_f(DBConn p_dbcAccess,
                                       ref EBasesOp p_entBasesOp,
                                       ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: BasesOp
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void BopEnabled_f(DBConn p_dbcAccess,
                                          bool p_bEnable,
                                          string p_strCod,
                                          ref int p_iFxdVersion,
                                          ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: BasesOp
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void BopRemove_f(DBConn p_dbcAccess,
                                         string p_strCod,
                                         int p_iFxdVersion,
                                         ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: BasesOp
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entBasesOp">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void BopTInt_f(DBConn p_dbcAccess,
                                       EBasesOp p_entBasesOp,
                                       ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá las validaciones adicionales
            // *********
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: CategoriasLlamada
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCategoriaLlamada">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CtlSave_f(DBConn p_dbcAccess,
                                       ref ECategoriaLlamada p_entCategoriaLlamada,
                                       ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: CategoriasLlamada
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CtlEnabled_f(DBConn p_dbcAccess,
                                          bool p_bEnable,
                                          string p_strCod,
                                          ref int p_iFxdVersion,
                                          ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: CategoriasLlamada
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CtlRemove_f(DBConn p_dbcAccess,
                                         string p_strCod,
                                         int p_iFxdVersion,
                                         ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: CategoriaLlamada
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCategoriaLlamada">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CtlTInt_f(DBConn p_dbcAccess,
                                       ECategoriaLlamada p_entCategoriaLlamada,
                                       ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá las validaciones adicionales
            // *********
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: Codigos
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCodigo">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CdgSave_f(DBConn p_dbcAccess,
                                       ref ECodigo p_entCodigo,
                                       ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: Codigos
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CdgEnabled_f(DBConn p_dbcAccess,
                                          bool p_bEnable,
                                          string p_strCod,
                                          ref int p_iFxdVersion,
                                          ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: Codigos
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CdgRemove_f(DBConn p_dbcAccess,
                                         string p_strCod,
                                         int p_iFxdVersion,
                                         ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: Codigo
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCodigo">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CdgTInt_f(DBConn p_dbcAccess,
                                       ECodigo p_entCodigo,
                                       ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá las validaciones adicionales
            // *********
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: ConversionColores
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entConversionColor">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ConSave_f(DBConn p_dbcAccess,
                                       ref EConversionColor p_entConversionColor,
                                       ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: ConversionColores
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ConEnabled_f(DBConn p_dbcAccess,
                                          bool p_bEnable,
                                          string p_strCod,
                                          ref int p_iFxdVersion,
                                          ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: ConversionColores
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ConRemove_f(DBConn p_dbcAccess,
                                         string p_strCod,
                                         int p_iFxdVersion,
                                         ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: ConversionColor
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entConversionColor">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ConTInt_f(DBConn p_dbcAccess,
                                       EConversionColor p_entConversionColor,
                                       ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá las validaciones adicionales
            // *********
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: Dominios
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entDominio">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void DomSave_f(DBConn p_dbcAccess,
                                       ref EDominio p_entDominio,
                                       ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: Dominios
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCodigo">Código</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void DomEnabled_f(DBConn p_dbcAccess,
                                          bool p_bEnable,
                                          string p_strCodigo,
                                          ref int p_iFxdVersion,
                                          ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: Dominios
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodigo">Código</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void DomRemove_f(DBConn p_dbcAccess,
                                         string p_strCodigo,
                                         int p_iFxdVersion,
                                         ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: Dominio
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entDominio">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void DomTInt_f(DBConn p_dbcAccess,
                                       EDominio p_entDominio,
                                       ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá las validaciones adicionales
            // *********
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: Franquicias
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entFranquicia">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void FrqSave_f(DBConn p_dbcAccess,
                                       ref EFranquicia p_entFranquicia,
                                       ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: Franquicias
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void FrqEnabled_f(DBConn p_dbcAccess,
                                          bool p_bEnable,
                                          string p_strCod,
                                          ref int p_iFxdVersion,
                                          ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: Franquicias
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void FrqRemove_f(DBConn p_dbcAccess,
                                         string p_strCod,
                                         int p_iFxdVersion,
                                         ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: Franquicia
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entFranquicia">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void FrqTInt_f(DBConn p_dbcAccess,
                                       EFranquicia p_entFranquicia,
                                       ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá las validaciones adicionales
            // *********
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: HistoricoAbonos
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entHistoricoAbono">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void HiaSave_f(DBConn p_dbcAccess,
                                       ref EHistoricoAbono p_entHistoricoAbono,
                                       ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: HistoricoAbonos
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_iNroavalon">Numero Avalon</param>
        /// <param name="p_strCodmarca">Marca</param>
        /// <param name="p_dtFecha">Fecha</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void HiaEnabled_f(DBConn p_dbcAccess,
                                          bool p_bEnable,
                                          int p_iNroavalon,
                                          string p_strCodmarca,
                                          DateTime p_dtFecha,
                                          ref int p_iFxdVersion,
                                          ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: HistoricoAbonos
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNroavalon">Numero Avalon</param>
        /// <param name="p_strCodmarca">Marca</param>
        /// <param name="p_dtFecha">Fecha</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void HiaRemove_f(DBConn p_dbcAccess,
                                         int p_iNroavalon,
                                         string p_strCodmarca,
                                         DateTime p_dtFecha,
                                         int p_iFxdVersion,
                                         ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: HistoricoAbono
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entHistoricoAbono">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void HiaTInt_f(DBConn p_dbcAccess,
                                       EHistoricoAbono p_entHistoricoAbono,
                                       ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá las validaciones adicionales
            // *********
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: Localidades
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entLocalidad">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void LocSave_f(DBConn p_dbcAccess,
                                       ref ELocalidad p_entLocalidad,
                                       ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: Localidades
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCodpost">Código postal</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void LocEnabled_f(DBConn p_dbcAccess,
                                          bool p_bEnable,
                                          string p_strCodpost,
                                          ref int p_iFxdVersion,
                                          ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: Localidades
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodpost">Código postal</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void LocRemove_f(DBConn p_dbcAccess,
                                         string p_strCodpost,
                                         int p_iFxdVersion,
                                         ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: Localidad
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entLocalidad">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void LocTInt_f(DBConn p_dbcAccess,
                                       ELocalidad p_entLocalidad,
                                       ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá las validaciones adicionales
            // *********
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: LogClientes
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entLogCliente">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void LgcSave_f(DBConn p_dbcAccess,
                                       ref ELogCliente p_entLogCliente,
                                       ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: LogClientes
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_iNro">Numero</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void LgcEnabled_f(DBConn p_dbcAccess,
                                          bool p_bEnable,
                                          int p_iNro,
                                          ref int p_iFxdVersion,
                                          ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: LogClientes
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNro">Numero</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void LgcRemove_f(DBConn p_dbcAccess,
                                         int p_iNro,
                                         int p_iFxdVersion,
                                         ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: LogCliente
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entLogCliente">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void LgcTInt_f(DBConn p_dbcAccess,
                                       ELogCliente p_entLogCliente,
                                       ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá las validaciones adicionales
            // *********
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: MarcaNotificados
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMarcaNotificado">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MntSave_f(DBConn p_dbcAccess,
                                       ref EMarcaNotificado p_entMarcaNotificado,
                                       ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: MarcaNotificados
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCodmarca">Marca</param>
        /// <param name="p_strCodnotificado">Notificado</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MntEnabled_f(DBConn p_dbcAccess,
                                          bool p_bEnable,
                                          string p_strCodmarca,
                                          string p_strCodnotificado,
                                          ref int p_iFxdVersion,
                                          ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: MarcaNotificados
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodmarca">Marca</param>
        /// <param name="p_strCodnotificado">Notificado</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MntRemove_f(DBConn p_dbcAccess,
                                         string p_strCodmarca,
                                         string p_strCodnotificado,
                                         int p_iFxdVersion,
                                         ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: MarcaNotificado
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMarcaNotificado">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MntTInt_f(DBConn p_dbcAccess,
                                       EMarcaNotificado p_entMarcaNotificado,
                                       ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá las validaciones adicionales
            // *********
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: Marcas
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMarca">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MrcSave_f(DBConn p_dbcAccess,
                                       ref EMarca p_entMarca,
                                       ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: Marcas
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MrcEnabled_f(DBConn p_dbcAccess,
                                          bool p_bEnable,
                                          string p_strCod,
                                          ref int p_iFxdVersion,
                                          ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: Marcas
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MrcRemove_f(DBConn p_dbcAccess,
                                         string p_strCod,
                                         int p_iFxdVersion,
                                         ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: Marca
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMarca">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MrcTInt_f(DBConn p_dbcAccess,
                                       EMarca p_entMarca,
                                       ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá las validaciones adicionales
            // *********
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: MarcasXCliente
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMarcaXCliente">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MclSave_f(DBConn p_dbcAccess,
                                       ref EMarcaXCliente p_entMarcaXCliente,
                                       ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: MarcasXCliente
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_iNrocliente">Numero de Cliente</param>
        /// <param name="p_strCodmarca">Código de Marca</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MclEnabled_f(DBConn p_dbcAccess,
                                          bool p_bEnable,
                                          int p_iNrocliente,
                                          string p_strCodmarca,
                                          ref int p_iFxdVersion,
                                          ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: MarcasXCliente
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNrocliente">Numero de Cliente</param>
        /// <param name="p_strCodmarca">Código de Marca</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MclRemove_f(DBConn p_dbcAccess,
                                         int p_iNrocliente,
                                         string p_strCodmarca,
                                         int p_iFxdVersion,
                                         ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: MarcaXCliente
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMarcaXCliente">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MclTInt_f(DBConn p_dbcAccess,
                                       EMarcaXCliente p_entMarcaXCliente,
                                       ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá las validaciones adicionales
            // *********
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: ModeloCarta
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entModeloCarta">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MdcSave_f(DBConn p_dbcAccess,
                                       ref EModeloCarta p_entModeloCarta,
                                       ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: ModeloCarta
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MdcEnabled_f(DBConn p_dbcAccess,
                                          bool p_bEnable,
                                          string p_strCod,
                                          ref int p_iFxdVersion,
                                          ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: ModeloCarta
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MdcRemove_f(DBConn p_dbcAccess,
                                         string p_strCod,
                                         int p_iFxdVersion,
                                         ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: ModeloCarta
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entModeloCarta">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MdcTInt_f(DBConn p_dbcAccess,
                                       EModeloCarta p_entModeloCarta,
                                       ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá las validaciones adicionales
            // *********
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: MotivosLlamada
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMotivosLlamada">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MtlSave_f(DBConn p_dbcAccess,
                                       ref EMotivosLlamada p_entMotivosLlamada,
                                       ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: MotivosLlamada
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MtlEnabled_f(DBConn p_dbcAccess,
                                          bool p_bEnable,
                                          string p_strCod,
                                          ref int p_iFxdVersion,
                                          ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: MotivosLlamada
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MtlRemove_f(DBConn p_dbcAccess,
                                         string p_strCod,
                                         int p_iFxdVersion,
                                         ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: MotivosLlamada
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMotivosLlamada">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MtlTInt_f(DBConn p_dbcAccess,
                                       EMotivosLlamada p_entMotivosLlamada,
                                       ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá las validaciones adicionales
            // *********
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: Notificados
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entNotificado">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void NotSave_f(DBConn p_dbcAccess,
                                       ref ENotificado p_entNotificado,
                                       ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: Notificados
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void NotEnabled_f(DBConn p_dbcAccess,
                                          bool p_bEnable,
                                          string p_strCod,
                                          ref int p_iFxdVersion,
                                          ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: Notificados
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void NotRemove_f(DBConn p_dbcAccess,
                                         string p_strCod,
                                         int p_iFxdVersion,
                                         ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: Notificado
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entNotificado">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void NotTInt_f(DBConn p_dbcAccess,
                                       ENotificado p_entNotificado,
                                       ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá las validaciones adicionales
            // *********
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: PreciosServicios
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entPrecioServicio">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void PrsSave_f(DBConn p_dbcAccess,
                                       ref EPrecioServicio p_entPrecioServicio,
                                       ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: PreciosServicios
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strColor">Color</param>
        /// <param name="p_dtFecha">Fecha</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void PrsEnabled_f(DBConn p_dbcAccess,
                                          bool p_bEnable,
                                          string p_strColor,
                                          DateTime p_dtFecha,
                                          ref int p_iFxdVersion,
                                          ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: PreciosServicios
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strColor">Color</param>
        /// <param name="p_dtFecha">Fecha</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void PrsRemove_f(DBConn p_dbcAccess,
                                         string p_strColor,
                                         DateTime p_dtFecha,
                                         int p_iFxdVersion,
                                         ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: PrecioServicio
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entPrecioServicio">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void PrsTInt_f(DBConn p_dbcAccess,
                                       EPrecioServicio p_entPrecioServicio,
                                       ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá las validaciones adicionales
            // *********
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: ResEntrevista
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entResEntrevista">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void RenSave_f(DBConn p_dbcAccess,
                                       ref EResEntrevista p_entResEntrevista,
                                       ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: ResEntrevista
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void RenEnabled_f(DBConn p_dbcAccess,
                                          bool p_bEnable,
                                          string p_strCod,
                                          ref int p_iFxdVersion,
                                          ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: ResEntrevista
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void RenRemove_f(DBConn p_dbcAccess,
                                         string p_strCod,
                                         int p_iFxdVersion,
                                         ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: ResEntrevista
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entResEntrevista">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void RenTInt_f(DBConn p_dbcAccess,
                                       EResEntrevista p_entResEntrevista,
                                       ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá las validaciones adicionales
            // *********
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: Rubros
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entRubro">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void RbrSave_f(DBConn p_dbcAccess,
                                       ref ERubro p_entRubro,
                                       ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: Rubros
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void RbrEnabled_f(DBConn p_dbcAccess,
                                          bool p_bEnable,
                                          string p_strCod,
                                          ref int p_iFxdVersion,
                                          ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: Rubros
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void RbrRemove_f(DBConn p_dbcAccess,
                                         string p_strCod,
                                         int p_iFxdVersion,
                                         ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: Rubro
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entRubro">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void RbrTInt_f(DBConn p_dbcAccess,
                                       ERubro p_entRubro,
                                       ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá las validaciones adicionales
            // *********
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: TipoVend
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entTipoVendedor">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TvdSave_f(DBConn p_dbcAccess,
                                       ref ETipoVendedor p_entTipoVendedor,
                                       ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: TipoVend
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TvdEnabled_f(DBConn p_dbcAccess,
                                          bool p_bEnable,
                                          string p_strCod,
                                          ref int p_iFxdVersion,
                                          ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: TipoVend
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TvdRemove_f(DBConn p_dbcAccess,
                                         string p_strCod,
                                         int p_iFxdVersion,
                                         ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: TipoVendedor
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entTipoVendedor">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TvdTInt_f(DBConn p_dbcAccess,
                                       ETipoVendedor p_entTipoVendedor,
                                       ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá las validaciones adicionales
            // *********
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: TipoCont
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entTipoCont">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TcnSave_f(DBConn p_dbcAccess,
                                       ref ETipoCont p_entTipoCont,
                                       ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: TipoCont
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TcnEnabled_f(DBConn p_dbcAccess,
                                          bool p_bEnable,
                                          string p_strCod,
                                          ref int p_iFxdVersion,
                                          ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: TipoCont
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TcnRemove_f(DBConn p_dbcAccess,
                                         string p_strCod,
                                         int p_iFxdVersion,
                                         ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: TipoCont
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entTipoCont">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TcnTInt_f(DBConn p_dbcAccess,
                                       ETipoCont p_entTipoCont,
                                       ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá las validaciones adicionales
            // *********
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: TipoInst
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entTipoInst">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TinSave_f(DBConn p_dbcAccess,
                                       ref ETipoInst p_entTipoInst,
                                       ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: TipoInst
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TinEnabled_f(DBConn p_dbcAccess,
                                          bool p_bEnable,
                                          string p_strCod,
                                          ref int p_iFxdVersion,
                                          ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: TipoInst
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TinRemove_f(DBConn p_dbcAccess,
                                         string p_strCod,
                                         int p_iFxdVersion,
                                         ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: TipoInst
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entTipoInst">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TinTInt_f(DBConn p_dbcAccess,
                                       ETipoInst p_entTipoInst,
                                       ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá las validaciones adicionales
            // *********
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: TipoSol
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entTipoSol">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TslSave_f(DBConn p_dbcAccess,
                                       ref ETipoSol p_entTipoSol,
                                       ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: TipoSol
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">Codigo Solicitud</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TslEnabled_f(DBConn p_dbcAccess,
                                          bool p_bEnable,
                                          string p_strCod,
                                          ref int p_iFxdVersion,
                                          ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: TipoSol
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo Solicitud</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TslRemove_f(DBConn p_dbcAccess,
                                         string p_strCod,
                                         int p_iFxdVersion,
                                         ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: TipoSol
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entTipoSol">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TslTInt_f(DBConn p_dbcAccess,
                                       ETipoSol p_entTipoSol,
                                       ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá las validaciones adicionales
            // *********
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: Zonas
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entZona">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ZnsSave_f(DBConn p_dbcAccess,
                                       ref EZona p_entZona,
                                       ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: Zonas
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ZnsEnabled_f(DBConn p_dbcAccess,
                                          bool p_bEnable,
                                          string p_strCod,
                                          ref int p_iFxdVersion,
                                          ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: Zonas
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ZnsRemove_f(DBConn p_dbcAccess,
                                         string p_strCod,
                                         int p_iFxdVersion,
                                         ref StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: Zona
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entZona">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ZnsTInt_f(DBConn p_dbcAccess,
                                       EZona p_entZona,
                                       ref StatMsg p_smResult)
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
