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
    // Fecha                    : 19/07/2021 08:58
    // Sistema                  : Carm
    // Clase para Administrar   : Log Clientes
    // Basada en la Tabla       : LogClientes
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
    /// Modulo DAL de Acceso a la tabla: LogClientes
    /// </summary>
    public static class LogClientes
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
                                      "TNGS_Carm..LOGCLIENTES_UP",
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
        /// <param name="p_iNro">Numero</param>
        /// <param name="p_iFxdVersion">Número de version a verificar</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void ChkVersion(DBConn p_dbcAccess,
                                      int p_iNro,
                                      int p_iFxdVersion,
                                      ref DataSet p_dsResult,
                                      string p_strTabla,
                                      StatMsg p_smResult)
        {
            try {
                // Verificamos el número de versión
                DBRuts.Exec_DS(p_dbcAccess,
                               "TNGS_Carm..LOGCLIENTES_CHKVERSION",
                               new DbParameter[] {
                                   p_dbcAccess.MakeParam("@lgc_nro_nro", p_iNro),
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
        /// <param name="p_iNro">Numero</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Search(DBConn p_dbcAccess,
                                 int p_iNro,
                                 bool p_bOnlyActive,
                                 ref DataSet p_dsResult,
                                 string p_strTabla,
                                 StatMsg p_smResult)
        {
            try {
                // Recuperamos el registro de la clave
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Carm..LOGCLIENTES_SEARCH",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@lgc_nro_nro", p_iNro),
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
        #endregion

        #region Metodos de Actualizacion

        /// <summary>
        /// Inserta un registro en la tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNro">Numero</param>
        /// <param name="p_iNrocliente">Número Cliente</param>
        /// <param name="p_iNroavalon">Número Avalon</param>
        /// <param name="p_strRsocial">Razon Social</param>
        /// <param name="p_strNomfantasia">Nombre Fantasia</param>
        /// <param name="p_strAccion">Acción</param>
        /// <param name="p_strUsuario">Usuario</param>
        /// <param name="p_dtFecha">Fecha</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Insert(DBConn p_dbcAccess,
                                 int p_iNro,
                                 int p_iNrocliente,
                                 int p_iNroavalon,
                                 string p_strRsocial,
                                 string p_strNomfantasia,
                                 string p_strAccion,
                                 string p_strUsuario,
                                 DateTime p_dtFecha,
                                 StatMsg p_smResult)
        {
            try {
                // Insertamos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..LOGCLIENTES_INSERT",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@lgc_nro_nro", p_iNro),
                                       p_dbcAccess.MakeParam("@lgc_nro_nrocliente", p_iNrocliente),
                                       p_dbcAccess.MakeParam("@lgc_nro_nroavalon", p_iNroavalon),
                                       p_dbcAccess.MakeParam("@lgc_ede_rsocial", p_strRsocial),
                                       p_dbcAccess.MakeParam("@lgc_des_nomfantasia", p_strNomfantasia),
                                       p_dbcAccess.MakeParam("@lgc_des_accion", p_strAccion),
                                       p_dbcAccess.MakeParam("@lgc_nom_usuario", p_strUsuario),
                                       p_dbcAccess.MakeParam("@lgc_fyh_fecha", p_dtFecha),
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
        /// <param name="p_iNro">Numero</param>
        /// <param name="p_iNrocliente">Número Cliente</param>
        /// <param name="p_iNroavalon">Número Avalon</param>
        /// <param name="p_strRsocial">Razon Social</param>
        /// <param name="p_strNomfantasia">Nombre Fantasia</param>
        /// <param name="p_strAccion">Acción</param>
        /// <param name="p_strUsuario">Usuario</param>
        /// <param name="p_dtFecha">Fecha</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Update(DBConn p_dbcAccess,
                                 int p_iNro,
                                 int p_iNrocliente,
                                 int p_iNroavalon,
                                 string p_strRsocial,
                                 string p_strNomfantasia,
                                 string p_strAccion,
                                 string p_strUsuario,
                                 DateTime p_dtFecha,
                                 StatMsg p_smResult)
        {
            try {
                // Modificamos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..LOGCLIENTES_UPDATE",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@lgc_nro_nro", p_iNro),
                                       p_dbcAccess.MakeParam("@lgc_nro_nrocliente", p_iNrocliente),
                                       p_dbcAccess.MakeParam("@lgc_nro_nroavalon", p_iNroavalon),
                                       p_dbcAccess.MakeParam("@lgc_ede_rsocial", p_strRsocial),
                                       p_dbcAccess.MakeParam("@lgc_des_nomfantasia", p_strNomfantasia),
                                       p_dbcAccess.MakeParam("@lgc_des_accion", p_strAccion),
                                       p_dbcAccess.MakeParam("@lgc_nom_usuario", p_strUsuario),
                                       p_dbcAccess.MakeParam("@lgc_fyh_fecha", p_dtFecha),
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
        /// <param name="p_iNro">Numero</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Delete(DBConn p_dbcAccess,
                                 int p_iNro,
                                 StatMsg p_smResult)
        {
            try {
                // Borramos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..LOGCLIENTES_DELETE",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@lgc_nro_nro", p_iNro),
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
        /// <param name="p_iNro">Numero</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Recall(DBConn p_dbcAccess,
                                 int p_iNro,
                                 StatMsg p_smResult)
        {
            try {
                // Borramos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..LOGCLIENTES_RECALL",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@lgc_nro_nro", p_iNro),
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
        /// <param name="p_iNro">Numero</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Drop(DBConn p_dbcAccess,
                               int p_iNro,
                               StatMsg p_smResult)
        {
            try {
                // Borramos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..LOGCLIENTES_DROP",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@lgc_nro_nro", p_iNro),
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
                                   "TNGS_Carm..LOGCLIENTES_PACK",
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
                p_dtResult.Columns["lgc_des_accion"].Caption= "V1AcciónCN1";
                p_dtResult.Columns["lgc_fyh_fecha"].Caption= "V1FechaDN1";
                p_dtResult.Columns["lgc_des_nomfantasia"].Caption= "V1Nombre FantasiaCN1";
                p_dtResult.Columns["lgc_nro_nroavalon"].Caption= "V1Número AvalonNN1";
                p_dtResult.Columns["lgc_nro_nrocliente"].Caption= "V1Número ClienteNN1";
                p_dtResult.Columns["lgc_ede_rsocial"].Caption= "V1Razon SocialCN1";
                p_dtResult.Columns["lgc_nom_usuario"].Caption= "V1UsuarioCN1";
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
