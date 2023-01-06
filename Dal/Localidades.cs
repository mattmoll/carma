#region Usings
using System;
using System.Data;
using System.Data.Common;
using TNGS.NetRoutines;
#endregion

namespace Carm.Dal
{
    //----------------------------------------------------------------------------
    //                         TNG Software DAL Generator
    //----------------------------------------------------------------------------
    // Fecha                    : 05/01/2023 22:22
    // Sistema                  : Carm
    // Clase para Administrar   : Localidades
    // Basada en la Tabla       : Localidades
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
    /// Modulo DAL de Acceso a la tabla: Localidades
    /// </summary>
    public static class Localidades
    {
        //---------------------------------------------------------------
        // Métodos públicos estáticos de la clase para realizar
        // operaciones sobre la Tabla
        //---------------------------------------------------------------

        #region Metodos de Recupero

        /// <summary>
        /// Recupera la lista completa de registros (Grilla)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_dsResult">DataSet donde devolver los datos</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Up(DBConn p_dbcAccess,
                             bool p_bOnlyActive,
                             ref DataSet p_dsResult,
                             string p_strTabla,
                             StatMsg p_smResult)
        {
            try {
                // Recuperamos todos los registros
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Carm..LOCALIDADES_UP",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@onlyactive", (p_bOnlyActive ? 1 : 0))
                                      },
                                      ref p_dsResult, p_strTabla);
            }
            catch (Exception l_expData) {
                // Error en el select de la tabla
                p_smResult.DalError(l_expData);
                return -1;
            }
        }

        /// <summary>
        /// Verifica el número de versión de un registro
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodpost">Código postal</param>
        /// <param name="p_iFxdVersion">Número de version a verificar</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void ChkVersion(DBConn p_dbcAccess,
                                      string p_strCodpost,
                                      int p_iFxdVersion,
                                      ref DataSet p_dsResult,
                                      string p_strTabla,
                                      StatMsg p_smResult)
        {
            try {
                // Verificamos el número de versión
                DBRuts.Exec_DS(p_dbcAccess,
                               "TNGS_Carm..LOCALIDADES_CHKVERSION",
                               new DbParameter[] {
                                   p_dbcAccess.MakeParam("@loc_ecd_codpost", p_strCodpost),
                                   p_dbcAccess.MakeParam("@version", p_iFxdVersion)
                               },
                               ref p_dsResult, p_strTabla);
            }
            catch (Exception l_expData) {
                // Error en el conteo
                p_smResult.DalError(l_expData);
            }
        }

        /// <summary>
        /// Busca el registro de una clave (Grilla)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodpost">Código postal</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Search(DBConn p_dbcAccess,
                                 string p_strCodpost,
                                 bool p_bOnlyActive,
                                 ref DataSet p_dsResult,
                                 string p_strTabla,
                                 StatMsg p_smResult)
        {
            try {
                // Recuperamos el registro de la clave
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Carm..LOCALIDADES_SEARCH",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@loc_ecd_codpost", p_strCodpost),
                                          p_dbcAccess.MakeParam("@onlyactive", (p_bOnlyActive ? 1 : 0))
                                      },
                                      ref p_dsResult, p_strTabla);
            }
            catch (Exception l_expData) {
                // Error en el search del registro
                p_smResult.DalError(l_expData);
                return -1;
            }
        }

        /// <summary>
        /// Busca la clave máxima de la tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void GetMaxKey(DBConn p_dbcAccess,
                                     ref DataSet p_dsResult,
                                     string p_strTabla,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            try {
                // Recuperamos la clave mas alta de la tabla
                DBRuts.Exec_DS(p_dbcAccess,
                               "TNGS_Carm..LOCALIDADES_GETMAXKEY",
                               new DbParameter[] {
                                   p_dbcAccess.MakeParam("@dummy", "X")
                               },
                               ref p_dsResult, p_strTabla);
            }
            catch (Exception l_expData) {
                // Error en el search de la clave máxima
                p_smResult.DalError(l_expData);
            }
        }
        #endregion

        #region Metodos de Actualizacion

        /// <summary>
        /// Inserta un registro en la tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodpost">Código postal</param>
        /// <param name="p_strNombre">Nombre</param>
        /// <param name="p_strCodzona">Zona</param>
        /// <param name="p_strPartido">Partido</param>
        /// <param name="p_strProvincia">Provincia</param>
        /// <param name="p_strNomgoogle">Nombre en google</param>
        /// <param name="p_strDirecta">Busqueda Directa</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Insert(DBConn p_dbcAccess,
                                 string p_strCodpost,
                                 string p_strNombre,
                                 string p_strCodzona,
                                 string p_strPartido,
                                 string p_strProvincia,
                                 string p_strNomgoogle,
                                 string p_strDirecta,
                                 StatMsg p_smResult)
        {
            try {
                // Insertamos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..LOCALIDADES_INSERT",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@loc_ecd_codpost", p_strCodpost),
                                       p_dbcAccess.MakeParam("@loc_ede_nombre", p_strNombre),
                                       p_dbcAccess.MakeParam("@loc_rcd_codzona", p_strCodzona),
                                       p_dbcAccess.MakeParam("@loc_ede_partido", p_strPartido),
                                       p_dbcAccess.MakeParam("@loc_des_provincia", p_strProvincia),
                                       p_dbcAccess.MakeParam("@loc_ede_nomgoogle", p_strNomgoogle),
                                       p_dbcAccess.MakeParam("@loc_cd1_directa", p_strDirecta),
                                       p_dbcAccess.MakeParam("@usuario", DBConn.Usuario)
                                   }
                                  );
            }
            catch (Exception l_expData) {
                // Error en el insert del registro
                p_smResult.DalError(l_expData);
                return -1;
            }
        }

        /// <summary>
        /// Actualiza un registro de la tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodpost">Código postal</param>
        /// <param name="p_strNombre">Nombre</param>
        /// <param name="p_strCodzona">Zona</param>
        /// <param name="p_strPartido">Partido</param>
        /// <param name="p_strProvincia">Provincia</param>
        /// <param name="p_strNomgoogle">Nombre en google</param>
        /// <param name="p_strDirecta">Busqueda Directa</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Update(DBConn p_dbcAccess,
                                 string p_strCodpost,
                                 string p_strNombre,
                                 string p_strCodzona,
                                 string p_strPartido,
                                 string p_strProvincia,
                                 string p_strNomgoogle,
                                 string p_strDirecta,
                                 StatMsg p_smResult)
        {
            try {
                // Modificamos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..LOCALIDADES_UPDATE",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@loc_ecd_codpost", p_strCodpost),
                                       p_dbcAccess.MakeParam("@loc_ede_nombre", p_strNombre),
                                       p_dbcAccess.MakeParam("@loc_rcd_codzona", p_strCodzona),
                                       p_dbcAccess.MakeParam("@loc_ede_partido", p_strPartido),
                                       p_dbcAccess.MakeParam("@loc_des_provincia", p_strProvincia),
                                       p_dbcAccess.MakeParam("@loc_ede_nomgoogle", p_strNomgoogle),
                                       p_dbcAccess.MakeParam("@loc_cd1_directa", p_strDirecta),
                                       p_dbcAccess.MakeParam("@usuario", DBConn.Usuario)
                                   }
                                  );
            }
            catch (Exception l_expData) {
                // Error en el update del registro
                p_smResult.DalError(l_expData);
                return -1;
            }
        }

        /// <summary>
        /// Borra logicamente un registro
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodpost">Código postal</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Delete(DBConn p_dbcAccess,
                                 string p_strCodpost,
                                 StatMsg p_smResult)
        {
            try {
                // Borramos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..LOCALIDADES_DELETE",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@loc_ecd_codpost", p_strCodpost),
                                       p_dbcAccess.MakeParam("@usuario", DBConn.Usuario)
                                   }
                                  );
            }
            catch (Exception l_expData) {
                // Error en el update del registro
                p_smResult.DalError(l_expData);
                return -1;
            }
        }

        /// <summary>
        /// Recupera un registro
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodpost">Código postal</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Recall(DBConn p_dbcAccess,
                                 string p_strCodpost,
                                 StatMsg p_smResult)
        {
            try {
                // Borramos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..LOCALIDADES_RECALL",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@loc_ecd_codpost", p_strCodpost),
                                       p_dbcAccess.MakeParam("@usuario", DBConn.Usuario)
                                   }
                                  );
            }
            catch (Exception l_expData) {
                // Error en el update del registro
                p_smResult.DalError(l_expData);
                return -1;
            }
        }

        /// <summary>
        /// Borra fisicamente un registro
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodpost">Código postal</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Drop(DBConn p_dbcAccess,
                               string p_strCodpost,
                               StatMsg p_smResult)
        {
            try {
                // Borramos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..LOCALIDADES_DROP",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@loc_ecd_codpost", p_strCodpost),
                                       p_dbcAccess.MakeParam("@usuario", DBConn.Usuario)
                                   }
                                  );
            }
            catch (Exception l_expData) {
                // Error en el delete del registro
                p_smResult.DalError(l_expData);
                return -1;
            }
        }

        /// <summary>
        /// Borra fisicamente los registros borrados logicamente
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Pack(DBConn p_dbcAccess,
                               StatMsg p_smResult)
        {
            try {
                // Borramos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..LOCALIDADES_PACK",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@usuario", DBConn.Usuario)
                                   }
                                  );
            }
            catch (Exception l_expData) {
                // Error en el delete del registro
                p_smResult.DalError(l_expData);
                return -1;
            }
        }
        #endregion

        #region Metodos del Usuario

        /// <summary>
        /// Método Fijo: Find
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= "p_strLocalidad">Nombre de la localidad</param>
        /// <param name= "p_strProvinciad">Provincia desde</param>
        /// <param name= "p_strProvinciah">Provincia hasta</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Find(DBConn p_dbcAccess,
                               string p_strLocalidad,
                               string p_strProvinciad,
                               string p_strProvinciah,
                               ref DataSet p_dsResult,
                               string p_strTabla,
                               StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Carm..LOCALIDADES_FIND",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@localidad", p_strLocalidad),
                                          p_dbcAccess.MakeParam("@provinciad", p_strProvinciad),
                                          p_dbcAccess.MakeParam("@provinciah", p_strProvinciah),
                                          p_dbcAccess.MakeParam("@usuario", DBConn.Usuario)
                                      },
                                      ref p_dsResult, p_strTabla);
            }
            catch (Exception l_expData) {
                // Error en el método fijo
                p_smResult.DalError(l_expData);
                return -1;
            }
        }

        /// <summary>
        /// Método Fijo: GetCodPostal
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= "p_strLocalidad">Nombre de la Localidad a Buscar</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int GetCodPostal(DBConn p_dbcAccess,
                                       string p_strLocalidad,
                                       ref DataSet p_dsResult,
                                       string p_strTabla,
                                       StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Carm..LOCALIDADES_GETCODPOSTAL",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@localidad", p_strLocalidad),
                                          p_dbcAccess.MakeParam("@usuario", DBConn.Usuario)
                                      },
                                      ref p_dsResult, p_strTabla);
            }
            catch (Exception l_expData) {
                // Error en el método fijo
                p_smResult.DalError(l_expData);
                return -1;
            }
        }

        /// <summary>
        /// Método Fijo: GetDirectaWithLike
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= "p_strLocabuscar">Letras de Loc a Buscar</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int GetDirectaWithLike(DBConn p_dbcAccess,
                                             string p_strLocabuscar,
                                             ref DataSet p_dsResult,
                                             string p_strTabla,
                                             StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Carm..LOCALIDADES_GETDIRECTAWITHLIKE",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@locabuscar", p_strLocabuscar),
                                          p_dbcAccess.MakeParam("@usuario", DBConn.Usuario)
                                      },
                                      ref p_dsResult, p_strTabla);
            }
            catch (Exception l_expData) {
                // Error en el método fijo
                p_smResult.DalError(l_expData);
                return -1;
            }
        }

        /// <summary>
        /// Método Fijo: GetLocalidadesZona
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= "p_strCodzona">Código de zona</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int GetLocalidadesZona(DBConn p_dbcAccess,
                                             string p_strCodzona,
                                             ref DataSet p_dsResult,
                                             string p_strTabla,
                                             StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Carm..LOCALIDADES_GETLOCALIDADESZONA",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@codzona", p_strCodzona),
                                          p_dbcAccess.MakeParam("@usuario", DBConn.Usuario)
                                      },
                                      ref p_dsResult, p_strTabla);
            }
            catch (Exception l_expData) {
                // Error en el método fijo
                p_smResult.DalError(l_expData);
                return -1;
            }
        }

        /// <summary>
        /// Método Fijo: GetPartidos
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= "p_strProvincia">Nombre de la provincia</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int GetPartidos(DBConn p_dbcAccess,
                                      string p_strProvincia,
                                      ref DataSet p_dsResult,
                                      string p_strTabla,
                                      StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Carm..LOCALIDADES_GETPARTIDOS",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@provincia", p_strProvincia),
                                          p_dbcAccess.MakeParam("@usuario", DBConn.Usuario)
                                      },
                                      ref p_dsResult, p_strTabla);
            }
            catch (Exception l_expData) {
                // Error en el método fijo
                p_smResult.DalError(l_expData);
                return -1;
            }
        }

        /// <summary>
        /// Método Fijo: GetProvincias
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int GetProvincias(DBConn p_dbcAccess,
                                        ref DataSet p_dsResult,
                                        string p_strTabla,
                                        StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Carm..LOCALIDADES_GETPROVINCIAS",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@usuario", DBConn.Usuario)
                                      },
                                      ref p_dsResult, p_strTabla);
            }
            catch (Exception l_expData) {
                // Error en el método fijo
                p_smResult.DalError(l_expData);
                return -1;
            }
        }

        /// <summary>
        /// Método Fijo: UpFullByPartido
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= "p_strProvincia">Provincia a buscar</param>
        /// <param name= "p_strPartido">Partido a buscar</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int UpFullByPartido(DBConn p_dbcAccess,
                                          string p_strProvincia,
                                          string p_strPartido,
                                          ref DataSet p_dsResult,
                                          string p_strTabla,
                                          StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Carm..LOCALIDADES_UPFULLBYPARTIDO",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@provincia", p_strProvincia),
                                          p_dbcAccess.MakeParam("@partido", p_strPartido),
                                          p_dbcAccess.MakeParam("@usuario", DBConn.Usuario)
                                      },
                                      ref p_dsResult, p_strTabla);
            }
            catch (Exception l_expData) {
                // Error en el método fijo
                p_smResult.DalError(l_expData);
                return -1;
            }
        }
        #endregion

        #region Grillas Definidas

        /// <summary>
        /// Genera los Captions para la grilla default
        /// </summary>
        /// <param name="p_dtResult">Tabla donde completar los captions</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void MakeGridCaptions(ref DataTable p_dtResult,
                                            StatMsg p_smResult)
        {
            try {
                // Quitamos los captions existentes
                DBRuts.ClearDTCaptions(ref p_dtResult);

                // Fijamos los nuevos captions de la grilla
                p_dtResult.Columns["loc_des_zona"].Caption= "V1ZonaCN1";
                p_dtResult.Columns["loc_ecd_codpost"].Caption= "V1Código postalCN1";
                p_dtResult.Columns["loc_rcd_codzona"].Caption= "V1ZonaCN1";
                p_dtResult.Columns["loc_cd1_directa"].Caption= "V1Busqueda DirectaCN1";
                p_dtResult.Columns["loc_ede_nombre"].Caption= "V1NombreCN1";
                p_dtResult.Columns["loc_ede_nomgoogle"].Caption= "V1Nombre en googleCN1";
                p_dtResult.Columns["loc_ede_partido"].Caption= "V1PartidoCN1";
                p_dtResult.Columns["loc_des_provincia"].Caption= "V1ProvinciaCN1";
                p_dtResult.Columns["deleted"].Caption= "V1Borrado2N2";
            }
            catch (Exception l_expData) {
                // Error en el armado de la grilla
                p_smResult.DalError(l_expData);
            }
        }

        /// <summary>
        /// Genera los Captions para la grilla default
        /// </summary>
        /// <param name="p_dsResult">DataSet donde completar los captions</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void MakeGridCaptions(ref DataSet p_dsResult,
                                            string p_strTabla,
                                            StatMsg p_smResult)
        {
            // Llamamos al método base
            DataTable l_dtTemp= p_dsResult.Tables[p_strTabla];
            MakeGridCaptions(ref l_dtTemp, p_smResult);
        }

        /// <summary>
        /// Genera los Captions para la grilla default
        /// </summary>
        /// <param name="p_lentResult">ListaEntidades donde completar los captions</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void MakeGridCaptions(ref ListaEntidades p_lentResult,
                                            StatMsg p_smResult)
        {
            // Llamamos al método base
            DataTable l_dtTemp= p_lentResult.InternalData.Table;
            MakeGridCaptions(ref l_dtTemp, p_smResult);
        }
        #endregion
    }
}
