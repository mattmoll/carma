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
    // Fecha                    : 05/01/2023 21:08
    // Sistema                  : Carm
    // Clase para Administrar   : Planes
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
    /// Mantenimiento de: Planes
    /// </summary>
    public static partial class Planes
    {

        //**********************************************************
        //
        // Funciones para la Tabla: PlnServicios
        // Usando ClaseDal        : PlnServicios
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos públicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: PlnServicios
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEPlnServicios</returns>
        public static LEPlnServicios PlsUpFull(bool p_bOnlyActive,
                                               StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                return PlsUpfl(l_dbcAccess, p_bOnlyActive, p_smResult);
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
        /// Devuelve una entidad: EPlnServicio
        /// </summary>
        /// <param name="p_strCodplan">Código de Plan</param>
        /// <param name="p_strCodservicio">Código de Servicio</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EPlnServicio</returns>
        public static EPlnServicio PlsGet(string p_strCodplan,
                                          string p_strCodservicio,
                                          bool p_bOnlyActive,
                                          StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCodplan= EPlnServicio.FrmtCodplan(p_strCodplan);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: EPlnServicio
                return PlsSrch(l_dbcAccess,
                               p_strCodplan,
                               p_strCodservicio,
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

        /// <summary>
        /// Devuelve una lista-entidad: LEPlnServicios
        /// asociada a una Foreing key de la tabla: PlnServicios
        /// </summary>
        /// <param name="p_strCodplan">Código de Plan</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-Entidad: LEPlnServicios</returns>
        public static LEPlnServicios PlsFGet(string p_strCodplan,
                                             bool p_bOnlyActive,
                                             StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCodplan= EPlnServicio.FrmtCodplan(p_strCodplan);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la lista-entidad: LEPlnServicios
                return PlsFSch(l_dbcAccess,
                               p_strCodplan,
                               p_bOnlyActive,
                               p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion FGet
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
        /// Agrega o modifica un registro de la tabla: PlnServicios
        /// </summary>
        /// <param name="p_entPlnServicio">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void PlsSave(EPlnServicio p_entPlnServicio,
                                   StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: EPlnServicio
                PlsSSav(l_dbcAccess, p_entPlnServicio, p_smResult);
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
        /// Habilita/Deshabilita un registro de la tabla: PlnServicios
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCodplan">Código de Plan</param>
        /// <param name="p_strCodservicio">Código de Servicio</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void PlsEnabled(bool p_bEnable,
                                      string p_strCodplan,
                                      string p_strCodservicio,
                                      int p_iFxdVersion,
                                      StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCodplan= EPlnServicio.FrmtCodplan(p_strCodplan);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                PlsEnabled_f(l_dbcAccess,
                             p_bEnable,
                             p_strCodplan,
                             p_strCodservicio,
                             ref p_iFxdVersion,
                             p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                PlsVKey(l_dbcAccess,
                        p_strCodplan,
                        p_strCodservicio,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (PlnServicio) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                PlsVVer(l_dbcAccess, 
                        p_strCodplan,
                        p_strCodservicio,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.PlnServicios.Recall(l_dbcAccess,
                                            p_strCodplan,
                                            p_strCodservicio,
                                            p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.PlnServicios.Delete(l_dbcAccess,
                                            p_strCodplan,
                                            p_strCodservicio,
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
        /// Borra físicamento un registro de la tabla: PlnServicios
        /// </summary>
        /// <param name="p_strCodplan">Código de Plan</param>
        /// <param name="p_strCodservicio">Código de Servicio</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void PlsRemove(string p_strCodplan,
                                     string p_strCodservicio,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCodplan= EPlnServicio.FrmtCodplan(p_strCodplan);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                PlsRemove_f(l_dbcAccess,
                            p_strCodplan,
                            p_strCodservicio,
                            p_iFxdVersion,
                            p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                PlsDrop(l_dbcAccess,
                        p_strCodplan,
                        p_strCodservicio,
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
        public static void PlsPurge(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Realizamos el borrado
                PlsPack(l_dbcAccess,
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
        #endregion

        //---------------------------------------------------------------
        // Metodos públicos de la clase (no visibles para la UIL)
        //---------------------------------------------------------------

        #region Metodos internos de validacion

        /// <summary>
        /// Valida la integridad de una entidad: PlnServicio
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entPlnServicio">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void PlsTInt(DBConn p_dbcAccess,
                                     EPlnServicio p_entPlnServicio,
                                     StatMsg p_smResult)
        {
            // ********
            // Validaciones de los campos sin conexion
            // ********

            if (p_entPlnServicio.Codplan.Trim() == "") {
                // El campo [Código de Plan] no puede ser vacío
                p_smResult.BllWarning("El dato [Código de Plan] no puede ser vacío","");
                return;
            }

            if (p_entPlnServicio.Valorprestacion <= 0) {
                // El campo [Valor Prestación] debe ser mayor a cero
                p_smResult.BllWarning("El dato [Valor Prestación] debe ser mayor a cero","");
                return;
            }

            // ********
            // Validaciones de los campos con conexion
            // ********

            Servicios.VKey(p_dbcAccess,
                           p_entPlnServicio.Codservicio,
                           p_smResult);
            if (p_smResult.NOk) return;

            if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                // El campo [Código de Servicio] debe existir en la tabla [Servicios.]
                p_smResult.BllWarning("El dato [Código de Servicio] debe existir en la tabla [Servicios.]","");
                return;
            }

            // Verificamos la clave foranea
            Planes.VKey(p_dbcAccess,
                        p_entPlnServicio.Codplan,
                        p_smResult);
            if (p_smResult.NOk) return;

            // El registro tiene que existir
            if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                // Error. La clave foranea no existe
                p_smResult.BllWarning("La clave (Plan) foranea no existe en el sistema.","");
                return;
            }

            // Todas las validaciones fueron correctas

            // Llamamos a la funcion fija del usuario
            PlsTInt_f(p_dbcAccess, p_entPlnServicio, p_smResult);
            if (p_smResult.NOk) return;
        }

        /// <summary>
        /// Verifica el número de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodplan">Código de Plan</param>
        /// <param name="p_strCodservicio">Código de Servicio</param>
        /// <param name="p_iFxdVersion">Número de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void PlsVVer(DBConn p_dbcAccess,
                                     string p_strCodplan,
                                     string p_strCodservicio,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            // Verificamos el número de versión
            Dal.PlnServicios.ChkVersion(p_dbcAccess,
                                        p_strCodplan,
                                        p_strCodservicio,
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
            p_smResult.BllWarning("El número de versión del registro del ítem (PlnServicio) no coincide.\r\nOperación cancelada.","");
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: EPlnServicio
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave está deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodplan">Código de Plan</param>
        /// <param name="p_strCodservicio">Código de Servicio</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void PlsVKey(DBConn p_dbcAccess,
                                     string p_strCodplan,
                                     string p_strCodservicio,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            Dal.PlnServicios.Search(p_dbcAccess,
                                    p_strCodplan,
                                    p_strCodservicio,
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
        /// Devuelve una Lista-entidad: LEPlnServicios
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEPlnServicios</returns>
        internal static LEPlnServicios PlsUpfl(DBConn p_dbcAccess,
                                                bool p_bOnlyActive,
                                                StatMsg p_smResult)
        {
            try {
                // Pedimos los registros de la tabla: PlnServicios
                DataSet l_dsTemp= new DataSet();

                Dal.PlnServicios.Up(p_dbcAccess, 
                                    p_bOnlyActive,
                                    ref l_dsTemp, "Temporal",
                                    p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.PlnServicios.MakeGridCaptions(ref l_dsTemp, "Temporal", p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LEPlnServicios l_lentRet= new LEPlnServicios(l_dsTemp.Tables["Temporal"]);
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
        /// Devuelve una entidad: EPlnServicio
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodplan">Código de Plan</param>
        /// <param name="p_strCodservicio">Código de Servicio</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EPlnServicio</returns>
        internal static EPlnServicio PlsSrch(DBConn p_dbcAccess,
                                             string p_strCodplan,
                                             string p_strCodservicio,
                                             bool p_bOnlyActive,
                                             StatMsg p_smResult)
        {
            try {
                // Pedimos el registro de la tabla: PlnServicios
                DataSet l_dsTemp= new DataSet();

                Dal.PlnServicios.Search(p_dbcAccess, 
                                        p_strCodplan,
                                        p_strCodservicio,
                                        p_bOnlyActive,
                                        ref l_dsTemp, "Temporal",
                                        p_smResult);
                if (p_smResult.NOk) return null;

                // Constuimos la entidad y la devolvemos (si vino un registro)
                EPlnServicio l_entRet= null;

                if (l_dsTemp.Tables["Temporal"].Rows.Count == 1)
                    l_entRet= new EPlnServicio(l_dsTemp.Tables["Temporal"].Rows[0]);

                l_dsTemp.Dispose();
                return l_entRet;
            }
            catch (Exception l_expData) {
                // Error en la operacion Srch
                p_smResult.BllError(l_expData);
                return null;
            }
        }

        /// <summary>
        /// Devuelve una lista-entidad: LEPlnServicios
        /// a partir de una clave foranea de la tabla: PlnServicios
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodplan">Código de Plan</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static LEPlnServicios PlsFSch(DBConn p_dbcAccess,
                                               string p_strCodplan,
                                               bool p_bOnlyActive,
                                               StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            try {
                // Pedimos los registros de la tabla por Foreing Key
                Dal.PlnServicios.FSearch(p_dbcAccess,
                                         p_strCodplan,
                                         p_bOnlyActive,
                                         ref l_dsTemp, "Temporal",
                                         p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.PlnServicios.MakeGridCaptions(ref l_dsTemp, "Temporal", p_smResult);

                // Contruimos la lista-entidad y la devolvemos
                LEPlnServicios l_entRet= new LEPlnServicios(l_dsTemp.Tables["Temporal"]);
                l_dsTemp.Dispose();
                return l_entRet;
            }
            catch (Exception l_expData) {
                // Error en la operacion FSch
                p_smResult.BllError(l_expData);
                return null;
            }
        }
        #endregion

        #region Metodos internos de modificacion

        /// <summary>
        /// Agrega o modifica un registro de la tabla: PlnServicios
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entPlnServicio">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void PlsSSav(DBConn p_dbcAccess,
                                     EPlnServicio p_entPlnServicio,
                                     StatMsg p_smResult)
        {
            try {
                // Procesamos codigo fijo
                PlsSave_f(p_dbcAccess, ref p_entPlnServicio, p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                PlsVKey(p_dbcAccess, 
                        p_entPlnServicio.Codplan,
                        p_entPlnServicio.Codservicio,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entPlnServicio.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El ítem (PlnServicio) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    PlsInsr(p_dbcAccess, p_entPlnServicio, p_smResult);
                    return;
                }

                // Es un update. La clave debe existir y estar habilitada
                if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                    // Error. La clave no existe o no está habilitada
                    p_smResult.BllWarning("El ítem (PlnServicio) que intenta modificar no existe en el sistema o no está habilitado.","");
                    return;
                }

                // Debe coincidir el número de version
                PlsVVer(p_dbcAccess, 
                        p_entPlnServicio.Codplan,
                        p_entPlnServicio.Codservicio,
                        p_entPlnServicio.FxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos el registro
                PlsUpdt(p_dbcAccess, p_entPlnServicio, p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Agrega un registro a la tabla a partir de una entidad: EPlnServicio
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entPlnServicio">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void PlsInsr(DBConn p_dbcAccess,
                                     EPlnServicio p_entPlnServicio,
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                PlsTInt(p_dbcAccess, p_entPlnServicio, p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: PlnServicios
                Dal.PlnServicios.Insert(p_dbcAccess,
                                        p_entPlnServicio.Codplan,
                                        p_entPlnServicio.Codservicio,
                                        p_entPlnServicio.Cprestlibres,
                                        p_entPlnServicio.Valorprestacion,
                                        p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Actualiza un registro a la tabla a partir de una entidad: EPlnServicio
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entPlnServicio">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void PlsUpdt(DBConn p_dbcAccess,
                                     EPlnServicio p_entPlnServicio,
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                PlsTInt(p_dbcAccess, p_entPlnServicio, p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: PlnServicios
                Dal.PlnServicios.Update(p_dbcAccess,
                                        p_entPlnServicio.Codplan,
                                        p_entPlnServicio.Codservicio,
                                        p_entPlnServicio.Cprestlibres,
                                        p_entPlnServicio.Valorprestacion,
                                        p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra físicamente un registro de a tabla: PlnServicios
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodplan">Código de Plan</param>
        /// <param name="p_strCodservicio">Código de Servicio</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void PlsDrop(DBConn p_dbcAccess,
                                     string p_strCodplan,
                                     string p_strCodservicio,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            try {
                // Verificamos la clave a borrar
                PlsVKey(p_dbcAccess,
                        p_strCodplan,
                        p_strCodservicio,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (PlnServicio) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                PlsVVer(p_dbcAccess, 
                        p_strCodplan,
                        p_strCodservicio,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Borramos físicamente el registro
                Dal.PlnServicios.Drop(p_dbcAccess,
                                      p_strCodplan,
                                      p_strCodservicio,
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
        internal static void PlsPack(DBConn p_dbcAccess,
                                     StatMsg p_smResult)
        {
            try {
                // Borramos los borrados lógicamente
                Dal.PlnServicios.Pack(p_dbcAccess,
                                      p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Realiza una actualización inteligente de la tabla a partir de una
        /// lista-entidad: LEPlnServicios
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodplan">Código de Plan</param>
        /// <param name="p_lentPlnServicios">Lista-entidad a actualizar sobre la tabla</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void PlsSSav(DBConn p_dbcAccess,
                                     string p_strCodplan,
                                      LEPlnServicios p_lentPlnServicios,
                                      StatMsg p_smResult)
        {
            try {
                // Deshabilitamos todas las entidades existentes
                Dal.PlnServicios.FDrop(p_dbcAccess,
                                       p_strCodplan,
                                       p_smResult);
                if (p_smResult.NOk) return;

                // Recorremos la lista de entidades
                foreach (EPlnServicio l_entPlnServicio in p_lentPlnServicios) {
                    // Forzamos la clave foranea
                    l_entPlnServicio.Codplan= p_strCodplan;

                    // Verificamos si existe
                    PlsVKey(p_dbcAccess,
                            l_entPlnServicio.Codplan,
                            l_entPlnServicio.Codservicio,
                            p_smResult);
                    if (p_smResult.NOk) return;

                    // Si no existe
                    if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Hay que darla de alta
                        PlsInsr(p_dbcAccess, l_entPlnServicio, p_smResult);
                        if (p_smResult.NOk) return;
                        continue;
                    }

                    // Existe. Debe coincidir el número de version
                    PlsVVer(p_dbcAccess, 
                            l_entPlnServicio.Codplan,
                            l_entPlnServicio.Codservicio,
                            l_entPlnServicio.FxdVersion,
                            p_smResult);
                    if (p_smResult.NOk) return;

                    // El número coincide. La Actualizamos si no está borrada
                    if (!l_entPlnServicio.EstaBorrada) {
                        PlsUpdt(p_dbcAccess, l_entPlnServicio, p_smResult);
                        if (p_smResult.NOk) return;
                    }
                }
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData);
            }
        }
        #endregion

        #region Metodos para métodos DAL definidos por el usuario
        #endregion


        //**********************************************************
        //
        // Funciones para la Tabla: Planes
        // Usando ClaseDal        : Planes
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos públicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: Planes
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEPlanes</returns>
        public static LEPlanes UpFull(bool p_bOnlyActive,
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
        /// Devuelve una entidad: EPlan
        /// </summary>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EPlan</returns>
        public static EPlan Get(string p_strCod,
                                bool p_bOnlyActive,
                                StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCod= EPlan.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: EPlan
                EPlan l_entPlan = Srch(l_dbcAccess,
                                       p_strCod,
                                       p_bOnlyActive,
                                       p_smResult);
                if (p_smResult.NOk) return null;
                if (l_entPlan == null) return null;

                // Completamos la lista-entidad: LEPlnServicios
                l_entPlan.PlnServicios= PlsFSch(l_dbcAccess,
                                                p_strCod,
                                                p_bOnlyActive,
                                                p_smResult);
                if (p_smResult.NOk) return null;

                // Devolvemos la entidad completa
                return l_entPlan;
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

        /// <summary>
        /// Devuelve la próxima clave de la entidad
        /// </summary>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Próxima clave</returns>
        public static string NextKey(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la clave máxima
                return GetNK(l_dbcAccess,
                             p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion NextKey
                p_smResult.BllError(l_expData);
                return "";
            }
            finally {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null) l_dbcAccess.Close();
            }
        }
        #endregion

        #region Metodos publicos de modificacion

        /// <summary>
        /// Agrega o modifica un registro de la tabla: Planes
        /// </summary>
        /// <param name="p_entPlan">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void Save(EPlan p_entPlan,
                                StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: EPlan
                SSav(l_dbcAccess, p_entPlan, p_smResult);
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
        /// Habilita/Deshabilita un registro de la tabla: Planes
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

            // Ajustamos codigos alineados a derecha
            p_strCod= EPlan.FrmtCod(p_strCod);

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
                    p_smResult.BllWarning("El ítem (Plan) que intenta modificar no existe en el sistema.","");
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
                    Dal.Planes.Recall(l_dbcAccess,
                                      p_strCod,
                                      p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.Planes.Delete(l_dbcAccess,
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
        /// Borra físicamento un registro de la tabla: Planes
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

            // Ajustamos codigos alineados a derecha
            p_strCod= EPlan.FrmtCod(p_strCod);

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
        /// Ejecuta el SP definido por el usuario: GetPlanesFromTCont
        /// </summary>
        /// <param name= p_strCodtcont>Codigo de Tipo de Contrato</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        public static ListaEntidades GetPlanesFromTCont(string p_strCodtcont,
                                                        StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Abrimos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Llamamos al metodo interno
                return GetPlanesFromTCont(l_dbcAccess,
                                          p_strCodtcont,
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
        /// Valida la integridad de una entidad: Plan
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entPlan">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TInt(DBConn p_dbcAccess,
                                  EPlan p_entPlan,
                                  StatMsg p_smResult)
        {
            // ********
            // Validaciones de los campos sin conexion
            // ********

            if (p_entPlan.Cod.Trim() == "") {
                // El campo [Código] no puede ser vacío
                p_smResult.BllWarning("El dato [Código] no puede ser vacío","");
                return;
            }

            if (p_entPlan.Des.Trim() == "") {
                // El campo [Descripción] no puede ser vacío
                p_smResult.BllWarning("El dato [Descripción] no puede ser vacío","");
                return;
            }

            if (p_entPlan.Codplanavalon.Trim() == "") {
                // El campo [Cod Plan Avalon] no puede ser vacío
                p_smResult.BllWarning("El dato [Cod Plan Avalon] no puede ser vacío","");
                return;
            }

            // ********
            // Validaciones de los campos con conexion
            // ********

            // Llamamos a la funcion fija del usuario
            TInt_f(p_dbcAccess, p_entPlan, p_smResult);
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
            Dal.Planes.ChkVersion(p_dbcAccess,
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
            p_smResult.BllWarning("El número de versión del registro del ítem (Plan) no coincide.\r\nOperación cancelada.","");
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: EPlan
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

            Dal.Planes.Search(p_dbcAccess,
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
        /// Devuelve una Lista-entidad: LEPlanes
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEPlanes</returns>
        internal static LEPlanes Upfl(DBConn p_dbcAccess,
                                          bool p_bOnlyActive,
                                          StatMsg p_smResult)
        {
            try {
                // Pedimos los registros de la tabla: Planes
                DataSet l_dsTemp= new DataSet();

                Dal.Planes.Up(p_dbcAccess, 
                              p_bOnlyActive,
                              ref l_dsTemp, "Temporal",
                              p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.Planes.MakeGridCaptions(ref l_dsTemp, "Temporal", p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LEPlanes l_lentRet= new LEPlanes(l_dsTemp.Tables["Temporal"]);
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
        /// Devuelve una entidad: EPlan
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EPlan</returns>
        internal static EPlan Srch(DBConn p_dbcAccess,
                                   string p_strCod,
                                   bool p_bOnlyActive,
                                   StatMsg p_smResult)
        {
            try {
                // Pedimos el registro de la tabla: Planes
                DataSet l_dsTemp= new DataSet();

                Dal.Planes.Search(p_dbcAccess, 
                                  p_strCod,
                                  p_bOnlyActive,
                                  ref l_dsTemp, "Temporal",
                                  p_smResult);
                if (p_smResult.NOk) return null;

                // Constuimos la entidad y la devolvemos (si vino un registro)
                EPlan l_entRet= null;

                if (l_dsTemp.Tables["Temporal"].Rows.Count == 1)
                    l_entRet= new EPlan(l_dsTemp.Tables["Temporal"].Rows[0]);

                l_dsTemp.Dispose();
                return l_entRet;
            }
            catch (Exception l_expData) {
                // Error en la operacion Srch
                p_smResult.BllError(l_expData);
                return null;
            }
        }

        /// <summary>
        /// Devuelve la próxima clave de la entidad
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Próxima clave</returns>
        internal static string GetNK(DBConn p_dbcAccess,
                                     StatMsg p_smResult)
        {
            try {
                // Pedimos la clave máxima
                DataSet l_dsTemp= new DataSet();

                Dal.Planes.GetMaxKey(p_dbcAccess,
                                     ref l_dsTemp,
                                     "Temporal",
                                     p_smResult);
                if (p_smResult.NOk) return "";

                // Si no vino nada
                if (l_dsTemp.Tables["Temporal"].Rows.Count == 0) {
                    // Primera clave de la tabla
                    return "1";
                }

                // Convertimos la clave a numerica y le sumamos uno
                int l_iValue= Convert.ToInt32((string) l_dsTemp.Tables["Temporal"].Rows[0][0]) + 1;

                // Devolvemos la nueva clave
                return l_iValue.ToString("0");
            }
            catch (Exception l_expData) {
                // Error en la operacion NextKey
                p_smResult.BllError(l_expData);
                return "";
            }
        }
        #endregion

        #region Metodos internos de modificacion

        /// <summary>
        /// Agrega un registro a la tabla a partir de una entidad: EPlan
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entPlan">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void Insr(DBConn p_dbcAccess,
                                  EPlan p_entPlan,
                                  StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                TInt(p_dbcAccess, p_entPlan, p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: Planes
                Dal.Planes.Insert(p_dbcAccess,
                                  p_entPlan.Cod,
                                  p_entPlan.Des,
                                  p_entPlan.Codplanavalon,
                                  p_entPlan.Tcontratoavalon,
                                  p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Actualiza un registro a la tabla a partir de una entidad: EPlan
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entPlan">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void Updt(DBConn p_dbcAccess,
                                  EPlan p_entPlan,
                                  StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                TInt(p_dbcAccess, p_entPlan, p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: Planes
                Dal.Planes.Update(p_dbcAccess,
                                  p_entPlan.Cod,
                                  p_entPlan.Des,
                                  p_entPlan.Codplanavalon,
                                  p_entPlan.Tcontratoavalon,
                                  p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra físicamente un registro de a tabla: Planes
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
                    p_smResult.BllWarning("El ítem (Plan) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                VVer(p_dbcAccess, 
                     p_strCod,
                     p_iFxdVersion,
                     p_smResult);
                if (p_smResult.NOk) return;

                // Borramos físicamente el registro
                Dal.Planes.Drop(p_dbcAccess,
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
                Dal.Planes.Pack(p_dbcAccess,
                                p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: Planes
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entPlan">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void SSav(DBConn p_dbcAccess,
                                  EPlan p_entPlan,
                                  StatMsg p_smResult)
        {
            try {
                // Procesamos codigo fijo
                Save_f(p_dbcAccess, ref p_entPlan, p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                VKey(p_dbcAccess, 
                     p_entPlan.Cod,
                     p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entPlan.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El ítem (Plan) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    Insr(p_dbcAccess, p_entPlan, p_smResult);
                }
                else {
                    // Es un update. La clave debe existir y estar habilitada
                    if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                        // Error. La clave no existe o no está habilitada
                        p_smResult.BllWarning("El ítem (Plan) que intenta modificar no existe en el sistema o no está habilitado.","");
                        return;
                    }

                    // Debe coincidir el número de version
                    VVer(p_dbcAccess, 
                         p_entPlan.Cod,
                         p_entPlan.FxdVersion,
                         p_smResult);
                    if (p_smResult.NOk) return;

                    // Actualizamos el registro
                    Updt(p_dbcAccess, p_entPlan, p_smResult);
                }
                if (p_smResult.NOk) return;

                // Grabamos la lista-entidad: LEPlnServicios
                PlsSSav(p_dbcAccess,
                        p_entPlan.Cod,
                        p_entPlan.PlnServicios,
                        p_smResult);
                if (p_smResult.NOk) return;
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData);
            }
        }
        #endregion

        #region Metodos para métodos DAL definidos por el usuario

        /// <summary>
        /// Ejecuta el SP definido por el usuario: GetPlanesFromTCont
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_strCodtcont>Codigo de Tipo de Contrato</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades GetPlanesFromTCont(DBConn p_dbcAccess,
                                                          string p_strCodtcont,
                                                          StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.Planes.GetPlanesFromTCont(p_dbcAccess,
                                              p_strCodtcont,
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
