#region Usings
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Xml;
using TNGS.NetRoutines;
using TNGS.NetAppBll;
using Carm;
using Carm.Bel;
#endregion

namespace Carm.Bll
{
    //----------------------------------------------------------------------------
    //                         TNG Software BLL Generator
    //----------------------------------------------------------------------------
    // Fecha                    : 03/01/2023 23:43
    // Sistema                  : Carm
    // Clase para Administrar   : Vendedores
    //----------------------------------------------------------------------------
    // © 1996-2023 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    //****************************************************************************
    // Atencion!!!
    //    Esta clase fue generada por un programa en forma automática. Cualquier
    //    modificación que se realize sobre ella se perderá en la próxima
    //    regeneración.
    //****************************************************************************

    /// <summary>
    /// Mantenimiento de: Vendedores
    /// </summary>
    public static partial class Vendedores
    {

        //**********************************************************
        //
        // Funciones para la Tabla: Vendedores
        // Usando ClaseDal        : Vendedores
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos públicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: Vendedores
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEVendedores</returns>
        public static LEVendedores UpFull(bool p_bOnlyActive,
                                          StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                return Upfl(l_dbcAccess, p_bOnlyActive, p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion UpFull
                p_smResult.BllError(l_expData);
                return null;
            }
            finally {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null) l_dbcAccess.Close();
            }
        }

