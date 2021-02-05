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
    // Fecha                    : 05/02/2021 12:36
    // Sistema                  : Carm
    // Clase para Administrar   : Clientes
    //----------------------------------------------------------------------------
    // © 1996-2021 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    //****************************************************************************
    // Atencion!!!
    //    Esta clase fue generada por un programa en forma automática. Cualquier
    //    modificación que se realize sobre ella se perderá en la próxima
    //    regeneración.
    //****************************************************************************

    /// <summary>
    /// Mantenimiento de: Clientes
    /// </summary>
    public static partial class Clientes
    {

        //**********************************************************
        //
        // Funciones para la Tabla: CliContactos
        // Usando ClaseDal        : CliContactos
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos públicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: CliContactos
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LECliContactos</returns>
        public static LECliContactos ClcUpFull(bool p_bOnlyActive,
                                               StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                return ClcUpfl(l_dbcAccess, p_bOnlyActive, p_smResult);
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
        /// Devuelve una entidad: ECliContacto
        /// </summary>
        /// <param name="p_iNumcliente">Número de cliente</param>
        /// <param name="p_iNumcontacto">Número</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: ECliContacto</returns>
        public static ECliContacto ClcGet(int p_iNumcliente,
                                          int p_iNumcontacto,
                                          bool p_bOnlyActive,
                                          StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: ECliContacto
                return ClcSrch(l_dbcAccess,
                               p_iNumcliente,
                               p_iNumcontacto,
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
        /// Devuelve una lista-entidad: LECliContactos
        /// asociada a una Foreing key de la tabla: CliContactos
        /// </summary>
        /// <param name="p_iNumcliente">Número de cliente</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-Entidad: LECliContactos</returns>
        public static LECliContactos ClcFGet(int p_iNumcliente,
                                             bool p_bOnlyActive,
                                             StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la lista-entidad: LECliContactos
                return ClcFSch(l_dbcAccess,
                               p_iNumcliente,
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
        /// Agrega o modifica un registro de la tabla: CliContactos
        /// </summary>
        /// <param name="p_entCliContacto">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void ClcSave(ECliContacto p_entCliContacto,
                                   StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: ECliContacto
                ClcSSav(l_dbcAccess, p_entCliContacto, p_smResult);
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
        /// Habilita/Deshabilita un registro de la tabla: CliContactos
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_iNumcliente">Número de cliente</param>
        /// <param name="p_iNumcontacto">Número</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void ClcEnabled(bool p_bEnable,
                                      int p_iNumcliente,
                                      int p_iNumcontacto,
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
                ClcEnabled_f(l_dbcAccess,
                             p_bEnable,
                             p_iNumcliente,
                             p_iNumcontacto,
                             ref p_iFxdVersion,
                             p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                ClcVKey(l_dbcAccess,
                        p_iNumcliente,
                        p_iNumcontacto,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (CliContacto) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                ClcVVer(l_dbcAccess, 
                        p_iNumcliente,
                        p_iNumcontacto,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.CliContactos.Recall(l_dbcAccess,
                                            p_iNumcliente,
                                            p_iNumcontacto,
                                            p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.CliContactos.Delete(l_dbcAccess,
                                            p_iNumcliente,
                                            p_iNumcontacto,
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
        /// Borra físicamento un registro de la tabla: CliContactos
        /// </summary>
        /// <param name="p_iNumcliente">Número de cliente</param>
        /// <param name="p_iNumcontacto">Número</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void ClcRemove(int p_iNumcliente,
                                     int p_iNumcontacto,
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
                ClcRemove_f(l_dbcAccess,
                            p_iNumcliente,
                            p_iNumcontacto,
                            p_iFxdVersion,
                            p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                ClcDrop(l_dbcAccess,
                        p_iNumcliente,
                        p_iNumcontacto,
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
        public static void ClcPurge(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Realizamos el borrado
                ClcPack(l_dbcAccess,
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
        /// Valida la integridad de una entidad: CliContacto
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCliContacto">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ClcTInt(DBConn p_dbcAccess,
                                     ECliContacto p_entCliContacto,
                                     StatMsg p_smResult)
        {
            // ********
            // Validaciones de los campos sin conexion
            // ********

            if (p_entCliContacto.Numcliente <= 0) {
                // El campo [Número de cliente] debe ser mayor a cero
                p_smResult.BllWarning("El dato [Número de cliente] debe ser mayor a cero","");
                return;
            }

            if (p_entCliContacto.Numcontacto <= 0) {
                // El campo [Número] debe ser mayor a cero
                p_smResult.BllWarning("El dato [Número] debe ser mayor a cero","");
                return;
            }

            if (p_entCliContacto.Nombre.Trim() == "") {
                // El campo [Apellido y Nombre] no puede ser vacío
                p_smResult.BllWarning("El dato [Apellido y Nombre] no puede ser vacío","");
                return;
            }

            if (p_entCliContacto.Cargo.Trim() == "") {
                // El campo [Cargo] no puede ser vacío
                p_smResult.BllWarning("El dato [Cargo] no puede ser vacío","");
                return;
            }

            // ********
            // Validaciones de los campos con conexion
            // ********

            // Verificamos la clave foranea
            Clientes.VKey(p_dbcAccess,
                          p_entCliContacto.Numcliente,
                          p_smResult);
            if (p_smResult.NOk) return;

            // El registro tiene que existir
            if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                // Error. La clave foranea no existe
                p_smResult.BllWarning("La clave (Cliente) foranea no existe en el sistema.","");
                return;
            }

            // Llamamos a la funcion fija del usuario
            ClcTInt_f(p_dbcAccess, p_entCliContacto, p_smResult);
            if (p_smResult.NOk) return;
        }

        /// <summary>
        /// Verifica el número de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Número de cliente</param>
        /// <param name="p_iNumcontacto">Número</param>
        /// <param name="p_iFxdVersion">Número de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ClcVVer(DBConn p_dbcAccess,
                                     int p_iNumcliente,
                                     int p_iNumcontacto,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            // Verificamos el número de versión
            Dal.CliContactos.ChkVersion(p_dbcAccess,
                                        p_iNumcliente,
                                        p_iNumcontacto,
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
            p_smResult.BllWarning("El número de versión del registro del ítem (CliContacto) no coincide.\r\nOperación cancelada.","");
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: ECliContacto
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave está deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Número de cliente</param>
        /// <param name="p_iNumcontacto">Número</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ClcVKey(DBConn p_dbcAccess,
                                     int p_iNumcliente,
                                     int p_iNumcontacto,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            Dal.CliContactos.Search(p_dbcAccess,
                                    p_iNumcliente,
                                    p_iNumcontacto,
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
        /// Devuelve una Lista-entidad: LECliContactos
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LECliContactos</returns>
        internal static LECliContactos ClcUpfl(DBConn p_dbcAccess,
                                                bool p_bOnlyActive,
                                                StatMsg p_smResult)
        {
            try {
                // Pedimos los registros de la tabla: CliContactos
                DataSet l_dsTemp= new DataSet();

                Dal.CliContactos.Up(p_dbcAccess, 
                                    p_bOnlyActive,
                                    ref l_dsTemp, "Temporal",
                                    p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.CliContactos.MakeGridCaptions(ref l_dsTemp, "Temporal", p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LECliContactos l_lentRet= new LECliContactos(l_dsTemp.Tables["Temporal"]);
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
        /// Devuelve una entidad: ECliContacto
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Número de cliente</param>
        /// <param name="p_iNumcontacto">Número</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: ECliContacto</returns>
        internal static ECliContacto ClcSrch(DBConn p_dbcAccess,
                                             int p_iNumcliente,
                                             int p_iNumcontacto,
                                             bool p_bOnlyActive,
                                             StatMsg p_smResult)
        {
            try {
                // Pedimos el registro de la tabla: CliContactos
                DataSet l_dsTemp= new DataSet();

                Dal.CliContactos.Search(p_dbcAccess, 
                                        p_iNumcliente,
                                        p_iNumcontacto,
                                        p_bOnlyActive,
                                        ref l_dsTemp, "Temporal",
                                        p_smResult);
                if (p_smResult.NOk) return null;

                // Constuimos la entidad y la devolvemos (si vino un registro)
                ECliContacto l_entRet= null;

                if (l_dsTemp.Tables["Temporal"].Rows.Count == 1)
                    l_entRet= new ECliContacto(l_dsTemp.Tables["Temporal"].Rows[0]);

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
        /// Devuelve una lista-entidad: LECliContactos
        /// a partir de una clave foranea de la tabla: CliContactos
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Número de cliente</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static LECliContactos ClcFSch(DBConn p_dbcAccess,
                                               int p_iNumcliente,
                                               bool p_bOnlyActive,
                                               StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            try {
                // Pedimos los registros de la tabla por Foreing Key
                Dal.CliContactos.FSearch(p_dbcAccess,
                                         p_iNumcliente,
                                         p_bOnlyActive,
                                         ref l_dsTemp, "Temporal",
                                         p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.CliContactos.MakeGridCaptions(ref l_dsTemp, "Temporal", p_smResult);

                // Contruimos la lista-entidad y la devolvemos
                LECliContactos l_entRet= new LECliContactos(l_dsTemp.Tables["Temporal"]);
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
        /// Agrega o modifica un registro de la tabla: CliContactos
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCliContacto">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ClcSSav(DBConn p_dbcAccess,
                                     ECliContacto p_entCliContacto,
                                     StatMsg p_smResult)
        {
            try {
                // Procesamos codigo fijo
                ClcSave_f(p_dbcAccess, ref p_entCliContacto, p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                ClcVKey(p_dbcAccess, 
                        p_entCliContacto.Numcliente,
                        p_entCliContacto.Numcontacto,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entCliContacto.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El ítem (CliContacto) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    ClcInsr(p_dbcAccess, p_entCliContacto, p_smResult);
                    return;
                }

                // Es un update. La clave debe existir y estar habilitada
                if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                    // Error. La clave no existe o no está habilitada
                    p_smResult.BllWarning("El ítem (CliContacto) que intenta modificar no existe en el sistema o no está habilitado.","");
                    return;
                }

                // Debe coincidir el número de version
                ClcVVer(p_dbcAccess, 
                        p_entCliContacto.Numcliente,
                        p_entCliContacto.Numcontacto,
                        p_entCliContacto.FxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos el registro
                ClcUpdt(p_dbcAccess, p_entCliContacto, p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Agrega un registro a la tabla a partir de una entidad: ECliContacto
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCliContacto">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ClcInsr(DBConn p_dbcAccess,
                                     ECliContacto p_entCliContacto,
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                ClcTInt(p_dbcAccess, p_entCliContacto, p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: CliContactos
                Dal.CliContactos.Insert(p_dbcAccess,
                                        p_entCliContacto.Numcliente,
                                        p_entCliContacto.Numcontacto,
                                        p_entCliContacto.Nombre,
                                        p_entCliContacto.Cargo,
                                        p_entCliContacto.Titulo,
                                        p_entCliContacto.Celular,
                                        p_entCliContacto.Telefono1,
                                        p_entCliContacto.Telefono2,
                                        p_entCliContacto.Interno,
                                        p_entCliContacto.Email,
                                        p_entCliContacto.Secretaria,
                                        p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Actualiza un registro a la tabla a partir de una entidad: ECliContacto
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCliContacto">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ClcUpdt(DBConn p_dbcAccess,
                                     ECliContacto p_entCliContacto,
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                ClcTInt(p_dbcAccess, p_entCliContacto, p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: CliContactos
                Dal.CliContactos.Update(p_dbcAccess,
                                        p_entCliContacto.Numcliente,
                                        p_entCliContacto.Numcontacto,
                                        p_entCliContacto.Nombre,
                                        p_entCliContacto.Cargo,
                                        p_entCliContacto.Titulo,
                                        p_entCliContacto.Celular,
                                        p_entCliContacto.Telefono1,
                                        p_entCliContacto.Telefono2,
                                        p_entCliContacto.Interno,
                                        p_entCliContacto.Email,
                                        p_entCliContacto.Secretaria,
                                        p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra físicamente un registro de a tabla: CliContactos
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Número de cliente</param>
        /// <param name="p_iNumcontacto">Número</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ClcDrop(DBConn p_dbcAccess,
                                     int p_iNumcliente,
                                     int p_iNumcontacto,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            try {
                // Verificamos la clave a borrar
                ClcVKey(p_dbcAccess,
                        p_iNumcliente,
                        p_iNumcontacto,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (CliContacto) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                ClcVVer(p_dbcAccess, 
                        p_iNumcliente,
                        p_iNumcontacto,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Borramos físicamente el registro
                Dal.CliContactos.Drop(p_dbcAccess,
                                      p_iNumcliente,
                                      p_iNumcontacto,
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
        internal static void ClcPack(DBConn p_dbcAccess,
                                     StatMsg p_smResult)
        {
            try {
                // Borramos los borrados lógicamente
                Dal.CliContactos.Pack(p_dbcAccess,
                                      p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Realiza una actualización inteligente de la tabla a partir de una
        /// lista-entidad: LECliContactos
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Número de cliente</param>
        /// <param name="p_lentCliContactos">Lista-entidad a actualizar sobre la tabla</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ClcSSav(DBConn p_dbcAccess,
                                     int p_iNumcliente,
                                      LECliContactos p_lentCliContactos,
                                      StatMsg p_smResult)
        {
            try {
                // Deshabilitamos todas las entidades existentes
                Dal.CliContactos.FDrop(p_dbcAccess,
                                       p_iNumcliente,
                                       p_smResult);
                if (p_smResult.NOk) return;

                // Recorremos la lista de entidades
                foreach (ECliContacto l_entCliContacto in p_lentCliContactos) {
                    // Forzamos la clave foranea
                    l_entCliContacto.Numcliente= p_iNumcliente;

                    // Verificamos si existe
                    ClcVKey(p_dbcAccess,
                            l_entCliContacto.Numcliente,
                            l_entCliContacto.Numcontacto,
                            p_smResult);
                    if (p_smResult.NOk) return;

                    // Si no existe
                    if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Hay que darla de alta
                        ClcInsr(p_dbcAccess, l_entCliContacto, p_smResult);
                        if (p_smResult.NOk) return;
                        continue;
                    }

                    // Existe. Debe coincidir el número de version
                    ClcVVer(p_dbcAccess, 
                            l_entCliContacto.Numcliente,
                            l_entCliContacto.Numcontacto,
                            l_entCliContacto.FxdVersion,
                            p_smResult);
                    if (p_smResult.NOk) return;

                    // El número coincide. La Actualizamos si no está borrada
                    if (!l_entCliContacto.EstaBorrada) {
                        ClcUpdt(p_dbcAccess, l_entCliContacto, p_smResult);
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

        /// <summary>
        /// Ejecuta el SP definido por el usuario: BorraPorCliente
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_iNrocliente>Numero del cliente a borrar sus contactos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ClcBorraPorCliente(DBConn p_dbcAccess,
                                                int p_iNrocliente,
                                                StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                Dal.CliContactos.BorraPorCliente(p_dbcAccess,
                                                 p_iNrocliente,
                                                 p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion
                p_smResult.BllError(l_expData);
            }
            finally {
                // Terminamos
            }
        }
        #endregion


        //**********************************************************
        //
        // Funciones para la Tabla: CliEntrevistas
        // Usando ClaseDal        : CliEntrevistas
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos públicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: CliEntrevistas
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LECliEntrevistas</returns>
        public static LECliEntrevistas CleUpFull(bool p_bOnlyActive,
                                                 StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                return CleUpfl(l_dbcAccess, p_bOnlyActive, p_smResult);
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
        /// Devuelve una entidad: ECliEntrevista
        /// </summary>
        /// <param name="p_iNumcliente">Número de cliente</param>
        /// <param name="p_iNumentrev">Número</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: ECliEntrevista</returns>
        public static ECliEntrevista CleGet(int p_iNumcliente,
                                            int p_iNumentrev,
                                            bool p_bOnlyActive,
                                            StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: ECliEntrevista
                return CleSrch(l_dbcAccess,
                               p_iNumcliente,
                               p_iNumentrev,
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
        /// Devuelve una lista-entidad: LECliEntrevistas
        /// asociada a una Foreing key de la tabla: CliEntrevistas
        /// </summary>
        /// <param name="p_iNumcliente">Número de cliente</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-Entidad: LECliEntrevistas</returns>
        public static LECliEntrevistas CleFGet(int p_iNumcliente,
                                               bool p_bOnlyActive,
                                               StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la lista-entidad: LECliEntrevistas
                return CleFSch(l_dbcAccess,
                               p_iNumcliente,
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
        /// Agrega o modifica un registro de la tabla: CliEntrevistas
        /// </summary>
        /// <param name="p_entCliEntrevista">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void CleSave(ECliEntrevista p_entCliEntrevista,
                                   StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: ECliEntrevista
                CleSSav(l_dbcAccess, p_entCliEntrevista, p_smResult);
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
        /// Habilita/Deshabilita un registro de la tabla: CliEntrevistas
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_iNumcliente">Número de cliente</param>
        /// <param name="p_iNumentrev">Número</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void CleEnabled(bool p_bEnable,
                                      int p_iNumcliente,
                                      int p_iNumentrev,
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
                CleEnabled_f(l_dbcAccess,
                             p_bEnable,
                             p_iNumcliente,
                             p_iNumentrev,
                             ref p_iFxdVersion,
                             p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                CleVKey(l_dbcAccess,
                        p_iNumcliente,
                        p_iNumentrev,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (CliEntrevista) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                CleVVer(l_dbcAccess, 
                        p_iNumcliente,
                        p_iNumentrev,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.CliEntrevistas.Recall(l_dbcAccess,
                                              p_iNumcliente,
                                              p_iNumentrev,
                                              p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.CliEntrevistas.Delete(l_dbcAccess,
                                              p_iNumcliente,
                                              p_iNumentrev,
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
        /// Borra físicamento un registro de la tabla: CliEntrevistas
        /// </summary>
        /// <param name="p_iNumcliente">Número de cliente</param>
        /// <param name="p_iNumentrev">Número</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void CleRemove(int p_iNumcliente,
                                     int p_iNumentrev,
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
                CleRemove_f(l_dbcAccess,
                            p_iNumcliente,
                            p_iNumentrev,
                            p_iFxdVersion,
                            p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                CleDrop(l_dbcAccess,
                        p_iNumcliente,
                        p_iNumentrev,
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
        public static void ClePurge(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Realizamos el borrado
                ClePack(l_dbcAccess,
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
        /// Ejecuta el SP definido por el usuario: GetEntrevistasCli
        /// </summary>
        /// <param name= p_iCliente>Numero del Cliente</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        public static LECliEntrevistas CleGetEntrevistasCli(int p_iCliente,
                                                            StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Abrimos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Llamamos al metodo interno
                return CleGetEntrevistasCli(l_dbcAccess,
                                            p_iCliente,
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
        /// Ejecuta el SP definido por el usuario: GetEntrevistasIncom
        /// </summary>
        /// <param name= p_iNumcliente>Número de cliente</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        public static ListaEntidades CleGetEntrevistasIncom(int p_iNumcliente,
                                                            StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Abrimos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Llamamos al metodo interno
                return CleGetEntrevistasIncom(l_dbcAccess,
                                              p_iNumcliente,
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
        /// Ejecuta el SP definido por el usuario: GetEntrevistasPend
        /// </summary>
        /// <param name= p_strCodvend>Código de vendedor</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        public static ListaEntidades CleGetEntrevistasPend(string p_strCodvend,
                                                           StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Abrimos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Llamamos al metodo interno
                return CleGetEntrevistasPend(l_dbcAccess,
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
        /// Ejecuta el SP definido por el usuario: SaveCompletarEntrev
        /// </summary>
        /// <param name= p_dtFrealizada>Fecha realizada</param>
        /// <param name= p_iNumentrev>Número de entrevista</param>
        /// <param name= p_strMotivo>Motivo de cambio de fecha</param>
        /// <param name= p_strInforme>Informe de resultado</param>
        /// <param name= p_strCodresultado>Codigo del Resultado de la entrev.</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void CleSaveCompletarEntrev(DateTime p_dtFrealizada,
                                                  int p_iNumentrev,
                                                  string p_strMotivo,
                                                  string p_strInforme,
                                                  string p_strCodresultado,
                                                  StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Abrimos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Llamamos al metodo interno
                CleSaveCompletarEntrev(l_dbcAccess,
                                       p_dtFrealizada,
                                       p_iNumentrev,
                                       p_strMotivo,
                                       p_strInforme,
                                       p_strCodresultado,
                                       p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion
                p_smResult.BllError(l_expData);
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
        /// Valida la integridad de una entidad: CliEntrevista
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCliEntrevista">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CleTInt(DBConn p_dbcAccess,
                                     ECliEntrevista p_entCliEntrevista,
                                     StatMsg p_smResult)
        {
            // ********
            // Validaciones de los campos sin conexion
            // ********

            if (p_entCliEntrevista.Numcliente <= 0) {
                // El campo [Número de cliente] debe ser mayor a cero
                p_smResult.BllWarning("El dato [Número de cliente] debe ser mayor a cero","");
                return;
            }

            if (p_entCliEntrevista.Numentrev <= 0) {
                // El campo [Número] debe ser mayor a cero
                p_smResult.BllWarning("El dato [Número] debe ser mayor a cero","");
                return;
            }

            if (p_entCliEntrevista.Fcoordinada.Year == 1900) {
                // El campo [Fecha coordinada] no puede ser vacío
                p_smResult.BllWarning("El dato [Fecha coordinada] no puede ser vacío","");
                return;
            }

            if (p_entCliEntrevista.Nombre.Trim() == "") {
                // El campo [Nombre] no puede ser vacío
                p_smResult.BllWarning("El dato [Nombre] no puede ser vacío","");
                return;
            }

            if (p_entCliEntrevista.Titulo.Trim() == "") {
                // El campo [Título] no puede ser vacío
                p_smResult.BllWarning("El dato [Título] no puede ser vacío","");
                return;
            }

            // ********
            // Validaciones de los campos con conexion
            // ********

            Vendedores.VKey(p_dbcAccess,
                            p_entCliEntrevista.Codvend,
                            p_smResult);
            if (p_smResult.NOk) return;

            if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                // El campo [Código de Vendedor] debe existir en la tabla [Vendedores.]
                p_smResult.BllWarning("El dato [Código de Vendedor] debe existir en la tabla [Vendedores.] y estar habilitado","");
                return;
            }

            if (p_entCliEntrevista.Codresultado.Trim() != "") {
                Tablas.RenVKey(p_dbcAccess,
                               p_entCliEntrevista.Codresultado,
                               p_smResult);
                if (p_smResult.NOk) return;

                if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                    // El campo [Código de resultado] debe existir en la tabla [Tablas.Ren]
                    p_smResult.BllWarning("El dato [Código de resultado] debe existir en la tabla [Tablas.Ren] y estar habilitado","");
                    return;
                }
            }

            // Verificamos la clave foranea
            Clientes.VKey(p_dbcAccess,
                          p_entCliEntrevista.Numcliente,
                          p_smResult);
            if (p_smResult.NOk) return;

            // El registro tiene que existir
            if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                // Error. La clave foranea no existe
                p_smResult.BllWarning("La clave (Cliente) foranea no existe en el sistema.","");
                return;
            }

            // Todas las validaciones fueron correctas

            // Llamamos a la funcion fija del usuario
            CleTInt_f(p_dbcAccess, p_entCliEntrevista, p_smResult);
            if (p_smResult.NOk) return;
        }

        /// <summary>
        /// Verifica el número de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Número de cliente</param>
        /// <param name="p_iNumentrev">Número</param>
        /// <param name="p_iFxdVersion">Número de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CleVVer(DBConn p_dbcAccess,
                                     int p_iNumcliente,
                                     int p_iNumentrev,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            // Verificamos el número de versión
            Dal.CliEntrevistas.ChkVersion(p_dbcAccess,
                                          p_iNumcliente,
                                          p_iNumentrev,
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
            p_smResult.BllWarning("El número de versión del registro del ítem (CliEntrevista) no coincide.\r\nOperación cancelada.","");
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: ECliEntrevista
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave está deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Número de cliente</param>
        /// <param name="p_iNumentrev">Número</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CleVKey(DBConn p_dbcAccess,
                                     int p_iNumcliente,
                                     int p_iNumentrev,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            Dal.CliEntrevistas.Search(p_dbcAccess,
                                      p_iNumcliente,
                                      p_iNumentrev,
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
        /// Devuelve una Lista-entidad: LECliEntrevistas
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LECliEntrevistas</returns>
        internal static LECliEntrevistas CleUpfl(DBConn p_dbcAccess,
                                                  bool p_bOnlyActive,
                                                  StatMsg p_smResult)
        {
            try {
                // Pedimos los registros de la tabla: CliEntrevistas
                DataSet l_dsTemp= new DataSet();

                Dal.CliEntrevistas.Up(p_dbcAccess, 
                                      p_bOnlyActive,
                                      ref l_dsTemp, "Temporal",
                                      p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.CliEntrevistas.MakeGridCaptions(ref l_dsTemp, "Temporal", p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LECliEntrevistas l_lentRet= new LECliEntrevistas(l_dsTemp.Tables["Temporal"]);
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
        /// Devuelve una entidad: ECliEntrevista
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Número de cliente</param>
        /// <param name="p_iNumentrev">Número</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: ECliEntrevista</returns>
        internal static ECliEntrevista CleSrch(DBConn p_dbcAccess,
                                               int p_iNumcliente,
                                               int p_iNumentrev,
                                               bool p_bOnlyActive,
                                               StatMsg p_smResult)
        {
            try {
                // Pedimos el registro de la tabla: CliEntrevistas
                DataSet l_dsTemp= new DataSet();

                Dal.CliEntrevistas.Search(p_dbcAccess, 
                                          p_iNumcliente,
                                          p_iNumentrev,
                                          p_bOnlyActive,
                                          ref l_dsTemp, "Temporal",
                                          p_smResult);
                if (p_smResult.NOk) return null;

                // Constuimos la entidad y la devolvemos (si vino un registro)
                ECliEntrevista l_entRet= null;

                if (l_dsTemp.Tables["Temporal"].Rows.Count == 1)
                    l_entRet= new ECliEntrevista(l_dsTemp.Tables["Temporal"].Rows[0]);

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
        /// Devuelve una lista-entidad: LECliEntrevistas
        /// a partir de una clave foranea de la tabla: CliEntrevistas
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Número de cliente</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static LECliEntrevistas CleFSch(DBConn p_dbcAccess,
                                                 int p_iNumcliente,
                                                 bool p_bOnlyActive,
                                                 StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            try {
                // Pedimos los registros de la tabla por Foreing Key
                Dal.CliEntrevistas.FSearch(p_dbcAccess,
                                           p_iNumcliente,
                                           p_bOnlyActive,
                                           ref l_dsTemp, "Temporal",
                                           p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.CliEntrevistas.MakeGridCaptions(ref l_dsTemp, "Temporal", p_smResult);

                // Contruimos la lista-entidad y la devolvemos
                LECliEntrevistas l_entRet= new LECliEntrevistas(l_dsTemp.Tables["Temporal"]);
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
        /// Agrega o modifica un registro de la tabla: CliEntrevistas
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCliEntrevista">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CleSSav(DBConn p_dbcAccess,
                                     ECliEntrevista p_entCliEntrevista,
                                     StatMsg p_smResult)
        {
            try {
                // Procesamos codigo fijo
                CleSave_f(p_dbcAccess, ref p_entCliEntrevista, p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                CleVKey(p_dbcAccess, 
                        p_entCliEntrevista.Numcliente,
                        p_entCliEntrevista.Numentrev,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entCliEntrevista.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El ítem (CliEntrevista) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    CleInsr(p_dbcAccess, p_entCliEntrevista, p_smResult);
                    return;
                }

                // Es un update. La clave debe existir y estar habilitada
                if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                    // Error. La clave no existe o no está habilitada
                    p_smResult.BllWarning("El ítem (CliEntrevista) que intenta modificar no existe en el sistema o no está habilitado.","");
                    return;
                }

                // Debe coincidir el número de version
                CleVVer(p_dbcAccess, 
                        p_entCliEntrevista.Numcliente,
                        p_entCliEntrevista.Numentrev,
                        p_entCliEntrevista.FxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos el registro
                CleUpdt(p_dbcAccess, p_entCliEntrevista, p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Agrega un registro a la tabla a partir de una entidad: ECliEntrevista
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCliEntrevista">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CleInsr(DBConn p_dbcAccess,
                                     ECliEntrevista p_entCliEntrevista,
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                CleTInt(p_dbcAccess, p_entCliEntrevista, p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: CliEntrevistas
                Dal.CliEntrevistas.Insert(p_dbcAccess,
                                          p_entCliEntrevista.Numcliente,
                                          p_entCliEntrevista.Numentrev,
                                          p_entCliEntrevista.Fcoordinada,
                                          p_entCliEntrevista.Frealizada,
                                          p_entCliEntrevista.Codvend,
                                          p_entCliEntrevista.Motcambiof,
                                          p_entCliEntrevista.Nombre,
                                          p_entCliEntrevista.Telefono,
                                          p_entCliEntrevista.Cargo,
                                          p_entCliEntrevista.Titulo,
                                          p_entCliEntrevista.Celular,
                                          p_entCliEntrevista.Email,
                                          p_entCliEntrevista.Direccion,
                                          p_entCliEntrevista.Observaciones,
                                          p_entCliEntrevista.Codresultado,
                                          p_entCliEntrevista.Informe,
                                          p_entCliEntrevista.Secretaria,
                                          p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Actualiza un registro a la tabla a partir de una entidad: ECliEntrevista
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCliEntrevista">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CleUpdt(DBConn p_dbcAccess,
                                     ECliEntrevista p_entCliEntrevista,
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                CleTInt(p_dbcAccess, p_entCliEntrevista, p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: CliEntrevistas
                Dal.CliEntrevistas.Update(p_dbcAccess,
                                          p_entCliEntrevista.Numcliente,
                                          p_entCliEntrevista.Numentrev,
                                          p_entCliEntrevista.Fcoordinada,
                                          p_entCliEntrevista.Frealizada,
                                          p_entCliEntrevista.Codvend,
                                          p_entCliEntrevista.Motcambiof,
                                          p_entCliEntrevista.Nombre,
                                          p_entCliEntrevista.Telefono,
                                          p_entCliEntrevista.Cargo,
                                          p_entCliEntrevista.Titulo,
                                          p_entCliEntrevista.Celular,
                                          p_entCliEntrevista.Email,
                                          p_entCliEntrevista.Direccion,
                                          p_entCliEntrevista.Observaciones,
                                          p_entCliEntrevista.Codresultado,
                                          p_entCliEntrevista.Informe,
                                          p_entCliEntrevista.Secretaria,
                                          p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra físicamente un registro de a tabla: CliEntrevistas
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Número de cliente</param>
        /// <param name="p_iNumentrev">Número</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CleDrop(DBConn p_dbcAccess,
                                     int p_iNumcliente,
                                     int p_iNumentrev,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            try {
                // Verificamos la clave a borrar
                CleVKey(p_dbcAccess,
                        p_iNumcliente,
                        p_iNumentrev,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (CliEntrevista) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                CleVVer(p_dbcAccess, 
                        p_iNumcliente,
                        p_iNumentrev,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Borramos físicamente el registro
                Dal.CliEntrevistas.Drop(p_dbcAccess,
                                        p_iNumcliente,
                                        p_iNumentrev,
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
        internal static void ClePack(DBConn p_dbcAccess,
                                     StatMsg p_smResult)
        {
            try {
                // Borramos los borrados lógicamente
                Dal.CliEntrevistas.Pack(p_dbcAccess,
                                        p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Realiza una actualización inteligente de la tabla a partir de una
        /// lista-entidad: LECliEntrevistas
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Número de cliente</param>
        /// <param name="p_lentCliEntrevistas">Lista-entidad a actualizar sobre la tabla</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CleSSav(DBConn p_dbcAccess,
                                     int p_iNumcliente,
                                      LECliEntrevistas p_lentCliEntrevistas,
                                      StatMsg p_smResult)
        {
            try {
                // Deshabilitamos todas las entidades existentes
                Dal.CliEntrevistas.FDrop(p_dbcAccess,
                                         p_iNumcliente,
                                         p_smResult);
                if (p_smResult.NOk) return;

                // Recorremos la lista de entidades
                foreach (ECliEntrevista l_entCliEntrevista in p_lentCliEntrevistas) {
                    // Forzamos la clave foranea
                    l_entCliEntrevista.Numcliente= p_iNumcliente;

                    // Verificamos si existe
                    CleVKey(p_dbcAccess,
                            l_entCliEntrevista.Numcliente,
                            l_entCliEntrevista.Numentrev,
                            p_smResult);
                    if (p_smResult.NOk) return;

                    // Si no existe
                    if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Hay que darla de alta
                        CleInsr(p_dbcAccess, l_entCliEntrevista, p_smResult);
                        if (p_smResult.NOk) return;
                        continue;
                    }

                    // Existe. Debe coincidir el número de version
                    CleVVer(p_dbcAccess, 
                            l_entCliEntrevista.Numcliente,
                            l_entCliEntrevista.Numentrev,
                            l_entCliEntrevista.FxdVersion,
                            p_smResult);
                    if (p_smResult.NOk) return;

                    // El número coincide. La Actualizamos si no está borrada
                    if (!l_entCliEntrevista.EstaBorrada) {
                        CleUpdt(p_dbcAccess, l_entCliEntrevista, p_smResult);
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

        /// <summary>
        /// Ejecuta el SP definido por el usuario: BorraPorCliente
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_iNrocliente>Numero de cliente a borrar entrevistas</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CleBorraPorCliente(DBConn p_dbcAccess,
                                                int p_iNrocliente,
                                                StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                Dal.CliEntrevistas.BorraPorCliente(p_dbcAccess,
                                                   p_iNrocliente,
                                                   p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion
                p_smResult.BllError(l_expData);
            }
            finally {
                // Terminamos
            }
        }

        /// <summary>
        /// Ejecuta el SP definido por el usuario: GetCodVend
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_iNrocliente>Numero del Cliente</param>
        /// <param name= p_iNroentrev>Numero de la Entrevista</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades CleGetCodVend(DBConn p_dbcAccess,
                                                     int p_iNrocliente,
                                                     int p_iNroentrev,
                                                     StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.CliEntrevistas.GetCodVend(p_dbcAccess,
                                              p_iNrocliente,
                                              p_iNroentrev,
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
        /// Ejecuta el SP definido por el usuario: GetEntrevPendVend
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_strCodvend>Código de vendedor</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static LECliEntrevistas CleGetEntrevPendVend(DBConn p_dbcAccess,
                                                              string p_strCodvend,
                                                              StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.CliEntrevistas.GetEntrevPendVend(p_dbcAccess,
                                                     p_strCodvend,
                                                     ref l_dsTemp,
                                                     "Temporal",
                                                     p_smResult);
                if (p_smResult.NOk) return null;

                // Captionamos el resultado
                Dal.CliEntrevistas.MakeGridCaptions(ref l_dsTemp, "Temporal", p_smResult);
                if (p_smResult.NOk) return null;

                // Creamos la ListaEntidad y la devolvemos
                LECliEntrevistas l_lentRet= new LECliEntrevistas(l_dsTemp.Tables["Temporal"]);
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
        /// Ejecuta el SP definido por el usuario: GetEntrevistasCli
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_iCliente>Numero del Cliente</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static LECliEntrevistas CleGetEntrevistasCli(DBConn p_dbcAccess,
                                                              int p_iCliente,
                                                              StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.CliEntrevistas.GetEntrevistasCli(p_dbcAccess,
                                                     p_iCliente,
                                                     ref l_dsTemp,
                                                     "Temporal",
                                                     p_smResult);
                if (p_smResult.NOk) return null;

                // Captionamos el resultado
                Dal.CliEntrevistas.MakeGridCaptions(ref l_dsTemp, "Temporal", p_smResult);
                if (p_smResult.NOk) return null;

                // Creamos la ListaEntidad y la devolvemos
                LECliEntrevistas l_lentRet= new LECliEntrevistas(l_dsTemp.Tables["Temporal"]);
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
        /// Ejecuta el SP definido por el usuario: GetEntrevistasIncom
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_iNumcliente>Número de cliente</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades CleGetEntrevistasIncom(DBConn p_dbcAccess,
                                                              int p_iNumcliente,
                                                              StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.CliEntrevistas.GetEntrevistasIncom(p_dbcAccess,
                                                       p_iNumcliente,
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
        /// Ejecuta el SP definido por el usuario: GetEntrevistasPend
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_strCodvend>Código de vendedor</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades CleGetEntrevistasPend(DBConn p_dbcAccess,
                                                             string p_strCodvend,
                                                             StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.CliEntrevistas.GetEntrevistasPend(p_dbcAccess,
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
        /// Ejecuta el SP definido por el usuario: GetEntrevistasVenc
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_strCodvend>Código de vendedor</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades CleGetEntrevistasVenc(DBConn p_dbcAccess,
                                                             string p_strCodvend,
                                                             StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.CliEntrevistas.GetEntrevistasVenc(p_dbcAccess,
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
        /// Ejecuta el SP definido por el usuario: SaveCompletarEntrev
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_dtFrealizada>Fecha realizada</param>
        /// <param name= p_iNumentrev>Número de entrevista</param>
        /// <param name= p_strMotivo>Motivo de cambio de fecha</param>
        /// <param name= p_strInforme>Informe de resultado</param>
        /// <param name= p_strCodresultado>Codigo del Resultado de la entrev.</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CleSaveCompletarEntrev(DBConn p_dbcAccess,
                                                    DateTime p_dtFrealizada,
                                                    int p_iNumentrev,
                                                    string p_strMotivo,
                                                    string p_strInforme,
                                                    string p_strCodresultado,
                                                    StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                Dal.CliEntrevistas.SaveCompletarEntrev(p_dbcAccess,
                                                       p_dtFrealizada,
                                                       p_iNumentrev,
                                                       p_strMotivo,
                                                       p_strInforme,
                                                       p_strCodresultado,
                                                       p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion
                p_smResult.BllError(l_expData);
            }
            finally {
                // Terminamos
            }
        }
        #endregion


        //**********************************************************
        //
        // Funciones para la Tabla: CliGrupoFamiliar
        // Usando ClaseDal        : CliGrupoFamiliar
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos públicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: CliGrupoFamiliar
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LECliGrupoFamiliares</returns>
        public static LECliGrupoFamiliares CgfUpFull(bool p_bOnlyActive,
                                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                return CgfUpfl(l_dbcAccess, p_bOnlyActive, p_smResult);
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
        /// Devuelve una entidad: ECliGrupoFamiliar
        /// </summary>
        /// <param name="p_iNumcliente">Nro Cliente</param>
        /// <param name="p_iNumintegrante">Nro Integrante GF</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: ECliGrupoFamiliar</returns>
        public static ECliGrupoFamiliar CgfGet(int p_iNumcliente,
                                               int p_iNumintegrante,
                                               bool p_bOnlyActive,
                                               StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: ECliGrupoFamiliar
                return CgfSrch(l_dbcAccess,
                               p_iNumcliente,
                               p_iNumintegrante,
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
        /// Devuelve una lista-entidad: LECliGrupoFamiliares
        /// asociada a una Foreing key de la tabla: CliGrupoFamiliar
        /// </summary>
        /// <param name="p_iNumcliente">Nro Cliente</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-Entidad: LECliGrupoFamiliares</returns>
        public static LECliGrupoFamiliares CgfFGet(int p_iNumcliente,
                                                   bool p_bOnlyActive,
                                                   StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la lista-entidad: LECliGrupoFamiliares
                return CgfFSch(l_dbcAccess,
                               p_iNumcliente,
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
        /// Agrega o modifica un registro de la tabla: CliGrupoFamiliar
        /// </summary>
        /// <param name="p_entCliGrupoFamiliar">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void CgfSave(ECliGrupoFamiliar p_entCliGrupoFamiliar,
                                   StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: ECliGrupoFamiliar
                CgfSSav(l_dbcAccess, p_entCliGrupoFamiliar, p_smResult);
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
        /// Habilita/Deshabilita un registro de la tabla: CliGrupoFamiliar
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_iNumcliente">Nro Cliente</param>
        /// <param name="p_iNumintegrante">Nro Integrante GF</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void CgfEnabled(bool p_bEnable,
                                      int p_iNumcliente,
                                      int p_iNumintegrante,
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
                CgfEnabled_f(l_dbcAccess,
                             p_bEnable,
                             p_iNumcliente,
                             p_iNumintegrante,
                             ref p_iFxdVersion,
                             p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                CgfVKey(l_dbcAccess,
                        p_iNumcliente,
                        p_iNumintegrante,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (CliGrupoFamiliar) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                CgfVVer(l_dbcAccess, 
                        p_iNumcliente,
                        p_iNumintegrante,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.CliGrupoFamiliar.Recall(l_dbcAccess,
                                                p_iNumcliente,
                                                p_iNumintegrante,
                                                p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.CliGrupoFamiliar.Delete(l_dbcAccess,
                                                p_iNumcliente,
                                                p_iNumintegrante,
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
        /// Borra físicamento un registro de la tabla: CliGrupoFamiliar
        /// </summary>
        /// <param name="p_iNumcliente">Nro Cliente</param>
        /// <param name="p_iNumintegrante">Nro Integrante GF</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void CgfRemove(int p_iNumcliente,
                                     int p_iNumintegrante,
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
                CgfRemove_f(l_dbcAccess,
                            p_iNumcliente,
                            p_iNumintegrante,
                            p_iFxdVersion,
                            p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                CgfDrop(l_dbcAccess,
                        p_iNumcliente,
                        p_iNumintegrante,
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
        public static void CgfPurge(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Realizamos el borrado
                CgfPack(l_dbcAccess,
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
        /// Valida la integridad de una entidad: CliGrupoFamiliar
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCliGrupoFamiliar">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CgfTInt(DBConn p_dbcAccess,
                                     ECliGrupoFamiliar p_entCliGrupoFamiliar,
                                     StatMsg p_smResult)
        {
            // ********
            // Validaciones de los campos sin conexion
            // ********

            // ********
            // Validaciones de los campos con conexion
            // ********

            // Verificamos la clave foranea
            Clientes.VKey(p_dbcAccess,
                          p_entCliGrupoFamiliar.Numcliente,
                          p_smResult);
            if (p_smResult.NOk) return;

            // El registro tiene que existir
            if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                // Error. La clave foranea no existe
                p_smResult.BllWarning("La clave (Cliente) foranea no existe en el sistema.","");
                return;
            }

            // Llamamos a la funcion fija del usuario
            CgfTInt_f(p_dbcAccess, p_entCliGrupoFamiliar, p_smResult);
            if (p_smResult.NOk) return;
        }

        /// <summary>
        /// Verifica el número de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Nro Cliente</param>
        /// <param name="p_iNumintegrante">Nro Integrante GF</param>
        /// <param name="p_iFxdVersion">Número de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CgfVVer(DBConn p_dbcAccess,
                                     int p_iNumcliente,
                                     int p_iNumintegrante,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            // Verificamos el número de versión
            Dal.CliGrupoFamiliar.ChkVersion(p_dbcAccess,
                                            p_iNumcliente,
                                            p_iNumintegrante,
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
            p_smResult.BllWarning("El número de versión del registro del ítem (CliGrupoFamiliar) no coincide.\r\nOperación cancelada.","");
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: ECliGrupoFamiliar
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave está deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Nro Cliente</param>
        /// <param name="p_iNumintegrante">Nro Integrante GF</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CgfVKey(DBConn p_dbcAccess,
                                     int p_iNumcliente,
                                     int p_iNumintegrante,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            Dal.CliGrupoFamiliar.Search(p_dbcAccess,
                                        p_iNumcliente,
                                        p_iNumintegrante,
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
        /// Devuelve una Lista-entidad: LECliGrupoFamiliares
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LECliGrupoFamiliares</returns>
        internal static LECliGrupoFamiliares CgfUpfl(DBConn p_dbcAccess,
                                                      bool p_bOnlyActive,
                                                      StatMsg p_smResult)
        {
            try {
                // Pedimos los registros de la tabla: CliGrupoFamiliar
                DataSet l_dsTemp= new DataSet();

                Dal.CliGrupoFamiliar.Up(p_dbcAccess, 
                                        p_bOnlyActive,
                                        ref l_dsTemp, "Temporal",
                                        p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.CliGrupoFamiliar.MakeGridCaptions(ref l_dsTemp, "Temporal", p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LECliGrupoFamiliares l_lentRet= new LECliGrupoFamiliares(l_dsTemp.Tables["Temporal"]);
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
        /// Devuelve una entidad: ECliGrupoFamiliar
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Nro Cliente</param>
        /// <param name="p_iNumintegrante">Nro Integrante GF</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: ECliGrupoFamiliar</returns>
        internal static ECliGrupoFamiliar CgfSrch(DBConn p_dbcAccess,
                                                  int p_iNumcliente,
                                                  int p_iNumintegrante,
                                                  bool p_bOnlyActive,
                                                  StatMsg p_smResult)
        {
            try {
                // Pedimos el registro de la tabla: CliGrupoFamiliar
                DataSet l_dsTemp= new DataSet();

                Dal.CliGrupoFamiliar.Search(p_dbcAccess, 
                                            p_iNumcliente,
                                            p_iNumintegrante,
                                            p_bOnlyActive,
                                            ref l_dsTemp, "Temporal",
                                            p_smResult);
                if (p_smResult.NOk) return null;

                // Constuimos la entidad y la devolvemos (si vino un registro)
                ECliGrupoFamiliar l_entRet= null;

                if (l_dsTemp.Tables["Temporal"].Rows.Count == 1)
                    l_entRet= new ECliGrupoFamiliar(l_dsTemp.Tables["Temporal"].Rows[0]);

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
        /// Devuelve una lista-entidad: LECliGrupoFamiliares
        /// a partir de una clave foranea de la tabla: CliGrupoFamiliar
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Nro Cliente</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static LECliGrupoFamiliares CgfFSch(DBConn p_dbcAccess,
                                                     int p_iNumcliente,
                                                     bool p_bOnlyActive,
                                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            try {
                // Pedimos los registros de la tabla por Foreing Key
                Dal.CliGrupoFamiliar.FSearch(p_dbcAccess,
                                             p_iNumcliente,
                                             p_bOnlyActive,
                                             ref l_dsTemp, "Temporal",
                                             p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.CliGrupoFamiliar.MakeGridCaptions(ref l_dsTemp, "Temporal", p_smResult);

                // Contruimos la lista-entidad y la devolvemos
                LECliGrupoFamiliares l_entRet= new LECliGrupoFamiliares(l_dsTemp.Tables["Temporal"]);
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
        /// Agrega o modifica un registro de la tabla: CliGrupoFamiliar
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCliGrupoFamiliar">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CgfSSav(DBConn p_dbcAccess,
                                     ECliGrupoFamiliar p_entCliGrupoFamiliar,
                                     StatMsg p_smResult)
        {
            try {
                // Procesamos codigo fijo
                CgfSave_f(p_dbcAccess, ref p_entCliGrupoFamiliar, p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                CgfVKey(p_dbcAccess, 
                        p_entCliGrupoFamiliar.Numcliente,
                        p_entCliGrupoFamiliar.Numintegrante,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entCliGrupoFamiliar.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El ítem (CliGrupoFamiliar) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    CgfInsr(p_dbcAccess, p_entCliGrupoFamiliar, p_smResult);
                    return;
                }

                // Es un update. La clave debe existir y estar habilitada
                if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                    // Error. La clave no existe o no está habilitada
                    p_smResult.BllWarning("El ítem (CliGrupoFamiliar) que intenta modificar no existe en el sistema o no está habilitado.","");
                    return;
                }

                // Debe coincidir el número de version
                CgfVVer(p_dbcAccess, 
                        p_entCliGrupoFamiliar.Numcliente,
                        p_entCliGrupoFamiliar.Numintegrante,
                        p_entCliGrupoFamiliar.FxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos el registro
                CgfUpdt(p_dbcAccess, p_entCliGrupoFamiliar, p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Agrega un registro a la tabla a partir de una entidad: ECliGrupoFamiliar
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCliGrupoFamiliar">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CgfInsr(DBConn p_dbcAccess,
                                     ECliGrupoFamiliar p_entCliGrupoFamiliar,
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                CgfTInt(p_dbcAccess, p_entCliGrupoFamiliar, p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: CliGrupoFamiliar
                Dal.CliGrupoFamiliar.Insert(p_dbcAccess,
                                            p_entCliGrupoFamiliar.Numcliente,
                                            p_entCliGrupoFamiliar.Numintegrante,
                                            p_entCliGrupoFamiliar.Apellido,
                                            p_entCliGrupoFamiliar.Nombre,
                                            p_entCliGrupoFamiliar.Codparentesco,
                                            p_entCliGrupoFamiliar.Dni,
                                            p_entCliGrupoFamiliar.Fechanacimiento,
                                            p_entCliGrupoFamiliar.Obrasocial,
                                            p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Actualiza un registro a la tabla a partir de una entidad: ECliGrupoFamiliar
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCliGrupoFamiliar">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CgfUpdt(DBConn p_dbcAccess,
                                     ECliGrupoFamiliar p_entCliGrupoFamiliar,
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                CgfTInt(p_dbcAccess, p_entCliGrupoFamiliar, p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: CliGrupoFamiliar
                Dal.CliGrupoFamiliar.Update(p_dbcAccess,
                                            p_entCliGrupoFamiliar.Numcliente,
                                            p_entCliGrupoFamiliar.Numintegrante,
                                            p_entCliGrupoFamiliar.Apellido,
                                            p_entCliGrupoFamiliar.Nombre,
                                            p_entCliGrupoFamiliar.Codparentesco,
                                            p_entCliGrupoFamiliar.Dni,
                                            p_entCliGrupoFamiliar.Fechanacimiento,
                                            p_entCliGrupoFamiliar.Obrasocial,
                                            p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra físicamente un registro de a tabla: CliGrupoFamiliar
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Nro Cliente</param>
        /// <param name="p_iNumintegrante">Nro Integrante GF</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CgfDrop(DBConn p_dbcAccess,
                                     int p_iNumcliente,
                                     int p_iNumintegrante,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            try {
                // Verificamos la clave a borrar
                CgfVKey(p_dbcAccess,
                        p_iNumcliente,
                        p_iNumintegrante,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (CliGrupoFamiliar) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                CgfVVer(p_dbcAccess, 
                        p_iNumcliente,
                        p_iNumintegrante,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Borramos físicamente el registro
                Dal.CliGrupoFamiliar.Drop(p_dbcAccess,
                                          p_iNumcliente,
                                          p_iNumintegrante,
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
        internal static void CgfPack(DBConn p_dbcAccess,
                                     StatMsg p_smResult)
        {
            try {
                // Borramos los borrados lógicamente
                Dal.CliGrupoFamiliar.Pack(p_dbcAccess,
                                          p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Realiza una actualización inteligente de la tabla a partir de una
        /// lista-entidad: LECliGrupoFamiliares
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Nro Cliente</param>
        /// <param name="p_lentCliGrupoFamiliares">Lista-entidad a actualizar sobre la tabla</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CgfSSav(DBConn p_dbcAccess,
                                     int p_iNumcliente,
                                      LECliGrupoFamiliares p_lentCliGrupoFamiliares,
                                      StatMsg p_smResult)
        {
            try {
                // Deshabilitamos todas las entidades existentes
                Dal.CliGrupoFamiliar.FDrop(p_dbcAccess,
                                           p_iNumcliente,
                                           p_smResult);
                if (p_smResult.NOk) return;

                // Recorremos la lista de entidades
                foreach (ECliGrupoFamiliar l_entCliGrupoFamiliar in p_lentCliGrupoFamiliares) {
                    // Forzamos la clave foranea
                    l_entCliGrupoFamiliar.Numcliente= p_iNumcliente;

                    // Verificamos si existe
                    CgfVKey(p_dbcAccess,
                            l_entCliGrupoFamiliar.Numcliente,
                            l_entCliGrupoFamiliar.Numintegrante,
                            p_smResult);
                    if (p_smResult.NOk) return;

                    // Si no existe
                    if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Hay que darla de alta
                        CgfInsr(p_dbcAccess, l_entCliGrupoFamiliar, p_smResult);
                        if (p_smResult.NOk) return;
                        continue;
                    }

                    // Existe. Debe coincidir el número de version
                    CgfVVer(p_dbcAccess, 
                            l_entCliGrupoFamiliar.Numcliente,
                            l_entCliGrupoFamiliar.Numintegrante,
                            l_entCliGrupoFamiliar.FxdVersion,
                            p_smResult);
                    if (p_smResult.NOk) return;

                    // El número coincide. La Actualizamos si no está borrada
                    if (!l_entCliGrupoFamiliar.EstaBorrada) {
                        CgfUpdt(p_dbcAccess, l_entCliGrupoFamiliar, p_smResult);
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
        // Funciones para la Tabla: CliLlamadas
        // Usando ClaseDal        : CliLlamadas
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos públicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: CliLlamadas
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LECliLlamadas</returns>
        public static LECliLlamadas CllUpFull(bool p_bOnlyActive,
                                              StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                return CllUpfl(l_dbcAccess, p_bOnlyActive, p_smResult);
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
        /// Devuelve una entidad: ECliLlamada
        /// </summary>
        /// <param name="p_iNumcliente">Número de cliente</param>
        /// <param name="p_iNumllamada">Número de llamada</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: ECliLlamada</returns>
        public static ECliLlamada CllGet(int p_iNumcliente,
                                         int p_iNumllamada,
                                         bool p_bOnlyActive,
                                         StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: ECliLlamada
                return CllSrch(l_dbcAccess,
                               p_iNumcliente,
                               p_iNumllamada,
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
        /// Devuelve una lista-entidad: LECliLlamadas
        /// asociada a una Foreing key de la tabla: CliLlamadas
        /// </summary>
        /// <param name="p_iNumcliente">Número de cliente</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-Entidad: LECliLlamadas</returns>
        public static LECliLlamadas CllFGet(int p_iNumcliente,
                                            bool p_bOnlyActive,
                                            StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la lista-entidad: LECliLlamadas
                return CllFSch(l_dbcAccess,
                               p_iNumcliente,
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
        /// Agrega o modifica un registro de la tabla: CliLlamadas
        /// </summary>
        /// <param name="p_entCliLlamada">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void CllSave(ECliLlamada p_entCliLlamada,
                                   StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: ECliLlamada
                CllSSav(l_dbcAccess, p_entCliLlamada, p_smResult);
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
        /// Habilita/Deshabilita un registro de la tabla: CliLlamadas
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_iNumcliente">Número de cliente</param>
        /// <param name="p_iNumllamada">Número de llamada</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void CllEnabled(bool p_bEnable,
                                      int p_iNumcliente,
                                      int p_iNumllamada,
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
                CllEnabled_f(l_dbcAccess,
                             p_bEnable,
                             p_iNumcliente,
                             p_iNumllamada,
                             ref p_iFxdVersion,
                             p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                CllVKey(l_dbcAccess,
                        p_iNumcliente,
                        p_iNumllamada,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (CliLlamada) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                CllVVer(l_dbcAccess, 
                        p_iNumcliente,
                        p_iNumllamada,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.CliLlamadas.Recall(l_dbcAccess,
                                           p_iNumcliente,
                                           p_iNumllamada,
                                           p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.CliLlamadas.Delete(l_dbcAccess,
                                           p_iNumcliente,
                                           p_iNumllamada,
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
        /// Borra físicamento un registro de la tabla: CliLlamadas
        /// </summary>
        /// <param name="p_iNumcliente">Número de cliente</param>
        /// <param name="p_iNumllamada">Número de llamada</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void CllRemove(int p_iNumcliente,
                                     int p_iNumllamada,
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
                CllRemove_f(l_dbcAccess,
                            p_iNumcliente,
                            p_iNumllamada,
                            p_iFxdVersion,
                            p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                CllDrop(l_dbcAccess,
                        p_iNumcliente,
                        p_iNumllamada,
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
        public static void CllPurge(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Realizamos el borrado
                CllPack(l_dbcAccess,
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
        /// Ejecuta el SP definido por el usuario: GetProgramadas
        /// </summary>
        /// <param name= p_strCodusuario>Nombre codigo usuario</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        public static ListaEntidades CllGetProgramadas(string p_strCodusuario,
                                                       StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Abrimos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Llamamos al metodo interno
                return CllGetProgramadas(l_dbcAccess,
                                         p_strCodusuario,
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
        /// Ejecuta el SP definido por el usuario: ZBajasDetalle
        /// </summary>
        /// <param name= p_dtFechaini>Fecha Inicial</param>
        /// <param name= p_dtFechafin>Fecha Fin</param>
        /// <param name= p_strCodinimarca>Codigo Inicial Marca</param>
        /// <param name= p_strCodfinmarca>Codigo Fin Marca</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        public static ListaEntidades CllZBajasDetalle(DateTime p_dtFechaini,
                                                      DateTime p_dtFechafin,
                                                      string p_strCodinimarca,
                                                      string p_strCodfinmarca,
                                                      StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Abrimos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Llamamos al metodo interno
                return CllZBajasDetalle(l_dbcAccess,
                                        p_dtFechaini,
                                        p_dtFechafin,
                                        p_strCodinimarca,
                                        p_strCodfinmarca,
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
        /// Ejecuta el SP definido por el usuario: ZBajasGral
        /// </summary>
        /// <param name= p_dtFechaini>Fecha Inicial</param>
        /// <param name= p_dtFechafin>Fecha Fin</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        public static ListaEntidades CllZBajasGral(DateTime p_dtFechaini,
                                                   DateTime p_dtFechafin,
                                                   StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Abrimos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Llamamos al metodo interno
                return CllZBajasGral(l_dbcAccess,
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
        /// Ejecuta el SP definido por el usuario: ZReajustesXClieXAnio
        /// </summary>
        /// <param name= p_iNroavalon>Numero de Avalon</param>
        /// <param name= p_iAnio>Anio a obtener historico</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        public static ListaEntidades CllZReajustesXClieXAnio(int p_iNroavalon,
                                                             int p_iAnio,
                                                             StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Abrimos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Llamamos al metodo interno
                return CllZReajustesXClieXAnio(l_dbcAccess,
                                               p_iNroavalon,
                                               p_iAnio,
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
        /// Ejecuta el SP definido por el usuario: ZReajustesXMes
        /// </summary>
        /// <param name= p_iAnio>Anio</param>
        /// <param name= p_iMes>Mes</param>
        /// <param name= p_strInicodmarca>Inicio Codigo Marca</param>
        /// <param name= p_strEndcodmarca>End Codigo Marca</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        public static ListaEntidades CllZReajustesXMes(int p_iAnio,
                                                       int p_iMes,
                                                       string p_strInicodmarca,
                                                       string p_strEndcodmarca,
                                                       StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Abrimos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Llamamos al metodo interno
                return CllZReajustesXMes(l_dbcAccess,
                                         p_iAnio,
                                         p_iMes,
                                         p_strInicodmarca,
                                         p_strEndcodmarca,
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
        /// Ejecuta el SP definido por el usuario: ZReclamosDetalle
        /// </summary>
        /// <param name= p_dtFechaini>Fecha Inicial</param>
        /// <param name= p_dtFechafin>Fecha Fin</param>
        /// <param name= p_strCodmarcaini>Codigo Marca Inicial</param>
        /// <param name= p_strCodmarcafin>Codigo Marca Fin</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        public static ListaEntidades CllZReclamosDetalle(DateTime p_dtFechaini,
                                                         DateTime p_dtFechafin,
                                                         string p_strCodmarcaini,
                                                         string p_strCodmarcafin,
                                                         StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Abrimos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Llamamos al metodo interno
                return CllZReclamosDetalle(l_dbcAccess,
                                           p_dtFechaini,
                                           p_dtFechafin,
                                           p_strCodmarcaini,
                                           p_strCodmarcafin,
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
        /// Ejecuta el SP definido por el usuario: ZReclamosGral
        /// </summary>
        /// <param name= p_dtFechaini>Fecha Inicial</param>
        /// <param name= p_dtFechafin>Fecha Fin</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        public static ListaEntidades CllZReclamosGral(DateTime p_dtFechaini,
                                                      DateTime p_dtFechafin,
                                                      StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Abrimos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Llamamos al metodo interno
                return CllZReclamosGral(l_dbcAccess,
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
        /// Ejecuta el SP definido por el usuario: ZRecuperosDetalle
        /// </summary>
        /// <param name= p_dtFechaini>Fecha Inicial</param>
        /// <param name= p_dtFechafin>Fecha Fin</param>
        /// <param name= p_strCodmarcaini>Codigo Marca Inicial</param>
        /// <param name= p_strCodmarcafin>Codigo Marca Fin</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        public static ListaEntidades CllZRecuperosDetalle(DateTime p_dtFechaini,
                                                          DateTime p_dtFechafin,
                                                          string p_strCodmarcaini,
                                                          string p_strCodmarcafin,
                                                          StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Abrimos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Llamamos al metodo interno
                return CllZRecuperosDetalle(l_dbcAccess,
                                            p_dtFechaini,
                                            p_dtFechafin,
                                            p_strCodmarcaini,
                                            p_strCodmarcafin,
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
        /// Ejecuta el SP definido por el usuario: ZRecuperosGral
        /// </summary>
        /// <param name= p_dtFechaini>Fecha Inicial</param>
        /// <param name= p_dtFechafin>Fecha Fin</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        public static ListaEntidades CllZRecuperosGral(DateTime p_dtFechaini,
                                                       DateTime p_dtFechafin,
                                                       StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Abrimos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Llamamos al metodo interno
                return CllZRecuperosGral(l_dbcAccess,
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
        #endregion

        //---------------------------------------------------------------
        // Metodos públicos de la clase (no visibles para la UIL)
        //---------------------------------------------------------------

        #region Metodos internos de validacion

        /// <summary>
        /// Valida la integridad de una entidad: CliLlamada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCliLlamada">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CllTInt(DBConn p_dbcAccess,
                                     ECliLlamada p_entCliLlamada,
                                     StatMsg p_smResult)
        {
            // ********
            // Validaciones de los campos sin conexion
            // ********

            if (p_entCliLlamada.Numcliente <= 0) {
                // El campo [Número de cliente] debe ser mayor a cero
                p_smResult.BllWarning("El dato [Número de cliente] debe ser mayor a cero","");
                return;
            }

            if (p_entCliLlamada.Numllamada <= 0) {
                // El campo [Número de llamada] debe ser mayor a cero
                p_smResult.BllWarning("El dato [Número de llamada] debe ser mayor a cero","");
                return;
            }

            if (p_entCliLlamada.Frealizada.Year == 1900) {
                // El campo [Fecha Realizada] no puede ser vacío
                p_smResult.BllWarning("El dato [Fecha Realizada] no puede ser vacío","");
                return;
            }

            if (p_entCliLlamada.Codusuario.Trim() == "") {
                // El campo [Código del usuario] no puede ser vacío
                p_smResult.BllWarning("El dato [Código del usuario] no puede ser vacío","");
                return;
            }

            if ((p_entCliLlamada.Baja != "S") &&
                (p_entCliLlamada.Baja != "N")) {
                // El campo [Produjo Baja] tiene opciones
                p_smResult.BllWarning("El dato [Produjo Baja] sólo admite\r\n\r\n[S]- SI\r\n[N]- NO\r\n","");
                return;
            }

            if (p_entCliLlamada.Numcontacto <= 0) {
                // El campo [Número de contacto] debe ser mayor a cero
                p_smResult.BllWarning("El dato [Número de contacto] debe ser mayor a cero","");
                return;
            }

            // ********
            // Validaciones de los campos con conexion
            // ********

            if (p_entCliLlamada.Codmotivo.Trim() != "") {
                Tablas.MtlVKey(p_dbcAccess,
                               p_entCliLlamada.Codmotivo,
                               p_smResult);
                if (p_smResult.NOk) return;

                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // El campo [Código de motivo] debe existir en la tabla [Tablas.Mtl]
                    p_smResult.BllWarning("El dato [Código de motivo] debe existir en la tabla [Tablas.Mtl]","");
                    return;
                }
            }

            // Verificamos la clave foranea
            Clientes.VKey(p_dbcAccess,
                          p_entCliLlamada.Numcliente,
                          p_smResult);
            if (p_smResult.NOk) return;

            // El registro tiene que existir
            if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                // Error. La clave foranea no existe
                p_smResult.BllWarning("La clave (Cliente) foranea no existe en el sistema.","");
                return;
            }

            // Todas las validaciones fueron correctas

            // Llamamos a la funcion fija del usuario
            CllTInt_f(p_dbcAccess, p_entCliLlamada, p_smResult);
            if (p_smResult.NOk) return;
        }

        /// <summary>
        /// Verifica el número de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Número de cliente</param>
        /// <param name="p_iNumllamada">Número de llamada</param>
        /// <param name="p_iFxdVersion">Número de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CllVVer(DBConn p_dbcAccess,
                                     int p_iNumcliente,
                                     int p_iNumllamada,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            // Verificamos el número de versión
            Dal.CliLlamadas.ChkVersion(p_dbcAccess,
                                       p_iNumcliente,
                                       p_iNumllamada,
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
            p_smResult.BllWarning("El número de versión del registro del ítem (CliLlamada) no coincide.\r\nOperación cancelada.","");
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: ECliLlamada
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave está deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Número de cliente</param>
        /// <param name="p_iNumllamada">Número de llamada</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CllVKey(DBConn p_dbcAccess,
                                     int p_iNumcliente,
                                     int p_iNumllamada,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            Dal.CliLlamadas.Search(p_dbcAccess,
                                   p_iNumcliente,
                                   p_iNumllamada,
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
        /// Devuelve una Lista-entidad: LECliLlamadas
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LECliLlamadas</returns>
        internal static LECliLlamadas CllUpfl(DBConn p_dbcAccess,
                                               bool p_bOnlyActive,
                                               StatMsg p_smResult)
        {
            try {
                // Pedimos los registros de la tabla: CliLlamadas
                DataSet l_dsTemp= new DataSet();

                Dal.CliLlamadas.Up(p_dbcAccess, 
                                   p_bOnlyActive,
                                   ref l_dsTemp, "Temporal",
                                   p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.CliLlamadas.MakeGridCaptions(ref l_dsTemp, "Temporal", p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LECliLlamadas l_lentRet= new LECliLlamadas(l_dsTemp.Tables["Temporal"]);
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
        /// Devuelve una entidad: ECliLlamada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Número de cliente</param>
        /// <param name="p_iNumllamada">Número de llamada</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: ECliLlamada</returns>
        internal static ECliLlamada CllSrch(DBConn p_dbcAccess,
                                            int p_iNumcliente,
                                            int p_iNumllamada,
                                            bool p_bOnlyActive,
                                            StatMsg p_smResult)
        {
            try {
                // Pedimos el registro de la tabla: CliLlamadas
                DataSet l_dsTemp= new DataSet();

                Dal.CliLlamadas.Search(p_dbcAccess, 
                                       p_iNumcliente,
                                       p_iNumllamada,
                                       p_bOnlyActive,
                                       ref l_dsTemp, "Temporal",
                                       p_smResult);
                if (p_smResult.NOk) return null;

                // Constuimos la entidad y la devolvemos (si vino un registro)
                ECliLlamada l_entRet= null;

                if (l_dsTemp.Tables["Temporal"].Rows.Count == 1)
                    l_entRet= new ECliLlamada(l_dsTemp.Tables["Temporal"].Rows[0]);

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
        /// Devuelve una lista-entidad: LECliLlamadas
        /// a partir de una clave foranea de la tabla: CliLlamadas
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Número de cliente</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static LECliLlamadas CllFSch(DBConn p_dbcAccess,
                                              int p_iNumcliente,
                                              bool p_bOnlyActive,
                                              StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            try {
                // Pedimos los registros de la tabla por Foreing Key
                Dal.CliLlamadas.FSearch(p_dbcAccess,
                                        p_iNumcliente,
                                        p_bOnlyActive,
                                        ref l_dsTemp, "Temporal",
                                        p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.CliLlamadas.MakeGridCaptions(ref l_dsTemp, "Temporal", p_smResult);

                // Contruimos la lista-entidad y la devolvemos
                LECliLlamadas l_entRet= new LECliLlamadas(l_dsTemp.Tables["Temporal"]);
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
        /// Agrega o modifica un registro de la tabla: CliLlamadas
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCliLlamada">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CllSSav(DBConn p_dbcAccess,
                                     ECliLlamada p_entCliLlamada,
                                     StatMsg p_smResult)
        {
            try {
                // Procesamos codigo fijo
                CllSave_f(p_dbcAccess, ref p_entCliLlamada, p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                CllVKey(p_dbcAccess, 
                        p_entCliLlamada.Numcliente,
                        p_entCliLlamada.Numllamada,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entCliLlamada.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El ítem (CliLlamada) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    CllInsr(p_dbcAccess, p_entCliLlamada, p_smResult);
                    return;
                }

                // Es un update. La clave debe existir y estar habilitada
                if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                    // Error. La clave no existe o no está habilitada
                    p_smResult.BllWarning("El ítem (CliLlamada) que intenta modificar no existe en el sistema o no está habilitado.","");
                    return;
                }

                // Debe coincidir el número de version
                CllVVer(p_dbcAccess, 
                        p_entCliLlamada.Numcliente,
                        p_entCliLlamada.Numllamada,
                        p_entCliLlamada.FxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos el registro
                CllUpdt(p_dbcAccess, p_entCliLlamada, p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Agrega un registro a la tabla a partir de una entidad: ECliLlamada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCliLlamada">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CllInsr(DBConn p_dbcAccess,
                                     ECliLlamada p_entCliLlamada,
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                CllTInt(p_dbcAccess, p_entCliLlamada, p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: CliLlamadas
                Dal.CliLlamadas.Insert(p_dbcAccess,
                                       p_entCliLlamada.Numcliente,
                                       p_entCliLlamada.Numllamada,
                                       p_entCliLlamada.Codmotivo,
                                       p_entCliLlamada.Frealizada,
                                       p_entCliLlamada.Resultado,
                                       p_entCliLlamada.Codusuario,
                                       p_entCliLlamada.Baja,
                                       p_entCliLlamada.Numcontacto,
                                       p_entCliLlamada.Obsprogramada,
                                       p_entCliLlamada.Abonoanterior,
                                       p_entCliLlamada.Abonorecuperado,
                                       p_entCliLlamada.Programador,
                                       p_entCliLlamada.Ajuste,
                                       p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Actualiza un registro a la tabla a partir de una entidad: ECliLlamada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCliLlamada">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CllUpdt(DBConn p_dbcAccess,
                                     ECliLlamada p_entCliLlamada,
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                CllTInt(p_dbcAccess, p_entCliLlamada, p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: CliLlamadas
                Dal.CliLlamadas.Update(p_dbcAccess,
                                       p_entCliLlamada.Numcliente,
                                       p_entCliLlamada.Numllamada,
                                       p_entCliLlamada.Codmotivo,
                                       p_entCliLlamada.Frealizada,
                                       p_entCliLlamada.Resultado,
                                       p_entCliLlamada.Codusuario,
                                       p_entCliLlamada.Baja,
                                       p_entCliLlamada.Numcontacto,
                                       p_entCliLlamada.Obsprogramada,
                                       p_entCliLlamada.Abonoanterior,
                                       p_entCliLlamada.Abonorecuperado,
                                       p_entCliLlamada.Programador,
                                       p_entCliLlamada.Ajuste,
                                       p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra físicamente un registro de a tabla: CliLlamadas
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Número de cliente</param>
        /// <param name="p_iNumllamada">Número de llamada</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CllDrop(DBConn p_dbcAccess,
                                     int p_iNumcliente,
                                     int p_iNumllamada,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            try {
                // Verificamos la clave a borrar
                CllVKey(p_dbcAccess,
                        p_iNumcliente,
                        p_iNumllamada,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (CliLlamada) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                CllVVer(p_dbcAccess, 
                        p_iNumcliente,
                        p_iNumllamada,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Borramos físicamente el registro
                Dal.CliLlamadas.Drop(p_dbcAccess,
                                     p_iNumcliente,
                                     p_iNumllamada,
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
        internal static void CllPack(DBConn p_dbcAccess,
                                     StatMsg p_smResult)
        {
            try {
                // Borramos los borrados lógicamente
                Dal.CliLlamadas.Pack(p_dbcAccess,
                                     p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Realiza una actualización inteligente de la tabla a partir de una
        /// lista-entidad: LECliLlamadas
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Número de cliente</param>
        /// <param name="p_lentCliLlamadas">Lista-entidad a actualizar sobre la tabla</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CllSSav(DBConn p_dbcAccess,
                                     int p_iNumcliente,
                                      LECliLlamadas p_lentCliLlamadas,
                                      StatMsg p_smResult)
        {
            try {
                // Deshabilitamos todas las entidades existentes
                Dal.CliLlamadas.FDrop(p_dbcAccess,
                                      p_iNumcliente,
                                      p_smResult);
                if (p_smResult.NOk) return;

                // Recorremos la lista de entidades
                foreach (ECliLlamada l_entCliLlamada in p_lentCliLlamadas) {
                    // Forzamos la clave foranea
                    l_entCliLlamada.Numcliente= p_iNumcliente;

                    // Verificamos si existe
                    CllVKey(p_dbcAccess,
                            l_entCliLlamada.Numcliente,
                            l_entCliLlamada.Numllamada,
                            p_smResult);
                    if (p_smResult.NOk) return;

                    // Si no existe
                    if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Hay que darla de alta
                        CllInsr(p_dbcAccess, l_entCliLlamada, p_smResult);
                        if (p_smResult.NOk) return;
                        continue;
                    }

                    // Existe. Debe coincidir el número de version
                    CllVVer(p_dbcAccess, 
                            l_entCliLlamada.Numcliente,
                            l_entCliLlamada.Numllamada,
                            l_entCliLlamada.FxdVersion,
                            p_smResult);
                    if (p_smResult.NOk) return;

                    // El número coincide. La Actualizamos si no está borrada
                    if (!l_entCliLlamada.EstaBorrada) {
                        CllUpdt(p_dbcAccess, l_entCliLlamada, p_smResult);
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

        /// <summary>
        /// Ejecuta el SP definido por el usuario: BorraPorCliente
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_iNrocliente>Numero del cliente a borrar las llamadas</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CllBorraPorCliente(DBConn p_dbcAccess,
                                                int p_iNrocliente,
                                                StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                Dal.CliLlamadas.BorraPorCliente(p_dbcAccess,
                                                p_iNrocliente,
                                                p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion
                p_smResult.BllError(l_expData);
            }
            finally {
                // Terminamos
            }
        }

        /// <summary>
        /// Ejecuta el SP definido por el usuario: GetLlamadProgVend
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_strCodusuario>Nombre codigo usuario</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static LECliLlamadas CllGetLlamadProgVend(DBConn p_dbcAccess,
                                                           string p_strCodusuario,
                                                           StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.CliLlamadas.GetLlamadProgVend(p_dbcAccess,
                                                  p_strCodusuario,
                                                  ref l_dsTemp,
                                                  "Temporal",
                                                  p_smResult);
                if (p_smResult.NOk) return null;

                // Captionamos el resultado
                Dal.CliLlamadas.MakeGridCaptions(ref l_dsTemp, "Temporal", p_smResult);
                if (p_smResult.NOk) return null;

                // Creamos la ListaEntidad y la devolvemos
                LECliLlamadas l_lentRet= new LECliLlamadas(l_dsTemp.Tables["Temporal"]);
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
        /// Ejecuta el SP definido por el usuario: GetProgramadas
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_strCodusuario>Nombre codigo usuario</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades CllGetProgramadas(DBConn p_dbcAccess,
                                                         string p_strCodusuario,
                                                         StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.CliLlamadas.GetProgramadas(p_dbcAccess,
                                               p_strCodusuario,
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
        /// Ejecuta el SP definido por el usuario: ZBajasDetalle
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_dtFechaini>Fecha Inicial</param>
        /// <param name= p_dtFechafin>Fecha Fin</param>
        /// <param name= p_strCodinimarca>Codigo Inicial Marca</param>
        /// <param name= p_strCodfinmarca>Codigo Fin Marca</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades CllZBajasDetalle(DBConn p_dbcAccess,
                                                        DateTime p_dtFechaini,
                                                        DateTime p_dtFechafin,
                                                        string p_strCodinimarca,
                                                        string p_strCodfinmarca,
                                                        StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.CliLlamadas.ZBajasDetalle(p_dbcAccess,
                                              p_dtFechaini,
                                              p_dtFechafin,
                                              p_strCodinimarca,
                                              p_strCodfinmarca,
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
        /// Ejecuta el SP definido por el usuario: ZBajasGral
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_dtFechaini>Fecha Inicial</param>
        /// <param name= p_dtFechafin>Fecha Fin</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades CllZBajasGral(DBConn p_dbcAccess,
                                                     DateTime p_dtFechaini,
                                                     DateTime p_dtFechafin,
                                                     StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.CliLlamadas.ZBajasGral(p_dbcAccess,
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
        /// Ejecuta el SP definido por el usuario: ZReajustesXClieXAnio
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_iNroavalon>Numero de Avalon</param>
        /// <param name= p_iAnio>Anio a obtener historico</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades CllZReajustesXClieXAnio(DBConn p_dbcAccess,
                                                               int p_iNroavalon,
                                                               int p_iAnio,
                                                               StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.CliLlamadas.ZReajustesXClieXAnio(p_dbcAccess,
                                                     p_iNroavalon,
                                                     p_iAnio,
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
        /// Ejecuta el SP definido por el usuario: ZReajustesXMes
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_iAnio>Anio</param>
        /// <param name= p_iMes>Mes</param>
        /// <param name= p_strInicodmarca>Inicio Codigo Marca</param>
        /// <param name= p_strEndcodmarca>End Codigo Marca</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades CllZReajustesXMes(DBConn p_dbcAccess,
                                                         int p_iAnio,
                                                         int p_iMes,
                                                         string p_strInicodmarca,
                                                         string p_strEndcodmarca,
                                                         StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.CliLlamadas.ZReajustesXMes(p_dbcAccess,
                                               p_iAnio,
                                               p_iMes,
                                               p_strInicodmarca,
                                               p_strEndcodmarca,
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
        /// Ejecuta el SP definido por el usuario: ZReclamosDetalle
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_dtFechaini>Fecha Inicial</param>
        /// <param name= p_dtFechafin>Fecha Fin</param>
        /// <param name= p_strCodmarcaini>Codigo Marca Inicial</param>
        /// <param name= p_strCodmarcafin>Codigo Marca Fin</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades CllZReclamosDetalle(DBConn p_dbcAccess,
                                                           DateTime p_dtFechaini,
                                                           DateTime p_dtFechafin,
                                                           string p_strCodmarcaini,
                                                           string p_strCodmarcafin,
                                                           StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.CliLlamadas.ZReclamosDetalle(p_dbcAccess,
                                                 p_dtFechaini,
                                                 p_dtFechafin,
                                                 p_strCodmarcaini,
                                                 p_strCodmarcafin,
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
        /// Ejecuta el SP definido por el usuario: ZReclamosGral
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_dtFechaini>Fecha Inicial</param>
        /// <param name= p_dtFechafin>Fecha Fin</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades CllZReclamosGral(DBConn p_dbcAccess,
                                                        DateTime p_dtFechaini,
                                                        DateTime p_dtFechafin,
                                                        StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.CliLlamadas.ZReclamosGral(p_dbcAccess,
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
        /// Ejecuta el SP definido por el usuario: ZRecuperosDetalle
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_dtFechaini>Fecha Inicial</param>
        /// <param name= p_dtFechafin>Fecha Fin</param>
        /// <param name= p_strCodmarcaini>Codigo Marca Inicial</param>
        /// <param name= p_strCodmarcafin>Codigo Marca Fin</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades CllZRecuperosDetalle(DBConn p_dbcAccess,
                                                            DateTime p_dtFechaini,
                                                            DateTime p_dtFechafin,
                                                            string p_strCodmarcaini,
                                                            string p_strCodmarcafin,
                                                            StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.CliLlamadas.ZRecuperosDetalle(p_dbcAccess,
                                                  p_dtFechaini,
                                                  p_dtFechafin,
                                                  p_strCodmarcaini,
                                                  p_strCodmarcafin,
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
        /// Ejecuta el SP definido por el usuario: ZRecuperosGral
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_dtFechaini>Fecha Inicial</param>
        /// <param name= p_dtFechafin>Fecha Fin</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades CllZRecuperosGral(DBConn p_dbcAccess,
                                                         DateTime p_dtFechaini,
                                                         DateTime p_dtFechafin,
                                                         StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.CliLlamadas.ZRecuperosGral(p_dbcAccess,
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
        #endregion


        //**********************************************************
        //
        // Funciones para la Tabla: CliNotas
        // Usando ClaseDal        : CliNotas
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos públicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: CliNotas
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LECliNotas</returns>
        public static LECliNotas ClnUpFull(bool p_bOnlyActive,
                                           StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                return ClnUpfl(l_dbcAccess, p_bOnlyActive, p_smResult);
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
        /// Devuelve una entidad: ECliNota
        /// </summary>
        /// <param name="p_iNumcliente">Numero del Cliente</param>
        /// <param name="p_dtFechayhora">Fecha y Hora</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: ECliNota</returns>
        public static ECliNota ClnGet(int p_iNumcliente,
                                      DateTime p_dtFechayhora,
                                      bool p_bOnlyActive,
                                      StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: ECliNota
                return ClnSrch(l_dbcAccess,
                               p_iNumcliente,
                               p_dtFechayhora,
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
        /// Devuelve una lista-entidad: LECliNotas
        /// asociada a una Foreing key de la tabla: CliNotas
        /// </summary>
        /// <param name="p_iNumcliente">Numero del Cliente</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-Entidad: LECliNotas</returns>
        public static LECliNotas ClnFGet(int p_iNumcliente,
                                         bool p_bOnlyActive,
                                         StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la lista-entidad: LECliNotas
                return ClnFSch(l_dbcAccess,
                               p_iNumcliente,
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
        /// Agrega o modifica un registro de la tabla: CliNotas
        /// </summary>
        /// <param name="p_entCliNota">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void ClnSave(ECliNota p_entCliNota,
                                   StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: ECliNota
                ClnSSav(l_dbcAccess, p_entCliNota, p_smResult);
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
        /// Habilita/Deshabilita un registro de la tabla: CliNotas
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_iNumcliente">Numero del Cliente</param>
        /// <param name="p_dtFechayhora">Fecha y Hora</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void ClnEnabled(bool p_bEnable,
                                      int p_iNumcliente,
                                      DateTime p_dtFechayhora,
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
                ClnEnabled_f(l_dbcAccess,
                             p_bEnable,
                             p_iNumcliente,
                             p_dtFechayhora,
                             ref p_iFxdVersion,
                             p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                ClnVKey(l_dbcAccess,
                        p_iNumcliente,
                        p_dtFechayhora,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (CliNota) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                ClnVVer(l_dbcAccess, 
                        p_iNumcliente,
                        p_dtFechayhora,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.CliNotas.Recall(l_dbcAccess,
                                        p_iNumcliente,
                                        p_dtFechayhora,
                                        p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.CliNotas.Delete(l_dbcAccess,
                                        p_iNumcliente,
                                        p_dtFechayhora,
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
        /// Borra físicamento un registro de la tabla: CliNotas
        /// </summary>
        /// <param name="p_iNumcliente">Numero del Cliente</param>
        /// <param name="p_dtFechayhora">Fecha y Hora</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void ClnRemove(int p_iNumcliente,
                                     DateTime p_dtFechayhora,
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
                ClnRemove_f(l_dbcAccess,
                            p_iNumcliente,
                            p_dtFechayhora,
                            p_iFxdVersion,
                            p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                ClnDrop(l_dbcAccess,
                        p_iNumcliente,
                        p_dtFechayhora,
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
        public static void ClnPurge(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Realizamos el borrado
                ClnPack(l_dbcAccess,
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
        /// Ejecuta el SP definido por el usuario: CantidadNotas
        /// </summary>
        /// <param name= p_iNrocliente>Numero del Cliente</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        public static ListaEntidades ClnCantidadNotas(int p_iNrocliente,
                                                      StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Abrimos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Llamamos al metodo interno
                return ClnCantidadNotas(l_dbcAccess,
                                        p_iNrocliente,
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
        /// Ejecuta el SP definido por el usuario: Remover
        /// </summary>
        /// <param name= p_strRemovedor>Usuario Removedor</param>
        /// <param name= p_dtFyhremovida>Fecha y Hora Removida</param>
        /// <param name= p_iNrocliente>Numero del cliente</param>
        /// <param name= p_dtFechayhora>Fecha y Hora de la nota</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void ClnRemover(string p_strRemovedor,
                                      DateTime p_dtFyhremovida,
                                      int p_iNrocliente,
                                      DateTime p_dtFechayhora,
                                      StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Abrimos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Llamamos al metodo interno
                ClnRemover(l_dbcAccess,
                           p_strRemovedor,
                           p_dtFyhremovida,
                           p_iNrocliente,
                           p_dtFechayhora,
                           p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion
                p_smResult.BllError(l_expData);
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
        /// Valida la integridad de una entidad: CliNota
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCliNota">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ClnTInt(DBConn p_dbcAccess,
                                     ECliNota p_entCliNota,
                                     StatMsg p_smResult)
        {
            // ********
            // Validaciones de los campos sin conexion
            // ********

            if (p_entCliNota.Numcliente <= 0) {
                // El campo [Numero del Cliente] debe ser mayor a cero
                p_smResult.BllWarning("El dato [Numero del Cliente] debe ser mayor a cero","");
                return;
            }

            if (p_entCliNota.Fechayhora.Year == 1900) {
                // El campo [Fecha y Hora] no puede ser vacío
                p_smResult.BllWarning("El dato [Fecha y Hora] no puede ser vacío","");
                return;
            }

            if (p_entCliNota.Titulo.Trim() == "") {
                // El campo [Título] no puede ser vacío
                p_smResult.BllWarning("El dato [Título] no puede ser vacío","");
                return;
            }

            if (p_entCliNota.Texto.Trim() == "") {
                // El campo [Texto] no puede ser vacío
                p_smResult.BllWarning("El dato [Texto] no puede ser vacío","");
                return;
            }

            if ((p_entCliNota.Tipo != "0") &&
                (p_entCliNota.Tipo != "1")) {
                // El campo [Tipo] tiene opciones
                p_smResult.BllWarning("El dato [Tipo] sólo admite\r\n\r\n[0]- ERROR\r\n[1]- NOTA\r\n","");
                return;
            }

            if (p_entCliNota.Escritor.Trim() == "") {
                // El campo [Usuario Escritor] no puede ser vacío
                p_smResult.BllWarning("El dato [Usuario Escritor] no puede ser vacío","");
                return;
            }

            // ********
            // Validaciones de los campos con conexion
            // ********

            // Verificamos la clave foranea
            Clientes.VKey(p_dbcAccess,
                          p_entCliNota.Numcliente,
                          p_smResult);
            if (p_smResult.NOk) return;

            // El registro tiene que existir
            if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                // Error. La clave foranea no existe
                p_smResult.BllWarning("La clave (Cliente) foranea no existe en el sistema.","");
                return;
            }

            // Llamamos a la funcion fija del usuario
            ClnTInt_f(p_dbcAccess, p_entCliNota, p_smResult);
            if (p_smResult.NOk) return;
        }

        /// <summary>
        /// Verifica el número de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Numero del Cliente</param>
        /// <param name="p_dtFechayhora">Fecha y Hora</param>
        /// <param name="p_iFxdVersion">Número de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ClnVVer(DBConn p_dbcAccess,
                                     int p_iNumcliente,
                                     DateTime p_dtFechayhora,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            // Verificamos el número de versión
            Dal.CliNotas.ChkVersion(p_dbcAccess,
                                    p_iNumcliente,
                                    p_dtFechayhora,
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
            p_smResult.BllWarning("El número de versión del registro del ítem (CliNota) no coincide.\r\nOperación cancelada.","");
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: ECliNota
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave está deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Numero del Cliente</param>
        /// <param name="p_dtFechayhora">Fecha y Hora</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ClnVKey(DBConn p_dbcAccess,
                                     int p_iNumcliente,
                                     DateTime p_dtFechayhora,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            Dal.CliNotas.Search(p_dbcAccess,
                                p_iNumcliente,
                                p_dtFechayhora,
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
        /// Devuelve una Lista-entidad: LECliNotas
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LECliNotas</returns>
        internal static LECliNotas ClnUpfl(DBConn p_dbcAccess,
                                            bool p_bOnlyActive,
                                            StatMsg p_smResult)
        {
            try {
                // Pedimos los registros de la tabla: CliNotas
                DataSet l_dsTemp= new DataSet();

                Dal.CliNotas.Up(p_dbcAccess, 
                                p_bOnlyActive,
                                ref l_dsTemp, "Temporal",
                                p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.CliNotas.MakeGridCaptions(ref l_dsTemp, "Temporal", p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LECliNotas l_lentRet= new LECliNotas(l_dsTemp.Tables["Temporal"]);
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
        /// Devuelve una entidad: ECliNota
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Numero del Cliente</param>
        /// <param name="p_dtFechayhora">Fecha y Hora</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: ECliNota</returns>
        internal static ECliNota ClnSrch(DBConn p_dbcAccess,
                                         int p_iNumcliente,
                                         DateTime p_dtFechayhora,
                                         bool p_bOnlyActive,
                                         StatMsg p_smResult)
        {
            try {
                // Pedimos el registro de la tabla: CliNotas
                DataSet l_dsTemp= new DataSet();

                Dal.CliNotas.Search(p_dbcAccess, 
                                    p_iNumcliente,
                                    p_dtFechayhora,
                                    p_bOnlyActive,
                                    ref l_dsTemp, "Temporal",
                                    p_smResult);
                if (p_smResult.NOk) return null;

                // Constuimos la entidad y la devolvemos (si vino un registro)
                ECliNota l_entRet= null;

                if (l_dsTemp.Tables["Temporal"].Rows.Count == 1)
                    l_entRet= new ECliNota(l_dsTemp.Tables["Temporal"].Rows[0]);

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
        /// Devuelve una lista-entidad: LECliNotas
        /// a partir de una clave foranea de la tabla: CliNotas
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Numero del Cliente</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static LECliNotas ClnFSch(DBConn p_dbcAccess,
                                           int p_iNumcliente,
                                           bool p_bOnlyActive,
                                           StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            try {
                // Pedimos los registros de la tabla por Foreing Key
                Dal.CliNotas.FSearch(p_dbcAccess,
                                     p_iNumcliente,
                                     p_bOnlyActive,
                                     ref l_dsTemp, "Temporal",
                                     p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.CliNotas.MakeGridCaptions(ref l_dsTemp, "Temporal", p_smResult);

                // Contruimos la lista-entidad y la devolvemos
                LECliNotas l_entRet= new LECliNotas(l_dsTemp.Tables["Temporal"]);
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
        /// Agrega o modifica un registro de la tabla: CliNotas
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCliNota">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ClnSSav(DBConn p_dbcAccess,
                                     ECliNota p_entCliNota,
                                     StatMsg p_smResult)
        {
            try {
                // Procesamos codigo fijo
                ClnSave_f(p_dbcAccess, ref p_entCliNota, p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                ClnVKey(p_dbcAccess, 
                        p_entCliNota.Numcliente,
                        p_entCliNota.Fechayhora,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entCliNota.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El ítem (CliNota) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    ClnInsr(p_dbcAccess, p_entCliNota, p_smResult);
                    return;
                }

                // Es un update. La clave debe existir y estar habilitada
                if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                    // Error. La clave no existe o no está habilitada
                    p_smResult.BllWarning("El ítem (CliNota) que intenta modificar no existe en el sistema o no está habilitado.","");
                    return;
                }

                // Debe coincidir el número de version
                ClnVVer(p_dbcAccess, 
                        p_entCliNota.Numcliente,
                        p_entCliNota.Fechayhora,
                        p_entCliNota.FxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos el registro
                ClnUpdt(p_dbcAccess, p_entCliNota, p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Agrega un registro a la tabla a partir de una entidad: ECliNota
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCliNota">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ClnInsr(DBConn p_dbcAccess,
                                     ECliNota p_entCliNota,
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                ClnTInt(p_dbcAccess, p_entCliNota, p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: CliNotas
                Dal.CliNotas.Insert(p_dbcAccess,
                                    p_entCliNota.Numcliente,
                                    p_entCliNota.Fechayhora,
                                    p_entCliNota.Titulo,
                                    p_entCliNota.Texto,
                                    p_entCliNota.Tipo,
                                    p_entCliNota.Escritor,
                                    p_entCliNota.Removedor,
                                    p_entCliNota.Fyhremovida,
                                    p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Actualiza un registro a la tabla a partir de una entidad: ECliNota
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCliNota">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ClnUpdt(DBConn p_dbcAccess,
                                     ECliNota p_entCliNota,
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                ClnTInt(p_dbcAccess, p_entCliNota, p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: CliNotas
                Dal.CliNotas.Update(p_dbcAccess,
                                    p_entCliNota.Numcliente,
                                    p_entCliNota.Fechayhora,
                                    p_entCliNota.Titulo,
                                    p_entCliNota.Texto,
                                    p_entCliNota.Tipo,
                                    p_entCliNota.Escritor,
                                    p_entCliNota.Removedor,
                                    p_entCliNota.Fyhremovida,
                                    p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra físicamente un registro de a tabla: CliNotas
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Numero del Cliente</param>
        /// <param name="p_dtFechayhora">Fecha y Hora</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ClnDrop(DBConn p_dbcAccess,
                                     int p_iNumcliente,
                                     DateTime p_dtFechayhora,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            try {
                // Verificamos la clave a borrar
                ClnVKey(p_dbcAccess,
                        p_iNumcliente,
                        p_dtFechayhora,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (CliNota) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                ClnVVer(p_dbcAccess, 
                        p_iNumcliente,
                        p_dtFechayhora,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Borramos físicamente el registro
                Dal.CliNotas.Drop(p_dbcAccess,
                                  p_iNumcliente,
                                  p_dtFechayhora,
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
        internal static void ClnPack(DBConn p_dbcAccess,
                                     StatMsg p_smResult)
        {
            try {
                // Borramos los borrados lógicamente
                Dal.CliNotas.Pack(p_dbcAccess,
                                  p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Realiza una actualización inteligente de la tabla a partir de una
        /// lista-entidad: LECliNotas
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Numero del Cliente</param>
        /// <param name="p_lentCliNotas">Lista-entidad a actualizar sobre la tabla</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ClnSSav(DBConn p_dbcAccess,
                                     int p_iNumcliente,
                                      LECliNotas p_lentCliNotas,
                                      StatMsg p_smResult)
        {
            try {
                // Deshabilitamos todas las entidades existentes
                Dal.CliNotas.FDrop(p_dbcAccess,
                                   p_iNumcliente,
                                   p_smResult);
                if (p_smResult.NOk) return;

                // Recorremos la lista de entidades
                foreach (ECliNota l_entCliNota in p_lentCliNotas) {
                    // Forzamos la clave foranea
                    l_entCliNota.Numcliente= p_iNumcliente;

                    // Verificamos si existe
                    ClnVKey(p_dbcAccess,
                            l_entCliNota.Numcliente,
                            l_entCliNota.Fechayhora,
                            p_smResult);
                    if (p_smResult.NOk) return;

                    // Si no existe
                    if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Hay que darla de alta
                        ClnInsr(p_dbcAccess, l_entCliNota, p_smResult);
                        if (p_smResult.NOk) return;
                        continue;
                    }

                    // Existe. Debe coincidir el número de version
                    ClnVVer(p_dbcAccess, 
                            l_entCliNota.Numcliente,
                            l_entCliNota.Fechayhora,
                            l_entCliNota.FxdVersion,
                            p_smResult);
                    if (p_smResult.NOk) return;

                    // El número coincide. La Actualizamos si no está borrada
                    if (!l_entCliNota.EstaBorrada) {
                        ClnUpdt(p_dbcAccess, l_entCliNota, p_smResult);
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

        /// <summary>
        /// Ejecuta el SP definido por el usuario: BorraPorCliente
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_iNrocliente>Numero del cliente a borrar las notas</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ClnBorraPorCliente(DBConn p_dbcAccess,
                                                int p_iNrocliente,
                                                StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                Dal.CliNotas.BorraPorCliente(p_dbcAccess,
                                             p_iNrocliente,
                                             p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion
                p_smResult.BllError(l_expData);
            }
            finally {
                // Terminamos
            }
        }

        /// <summary>
        /// Ejecuta el SP definido por el usuario: CantidadNotas
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_iNrocliente>Numero del Cliente</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades ClnCantidadNotas(DBConn p_dbcAccess,
                                                        int p_iNrocliente,
                                                        StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.CliNotas.CantidadNotas(p_dbcAccess,
                                           p_iNrocliente,
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
        /// Ejecuta el SP definido por el usuario: Remover
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_strRemovedor>Usuario Removedor</param>
        /// <param name= p_dtFyhremovida>Fecha y Hora Removida</param>
        /// <param name= p_iNrocliente>Numero del cliente</param>
        /// <param name= p_dtFechayhora>Fecha y Hora de la nota</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ClnRemover(DBConn p_dbcAccess,
                                        string p_strRemovedor,
                                        DateTime p_dtFyhremovida,
                                        int p_iNrocliente,
                                        DateTime p_dtFechayhora,
                                        StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                Dal.CliNotas.Remover(p_dbcAccess,
                                     p_strRemovedor,
                                     p_dtFyhremovida,
                                     p_iNrocliente,
                                     p_dtFechayhora,
                                     p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion
                p_smResult.BllError(l_expData);
            }
            finally {
                // Terminamos
            }
        }
        #endregion


        //**********************************************************
        //
        // Funciones para la Tabla: CliServicios
        // Usando ClaseDal        : CliServicios
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos públicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: CliServicios
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LECliServicios</returns>
        public static LECliServicios ClsUpFull(bool p_bOnlyActive,
                                               StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                return ClsUpfl(l_dbcAccess, p_bOnlyActive, p_smResult);
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
        /// Devuelve una entidad: ECliServicio
        /// </summary>
        /// <param name="p_iNumcliente">Número Cliente</param>
        /// <param name="p_iItem">Item</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: ECliServicio</returns>
        public static ECliServicio ClsGet(int p_iNumcliente,
                                          int p_iItem,
                                          bool p_bOnlyActive,
                                          StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: ECliServicio
                return ClsSrch(l_dbcAccess,
                               p_iNumcliente,
                               p_iItem,
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
        /// Devuelve una lista-entidad: LECliServicios
        /// asociada a una Foreing key de la tabla: CliServicios
        /// </summary>
        /// <param name="p_iNumcliente">Número Cliente</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-Entidad: LECliServicios</returns>
        public static LECliServicios ClsFGet(int p_iNumcliente,
                                             bool p_bOnlyActive,
                                             StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la lista-entidad: LECliServicios
                return ClsFSch(l_dbcAccess,
                               p_iNumcliente,
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
        /// Agrega o modifica un registro de la tabla: CliServicios
        /// </summary>
        /// <param name="p_entCliServicio">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void ClsSave(ECliServicio p_entCliServicio,
                                   StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: ECliServicio
                ClsSSav(l_dbcAccess, p_entCliServicio, p_smResult);
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
        /// Habilita/Deshabilita un registro de la tabla: CliServicios
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_iNumcliente">Número Cliente</param>
        /// <param name="p_iItem">Item</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void ClsEnabled(bool p_bEnable,
                                      int p_iNumcliente,
                                      int p_iItem,
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
                ClsEnabled_f(l_dbcAccess,
                             p_bEnable,
                             p_iNumcliente,
                             p_iItem,
                             ref p_iFxdVersion,
                             p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                ClsVKey(l_dbcAccess,
                        p_iNumcliente,
                        p_iItem,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (CliServicio) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                ClsVVer(l_dbcAccess, 
                        p_iNumcliente,
                        p_iItem,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.CliServicios.Recall(l_dbcAccess,
                                            p_iNumcliente,
                                            p_iItem,
                                            p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.CliServicios.Delete(l_dbcAccess,
                                            p_iNumcliente,
                                            p_iItem,
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
        /// Borra físicamento un registro de la tabla: CliServicios
        /// </summary>
        /// <param name="p_iNumcliente">Número Cliente</param>
        /// <param name="p_iItem">Item</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void ClsRemove(int p_iNumcliente,
                                     int p_iItem,
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
                ClsRemove_f(l_dbcAccess,
                            p_iNumcliente,
                            p_iItem,
                            p_iFxdVersion,
                            p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                ClsDrop(l_dbcAccess,
                        p_iNumcliente,
                        p_iItem,
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
        public static void ClsPurge(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Realizamos el borrado
                ClsPack(l_dbcAccess,
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
        /// Valida la integridad de una entidad: CliServicio
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCliServicio">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ClsTInt(DBConn p_dbcAccess,
                                     ECliServicio p_entCliServicio,
                                     StatMsg p_smResult)
        {
            // ********
            // Validaciones de los campos sin conexion
            // ********

            if (p_entCliServicio.Item <= 0) {
                // El campo [Item] debe ser mayor a cero
                p_smResult.BllWarning("El dato [Item] debe ser mayor a cero","");
                return;
            }

            // ********
            // Validaciones de los campos con conexion
            // ********

            Servicios.VKey(p_dbcAccess,
                           p_entCliServicio.Codservicio,
                           p_smResult);
            if (p_smResult.NOk) return;

            if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                // El campo [Código de Servicio] debe existir en la tabla [Servicios.]
                p_smResult.BllWarning("El dato [Código de Servicio] debe existir en la tabla [Servicios.]","");
                return;
            }

            // Verificamos la clave foranea
            Clientes.VKey(p_dbcAccess,
                          p_entCliServicio.Numcliente,
                          p_smResult);
            if (p_smResult.NOk) return;

            // El registro tiene que existir
            if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                // Error. La clave foranea no existe
                p_smResult.BllWarning("La clave (Cliente) foranea no existe en el sistema.","");
                return;
            }

            // Todas las validaciones fueron correctas

            // Llamamos a la funcion fija del usuario
            ClsTInt_f(p_dbcAccess, p_entCliServicio, p_smResult);
            if (p_smResult.NOk) return;
        }

        /// <summary>
        /// Verifica el número de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Número Cliente</param>
        /// <param name="p_iItem">Item</param>
        /// <param name="p_iFxdVersion">Número de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ClsVVer(DBConn p_dbcAccess,
                                     int p_iNumcliente,
                                     int p_iItem,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            // Verificamos el número de versión
            Dal.CliServicios.ChkVersion(p_dbcAccess,
                                        p_iNumcliente,
                                        p_iItem,
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
            p_smResult.BllWarning("El número de versión del registro del ítem (CliServicio) no coincide.\r\nOperación cancelada.","");
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: ECliServicio
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave está deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Número Cliente</param>
        /// <param name="p_iItem">Item</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ClsVKey(DBConn p_dbcAccess,
                                     int p_iNumcliente,
                                     int p_iItem,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            Dal.CliServicios.Search(p_dbcAccess,
                                    p_iNumcliente,
                                    p_iItem,
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
        /// Devuelve una Lista-entidad: LECliServicios
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LECliServicios</returns>
        internal static LECliServicios ClsUpfl(DBConn p_dbcAccess,
                                                bool p_bOnlyActive,
                                                StatMsg p_smResult)
        {
            try {
                // Pedimos los registros de la tabla: CliServicios
                DataSet l_dsTemp= new DataSet();

                Dal.CliServicios.Up(p_dbcAccess, 
                                    p_bOnlyActive,
                                    ref l_dsTemp, "Temporal",
                                    p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.CliServicios.MakeGridCaptions(ref l_dsTemp, "Temporal", p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LECliServicios l_lentRet= new LECliServicios(l_dsTemp.Tables["Temporal"]);
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
        /// Devuelve una entidad: ECliServicio
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Número Cliente</param>
        /// <param name="p_iItem">Item</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: ECliServicio</returns>
        internal static ECliServicio ClsSrch(DBConn p_dbcAccess,
                                             int p_iNumcliente,
                                             int p_iItem,
                                             bool p_bOnlyActive,
                                             StatMsg p_smResult)
        {
            try {
                // Pedimos el registro de la tabla: CliServicios
                DataSet l_dsTemp= new DataSet();

                Dal.CliServicios.Search(p_dbcAccess, 
                                        p_iNumcliente,
                                        p_iItem,
                                        p_bOnlyActive,
                                        ref l_dsTemp, "Temporal",
                                        p_smResult);
                if (p_smResult.NOk) return null;

                // Constuimos la entidad y la devolvemos (si vino un registro)
                ECliServicio l_entRet= null;

                if (l_dsTemp.Tables["Temporal"].Rows.Count == 1)
                    l_entRet= new ECliServicio(l_dsTemp.Tables["Temporal"].Rows[0]);

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
        /// Devuelve una lista-entidad: LECliServicios
        /// a partir de una clave foranea de la tabla: CliServicios
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Número Cliente</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static LECliServicios ClsFSch(DBConn p_dbcAccess,
                                               int p_iNumcliente,
                                               bool p_bOnlyActive,
                                               StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            try {
                // Pedimos los registros de la tabla por Foreing Key
                Dal.CliServicios.FSearch(p_dbcAccess,
                                         p_iNumcliente,
                                         p_bOnlyActive,
                                         ref l_dsTemp, "Temporal",
                                         p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.CliServicios.MakeGridCaptions(ref l_dsTemp, "Temporal", p_smResult);

                // Contruimos la lista-entidad y la devolvemos
                LECliServicios l_entRet= new LECliServicios(l_dsTemp.Tables["Temporal"]);
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
        /// Agrega o modifica un registro de la tabla: CliServicios
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCliServicio">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ClsSSav(DBConn p_dbcAccess,
                                     ECliServicio p_entCliServicio,
                                     StatMsg p_smResult)
        {
            try {
                // Procesamos codigo fijo
                ClsSave_f(p_dbcAccess, ref p_entCliServicio, p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                ClsVKey(p_dbcAccess, 
                        p_entCliServicio.Numcliente,
                        p_entCliServicio.Item,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entCliServicio.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El ítem (CliServicio) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    ClsInsr(p_dbcAccess, p_entCliServicio, p_smResult);
                    return;
                }

                // Es un update. La clave debe existir y estar habilitada
                if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                    // Error. La clave no existe o no está habilitada
                    p_smResult.BllWarning("El ítem (CliServicio) que intenta modificar no existe en el sistema o no está habilitado.","");
                    return;
                }

                // Debe coincidir el número de version
                ClsVVer(p_dbcAccess, 
                        p_entCliServicio.Numcliente,
                        p_entCliServicio.Item,
                        p_entCliServicio.FxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos el registro
                ClsUpdt(p_dbcAccess, p_entCliServicio, p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Agrega un registro a la tabla a partir de una entidad: ECliServicio
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCliServicio">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ClsInsr(DBConn p_dbcAccess,
                                     ECliServicio p_entCliServicio,
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                ClsTInt(p_dbcAccess, p_entCliServicio, p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: CliServicios
                Dal.CliServicios.Insert(p_dbcAccess,
                                        p_entCliServicio.Numcliente,
                                        p_entCliServicio.Item,
                                        p_entCliServicio.Codservicio,
                                        p_entCliServicio.Coseguro,
                                        p_entCliServicio.Valorprestacion,
                                        p_entCliServicio.Cantestprestaciones,
                                        p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Actualiza un registro a la tabla a partir de una entidad: ECliServicio
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCliServicio">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ClsUpdt(DBConn p_dbcAccess,
                                     ECliServicio p_entCliServicio,
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                ClsTInt(p_dbcAccess, p_entCliServicio, p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: CliServicios
                Dal.CliServicios.Update(p_dbcAccess,
                                        p_entCliServicio.Numcliente,
                                        p_entCliServicio.Item,
                                        p_entCliServicio.Codservicio,
                                        p_entCliServicio.Coseguro,
                                        p_entCliServicio.Valorprestacion,
                                        p_entCliServicio.Cantestprestaciones,
                                        p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra físicamente un registro de a tabla: CliServicios
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Número Cliente</param>
        /// <param name="p_iItem">Item</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ClsDrop(DBConn p_dbcAccess,
                                     int p_iNumcliente,
                                     int p_iItem,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            try {
                // Verificamos la clave a borrar
                ClsVKey(p_dbcAccess,
                        p_iNumcliente,
                        p_iItem,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (CliServicio) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                ClsVVer(p_dbcAccess, 
                        p_iNumcliente,
                        p_iItem,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Borramos físicamente el registro
                Dal.CliServicios.Drop(p_dbcAccess,
                                      p_iNumcliente,
                                      p_iItem,
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
        internal static void ClsPack(DBConn p_dbcAccess,
                                     StatMsg p_smResult)
        {
            try {
                // Borramos los borrados lógicamente
                Dal.CliServicios.Pack(p_dbcAccess,
                                      p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Realiza una actualización inteligente de la tabla a partir de una
        /// lista-entidad: LECliServicios
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Número Cliente</param>
        /// <param name="p_lentCliServicios">Lista-entidad a actualizar sobre la tabla</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ClsSSav(DBConn p_dbcAccess,
                                     int p_iNumcliente,
                                      LECliServicios p_lentCliServicios,
                                      StatMsg p_smResult)
        {
            try {
                // Deshabilitamos todas las entidades existentes
                Dal.CliServicios.FDrop(p_dbcAccess,
                                       p_iNumcliente,
                                       p_smResult);
                if (p_smResult.NOk) return;

                // Recorremos la lista de entidades
                foreach (ECliServicio l_entCliServicio in p_lentCliServicios) {
                    // Forzamos la clave foranea
                    l_entCliServicio.Numcliente= p_iNumcliente;

                    // Verificamos si existe
                    ClsVKey(p_dbcAccess,
                            l_entCliServicio.Numcliente,
                            l_entCliServicio.Item,
                            p_smResult);
                    if (p_smResult.NOk) return;

                    // Si no existe
                    if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Hay que darla de alta
                        ClsInsr(p_dbcAccess, l_entCliServicio, p_smResult);
                        if (p_smResult.NOk) return;
                        continue;
                    }

                    // Existe. Debe coincidir el número de version
                    ClsVVer(p_dbcAccess, 
                            l_entCliServicio.Numcliente,
                            l_entCliServicio.Item,
                            l_entCliServicio.FxdVersion,
                            p_smResult);
                    if (p_smResult.NOk) return;

                    // El número coincide. La Actualizamos si no está borrada
                    if (!l_entCliServicio.EstaBorrada) {
                        ClsUpdt(p_dbcAccess, l_entCliServicio, p_smResult);
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

        /// <summary>
        /// Ejecuta el SP definido por el usuario: BorraPorCliente
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_iNrocliente>Numero del cliente a borrar los servicios</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ClsBorraPorCliente(DBConn p_dbcAccess,
                                                int p_iNrocliente,
                                                StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                Dal.CliServicios.BorraPorCliente(p_dbcAccess,
                                                 p_iNrocliente,
                                                 p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion
                p_smResult.BllError(l_expData);
            }
            finally {
                // Terminamos
            }
        }
        #endregion


        //**********************************************************
        //
        // Funciones para la Tabla: CliVentas
        // Usando ClaseDal        : CliVentas
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos públicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: CliVentas
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LECliVentas</returns>
        public static LECliVentas ClvUpFull(bool p_bOnlyActive,
                                            StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                return ClvUpfl(l_dbcAccess, p_bOnlyActive, p_smResult);
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
        /// Devuelve una entidad: ECliVenta
        /// </summary>
        /// <param name="p_iNumcliente">Numero Cliente</param>
        /// <param name="p_dtFecha">Fecha Venta</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: ECliVenta</returns>
        public static ECliVenta ClvGet(int p_iNumcliente,
                                       DateTime p_dtFecha,
                                       bool p_bOnlyActive,
                                       StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: ECliVenta
                return ClvSrch(l_dbcAccess,
                               p_iNumcliente,
                               p_dtFecha,
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
        /// Devuelve una lista-entidad: LECliVentas
        /// asociada a una Foreing key de la tabla: CliVentas
        /// </summary>
        /// <param name="p_iNumcliente">Numero Cliente</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-Entidad: LECliVentas</returns>
        public static LECliVentas ClvFGet(int p_iNumcliente,
                                          bool p_bOnlyActive,
                                          StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la lista-entidad: LECliVentas
                return ClvFSch(l_dbcAccess,
                               p_iNumcliente,
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
        /// Agrega o modifica un registro de la tabla: CliVentas
        /// </summary>
        /// <param name="p_entCliVenta">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void ClvSave(ECliVenta p_entCliVenta,
                                   StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: ECliVenta
                ClvSSav(l_dbcAccess, p_entCliVenta, p_smResult);
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
        /// Habilita/Deshabilita un registro de la tabla: CliVentas
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_iNumcliente">Numero Cliente</param>
        /// <param name="p_dtFecha">Fecha Venta</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void ClvEnabled(bool p_bEnable,
                                      int p_iNumcliente,
                                      DateTime p_dtFecha,
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
                ClvEnabled_f(l_dbcAccess,
                             p_bEnable,
                             p_iNumcliente,
                             p_dtFecha,
                             ref p_iFxdVersion,
                             p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                ClvVKey(l_dbcAccess,
                        p_iNumcliente,
                        p_dtFecha,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (CliVenta) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                ClvVVer(l_dbcAccess, 
                        p_iNumcliente,
                        p_dtFecha,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.CliVentas.Recall(l_dbcAccess,
                                         p_iNumcliente,
                                         p_dtFecha,
                                         p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.CliVentas.Delete(l_dbcAccess,
                                         p_iNumcliente,
                                         p_dtFecha,
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
        /// Borra físicamento un registro de la tabla: CliVentas
        /// </summary>
        /// <param name="p_iNumcliente">Numero Cliente</param>
        /// <param name="p_dtFecha">Fecha Venta</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void ClvRemove(int p_iNumcliente,
                                     DateTime p_dtFecha,
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
                ClvRemove_f(l_dbcAccess,
                            p_iNumcliente,
                            p_dtFecha,
                            p_iFxdVersion,
                            p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                ClvDrop(l_dbcAccess,
                        p_iNumcliente,
                        p_dtFecha,
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
        public static void ClvPurge(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Realizamos el borrado
                ClvPack(l_dbcAccess,
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
        /// Ejecuta el SP definido por el usuario: ZDetalleVentas
        /// </summary>
        /// <param name= p_iAnio>Anio</param>
        /// <param name= p_iMes>Mes</param>
        /// <param name= p_strCodmarcaini>Cod Marca Inicial</param>
        /// <param name= p_strCodmarcafin>Cod Marca Fin</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        public static ListaEntidades ClvZDetalleVentas(int p_iAnio,
                                                       int p_iMes,
                                                       string p_strCodmarcaini,
                                                       string p_strCodmarcafin,
                                                       StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Abrimos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Llamamos al metodo interno
                return ClvZDetalleVentas(l_dbcAccess,
                                         p_iAnio,
                                         p_iMes,
                                         p_strCodmarcaini,
                                         p_strCodmarcafin,
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
        /// Ejecuta el SP definido por el usuario: ZVentasPorMes
        /// </summary>
        /// <param name= p_iAnioinicio>Anio de inicio</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        public static ListaEntidades ClvZVentasPorMes(int p_iAnioinicio,
                                                      StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Abrimos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Llamamos al metodo interno
                return ClvZVentasPorMes(l_dbcAccess,
                                        p_iAnioinicio,
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
        /// Valida la integridad de una entidad: CliVenta
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCliVenta">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ClvTInt(DBConn p_dbcAccess,
                                     ECliVenta p_entCliVenta,
                                     StatMsg p_smResult)
        {
            // ********
            // Validaciones de los campos sin conexion
            // ********

            if (p_entCliVenta.Cantcapitas < 0) {
                // El campo [Capitas] no puede menor a cero
                p_smResult.BllWarning("El dato [Capitas] no puede ser negativo","");
                return;
            }

            // ********
            // Validaciones de los campos con conexion
            // ********

            Vendedores.VKey(p_dbcAccess,
                            p_entCliVenta.Codvendedor,
                            p_smResult);
            if (p_smResult.NOk) return;

            if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                // El campo [Vendedor] debe existir en la tabla [Vendedores.]
                p_smResult.BllWarning("El dato [Vendedor] debe existir en la tabla [Vendedores.]","");
                return;
            }

            Tablas.TcnVKey(p_dbcAccess,
                           p_entCliVenta.Codtipocontrato,
                           p_smResult);
            if (p_smResult.NOk) return;

            if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                // El campo [Tipo Contrato] debe existir en la tabla [Tablas.Tcn]
                p_smResult.BllWarning("El dato [Tipo Contrato] debe existir en la tabla [Tablas.Tcn]","");
                return;
            }

            // Verificamos la clave foranea
            Clientes.VKey(p_dbcAccess,
                          p_entCliVenta.Numcliente,
                          p_smResult);
            if (p_smResult.NOk) return;

            // El registro tiene que existir
            if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                // Error. La clave foranea no existe
                p_smResult.BllWarning("La clave (Cliente) foranea no existe en el sistema.","");
                return;
            }

            // Todas las validaciones fueron correctas

            // Llamamos a la funcion fija del usuario
            ClvTInt_f(p_dbcAccess, p_entCliVenta, p_smResult);
            if (p_smResult.NOk) return;
        }

        /// <summary>
        /// Verifica el número de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Numero Cliente</param>
        /// <param name="p_dtFecha">Fecha Venta</param>
        /// <param name="p_iFxdVersion">Número de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ClvVVer(DBConn p_dbcAccess,
                                     int p_iNumcliente,
                                     DateTime p_dtFecha,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            // Verificamos el número de versión
            Dal.CliVentas.ChkVersion(p_dbcAccess,
                                     p_iNumcliente,
                                     p_dtFecha,
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
            p_smResult.BllWarning("El número de versión del registro del ítem (CliVenta) no coincide.\r\nOperación cancelada.","");
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: ECliVenta
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave está deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Numero Cliente</param>
        /// <param name="p_dtFecha">Fecha Venta</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ClvVKey(DBConn p_dbcAccess,
                                     int p_iNumcliente,
                                     DateTime p_dtFecha,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            Dal.CliVentas.Search(p_dbcAccess,
                                 p_iNumcliente,
                                 p_dtFecha,
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
        /// Devuelve una Lista-entidad: LECliVentas
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LECliVentas</returns>
        internal static LECliVentas ClvUpfl(DBConn p_dbcAccess,
                                             bool p_bOnlyActive,
                                             StatMsg p_smResult)
        {
            try {
                // Pedimos los registros de la tabla: CliVentas
                DataSet l_dsTemp= new DataSet();

                Dal.CliVentas.Up(p_dbcAccess, 
                                 p_bOnlyActive,
                                 ref l_dsTemp, "Temporal",
                                 p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.CliVentas.MakeGridCaptions(ref l_dsTemp, "Temporal", p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LECliVentas l_lentRet= new LECliVentas(l_dsTemp.Tables["Temporal"]);
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
        /// Devuelve una entidad: ECliVenta
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Numero Cliente</param>
        /// <param name="p_dtFecha">Fecha Venta</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: ECliVenta</returns>
        internal static ECliVenta ClvSrch(DBConn p_dbcAccess,
                                          int p_iNumcliente,
                                          DateTime p_dtFecha,
                                          bool p_bOnlyActive,
                                          StatMsg p_smResult)
        {
            try {
                // Pedimos el registro de la tabla: CliVentas
                DataSet l_dsTemp= new DataSet();

                Dal.CliVentas.Search(p_dbcAccess, 
                                     p_iNumcliente,
                                     p_dtFecha,
                                     p_bOnlyActive,
                                     ref l_dsTemp, "Temporal",
                                     p_smResult);
                if (p_smResult.NOk) return null;

                // Constuimos la entidad y la devolvemos (si vino un registro)
                ECliVenta l_entRet= null;

                if (l_dsTemp.Tables["Temporal"].Rows.Count == 1)
                    l_entRet= new ECliVenta(l_dsTemp.Tables["Temporal"].Rows[0]);

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
        /// Devuelve una lista-entidad: LECliVentas
        /// a partir de una clave foranea de la tabla: CliVentas
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Numero Cliente</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static LECliVentas ClvFSch(DBConn p_dbcAccess,
                                            int p_iNumcliente,
                                            bool p_bOnlyActive,
                                            StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            try {
                // Pedimos los registros de la tabla por Foreing Key
                Dal.CliVentas.FSearch(p_dbcAccess,
                                      p_iNumcliente,
                                      p_bOnlyActive,
                                      ref l_dsTemp, "Temporal",
                                      p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.CliVentas.MakeGridCaptions(ref l_dsTemp, "Temporal", p_smResult);

                // Contruimos la lista-entidad y la devolvemos
                LECliVentas l_entRet= new LECliVentas(l_dsTemp.Tables["Temporal"]);
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
        /// Agrega o modifica un registro de la tabla: CliVentas
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCliVenta">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ClvSSav(DBConn p_dbcAccess,
                                     ECliVenta p_entCliVenta,
                                     StatMsg p_smResult)
        {
            try {
                // Procesamos codigo fijo
                ClvSave_f(p_dbcAccess, ref p_entCliVenta, p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                ClvVKey(p_dbcAccess, 
                        p_entCliVenta.Numcliente,
                        p_entCliVenta.Fecha,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entCliVenta.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El ítem (CliVenta) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    ClvInsr(p_dbcAccess, p_entCliVenta, p_smResult);
                    return;
                }

                // Es un update. La clave debe existir y estar habilitada
                if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                    // Error. La clave no existe o no está habilitada
                    p_smResult.BllWarning("El ítem (CliVenta) que intenta modificar no existe en el sistema o no está habilitado.","");
                    return;
                }

                // Debe coincidir el número de version
                ClvVVer(p_dbcAccess, 
                        p_entCliVenta.Numcliente,
                        p_entCliVenta.Fecha,
                        p_entCliVenta.FxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos el registro
                ClvUpdt(p_dbcAccess, p_entCliVenta, p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Agrega un registro a la tabla a partir de una entidad: ECliVenta
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCliVenta">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ClvInsr(DBConn p_dbcAccess,
                                     ECliVenta p_entCliVenta,
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                ClvTInt(p_dbcAccess, p_entCliVenta, p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: CliVentas
                Dal.CliVentas.Insert(p_dbcAccess,
                                     p_entCliVenta.Numcliente,
                                     p_entCliVenta.Fecha,
                                     p_entCliVenta.Codvendedor,
                                     p_entCliVenta.Codtipocontrato,
                                     p_entCliVenta.Abono,
                                     p_entCliVenta.Cantcapitas,
                                     p_entCliVenta.Valorcapita,
                                     p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Actualiza un registro a la tabla a partir de una entidad: ECliVenta
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCliVenta">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ClvUpdt(DBConn p_dbcAccess,
                                     ECliVenta p_entCliVenta,
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                ClvTInt(p_dbcAccess, p_entCliVenta, p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: CliVentas
                Dal.CliVentas.Update(p_dbcAccess,
                                     p_entCliVenta.Numcliente,
                                     p_entCliVenta.Fecha,
                                     p_entCliVenta.Codvendedor,
                                     p_entCliVenta.Codtipocontrato,
                                     p_entCliVenta.Abono,
                                     p_entCliVenta.Cantcapitas,
                                     p_entCliVenta.Valorcapita,
                                     p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra físicamente un registro de a tabla: CliVentas
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Numero Cliente</param>
        /// <param name="p_dtFecha">Fecha Venta</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ClvDrop(DBConn p_dbcAccess,
                                     int p_iNumcliente,
                                     DateTime p_dtFecha,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            try {
                // Verificamos la clave a borrar
                ClvVKey(p_dbcAccess,
                        p_iNumcliente,
                        p_dtFecha,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (CliVenta) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                ClvVVer(p_dbcAccess, 
                        p_iNumcliente,
                        p_dtFecha,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Borramos físicamente el registro
                Dal.CliVentas.Drop(p_dbcAccess,
                                   p_iNumcliente,
                                   p_dtFecha,
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
        internal static void ClvPack(DBConn p_dbcAccess,
                                     StatMsg p_smResult)
        {
            try {
                // Borramos los borrados lógicamente
                Dal.CliVentas.Pack(p_dbcAccess,
                                   p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Realiza una actualización inteligente de la tabla a partir de una
        /// lista-entidad: LECliVentas
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Numero Cliente</param>
        /// <param name="p_lentCliVentas">Lista-entidad a actualizar sobre la tabla</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ClvSSav(DBConn p_dbcAccess,
                                     int p_iNumcliente,
                                      LECliVentas p_lentCliVentas,
                                      StatMsg p_smResult)
        {
            try {
                // Deshabilitamos todas las entidades existentes
                Dal.CliVentas.FDrop(p_dbcAccess,
                                    p_iNumcliente,
                                    p_smResult);
                if (p_smResult.NOk) return;

                // Recorremos la lista de entidades
                foreach (ECliVenta l_entCliVenta in p_lentCliVentas) {
                    // Forzamos la clave foranea
                    l_entCliVenta.Numcliente= p_iNumcliente;

                    // Verificamos si existe
                    ClvVKey(p_dbcAccess,
                            l_entCliVenta.Numcliente,
                            l_entCliVenta.Fecha,
                            p_smResult);
                    if (p_smResult.NOk) return;

                    // Si no existe
                    if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Hay que darla de alta
                        ClvInsr(p_dbcAccess, l_entCliVenta, p_smResult);
                        if (p_smResult.NOk) return;
                        continue;
                    }

                    // Existe. Debe coincidir el número de version
                    ClvVVer(p_dbcAccess, 
                            l_entCliVenta.Numcliente,
                            l_entCliVenta.Fecha,
                            l_entCliVenta.FxdVersion,
                            p_smResult);
                    if (p_smResult.NOk) return;

                    // El número coincide. La Actualizamos si no está borrada
                    if (!l_entCliVenta.EstaBorrada) {
                        ClvUpdt(p_dbcAccess, l_entCliVenta, p_smResult);
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

        /// <summary>
        /// Ejecuta el SP definido por el usuario: ZDetalleVentas
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_iAnio>Anio</param>
        /// <param name= p_iMes>Mes</param>
        /// <param name= p_strCodmarcaini>Cod Marca Inicial</param>
        /// <param name= p_strCodmarcafin>Cod Marca Fin</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades ClvZDetalleVentas(DBConn p_dbcAccess,
                                                         int p_iAnio,
                                                         int p_iMes,
                                                         string p_strCodmarcaini,
                                                         string p_strCodmarcafin,
                                                         StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.CliVentas.ZDetalleVentas(p_dbcAccess,
                                             p_iAnio,
                                             p_iMes,
                                             p_strCodmarcaini,
                                             p_strCodmarcafin,
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
        /// Ejecuta el SP definido por el usuario: ZVentasPorMes
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_iAnioinicio>Anio de inicio</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades ClvZVentasPorMes(DBConn p_dbcAccess,
                                                        int p_iAnioinicio,
                                                        StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.CliVentas.ZVentasPorMes(p_dbcAccess,
                                            p_iAnioinicio,
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


        //**********************************************************
        //
        // Funciones para la Tabla: Clientes
        // Usando ClaseDal        : Clientes
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos públicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: Clientes
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEClientes</returns>
        public static LEClientes UpFull(bool p_bOnlyActive,
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
        /// Devuelve una entidad: ECliente
        /// </summary>
        /// <param name="p_iNumero">Número de cliente</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: ECliente</returns>
        public static ECliente Get(int p_iNumero,
                                   bool p_bOnlyActive,
                                   StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: ECliente
                ECliente l_entCliente = Srch(l_dbcAccess,
                                             p_iNumero,
                                             p_bOnlyActive,
                                             p_smResult);
                if (p_smResult.NOk) return null;
                if (l_entCliente == null) return null;

                // Completamos la lista-entidad: LECliContactos
                l_entCliente.CliContactos= ClcFSch(l_dbcAccess,
                                                   p_iNumero,
                                                   p_bOnlyActive,
                                                   p_smResult);
                if (p_smResult.NOk) return null;

                // Completamos la lista-entidad: LECliEntrevistas
                l_entCliente.CliEntrevistas= CleFSch(l_dbcAccess,
                                                     p_iNumero,
                                                     p_bOnlyActive,
                                                     p_smResult);
                if (p_smResult.NOk) return null;

                // Completamos la lista-entidad: LECliGrupoFamiliares
                l_entCliente.CliGrupoFamiliares= CgfFSch(l_dbcAccess,
                                                         p_iNumero,
                                                         p_bOnlyActive,
                                                         p_smResult);
                if (p_smResult.NOk) return null;

                // Completamos la lista-entidad: LECliLlamadas
                l_entCliente.CliLlamadas= CllFSch(l_dbcAccess,
                                                  p_iNumero,
                                                  p_bOnlyActive,
                                                  p_smResult);
                if (p_smResult.NOk) return null;

                // Completamos la lista-entidad: LECliNotas
                l_entCliente.CliNotas= ClnFSch(l_dbcAccess,
                                               p_iNumero,
                                               p_bOnlyActive,
                                               p_smResult);
                if (p_smResult.NOk) return null;

                // Completamos la lista-entidad: LECliServicios
                l_entCliente.CliServicios= ClsFSch(l_dbcAccess,
                                                   p_iNumero,
                                                   p_bOnlyActive,
                                                   p_smResult);
                if (p_smResult.NOk) return null;

                // Completamos la lista-entidad: LECliVentas
                l_entCliente.CliVentas= ClvFSch(l_dbcAccess,
                                                p_iNumero,
                                                p_bOnlyActive,
                                                p_smResult);
                if (p_smResult.NOk) return null;

                // Devolvemos la entidad completa
                return l_entCliente;
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

        #region Metodos publicos de modificacion

        /// <summary>
        /// Agrega o modifica un registro de la tabla: Clientes
        /// </summary>
        /// <param name="p_entCliente">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void Save(ECliente p_entCliente,
                                StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: ECliente
                SSav(l_dbcAccess, p_entCliente, p_smResult);
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
        /// Habilita/Deshabilita un registro de la tabla: Clientes
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_iNumero">Número de cliente</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void Enabled(bool p_bEnable,
                                   int p_iNumero,
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
                          p_iNumero,
                          ref p_iFxdVersion,
                          p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                VKey(l_dbcAccess,
                     p_iNumero,
                     p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (Cliente) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                VVer(l_dbcAccess, 
                     p_iNumero,
                     p_iFxdVersion,
                     p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.Clientes.Recall(l_dbcAccess,
                                        p_iNumero,
                                        p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.Clientes.Delete(l_dbcAccess,
                                        p_iNumero,
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
        /// Borra físicamento un registro de la tabla: Clientes
        /// </summary>
        /// <param name="p_iNumero">Número de cliente</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void Remove(int p_iNumero,
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
                         p_iNumero,
                         p_iFxdVersion,
                         p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                Drop(l_dbcAccess,
                     p_iNumero,
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
        /// Ejecuta el SP definido por el usuario: BajaYBorraServicios
        /// </summary>
        /// <param name= p_iNrocliente>Numero de Cliente</param>
        /// <param name= p_iCantdiascancel>Tope Cantidad de Dias Cancelacion Servicio</param>
        /// <param name= p_strCodcompetencia>Codigo de Competencia</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void BajaYBorraServicios(int p_iNrocliente,
                                               int p_iCantdiascancel,
                                               string p_strCodcompetencia,
                                               StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Abrimos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Llamamos al metodo interno
                BajaYBorraServicios(l_dbcAccess,
                                    p_iNrocliente,
                                    p_iCantdiascancel,
                                    p_strCodcompetencia,
                                    p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion
                p_smResult.BllError(l_expData);
            }
            finally {
                // Si abrimos una conexion -> la cerramos
                if (l_dbcAccess != null) l_dbcAccess.Close();
            }
        }

        /// <summary>
        /// Ejecuta el SP definido por el usuario: BorraEntrevistasPend
        /// </summary>
        /// <param name= p_iNumcliente>Numero de Cliente</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void BorraEntrevistasPend(int p_iNumcliente,
                                                StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Abrimos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Llamamos al metodo interno
                BorraEntrevistasPend(l_dbcAccess,
                                     p_iNumcliente,
                                     p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion
                p_smResult.BllError(l_expData);
            }
            finally {
                // Si abrimos una conexion -> la cerramos
                if (l_dbcAccess != null) l_dbcAccess.Close();
            }
        }

        /// <summary>
        /// Ejecuta el SP definido por el usuario: CambiarMarcaVendido
        /// </summary>
        /// <param name= p_strValoralta>Valor Alta (S/N)</param>
        /// <param name= p_iNrocliente>Numero de CLiente</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void CambiarMarcaVendido(string p_strValoralta,
                                               int p_iNrocliente,
                                               StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Abrimos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Llamamos al metodo interno
                CambiarMarcaVendido(l_dbcAccess,
                                    p_strValoralta,
                                    p_iNrocliente,
                                    p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion
                p_smResult.BllError(l_expData);
            }
            finally {
                // Si abrimos una conexion -> la cerramos
                if (l_dbcAccess != null) l_dbcAccess.Close();
            }
        }

        /// <summary>
        /// Ejecuta el SP definido por el usuario: GetSinCodVend
        /// </summary>
        /// <param name= p_iNumero>Numero del cliente</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        public static ListaEntidades GetSinCodVend(int p_iNumero,
                                                   StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Abrimos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Llamamos al metodo interno
                return GetSinCodVend(l_dbcAccess,
                                     p_iNumero,
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
        /// Ejecuta el SP definido por el usuario: GetTodosLosClientes
        /// </summary>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        public static ListaEntidades GetTodosLosClientes(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Abrimos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Llamamos al metodo interno
                return GetTodosLosClientes(l_dbcAccess,
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
        /// Ejecuta el SP definido por el usuario: GetVendidos
        /// </summary>
        /// <param name= p_strCodvend>Codigo de Vendedor</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        public static ListaEntidades GetVendidos(string p_strCodvend,
                                                 StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Abrimos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Llamamos al metodo interno
                return GetVendidos(l_dbcAccess,
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
        /// Ejecuta el SP definido por el usuario: ZCargadores
        /// </summary>
        /// <param name= p_dtFechaini>Fecha Inicio</param>
        /// <param name= p_dtFechafin>Fecha Fin</param>
        /// <param name= p_strIninomcargador>Inicio Nombre cargador</param>
        /// <param name= p_strFinnomcargador>Fin Nombre cargador</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        public static ListaEntidades ZCargadores(DateTime p_dtFechaini,
                                                 DateTime p_dtFechafin,
                                                 string p_strIninomcargador,
                                                 string p_strFinnomcargador,
                                                 StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Abrimos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Llamamos al metodo interno
                return ZCargadores(l_dbcAccess,
                                   p_dtFechaini,
                                   p_dtFechafin,
                                   p_strIninomcargador,
                                   p_strFinnomcargador,
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
        /// Ejecuta el SP definido por el usuario: ZLog
        /// </summary>
        /// <param name= p_strIninomusuario>Inicio nombre usuario</param>
        /// <param name= p_strFinnomusuario>Fin nombre usuario</param>
        /// <param name= p_dtFechaini>Fecha Inicio</param>
        /// <param name= p_dtFechafin>Fecha Fin</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        public static ListaEntidades ZLog(string p_strIninomusuario,
                                          string p_strFinnomusuario,
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
                return ZLog(l_dbcAccess,
                            p_strIninomusuario,
                            p_strFinnomusuario,
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
        #endregion

        //---------------------------------------------------------------
        // Metodos públicos de la clase (no visibles para la UIL)
        //---------------------------------------------------------------

        #region Metodos internos de validacion

        /// <summary>
        /// Valida la integridad de una entidad: Cliente
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCliente">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TInt(DBConn p_dbcAccess,
                                  ECliente p_entCliente,
                                  StatMsg p_smResult)
        {
            // ********
            // Validaciones de los campos sin conexion
            // ********

            if (p_entCliente.Numero <= 0) {
                // El campo [Número de cliente] debe ser mayor a cero
                p_smResult.BllWarning("El dato [Número de cliente] debe ser mayor a cero","");
                return;
            }

            if ((p_entCliente.Alta != "S") &&
                (p_entCliente.Alta != "N")) {
                // El campo [Alta en Avalon] tiene opciones
                p_smResult.BllWarning("El dato [Alta en Avalon] sólo admite\r\n\r\n[S]- SI\r\n[N]- NO\r\n","");
                return;
            }

            if (p_entCliente.Direccion.Trim() == "") {
                // El campo [Dirección] no puede ser vacío
                p_smResult.BllWarning("El dato [Dirección] no puede ser vacío","");
                return;
            }

            if (p_entCliente.Altura < 0) {
                // El campo [Altura] no puede menor a cero
                p_smResult.BllWarning("El dato [Altura] no puede ser negativo","");
                return;
            }

            if (p_entCliente.Fechaingreso.Year == 1900) {
                // El campo [Fecha de ingreso] no puede ser vacío
                p_smResult.BllWarning("El dato [Fecha de ingreso] no puede ser vacío","");
                return;
            }

            if (p_entCliente.Cargador.Trim() == "") {
                // El campo [Usuario Cargador] no puede ser vacío
                p_smResult.BllWarning("El dato [Usuario Cargador] no puede ser vacío","");
                return;
            }

            if (p_entCliente.Nroavalon < 0) {
                // El campo [Número Avalon] no puede menor a cero
                p_smResult.BllWarning("El dato [Número Avalon] no puede ser negativo","");
                return;
            }

            if (p_entCliente.Deuda < 0) {
                // El campo [Deuda] no puede menor a cero
                p_smResult.BllWarning("El dato [Deuda] no puede ser negativo","");
                return;
            }

            // ********
            // Validaciones de los campos con conexion
            // ********

            if (p_entCliente.Codtinst.Trim() != "") {
                Tablas.TinVKey(p_dbcAccess,
                               p_entCliente.Codtinst,
                               p_smResult);
                if (p_smResult.NOk) return;

                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // El campo [Tipo de Institucion] debe existir en la tabla [Tablas.Tin]
                    p_smResult.BllWarning("El dato [Tipo de Institucion] debe existir en la tabla [Tablas.Tin]","");
                    return;
                }
            }

            if (p_entCliente.Codfrq.Trim() != "") {
                Tablas.FrqVKey(p_dbcAccess,
                               p_entCliente.Codfrq,
                               p_smResult);
                if (p_smResult.NOk) return;

                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // El campo [Franquicia] debe existir en la tabla [Tablas.Frq]
                    p_smResult.BllWarning("El dato [Franquicia] debe existir en la tabla [Tablas.Frq]","");
                    return;
                }
            }

            Tablas.LocVKey(p_dbcAccess,
                           p_entCliente.Codlocalidad,
                           p_smResult);
            if (p_smResult.NOk) return;

            if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                // El campo [Código de localidad] debe existir en la tabla [Tablas.Loc]
                p_smResult.BllWarning("El dato [Código de localidad] debe existir en la tabla [Tablas.Loc] y estar habilitado","");
                return;
            }

            if (p_entCliente.Codvend.Trim() != "") {
                Vendedores.VKey(p_dbcAccess,
                                p_entCliente.Codvend,
                                p_smResult);
                if (p_smResult.NOk) return;

                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // El campo [Código de vendedor] debe existir en la tabla [Vendedores.]
                    p_smResult.BllWarning("El dato [Código de vendedor] debe existir en la tabla [Vendedores.]","");
                    return;
                }
            }

            if (p_entCliente.Codtipocont.Trim() != "") {
                Tablas.TcnVKey(p_dbcAccess,
                               p_entCliente.Codtipocont,
                               p_smResult);
                if (p_smResult.NOk) return;

                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // El campo [Tipo Contrato] debe existir en la tabla [Tablas.Tcn]
                    p_smResult.BllWarning("El dato [Tipo Contrato] debe existir en la tabla [Tablas.Tcn]","");
                    return;
                }
            }

            if (p_entCliente.Codmarca.Trim() != "") {
                Tablas.MrcVKey(p_dbcAccess,
                               p_entCliente.Codmarca,
                               p_smResult);
                if (p_smResult.NOk) return;

                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // El campo [Marca] debe existir en la tabla [Tablas.Mrc]
                    p_smResult.BllWarning("El dato [Marca] debe existir en la tabla [Tablas.Mrc]","");
                    return;
                }
            }

            if (p_entCliente.Situacioniva.Trim() != "") {
                Tablas.SivVKey(p_dbcAccess,
                               p_entCliente.Situacioniva,
                               p_smResult);
                if (p_smResult.NOk) return;

                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // El campo [Situacion IVA] debe existir en la tabla [Tablas.Siv]
                    p_smResult.BllWarning("El dato [Situacion IVA] debe existir en la tabla [Tablas.Siv]","");
                    return;
                }
            }

            if (p_entCliente.Codrubro.Trim() != "") {
                Tablas.RbrVKey(p_dbcAccess,
                               p_entCliente.Codrubro,
                               p_smResult);
                if (p_smResult.NOk) return;

                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // El campo [Rubro] debe existir en la tabla [Tablas.Rbr]
                    p_smResult.BllWarning("El dato [Rubro] debe existir en la tabla [Tablas.Rbr]","");
                    return;
                }
            }

            // Todas las validaciones fueron correctas

            // Llamamos a la funcion fija del usuario
            TInt_f(p_dbcAccess, p_entCliente, p_smResult);
            if (p_smResult.NOk) return;
        }

        /// <summary>
        /// Verifica el número de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumero">Número de cliente</param>
        /// <param name="p_iFxdVersion">Número de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void VVer(DBConn p_dbcAccess,
                                  int p_iNumero,
                                  int p_iFxdVersion,
                                  StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            // Verificamos el número de versión
            Dal.Clientes.ChkVersion(p_dbcAccess,
                                    p_iNumero,
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
            p_smResult.BllWarning("El número de versión del registro del ítem (Cliente) no coincide.\r\nOperación cancelada.","");
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: ECliente
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave está deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumero">Número de cliente</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void VKey(DBConn p_dbcAccess,
                                  int p_iNumero,
                                  StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            Dal.Clientes.Search(p_dbcAccess,
                                p_iNumero,
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
        /// Devuelve una Lista-entidad: LEClientes
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEClientes</returns>
        internal static LEClientes Upfl(DBConn p_dbcAccess,
                                            bool p_bOnlyActive,
                                            StatMsg p_smResult)
        {
            try {
                // Pedimos los registros de la tabla: Clientes
                DataSet l_dsTemp= new DataSet();

                Dal.Clientes.Up(p_dbcAccess, 
                                p_bOnlyActive,
                                ref l_dsTemp, "Temporal",
                                p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.Clientes.MakeGridCaptions(ref l_dsTemp, "Temporal", p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LEClientes l_lentRet= new LEClientes(l_dsTemp.Tables["Temporal"]);
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
        /// Devuelve una entidad: ECliente
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumero">Número de cliente</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: ECliente</returns>
        internal static ECliente Srch(DBConn p_dbcAccess,
                                      int p_iNumero,
                                      bool p_bOnlyActive,
                                      StatMsg p_smResult)
        {
            try {
                // Pedimos el registro de la tabla: Clientes
                DataSet l_dsTemp= new DataSet();

                Dal.Clientes.Search(p_dbcAccess, 
                                    p_iNumero,
                                    p_bOnlyActive,
                                    ref l_dsTemp, "Temporal",
                                    p_smResult);
                if (p_smResult.NOk) return null;

                // Constuimos la entidad y la devolvemos (si vino un registro)
                ECliente l_entRet= null;

                if (l_dsTemp.Tables["Temporal"].Rows.Count == 1)
                    l_entRet= new ECliente(l_dsTemp.Tables["Temporal"].Rows[0]);

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
        /// Agrega un registro a la tabla a partir de una entidad: ECliente
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCliente">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void Insr(DBConn p_dbcAccess,
                                  ECliente p_entCliente,
                                  StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                TInt(p_dbcAccess, p_entCliente, p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: Clientes
                Dal.Clientes.Insert(p_dbcAccess,
                                    p_entCliente.Numero,
                                    p_entCliente.Rsocial,
                                    p_entCliente.Nombrefant,
                                    p_entCliente.Codtinst,
                                    p_entCliente.Codfrq,
                                    p_entCliente.Alta,
                                    p_entCliente.Telefono1,
                                    p_entCliente.Celular,
                                    p_entCliente.Telefono2,
                                    p_entCliente.Fax,
                                    p_entCliente.Direccion,
                                    p_entCliente.Altura,
                                    p_entCliente.Piso,
                                    p_entCliente.Oficina,
                                    p_entCliente.Codlocalidad,
                                    p_entCliente.Cuil,
                                    p_entCliente.Url,
                                    p_entCliente.Codvend,
                                    p_entCliente.Fechaingreso,
                                    p_entCliente.Cantempleados,
                                    p_entCliente.Cobertura,
                                    p_entCliente.Cargador,
                                    p_entCliente.Observacion,
                                    p_entCliente.Email,
                                    p_entCliente.Nroavalon,
                                    p_entCliente.Abono,
                                    p_entCliente.Codtipocont,
                                    p_entCliente.Deuda,
                                    p_entCliente.Sexo,
                                    p_entCliente.Tarjetacred,
                                    p_entCliente.Fueclienteantes,
                                    p_entCliente.Titular,
                                    p_entCliente.Direccioncobertura,
                                    p_entCliente.Alturacobertura,
                                    p_entCliente.Pisocobertura,
                                    p_entCliente.Oficinacobertura,
                                    p_entCliente.Codloccobertura,
                                    p_entCliente.Codmarca,
                                    p_entCliente.Tipocliente,
                                    p_entCliente.Apellido,
                                    p_entCliente.Fechanacimiento,
                                    p_entCliente.Situacioniva,
                                    p_entCliente.Nombre,
                                    p_entCliente.Codrubro,
                                    p_entCliente.Fecultimocontacto,
                                    p_entCliente.Fechaproxcontacto,
                                    p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Actualiza un registro a la tabla a partir de una entidad: ECliente
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCliente">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void Updt(DBConn p_dbcAccess,
                                  ECliente p_entCliente,
                                  StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                TInt(p_dbcAccess, p_entCliente, p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: Clientes
                Dal.Clientes.Update(p_dbcAccess,
                                    p_entCliente.Numero,
                                    p_entCliente.Rsocial,
                                    p_entCliente.Nombrefant,
                                    p_entCliente.Codtinst,
                                    p_entCliente.Codfrq,
                                    p_entCliente.Alta,
                                    p_entCliente.Telefono1,
                                    p_entCliente.Celular,
                                    p_entCliente.Telefono2,
                                    p_entCliente.Fax,
                                    p_entCliente.Direccion,
                                    p_entCliente.Altura,
                                    p_entCliente.Piso,
                                    p_entCliente.Oficina,
                                    p_entCliente.Codlocalidad,
                                    p_entCliente.Cuil,
                                    p_entCliente.Url,
                                    p_entCliente.Codvend,
                                    p_entCliente.Fechaingreso,
                                    p_entCliente.Cantempleados,
                                    p_entCliente.Cobertura,
                                    p_entCliente.Cargador,
                                    p_entCliente.Observacion,
                                    p_entCliente.Email,
                                    p_entCliente.Nroavalon,
                                    p_entCliente.Abono,
                                    p_entCliente.Codtipocont,
                                    p_entCliente.Deuda,
                                    p_entCliente.Sexo,
                                    p_entCliente.Tarjetacred,
                                    p_entCliente.Fueclienteantes,
                                    p_entCliente.Titular,
                                    p_entCliente.Direccioncobertura,
                                    p_entCliente.Alturacobertura,
                                    p_entCliente.Pisocobertura,
                                    p_entCliente.Oficinacobertura,
                                    p_entCliente.Codloccobertura,
                                    p_entCliente.Codmarca,
                                    p_entCliente.Tipocliente,
                                    p_entCliente.Apellido,
                                    p_entCliente.Fechanacimiento,
                                    p_entCliente.Situacioniva,
                                    p_entCliente.Nombre,
                                    p_entCliente.Codrubro,
                                    p_entCliente.Fecultimocontacto,
                                    p_entCliente.Fechaproxcontacto,
                                    p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra físicamente un registro de a tabla: Clientes
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumero">Número de cliente</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void Drop(DBConn p_dbcAccess,
                                  int p_iNumero,
                                  int p_iFxdVersion,
                                  StatMsg p_smResult)
        {
            try {
                // Verificamos la clave a borrar
                VKey(p_dbcAccess,
                     p_iNumero,
                     p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (Cliente) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                VVer(p_dbcAccess, 
                     p_iNumero,
                     p_iFxdVersion,
                     p_smResult);
                if (p_smResult.NOk) return;

                // Borramos físicamente el registro
                Dal.Clientes.Drop(p_dbcAccess,
                                  p_iNumero,
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
                Dal.Clientes.Pack(p_dbcAccess,
                                  p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: Clientes
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCliente">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void SSav(DBConn p_dbcAccess,
                                  ECliente p_entCliente,
                                  StatMsg p_smResult)
        {
            try {
                // Procesamos codigo fijo
                Save_f(p_dbcAccess, ref p_entCliente, p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                VKey(p_dbcAccess, 
                     p_entCliente.Numero,
                     p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entCliente.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El ítem (Cliente) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    Insr(p_dbcAccess, p_entCliente, p_smResult);
                }
                else {
                    // Es un update. La clave debe existir y estar habilitada
                    if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                        // Error. La clave no existe o no está habilitada
                        p_smResult.BllWarning("El ítem (Cliente) que intenta modificar no existe en el sistema o no está habilitado.","");
                        return;
                    }

                    // Debe coincidir el número de version
                    VVer(p_dbcAccess, 
                         p_entCliente.Numero,
                         p_entCliente.FxdVersion,
                         p_smResult);
                    if (p_smResult.NOk) return;

                    // Actualizamos el registro
                    Updt(p_dbcAccess, p_entCliente, p_smResult);
                }
                if (p_smResult.NOk) return;

                // Grabamos la lista-entidad: LECliContactos
                ClcSSav(p_dbcAccess,
                        p_entCliente.Numero,
                        p_entCliente.CliContactos,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Grabamos la lista-entidad: LECliEntrevistas
                CleSSav(p_dbcAccess,
                        p_entCliente.Numero,
                        p_entCliente.CliEntrevistas,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Grabamos la lista-entidad: LECliGrupoFamiliares
                CgfSSav(p_dbcAccess,
                        p_entCliente.Numero,
                        p_entCliente.CliGrupoFamiliares,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Grabamos la lista-entidad: LECliLlamadas
                CllSSav(p_dbcAccess,
                        p_entCliente.Numero,
                        p_entCliente.CliLlamadas,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Grabamos la lista-entidad: LECliNotas
                ClnSSav(p_dbcAccess,
                        p_entCliente.Numero,
                        p_entCliente.CliNotas,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Grabamos la lista-entidad: LECliServicios
                ClsSSav(p_dbcAccess,
                        p_entCliente.Numero,
                        p_entCliente.CliServicios,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Grabamos la lista-entidad: LECliVentas
                ClvSSav(p_dbcAccess,
                        p_entCliente.Numero,
                        p_entCliente.CliVentas,
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
        /// Ejecuta el SP definido por el usuario: BajaYBorraServicios
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_iNrocliente>Numero de Cliente</param>
        /// <param name= p_iCantdiascancel>Tope Cantidad de Dias Cancelacion Servicio</param>
        /// <param name= p_strCodcompetencia>Codigo de Competencia</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void BajaYBorraServicios(DBConn p_dbcAccess,
                                                 int p_iNrocliente,
                                                 int p_iCantdiascancel,
                                                 string p_strCodcompetencia,
                                                 StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                Dal.Clientes.BajaYBorraServicios(p_dbcAccess,
                                                 p_iNrocliente,
                                                 p_iCantdiascancel,
                                                 p_strCodcompetencia,
                                                 p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion
                p_smResult.BllError(l_expData);
            }
            finally {
                // Terminamos
            }
        }

        /// <summary>
        /// Ejecuta el SP definido por el usuario: BorraEntrevistasPend
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_iNumcliente>Numero de Cliente</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void BorraEntrevistasPend(DBConn p_dbcAccess,
                                                  int p_iNumcliente,
                                                  StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                Dal.Clientes.BorraEntrevistasPend(p_dbcAccess,
                                                  p_iNumcliente,
                                                  p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion
                p_smResult.BllError(l_expData);
            }
            finally {
                // Terminamos
            }
        }

        /// <summary>
        /// Ejecuta el SP definido por el usuario: CambiarMarcaVendido
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_strValoralta>Valor Alta (S/N)</param>
        /// <param name= p_iNrocliente>Numero de CLiente</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CambiarMarcaVendido(DBConn p_dbcAccess,
                                                 string p_strValoralta,
                                                 int p_iNrocliente,
                                                 StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                Dal.Clientes.CambiarMarcaVendido(p_dbcAccess,
                                                 p_strValoralta,
                                                 p_iNrocliente,
                                                 p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion
                p_smResult.BllError(l_expData);
            }
            finally {
                // Terminamos
            }
        }

        /// <summary>
        /// Ejecuta el SP definido por el usuario: GetFromNroAvln
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_iNroavalon>Numero de Avalon</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades GetFromNroAvln(DBConn p_dbcAccess,
                                                      int p_iNroavalon,
                                                      StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.Clientes.GetFromNroAvln(p_dbcAccess,
                                            p_iNroavalon,
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
        /// Ejecuta el SP definido por el usuario: GetPorClaveAvalon
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_iNroavalon>Numero de Avalon</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades GetPorClaveAvalon(DBConn p_dbcAccess,
                                                         int p_iNroavalon,
                                                         StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.Clientes.GetPorClaveAvalon(p_dbcAccess,
                                               p_iNroavalon,
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
        /// Ejecuta el SP definido por el usuario: GetRSocialCliente
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_iNumcliente>Número de cliente</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades GetRSocialCliente(DBConn p_dbcAccess,
                                                         int p_iNumcliente,
                                                         StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.Clientes.GetRSocialCliente(p_dbcAccess,
                                               p_iNumcliente,
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
        /// Ejecuta el SP definido por el usuario: GetSinCodVend
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_iNumero>Numero del cliente</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades GetSinCodVend(DBConn p_dbcAccess,
                                                     int p_iNumero,
                                                     StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.Clientes.GetSinCodVend(p_dbcAccess,
                                           p_iNumero,
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
        /// Ejecuta el SP definido por el usuario: GetTodosLosClientes
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades GetTodosLosClientes(DBConn p_dbcAccess,
                                                           StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.Clientes.GetTodosLosClientes(p_dbcAccess,
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
        /// Ejecuta el SP definido por el usuario: GetVendidos
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_strCodvend>Codigo de Vendedor</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades GetVendidos(DBConn p_dbcAccess,
                                                   string p_strCodvend,
                                                   StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.Clientes.GetVendidos(p_dbcAccess,
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
        /// Ejecuta el SP definido por el usuario: UpdateAbono
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_iNrocliente>Numero de Cliente</param>
        /// <param name= p_dcNuevoabono>Nuevo Abono</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void UpdateAbono(DBConn p_dbcAccess,
                                         int p_iNrocliente,
                                         decimal p_dcNuevoabono,
                                         StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                Dal.Clientes.UpdateAbono(p_dbcAccess,
                                         p_iNrocliente,
                                         p_dcNuevoabono,
                                         p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion
                p_smResult.BllError(l_expData);
            }
            finally {
                // Terminamos
            }
        }

        /// <summary>
        /// Ejecuta el SP definido por el usuario: ValidaDir
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_strDir>Direccion del nuevo Cliente</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades ValidaDir(DBConn p_dbcAccess,
                                                 string p_strDir,
                                                 StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.Clientes.ValidaDir(p_dbcAccess,
                                       p_strDir,
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
        /// Ejecuta el SP definido por el usuario: ValidaRSocial
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_strRazonsocial>Razon Social del Nuevo Cliente</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades ValidaRSocial(DBConn p_dbcAccess,
                                                     string p_strRazonsocial,
                                                     StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.Clientes.ValidaRSocial(p_dbcAccess,
                                           p_strRazonsocial,
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
        /// Ejecuta el SP definido por el usuario: ValidaTelefono
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_strTelefono>Telefono del Nuevo Cliente</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades ValidaTelefono(DBConn p_dbcAccess,
                                                      string p_strTelefono,
                                                      StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.Clientes.ValidaTelefono(p_dbcAccess,
                                            p_strTelefono,
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
        /// Ejecuta el SP definido por el usuario: ValidarExistenciaAvl
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_iNroavalon>Numero de Avalon</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades ValidarExistenciaAvl(DBConn p_dbcAccess,
                                                            int p_iNroavalon,
                                                            StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.Clientes.ValidarExistenciaAvl(p_dbcAccess,
                                                  p_iNroavalon,
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
        /// Ejecuta el SP definido por el usuario: Vendido
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_iNumero>Numero del Cliente</param>
        /// <param name= p_dcAbono>Abono vendido</param>
        /// <param name= p_strCodtipocont>Cod Tipo de Contrato Vendido</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void Vendido(DBConn p_dbcAccess,
                                     int p_iNumero,
                                     decimal p_dcAbono,
                                     string p_strCodtipocont,
                                     StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                Dal.Clientes.Vendido(p_dbcAccess,
                                     p_iNumero,
                                     p_dcAbono,
                                     p_strCodtipocont,
                                     p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion
                p_smResult.BllError(l_expData);
            }
            finally {
                // Terminamos
            }
        }

        /// <summary>
        /// Ejecuta el SP definido por el usuario: ZCargadores
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_dtFechaini>Fecha Inicio</param>
        /// <param name= p_dtFechafin>Fecha Fin</param>
        /// <param name= p_strIninomcargador>Inicio Nombre cargador</param>
        /// <param name= p_strFinnomcargador>Fin Nombre cargador</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades ZCargadores(DBConn p_dbcAccess,
                                                   DateTime p_dtFechaini,
                                                   DateTime p_dtFechafin,
                                                   string p_strIninomcargador,
                                                   string p_strFinnomcargador,
                                                   StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.Clientes.ZCargadores(p_dbcAccess,
                                         p_dtFechaini,
                                         p_dtFechafin,
                                         p_strIninomcargador,
                                         p_strFinnomcargador,
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
        /// Ejecuta el SP definido por el usuario: ZLog
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_strIninomusuario>Inicio nombre usuario</param>
        /// <param name= p_strFinnomusuario>Fin nombre usuario</param>
        /// <param name= p_dtFechaini>Fecha Inicio</param>
        /// <param name= p_dtFechafin>Fecha Fin</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades ZLog(DBConn p_dbcAccess,
                                            string p_strIninomusuario,
                                            string p_strFinnomusuario,
                                            DateTime p_dtFechaini,
                                            DateTime p_dtFechafin,
                                            StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.Clientes.ZLog(p_dbcAccess,
                                  p_strIninomusuario,
                                  p_strFinnomusuario,
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
        #endregion
    }
}
