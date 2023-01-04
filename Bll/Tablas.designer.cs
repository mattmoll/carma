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
    // Fecha                    : 04/01/2023 00:10
    // Sistema                  : Carm
    // Clase para Administrar   : Tablas
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
    /// Mantenimiento de: Tablas
    /// </summary>
    public static partial class Tablas
    {

        //**********************************************************
        //
        // Funciones para la Tabla: CategoriasLlamada
        // Usando ClaseDal        : CategoriasLlamada
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos públicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: CategoriasLlamada
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LECategoriasLlamada</returns>
        public static LECategoriasLlamada CtlUpFull(bool p_bOnlyActive,
                                                    StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                return CtlUpfl(l_dbcAccess, p_bOnlyActive, p_smResult);
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
        /// Devuelve una entidad: ECategoriaLlamada
        /// </summary>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: ECategoriaLlamada</returns>
        public static ECategoriaLlamada CtlGet(string p_strCod,
                                               bool p_bOnlyActive,
                                               StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCod= ECategoriaLlamada.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: ECategoriaLlamada
                return CtlSrch(l_dbcAccess,
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

        /// <summary>
        /// Devuelve la próxima clave de la entidad
        /// </summary>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Próxima clave</returns>
        public static string CtlNextKey(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la clave máxima
                return CtlGetNK(l_dbcAccess,
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

        #region Metodos publicos de grabacion

        /// <summary>
        /// Agrega o modifica un registro de la tabla: CategoriasLlamada
        /// </summary>
        /// <param name="p_entCategoriaLlamada">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void CtlSave(ECategoriaLlamada p_entCategoriaLlamada,
                                   StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: ECategoriaLlamada
                CtlSSav(l_dbcAccess, p_entCategoriaLlamada, p_smResult);
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
        /// Habilita/Deshabilita un registro de la tabla: CategoriasLlamada
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void CtlEnabled(bool p_bEnable,
                                      string p_strCod,
                                      int p_iFxdVersion,
                                      StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCod= ECategoriaLlamada.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                CtlEnabled_f(l_dbcAccess,
                             p_bEnable,
                             p_strCod,
                             ref p_iFxdVersion,
                             p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                CtlVKey(l_dbcAccess,
                        p_strCod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (CategoriaLlamada) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                CtlVVer(l_dbcAccess, 
                        p_strCod,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.CategoriasLlamada.Recall(l_dbcAccess,
                                                 p_strCod,
                                                 p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.CategoriasLlamada.Delete(l_dbcAccess,
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
        /// Borra físicamento un registro de la tabla: CategoriasLlamada
        /// </summary>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void CtlRemove(string p_strCod,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCod= ECategoriaLlamada.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                CtlRemove_f(l_dbcAccess,
                            p_strCod,
                            p_iFxdVersion,
                            p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                CtlDrop(l_dbcAccess,
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
        public static void CtlPurge(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Realizamos el borrado
                CtlPack(l_dbcAccess,
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
        /// Valida la integridad de una entidad: CategoriaLlamada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCategoriaLlamada">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CtlTInt(DBConn p_dbcAccess,
                                     ECategoriaLlamada p_entCategoriaLlamada,
                                     StatMsg p_smResult)
        {
            // ********
            // Validaciones de los campos sin conexion
            // ********

            if (p_entCategoriaLlamada.Cod.Trim() == "") {
                // El campo [Codigo] no puede ser vacío
                p_smResult.BllWarning("El dato [Codigo] no puede ser vacío","");
                return;
            }

            if (p_entCategoriaLlamada.Des.Trim() == "") {
                // El campo [Categoría] no puede ser vacío
                p_smResult.BllWarning("El dato [Categoría] no puede ser vacío","");
                return;
            }

            if ((p_entCategoriaLlamada.Tipo != "E") &&
                (p_entCategoriaLlamada.Tipo != "S")) {
                // El campo [Tipo de llamada] tiene opciones
                p_smResult.BllWarning("El dato [Tipo de llamada] sólo admite\r\n\r\n[E]- ENTRADA\r\n[S]- SALIDA\r\n","");
                return;
            }

            // ********
            // Validaciones de los campos con conexion
            // ********

            // Llamamos a la funcion fija del usuario
            CtlTInt_f(p_dbcAccess, p_entCategoriaLlamada, p_smResult);
            if (p_smResult.NOk) return;
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: ECategoriaLlamada
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave está deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CtlVKey(DBConn p_dbcAccess,
                                     string p_strCod,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            Dal.CategoriasLlamada.Search(p_dbcAccess,
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

        /// <summary>
        /// Verifica el número de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_iFxdVersion">Número de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CtlVVer(DBConn p_dbcAccess,
                                     string p_strCod,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            // Verificamos el número de versión
            Dal.CategoriasLlamada.ChkVersion(p_dbcAccess,
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
            p_smResult.BllWarning("El número de versión del registro del ítem (CategoriaLlamada) no coincide.\r\nOperación cancelada.","");
        }
        #endregion

        #region Metodos internos de recupero

        /// <summary>
        /// Devuelve una Lista-entidad: LECategoriasLlamada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LECategoriasLlamada</returns>
        internal static LECategoriasLlamada CtlUpfl(DBConn p_dbcAccess,
                                                     bool p_bOnlyActive,
                                                     StatMsg p_smResult)
        {
            try {
                // Pedimos los registros de la tabla: CategoriasLlamada
                DataSet l_dsTemp= new DataSet();

                Dal.CategoriasLlamada.Up(p_dbcAccess, 
                                         p_bOnlyActive,
                                         ref l_dsTemp, "Temporal",
                                         p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.CategoriasLlamada.MakeGridCaptions(ref l_dsTemp, "Temporal", p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LECategoriasLlamada l_lentRet= new LECategoriasLlamada(l_dsTemp.Tables["Temporal"]);
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
        /// Devuelve una entidad: ECategoriaLlamada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: ECategoriaLlamada</returns>
        internal static ECategoriaLlamada CtlSrch(DBConn p_dbcAccess,
                                                  string p_strCod,
                                                  bool p_bOnlyActive,
                                                  StatMsg p_smResult)
        {
            try {
                // Pedimos el registro de la tabla: CategoriasLlamada
                DataSet l_dsTemp= new DataSet();

                Dal.CategoriasLlamada.Search(p_dbcAccess, 
                                             p_strCod,
                                             p_bOnlyActive,
                                             ref l_dsTemp, "Temporal",
                                             p_smResult);
                if (p_smResult.NOk) return null;

                // Constuimos la entidad y la devolvemos (si vino un registro)
                ECategoriaLlamada l_entRet= null;

                if (l_dsTemp.Tables["Temporal"].Rows.Count == 1)
                    l_entRet= new ECategoriaLlamada(l_dsTemp.Tables["Temporal"].Rows[0]);

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
        internal static string CtlGetNK(DBConn p_dbcAccess,
                                        StatMsg p_smResult)
        {
            try {
                // Pedimos la clave máxima
                DataSet l_dsTemp= new DataSet();

                Dal.CategoriasLlamada.GetMaxKey(p_dbcAccess,
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
        /// Agrega o modifica un registro de la tabla: CategoriasLlamada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCategoriaLlamada">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CtlSSav(DBConn p_dbcAccess,
                                     ECategoriaLlamada p_entCategoriaLlamada,
                                     StatMsg p_smResult)
        {
            try {
                // Procesamos codigo fijo
                CtlSave_f(p_dbcAccess, ref p_entCategoriaLlamada, p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                CtlVKey(p_dbcAccess, 
                        p_entCategoriaLlamada.Cod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entCategoriaLlamada.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El ítem (CategoriaLlamada) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    CtlInsr(p_dbcAccess, p_entCategoriaLlamada, p_smResult);
                    return;
                }

                // Es un update. La clave debe existir y estar habilitada
                if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                    // Error. La clave no existe o no está habilitada
                    p_smResult.BllWarning("El ítem (CategoriaLlamada) que intenta modificar no existe en el sistema o no está habilitado.","");
                    return;
                }

                // Debe coincidir el número de version
                CtlVVer(p_dbcAccess, 
                        p_entCategoriaLlamada.Cod,
                        p_entCategoriaLlamada.FxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos el registro
                CtlUpdt(p_dbcAccess, p_entCategoriaLlamada, p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Agrega un registro a la tabla a partir de una entidad: ECategoriaLlamada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCategoriaLlamada">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CtlInsr(DBConn p_dbcAccess,
                                     ECategoriaLlamada p_entCategoriaLlamada,
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                CtlTInt(p_dbcAccess, p_entCategoriaLlamada, p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: CategoriasLlamada
                Dal.CategoriasLlamada.Insert(p_dbcAccess,
                                             p_entCategoriaLlamada.Cod,
                                             p_entCategoriaLlamada.Des,
                                             p_entCategoriaLlamada.Tipo,
                                             p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Actualiza un registro a la tabla a partir de una entidad: ECategoriaLlamada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCategoriaLlamada">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CtlUpdt(DBConn p_dbcAccess,
                                     ECategoriaLlamada p_entCategoriaLlamada,
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                CtlTInt(p_dbcAccess, p_entCategoriaLlamada, p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: CategoriasLlamada
                Dal.CategoriasLlamada.Update(p_dbcAccess,
                                             p_entCategoriaLlamada.Cod,
                                             p_entCategoriaLlamada.Des,
                                             p_entCategoriaLlamada.Tipo,
                                             p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra físicamente un registro de a tabla: CategoriasLlamada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CtlDrop(DBConn p_dbcAccess,
                                     string p_strCod,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            try {
                // Verificamos la clave a borrar
                CtlVKey(p_dbcAccess,
                        p_strCod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (CategoriaLlamada) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                CtlVVer(p_dbcAccess, 
                        p_strCod,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Borramos físicamente el registro
                Dal.CategoriasLlamada.Drop(p_dbcAccess,
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
        internal static void CtlPack(DBConn p_dbcAccess,
                                     StatMsg p_smResult)
        {
            try {
                // Borramos los borrados lógicamente
                Dal.CategoriasLlamada.Pack(p_dbcAccess,
                                           p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }
        #endregion

        #region Metodos para métodos DAL definidos por el usuario
        #endregion


        //**********************************************************
        //
        // Funciones para la Tabla: ConversionColores
        // Usando ClaseDal        : ConversionColores
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos públicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: ConversionColores
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEConversionColores</returns>
        public static LEConversionColores ConUpFull(bool p_bOnlyActive,
                                                    StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                return ConUpfl(l_dbcAccess, p_bOnlyActive, p_smResult);
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
        /// Devuelve una entidad: EConversionColor
        /// </summary>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EConversionColor</returns>
        public static EConversionColor ConGet(string p_strCod,
                                              bool p_bOnlyActive,
                                              StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCod= EConversionColor.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: EConversionColor
                return ConSrch(l_dbcAccess,
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

        /// <summary>
        /// Devuelve la próxima clave de la entidad
        /// </summary>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Próxima clave</returns>
        public static string ConNextKey(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la clave máxima
                return ConGetNK(l_dbcAccess,
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

        #region Metodos publicos de grabacion

        /// <summary>
        /// Agrega o modifica un registro de la tabla: ConversionColores
        /// </summary>
        /// <param name="p_entConversionColor">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void ConSave(EConversionColor p_entConversionColor,
                                   StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: EConversionColor
                ConSSav(l_dbcAccess, p_entConversionColor, p_smResult);
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
        /// Habilita/Deshabilita un registro de la tabla: ConversionColores
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void ConEnabled(bool p_bEnable,
                                      string p_strCod,
                                      int p_iFxdVersion,
                                      StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCod= EConversionColor.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                ConEnabled_f(l_dbcAccess,
                             p_bEnable,
                             p_strCod,
                             ref p_iFxdVersion,
                             p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                ConVKey(l_dbcAccess,
                        p_strCod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (ConversionColor) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                ConVVer(l_dbcAccess, 
                        p_strCod,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.ConversionColores.Recall(l_dbcAccess,
                                                 p_strCod,
                                                 p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.ConversionColores.Delete(l_dbcAccess,
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
        /// Borra físicamento un registro de la tabla: ConversionColores
        /// </summary>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void ConRemove(string p_strCod,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCod= EConversionColor.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                ConRemove_f(l_dbcAccess,
                            p_strCod,
                            p_iFxdVersion,
                            p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                ConDrop(l_dbcAccess,
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
        public static void ConPurge(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Realizamos el borrado
                ConPack(l_dbcAccess,
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
        /// Ejecuta el SP definido por el usuario: getConvertido
        /// </summary>
        /// <param name= p_strColoraconvertir>Color a Convertir</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        public static ListaEntidades CongetConvertido(string p_strColoraconvertir,
                                                      StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Abrimos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Llamamos al metodo interno
                return CongetConvertido(l_dbcAccess,
                                        p_strColoraconvertir,
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
        /// Valida la integridad de una entidad: ConversionColor
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entConversionColor">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ConTInt(DBConn p_dbcAccess,
                                     EConversionColor p_entConversionColor,
                                     StatMsg p_smResult)
        {
            // ********
            // Validaciones de los campos sin conexion
            // ********

            if (p_entConversionColor.Cod.Trim() == "") {
                // El campo [Código] no puede ser vacío
                p_smResult.BllWarning("El dato [Código] no puede ser vacío","");
                return;
            }

            if (p_entConversionColor.Coloraconvertir.Trim() == "") {
                // El campo [Color a Convertir] no puede ser vacío
                p_smResult.BllWarning("El dato [Color a Convertir] no puede ser vacío","");
                return;
            }

            if ((p_entConversionColor.Colorconvertido != "V") &&
                (p_entConversionColor.Colorconvertido != "A") &&
                (p_entConversionColor.Colorconvertido != "R") &&
                (p_entConversionColor.Colorconvertido != "T")) {
                // El campo [Color Convertido] tiene opciones
                p_smResult.BllWarning("El dato [Color Convertido] sólo admite\r\n\r\n[V]- VERDE\r\n[A]- AMARILLO\r\n[R]- ROJO\r\n[T]- TRASLADO\r\n","");
                return;
            }

            // ********
            // Validaciones de los campos con conexion
            // ********

            // Llamamos a la funcion fija del usuario
            ConTInt_f(p_dbcAccess, p_entConversionColor, p_smResult);
            if (p_smResult.NOk) return;
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: EConversionColor
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave está deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ConVKey(DBConn p_dbcAccess,
                                     string p_strCod,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            Dal.ConversionColores.Search(p_dbcAccess,
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

        /// <summary>
        /// Verifica el número de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_iFxdVersion">Número de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ConVVer(DBConn p_dbcAccess,
                                     string p_strCod,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            // Verificamos el número de versión
            Dal.ConversionColores.ChkVersion(p_dbcAccess,
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
            p_smResult.BllWarning("El número de versión del registro del ítem (ConversionColor) no coincide.\r\nOperación cancelada.","");
        }
        #endregion

        #region Metodos internos de recupero

        /// <summary>
        /// Devuelve una Lista-entidad: LEConversionColores
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEConversionColores</returns>
        internal static LEConversionColores ConUpfl(DBConn p_dbcAccess,
                                                     bool p_bOnlyActive,
                                                     StatMsg p_smResult)
        {
            try {
                // Pedimos los registros de la tabla: ConversionColores
                DataSet l_dsTemp= new DataSet();

                Dal.ConversionColores.Up(p_dbcAccess, 
                                         p_bOnlyActive,
                                         ref l_dsTemp, "Temporal",
                                         p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.ConversionColores.MakeGridCaptions(ref l_dsTemp, "Temporal", p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LEConversionColores l_lentRet= new LEConversionColores(l_dsTemp.Tables["Temporal"]);
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
        /// Devuelve una entidad: EConversionColor
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EConversionColor</returns>
        internal static EConversionColor ConSrch(DBConn p_dbcAccess,
                                                 string p_strCod,
                                                 bool p_bOnlyActive,
                                                 StatMsg p_smResult)
        {
            try {
                // Pedimos el registro de la tabla: ConversionColores
                DataSet l_dsTemp= new DataSet();

                Dal.ConversionColores.Search(p_dbcAccess, 
                                             p_strCod,
                                             p_bOnlyActive,
                                             ref l_dsTemp, "Temporal",
                                             p_smResult);
                if (p_smResult.NOk) return null;

                // Constuimos la entidad y la devolvemos (si vino un registro)
                EConversionColor l_entRet= null;

                if (l_dsTemp.Tables["Temporal"].Rows.Count == 1)
                    l_entRet= new EConversionColor(l_dsTemp.Tables["Temporal"].Rows[0]);

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
        internal static string ConGetNK(DBConn p_dbcAccess,
                                        StatMsg p_smResult)
        {
            try {
                // Pedimos la clave máxima
                DataSet l_dsTemp= new DataSet();

                Dal.ConversionColores.GetMaxKey(p_dbcAccess,
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
        /// Agrega o modifica un registro de la tabla: ConversionColores
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entConversionColor">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ConSSav(DBConn p_dbcAccess,
                                     EConversionColor p_entConversionColor,
                                     StatMsg p_smResult)
        {
            try {
                // Procesamos codigo fijo
                ConSave_f(p_dbcAccess, ref p_entConversionColor, p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                ConVKey(p_dbcAccess, 
                        p_entConversionColor.Cod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entConversionColor.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El ítem (ConversionColor) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    ConInsr(p_dbcAccess, p_entConversionColor, p_smResult);
                    return;
                }

                // Es un update. La clave debe existir y estar habilitada
                if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                    // Error. La clave no existe o no está habilitada
                    p_smResult.BllWarning("El ítem (ConversionColor) que intenta modificar no existe en el sistema o no está habilitado.","");
                    return;
                }

                // Debe coincidir el número de version
                ConVVer(p_dbcAccess, 
                        p_entConversionColor.Cod,
                        p_entConversionColor.FxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos el registro
                ConUpdt(p_dbcAccess, p_entConversionColor, p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Agrega un registro a la tabla a partir de una entidad: EConversionColor
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entConversionColor">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ConInsr(DBConn p_dbcAccess,
                                     EConversionColor p_entConversionColor,
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                ConTInt(p_dbcAccess, p_entConversionColor, p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: ConversionColores
                Dal.ConversionColores.Insert(p_dbcAccess,
                                             p_entConversionColor.Cod,
                                             p_entConversionColor.Coloraconvertir,
                                             p_entConversionColor.Colorconvertido,
                                             p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Actualiza un registro a la tabla a partir de una entidad: EConversionColor
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entConversionColor">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ConUpdt(DBConn p_dbcAccess,
                                     EConversionColor p_entConversionColor,
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                ConTInt(p_dbcAccess, p_entConversionColor, p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: ConversionColores
                Dal.ConversionColores.Update(p_dbcAccess,
                                             p_entConversionColor.Cod,
                                             p_entConversionColor.Coloraconvertir,
                                             p_entConversionColor.Colorconvertido,
                                             p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra físicamente un registro de a tabla: ConversionColores
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ConDrop(DBConn p_dbcAccess,
                                     string p_strCod,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            try {
                // Verificamos la clave a borrar
                ConVKey(p_dbcAccess,
                        p_strCod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (ConversionColor) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                ConVVer(p_dbcAccess, 
                        p_strCod,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Borramos físicamente el registro
                Dal.ConversionColores.Drop(p_dbcAccess,
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
        internal static void ConPack(DBConn p_dbcAccess,
                                     StatMsg p_smResult)
        {
            try {
                // Borramos los borrados lógicamente
                Dal.ConversionColores.Pack(p_dbcAccess,
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
        /// Ejecuta el SP definido por el usuario: getConvertido
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_strColoraconvertir>Color a Convertir</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades CongetConvertido(DBConn p_dbcAccess,
                                                        string p_strColoraconvertir,
                                                        StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.ConversionColores.getConvertido(p_dbcAccess,
                                                    p_strColoraconvertir,
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
        // Funciones para la Tabla: Franquicias
        // Usando ClaseDal        : Franquicias
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos públicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: Franquicias
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEFranquicias</returns>
        public static LEFranquicias FrqUpFull(bool p_bOnlyActive,
                                              StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                return FrqUpfl(l_dbcAccess, p_bOnlyActive, p_smResult);
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
        /// Devuelve una entidad: EFranquicia
        /// </summary>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EFranquicia</returns>
        public static EFranquicia FrqGet(string p_strCod,
                                         bool p_bOnlyActive,
                                         StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCod= EFranquicia.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: EFranquicia
                return FrqSrch(l_dbcAccess,
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

        /// <summary>
        /// Devuelve la próxima clave de la entidad
        /// </summary>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Próxima clave</returns>
        public static string FrqNextKey(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la clave máxima
                return FrqGetNK(l_dbcAccess,
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

        #region Metodos publicos de grabacion

        /// <summary>
        /// Agrega o modifica un registro de la tabla: Franquicias
        /// </summary>
        /// <param name="p_entFranquicia">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void FrqSave(EFranquicia p_entFranquicia,
                                   StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: EFranquicia
                FrqSSav(l_dbcAccess, p_entFranquicia, p_smResult);
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
        /// Habilita/Deshabilita un registro de la tabla: Franquicias
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void FrqEnabled(bool p_bEnable,
                                      string p_strCod,
                                      int p_iFxdVersion,
                                      StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCod= EFranquicia.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                FrqEnabled_f(l_dbcAccess,
                             p_bEnable,
                             p_strCod,
                             ref p_iFxdVersion,
                             p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                FrqVKey(l_dbcAccess,
                        p_strCod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (Franquicia) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                FrqVVer(l_dbcAccess, 
                        p_strCod,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.Franquicias.Recall(l_dbcAccess,
                                           p_strCod,
                                           p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.Franquicias.Delete(l_dbcAccess,
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
        /// Borra físicamento un registro de la tabla: Franquicias
        /// </summary>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void FrqRemove(string p_strCod,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCod= EFranquicia.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                FrqRemove_f(l_dbcAccess,
                            p_strCod,
                            p_iFxdVersion,
                            p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                FrqDrop(l_dbcAccess,
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
        public static void FrqPurge(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Realizamos el borrado
                FrqPack(l_dbcAccess,
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
        /// Valida la integridad de una entidad: Franquicia
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entFranquicia">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void FrqTInt(DBConn p_dbcAccess,
                                     EFranquicia p_entFranquicia,
                                     StatMsg p_smResult)
        {
            // ********
            // Validaciones de los campos sin conexion
            // ********

            if (p_entFranquicia.Cod.Trim() == "") {
                // El campo [Codigo] no puede ser vacío
                p_smResult.BllWarning("El dato [Codigo] no puede ser vacío","");
                return;
            }

            if (p_entFranquicia.Des.Trim() == "") {
                // El campo [Descripcion] no puede ser vacío
                p_smResult.BllWarning("El dato [Descripcion] no puede ser vacío","");
                return;
            }

            // ********
            // Validaciones de los campos con conexion
            // ********

            // Llamamos a la funcion fija del usuario
            FrqTInt_f(p_dbcAccess, p_entFranquicia, p_smResult);
            if (p_smResult.NOk) return;
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: EFranquicia
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave está deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void FrqVKey(DBConn p_dbcAccess,
                                     string p_strCod,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            Dal.Franquicias.Search(p_dbcAccess,
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

        /// <summary>
        /// Verifica el número de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_iFxdVersion">Número de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void FrqVVer(DBConn p_dbcAccess,
                                     string p_strCod,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            // Verificamos el número de versión
            Dal.Franquicias.ChkVersion(p_dbcAccess,
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
            p_smResult.BllWarning("El número de versión del registro del ítem (Franquicia) no coincide.\r\nOperación cancelada.","");
        }
        #endregion

        #region Metodos internos de recupero

        /// <summary>
        /// Devuelve una Lista-entidad: LEFranquicias
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEFranquicias</returns>
        internal static LEFranquicias FrqUpfl(DBConn p_dbcAccess,
                                               bool p_bOnlyActive,
                                               StatMsg p_smResult)
        {
            try {
                // Pedimos los registros de la tabla: Franquicias
                DataSet l_dsTemp= new DataSet();

                Dal.Franquicias.Up(p_dbcAccess, 
                                   p_bOnlyActive,
                                   ref l_dsTemp, "Temporal",
                                   p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.Franquicias.MakeGridCaptions(ref l_dsTemp, "Temporal", p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LEFranquicias l_lentRet= new LEFranquicias(l_dsTemp.Tables["Temporal"]);
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
        /// Devuelve una entidad: EFranquicia
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EFranquicia</returns>
        internal static EFranquicia FrqSrch(DBConn p_dbcAccess,
                                            string p_strCod,
                                            bool p_bOnlyActive,
                                            StatMsg p_smResult)
        {
            try {
                // Pedimos el registro de la tabla: Franquicias
                DataSet l_dsTemp= new DataSet();

                Dal.Franquicias.Search(p_dbcAccess, 
                                       p_strCod,
                                       p_bOnlyActive,
                                       ref l_dsTemp, "Temporal",
                                       p_smResult);
                if (p_smResult.NOk) return null;

                // Constuimos la entidad y la devolvemos (si vino un registro)
                EFranquicia l_entRet= null;

                if (l_dsTemp.Tables["Temporal"].Rows.Count == 1)
                    l_entRet= new EFranquicia(l_dsTemp.Tables["Temporal"].Rows[0]);

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
        internal static string FrqGetNK(DBConn p_dbcAccess,
                                        StatMsg p_smResult)
        {
            try {
                // Pedimos la clave máxima
                DataSet l_dsTemp= new DataSet();

                Dal.Franquicias.GetMaxKey(p_dbcAccess,
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
        /// Agrega o modifica un registro de la tabla: Franquicias
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entFranquicia">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void FrqSSav(DBConn p_dbcAccess,
                                     EFranquicia p_entFranquicia,
                                     StatMsg p_smResult)
        {
            try {
                // Procesamos codigo fijo
                FrqSave_f(p_dbcAccess, ref p_entFranquicia, p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                FrqVKey(p_dbcAccess, 
                        p_entFranquicia.Cod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entFranquicia.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El ítem (Franquicia) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    FrqInsr(p_dbcAccess, p_entFranquicia, p_smResult);
                    return;
                }

                // Es un update. La clave debe existir y estar habilitada
                if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                    // Error. La clave no existe o no está habilitada
                    p_smResult.BllWarning("El ítem (Franquicia) que intenta modificar no existe en el sistema o no está habilitado.","");
                    return;
                }

                // Debe coincidir el número de version
                FrqVVer(p_dbcAccess, 
                        p_entFranquicia.Cod,
                        p_entFranquicia.FxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos el registro
                FrqUpdt(p_dbcAccess, p_entFranquicia, p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Agrega un registro a la tabla a partir de una entidad: EFranquicia
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entFranquicia">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void FrqInsr(DBConn p_dbcAccess,
                                     EFranquicia p_entFranquicia,
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                FrqTInt(p_dbcAccess, p_entFranquicia, p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: Franquicias
                Dal.Franquicias.Insert(p_dbcAccess,
                                       p_entFranquicia.Cod,
                                       p_entFranquicia.Des,
                                       p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Actualiza un registro a la tabla a partir de una entidad: EFranquicia
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entFranquicia">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void FrqUpdt(DBConn p_dbcAccess,
                                     EFranquicia p_entFranquicia,
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                FrqTInt(p_dbcAccess, p_entFranquicia, p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: Franquicias
                Dal.Franquicias.Update(p_dbcAccess,
                                       p_entFranquicia.Cod,
                                       p_entFranquicia.Des,
                                       p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra físicamente un registro de a tabla: Franquicias
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void FrqDrop(DBConn p_dbcAccess,
                                     string p_strCod,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            try {
                // Verificamos la clave a borrar
                FrqVKey(p_dbcAccess,
                        p_strCod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (Franquicia) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                FrqVVer(p_dbcAccess, 
                        p_strCod,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Borramos físicamente el registro
                Dal.Franquicias.Drop(p_dbcAccess,
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
        internal static void FrqPack(DBConn p_dbcAccess,
                                     StatMsg p_smResult)
        {
            try {
                // Borramos los borrados lógicamente
                Dal.Franquicias.Pack(p_dbcAccess,
                                     p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }
        #endregion

        #region Metodos para métodos DAL definidos por el usuario
        #endregion


        //**********************************************************
        //
        // Funciones para la Tabla: ListasDePrecios
        // Usando ClaseDal        : ListasDePrecios
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos públicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: ListasDePrecios
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEListasDePrecios</returns>
        public static LEListasDePrecios LprUpFull(bool p_bOnlyActive,
                                                  StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                return LprUpfl(l_dbcAccess, p_bOnlyActive, p_smResult);
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
        /// Devuelve una entidad: EListaDePrecios
        /// </summary>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EListaDePrecios</returns>
        public static EListaDePrecios LprGet(string p_strCod,
                                             bool p_bOnlyActive,
                                             StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: EListaDePrecios
                return LprSrch(l_dbcAccess,
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
        /// Agrega o modifica un registro de la tabla: ListasDePrecios
        /// </summary>
        /// <param name="p_entListaDePrecios">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void LprSave(EListaDePrecios p_entListaDePrecios,
                                   StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: EListaDePrecios
                LprSSav(l_dbcAccess, p_entListaDePrecios, p_smResult);
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
        /// Habilita/Deshabilita un registro de la tabla: ListasDePrecios
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void LprEnabled(bool p_bEnable,
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
                LprEnabled_f(l_dbcAccess,
                             p_bEnable,
                             p_strCod,
                             ref p_iFxdVersion,
                             p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                LprVKey(l_dbcAccess,
                        p_strCod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (ListaDePrecios) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                LprVVer(l_dbcAccess, 
                        p_strCod,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.ListasDePrecios.Recall(l_dbcAccess,
                                               p_strCod,
                                               p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.ListasDePrecios.Delete(l_dbcAccess,
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
        /// Borra físicamento un registro de la tabla: ListasDePrecios
        /// </summary>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void LprRemove(string p_strCod,
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
                LprRemove_f(l_dbcAccess,
                            p_strCod,
                            p_iFxdVersion,
                            p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                LprDrop(l_dbcAccess,
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
        public static void LprPurge(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Realizamos el borrado
                LprPack(l_dbcAccess,
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
        /// Valida la integridad de una entidad: ListaDePrecios
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entListaDePrecios">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void LprTInt(DBConn p_dbcAccess,
                                     EListaDePrecios p_entListaDePrecios,
                                     StatMsg p_smResult)
        {
            // ********
            // Validaciones de los campos sin conexion
            // ********

            // ********
            // Validaciones de los campos con conexion
            // ********

            Planes.VKey(p_dbcAccess,
                        p_entListaDePrecios.Codplan,
                        p_smResult);
            if (p_smResult.NOk) return;

            if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                // El campo [Plan] debe existir en la tabla [Planes.]
                p_smResult.BllWarning("El dato [Plan] debe existir en la tabla [Planes.]","");
                return;
            }

            Tablas.MrcVKey(p_dbcAccess,
                           p_entListaDePrecios.Codmarca,
                           p_smResult);
            if (p_smResult.NOk) return;

            if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                // El campo [Marca] debe existir en la tabla [Tablas.Mrc]
                p_smResult.BllWarning("El dato [Marca] debe existir en la tabla [Tablas.Mrc]","");
                return;
            }

            // Todas las validaciones fueron correctas

            // Llamamos a la funcion fija del usuario
            LprTInt_f(p_dbcAccess, p_entListaDePrecios, p_smResult);
            if (p_smResult.NOk) return;
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: EListaDePrecios
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave está deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void LprVKey(DBConn p_dbcAccess,
                                     string p_strCod,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            Dal.ListasDePrecios.Search(p_dbcAccess,
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

        /// <summary>
        /// Verifica el número de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_iFxdVersion">Número de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void LprVVer(DBConn p_dbcAccess,
                                     string p_strCod,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            // Verificamos el número de versión
            Dal.ListasDePrecios.ChkVersion(p_dbcAccess,
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
            p_smResult.BllWarning("El número de versión del registro del ítem (ListaDePrecios) no coincide.\r\nOperación cancelada.","");
        }
        #endregion

        #region Metodos internos de recupero

        /// <summary>
        /// Devuelve una Lista-entidad: LEListasDePrecios
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEListasDePrecios</returns>
        internal static LEListasDePrecios LprUpfl(DBConn p_dbcAccess,
                                                   bool p_bOnlyActive,
                                                   StatMsg p_smResult)
        {
            try {
                // Pedimos los registros de la tabla: ListasDePrecios
                DataSet l_dsTemp= new DataSet();

                Dal.ListasDePrecios.Up(p_dbcAccess, 
                                       p_bOnlyActive,
                                       ref l_dsTemp, "Temporal",
                                       p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.ListasDePrecios.MakeGridCaptions(ref l_dsTemp, "Temporal", p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LEListasDePrecios l_lentRet= new LEListasDePrecios(l_dsTemp.Tables["Temporal"]);
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
        /// Devuelve una entidad: EListaDePrecios
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EListaDePrecios</returns>
        internal static EListaDePrecios LprSrch(DBConn p_dbcAccess,
                                                string p_strCod,
                                                bool p_bOnlyActive,
                                                StatMsg p_smResult)
        {
            try {
                // Pedimos el registro de la tabla: ListasDePrecios
                DataSet l_dsTemp= new DataSet();

                Dal.ListasDePrecios.Search(p_dbcAccess, 
                                           p_strCod,
                                           p_bOnlyActive,
                                           ref l_dsTemp, "Temporal",
                                           p_smResult);
                if (p_smResult.NOk) return null;

                // Constuimos la entidad y la devolvemos (si vino un registro)
                EListaDePrecios l_entRet= null;

                if (l_dsTemp.Tables["Temporal"].Rows.Count == 1)
                    l_entRet= new EListaDePrecios(l_dsTemp.Tables["Temporal"].Rows[0]);

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
        /// Agrega o modifica un registro de la tabla: ListasDePrecios
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entListaDePrecios">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void LprSSav(DBConn p_dbcAccess,
                                     EListaDePrecios p_entListaDePrecios,
                                     StatMsg p_smResult)
        {
            try {
                // Procesamos codigo fijo
                LprSave_f(p_dbcAccess, ref p_entListaDePrecios, p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                LprVKey(p_dbcAccess, 
                        p_entListaDePrecios.Cod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entListaDePrecios.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El ítem (ListaDePrecios) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    LprInsr(p_dbcAccess, p_entListaDePrecios, p_smResult);
                    return;
                }

                // Es un update. La clave debe existir y estar habilitada
                if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                    // Error. La clave no existe o no está habilitada
                    p_smResult.BllWarning("El ítem (ListaDePrecios) que intenta modificar no existe en el sistema o no está habilitado.","");
                    return;
                }

                // Debe coincidir el número de version
                LprVVer(p_dbcAccess, 
                        p_entListaDePrecios.Cod,
                        p_entListaDePrecios.FxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos el registro
                LprUpdt(p_dbcAccess, p_entListaDePrecios, p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Agrega un registro a la tabla a partir de una entidad: EListaDePrecios
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entListaDePrecios">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void LprInsr(DBConn p_dbcAccess,
                                     EListaDePrecios p_entListaDePrecios,
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                LprTInt(p_dbcAccess, p_entListaDePrecios, p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: ListasDePrecios
                Dal.ListasDePrecios.Insert(p_dbcAccess,
                                           p_entListaDePrecios.Cod,
                                           p_entListaDePrecios.Des,
                                           p_entListaDePrecios.Codplan,
                                           p_entListaDePrecios.Codmarca,
                                           p_entListaDePrecios.Precio1p,
                                           p_entListaDePrecios.Precio2p,
                                           p_entListaDePrecios.Precio3p,
                                           p_entListaDePrecios.Precio4p,
                                           p_entListaDePrecios.Precio5p,
                                           p_entListaDePrecios.Precio6p,
                                           p_entListaDePrecios.Precio7p,
                                           p_entListaDePrecios.Precio8p,
                                           p_entListaDePrecios.Precio9p,
                                           p_entListaDePrecios.Precio10p,
                                           p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Actualiza un registro a la tabla a partir de una entidad: EListaDePrecios
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entListaDePrecios">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void LprUpdt(DBConn p_dbcAccess,
                                     EListaDePrecios p_entListaDePrecios,
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                LprTInt(p_dbcAccess, p_entListaDePrecios, p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: ListasDePrecios
                Dal.ListasDePrecios.Update(p_dbcAccess,
                                           p_entListaDePrecios.Cod,
                                           p_entListaDePrecios.Des,
                                           p_entListaDePrecios.Codplan,
                                           p_entListaDePrecios.Codmarca,
                                           p_entListaDePrecios.Precio1p,
                                           p_entListaDePrecios.Precio2p,
                                           p_entListaDePrecios.Precio3p,
                                           p_entListaDePrecios.Precio4p,
                                           p_entListaDePrecios.Precio5p,
                                           p_entListaDePrecios.Precio6p,
                                           p_entListaDePrecios.Precio7p,
                                           p_entListaDePrecios.Precio8p,
                                           p_entListaDePrecios.Precio9p,
                                           p_entListaDePrecios.Precio10p,
                                           p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra físicamente un registro de a tabla: ListasDePrecios
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void LprDrop(DBConn p_dbcAccess,
                                     string p_strCod,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            try {
                // Verificamos la clave a borrar
                LprVKey(p_dbcAccess,
                        p_strCod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (ListaDePrecios) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                LprVVer(p_dbcAccess, 
                        p_strCod,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Borramos físicamente el registro
                Dal.ListasDePrecios.Drop(p_dbcAccess,
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
        internal static void LprPack(DBConn p_dbcAccess,
                                     StatMsg p_smResult)
        {
            try {
                // Borramos los borrados lógicamente
                Dal.ListasDePrecios.Pack(p_dbcAccess,
                                         p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }
        #endregion

        #region Metodos para métodos DAL definidos por el usuario
        #endregion


        //**********************************************************
        //
        // Funciones para la Tabla: Localidades
        // Usando ClaseDal        : Localidades
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos públicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: Localidades
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LELocalidades</returns>
        public static LELocalidades LocUpFull(bool p_bOnlyActive,
                                              StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                return LocUpfl(l_dbcAccess, p_bOnlyActive, p_smResult);
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
        /// Devuelve una entidad: ELocalidad
        /// </summary>
        /// <param name="p_strCodpost">Código postal</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: ELocalidad</returns>
        public static ELocalidad LocGet(string p_strCodpost,
                                        bool p_bOnlyActive,
                                        StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCodpost= ELocalidad.FrmtCodpost(p_strCodpost);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: ELocalidad
                return LocSrch(l_dbcAccess,
                               p_strCodpost,
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
        /// Devuelve la próxima clave de la entidad
        /// </summary>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Próxima clave</returns>
        public static string LocNextKey(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la clave máxima
                return LocGetNK(l_dbcAccess,
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

        #region Metodos publicos de grabacion

        /// <summary>
        /// Agrega o modifica un registro de la tabla: Localidades
        /// </summary>
        /// <param name="p_entLocalidad">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void LocSave(ELocalidad p_entLocalidad,
                                   StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: ELocalidad
                LocSSav(l_dbcAccess, p_entLocalidad, p_smResult);
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
        /// Habilita/Deshabilita un registro de la tabla: Localidades
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCodpost">Código postal</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void LocEnabled(bool p_bEnable,
                                      string p_strCodpost,
                                      int p_iFxdVersion,
                                      StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCodpost= ELocalidad.FrmtCodpost(p_strCodpost);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                LocEnabled_f(l_dbcAccess,
                             p_bEnable,
                             p_strCodpost,
                             ref p_iFxdVersion,
                             p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                LocVKey(l_dbcAccess,
                        p_strCodpost,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (Localidad) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                LocVVer(l_dbcAccess, 
                        p_strCodpost,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.Localidades.Recall(l_dbcAccess,
                                           p_strCodpost,
                                           p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.Localidades.Delete(l_dbcAccess,
                                           p_strCodpost,
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
        /// Borra físicamento un registro de la tabla: Localidades
        /// </summary>
        /// <param name="p_strCodpost">Código postal</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void LocRemove(string p_strCodpost,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCodpost= ELocalidad.FrmtCodpost(p_strCodpost);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                LocRemove_f(l_dbcAccess,
                            p_strCodpost,
                            p_iFxdVersion,
                            p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                LocDrop(l_dbcAccess,
                        p_strCodpost,
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
        public static void LocPurge(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Realizamos el borrado
                LocPack(l_dbcAccess,
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
        /// Ejecuta el SP definido por el usuario: Find
        /// </summary>
        /// <param name= p_strLocalidad>Nombre de la localidad</param>
        /// <param name= p_strProvinciad>Provincia desde</param>
        /// <param name= p_strProvinciah>Provincia hasta</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        public static LELocalidades LocFind(string p_strLocalidad,
                                            string p_strProvinciad,
                                            string p_strProvinciah,
                                            StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Abrimos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Llamamos al metodo interno
                return LocFind(l_dbcAccess,
                               p_strLocalidad,
                               p_strProvinciad,
                               p_strProvinciah,
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
        /// Ejecuta el SP definido por el usuario: GetDirectaWithLike
        /// </summary>
        /// <param name= p_strLocabuscar>Letras de Loc a Buscar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        public static LELocalidades LocGetDirectaWithLike(string p_strLocabuscar,
                                                          StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Abrimos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Llamamos al metodo interno
                return LocGetDirectaWithLike(l_dbcAccess,
                                             p_strLocabuscar,
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
        /// Ejecuta el SP definido por el usuario: GetLocalidadesZona
        /// </summary>
        /// <param name= p_strCodzona>Código de zona</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        public static ListaEntidades LocGetLocalidadesZona(string p_strCodzona,
                                                           StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Abrimos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Llamamos al metodo interno
                return LocGetLocalidadesZona(l_dbcAccess,
                                             p_strCodzona,
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
        /// Ejecuta el SP definido por el usuario: GetPartidos
        /// </summary>
        /// <param name= p_strProvincia>Nombre de la provincia</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        public static ListaEntidades LocGetPartidos(string p_strProvincia,
                                                    StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Abrimos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Llamamos al metodo interno
                return LocGetPartidos(l_dbcAccess,
                                      p_strProvincia,
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
        /// Ejecuta el SP definido por el usuario: GetProvincias
        /// </summary>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        public static ListaEntidades LocGetProvincias(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Abrimos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Llamamos al metodo interno
                return LocGetProvincias(l_dbcAccess,
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
        /// Ejecuta el SP definido por el usuario: UpFullByPartido
        /// </summary>
        /// <param name= p_strProvincia>Provincia a buscar</param>
        /// <param name= p_strPartido>Partido a buscar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        public static LELocalidades LocUpFullByPartido(string p_strProvincia,
                                                       string p_strPartido,
                                                       StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Abrimos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Llamamos al metodo interno
                return LocUpFullByPartido(l_dbcAccess,
                                          p_strProvincia,
                                          p_strPartido,
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
        /// Valida la integridad de una entidad: Localidad
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entLocalidad">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void LocTInt(DBConn p_dbcAccess,
                                     ELocalidad p_entLocalidad,
                                     StatMsg p_smResult)
        {
            // ********
            // Validaciones de los campos sin conexion
            // ********

            if (p_entLocalidad.Codpost.Trim() == "") {
                // El campo [Código postal] no puede ser vacío
                p_smResult.BllWarning("El dato [Código postal] no puede ser vacío","");
                return;
            }

            if (p_entLocalidad.Nombre.Trim() == "") {
                // El campo [Nombre] no puede ser vacío
                p_smResult.BllWarning("El dato [Nombre] no puede ser vacío","");
                return;
            }

            if (p_entLocalidad.Partido.Trim() == "") {
                // El campo [Partido] no puede ser vacío
                p_smResult.BllWarning("El dato [Partido] no puede ser vacío","");
                return;
            }

            if (p_entLocalidad.Provincia.Trim() == "") {
                // El campo [Provincia] no puede ser vacío
                p_smResult.BllWarning("El dato [Provincia] no puede ser vacío","");
                return;
            }

            if ((p_entLocalidad.Directa != "S") &&
                (p_entLocalidad.Directa != "N")) {
                // El campo [Busqueda Directa] tiene opciones
                p_smResult.BllWarning("El dato [Busqueda Directa] sólo admite\r\n\r\n[S]- SI\r\n[N]- NO\r\n","");
                return;
            }

            // ********
            // Validaciones de los campos con conexion
            // ********

            Tablas.ZnsVKey(p_dbcAccess,
                           p_entLocalidad.Codzona,
                           p_smResult);
            if (p_smResult.NOk) return;

            if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                // El campo [Zona] debe existir en la tabla [Tablas.Zns]
                p_smResult.BllWarning("El dato [Zona] debe existir en la tabla [Tablas.Zns]","");
                return;
            }

            // Todas las validaciones fueron correctas

            // Llamamos a la funcion fija del usuario
            LocTInt_f(p_dbcAccess, p_entLocalidad, p_smResult);
            if (p_smResult.NOk) return;
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: ELocalidad
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave está deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodpost">Código postal</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void LocVKey(DBConn p_dbcAccess,
                                     string p_strCodpost,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            Dal.Localidades.Search(p_dbcAccess,
                                   p_strCodpost,
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

        /// <summary>
        /// Verifica el número de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodpost">Código postal</param>
        /// <param name="p_iFxdVersion">Número de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void LocVVer(DBConn p_dbcAccess,
                                     string p_strCodpost,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            // Verificamos el número de versión
            Dal.Localidades.ChkVersion(p_dbcAccess,
                                       p_strCodpost,
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
            p_smResult.BllWarning("El número de versión del registro del ítem (Localidad) no coincide.\r\nOperación cancelada.","");
        }
        #endregion

        #region Metodos internos de recupero

        /// <summary>
        /// Devuelve una Lista-entidad: LELocalidades
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LELocalidades</returns>
        internal static LELocalidades LocUpfl(DBConn p_dbcAccess,
                                               bool p_bOnlyActive,
                                               StatMsg p_smResult)
        {
            try {
                // Pedimos los registros de la tabla: Localidades
                DataSet l_dsTemp= new DataSet();

                Dal.Localidades.Up(p_dbcAccess, 
                                   p_bOnlyActive,
                                   ref l_dsTemp, "Temporal",
                                   p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.Localidades.MakeGridCaptions(ref l_dsTemp, "Temporal", p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LELocalidades l_lentRet= new LELocalidades(l_dsTemp.Tables["Temporal"]);
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
        /// Devuelve una entidad: ELocalidad
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodpost">Código postal</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: ELocalidad</returns>
        internal static ELocalidad LocSrch(DBConn p_dbcAccess,
                                           string p_strCodpost,
                                           bool p_bOnlyActive,
                                           StatMsg p_smResult)
        {
            try {
                // Pedimos el registro de la tabla: Localidades
                DataSet l_dsTemp= new DataSet();

                Dal.Localidades.Search(p_dbcAccess, 
                                       p_strCodpost,
                                       p_bOnlyActive,
                                       ref l_dsTemp, "Temporal",
                                       p_smResult);
                if (p_smResult.NOk) return null;

                // Constuimos la entidad y la devolvemos (si vino un registro)
                ELocalidad l_entRet= null;

                if (l_dsTemp.Tables["Temporal"].Rows.Count == 1)
                    l_entRet= new ELocalidad(l_dsTemp.Tables["Temporal"].Rows[0]);

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
        internal static string LocGetNK(DBConn p_dbcAccess,
                                        StatMsg p_smResult)
        {
            try {
                // Pedimos la clave máxima
                DataSet l_dsTemp= new DataSet();

                Dal.Localidades.GetMaxKey(p_dbcAccess,
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
        /// Agrega o modifica un registro de la tabla: Localidades
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entLocalidad">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void LocSSav(DBConn p_dbcAccess,
                                     ELocalidad p_entLocalidad,
                                     StatMsg p_smResult)
        {
            try {
                // Procesamos codigo fijo
                LocSave_f(p_dbcAccess, ref p_entLocalidad, p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                LocVKey(p_dbcAccess, 
                        p_entLocalidad.Codpost,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entLocalidad.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El ítem (Localidad) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    LocInsr(p_dbcAccess, p_entLocalidad, p_smResult);
                    return;
                }

                // Es un update. La clave debe existir y estar habilitada
                if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                    // Error. La clave no existe o no está habilitada
                    p_smResult.BllWarning("El ítem (Localidad) que intenta modificar no existe en el sistema o no está habilitado.","");
                    return;
                }

                // Debe coincidir el número de version
                LocVVer(p_dbcAccess, 
                        p_entLocalidad.Codpost,
                        p_entLocalidad.FxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos el registro
                LocUpdt(p_dbcAccess, p_entLocalidad, p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Agrega un registro a la tabla a partir de una entidad: ELocalidad
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entLocalidad">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void LocInsr(DBConn p_dbcAccess,
                                     ELocalidad p_entLocalidad,
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                LocTInt(p_dbcAccess, p_entLocalidad, p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: Localidades
                Dal.Localidades.Insert(p_dbcAccess,
                                       p_entLocalidad.Codpost,
                                       p_entLocalidad.Nombre,
                                       p_entLocalidad.Codzona,
                                       p_entLocalidad.Partido,
                                       p_entLocalidad.Provincia,
                                       p_entLocalidad.Nomgoogle,
                                       p_entLocalidad.Directa,
                                       p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Actualiza un registro a la tabla a partir de una entidad: ELocalidad
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entLocalidad">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void LocUpdt(DBConn p_dbcAccess,
                                     ELocalidad p_entLocalidad,
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                LocTInt(p_dbcAccess, p_entLocalidad, p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: Localidades
                Dal.Localidades.Update(p_dbcAccess,
                                       p_entLocalidad.Codpost,
                                       p_entLocalidad.Nombre,
                                       p_entLocalidad.Codzona,
                                       p_entLocalidad.Partido,
                                       p_entLocalidad.Provincia,
                                       p_entLocalidad.Nomgoogle,
                                       p_entLocalidad.Directa,
                                       p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra físicamente un registro de a tabla: Localidades
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodpost">Código postal</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void LocDrop(DBConn p_dbcAccess,
                                     string p_strCodpost,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            try {
                // Verificamos la clave a borrar
                LocVKey(p_dbcAccess,
                        p_strCodpost,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (Localidad) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                LocVVer(p_dbcAccess, 
                        p_strCodpost,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Borramos físicamente el registro
                Dal.Localidades.Drop(p_dbcAccess,
                                     p_strCodpost,
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
        internal static void LocPack(DBConn p_dbcAccess,
                                     StatMsg p_smResult)
        {
            try {
                // Borramos los borrados lógicamente
                Dal.Localidades.Pack(p_dbcAccess,
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
        /// Ejecuta el SP definido por el usuario: Find
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_strLocalidad>Nombre de la localidad</param>
        /// <param name= p_strProvinciad>Provincia desde</param>
        /// <param name= p_strProvinciah>Provincia hasta</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static LELocalidades LocFind(DBConn p_dbcAccess,
                                              string p_strLocalidad,
                                              string p_strProvinciad,
                                              string p_strProvinciah,
                                              StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.Localidades.Find(p_dbcAccess,
                                     p_strLocalidad,
                                     p_strProvinciad,
                                     p_strProvinciah,
                                     ref l_dsTemp,
                                     "Temporal",
                                     p_smResult);
                if (p_smResult.NOk) return null;

                // Captionamos el resultado
                Dal.Localidades.MakeGridCaptions(ref l_dsTemp, "Temporal", p_smResult);
                if (p_smResult.NOk) return null;

                // Creamos la ListaEntidad y la devolvemos
                LELocalidades l_lentRet= new LELocalidades(l_dsTemp.Tables["Temporal"]);
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
        /// Ejecuta el SP definido por el usuario: GetCodPostal
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_strLocalidad>Nombre de la Localidad a Buscar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades LocGetCodPostal(DBConn p_dbcAccess,
                                                       string p_strLocalidad,
                                                       StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.Localidades.GetCodPostal(p_dbcAccess,
                                             p_strLocalidad,
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
        /// Ejecuta el SP definido por el usuario: GetDirectaWithLike
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_strLocabuscar>Letras de Loc a Buscar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static LELocalidades LocGetDirectaWithLike(DBConn p_dbcAccess,
                                                            string p_strLocabuscar,
                                                            StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.Localidades.GetDirectaWithLike(p_dbcAccess,
                                                   p_strLocabuscar,
                                                   ref l_dsTemp,
                                                   "Temporal",
                                                   p_smResult);
                if (p_smResult.NOk) return null;

                // Captionamos el resultado
                Dal.Localidades.MakeGridCaptions(ref l_dsTemp, "Temporal", p_smResult);
                if (p_smResult.NOk) return null;

                // Creamos la ListaEntidad y la devolvemos
                LELocalidades l_lentRet= new LELocalidades(l_dsTemp.Tables["Temporal"]);
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
        /// Ejecuta el SP definido por el usuario: GetLocalidadesZona
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_strCodzona>Código de zona</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades LocGetLocalidadesZona(DBConn p_dbcAccess,
                                                             string p_strCodzona,
                                                             StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.Localidades.GetLocalidadesZona(p_dbcAccess,
                                                   p_strCodzona,
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
        /// Ejecuta el SP definido por el usuario: GetPartidos
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_strProvincia>Nombre de la provincia</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades LocGetPartidos(DBConn p_dbcAccess,
                                                      string p_strProvincia,
                                                      StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.Localidades.GetPartidos(p_dbcAccess,
                                            p_strProvincia,
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
        /// Ejecuta el SP definido por el usuario: GetProvincias
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades LocGetProvincias(DBConn p_dbcAccess,
                                                        StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.Localidades.GetProvincias(p_dbcAccess,
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
        /// Ejecuta el SP definido por el usuario: UpFullByPartido
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_strProvincia>Provincia a buscar</param>
        /// <param name= p_strPartido>Partido a buscar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static LELocalidades LocUpFullByPartido(DBConn p_dbcAccess,
                                                         string p_strProvincia,
                                                         string p_strPartido,
                                                         StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.Localidades.UpFullByPartido(p_dbcAccess,
                                                p_strProvincia,
                                                p_strPartido,
                                                ref l_dsTemp,
                                                "Temporal",
                                                p_smResult);
                if (p_smResult.NOk) return null;

                // Captionamos el resultado
                Dal.Localidades.MakeGridCaptions(ref l_dsTemp, "Temporal", p_smResult);
                if (p_smResult.NOk) return null;

                // Creamos la ListaEntidad y la devolvemos
                LELocalidades l_lentRet= new LELocalidades(l_dsTemp.Tables["Temporal"]);
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
        // Funciones para la Tabla: LogClientes
        // Usando ClaseDal        : LogClientes
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos públicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: LogClientes
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LELogClientes</returns>
        public static LELogClientes LgcUpFull(bool p_bOnlyActive,
                                              StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                return LgcUpfl(l_dbcAccess, p_bOnlyActive, p_smResult);
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
        /// Devuelve una entidad: ELogCliente
        /// </summary>
        /// <param name="p_iNro">Numero</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: ELogCliente</returns>
        public static ELogCliente LgcGet(int p_iNro,
                                         bool p_bOnlyActive,
                                         StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: ELogCliente
                return LgcSrch(l_dbcAccess,
                               p_iNro,
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
        /// Agrega o modifica un registro de la tabla: LogClientes
        /// </summary>
        /// <param name="p_entLogCliente">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void LgcSave(ELogCliente p_entLogCliente,
                                   StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: ELogCliente
                LgcSSav(l_dbcAccess, p_entLogCliente, p_smResult);
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
        /// Habilita/Deshabilita un registro de la tabla: LogClientes
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_iNro">Numero</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void LgcEnabled(bool p_bEnable,
                                      int p_iNro,
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
                LgcEnabled_f(l_dbcAccess,
                             p_bEnable,
                             p_iNro,
                             ref p_iFxdVersion,
                             p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                LgcVKey(l_dbcAccess,
                        p_iNro,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (LogCliente) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                LgcVVer(l_dbcAccess, 
                        p_iNro,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.LogClientes.Recall(l_dbcAccess,
                                           p_iNro,
                                           p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.LogClientes.Delete(l_dbcAccess,
                                           p_iNro,
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
        /// Borra físicamento un registro de la tabla: LogClientes
        /// </summary>
        /// <param name="p_iNro">Numero</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void LgcRemove(int p_iNro,
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
                LgcRemove_f(l_dbcAccess,
                            p_iNro,
                            p_iFxdVersion,
                            p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                LgcDrop(l_dbcAccess,
                        p_iNro,
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
        public static void LgcPurge(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Realizamos el borrado
                LgcPack(l_dbcAccess,
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
        /// Valida la integridad de una entidad: LogCliente
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entLogCliente">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void LgcTInt(DBConn p_dbcAccess,
                                     ELogCliente p_entLogCliente,
                                     StatMsg p_smResult)
        {
            // ********
            // Validaciones de los campos sin conexion
            // ********

            // ********
            // Validaciones de los campos con conexion
            // ********

            // Llamamos a la funcion fija del usuario
            LgcTInt_f(p_dbcAccess, p_entLogCliente, p_smResult);
            if (p_smResult.NOk) return;
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: ELogCliente
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave está deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNro">Numero</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void LgcVKey(DBConn p_dbcAccess,
                                     int p_iNro,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            Dal.LogClientes.Search(p_dbcAccess,
                                   p_iNro,
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

        /// <summary>
        /// Verifica el número de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNro">Numero</param>
        /// <param name="p_iFxdVersion">Número de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void LgcVVer(DBConn p_dbcAccess,
                                     int p_iNro,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            // Verificamos el número de versión
            Dal.LogClientes.ChkVersion(p_dbcAccess,
                                       p_iNro,
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
            p_smResult.BllWarning("El número de versión del registro del ítem (LogCliente) no coincide.\r\nOperación cancelada.","");
        }
        #endregion

        #region Metodos internos de recupero

        /// <summary>
        /// Devuelve una Lista-entidad: LELogClientes
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LELogClientes</returns>
        internal static LELogClientes LgcUpfl(DBConn p_dbcAccess,
                                               bool p_bOnlyActive,
                                               StatMsg p_smResult)
        {
            try {
                // Pedimos los registros de la tabla: LogClientes
                DataSet l_dsTemp= new DataSet();

                Dal.LogClientes.Up(p_dbcAccess, 
                                   p_bOnlyActive,
                                   ref l_dsTemp, "Temporal",
                                   p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.LogClientes.MakeGridCaptions(ref l_dsTemp, "Temporal", p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LELogClientes l_lentRet= new LELogClientes(l_dsTemp.Tables["Temporal"]);
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
        /// Devuelve una entidad: ELogCliente
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNro">Numero</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: ELogCliente</returns>
        internal static ELogCliente LgcSrch(DBConn p_dbcAccess,
                                            int p_iNro,
                                            bool p_bOnlyActive,
                                            StatMsg p_smResult)
        {
            try {
                // Pedimos el registro de la tabla: LogClientes
                DataSet l_dsTemp= new DataSet();

                Dal.LogClientes.Search(p_dbcAccess, 
                                       p_iNro,
                                       p_bOnlyActive,
                                       ref l_dsTemp, "Temporal",
                                       p_smResult);
                if (p_smResult.NOk) return null;

                // Constuimos la entidad y la devolvemos (si vino un registro)
                ELogCliente l_entRet= null;

                if (l_dsTemp.Tables["Temporal"].Rows.Count == 1)
                    l_entRet= new ELogCliente(l_dsTemp.Tables["Temporal"].Rows[0]);

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
        /// Agrega o modifica un registro de la tabla: LogClientes
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entLogCliente">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void LgcSSav(DBConn p_dbcAccess,
                                     ELogCliente p_entLogCliente,
                                     StatMsg p_smResult)
        {
            try {
                // Procesamos codigo fijo
                LgcSave_f(p_dbcAccess, ref p_entLogCliente, p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                LgcVKey(p_dbcAccess, 
                        p_entLogCliente.Nro,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entLogCliente.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El ítem (LogCliente) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    LgcInsr(p_dbcAccess, p_entLogCliente, p_smResult);
                    return;
                }

                // Es un update. La clave debe existir y estar habilitada
                if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                    // Error. La clave no existe o no está habilitada
                    p_smResult.BllWarning("El ítem (LogCliente) que intenta modificar no existe en el sistema o no está habilitado.","");
                    return;
                }

                // Debe coincidir el número de version
                LgcVVer(p_dbcAccess, 
                        p_entLogCliente.Nro,
                        p_entLogCliente.FxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos el registro
                LgcUpdt(p_dbcAccess, p_entLogCliente, p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Agrega un registro a la tabla a partir de una entidad: ELogCliente
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entLogCliente">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void LgcInsr(DBConn p_dbcAccess,
                                     ELogCliente p_entLogCliente,
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                LgcTInt(p_dbcAccess, p_entLogCliente, p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: LogClientes
                Dal.LogClientes.Insert(p_dbcAccess,
                                       p_entLogCliente.Nro,
                                       p_entLogCliente.Nrocliente,
                                       p_entLogCliente.Nroavalon,
                                       p_entLogCliente.Rsocial,
                                       p_entLogCliente.Nomfantasia,
                                       p_entLogCliente.Accion,
                                       p_entLogCliente.Usuario,
                                       p_entLogCliente.Fecha,
                                       p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Actualiza un registro a la tabla a partir de una entidad: ELogCliente
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entLogCliente">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void LgcUpdt(DBConn p_dbcAccess,
                                     ELogCliente p_entLogCliente,
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                LgcTInt(p_dbcAccess, p_entLogCliente, p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: LogClientes
                Dal.LogClientes.Update(p_dbcAccess,
                                       p_entLogCliente.Nro,
                                       p_entLogCliente.Nrocliente,
                                       p_entLogCliente.Nroavalon,
                                       p_entLogCliente.Rsocial,
                                       p_entLogCliente.Nomfantasia,
                                       p_entLogCliente.Accion,
                                       p_entLogCliente.Usuario,
                                       p_entLogCliente.Fecha,
                                       p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra físicamente un registro de a tabla: LogClientes
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNro">Numero</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void LgcDrop(DBConn p_dbcAccess,
                                     int p_iNro,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            try {
                // Verificamos la clave a borrar
                LgcVKey(p_dbcAccess,
                        p_iNro,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (LogCliente) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                LgcVVer(p_dbcAccess, 
                        p_iNro,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Borramos físicamente el registro
                Dal.LogClientes.Drop(p_dbcAccess,
                                     p_iNro,
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
        internal static void LgcPack(DBConn p_dbcAccess,
                                     StatMsg p_smResult)
        {
            try {
                // Borramos los borrados lógicamente
                Dal.LogClientes.Pack(p_dbcAccess,
                                     p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }
        #endregion

        #region Metodos para métodos DAL definidos por el usuario
        #endregion


        //**********************************************************
        //
        // Funciones para la Tabla: Marcas
        // Usando ClaseDal        : Marcas
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos públicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: Marcas
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEMarcas</returns>
        public static LEMarcas MrcUpFull(bool p_bOnlyActive,
                                         StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                return MrcUpfl(l_dbcAccess, p_bOnlyActive, p_smResult);
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
        /// Devuelve una entidad: EMarca
        /// </summary>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EMarca</returns>
        public static EMarca MrcGet(string p_strCod,
                                    bool p_bOnlyActive,
                                    StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: EMarca
                return MrcSrch(l_dbcAccess,
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
        /// Agrega o modifica un registro de la tabla: Marcas
        /// </summary>
        /// <param name="p_entMarca">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void MrcSave(EMarca p_entMarca,
                                   StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: EMarca
                MrcSSav(l_dbcAccess, p_entMarca, p_smResult);
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
        /// Habilita/Deshabilita un registro de la tabla: Marcas
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void MrcEnabled(bool p_bEnable,
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
                MrcEnabled_f(l_dbcAccess,
                             p_bEnable,
                             p_strCod,
                             ref p_iFxdVersion,
                             p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                MrcVKey(l_dbcAccess,
                        p_strCod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (Marca) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                MrcVVer(l_dbcAccess, 
                        p_strCod,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.Marcas.Recall(l_dbcAccess,
                                      p_strCod,
                                      p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.Marcas.Delete(l_dbcAccess,
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
        /// Borra físicamento un registro de la tabla: Marcas
        /// </summary>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void MrcRemove(string p_strCod,
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
                MrcRemove_f(l_dbcAccess,
                            p_strCod,
                            p_iFxdVersion,
                            p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                MrcDrop(l_dbcAccess,
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
        public static void MrcPurge(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Realizamos el borrado
                MrcPack(l_dbcAccess,
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
        /// Valida la integridad de una entidad: Marca
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMarca">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MrcTInt(DBConn p_dbcAccess,
                                     EMarca p_entMarca,
                                     StatMsg p_smResult)
        {
            // ********
            // Validaciones de los campos sin conexion
            // ********

            // ********
            // Validaciones de los campos con conexion
            // ********

            Tablas.LocVKey(p_dbcAccess,
                           p_entMarca.Codlocalidad,
                           p_smResult);
            if (p_smResult.NOk) return;

            if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                // El campo [Localidad] debe existir en la tabla [Tablas.Loc]
                p_smResult.BllWarning("El dato [Localidad] debe existir en la tabla [Tablas.Loc]","");
                return;
            }

            // Todas las validaciones fueron correctas

            // Llamamos a la funcion fija del usuario
            MrcTInt_f(p_dbcAccess, p_entMarca, p_smResult);
            if (p_smResult.NOk) return;
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: EMarca
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave está deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MrcVKey(DBConn p_dbcAccess,
                                     string p_strCod,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            Dal.Marcas.Search(p_dbcAccess,
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

        /// <summary>
        /// Verifica el número de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_iFxdVersion">Número de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MrcVVer(DBConn p_dbcAccess,
                                     string p_strCod,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            // Verificamos el número de versión
            Dal.Marcas.ChkVersion(p_dbcAccess,
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
            p_smResult.BllWarning("El número de versión del registro del ítem (Marca) no coincide.\r\nOperación cancelada.","");
        }
        #endregion

        #region Metodos internos de recupero

        /// <summary>
        /// Devuelve una Lista-entidad: LEMarcas
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEMarcas</returns>
        internal static LEMarcas MrcUpfl(DBConn p_dbcAccess,
                                          bool p_bOnlyActive,
                                          StatMsg p_smResult)
        {
            try {
                // Pedimos los registros de la tabla: Marcas
                DataSet l_dsTemp= new DataSet();

                Dal.Marcas.Up(p_dbcAccess, 
                              p_bOnlyActive,
                              ref l_dsTemp, "Temporal",
                              p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.Marcas.MakeGridCaptions(ref l_dsTemp, "Temporal", p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LEMarcas l_lentRet= new LEMarcas(l_dsTemp.Tables["Temporal"]);
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
        /// Devuelve una entidad: EMarca
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EMarca</returns>
        internal static EMarca MrcSrch(DBConn p_dbcAccess,
                                       string p_strCod,
                                       bool p_bOnlyActive,
                                       StatMsg p_smResult)
        {
            try {
                // Pedimos el registro de la tabla: Marcas
                DataSet l_dsTemp= new DataSet();

                Dal.Marcas.Search(p_dbcAccess, 
                                  p_strCod,
                                  p_bOnlyActive,
                                  ref l_dsTemp, "Temporal",
                                  p_smResult);
                if (p_smResult.NOk) return null;

                // Constuimos la entidad y la devolvemos (si vino un registro)
                EMarca l_entRet= null;

                if (l_dsTemp.Tables["Temporal"].Rows.Count == 1)
                    l_entRet= new EMarca(l_dsTemp.Tables["Temporal"].Rows[0]);

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
        /// Agrega o modifica un registro de la tabla: Marcas
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMarca">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MrcSSav(DBConn p_dbcAccess,
                                     EMarca p_entMarca,
                                     StatMsg p_smResult)
        {
            try {
                // Procesamos codigo fijo
                MrcSave_f(p_dbcAccess, ref p_entMarca, p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                MrcVKey(p_dbcAccess, 
                        p_entMarca.Cod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entMarca.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El ítem (Marca) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    MrcInsr(p_dbcAccess, p_entMarca, p_smResult);
                    return;
                }

                // Es un update. La clave debe existir y estar habilitada
                if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                    // Error. La clave no existe o no está habilitada
                    p_smResult.BllWarning("El ítem (Marca) que intenta modificar no existe en el sistema o no está habilitado.","");
                    return;
                }

                // Debe coincidir el número de version
                MrcVVer(p_dbcAccess, 
                        p_entMarca.Cod,
                        p_entMarca.FxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos el registro
                MrcUpdt(p_dbcAccess, p_entMarca, p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Agrega un registro a la tabla a partir de una entidad: EMarca
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMarca">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MrcInsr(DBConn p_dbcAccess,
                                     EMarca p_entMarca,
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                MrcTInt(p_dbcAccess, p_entMarca, p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: Marcas
                Dal.Marcas.Insert(p_dbcAccess,
                                  p_entMarca.Cod,
                                  p_entMarca.Des,
                                  p_entMarca.Codlocalidad,
                                  p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Actualiza un registro a la tabla a partir de una entidad: EMarca
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMarca">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MrcUpdt(DBConn p_dbcAccess,
                                     EMarca p_entMarca,
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                MrcTInt(p_dbcAccess, p_entMarca, p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: Marcas
                Dal.Marcas.Update(p_dbcAccess,
                                  p_entMarca.Cod,
                                  p_entMarca.Des,
                                  p_entMarca.Codlocalidad,
                                  p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra físicamente un registro de a tabla: Marcas
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MrcDrop(DBConn p_dbcAccess,
                                     string p_strCod,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            try {
                // Verificamos la clave a borrar
                MrcVKey(p_dbcAccess,
                        p_strCod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (Marca) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                MrcVVer(p_dbcAccess, 
                        p_strCod,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Borramos físicamente el registro
                Dal.Marcas.Drop(p_dbcAccess,
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
        internal static void MrcPack(DBConn p_dbcAccess,
                                     StatMsg p_smResult)
        {
            try {
                // Borramos los borrados lógicamente
                Dal.Marcas.Pack(p_dbcAccess,
                                p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }
        #endregion

        #region Metodos para métodos DAL definidos por el usuario
        #endregion


        //**********************************************************
        //
        // Funciones para la Tabla: MotivosLlamada
        // Usando ClaseDal        : MotivosLlamada
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos públicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: MotivosLlamada
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEMotivosLlamadas</returns>
        public static LEMotivosLlamadas MtlUpFull(bool p_bOnlyActive,
                                                  StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                return MtlUpfl(l_dbcAccess, p_bOnlyActive, p_smResult);
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
        /// Devuelve una entidad: EMotivosLlamada
        /// </summary>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EMotivosLlamada</returns>
        public static EMotivosLlamada MtlGet(string p_strCod,
                                             bool p_bOnlyActive,
                                             StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCod= EMotivosLlamada.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: EMotivosLlamada
                return MtlSrch(l_dbcAccess,
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

        /// <summary>
        /// Devuelve la próxima clave de la entidad
        /// </summary>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Próxima clave</returns>
        public static string MtlNextKey(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la clave máxima
                return MtlGetNK(l_dbcAccess,
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

        #region Metodos publicos de grabacion

        /// <summary>
        /// Agrega o modifica un registro de la tabla: MotivosLlamada
        /// </summary>
        /// <param name="p_entMotivosLlamada">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void MtlSave(EMotivosLlamada p_entMotivosLlamada,
                                   StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: EMotivosLlamada
                MtlSSav(l_dbcAccess, p_entMotivosLlamada, p_smResult);
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
        /// Habilita/Deshabilita un registro de la tabla: MotivosLlamada
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void MtlEnabled(bool p_bEnable,
                                      string p_strCod,
                                      int p_iFxdVersion,
                                      StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCod= EMotivosLlamada.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                MtlEnabled_f(l_dbcAccess,
                             p_bEnable,
                             p_strCod,
                             ref p_iFxdVersion,
                             p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                MtlVKey(l_dbcAccess,
                        p_strCod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (MotivosLlamada) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                MtlVVer(l_dbcAccess, 
                        p_strCod,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.MotivosLlamada.Recall(l_dbcAccess,
                                              p_strCod,
                                              p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.MotivosLlamada.Delete(l_dbcAccess,
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
        /// Borra físicamento un registro de la tabla: MotivosLlamada
        /// </summary>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void MtlRemove(string p_strCod,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCod= EMotivosLlamada.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                MtlRemove_f(l_dbcAccess,
                            p_strCod,
                            p_iFxdVersion,
                            p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                MtlDrop(l_dbcAccess,
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
        public static void MtlPurge(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Realizamos el borrado
                MtlPack(l_dbcAccess,
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
        /// Ejecuta el SP definido por el usuario: GetByCategoria
        /// </summary>
        /// <param name= p_strCodcategoria>Codigo de categoria</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        public static ListaEntidades MtlGetByCategoria(string p_strCodcategoria,
                                                       StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Abrimos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Llamamos al metodo interno
                return MtlGetByCategoria(l_dbcAccess,
                                         p_strCodcategoria,
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
        /// Valida la integridad de una entidad: MotivosLlamada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMotivosLlamada">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MtlTInt(DBConn p_dbcAccess,
                                     EMotivosLlamada p_entMotivosLlamada,
                                     StatMsg p_smResult)
        {
            // ********
            // Validaciones de los campos sin conexion
            // ********

            if (p_entMotivosLlamada.Cod.Trim() == "") {
                // El campo [Código] no puede ser vacío
                p_smResult.BllWarning("El dato [Código] no puede ser vacío","");
                return;
            }

            if (p_entMotivosLlamada.Des.Trim() == "") {
                // El campo [Motivo] no puede ser vacío
                p_smResult.BllWarning("El dato [Motivo] no puede ser vacío","");
                return;
            }

            if ((p_entMotivosLlamada.Esreclamo != "S") &&
                (p_entMotivosLlamada.Esreclamo != "N")) {
                // El campo [Reclamo] tiene opciones
                p_smResult.BllWarning("El dato [Reclamo] sólo admite\r\n\r\n[S]- SI\r\n[N]- NO\r\n","");
                return;
            }

            // ********
            // Validaciones de los campos con conexion
            // ********

            Tablas.CtlVKey(p_dbcAccess,
                           p_entMotivosLlamada.Codcategoria,
                           p_smResult);
            if (p_smResult.NOk) return;

            if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                // El campo [Categoria] debe existir en la tabla [Tablas.Ctl]
                p_smResult.BllWarning("El dato [Categoria] debe existir en la tabla [Tablas.Ctl] y estar habilitado","");
                return;
            }

            // Todas las validaciones fueron correctas

            // Llamamos a la funcion fija del usuario
            MtlTInt_f(p_dbcAccess, p_entMotivosLlamada, p_smResult);
            if (p_smResult.NOk) return;
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: EMotivosLlamada
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave está deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MtlVKey(DBConn p_dbcAccess,
                                     string p_strCod,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            Dal.MotivosLlamada.Search(p_dbcAccess,
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

        /// <summary>
        /// Verifica el número de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_iFxdVersion">Número de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MtlVVer(DBConn p_dbcAccess,
                                     string p_strCod,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            // Verificamos el número de versión
            Dal.MotivosLlamada.ChkVersion(p_dbcAccess,
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
            p_smResult.BllWarning("El número de versión del registro del ítem (MotivosLlamada) no coincide.\r\nOperación cancelada.","");
        }
        #endregion

        #region Metodos internos de recupero

        /// <summary>
        /// Devuelve una Lista-entidad: LEMotivosLlamadas
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEMotivosLlamadas</returns>
        internal static LEMotivosLlamadas MtlUpfl(DBConn p_dbcAccess,
                                                   bool p_bOnlyActive,
                                                   StatMsg p_smResult)
        {
            try {
                // Pedimos los registros de la tabla: MotivosLlamada
                DataSet l_dsTemp= new DataSet();

                Dal.MotivosLlamada.Up(p_dbcAccess, 
                                      p_bOnlyActive,
                                      ref l_dsTemp, "Temporal",
                                      p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.MotivosLlamada.MakeGridCaptions(ref l_dsTemp, "Temporal", p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LEMotivosLlamadas l_lentRet= new LEMotivosLlamadas(l_dsTemp.Tables["Temporal"]);
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
        /// Devuelve una entidad: EMotivosLlamada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EMotivosLlamada</returns>
        internal static EMotivosLlamada MtlSrch(DBConn p_dbcAccess,
                                                string p_strCod,
                                                bool p_bOnlyActive,
                                                StatMsg p_smResult)
        {
            try {
                // Pedimos el registro de la tabla: MotivosLlamada
                DataSet l_dsTemp= new DataSet();

                Dal.MotivosLlamada.Search(p_dbcAccess, 
                                          p_strCod,
                                          p_bOnlyActive,
                                          ref l_dsTemp, "Temporal",
                                          p_smResult);
                if (p_smResult.NOk) return null;

                // Constuimos la entidad y la devolvemos (si vino un registro)
                EMotivosLlamada l_entRet= null;

                if (l_dsTemp.Tables["Temporal"].Rows.Count == 1)
                    l_entRet= new EMotivosLlamada(l_dsTemp.Tables["Temporal"].Rows[0]);

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
        internal static string MtlGetNK(DBConn p_dbcAccess,
                                        StatMsg p_smResult)
        {
            try {
                // Pedimos la clave máxima
                DataSet l_dsTemp= new DataSet();

                Dal.MotivosLlamada.GetMaxKey(p_dbcAccess,
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
        /// Agrega o modifica un registro de la tabla: MotivosLlamada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMotivosLlamada">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MtlSSav(DBConn p_dbcAccess,
                                     EMotivosLlamada p_entMotivosLlamada,
                                     StatMsg p_smResult)
        {
            try {
                // Procesamos codigo fijo
                MtlSave_f(p_dbcAccess, ref p_entMotivosLlamada, p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                MtlVKey(p_dbcAccess, 
                        p_entMotivosLlamada.Cod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entMotivosLlamada.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El ítem (MotivosLlamada) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    MtlInsr(p_dbcAccess, p_entMotivosLlamada, p_smResult);
                    return;
                }

                // Es un update. La clave debe existir y estar habilitada
                if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                    // Error. La clave no existe o no está habilitada
                    p_smResult.BllWarning("El ítem (MotivosLlamada) que intenta modificar no existe en el sistema o no está habilitado.","");
                    return;
                }

                // Debe coincidir el número de version
                MtlVVer(p_dbcAccess, 
                        p_entMotivosLlamada.Cod,
                        p_entMotivosLlamada.FxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos el registro
                MtlUpdt(p_dbcAccess, p_entMotivosLlamada, p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Agrega un registro a la tabla a partir de una entidad: EMotivosLlamada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMotivosLlamada">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MtlInsr(DBConn p_dbcAccess,
                                     EMotivosLlamada p_entMotivosLlamada,
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                MtlTInt(p_dbcAccess, p_entMotivosLlamada, p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: MotivosLlamada
                Dal.MotivosLlamada.Insert(p_dbcAccess,
                                          p_entMotivosLlamada.Cod,
                                          p_entMotivosLlamada.Des,
                                          p_entMotivosLlamada.Codcategoria,
                                          p_entMotivosLlamada.Esreclamo,
                                          p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Actualiza un registro a la tabla a partir de una entidad: EMotivosLlamada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMotivosLlamada">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MtlUpdt(DBConn p_dbcAccess,
                                     EMotivosLlamada p_entMotivosLlamada,
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                MtlTInt(p_dbcAccess, p_entMotivosLlamada, p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: MotivosLlamada
                Dal.MotivosLlamada.Update(p_dbcAccess,
                                          p_entMotivosLlamada.Cod,
                                          p_entMotivosLlamada.Des,
                                          p_entMotivosLlamada.Codcategoria,
                                          p_entMotivosLlamada.Esreclamo,
                                          p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra físicamente un registro de a tabla: MotivosLlamada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MtlDrop(DBConn p_dbcAccess,
                                     string p_strCod,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            try {
                // Verificamos la clave a borrar
                MtlVKey(p_dbcAccess,
                        p_strCod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (MotivosLlamada) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                MtlVVer(p_dbcAccess, 
                        p_strCod,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Borramos físicamente el registro
                Dal.MotivosLlamada.Drop(p_dbcAccess,
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
        internal static void MtlPack(DBConn p_dbcAccess,
                                     StatMsg p_smResult)
        {
            try {
                // Borramos los borrados lógicamente
                Dal.MotivosLlamada.Pack(p_dbcAccess,
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
        /// Ejecuta el SP definido por el usuario: GetByCategoria
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_strCodcategoria>Codigo de categoria</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades MtlGetByCategoria(DBConn p_dbcAccess,
                                                         string p_strCodcategoria,
                                                         StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.MotivosLlamada.GetByCategoria(p_dbcAccess,
                                                  p_strCodcategoria,
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
        // Funciones para la Tabla: Parentescos
        // Usando ClaseDal        : Parentescos
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos públicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: Parentescos
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEParentescos</returns>
        public static LEParentescos PrtUpFull(bool p_bOnlyActive,
                                              StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                return PrtUpfl(l_dbcAccess, p_bOnlyActive, p_smResult);
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
        /// Devuelve una entidad: EParentesco
        /// </summary>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EParentesco</returns>
        public static EParentesco PrtGet(string p_strCod,
                                         bool p_bOnlyActive,
                                         StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: EParentesco
                return PrtSrch(l_dbcAccess,
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
        /// Agrega o modifica un registro de la tabla: Parentescos
        /// </summary>
        /// <param name="p_entParentesco">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void PrtSave(EParentesco p_entParentesco,
                                   StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: EParentesco
                PrtSSav(l_dbcAccess, p_entParentesco, p_smResult);
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
        /// Habilita/Deshabilita un registro de la tabla: Parentescos
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void PrtEnabled(bool p_bEnable,
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
                PrtEnabled_f(l_dbcAccess,
                             p_bEnable,
                             p_strCod,
                             ref p_iFxdVersion,
                             p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                PrtVKey(l_dbcAccess,
                        p_strCod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (Parentesco) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                PrtVVer(l_dbcAccess, 
                        p_strCod,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.Parentescos.Recall(l_dbcAccess,
                                           p_strCod,
                                           p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.Parentescos.Delete(l_dbcAccess,
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
        /// Borra físicamento un registro de la tabla: Parentescos
        /// </summary>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void PrtRemove(string p_strCod,
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
                PrtRemove_f(l_dbcAccess,
                            p_strCod,
                            p_iFxdVersion,
                            p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                PrtDrop(l_dbcAccess,
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
        public static void PrtPurge(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Realizamos el borrado
                PrtPack(l_dbcAccess,
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
        /// Valida la integridad de una entidad: Parentesco
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entParentesco">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void PrtTInt(DBConn p_dbcAccess,
                                     EParentesco p_entParentesco,
                                     StatMsg p_smResult)
        {
            // ********
            // Validaciones de los campos sin conexion
            // ********

            // ********
            // Validaciones de los campos con conexion
            // ********

            // Llamamos a la funcion fija del usuario
            PrtTInt_f(p_dbcAccess, p_entParentesco, p_smResult);
            if (p_smResult.NOk) return;
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: EParentesco
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave está deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void PrtVKey(DBConn p_dbcAccess,
                                     string p_strCod,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            Dal.Parentescos.Search(p_dbcAccess,
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

        /// <summary>
        /// Verifica el número de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_iFxdVersion">Número de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void PrtVVer(DBConn p_dbcAccess,
                                     string p_strCod,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            // Verificamos el número de versión
            Dal.Parentescos.ChkVersion(p_dbcAccess,
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
            p_smResult.BllWarning("El número de versión del registro del ítem (Parentesco) no coincide.\r\nOperación cancelada.","");
        }
        #endregion

        #region Metodos internos de recupero

        /// <summary>
        /// Devuelve una Lista-entidad: LEParentescos
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEParentescos</returns>
        internal static LEParentescos PrtUpfl(DBConn p_dbcAccess,
                                               bool p_bOnlyActive,
                                               StatMsg p_smResult)
        {
            try {
                // Pedimos los registros de la tabla: Parentescos
                DataSet l_dsTemp= new DataSet();

                Dal.Parentescos.Up(p_dbcAccess, 
                                   p_bOnlyActive,
                                   ref l_dsTemp, "Temporal",
                                   p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.Parentescos.MakeGridCaptions(ref l_dsTemp, "Temporal", p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LEParentescos l_lentRet= new LEParentescos(l_dsTemp.Tables["Temporal"]);
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
        /// Devuelve una entidad: EParentesco
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EParentesco</returns>
        internal static EParentesco PrtSrch(DBConn p_dbcAccess,
                                            string p_strCod,
                                            bool p_bOnlyActive,
                                            StatMsg p_smResult)
        {
            try {
                // Pedimos el registro de la tabla: Parentescos
                DataSet l_dsTemp= new DataSet();

                Dal.Parentescos.Search(p_dbcAccess, 
                                       p_strCod,
                                       p_bOnlyActive,
                                       ref l_dsTemp, "Temporal",
                                       p_smResult);
                if (p_smResult.NOk) return null;

                // Constuimos la entidad y la devolvemos (si vino un registro)
                EParentesco l_entRet= null;

                if (l_dsTemp.Tables["Temporal"].Rows.Count == 1)
                    l_entRet= new EParentesco(l_dsTemp.Tables["Temporal"].Rows[0]);

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
        /// Agrega o modifica un registro de la tabla: Parentescos
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entParentesco">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void PrtSSav(DBConn p_dbcAccess,
                                     EParentesco p_entParentesco,
                                     StatMsg p_smResult)
        {
            try {
                // Procesamos codigo fijo
                PrtSave_f(p_dbcAccess, ref p_entParentesco, p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                PrtVKey(p_dbcAccess, 
                        p_entParentesco.Cod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entParentesco.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El ítem (Parentesco) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    PrtInsr(p_dbcAccess, p_entParentesco, p_smResult);
                    return;
                }

                // Es un update. La clave debe existir y estar habilitada
                if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                    // Error. La clave no existe o no está habilitada
                    p_smResult.BllWarning("El ítem (Parentesco) que intenta modificar no existe en el sistema o no está habilitado.","");
                    return;
                }

                // Debe coincidir el número de version
                PrtVVer(p_dbcAccess, 
                        p_entParentesco.Cod,
                        p_entParentesco.FxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos el registro
                PrtUpdt(p_dbcAccess, p_entParentesco, p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Agrega un registro a la tabla a partir de una entidad: EParentesco
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entParentesco">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void PrtInsr(DBConn p_dbcAccess,
                                     EParentesco p_entParentesco,
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                PrtTInt(p_dbcAccess, p_entParentesco, p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: Parentescos
                Dal.Parentescos.Insert(p_dbcAccess,
                                       p_entParentesco.Cod,
                                       p_entParentesco.Des,
                                       p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Actualiza un registro a la tabla a partir de una entidad: EParentesco
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entParentesco">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void PrtUpdt(DBConn p_dbcAccess,
                                     EParentesco p_entParentesco,
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                PrtTInt(p_dbcAccess, p_entParentesco, p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: Parentescos
                Dal.Parentescos.Update(p_dbcAccess,
                                       p_entParentesco.Cod,
                                       p_entParentesco.Des,
                                       p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra físicamente un registro de a tabla: Parentescos
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void PrtDrop(DBConn p_dbcAccess,
                                     string p_strCod,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            try {
                // Verificamos la clave a borrar
                PrtVKey(p_dbcAccess,
                        p_strCod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (Parentesco) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                PrtVVer(p_dbcAccess, 
                        p_strCod,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Borramos físicamente el registro
                Dal.Parentescos.Drop(p_dbcAccess,
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
        internal static void PrtPack(DBConn p_dbcAccess,
                                     StatMsg p_smResult)
        {
            try {
                // Borramos los borrados lógicamente
                Dal.Parentescos.Pack(p_dbcAccess,
                                     p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }
        #endregion

        #region Metodos para métodos DAL definidos por el usuario
        #endregion


        //**********************************************************
        //
        // Funciones para la Tabla: PreciosServicios
        // Usando ClaseDal        : PreciosServicios
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos públicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: PreciosServicios
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEPreciosServicios</returns>
        public static LEPreciosServicios PrsUpFull(bool p_bOnlyActive,
                                                   StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                return PrsUpfl(l_dbcAccess, p_bOnlyActive, p_smResult);
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
        /// Devuelve una entidad: EPrecioServicio
        /// </summary>
        /// <param name="p_strColor">Color</param>
        /// <param name="p_dtFecha">Fecha</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EPrecioServicio</returns>
        public static EPrecioServicio PrsGet(string p_strColor,
                                             DateTime p_dtFecha,
                                             bool p_bOnlyActive,
                                             StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: EPrecioServicio
                return PrsSrch(l_dbcAccess,
                               p_strColor,
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
        #endregion

        #region Metodos publicos de grabacion

        /// <summary>
        /// Agrega o modifica un registro de la tabla: PreciosServicios
        /// </summary>
        /// <param name="p_entPrecioServicio">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void PrsSave(EPrecioServicio p_entPrecioServicio,
                                   StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: EPrecioServicio
                PrsSSav(l_dbcAccess, p_entPrecioServicio, p_smResult);
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
        /// Habilita/Deshabilita un registro de la tabla: PreciosServicios
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strColor">Color</param>
        /// <param name="p_dtFecha">Fecha</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void PrsEnabled(bool p_bEnable,
                                      string p_strColor,
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
                PrsEnabled_f(l_dbcAccess,
                             p_bEnable,
                             p_strColor,
                             p_dtFecha,
                             ref p_iFxdVersion,
                             p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                PrsVKey(l_dbcAccess,
                        p_strColor,
                        p_dtFecha,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (PrecioServicio) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                PrsVVer(l_dbcAccess, 
                        p_strColor,
                        p_dtFecha,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.PreciosServicios.Recall(l_dbcAccess,
                                                p_strColor,
                                                p_dtFecha,
                                                p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.PreciosServicios.Delete(l_dbcAccess,
                                                p_strColor,
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
        /// Borra físicamento un registro de la tabla: PreciosServicios
        /// </summary>
        /// <param name="p_strColor">Color</param>
        /// <param name="p_dtFecha">Fecha</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void PrsRemove(string p_strColor,
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
                PrsRemove_f(l_dbcAccess,
                            p_strColor,
                            p_dtFecha,
                            p_iFxdVersion,
                            p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                PrsDrop(l_dbcAccess,
                        p_strColor,
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
        public static void PrsPurge(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Realizamos el borrado
                PrsPack(l_dbcAccess,
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
        /// Valida la integridad de una entidad: PrecioServicio
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entPrecioServicio">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void PrsTInt(DBConn p_dbcAccess,
                                     EPrecioServicio p_entPrecioServicio,
                                     StatMsg p_smResult)
        {
            // ********
            // Validaciones de los campos sin conexion
            // ********

            if ((p_entPrecioServicio.Color != "V") &&
                (p_entPrecioServicio.Color != "A") &&
                (p_entPrecioServicio.Color != "R") &&
                (p_entPrecioServicio.Color != "T")) {
                // El campo [Color] tiene opciones
                p_smResult.BllWarning("El dato [Color] sólo admite\r\n\r\n[V]- VERDE\r\n[A]- AMARILLO\r\n[R]- ROJO\r\n[T]- TRASLADO\r\n","");
                return;
            }

            // ********
            // Validaciones de los campos con conexion
            // ********

            // Llamamos a la funcion fija del usuario
            PrsTInt_f(p_dbcAccess, p_entPrecioServicio, p_smResult);
            if (p_smResult.NOk) return;
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: EPrecioServicio
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave está deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strColor">Color</param>
        /// <param name="p_dtFecha">Fecha</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void PrsVKey(DBConn p_dbcAccess,
                                     string p_strColor,
                                     DateTime p_dtFecha,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            Dal.PreciosServicios.Search(p_dbcAccess,
                                        p_strColor,
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

        /// <summary>
        /// Verifica el número de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strColor">Color</param>
        /// <param name="p_dtFecha">Fecha</param>
        /// <param name="p_iFxdVersion">Número de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void PrsVVer(DBConn p_dbcAccess,
                                     string p_strColor,
                                     DateTime p_dtFecha,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            // Verificamos el número de versión
            Dal.PreciosServicios.ChkVersion(p_dbcAccess,
                                            p_strColor,
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
            p_smResult.BllWarning("El número de versión del registro del ítem (PrecioServicio) no coincide.\r\nOperación cancelada.","");
        }
        #endregion

        #region Metodos internos de recupero

        /// <summary>
        /// Devuelve una Lista-entidad: LEPreciosServicios
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEPreciosServicios</returns>
        internal static LEPreciosServicios PrsUpfl(DBConn p_dbcAccess,
                                                    bool p_bOnlyActive,
                                                    StatMsg p_smResult)
        {
            try {
                // Pedimos los registros de la tabla: PreciosServicios
                DataSet l_dsTemp= new DataSet();

                Dal.PreciosServicios.Up(p_dbcAccess, 
                                        p_bOnlyActive,
                                        ref l_dsTemp, "Temporal",
                                        p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.PreciosServicios.MakeGridCaptions(ref l_dsTemp, "Temporal", p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LEPreciosServicios l_lentRet= new LEPreciosServicios(l_dsTemp.Tables["Temporal"]);
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
        /// Devuelve una entidad: EPrecioServicio
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strColor">Color</param>
        /// <param name="p_dtFecha">Fecha</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EPrecioServicio</returns>
        internal static EPrecioServicio PrsSrch(DBConn p_dbcAccess,
                                                string p_strColor,
                                                DateTime p_dtFecha,
                                                bool p_bOnlyActive,
                                                StatMsg p_smResult)
        {
            try {
                // Pedimos el registro de la tabla: PreciosServicios
                DataSet l_dsTemp= new DataSet();

                Dal.PreciosServicios.Search(p_dbcAccess, 
                                            p_strColor,
                                            p_dtFecha,
                                            p_bOnlyActive,
                                            ref l_dsTemp, "Temporal",
                                            p_smResult);
                if (p_smResult.NOk) return null;

                // Constuimos la entidad y la devolvemos (si vino un registro)
                EPrecioServicio l_entRet= null;

                if (l_dsTemp.Tables["Temporal"].Rows.Count == 1)
                    l_entRet= new EPrecioServicio(l_dsTemp.Tables["Temporal"].Rows[0]);

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
        /// Agrega o modifica un registro de la tabla: PreciosServicios
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entPrecioServicio">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void PrsSSav(DBConn p_dbcAccess,
                                     EPrecioServicio p_entPrecioServicio,
                                     StatMsg p_smResult)
        {
            try {
                // Procesamos codigo fijo
                PrsSave_f(p_dbcAccess, ref p_entPrecioServicio, p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                PrsVKey(p_dbcAccess, 
                        p_entPrecioServicio.Color,
                        p_entPrecioServicio.Fecha,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entPrecioServicio.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El ítem (PrecioServicio) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    PrsInsr(p_dbcAccess, p_entPrecioServicio, p_smResult);
                    return;
                }

                // Es un update. La clave debe existir y estar habilitada
                if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                    // Error. La clave no existe o no está habilitada
                    p_smResult.BllWarning("El ítem (PrecioServicio) que intenta modificar no existe en el sistema o no está habilitado.","");
                    return;
                }

                // Debe coincidir el número de version
                PrsVVer(p_dbcAccess, 
                        p_entPrecioServicio.Color,
                        p_entPrecioServicio.Fecha,
                        p_entPrecioServicio.FxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos el registro
                PrsUpdt(p_dbcAccess, p_entPrecioServicio, p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Agrega un registro a la tabla a partir de una entidad: EPrecioServicio
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entPrecioServicio">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void PrsInsr(DBConn p_dbcAccess,
                                     EPrecioServicio p_entPrecioServicio,
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                PrsTInt(p_dbcAccess, p_entPrecioServicio, p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: PreciosServicios
                Dal.PreciosServicios.Insert(p_dbcAccess,
                                            p_entPrecioServicio.Color,
                                            p_entPrecioServicio.Fecha,
                                            p_entPrecioServicio.Precio,
                                            p_entPrecioServicio.Coseguro,
                                            p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Actualiza un registro a la tabla a partir de una entidad: EPrecioServicio
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entPrecioServicio">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void PrsUpdt(DBConn p_dbcAccess,
                                     EPrecioServicio p_entPrecioServicio,
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                PrsTInt(p_dbcAccess, p_entPrecioServicio, p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: PreciosServicios
                Dal.PreciosServicios.Update(p_dbcAccess,
                                            p_entPrecioServicio.Color,
                                            p_entPrecioServicio.Fecha,
                                            p_entPrecioServicio.Precio,
                                            p_entPrecioServicio.Coseguro,
                                            p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra físicamente un registro de a tabla: PreciosServicios
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strColor">Color</param>
        /// <param name="p_dtFecha">Fecha</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void PrsDrop(DBConn p_dbcAccess,
                                     string p_strColor,
                                     DateTime p_dtFecha,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            try {
                // Verificamos la clave a borrar
                PrsVKey(p_dbcAccess,
                        p_strColor,
                        p_dtFecha,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (PrecioServicio) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                PrsVVer(p_dbcAccess, 
                        p_strColor,
                        p_dtFecha,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Borramos físicamente el registro
                Dal.PreciosServicios.Drop(p_dbcAccess,
                                          p_strColor,
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
        internal static void PrsPack(DBConn p_dbcAccess,
                                     StatMsg p_smResult)
        {
            try {
                // Borramos los borrados lógicamente
                Dal.PreciosServicios.Pack(p_dbcAccess,
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
        /// Ejecuta el SP definido por el usuario: GetHistorialColor
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_strColor>Color</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static LEPreciosServicios PrsGetHistorialColor(DBConn p_dbcAccess,
                                                                string p_strColor,
                                                                StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.PreciosServicios.GetHistorialColor(p_dbcAccess,
                                                       p_strColor,
                                                       ref l_dsTemp,
                                                       "Temporal",
                                                       p_smResult);
                if (p_smResult.NOk) return null;

                // Captionamos el resultado
                Dal.PreciosServicios.MakeGridCaptions(ref l_dsTemp, "Temporal", p_smResult);
                if (p_smResult.NOk) return null;

                // Creamos la ListaEntidad y la devolvemos
                LEPreciosServicios l_lentRet= new LEPreciosServicios(l_dsTemp.Tables["Temporal"]);
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
        // Funciones para la Tabla: ResEntrevista
        // Usando ClaseDal        : ResEntrevista
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos públicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: ResEntrevista
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEResEntrevistas</returns>
        public static LEResEntrevistas RenUpFull(bool p_bOnlyActive,
                                                 StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                return RenUpfl(l_dbcAccess, p_bOnlyActive, p_smResult);
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
        /// Devuelve una entidad: EResEntrevista
        /// </summary>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EResEntrevista</returns>
        public static EResEntrevista RenGet(string p_strCod,
                                            bool p_bOnlyActive,
                                            StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCod= EResEntrevista.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: EResEntrevista
                return RenSrch(l_dbcAccess,
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

        /// <summary>
        /// Devuelve la próxima clave de la entidad
        /// </summary>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Próxima clave</returns>
        public static string RenNextKey(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la clave máxima
                return RenGetNK(l_dbcAccess,
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

        #region Metodos publicos de grabacion

        /// <summary>
        /// Agrega o modifica un registro de la tabla: ResEntrevista
        /// </summary>
        /// <param name="p_entResEntrevista">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void RenSave(EResEntrevista p_entResEntrevista,
                                   StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: EResEntrevista
                RenSSav(l_dbcAccess, p_entResEntrevista, p_smResult);
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
        /// Habilita/Deshabilita un registro de la tabla: ResEntrevista
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void RenEnabled(bool p_bEnable,
                                      string p_strCod,
                                      int p_iFxdVersion,
                                      StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCod= EResEntrevista.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                RenEnabled_f(l_dbcAccess,
                             p_bEnable,
                             p_strCod,
                             ref p_iFxdVersion,
                             p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                RenVKey(l_dbcAccess,
                        p_strCod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (ResEntrevista) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                RenVVer(l_dbcAccess, 
                        p_strCod,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.ResEntrevista.Recall(l_dbcAccess,
                                             p_strCod,
                                             p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.ResEntrevista.Delete(l_dbcAccess,
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
        /// Borra físicamento un registro de la tabla: ResEntrevista
        /// </summary>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void RenRemove(string p_strCod,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCod= EResEntrevista.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                RenRemove_f(l_dbcAccess,
                            p_strCod,
                            p_iFxdVersion,
                            p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                RenDrop(l_dbcAccess,
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
        public static void RenPurge(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Realizamos el borrado
                RenPack(l_dbcAccess,
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
        /// Valida la integridad de una entidad: ResEntrevista
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entResEntrevista">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void RenTInt(DBConn p_dbcAccess,
                                     EResEntrevista p_entResEntrevista,
                                     StatMsg p_smResult)
        {
            // ********
            // Validaciones de los campos sin conexion
            // ********

            if (p_entResEntrevista.Cod.Trim() == "") {
                // El campo [Código] no puede ser vacío
                p_smResult.BllWarning("El dato [Código] no puede ser vacío","");
                return;
            }

            if (p_entResEntrevista.Des.Trim() == "") {
                // El campo [Descripción] no puede ser vacío
                p_smResult.BllWarning("El dato [Descripción] no puede ser vacío","");
                return;
            }

            if ((p_entResEntrevista.Codfiltro != "S") &&
                (p_entResEntrevista.Codfiltro != "N")) {
                // El campo [Genera Contrato] tiene opciones
                p_smResult.BllWarning("El dato [Genera Contrato] sólo admite\r\n\r\n[S]- SI\r\n[N]- NO\r\n","");
                return;
            }

            // ********
            // Validaciones de los campos con conexion
            // ********

            // Llamamos a la funcion fija del usuario
            RenTInt_f(p_dbcAccess, p_entResEntrevista, p_smResult);
            if (p_smResult.NOk) return;
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: EResEntrevista
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave está deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void RenVKey(DBConn p_dbcAccess,
                                     string p_strCod,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            Dal.ResEntrevista.Search(p_dbcAccess,
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

        /// <summary>
        /// Verifica el número de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_iFxdVersion">Número de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void RenVVer(DBConn p_dbcAccess,
                                     string p_strCod,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            // Verificamos el número de versión
            Dal.ResEntrevista.ChkVersion(p_dbcAccess,
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
            p_smResult.BllWarning("El número de versión del registro del ítem (ResEntrevista) no coincide.\r\nOperación cancelada.","");
        }
        #endregion

        #region Metodos internos de recupero

        /// <summary>
        /// Devuelve una Lista-entidad: LEResEntrevistas
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEResEntrevistas</returns>
        internal static LEResEntrevistas RenUpfl(DBConn p_dbcAccess,
                                                  bool p_bOnlyActive,
                                                  StatMsg p_smResult)
        {
            try {
                // Pedimos los registros de la tabla: ResEntrevista
                DataSet l_dsTemp= new DataSet();

                Dal.ResEntrevista.Up(p_dbcAccess, 
                                     p_bOnlyActive,
                                     ref l_dsTemp, "Temporal",
                                     p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.ResEntrevista.MakeGridCaptions(ref l_dsTemp, "Temporal", p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LEResEntrevistas l_lentRet= new LEResEntrevistas(l_dsTemp.Tables["Temporal"]);
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
        /// Devuelve una entidad: EResEntrevista
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EResEntrevista</returns>
        internal static EResEntrevista RenSrch(DBConn p_dbcAccess,
                                               string p_strCod,
                                               bool p_bOnlyActive,
                                               StatMsg p_smResult)
        {
            try {
                // Pedimos el registro de la tabla: ResEntrevista
                DataSet l_dsTemp= new DataSet();

                Dal.ResEntrevista.Search(p_dbcAccess, 
                                         p_strCod,
                                         p_bOnlyActive,
                                         ref l_dsTemp, "Temporal",
                                         p_smResult);
                if (p_smResult.NOk) return null;

                // Constuimos la entidad y la devolvemos (si vino un registro)
                EResEntrevista l_entRet= null;

                if (l_dsTemp.Tables["Temporal"].Rows.Count == 1)
                    l_entRet= new EResEntrevista(l_dsTemp.Tables["Temporal"].Rows[0]);

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
        internal static string RenGetNK(DBConn p_dbcAccess,
                                        StatMsg p_smResult)
        {
            try {
                // Pedimos la clave máxima
                DataSet l_dsTemp= new DataSet();

                Dal.ResEntrevista.GetMaxKey(p_dbcAccess,
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
        /// Agrega o modifica un registro de la tabla: ResEntrevista
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entResEntrevista">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void RenSSav(DBConn p_dbcAccess,
                                     EResEntrevista p_entResEntrevista,
                                     StatMsg p_smResult)
        {
            try {
                // Procesamos codigo fijo
                RenSave_f(p_dbcAccess, ref p_entResEntrevista, p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                RenVKey(p_dbcAccess, 
                        p_entResEntrevista.Cod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entResEntrevista.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El ítem (ResEntrevista) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    RenInsr(p_dbcAccess, p_entResEntrevista, p_smResult);
                    return;
                }

                // Es un update. La clave debe existir y estar habilitada
                if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                    // Error. La clave no existe o no está habilitada
                    p_smResult.BllWarning("El ítem (ResEntrevista) que intenta modificar no existe en el sistema o no está habilitado.","");
                    return;
                }

                // Debe coincidir el número de version
                RenVVer(p_dbcAccess, 
                        p_entResEntrevista.Cod,
                        p_entResEntrevista.FxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos el registro
                RenUpdt(p_dbcAccess, p_entResEntrevista, p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Agrega un registro a la tabla a partir de una entidad: EResEntrevista
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entResEntrevista">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void RenInsr(DBConn p_dbcAccess,
                                     EResEntrevista p_entResEntrevista,
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                RenTInt(p_dbcAccess, p_entResEntrevista, p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: ResEntrevista
                Dal.ResEntrevista.Insert(p_dbcAccess,
                                         p_entResEntrevista.Cod,
                                         p_entResEntrevista.Des,
                                         p_entResEntrevista.Codfiltro,
                                         p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Actualiza un registro a la tabla a partir de una entidad: EResEntrevista
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entResEntrevista">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void RenUpdt(DBConn p_dbcAccess,
                                     EResEntrevista p_entResEntrevista,
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                RenTInt(p_dbcAccess, p_entResEntrevista, p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: ResEntrevista
                Dal.ResEntrevista.Update(p_dbcAccess,
                                         p_entResEntrevista.Cod,
                                         p_entResEntrevista.Des,
                                         p_entResEntrevista.Codfiltro,
                                         p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra físicamente un registro de a tabla: ResEntrevista
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void RenDrop(DBConn p_dbcAccess,
                                     string p_strCod,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            try {
                // Verificamos la clave a borrar
                RenVKey(p_dbcAccess,
                        p_strCod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (ResEntrevista) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                RenVVer(p_dbcAccess, 
                        p_strCod,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Borramos físicamente el registro
                Dal.ResEntrevista.Drop(p_dbcAccess,
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
        internal static void RenPack(DBConn p_dbcAccess,
                                     StatMsg p_smResult)
        {
            try {
                // Borramos los borrados lógicamente
                Dal.ResEntrevista.Pack(p_dbcAccess,
                                       p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }
        #endregion

        #region Metodos para métodos DAL definidos por el usuario
        #endregion


        //**********************************************************
        //
        // Funciones para la Tabla: Rubros
        // Usando ClaseDal        : Rubros
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos públicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: Rubros
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LERubros</returns>
        public static LERubros RbrUpFull(bool p_bOnlyActive,
                                         StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                return RbrUpfl(l_dbcAccess, p_bOnlyActive, p_smResult);
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
        /// Devuelve una entidad: ERubro
        /// </summary>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: ERubro</returns>
        public static ERubro RbrGet(string p_strCod,
                                    bool p_bOnlyActive,
                                    StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCod= ERubro.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: ERubro
                return RbrSrch(l_dbcAccess,
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

        /// <summary>
        /// Devuelve la próxima clave de la entidad
        /// </summary>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Próxima clave</returns>
        public static string RbrNextKey(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la clave máxima
                return RbrGetNK(l_dbcAccess,
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

        #region Metodos publicos de grabacion

        /// <summary>
        /// Agrega o modifica un registro de la tabla: Rubros
        /// </summary>
        /// <param name="p_entRubro">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void RbrSave(ERubro p_entRubro,
                                   StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: ERubro
                RbrSSav(l_dbcAccess, p_entRubro, p_smResult);
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
        /// Habilita/Deshabilita un registro de la tabla: Rubros
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void RbrEnabled(bool p_bEnable,
                                      string p_strCod,
                                      int p_iFxdVersion,
                                      StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCod= ERubro.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                RbrEnabled_f(l_dbcAccess,
                             p_bEnable,
                             p_strCod,
                             ref p_iFxdVersion,
                             p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                RbrVKey(l_dbcAccess,
                        p_strCod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (Rubro) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                RbrVVer(l_dbcAccess, 
                        p_strCod,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.Rubros.Recall(l_dbcAccess,
                                      p_strCod,
                                      p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.Rubros.Delete(l_dbcAccess,
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
        /// Borra físicamento un registro de la tabla: Rubros
        /// </summary>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void RbrRemove(string p_strCod,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCod= ERubro.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                RbrRemove_f(l_dbcAccess,
                            p_strCod,
                            p_iFxdVersion,
                            p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                RbrDrop(l_dbcAccess,
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
        public static void RbrPurge(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Realizamos el borrado
                RbrPack(l_dbcAccess,
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
        /// Valida la integridad de una entidad: Rubro
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entRubro">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void RbrTInt(DBConn p_dbcAccess,
                                     ERubro p_entRubro,
                                     StatMsg p_smResult)
        {
            // ********
            // Validaciones de los campos sin conexion
            // ********

            if (p_entRubro.Cod.Trim() == "") {
                // El campo [Código] no puede ser vacío
                p_smResult.BllWarning("El dato [Código] no puede ser vacío","");
                return;
            }

            if (p_entRubro.Des.Trim() == "") {
                // El campo [Descripción] no puede ser vacío
                p_smResult.BllWarning("El dato [Descripción] no puede ser vacío","");
                return;
            }

            // ********
            // Validaciones de los campos con conexion
            // ********

            // Llamamos a la funcion fija del usuario
            RbrTInt_f(p_dbcAccess, p_entRubro, p_smResult);
            if (p_smResult.NOk) return;
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: ERubro
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave está deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void RbrVKey(DBConn p_dbcAccess,
                                     string p_strCod,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            Dal.Rubros.Search(p_dbcAccess,
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

        /// <summary>
        /// Verifica el número de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_iFxdVersion">Número de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void RbrVVer(DBConn p_dbcAccess,
                                     string p_strCod,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            // Verificamos el número de versión
            Dal.Rubros.ChkVersion(p_dbcAccess,
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
            p_smResult.BllWarning("El número de versión del registro del ítem (Rubro) no coincide.\r\nOperación cancelada.","");
        }
        #endregion

        #region Metodos internos de recupero

        /// <summary>
        /// Devuelve una Lista-entidad: LERubros
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LERubros</returns>
        internal static LERubros RbrUpfl(DBConn p_dbcAccess,
                                          bool p_bOnlyActive,
                                          StatMsg p_smResult)
        {
            try {
                // Pedimos los registros de la tabla: Rubros
                DataSet l_dsTemp= new DataSet();

                Dal.Rubros.Up(p_dbcAccess, 
                              p_bOnlyActive,
                              ref l_dsTemp, "Temporal",
                              p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.Rubros.MakeGridCaptions(ref l_dsTemp, "Temporal", p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LERubros l_lentRet= new LERubros(l_dsTemp.Tables["Temporal"]);
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
        /// Devuelve una entidad: ERubro
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: ERubro</returns>
        internal static ERubro RbrSrch(DBConn p_dbcAccess,
                                       string p_strCod,
                                       bool p_bOnlyActive,
                                       StatMsg p_smResult)
        {
            try {
                // Pedimos el registro de la tabla: Rubros
                DataSet l_dsTemp= new DataSet();

                Dal.Rubros.Search(p_dbcAccess, 
                                  p_strCod,
                                  p_bOnlyActive,
                                  ref l_dsTemp, "Temporal",
                                  p_smResult);
                if (p_smResult.NOk) return null;

                // Constuimos la entidad y la devolvemos (si vino un registro)
                ERubro l_entRet= null;

                if (l_dsTemp.Tables["Temporal"].Rows.Count == 1)
                    l_entRet= new ERubro(l_dsTemp.Tables["Temporal"].Rows[0]);

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
        internal static string RbrGetNK(DBConn p_dbcAccess,
                                        StatMsg p_smResult)
        {
            try {
                // Pedimos la clave máxima
                DataSet l_dsTemp= new DataSet();

                Dal.Rubros.GetMaxKey(p_dbcAccess,
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
        /// Agrega o modifica un registro de la tabla: Rubros
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entRubro">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void RbrSSav(DBConn p_dbcAccess,
                                     ERubro p_entRubro,
                                     StatMsg p_smResult)
        {
            try {
                // Procesamos codigo fijo
                RbrSave_f(p_dbcAccess, ref p_entRubro, p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                RbrVKey(p_dbcAccess, 
                        p_entRubro.Cod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entRubro.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El ítem (Rubro) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    RbrInsr(p_dbcAccess, p_entRubro, p_smResult);
                    return;
                }

                // Es un update. La clave debe existir y estar habilitada
                if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                    // Error. La clave no existe o no está habilitada
                    p_smResult.BllWarning("El ítem (Rubro) que intenta modificar no existe en el sistema o no está habilitado.","");
                    return;
                }

                // Debe coincidir el número de version
                RbrVVer(p_dbcAccess, 
                        p_entRubro.Cod,
                        p_entRubro.FxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos el registro
                RbrUpdt(p_dbcAccess, p_entRubro, p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Agrega un registro a la tabla a partir de una entidad: ERubro
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entRubro">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void RbrInsr(DBConn p_dbcAccess,
                                     ERubro p_entRubro,
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                RbrTInt(p_dbcAccess, p_entRubro, p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: Rubros
                Dal.Rubros.Insert(p_dbcAccess,
                                  p_entRubro.Cod,
                                  p_entRubro.Des,
                                  p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Actualiza un registro a la tabla a partir de una entidad: ERubro
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entRubro">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void RbrUpdt(DBConn p_dbcAccess,
                                     ERubro p_entRubro,
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                RbrTInt(p_dbcAccess, p_entRubro, p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: Rubros
                Dal.Rubros.Update(p_dbcAccess,
                                  p_entRubro.Cod,
                                  p_entRubro.Des,
                                  p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra físicamente un registro de a tabla: Rubros
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void RbrDrop(DBConn p_dbcAccess,
                                     string p_strCod,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            try {
                // Verificamos la clave a borrar
                RbrVKey(p_dbcAccess,
                        p_strCod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (Rubro) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                RbrVVer(p_dbcAccess, 
                        p_strCod,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Borramos físicamente el registro
                Dal.Rubros.Drop(p_dbcAccess,
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
        internal static void RbrPack(DBConn p_dbcAccess,
                                     StatMsg p_smResult)
        {
            try {
                // Borramos los borrados lógicamente
                Dal.Rubros.Pack(p_dbcAccess,
                                p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }
        #endregion

        #region Metodos para métodos DAL definidos por el usuario
        #endregion


        //**********************************************************
        //
        // Funciones para la Tabla: SituacionesIVA
        // Usando ClaseDal        : SituacionesIVA
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos públicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: SituacionesIVA
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LESituacionesIVAs</returns>
        public static LESituacionesIVAs SivUpFull(bool p_bOnlyActive,
                                                  StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                return SivUpfl(l_dbcAccess, p_bOnlyActive, p_smResult);
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
        /// Devuelve una entidad: ESituacionIVA
        /// </summary>
        /// <param name="p_strCodigo">Codigo</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: ESituacionIVA</returns>
        public static ESituacionIVA SivGet(string p_strCodigo,
                                           bool p_bOnlyActive,
                                           StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: ESituacionIVA
                return SivSrch(l_dbcAccess,
                               p_strCodigo,
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
        /// Agrega o modifica un registro de la tabla: SituacionesIVA
        /// </summary>
        /// <param name="p_entSituacionIVA">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void SivSave(ESituacionIVA p_entSituacionIVA,
                                   StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: ESituacionIVA
                SivSSav(l_dbcAccess, p_entSituacionIVA, p_smResult);
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
        /// Habilita/Deshabilita un registro de la tabla: SituacionesIVA
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCodigo">Codigo</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void SivEnabled(bool p_bEnable,
                                      string p_strCodigo,
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
                SivEnabled_f(l_dbcAccess,
                             p_bEnable,
                             p_strCodigo,
                             ref p_iFxdVersion,
                             p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                SivVKey(l_dbcAccess,
                        p_strCodigo,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (SituacionIVA) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                SivVVer(l_dbcAccess, 
                        p_strCodigo,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.SituacionesIVA.Recall(l_dbcAccess,
                                              p_strCodigo,
                                              p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.SituacionesIVA.Delete(l_dbcAccess,
                                              p_strCodigo,
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
        /// Borra físicamento un registro de la tabla: SituacionesIVA
        /// </summary>
        /// <param name="p_strCodigo">Codigo</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void SivRemove(string p_strCodigo,
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
                SivRemove_f(l_dbcAccess,
                            p_strCodigo,
                            p_iFxdVersion,
                            p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                SivDrop(l_dbcAccess,
                        p_strCodigo,
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
        public static void SivPurge(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Realizamos el borrado
                SivPack(l_dbcAccess,
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
        /// Valida la integridad de una entidad: SituacionIVA
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entSituacionIVA">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void SivTInt(DBConn p_dbcAccess,
                                     ESituacionIVA p_entSituacionIVA,
                                     StatMsg p_smResult)
        {
            // ********
            // Validaciones de los campos sin conexion
            // ********

            // ********
            // Validaciones de los campos con conexion
            // ********

            // Llamamos a la funcion fija del usuario
            SivTInt_f(p_dbcAccess, p_entSituacionIVA, p_smResult);
            if (p_smResult.NOk) return;
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: ESituacionIVA
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave está deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodigo">Codigo</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void SivVKey(DBConn p_dbcAccess,
                                     string p_strCodigo,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            Dal.SituacionesIVA.Search(p_dbcAccess,
                                      p_strCodigo,
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

        /// <summary>
        /// Verifica el número de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodigo">Codigo</param>
        /// <param name="p_iFxdVersion">Número de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void SivVVer(DBConn p_dbcAccess,
                                     string p_strCodigo,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            // Verificamos el número de versión
            Dal.SituacionesIVA.ChkVersion(p_dbcAccess,
                                          p_strCodigo,
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
            p_smResult.BllWarning("El número de versión del registro del ítem (SituacionIVA) no coincide.\r\nOperación cancelada.","");
        }
        #endregion

        #region Metodos internos de recupero

        /// <summary>
        /// Devuelve una Lista-entidad: LESituacionesIVAs
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LESituacionesIVAs</returns>
        internal static LESituacionesIVAs SivUpfl(DBConn p_dbcAccess,
                                                   bool p_bOnlyActive,
                                                   StatMsg p_smResult)
        {
            try {
                // Pedimos los registros de la tabla: SituacionesIVA
                DataSet l_dsTemp= new DataSet();

                Dal.SituacionesIVA.Up(p_dbcAccess, 
                                      p_bOnlyActive,
                                      ref l_dsTemp, "Temporal",
                                      p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.SituacionesIVA.MakeGridCaptions(ref l_dsTemp, "Temporal", p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LESituacionesIVAs l_lentRet= new LESituacionesIVAs(l_dsTemp.Tables["Temporal"]);
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
        /// Devuelve una entidad: ESituacionIVA
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodigo">Codigo</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: ESituacionIVA</returns>
        internal static ESituacionIVA SivSrch(DBConn p_dbcAccess,
                                              string p_strCodigo,
                                              bool p_bOnlyActive,
                                              StatMsg p_smResult)
        {
            try {
                // Pedimos el registro de la tabla: SituacionesIVA
                DataSet l_dsTemp= new DataSet();

                Dal.SituacionesIVA.Search(p_dbcAccess, 
                                          p_strCodigo,
                                          p_bOnlyActive,
                                          ref l_dsTemp, "Temporal",
                                          p_smResult);
                if (p_smResult.NOk) return null;

                // Constuimos la entidad y la devolvemos (si vino un registro)
                ESituacionIVA l_entRet= null;

                if (l_dsTemp.Tables["Temporal"].Rows.Count == 1)
                    l_entRet= new ESituacionIVA(l_dsTemp.Tables["Temporal"].Rows[0]);

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
        /// Agrega o modifica un registro de la tabla: SituacionesIVA
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entSituacionIVA">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void SivSSav(DBConn p_dbcAccess,
                                     ESituacionIVA p_entSituacionIVA,
                                     StatMsg p_smResult)
        {
            try {
                // Procesamos codigo fijo
                SivSave_f(p_dbcAccess, ref p_entSituacionIVA, p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                SivVKey(p_dbcAccess, 
                        p_entSituacionIVA.Codigo,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entSituacionIVA.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El ítem (SituacionIVA) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    SivInsr(p_dbcAccess, p_entSituacionIVA, p_smResult);
                    return;
                }

                // Es un update. La clave debe existir y estar habilitada
                if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                    // Error. La clave no existe o no está habilitada
                    p_smResult.BllWarning("El ítem (SituacionIVA) que intenta modificar no existe en el sistema o no está habilitado.","");
                    return;
                }

                // Debe coincidir el número de version
                SivVVer(p_dbcAccess, 
                        p_entSituacionIVA.Codigo,
                        p_entSituacionIVA.FxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos el registro
                SivUpdt(p_dbcAccess, p_entSituacionIVA, p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Agrega un registro a la tabla a partir de una entidad: ESituacionIVA
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entSituacionIVA">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void SivInsr(DBConn p_dbcAccess,
                                     ESituacionIVA p_entSituacionIVA,
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                SivTInt(p_dbcAccess, p_entSituacionIVA, p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: SituacionesIVA
                Dal.SituacionesIVA.Insert(p_dbcAccess,
                                          p_entSituacionIVA.Codigo,
                                          p_entSituacionIVA.Descripcion,
                                          p_entSituacionIVA.Discrimina,
                                          p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Actualiza un registro a la tabla a partir de una entidad: ESituacionIVA
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entSituacionIVA">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void SivUpdt(DBConn p_dbcAccess,
                                     ESituacionIVA p_entSituacionIVA,
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                SivTInt(p_dbcAccess, p_entSituacionIVA, p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: SituacionesIVA
                Dal.SituacionesIVA.Update(p_dbcAccess,
                                          p_entSituacionIVA.Codigo,
                                          p_entSituacionIVA.Descripcion,
                                          p_entSituacionIVA.Discrimina,
                                          p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra físicamente un registro de a tabla: SituacionesIVA
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodigo">Codigo</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void SivDrop(DBConn p_dbcAccess,
                                     string p_strCodigo,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            try {
                // Verificamos la clave a borrar
                SivVKey(p_dbcAccess,
                        p_strCodigo,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (SituacionIVA) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                SivVVer(p_dbcAccess, 
                        p_strCodigo,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Borramos físicamente el registro
                Dal.SituacionesIVA.Drop(p_dbcAccess,
                                        p_strCodigo,
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
        internal static void SivPack(DBConn p_dbcAccess,
                                     StatMsg p_smResult)
        {
            try {
                // Borramos los borrados lógicamente
                Dal.SituacionesIVA.Pack(p_dbcAccess,
                                        p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }
        #endregion

        #region Metodos para métodos DAL definidos por el usuario
        #endregion


        //**********************************************************
        //
        // Funciones para la Tabla: TipoVend
        // Usando ClaseDal        : TVendedores
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos públicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: TipoVend
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LETipoVendedores</returns>
        public static LETipoVendedores TvdUpFull(bool p_bOnlyActive,
                                                 StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                return TvdUpfl(l_dbcAccess, p_bOnlyActive, p_smResult);
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
        /// Devuelve una entidad: ETipoVendedor
        /// </summary>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: ETipoVendedor</returns>
        public static ETipoVendedor TvdGet(string p_strCod,
                                           bool p_bOnlyActive,
                                           StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCod= ETipoVendedor.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: ETipoVendedor
                return TvdSrch(l_dbcAccess,
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

        /// <summary>
        /// Devuelve la próxima clave de la entidad
        /// </summary>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Próxima clave</returns>
        public static string TvdNextKey(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la clave máxima
                return TvdGetNK(l_dbcAccess,
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

        #region Metodos publicos de grabacion

        /// <summary>
        /// Agrega o modifica un registro de la tabla: TipoVend
        /// </summary>
        /// <param name="p_entTipoVendedor">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void TvdSave(ETipoVendedor p_entTipoVendedor,
                                   StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: ETipoVendedor
                TvdSSav(l_dbcAccess, p_entTipoVendedor, p_smResult);
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
        /// Habilita/Deshabilita un registro de la tabla: TipoVend
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void TvdEnabled(bool p_bEnable,
                                      string p_strCod,
                                      int p_iFxdVersion,
                                      StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCod= ETipoVendedor.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                TvdEnabled_f(l_dbcAccess,
                             p_bEnable,
                             p_strCod,
                             ref p_iFxdVersion,
                             p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                TvdVKey(l_dbcAccess,
                        p_strCod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (TipoVendedor) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                TvdVVer(l_dbcAccess, 
                        p_strCod,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.TVendedores.Recall(l_dbcAccess,
                                           p_strCod,
                                           p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.TVendedores.Delete(l_dbcAccess,
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
        /// Borra físicamento un registro de la tabla: TipoVend
        /// </summary>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void TvdRemove(string p_strCod,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCod= ETipoVendedor.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                TvdRemove_f(l_dbcAccess,
                            p_strCod,
                            p_iFxdVersion,
                            p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                TvdDrop(l_dbcAccess,
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
        public static void TvdPurge(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Realizamos el borrado
                TvdPack(l_dbcAccess,
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
        /// Valida la integridad de una entidad: TipoVendedor
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entTipoVendedor">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TvdTInt(DBConn p_dbcAccess,
                                     ETipoVendedor p_entTipoVendedor,
                                     StatMsg p_smResult)
        {
            // ********
            // Validaciones de los campos sin conexion
            // ********

            if (p_entTipoVendedor.Cod.Trim() == "") {
                // El campo [Codigo] no puede ser vacío
                p_smResult.BllWarning("El dato [Codigo] no puede ser vacío","");
                return;
            }

            if (p_entTipoVendedor.Des.Trim() == "") {
                // El campo [Descripcion] no puede ser vacío
                p_smResult.BllWarning("El dato [Descripcion] no puede ser vacío","");
                return;
            }

            if (p_entTipoVendedor.Vemayor.Trim() != "") {
                if ((p_entTipoVendedor.Vemayor != "S") &&
                    (p_entTipoVendedor.Vemayor != "N")) {
                    // El campo [Ve Mayoristas] tiene opciones
                    p_smResult.BllWarning("El dato [Ve Mayoristas] sólo admite\r\n\r\n[S]- SI\r\n[N]- NO\r\n","");
                    return;
                }
            }

            // ********
            // Validaciones de los campos con conexion
            // ********

            // Llamamos a la funcion fija del usuario
            TvdTInt_f(p_dbcAccess, p_entTipoVendedor, p_smResult);
            if (p_smResult.NOk) return;
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: ETipoVendedor
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave está deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TvdVKey(DBConn p_dbcAccess,
                                     string p_strCod,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            Dal.TVendedores.Search(p_dbcAccess,
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

        /// <summary>
        /// Verifica el número de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_iFxdVersion">Número de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TvdVVer(DBConn p_dbcAccess,
                                     string p_strCod,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            // Verificamos el número de versión
            Dal.TVendedores.ChkVersion(p_dbcAccess,
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
            p_smResult.BllWarning("El número de versión del registro del ítem (TipoVendedor) no coincide.\r\nOperación cancelada.","");
        }
        #endregion

        #region Metodos internos de recupero

        /// <summary>
        /// Devuelve una Lista-entidad: LETipoVendedores
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LETipoVendedores</returns>
        internal static LETipoVendedores TvdUpfl(DBConn p_dbcAccess,
                                                  bool p_bOnlyActive,
                                                  StatMsg p_smResult)
        {
            try {
                // Pedimos los registros de la tabla: TipoVend
                DataSet l_dsTemp= new DataSet();

                Dal.TVendedores.Up(p_dbcAccess, 
                                   p_bOnlyActive,
                                   ref l_dsTemp, "Temporal",
                                   p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.TVendedores.MakeGridCaptions(ref l_dsTemp, "Temporal", p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LETipoVendedores l_lentRet= new LETipoVendedores(l_dsTemp.Tables["Temporal"]);
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
        /// Devuelve una entidad: ETipoVendedor
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: ETipoVendedor</returns>
        internal static ETipoVendedor TvdSrch(DBConn p_dbcAccess,
                                              string p_strCod,
                                              bool p_bOnlyActive,
                                              StatMsg p_smResult)
        {
            try {
                // Pedimos el registro de la tabla: TipoVend
                DataSet l_dsTemp= new DataSet();

                Dal.TVendedores.Search(p_dbcAccess, 
                                       p_strCod,
                                       p_bOnlyActive,
                                       ref l_dsTemp, "Temporal",
                                       p_smResult);
                if (p_smResult.NOk) return null;

                // Constuimos la entidad y la devolvemos (si vino un registro)
                ETipoVendedor l_entRet= null;

                if (l_dsTemp.Tables["Temporal"].Rows.Count == 1)
                    l_entRet= new ETipoVendedor(l_dsTemp.Tables["Temporal"].Rows[0]);

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
        internal static string TvdGetNK(DBConn p_dbcAccess,
                                        StatMsg p_smResult)
        {
            try {
                // Pedimos la clave máxima
                DataSet l_dsTemp= new DataSet();

                Dal.TVendedores.GetMaxKey(p_dbcAccess,
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
        /// Agrega o modifica un registro de la tabla: TipoVend
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entTipoVendedor">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TvdSSav(DBConn p_dbcAccess,
                                     ETipoVendedor p_entTipoVendedor,
                                     StatMsg p_smResult)
        {
            try {
                // Procesamos codigo fijo
                TvdSave_f(p_dbcAccess, ref p_entTipoVendedor, p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                TvdVKey(p_dbcAccess, 
                        p_entTipoVendedor.Cod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entTipoVendedor.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El ítem (TipoVendedor) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    TvdInsr(p_dbcAccess, p_entTipoVendedor, p_smResult);
                    return;
                }

                // Es un update. La clave debe existir y estar habilitada
                if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                    // Error. La clave no existe o no está habilitada
                    p_smResult.BllWarning("El ítem (TipoVendedor) que intenta modificar no existe en el sistema o no está habilitado.","");
                    return;
                }

                // Debe coincidir el número de version
                TvdVVer(p_dbcAccess, 
                        p_entTipoVendedor.Cod,
                        p_entTipoVendedor.FxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos el registro
                TvdUpdt(p_dbcAccess, p_entTipoVendedor, p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Agrega un registro a la tabla a partir de una entidad: ETipoVendedor
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entTipoVendedor">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TvdInsr(DBConn p_dbcAccess,
                                     ETipoVendedor p_entTipoVendedor,
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                TvdTInt(p_dbcAccess, p_entTipoVendedor, p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: TipoVend
                Dal.TVendedores.Insert(p_dbcAccess,
                                       p_entTipoVendedor.Cod,
                                       p_entTipoVendedor.Des,
                                       p_entTipoVendedor.Vemayor,
                                       p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Actualiza un registro a la tabla a partir de una entidad: ETipoVendedor
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entTipoVendedor">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TvdUpdt(DBConn p_dbcAccess,
                                     ETipoVendedor p_entTipoVendedor,
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                TvdTInt(p_dbcAccess, p_entTipoVendedor, p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: TipoVend
                Dal.TVendedores.Update(p_dbcAccess,
                                       p_entTipoVendedor.Cod,
                                       p_entTipoVendedor.Des,
                                       p_entTipoVendedor.Vemayor,
                                       p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra físicamente un registro de a tabla: TipoVend
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TvdDrop(DBConn p_dbcAccess,
                                     string p_strCod,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            try {
                // Verificamos la clave a borrar
                TvdVKey(p_dbcAccess,
                        p_strCod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (TipoVendedor) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                TvdVVer(p_dbcAccess, 
                        p_strCod,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Borramos físicamente el registro
                Dal.TVendedores.Drop(p_dbcAccess,
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
        internal static void TvdPack(DBConn p_dbcAccess,
                                     StatMsg p_smResult)
        {
            try {
                // Borramos los borrados lógicamente
                Dal.TVendedores.Pack(p_dbcAccess,
                                     p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }
        #endregion

        #region Metodos para métodos DAL definidos por el usuario
        #endregion


        //**********************************************************
        //
        // Funciones para la Tabla: TipoCont
        // Usando ClaseDal        : TipoCont
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos públicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: TipoCont
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LETipoConts</returns>
        public static LETipoConts TcnUpFull(bool p_bOnlyActive,
                                            StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                return TcnUpfl(l_dbcAccess, p_bOnlyActive, p_smResult);
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
        /// Devuelve una entidad: ETipoCont
        /// </summary>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: ETipoCont</returns>
        public static ETipoCont TcnGet(string p_strCod,
                                       bool p_bOnlyActive,
                                       StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCod= ETipoCont.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: ETipoCont
                return TcnSrch(l_dbcAccess,
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

        /// <summary>
        /// Devuelve la próxima clave de la entidad
        /// </summary>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Próxima clave</returns>
        public static string TcnNextKey(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la clave máxima
                return TcnGetNK(l_dbcAccess,
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

        #region Metodos publicos de grabacion

        /// <summary>
        /// Agrega o modifica un registro de la tabla: TipoCont
        /// </summary>
        /// <param name="p_entTipoCont">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void TcnSave(ETipoCont p_entTipoCont,
                                   StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: ETipoCont
                TcnSSav(l_dbcAccess, p_entTipoCont, p_smResult);
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
        /// Habilita/Deshabilita un registro de la tabla: TipoCont
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void TcnEnabled(bool p_bEnable,
                                      string p_strCod,
                                      int p_iFxdVersion,
                                      StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCod= ETipoCont.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                TcnEnabled_f(l_dbcAccess,
                             p_bEnable,
                             p_strCod,
                             ref p_iFxdVersion,
                             p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                TcnVKey(l_dbcAccess,
                        p_strCod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (TipoCont) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                TcnVVer(l_dbcAccess, 
                        p_strCod,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.TipoCont.Recall(l_dbcAccess,
                                        p_strCod,
                                        p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.TipoCont.Delete(l_dbcAccess,
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
        /// Borra físicamento un registro de la tabla: TipoCont
        /// </summary>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void TcnRemove(string p_strCod,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCod= ETipoCont.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                TcnRemove_f(l_dbcAccess,
                            p_strCod,
                            p_iFxdVersion,
                            p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                TcnDrop(l_dbcAccess,
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
        public static void TcnPurge(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Realizamos el borrado
                TcnPack(l_dbcAccess,
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
        /// Valida la integridad de una entidad: TipoCont
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entTipoCont">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TcnTInt(DBConn p_dbcAccess,
                                     ETipoCont p_entTipoCont,
                                     StatMsg p_smResult)
        {
            // ********
            // Validaciones de los campos sin conexion
            // ********

            if (p_entTipoCont.Cod.Trim() == "") {
                // El campo [Código] no puede ser vacío
                p_smResult.BllWarning("El dato [Código] no puede ser vacío","");
                return;
            }

            if (p_entTipoCont.Des.Trim() == "") {
                // El campo [Descripción] no puede ser vacío
                p_smResult.BllWarning("El dato [Descripción] no puede ser vacío","");
                return;
            }

            if ((p_entTipoCont.Modo != "F") &&
                (p_entTipoCont.Modo != "C") &&
                (p_entTipoCont.Modo != "P") &&
                (p_entTipoCont.Modo != "A")) {
                // El campo [Modo Venta] tiene opciones
                p_smResult.BllWarning("El dato [Modo Venta] sólo admite\r\n\r\n[F]- ABONO FIJO\r\n[C]- CAPITADO\r\n[P]- PRESTACIÓN\r\n[A]- ABONO + PRESTACIÓN\r\n","");
                return;
            }

            if (p_entTipoCont.Tcontratoavalon.Trim() == "") {
                // El campo [Tipo Contrato Avalon] no puede ser vacío
                p_smResult.BllWarning("El dato [Tipo Contrato Avalon] no puede ser vacío","");
                return;
            }

            // ********
            // Validaciones de los campos con conexion
            // ********

            // Llamamos a la funcion fija del usuario
            TcnTInt_f(p_dbcAccess, p_entTipoCont, p_smResult);
            if (p_smResult.NOk) return;
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: ETipoCont
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave está deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TcnVKey(DBConn p_dbcAccess,
                                     string p_strCod,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            Dal.TipoCont.Search(p_dbcAccess,
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

        /// <summary>
        /// Verifica el número de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_iFxdVersion">Número de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TcnVVer(DBConn p_dbcAccess,
                                     string p_strCod,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            // Verificamos el número de versión
            Dal.TipoCont.ChkVersion(p_dbcAccess,
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
            p_smResult.BllWarning("El número de versión del registro del ítem (TipoCont) no coincide.\r\nOperación cancelada.","");
        }
        #endregion

        #region Metodos internos de recupero

        /// <summary>
        /// Devuelve una Lista-entidad: LETipoConts
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LETipoConts</returns>
        internal static LETipoConts TcnUpfl(DBConn p_dbcAccess,
                                             bool p_bOnlyActive,
                                             StatMsg p_smResult)
        {
            try {
                // Pedimos los registros de la tabla: TipoCont
                DataSet l_dsTemp= new DataSet();

                Dal.TipoCont.Up(p_dbcAccess, 
                                p_bOnlyActive,
                                ref l_dsTemp, "Temporal",
                                p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.TipoCont.MakeGridCaptions(ref l_dsTemp, "Temporal", p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LETipoConts l_lentRet= new LETipoConts(l_dsTemp.Tables["Temporal"]);
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
        /// Devuelve una entidad: ETipoCont
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: ETipoCont</returns>
        internal static ETipoCont TcnSrch(DBConn p_dbcAccess,
                                          string p_strCod,
                                          bool p_bOnlyActive,
                                          StatMsg p_smResult)
        {
            try {
                // Pedimos el registro de la tabla: TipoCont
                DataSet l_dsTemp= new DataSet();

                Dal.TipoCont.Search(p_dbcAccess, 
                                    p_strCod,
                                    p_bOnlyActive,
                                    ref l_dsTemp, "Temporal",
                                    p_smResult);
                if (p_smResult.NOk) return null;

                // Constuimos la entidad y la devolvemos (si vino un registro)
                ETipoCont l_entRet= null;

                if (l_dsTemp.Tables["Temporal"].Rows.Count == 1)
                    l_entRet= new ETipoCont(l_dsTemp.Tables["Temporal"].Rows[0]);

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
        internal static string TcnGetNK(DBConn p_dbcAccess,
                                        StatMsg p_smResult)
        {
            try {
                // Pedimos la clave máxima
                DataSet l_dsTemp= new DataSet();

                Dal.TipoCont.GetMaxKey(p_dbcAccess,
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
        /// Agrega o modifica un registro de la tabla: TipoCont
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entTipoCont">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TcnSSav(DBConn p_dbcAccess,
                                     ETipoCont p_entTipoCont,
                                     StatMsg p_smResult)
        {
            try {
                // Procesamos codigo fijo
                TcnSave_f(p_dbcAccess, ref p_entTipoCont, p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                TcnVKey(p_dbcAccess, 
                        p_entTipoCont.Cod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entTipoCont.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El ítem (TipoCont) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    TcnInsr(p_dbcAccess, p_entTipoCont, p_smResult);
                    return;
                }

                // Es un update. La clave debe existir y estar habilitada
                if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                    // Error. La clave no existe o no está habilitada
                    p_smResult.BllWarning("El ítem (TipoCont) que intenta modificar no existe en el sistema o no está habilitado.","");
                    return;
                }

                // Debe coincidir el número de version
                TcnVVer(p_dbcAccess, 
                        p_entTipoCont.Cod,
                        p_entTipoCont.FxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos el registro
                TcnUpdt(p_dbcAccess, p_entTipoCont, p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Agrega un registro a la tabla a partir de una entidad: ETipoCont
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entTipoCont">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TcnInsr(DBConn p_dbcAccess,
                                     ETipoCont p_entTipoCont,
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                TcnTInt(p_dbcAccess, p_entTipoCont, p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: TipoCont
                Dal.TipoCont.Insert(p_dbcAccess,
                                    p_entTipoCont.Cod,
                                    p_entTipoCont.Des,
                                    p_entTipoCont.Modo,
                                    p_entTipoCont.Tcontratoavalon,
                                    p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Actualiza un registro a la tabla a partir de una entidad: ETipoCont
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entTipoCont">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TcnUpdt(DBConn p_dbcAccess,
                                     ETipoCont p_entTipoCont,
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                TcnTInt(p_dbcAccess, p_entTipoCont, p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: TipoCont
                Dal.TipoCont.Update(p_dbcAccess,
                                    p_entTipoCont.Cod,
                                    p_entTipoCont.Des,
                                    p_entTipoCont.Modo,
                                    p_entTipoCont.Tcontratoavalon,
                                    p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra físicamente un registro de a tabla: TipoCont
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TcnDrop(DBConn p_dbcAccess,
                                     string p_strCod,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            try {
                // Verificamos la clave a borrar
                TcnVKey(p_dbcAccess,
                        p_strCod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (TipoCont) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                TcnVVer(p_dbcAccess, 
                        p_strCod,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Borramos físicamente el registro
                Dal.TipoCont.Drop(p_dbcAccess,
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
        internal static void TcnPack(DBConn p_dbcAccess,
                                     StatMsg p_smResult)
        {
            try {
                // Borramos los borrados lógicamente
                Dal.TipoCont.Pack(p_dbcAccess,
                                  p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }
        #endregion

        #region Metodos para métodos DAL definidos por el usuario
        #endregion


        //**********************************************************
        //
        // Funciones para la Tabla: TipoInst
        // Usando ClaseDal        : TipoInst
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos públicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: TipoInst
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LETipoInsts</returns>
        public static LETipoInsts TinUpFull(bool p_bOnlyActive,
                                            StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                return TinUpfl(l_dbcAccess, p_bOnlyActive, p_smResult);
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
        /// Devuelve una entidad: ETipoInst
        /// </summary>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: ETipoInst</returns>
        public static ETipoInst TinGet(string p_strCod,
                                       bool p_bOnlyActive,
                                       StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCod= ETipoInst.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: ETipoInst
                return TinSrch(l_dbcAccess,
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

        /// <summary>
        /// Devuelve la próxima clave de la entidad
        /// </summary>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Próxima clave</returns>
        public static string TinNextKey(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la clave máxima
                return TinGetNK(l_dbcAccess,
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

        #region Metodos publicos de grabacion

        /// <summary>
        /// Agrega o modifica un registro de la tabla: TipoInst
        /// </summary>
        /// <param name="p_entTipoInst">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void TinSave(ETipoInst p_entTipoInst,
                                   StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: ETipoInst
                TinSSav(l_dbcAccess, p_entTipoInst, p_smResult);
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
        /// Habilita/Deshabilita un registro de la tabla: TipoInst
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void TinEnabled(bool p_bEnable,
                                      string p_strCod,
                                      int p_iFxdVersion,
                                      StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCod= ETipoInst.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                TinEnabled_f(l_dbcAccess,
                             p_bEnable,
                             p_strCod,
                             ref p_iFxdVersion,
                             p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                TinVKey(l_dbcAccess,
                        p_strCod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (TipoInst) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                TinVVer(l_dbcAccess, 
                        p_strCod,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.TipoInst.Recall(l_dbcAccess,
                                        p_strCod,
                                        p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.TipoInst.Delete(l_dbcAccess,
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
        /// Borra físicamento un registro de la tabla: TipoInst
        /// </summary>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void TinRemove(string p_strCod,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCod= ETipoInst.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                TinRemove_f(l_dbcAccess,
                            p_strCod,
                            p_iFxdVersion,
                            p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                TinDrop(l_dbcAccess,
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
        public static void TinPurge(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Realizamos el borrado
                TinPack(l_dbcAccess,
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
        /// Ejecuta el SP definido por el usuario: GetTiposInstRubro
        /// </summary>
        /// <param name= p_strCodrubro>Código de Rubro</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        public static ListaEntidades TinGetTiposInstRubro(string p_strCodrubro,
                                                          StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Abrimos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Llamamos al metodo interno
                return TinGetTiposInstRubro(l_dbcAccess,
                                            p_strCodrubro,
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
        /// Valida la integridad de una entidad: TipoInst
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entTipoInst">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TinTInt(DBConn p_dbcAccess,
                                     ETipoInst p_entTipoInst,
                                     StatMsg p_smResult)
        {
            // ********
            // Validaciones de los campos sin conexion
            // ********

            if (p_entTipoInst.Cod.Trim() == "") {
                // El campo [Código] no puede ser vacío
                p_smResult.BllWarning("El dato [Código] no puede ser vacío","");
                return;
            }

            if (p_entTipoInst.Des.Trim() == "") {
                // El campo [Descripción] no puede ser vacío
                p_smResult.BllWarning("El dato [Descripción] no puede ser vacío","");
                return;
            }

            if ((p_entTipoInst.Mayorista != "S") &&
                (p_entTipoInst.Mayorista != "N")) {
                // El campo [Mayorista] tiene opciones
                p_smResult.BllWarning("El dato [Mayorista] sólo admite\r\n\r\n[S]-  SI\r\n[N]-  NO\r\n","");
                return;
            }

            // ********
            // Validaciones de los campos con conexion
            // ********

            Tablas.RbrVKey(p_dbcAccess,
                           p_entTipoInst.Codrubro,
                           p_smResult);
            if (p_smResult.NOk) return;

            if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                // El campo [Rubro] debe existir en la tabla [Tablas.Rbr]
                p_smResult.BllWarning("El dato [Rubro] debe existir en la tabla [Tablas.Rbr] y estar habilitado","");
                return;
            }

            // Todas las validaciones fueron correctas

            // Llamamos a la funcion fija del usuario
            TinTInt_f(p_dbcAccess, p_entTipoInst, p_smResult);
            if (p_smResult.NOk) return;
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: ETipoInst
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave está deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TinVKey(DBConn p_dbcAccess,
                                     string p_strCod,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            Dal.TipoInst.Search(p_dbcAccess,
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

        /// <summary>
        /// Verifica el número de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_iFxdVersion">Número de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TinVVer(DBConn p_dbcAccess,
                                     string p_strCod,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            // Verificamos el número de versión
            Dal.TipoInst.ChkVersion(p_dbcAccess,
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
            p_smResult.BllWarning("El número de versión del registro del ítem (TipoInst) no coincide.\r\nOperación cancelada.","");
        }
        #endregion

        #region Metodos internos de recupero

        /// <summary>
        /// Devuelve una Lista-entidad: LETipoInsts
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LETipoInsts</returns>
        internal static LETipoInsts TinUpfl(DBConn p_dbcAccess,
                                             bool p_bOnlyActive,
                                             StatMsg p_smResult)
        {
            try {
                // Pedimos los registros de la tabla: TipoInst
                DataSet l_dsTemp= new DataSet();

                Dal.TipoInst.Up(p_dbcAccess, 
                                p_bOnlyActive,
                                ref l_dsTemp, "Temporal",
                                p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.TipoInst.MakeGridCaptions(ref l_dsTemp, "Temporal", p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LETipoInsts l_lentRet= new LETipoInsts(l_dsTemp.Tables["Temporal"]);
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
        /// Devuelve una entidad: ETipoInst
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: ETipoInst</returns>
        internal static ETipoInst TinSrch(DBConn p_dbcAccess,
                                          string p_strCod,
                                          bool p_bOnlyActive,
                                          StatMsg p_smResult)
        {
            try {
                // Pedimos el registro de la tabla: TipoInst
                DataSet l_dsTemp= new DataSet();

                Dal.TipoInst.Search(p_dbcAccess, 
                                    p_strCod,
                                    p_bOnlyActive,
                                    ref l_dsTemp, "Temporal",
                                    p_smResult);
                if (p_smResult.NOk) return null;

                // Constuimos la entidad y la devolvemos (si vino un registro)
                ETipoInst l_entRet= null;

                if (l_dsTemp.Tables["Temporal"].Rows.Count == 1)
                    l_entRet= new ETipoInst(l_dsTemp.Tables["Temporal"].Rows[0]);

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
        internal static string TinGetNK(DBConn p_dbcAccess,
                                        StatMsg p_smResult)
        {
            try {
                // Pedimos la clave máxima
                DataSet l_dsTemp= new DataSet();

                Dal.TipoInst.GetMaxKey(p_dbcAccess,
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
        /// Agrega o modifica un registro de la tabla: TipoInst
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entTipoInst">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TinSSav(DBConn p_dbcAccess,
                                     ETipoInst p_entTipoInst,
                                     StatMsg p_smResult)
        {
            try {
                // Procesamos codigo fijo
                TinSave_f(p_dbcAccess, ref p_entTipoInst, p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                TinVKey(p_dbcAccess, 
                        p_entTipoInst.Cod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entTipoInst.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El ítem (TipoInst) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    TinInsr(p_dbcAccess, p_entTipoInst, p_smResult);
                    return;
                }

                // Es un update. La clave debe existir y estar habilitada
                if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                    // Error. La clave no existe o no está habilitada
                    p_smResult.BllWarning("El ítem (TipoInst) que intenta modificar no existe en el sistema o no está habilitado.","");
                    return;
                }

                // Debe coincidir el número de version
                TinVVer(p_dbcAccess, 
                        p_entTipoInst.Cod,
                        p_entTipoInst.FxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos el registro
                TinUpdt(p_dbcAccess, p_entTipoInst, p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Agrega un registro a la tabla a partir de una entidad: ETipoInst
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entTipoInst">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TinInsr(DBConn p_dbcAccess,
                                     ETipoInst p_entTipoInst,
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                TinTInt(p_dbcAccess, p_entTipoInst, p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: TipoInst
                Dal.TipoInst.Insert(p_dbcAccess,
                                    p_entTipoInst.Cod,
                                    p_entTipoInst.Des,
                                    p_entTipoInst.Codrubro,
                                    p_entTipoInst.Mayorista,
                                    p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Actualiza un registro a la tabla a partir de una entidad: ETipoInst
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entTipoInst">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TinUpdt(DBConn p_dbcAccess,
                                     ETipoInst p_entTipoInst,
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                TinTInt(p_dbcAccess, p_entTipoInst, p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: TipoInst
                Dal.TipoInst.Update(p_dbcAccess,
                                    p_entTipoInst.Cod,
                                    p_entTipoInst.Des,
                                    p_entTipoInst.Codrubro,
                                    p_entTipoInst.Mayorista,
                                    p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra físicamente un registro de a tabla: TipoInst
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TinDrop(DBConn p_dbcAccess,
                                     string p_strCod,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            try {
                // Verificamos la clave a borrar
                TinVKey(p_dbcAccess,
                        p_strCod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (TipoInst) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                TinVVer(p_dbcAccess, 
                        p_strCod,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Borramos físicamente el registro
                Dal.TipoInst.Drop(p_dbcAccess,
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
        internal static void TinPack(DBConn p_dbcAccess,
                                     StatMsg p_smResult)
        {
            try {
                // Borramos los borrados lógicamente
                Dal.TipoInst.Pack(p_dbcAccess,
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
        /// Ejecuta el SP definido por el usuario: GetTiposInstRubro
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_strCodrubro>Código de Rubro</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades TinGetTiposInstRubro(DBConn p_dbcAccess,
                                                            string p_strCodrubro,
                                                            StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.TipoInst.GetTiposInstRubro(p_dbcAccess,
                                               p_strCodrubro,
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
        // Funciones para la Tabla: Zonas
        // Usando ClaseDal        : Zonas
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos públicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: Zonas
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEZonas</returns>
        public static LEZonas ZnsUpFull(bool p_bOnlyActive,
                                        StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                return ZnsUpfl(l_dbcAccess, p_bOnlyActive, p_smResult);
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
        /// Devuelve una entidad: EZona
        /// </summary>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EZona</returns>
        public static EZona ZnsGet(string p_strCod,
                                   bool p_bOnlyActive,
                                   StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCod= EZona.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: EZona
                return ZnsSrch(l_dbcAccess,
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

        /// <summary>
        /// Devuelve la próxima clave de la entidad
        /// </summary>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Próxima clave</returns>
        public static string ZnsNextKey(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la clave máxima
                return ZnsGetNK(l_dbcAccess,
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

        #region Metodos publicos de grabacion

        /// <summary>
        /// Agrega o modifica un registro de la tabla: Zonas
        /// </summary>
        /// <param name="p_entZona">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void ZnsSave(EZona p_entZona,
                                   StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: EZona
                ZnsSSav(l_dbcAccess, p_entZona, p_smResult);
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
        /// Habilita/Deshabilita un registro de la tabla: Zonas
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void ZnsEnabled(bool p_bEnable,
                                      string p_strCod,
                                      int p_iFxdVersion,
                                      StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCod= EZona.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                ZnsEnabled_f(l_dbcAccess,
                             p_bEnable,
                             p_strCod,
                             ref p_iFxdVersion,
                             p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                ZnsVKey(l_dbcAccess,
                        p_strCod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (Zona) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                ZnsVVer(l_dbcAccess, 
                        p_strCod,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.Zonas.Recall(l_dbcAccess,
                                     p_strCod,
                                     p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.Zonas.Delete(l_dbcAccess,
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
        /// Borra físicamento un registro de la tabla: Zonas
        /// </summary>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void ZnsRemove(string p_strCod,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCod= EZona.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                ZnsRemove_f(l_dbcAccess,
                            p_strCod,
                            p_iFxdVersion,
                            p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                ZnsDrop(l_dbcAccess,
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
        public static void ZnsPurge(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Realizamos el borrado
                ZnsPack(l_dbcAccess,
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
        /// Valida la integridad de una entidad: Zona
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entZona">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ZnsTInt(DBConn p_dbcAccess,
                                     EZona p_entZona,
                                     StatMsg p_smResult)
        {
            // ********
            // Validaciones de los campos sin conexion
            // ********

            if (p_entZona.Cod.Trim() == "") {
                // El campo [Código] no puede ser vacío
                p_smResult.BllWarning("El dato [Código] no puede ser vacío","");
                return;
            }

            if (p_entZona.Nombre.Trim() == "") {
                // El campo [Nombre de la zona] no puede ser vacío
                p_smResult.BllWarning("El dato [Nombre de la zona] no puede ser vacío","");
                return;
            }

            // ********
            // Validaciones de los campos con conexion
            // ********

            // Llamamos a la funcion fija del usuario
            ZnsTInt_f(p_dbcAccess, p_entZona, p_smResult);
            if (p_smResult.NOk) return;
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: EZona
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave está deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ZnsVKey(DBConn p_dbcAccess,
                                     string p_strCod,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            Dal.Zonas.Search(p_dbcAccess,
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

        /// <summary>
        /// Verifica el número de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_iFxdVersion">Número de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ZnsVVer(DBConn p_dbcAccess,
                                     string p_strCod,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            // Verificamos el número de versión
            Dal.Zonas.ChkVersion(p_dbcAccess,
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
            p_smResult.BllWarning("El número de versión del registro del ítem (Zona) no coincide.\r\nOperación cancelada.","");
        }
        #endregion

        #region Metodos internos de recupero

        /// <summary>
        /// Devuelve una Lista-entidad: LEZonas
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEZonas</returns>
        internal static LEZonas ZnsUpfl(DBConn p_dbcAccess,
                                         bool p_bOnlyActive,
                                         StatMsg p_smResult)
        {
            try {
                // Pedimos los registros de la tabla: Zonas
                DataSet l_dsTemp= new DataSet();

                Dal.Zonas.Up(p_dbcAccess, 
                             p_bOnlyActive,
                             ref l_dsTemp, "Temporal",
                             p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.Zonas.MakeGridCaptions(ref l_dsTemp, "Temporal", p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LEZonas l_lentRet= new LEZonas(l_dsTemp.Tables["Temporal"]);
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
        /// Devuelve una entidad: EZona
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EZona</returns>
        internal static EZona ZnsSrch(DBConn p_dbcAccess,
                                      string p_strCod,
                                      bool p_bOnlyActive,
                                      StatMsg p_smResult)
        {
            try {
                // Pedimos el registro de la tabla: Zonas
                DataSet l_dsTemp= new DataSet();

                Dal.Zonas.Search(p_dbcAccess, 
                                 p_strCod,
                                 p_bOnlyActive,
                                 ref l_dsTemp, "Temporal",
                                 p_smResult);
                if (p_smResult.NOk) return null;

                // Constuimos la entidad y la devolvemos (si vino un registro)
                EZona l_entRet= null;

                if (l_dsTemp.Tables["Temporal"].Rows.Count == 1)
                    l_entRet= new EZona(l_dsTemp.Tables["Temporal"].Rows[0]);

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
        internal static string ZnsGetNK(DBConn p_dbcAccess,
                                        StatMsg p_smResult)
        {
            try {
                // Pedimos la clave máxima
                DataSet l_dsTemp= new DataSet();

                Dal.Zonas.GetMaxKey(p_dbcAccess,
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
        /// Agrega o modifica un registro de la tabla: Zonas
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entZona">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ZnsSSav(DBConn p_dbcAccess,
                                     EZona p_entZona,
                                     StatMsg p_smResult)
        {
            try {
                // Procesamos codigo fijo
                ZnsSave_f(p_dbcAccess, ref p_entZona, p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                ZnsVKey(p_dbcAccess, 
                        p_entZona.Cod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entZona.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El ítem (Zona) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    ZnsInsr(p_dbcAccess, p_entZona, p_smResult);
                    return;
                }

                // Es un update. La clave debe existir y estar habilitada
                if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                    // Error. La clave no existe o no está habilitada
                    p_smResult.BllWarning("El ítem (Zona) que intenta modificar no existe en el sistema o no está habilitado.","");
                    return;
                }

                // Debe coincidir el número de version
                ZnsVVer(p_dbcAccess, 
                        p_entZona.Cod,
                        p_entZona.FxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos el registro
                ZnsUpdt(p_dbcAccess, p_entZona, p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Agrega un registro a la tabla a partir de una entidad: EZona
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entZona">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ZnsInsr(DBConn p_dbcAccess,
                                     EZona p_entZona,
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                ZnsTInt(p_dbcAccess, p_entZona, p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: Zonas
                Dal.Zonas.Insert(p_dbcAccess,
                                 p_entZona.Cod,
                                 p_entZona.Nombre,
                                 p_entZona.Geoloc,
                                 p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Actualiza un registro a la tabla a partir de una entidad: EZona
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entZona">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ZnsUpdt(DBConn p_dbcAccess,
                                     EZona p_entZona,
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                ZnsTInt(p_dbcAccess, p_entZona, p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: Zonas
                Dal.Zonas.Update(p_dbcAccess,
                                 p_entZona.Cod,
                                 p_entZona.Nombre,
                                 p_entZona.Geoloc,
                                 p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra físicamente un registro de a tabla: Zonas
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ZnsDrop(DBConn p_dbcAccess,
                                     string p_strCod,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            try {
                // Verificamos la clave a borrar
                ZnsVKey(p_dbcAccess,
                        p_strCod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (Zona) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                ZnsVVer(p_dbcAccess, 
                        p_strCod,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Borramos físicamente el registro
                Dal.Zonas.Drop(p_dbcAccess,
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
        internal static void ZnsPack(DBConn p_dbcAccess,
                                     StatMsg p_smResult)
        {
            try {
                // Borramos los borrados lógicamente
                Dal.Zonas.Pack(p_dbcAccess,
                               p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }
        #endregion

        #region Metodos para métodos DAL definidos por el usuario
        #endregion

    }
}