        /// <summary>
        /// Devuelve una entidad: EVendedor
        /// </summary>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EVendedor</returns>
        public static EVendedor Get(string p_strCod,
                                    bool p_bOnlyActive,
                                    StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: EVendedor
                return Srch(l_dbcAccess,
                            p_strCod,
                            p_bOnlyActive,
                            p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Get
                p_smResult.BllError(l_expData);
                return null;
            }
            finally {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null) l_dbcAccess.Close();
            }
        }
        #endregion

        #region Metodos publicos de grabacion

        /// <summary>
        /// Agrega o modifica un registro de la tabla: Vendedores
        /// </summary>
        /// <param name="p_entVendedor">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void Save(EVendedor p_entVendedor,
                                StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: EVendedor
                SSav(l_dbcAccess, p_entVendedor, p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Save
                p_smResult.BllError(l_expData);
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacción y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: Vendedores
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void Enabled(bool p_bEnable,
                                   string p_strCod,
                                   int p_iFxdVersion,
                                   StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                Enabled_f(l_dbcAccess,
                          p_bEnable,
                          p_strCod,
                          ref p_iFxdVersion,
                          p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                VKey(l_dbcAccess,
                     p_strCod,
                     p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (Vendedor) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                VVer(l_dbcAccess, 
                     p_strCod,
                     p_iFxdVersion,
                     p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.Vendedores.Recall(l_dbcAccess,
                                          p_strCod,
                                          p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.Vendedores.Delete(l_dbcAccess,
                                          p_strCod,
                                          p_smResult);
                }
            }
            catch (Exception l_expData) {
                // Error en la operacion Enabled
                p_smResult.BllError(l_expData);
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacción y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }
        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: Vendedores
        /// </summary>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void Remove(string p_strCod,
                                  int p_iFxdVersion,
                                  StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                Remove_f(l_dbcAccess,
                         p_strCod,
                         p_iFxdVersion,
                         p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                Drop(l_dbcAccess,
                     p_strCod,
                     p_iFxdVersion,
                     p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Remove
                p_smResult.BllError(l_expData);
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacción y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }
        }

        /// <summary>
        /// Compacta una tabla borrando los registros deshabilitados
        /// </summary>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void Purge(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Realizamos el borrado
                Pack(l_dbcAccess,
                     p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Enabled
                p_smResult.BllError(l_expData);
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacción y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }
        }
        #endregion

        #region Metodos para métodos DAL definidos por el usuario

        /// <summary>
        /// Ejecuta el SP definido por el usuario: GetCodVend
        /// </summary>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        public static ListaEntidades GetCodVend(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Abrimos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Llamamos al metodo interno
                return GetCodVend(l_dbcAccess,
                                  p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion
                p_smResult.BllError(l_expData);
                return null;
            }
            finally {
                // Si abrimos una conexion -> la cerramos
                if (l_dbcAccess != null) l_dbcAccess.Close();
            }
        }

        /// <summary>
        /// Ejecuta el SP definido por el usuario: GetEntrevistas
        /// </summary>
        /// <param name= p_strCodvend>Código de vendedor</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        public static ListaEntidades GetEntrevistas(string p_strCodvend,
                                                    StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Abrimos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Llamamos al metodo interno
                return GetEntrevistas(l_dbcAccess,
                                      p_strCodvend,
                                      p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion
                p_smResult.BllError(l_expData);
                return null;
            }
            finally {
                // Si abrimos una conexion -> la cerramos
                if (l_dbcAccess != null) l_dbcAccess.Close();
            }
        }

        /// <summary>
        /// Ejecuta el SP definido por el usuario: GetEntrevistasHist
        /// </summary>
        /// <param name= p_strCodvend>Código de vendedor</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        public static ListaEntidades GetEntrevistasHist(string p_strCodvend,
                                                        StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Abrimos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Llamamos al metodo interno
                return GetEntrevistasHist(l_dbcAccess,
                                          p_strCodvend,
                                          p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion
                p_smResult.BllError(l_expData);
                return null;
            }
            finally {
                // Si abrimos una conexion -> la cerramos
                if (l_dbcAccess != null) l_dbcAccess.Close();
            }
        }

        /// <summary>
        /// Ejecuta el SP definido por el usuario: GetLlamadas
        /// </summary>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        public static ListaEntidades GetLlamadas(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Abrimos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Llamamos al metodo interno
                return GetLlamadas(l_dbcAccess,
                                   p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion
                p_smResult.BllError(l_expData);
                return null;
            }
            finally {
                // Si abrimos una conexion -> la cerramos
                if (l_dbcAccess != null) l_dbcAccess.Close();
            }
        }

        /// <summary>
        /// Ejecuta el SP definido por el usuario: GetSolicitudes
        /// </summary>
        /// <param name= p_strCodvend>Código de vendedor</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        public static ListaEntidades GetSolicitudes(string p_strCodvend,
                                                    StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Abrimos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Llamamos al metodo interno
                return GetSolicitudes(l_dbcAccess,
                                      p_strCodvend,
                                      p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion
                p_smResult.BllError(l_expData);
                return null;
            }
            finally {
                // Si abrimos una conexion -> la cerramos
                if (l_dbcAccess != null) l_dbcAccess.Close();
            }
        }

        /// <summary>
        /// Ejecuta el SP definido por el usuario: GetVendedorFromUsu
        /// </summary>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        public static LEVendedores GetVendedorFromUsu(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Abrimos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Llamamos al metodo interno
                return GetVendedorFromUsu(l_dbcAccess,
                                          p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion
                p_smResult.BllError(l_expData);
                return null;
            }
            finally {
                // Si abrimos una conexion -> la cerramos
                if (l_dbcAccess != null) l_dbcAccess.Close();
            }
        }

        /// <summary>
        /// Ejecuta el SP definido por el usuario: ZEntrevistasBasico
        /// </summary>
        /// <param name= p_dtFechaini>Fecha Inicio de busqueda</param>
        /// <param name= p_dtFechafin>Fecha Fin de busqueda</param>
        /// <param name= p_strCodinivendedor>Codigo inicial Vendedor</param>
        /// <param name= p_strCodfinvendedor>Codigo Fin Vendedor</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        public static ListaEntidades ZEntrevistasBasico(DateTime p_dtFechaini,
                                                        DateTime p_dtFechafin,
                                                        string p_strCodinivendedor,
                                                        string p_strCodfinvendedor,
                                                        StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Abrimos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Llamamos al metodo interno
                return ZEntrevistasBasico(l_dbcAccess,
                                          p_dtFechaini,
                                          p_dtFechafin,
                                          p_strCodinivendedor,
                                          p_strCodfinvendedor,
                                          p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion
                p_smResult.BllError(l_expData);
                return null;
            }
            finally {
                // Si abrimos una conexion -> la cerramos
                if (l_dbcAccess != null) l_dbcAccess.Close();
            }
        }

        /// <summary>
        /// Ejecuta el SP definido por el usuario: ZLlamadasProgramadas
        /// </summary>
        /// <param name= p_strUsuarioprogramador>Usuario que programo la llamada</param>
        /// <param name= p_dtFechaini>Fecha inicial</param>
        /// <param name= p_dtFechafin>Fecha fin</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        public static ListaEntidades ZLlamadasProgramadas(string p_strUsuarioprogramador,
                                                          DateTime p_dtFechaini,
                                                          DateTime p_dtFechafin,
                                                          StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Abrimos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Llamamos al metodo interno
                return ZLlamadasProgramadas(l_dbcAccess,
                                            p_strUsuarioprogramador,
                                            p_dtFechaini,
                                            p_dtFechafin,
                                            p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion
                p_smResult.BllError(l_expData);
                return null;
            }
            finally {
                // Si abrimos una conexion -> la cerramos
                if (l_dbcAccess != null) l_dbcAccess.Close();
            }
        }

        /// <summary>
        /// Ejecuta el SP definido por el usuario: ZLlamados
        /// </summary>
        /// <param name= p_dtFechaini>Fecha de Inicio Busqueda</param>
        /// <param name= p_dtFechafin>Fecha de Fin Busqueda</param>
        /// <param name= p_strTipo>Tipo de Llamadas (E/S)</param>
        /// <param name= p_strCodcatini>Codigo Categoria Ini</param>
        /// <param name= p_strCodcatfin>Codigo Categoria Fin</param>
        /// <param name= p_strCodinivendedor>Codigo inicial Vendedor</param>
        /// <param name= p_strCodfinvendedor>Codigo Vendedor Fin</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        public static ListaEntidades ZLlamados(DateTime p_dtFechaini,
                                               DateTime p_dtFechafin,
                                               string p_strTipo,
                                               string p_strCodcatini,
                                               string p_strCodcatfin,
                                               string p_strCodinivendedor,
                                               string p_strCodfinvendedor,
                                               StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Abrimos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Llamamos al metodo interno
                return ZLlamados(l_dbcAccess,
                                 p_dtFechaini,
                                 p_dtFechafin,
                                 p_strTipo,
                                 p_strCodcatini,
                                 p_strCodcatfin,
                                 p_strCodinivendedor,
                                 p_strCodfinvendedor,
                                 p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion
                p_smResult.BllError(l_expData);
                return null;
            }
            finally {
                // Si abrimos una conexion -> la cerramos
                if (l_dbcAccess != null) l_dbcAccess.Close();
            }
        }

        /// <summary>
        /// Ejecuta el SP definido por el usuario: ZReservasBasico
        /// </summary>
        /// <param name= p_strCodvendini>Codigo Inicial de Vendedor</param>
        /// <param name= p_strCodvendfin>Codigo Final de Vendedor</param>
        /// <param name= p_dtFechaini>Fecha Inicial de Reservas</param>
        /// <param name= p_dtFechafin>Fecha Final de Reservas</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        public static ListaEntidades ZReservasBasico(string p_strCodvendini,
                                                     string p_strCodvendfin,
                                                     DateTime p_dtFechaini,
                                                     DateTime p_dtFechafin,
                                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Abrimos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Llamamos al metodo interno
                return ZReservasBasico(l_dbcAccess,
                                       p_strCodvendini,
                                       p_strCodvendfin,
                                       p_dtFechaini,
                                       p_dtFechafin,
                                       p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion
                p_smResult.BllError(l_expData);
                return null;
            }
            finally {
                // Si abrimos una conexion -> la cerramos
                if (l_dbcAccess != null) l_dbcAccess.Close();
            }
        }

        /// <summary>
        /// Ejecuta el SP definido por el usuario: ZVencidas
        /// </summary>
        /// <param name= p_strCodvendini>Codigo Vendedor Inicial</param>
        /// <param name= p_strCodvendfin>Codigo Vendedor Fin</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        public static ListaEntidades ZVencidas(string p_strCodvendini,
                                               string p_strCodvendfin,
                                               StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Abrimos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Llamamos al metodo interno
                return ZVencidas(l_dbcAccess,
                                 p_strCodvendini,
                                 p_strCodvendfin,
                                 p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion
                p_smResult.BllError(l_expData);
                return null;
            }
            finally {
                // Si abrimos una conexion -> la cerramos
                if (l_dbcAccess != null) l_dbcAccess.Close();
            }
        }

        /// <summary>
        /// Ejecuta el SP definido por el usuario: ZVentas
        /// </summary>
        /// <param name= p_dtFechaini>Fecha Inicial de la busqueda</param>
        /// <param name= p_dtFechafin>Fecha Fianl de la busqueda</param>
        /// <param name= p_strCodvendini>Codigo Inicial de Vendedor</param>
        /// <param name= p_strCodvendfin>Codigo Final de Vendedor</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        public static ListaEntidades ZVentas(DateTime p_dtFechaini,
                                             DateTime p_dtFechafin,
                                             string p_strCodvendini,
                                             string p_strCodvendfin,
                                             StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Abrimos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Llamamos al metodo interno
                return ZVentas(l_dbcAccess,
                               p_dtFechaini,
                               p_dtFechafin,
                               p_strCodvendini,
                               p_strCodvendfin,
                               p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion
                p_smResult.BllError(l_expData);
                return null;
            }
            finally {
                // Si abrimos una conexion -> la cerramos
                if (l_dbcAccess != null) l_dbcAccess.Close();
            }
        }

        /// <summary>
        /// Ejecuta el SP definido por el usuario: ZVentasDetalle
        /// </summary>
        /// <param name= p_dtFechaini>Fecha Inicial de la busqueda</param>
        /// <param name= p_dtFechafin>Fecha Fianl de la busqueda</param>
        /// <param name= p_strCodvendini>Codigo Inicial de Vendedor</param>
        /// <param name= p_strCodvendfin>Codigo Final de Vendedor</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        public static ListaEntidades ZVentasDetalle(DateTime p_dtFechaini,
                                                    DateTime p_dtFechafin,
                                                    string p_strCodvendini,
                                                    string p_strCodvendfin,
                                                    StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Abrimos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Llamamos al metodo interno
                return ZVentasDetalle(l_dbcAccess,
                                      p_dtFechaini,
                                      p_dtFechafin,
                                      p_strCodvendini,
                                      p_strCodvendfin,
                                      p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion
                p_smResult.BllError(l_expData);
                return null;
            }
            finally {
                // Si abrimos una conexion -> la cerramos
                if (l_dbcAccess != null) l_dbcAccess.Close();
            }
        }
        #endregion

        //---------------------------------------------------------------
        // Metodos públicos de la clase (no visibles para la UIL)
        //---------------------------------------------------------------

        #region Metodos internos de validacion

        /// <summary>
        /// Valida la integridad de una entidad: Vendedor
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entVendedor">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TInt(DBConn p_dbcAccess,
                                  EVendedor p_entVendedor,
                                  StatMsg p_smResult)
        {
            // ********
            // Validaciones de los campos sin conexion
            // ********

            if (p_entVendedor.Cod.Trim() == "") {
                // El campo [Código] no puede ser vacío
                p_smResult.BllWarning("El dato [Código] no puede ser vacío","");
                return;
            }

            if (p_entVendedor.Apellido.Trim() == "") {
                // El campo [Apellido] no puede ser vacío
                p_smResult.BllWarning("El dato [Apellido] no puede ser vacío","");
                return;
            }

            if (p_entVendedor.Nombre.Trim() == "") {
                // El campo [Nombre] no puede ser vacío
                p_smResult.BllWarning("El dato [Nombre] no puede ser vacío","");
                return;
            }

            if (p_entVendedor.Usuario.Trim() == "") {
                // El campo [Usuario Sistema] no puede ser vacío
                p_smResult.BllWarning("El dato [Usuario Sistema] no puede ser vacío","");
                return;
            }

            if (p_entVendedor.Fecnacim.Year == 1900) {
                // El campo [Fecha Nacimiento] no puede ser vacío
                p_smResult.BllWarning("El dato [Fecha Nacimiento] no puede ser vacío","");
                return;
            }

            // ********
            // Validaciones de los campos con conexion
            // ********

            Supervisores.VKey(p_dbcAccess,
                              p_entVendedor.Codsuperv,
                              p_smResult);
            if (p_smResult.NOk) return;

            if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                // El campo [Supervisor] debe existir en la tabla [Supervisores.]
                p_smResult.BllWarning("El dato [Supervisor] debe existir en la tabla [Supervisores.]","");
                return;
            }

            Tablas.TvdVKey(p_dbcAccess,
                           p_entVendedor.Codtvend,
                           p_smResult);
            if (p_smResult.NOk) return;

            if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                // El campo [Tipo Vendedor] debe existir en la tabla [Tablas.Tvd]
                p_smResult.BllWarning("El dato [Tipo Vendedor] debe existir en la tabla [Tablas.Tvd] y estar habilitado","");
                return;
            }

            // Todas las validaciones fueron correctas

            // Llamamos a la funcion fija del usuario
            TInt_f(p_dbcAccess, p_entVendedor, p_smResult);
            if (p_smResult.NOk) return;
        }

        /// <summary>
        /// Verifica el número de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_iFxdVersion">Número de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void VVer(DBConn p_dbcAccess,
                                  string p_strCod,
                                  int p_iFxdVersion,
                                  StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            // Verificamos el número de versión
            Dal.Vendedores.ChkVersion(p_dbcAccess,
                                      p_strCod,
                                      p_iFxdVersion,
                                      ref l_dsTemp,
                                      "Temporal",
                                      p_smResult);
            if (p_smResult.NOk) return;

            // Verificamos el resultado que vino
            if (l_dsTemp.Tables["Temporal"].Rows.Count != 0) {
                // Verificamos si la cantidad es 1
                if ((int) l_dsTemp.Tables["Temporal"].Rows[0]["cantidad"] == 1) {
                    // La versión coincide
                    l_dsTemp.Dispose();
                    return;
                }
            }

            // El número de versión no coincide
            StreamWriter l_swErrorFile= null;
            string l_strErrFName= String.Format("C:\\V{0:ddMMyyyyHHmmss}.Err",
                                                DateTime.Now);
            try {
                // Creamos el archivo del error
                l_swErrorFile= new StreamWriter(File.Create(l_strErrFName),
                                                System.Text.Encoding.ASCII);

                // Grabamos los datos del error
                l_swErrorFile.WriteLine("Instante    : {0:dd/MM/yyyy HH:mm:ss}", DateTime.Now);
                l_swErrorFile.WriteLine("Metodo      : {0}", p_smResult.Method);
                l_swErrorFile.WriteLine("Message     : No coincide el numero de version");
            }
            catch (Exception l_expData) {
                // Error en el acceso al archivo.
                string l_strLinea= l_expData.Message;
            }
            finally {
                // Si llegamos a abrir el archivo -> lo cerramos
                if (l_swErrorFile != null) {
                    l_swErrorFile.Close();
                    l_swErrorFile.Dispose();
                }
            }

            // El número de versión no coincide
            l_dsTemp.Dispose();
            p_smResult.BllWarning("El número de versión del registro del ítem (Vendedor) no coincide.\r\nOperación cancelada.","");
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: EVendedor
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave está deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void VKey(DBConn p_dbcAccess,
                                  string p_strCod,
                                  StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            Dal.Vendedores.Search(p_dbcAccess,
                                  p_strCod,
                                  false,
                                  ref l_dsTemp,
                                  "Temporal",
                                  p_smResult);
            if (p_smResult.NOk) return;

            try {
                // Verificamos si vino algun registro
                p_smResult.BllICode(BllCodes.KeyDsntFound);
                if (l_dsTemp.Tables["Temporal"].Rows.Count == 0) return;

                // Verificamos si el registro que vino esta habilitado
                p_smResult.BllICode(BllCodes.KeyDisabled);
                if ((decimal) l_dsTemp.Tables["Temporal"].Rows[0]["deleted"] == 1) return;

                // La clave existia y estaba habilitada
                p_smResult.BllICode(BllCodes.KeyExists);
            }
            finally {
                // Terminamos
                l_dsTemp.Dispose();
            }
        }
        #endregion

        #region Metodos internos de recupero

        /// <summary>
        /// Devuelve una Lista-entidad: LEVendedores
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEVendedores</returns>
        internal static LEVendedores Upfl(DBConn p_dbcAccess,
                                              bool p_bOnlyActive,
                                              StatMsg p_smResult)
        {
            try {
                // Pedimos los registros de la tabla: Vendedores
                DataSet l_dsTemp= new DataSet();

                Dal.Vendedores.Up(p_dbcAccess, 
                                  p_bOnlyActive,
                                  ref l_dsTemp, "Temporal",
                                  p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.Vendedores.MakeGridCaptions(ref l_dsTemp, "Temporal", p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LEVendedores l_lentRet= new LEVendedores(l_dsTemp.Tables["Temporal"]);
                l_dsTemp.Dispose();
                return l_lentRet;
            }
            catch (Exception l_expData) {
                // Error en la operacion Upfl
                p_smResult.BllError(l_expData);
                return null;
            }
        }

        /// <summary>
        /// Devuelve una entidad: EVendedor
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EVendedor</returns>
        internal static EVendedor Srch(DBConn p_dbcAccess,
                                       string p_strCod,
                                       bool p_bOnlyActive,
                                       StatMsg p_smResult)
        {
            try {
                // Pedimos el registro de la tabla: Vendedores
                DataSet l_dsTemp= new DataSet();

                Dal.Vendedores.Search(p_dbcAccess, 
                                      p_strCod,
                                      p_bOnlyActive,
                                      ref l_dsTemp, "Temporal",
                                      p_smResult);
                if (p_smResult.NOk) return null;

                // Constuimos la entidad y la devolvemos (si vino un registro)
                EVendedor l_entRet= null;

                if (l_dsTemp.Tables["Temporal"].Rows.Count == 1)
                    l_entRet= new EVendedor(l_dsTemp.Tables["Temporal"].Rows[0]);

                l_dsTemp.Dispose();
                return l_entRet;
            }
            catch (Exception l_expData) {
                // Error en la operacion Srch
                p_smResult.BllError(l_expData);
                return null;
            }
        }
        #endregion

        #region Metodos internos de modificacion

        /// <summary>
        /// Agrega o modifica un registro de la tabla: Vendedores
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entVendedor">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void SSav(DBConn p_dbcAccess,
                                  EVendedor p_entVendedor,
                                  StatMsg p_smResult)
        {
            try {
                // Procesamos codigo fijo
                Save_f(p_dbcAccess, ref p_entVendedor, p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                VKey(p_dbcAccess, 
                     p_entVendedor.Cod,
                     p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entVendedor.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El ítem (Vendedor) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    Insr(p_dbcAccess, p_entVendedor, p_smResult);
                    return;
                }

                // Es un update. La clave debe existir y estar habilitada
                if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                    // Error. La clave no existe o no está habilitada
                    p_smResult.BllWarning("El ítem (Vendedor) que intenta modificar no existe en el sistema o no está habilitado.","");
                    return;
                }

                // Debe coincidir el número de version
                VVer(p_dbcAccess, 
                     p_entVendedor.Cod,
                     p_entVendedor.FxdVersion,
                     p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos el registro
                Updt(p_dbcAccess, p_entVendedor, p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Agrega un registro a la tabla a partir de una entidad: EVendedor
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entVendedor">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void Insr(DBConn p_dbcAccess,
                                  EVendedor p_entVendedor,
                                  StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                TInt(p_dbcAccess, p_entVendedor, p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: Vendedores
                Dal.Vendedores.Insert(p_dbcAccess,
                                      p_entVendedor.Cod,
                                      p_entVendedor.Apellido,
                                      p_entVendedor.Nombre,
                                      p_entVendedor.Usuario,
                                      p_entVendedor.Tel1,
                                      p_entVendedor.Celular,
                                      p_entVendedor.Tel2,
                                      p_entVendedor.Fecnacim,
                                      p_entVendedor.Direccion,
                                      p_entVendedor.Codsuperv,
                                      p_entVendedor.Codtvend,
                                      p_entVendedor.Horarios,
                                      p_entVendedor.Historico,
                                      p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Actualiza un registro a la tabla a partir de una entidad: EVendedor
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entVendedor">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void Updt(DBConn p_dbcAccess,
                                  EVendedor p_entVendedor,
                                  StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                TInt(p_dbcAccess, p_entVendedor, p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: Vendedores
                Dal.Vendedores.Update(p_dbcAccess,
                                      p_entVendedor.Cod,
                                      p_entVendedor.Apellido,
                                      p_entVendedor.Nombre,
                                      p_entVendedor.Usuario,
                                      p_entVendedor.Tel1,
                                      p_entVendedor.Celular,
                                      p_entVendedor.Tel2,
                                      p_entVendedor.Fecnacim,
                                      p_entVendedor.Direccion,
                                      p_entVendedor.Codsuperv,
                                      p_entVendedor.Codtvend,
                                      p_entVendedor.Horarios,
                                      p_entVendedor.Historico,
                                      p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra físicamente un registro de a tabla: Vendedores
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void Drop(DBConn p_dbcAccess,
                                  string p_strCod,
                                  int p_iFxdVersion,
                                  StatMsg p_smResult)
        {
            try {
                // Verificamos la clave a borrar
                VKey(p_dbcAccess,
                     p_strCod,
                     p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (Vendedor) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                VVer(p_dbcAccess, 
                     p_strCod,
                     p_iFxdVersion,
                     p_smResult);
                if (p_smResult.NOk) return;

                // Borramos físicamente el registro
                Dal.Vendedores.Drop(p_dbcAccess,
                                    p_strCod,
                                    p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Remove
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra los registros borrados lógicamente de la tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void Pack(DBConn p_dbcAccess,
                                  StatMsg p_smResult)
        {
            try {
                // Borramos los borrados lógicamente
                Dal.Vendedores.Pack(p_dbcAccess,
                                    p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }
        #endregion

        #region Metodos para métodos DAL definidos por el usuario

        /// <summary>
        /// Ejecuta el SP definido por el usuario: GetCodVend
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades GetCodVend(DBConn p_dbcAccess,
                                                  StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.Vendedores.GetCodVend(p_dbcAccess,
                                          ref l_dsTemp,
                                          "Temporal",
                                          p_smResult);
                if (p_smResult.NOk) return null;

                // Creamos la LE y Captionamos
                ListaEntidades l_lentRet= new ListaEntidades(l_dsTemp.Tables["Temporal"]);
                BllRuts.FillStdCaptions(ref l_lentRet);

                // Devolvemos la LE
                l_dsTemp.Dispose();
                return l_lentRet;
            }
            catch (Exception l_expData) {
                // Error en la operacion
                p_smResult.BllError(l_expData);
                return null;
            }
            finally {
                // Terminamos
            }
        }

        /// <summary>
        /// Ejecuta el SP definido por el usuario: GetEntrevistas
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_strCodvend>Código de vendedor</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades GetEntrevistas(DBConn p_dbcAccess,
                                                      string p_strCodvend,
                                                      StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.Vendedores.GetEntrevistas(p_dbcAccess,
                                              p_strCodvend,
                                              ref l_dsTemp,
                                              "Temporal",
                                              p_smResult);
                if (p_smResult.NOk) return null;

                // Creamos la LE y Captionamos
                ListaEntidades l_lentRet= new ListaEntidades(l_dsTemp.Tables["Temporal"]);
                BllRuts.FillStdCaptions(ref l_lentRet);

                // Devolvemos la LE
                l_dsTemp.Dispose();
                return l_lentRet;
            }
            catch (Exception l_expData) {
                // Error en la operacion
                p_smResult.BllError(l_expData);
                return null;
            }
            finally {
                // Terminamos
            }
        }

        /// <summary>
        /// Ejecuta el SP definido por el usuario: GetEntrevistasHist
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_strCodvend>Código de vendedor</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades GetEntrevistasHist(DBConn p_dbcAccess,
                                                          string p_strCodvend,
                                                          StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.Vendedores.GetEntrevistasHist(p_dbcAccess,
                                                  p_strCodvend,
                                                  ref l_dsTemp,
                                                  "Temporal",
                                                  p_smResult);
                if (p_smResult.NOk) return null;

                // Creamos la LE y Captionamos
                ListaEntidades l_lentRet= new ListaEntidades(l_dsTemp.Tables["Temporal"]);
                BllRuts.FillStdCaptions(ref l_lentRet);

                // Devolvemos la LE
                l_dsTemp.Dispose();
                return l_lentRet;
            }
            catch (Exception l_expData) {
                // Error en la operacion
                p_smResult.BllError(l_expData);
                return null;
            }
            finally {
                // Terminamos
            }
        }

        /// <summary>
        /// Ejecuta el SP definido por el usuario: GetLlamadas
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades GetLlamadas(DBConn p_dbcAccess,
                                                   StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.Vendedores.GetLlamadas(p_dbcAccess,
                                           ref l_dsTemp,
                                           "Temporal",
                                           p_smResult);
                if (p_smResult.NOk) return null;

                // Creamos la LE y Captionamos
                ListaEntidades l_lentRet= new ListaEntidades(l_dsTemp.Tables["Temporal"]);
                BllRuts.FillStdCaptions(ref l_lentRet);

                // Devolvemos la LE
                l_dsTemp.Dispose();
                return l_lentRet;
            }
            catch (Exception l_expData) {
                // Error en la operacion
                p_smResult.BllError(l_expData);
                return null;
            }
            finally {
                // Terminamos
            }
        }

        /// <summary>
        /// Ejecuta el SP definido por el usuario: GetSolicitudes
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_strCodvend>Código de vendedor</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades GetSolicitudes(DBConn p_dbcAccess,
                                                      string p_strCodvend,
                                                      StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.Vendedores.GetSolicitudes(p_dbcAccess,
                                              p_strCodvend,
                                              ref l_dsTemp,
                                              "Temporal",
                                              p_smResult);
                if (p_smResult.NOk) return null;

                // Creamos la LE y Captionamos
                ListaEntidades l_lentRet= new ListaEntidades(l_dsTemp.Tables["Temporal"]);
                BllRuts.FillStdCaptions(ref l_lentRet);

                // Devolvemos la LE
                l_dsTemp.Dispose();
                return l_lentRet;
            }
            catch (Exception l_expData) {
                // Error en la operacion
                p_smResult.BllError(l_expData);
                return null;
            }
            finally {
                // Terminamos
            }
        }

        /// <summary>
        /// Ejecuta el SP definido por el usuario: GetVendedorFromUsu
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static LEVendedores GetVendedorFromUsu(DBConn p_dbcAccess,
                                                        StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.Vendedores.GetVendedorFromUsu(p_dbcAccess,
                                                  ref l_dsTemp,
                                                  "Temporal",
                                                  p_smResult);
                if (p_smResult.NOk) return null;

                // Captionamos el resultado
                Dal.Vendedores.MakeGridCaptions(ref l_dsTemp, "Temporal", p_smResult);
                if (p_smResult.NOk) return null;

                // Creamos la ListaEntidad y la devolvemos
                LEVendedores l_lentRet= new LEVendedores(l_dsTemp.Tables["Temporal"]);
                l_dsTemp.Dispose();
                return l_lentRet;
            }
            catch (Exception l_expData) {
                // Error en la operacion
                p_smResult.BllError(l_expData);
                return null;
            }
            finally {
                // Terminamos
            }
        }

        /// <summary>
        /// Ejecuta el SP definido por el usuario: ZEntrevistasBasico
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_dtFechaini>Fecha Inicio de busqueda</param>
        /// <param name= p_dtFechafin>Fecha Fin de busqueda</param>
        /// <param name= p_strCodinivendedor>Codigo inicial Vendedor</param>
        /// <param name= p_strCodfinvendedor>Codigo Fin Vendedor</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades ZEntrevistasBasico(DBConn p_dbcAccess,
                                                          DateTime p_dtFechaini,
                                                          DateTime p_dtFechafin,
                                                          string p_strCodinivendedor,
                                                          string p_strCodfinvendedor,
                                                          StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.Vendedores.ZEntrevistasBasico(p_dbcAccess,
                                                  p_dtFechaini,
                                                  p_dtFechafin,
                                                  p_strCodinivendedor,
                                                  p_strCodfinvendedor,
                                                  ref l_dsTemp,
                                                  "Temporal",
                                                  p_smResult);
                if (p_smResult.NOk) return null;

                // Creamos la LE y Captionamos
                ListaEntidades l_lentRet= new ListaEntidades(l_dsTemp.Tables["Temporal"]);
                BllRuts.FillStdCaptions(ref l_lentRet);

                // Devolvemos la LE
                l_dsTemp.Dispose();
                return l_lentRet;
            }
            catch (Exception l_expData) {
                // Error en la operacion
                p_smResult.BllError(l_expData);
                return null;
            }
            finally {
                // Terminamos
            }
        }

        /// <summary>
        /// Ejecuta el SP definido por el usuario: ZLlamadasProgramadas
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_strUsuarioprogramador>Usuario que programo la llamada</param>
        /// <param name= p_dtFechaini>Fecha inicial</param>
        /// <param name= p_dtFechafin>Fecha fin</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades ZLlamadasProgramadas(DBConn p_dbcAccess,
                                                            string p_strUsuarioprogramador,
                                                            DateTime p_dtFechaini,
                                                            DateTime p_dtFechafin,
                                                            StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.Vendedores.ZLlamadasProgramadas(p_dbcAccess,
                                                    p_strUsuarioprogramador,
                                                    p_dtFechaini,
                                                    p_dtFechafin,
                                                    ref l_dsTemp,
                                                    "Temporal",
                                                    p_smResult);
                if (p_smResult.NOk) return null;

                // Creamos la LE y Captionamos
                ListaEntidades l_lentRet= new ListaEntidades(l_dsTemp.Tables["Temporal"]);
                BllRuts.FillStdCaptions(ref l_lentRet);

                // Devolvemos la LE
                l_dsTemp.Dispose();
                return l_lentRet;
            }
            catch (Exception l_expData) {
                // Error en la operacion
                p_smResult.BllError(l_expData);
                return null;
            }
            finally {
                // Terminamos
            }
        }

        /// <summary>
        /// Ejecuta el SP definido por el usuario: ZLlamados
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_dtFechaini>Fecha de Inicio Busqueda</param>
        /// <param name= p_dtFechafin>Fecha de Fin Busqueda</param>
        /// <param name= p_strTipo>Tipo de Llamadas (E/S)</param>
        /// <param name= p_strCodcatini>Codigo Categoria Ini</param>
        /// <param name= p_strCodcatfin>Codigo Categoria Fin</param>
        /// <param name= p_strCodinivendedor>Codigo inicial Vendedor</param>
        /// <param name= p_strCodfinvendedor>Codigo Vendedor Fin</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades ZLlamados(DBConn p_dbcAccess,
                                                 DateTime p_dtFechaini,
                                                 DateTime p_dtFechafin,
                                                 string p_strTipo,
                                                 string p_strCodcatini,
                                                 string p_strCodcatfin,
                                                 string p_strCodinivendedor,
                                                 string p_strCodfinvendedor,
                                                 StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.Vendedores.ZLlamados(p_dbcAccess,
                                         p_dtFechaini,
                                         p_dtFechafin,
                                         p_strTipo,
                                         p_strCodcatini,
                                         p_strCodcatfin,
                                         p_strCodinivendedor,
                                         p_strCodfinvendedor,
                                         ref l_dsTemp,
                                         "Temporal",
                                         p_smResult);
                if (p_smResult.NOk) return null;

                // Creamos la LE y Captionamos
                ListaEntidades l_lentRet= new ListaEntidades(l_dsTemp.Tables["Temporal"]);
                BllRuts.FillStdCaptions(ref l_lentRet);

                // Devolvemos la LE
                l_dsTemp.Dispose();
                return l_lentRet;
            }
            catch (Exception l_expData) {
                // Error en la operacion
                p_smResult.BllError(l_expData);
                return null;
            }
            finally {
                // Terminamos
            }
        }

        /// <summary>
        /// Ejecuta el SP definido por el usuario: ZReservasBasico
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_strCodvendini>Codigo Inicial de Vendedor</param>
        /// <param name= p_strCodvendfin>Codigo Final de Vendedor</param>
        /// <param name= p_dtFechaini>Fecha Inicial de Reservas</param>
        /// <param name= p_dtFechafin>Fecha Final de Reservas</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades ZReservasBasico(DBConn p_dbcAccess,
                                                       string p_strCodvendini,
                                                       string p_strCodvendfin,
                                                       DateTime p_dtFechaini,
                                                       DateTime p_dtFechafin,
                                                       StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.Vendedores.ZReservasBasico(p_dbcAccess,
                                               p_strCodvendini,
                                               p_strCodvendfin,
                                               p_dtFechaini,
                                               p_dtFechafin,
                                               ref l_dsTemp,
                                               "Temporal",
                                               p_smResult);
                if (p_smResult.NOk) return null;

                // Creamos la LE y Captionamos
                ListaEntidades l_lentRet= new ListaEntidades(l_dsTemp.Tables["Temporal"]);
                BllRuts.FillStdCaptions(ref l_lentRet);

                // Devolvemos la LE
                l_dsTemp.Dispose();
                return l_lentRet;
            }
            catch (Exception l_expData) {
                // Error en la operacion
                p_smResult.BllError(l_expData);
                return null;
            }
            finally {
                // Terminamos
            }
        }

        /// <summary>
        /// Ejecuta el SP definido por el usuario: ZVencidas
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_strCodvendini>Codigo Vendedor Inicial</param>
        /// <param name= p_strCodvendfin>Codigo Vendedor Fin</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades ZVencidas(DBConn p_dbcAccess,
                                                 string p_strCodvendini,
                                                 string p_strCodvendfin,
                                                 StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.Vendedores.ZVencidas(p_dbcAccess,
                                         p_strCodvendini,
                                         p_strCodvendfin,
                                         ref l_dsTemp,
                                         "Temporal",
                                         p_smResult);
                if (p_smResult.NOk) return null;

                // Creamos la LE y Captionamos
                ListaEntidades l_lentRet= new ListaEntidades(l_dsTemp.Tables["Temporal"]);
                BllRuts.FillStdCaptions(ref l_lentRet);

                // Devolvemos la LE
                l_dsTemp.Dispose();
                return l_lentRet;
            }
            catch (Exception l_expData) {
                // Error en la operacion
                p_smResult.BllError(l_expData);
                return null;
            }
            finally {
                // Terminamos
            }
        }

        /// <summary>
        /// Ejecuta el SP definido por el usuario: ZVentas
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_dtFechaini>Fecha Inicial de la busqueda</param>
        /// <param name= p_dtFechafin>Fecha Fianl de la busqueda</param>
        /// <param name= p_strCodvendini>Codigo Inicial de Vendedor</param>
        /// <param name= p_strCodvendfin>Codigo Final de Vendedor</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades ZVentas(DBConn p_dbcAccess,
                                               DateTime p_dtFechaini,
                                               DateTime p_dtFechafin,
                                               string p_strCodvendini,
                                               string p_strCodvendfin,
                                               StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.Vendedores.ZVentas(p_dbcAccess,
                                       p_dtFechaini,
                                       p_dtFechafin,
                                       p_strCodvendini,
                                       p_strCodvendfin,
                                       ref l_dsTemp,
                                       "Temporal",
                                       p_smResult);
                if (p_smResult.NOk) return null;

                // Creamos la LE y Captionamos
                ListaEntidades l_lentRet= new ListaEntidades(l_dsTemp.Tables["Temporal"]);
                BllRuts.FillStdCaptions(ref l_lentRet);

                // Devolvemos la LE
                l_dsTemp.Dispose();
                return l_lentRet;
            }
            catch (Exception l_expData) {
                // Error en la operacion
                p_smResult.BllError(l_expData);
                return null;
            }
            finally {
                // Terminamos
            }
        }

        /// <summary>
        /// Ejecuta el SP definido por el usuario: ZVentasDetalle
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_dtFechaini>Fecha Inicial de la busqueda</param>
        /// <param name= p_dtFechafin>Fecha Fianl de la busqueda</param>
        /// <param name= p_strCodvendini>Codigo Inicial de Vendedor</param>
        /// <param name= p_strCodvendfin>Codigo Final de Vendedor</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades ZVentasDetalle(DBConn p_dbcAccess,
                                                      DateTime p_dtFechaini,
                                                      DateTime p_dtFechafin,
                                                      string p_strCodvendini,
                                                      string p_strCodvendfin,
                                                      StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.Vendedores.ZVentasDetalle(p_dbcAccess,
                                              p_dtFechaini,
                                              p_dtFechafin,
                                              p_strCodvendini,
                                              p_strCodvendfin,
                                              ref l_dsTemp,
                                              "Temporal",
                                              p_smResult);
                if (p_smResult.NOk) return null;

                // Creamos la LE y Captionamos
                ListaEntidades l_lentRet= new ListaEntidades(l_dsTemp.Tables["Temporal"]);
                BllRuts.FillStdCaptions(ref l_lentRet);

                // Devolvemos la LE
                l_dsTemp.Dispose();
                return l_lentRet;
            }
            catch (Exception l_expData) {
                // Error en la operacion
                p_smResult.BllError(l_expData);
                return null;
            }
            finally {
                // Terminamos
            }
        }
        #endregion
    }
}
