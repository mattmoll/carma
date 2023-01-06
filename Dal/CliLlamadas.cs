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
    // Clase para Administrar   : Llamadas de los Clientes
    // Basada en la Tabla       : CliLlamadas
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
    /// Modulo DAL de Acceso a la tabla: CliLlamadas
    /// </summary>
    public static class CliLlamadas
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
                                      "TNGS_Carm..CLILLAMADAS_UP",
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
        /// <param name="p_iNumcliente">Número de cliente</param>
        /// <param name="p_iNumllamada">Número de llamada</param>
        /// <param name="p_iFxdVersion">Número de version a verificar</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void ChkVersion(DBConn p_dbcAccess,
                                      int p_iNumcliente,
                                      int p_iNumllamada,
                                      int p_iFxdVersion,
                                      ref DataSet p_dsResult,
                                      string p_strTabla,
                                      StatMsg p_smResult)
        {
            try {
                // Verificamos el número de versión
                DBRuts.Exec_DS(p_dbcAccess,
                               "TNGS_Carm..CLILLAMADAS_CHKVERSION",
                               new DbParameter[] {
                                   p_dbcAccess.MakeParam("@cll_nro_numcliente", p_iNumcliente),
                                   p_dbcAccess.MakeParam("@cll_nro_numllamada", p_iNumllamada),
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
        /// <param name="p_iNumcliente">Número de cliente</param>
        /// <param name="p_iNumllamada">Número de llamada</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Search(DBConn p_dbcAccess,
                                 int p_iNumcliente,
                                 int p_iNumllamada,
                                 bool p_bOnlyActive,
                                 ref DataSet p_dsResult,
                                 string p_strTabla,
                                 StatMsg p_smResult)
        {
            try {
                // Recuperamos el registro de la clave
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Carm..CLILLAMADAS_SEARCH",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@cll_nro_numcliente", p_iNumcliente),
                                          p_dbcAccess.MakeParam("@cll_nro_numllamada", p_iNumllamada),
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
        /// Busca los registros de una clave foranea (Grilla)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Número de cliente</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int FSearch(DBConn p_dbcAccess,
                                  int p_iNumcliente,
                                  bool p_bOnlyActive,
                                  ref DataSet p_dsResult,
                                  string p_strTabla,
                                  StatMsg p_smResult)
        {
            try {
                // Recuperamos los registro de la clave foranea
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Carm..CLILLAMADAS_FSEARCH",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@cll_nro_numcliente", p_iNumcliente),
                                          p_dbcAccess.MakeParam("@onlyactive", (p_bOnlyActive ? 1 : 0))
                                      },
                                      ref p_dsResult, p_strTabla);
            }
            catch (Exception l_expData) {
                // Error en el search de los registros
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
        /// <param name="p_iNumcliente">Número de cliente</param>
        /// <param name="p_iNumllamada">Número de llamada</param>
        /// <param name="p_strCodmotivo">Código de motivo</param>
        /// <param name="p_dtFrealizada">Fecha Realizada</param>
        /// <param name="p_strResultado">Resultado</param>
        /// <param name="p_strCodusuario">Código del usuario</param>
        /// <param name="p_strBaja">Produjo Baja</param>
        /// <param name="p_iNumcontacto">Número de contacto</param>
        /// <param name="p_strObsprogramada">Observación</param>
        /// <param name="p_dcAbonoanterior">Abono Anterior</param>
        /// <param name="p_dcAbonorecuperado">Abono Recuperador</param>
        /// <param name="p_strProgramador">Usuario Programador</param>
        /// <param name="p_dcAjuste">Ajuste</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Insert(DBConn p_dbcAccess,
                                 int p_iNumcliente,
                                 int p_iNumllamada,
                                 string p_strCodmotivo,
                                 DateTime p_dtFrealizada,
                                 string p_strResultado,
                                 string p_strCodusuario,
                                 string p_strBaja,
                                 int p_iNumcontacto,
                                 string p_strObsprogramada,
                                 decimal p_dcAbonoanterior,
                                 decimal p_dcAbonorecuperado,
                                 string p_strProgramador,
                                 decimal p_dcAjuste,
                                 StatMsg p_smResult)
        {
            try {
                // Insertamos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..CLILLAMADAS_INSERT",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@cll_nro_numcliente", p_iNumcliente),
                                       p_dbcAccess.MakeParam("@cll_nro_numllamada", p_iNumllamada),
                                       p_dbcAccess.MakeParam("@cll_cod_codmotivo", p_strCodmotivo),
                                       p_dbcAccess.MakeParam("@cll_fyh_frealizada", p_dtFrealizada),
                                       p_dbcAccess.MakeParam("@cll_txt_resultado", p_strResultado),
                                       p_dbcAccess.MakeParam("@cll_nom_codusuario", p_strCodusuario),
                                       p_dbcAccess.MakeParam("@cll_cd1_baja", p_strBaja),
                                       p_dbcAccess.MakeParam("@cll_nro_numcontacto", p_iNumcontacto),
                                       p_dbcAccess.MakeParam("@cll_txt_obsprogramada", p_strObsprogramada),
                                       p_dbcAccess.MakeParam("@cll_imp_abonoanterior", p_dcAbonoanterior),
                                       p_dbcAccess.MakeParam("@cll_imp_abonorecuperado", p_dcAbonorecuperado),
                                       p_dbcAccess.MakeParam("@cll_nom_programador", p_strProgramador),
                                       p_dbcAccess.MakeParam("@cll_imp_ajuste", p_dcAjuste),
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
        /// <param name="p_iNumcliente">Número de cliente</param>
        /// <param name="p_iNumllamada">Número de llamada</param>
        /// <param name="p_strCodmotivo">Código de motivo</param>
        /// <param name="p_dtFrealizada">Fecha Realizada</param>
        /// <param name="p_strResultado">Resultado</param>
        /// <param name="p_strCodusuario">Código del usuario</param>
        /// <param name="p_strBaja">Produjo Baja</param>
        /// <param name="p_iNumcontacto">Número de contacto</param>
        /// <param name="p_strObsprogramada">Observación</param>
        /// <param name="p_dcAbonoanterior">Abono Anterior</param>
        /// <param name="p_dcAbonorecuperado">Abono Recuperador</param>
        /// <param name="p_strProgramador">Usuario Programador</param>
        /// <param name="p_dcAjuste">Ajuste</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Update(DBConn p_dbcAccess,
                                 int p_iNumcliente,
                                 int p_iNumllamada,
                                 string p_strCodmotivo,
                                 DateTime p_dtFrealizada,
                                 string p_strResultado,
                                 string p_strCodusuario,
                                 string p_strBaja,
                                 int p_iNumcontacto,
                                 string p_strObsprogramada,
                                 decimal p_dcAbonoanterior,
                                 decimal p_dcAbonorecuperado,
                                 string p_strProgramador,
                                 decimal p_dcAjuste,
                                 StatMsg p_smResult)
        {
            try {
                // Modificamos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..CLILLAMADAS_UPDATE",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@cll_nro_numcliente", p_iNumcliente),
                                       p_dbcAccess.MakeParam("@cll_nro_numllamada", p_iNumllamada),
                                       p_dbcAccess.MakeParam("@cll_cod_codmotivo", p_strCodmotivo),
                                       p_dbcAccess.MakeParam("@cll_fyh_frealizada", p_dtFrealizada),
                                       p_dbcAccess.MakeParam("@cll_txt_resultado", p_strResultado),
                                       p_dbcAccess.MakeParam("@cll_nom_codusuario", p_strCodusuario),
                                       p_dbcAccess.MakeParam("@cll_cd1_baja", p_strBaja),
                                       p_dbcAccess.MakeParam("@cll_nro_numcontacto", p_iNumcontacto),
                                       p_dbcAccess.MakeParam("@cll_txt_obsprogramada", p_strObsprogramada),
                                       p_dbcAccess.MakeParam("@cll_imp_abonoanterior", p_dcAbonoanterior),
                                       p_dbcAccess.MakeParam("@cll_imp_abonorecuperado", p_dcAbonorecuperado),
                                       p_dbcAccess.MakeParam("@cll_nom_programador", p_strProgramador),
                                       p_dbcAccess.MakeParam("@cll_imp_ajuste", p_dcAjuste),
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
        /// <param name="p_iNumcliente">Número de cliente</param>
        /// <param name="p_iNumllamada">Número de llamada</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Delete(DBConn p_dbcAccess,
                                 int p_iNumcliente,
                                 int p_iNumllamada,
                                 StatMsg p_smResult)
        {
            try {
                // Borramos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..CLILLAMADAS_DELETE",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@cll_nro_numcliente", p_iNumcliente),
                                       p_dbcAccess.MakeParam("@cll_nro_numllamada", p_iNumllamada),
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
        /// Borra logicamente los registros de una clave foranea
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Número de cliente</param>
        /// <param name="p_dtInstante">Instante del borrado</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int FDelete(DBConn p_dbcAccess,
                                  int p_iNumcliente,
                                  DateTime p_dtInstante,
                                  StatMsg p_smResult)
        {
            try {
                // Borramos los registro de la clave foranea
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..CLILLAMADAS_FDELETE",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@cll_nro_numcliente", p_iNumcliente),
                                       p_dbcAccess.MakeParam("@instante", p_dtInstante),
                                       p_dbcAccess.MakeParam("@usuario", DBConn.Usuario)
                                   }
                                  );
            }
            catch (Exception l_expData) {
                // Error en el update de los registros
                p_smResult.DalError(l_expData);
                return -1;
            }
        }

        /// <summary>
        /// Recupera un registro
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Número de cliente</param>
        /// <param name="p_iNumllamada">Número de llamada</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Recall(DBConn p_dbcAccess,
                                 int p_iNumcliente,
                                 int p_iNumllamada,
                                 StatMsg p_smResult)
        {
            try {
                // Borramos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..CLILLAMADAS_RECALL",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@cll_nro_numcliente", p_iNumcliente),
                                       p_dbcAccess.MakeParam("@cll_nro_numllamada", p_iNumllamada),
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
        /// Recupera logicamente los registros de una clave foranea
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Número de cliente</param>
        /// <param name="p_dtInstante">Instante del borrado</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int FRecall(DBConn p_dbcAccess,
                                  int p_iNumcliente,
                                  DateTime p_dtInstante,
                                  StatMsg p_smResult)
        {
            try {
                // Borramos los registro de la clave foranea
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..CLILLAMADAS_FRECALL",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@cll_nro_numcliente", p_iNumcliente),
                                       p_dbcAccess.MakeParam("@instante", p_dtInstante),
                                       p_dbcAccess.MakeParam("@usuario", DBConn.Usuario)
                                   }
                                  );
            }
            catch (Exception l_expData) {
                // Error en el update de los registros
                p_smResult.DalError(l_expData);
                return -1;
            }
        }

        /// <summary>
        /// Borra fisicamente un registro
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Número de cliente</param>
        /// <param name="p_iNumllamada">Número de llamada</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Drop(DBConn p_dbcAccess,
                               int p_iNumcliente,
                               int p_iNumllamada,
                               StatMsg p_smResult)
        {
            try {
                // Borramos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..CLILLAMADAS_DROP",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@cll_nro_numcliente", p_iNumcliente),
                                       p_dbcAccess.MakeParam("@cll_nro_numllamada", p_iNumllamada),
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
        /// Borra fisicamente los registros de una clave foranea
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Número de cliente</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int FDrop(DBConn p_dbcAccess,
                                int p_iNumcliente,
                                StatMsg p_smResult)
        {
            try {
                // Borramos los registro de la clave foranea
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..CLILLAMADAS_FDROP",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@cll_nro_numcliente", p_iNumcliente),
                                       p_dbcAccess.MakeParam("@usuario", DBConn.Usuario)
                                   }
                                  );
            }
            catch (Exception l_expData) {
                // Error en el delete de los registros
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
                                   "TNGS_Carm..CLILLAMADAS_PACK",
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

        /// <summary>
        /// Borra fisicamente los registros borrado lógicamente de una clave foranea
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Número de cliente</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int FPack(DBConn p_dbcAccess,
                                int p_iNumcliente,
                                StatMsg p_smResult)
        {
            try {
                // Borramos los registro de la clave foranea
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..CLILLAMADAS_FPACK",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@cll_nro_numcliente", p_iNumcliente),
                                       p_dbcAccess.MakeParam("@usuario", DBConn.Usuario)
                                   }
                                  );
            }
            catch (Exception l_expData) {
                // Error en el delete de los registros
                p_smResult.DalError(l_expData);
                return -1;
            }
        }
        #endregion

        #region Metodos del Usuario

        /// <summary>
        /// Método Fijo: BorraPorCliente
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= "p_iNrocliente">Numero del cliente a borrar las llamadas</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int BorraPorCliente(DBConn p_dbcAccess,
                                          int p_iNrocliente,
                                          StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..CLILLAMADAS_BORRAPORCLIENTE",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@nrocliente", p_iNrocliente),
                                       p_dbcAccess.MakeParam("@usuario", DBConn.Usuario)
                                   }
                                  );
            }
            catch (Exception l_expData) {
                // Error en el método fijo
                p_smResult.DalError(l_expData);
                return -1;
            }
        }

        /// <summary>
        /// Método Fijo: GetLlamadProgVend
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= "p_strCodusuario">Nombre codigo usuario</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int GetLlamadProgVend(DBConn p_dbcAccess,
                                            string p_strCodusuario,
                                            ref DataSet p_dsResult,
                                            string p_strTabla,
                                            StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Carm..CLILLAMADAS_GETLLAMADPROGVEND",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@codusuario", p_strCodusuario),
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
        /// Método Fijo: GetProgramadas
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= "p_strCodusuario">Nombre codigo usuario</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int GetProgramadas(DBConn p_dbcAccess,
                                         string p_strCodusuario,
                                         ref DataSet p_dsResult,
                                         string p_strTabla,
                                         StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Carm..CLILLAMADAS_GETPROGRAMADAS",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@codusuario", p_strCodusuario),
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
        /// Método Fijo: ZBajasDetalle
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= "p_dtFechaini">Fecha Inicial</param>
        /// <param name= "p_dtFechafin">Fecha Fin</param>
        /// <param name= "p_strCodinimarca">Codigo Inicial Marca</param>
        /// <param name= "p_strCodfinmarca">Codigo Fin Marca</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int ZBajasDetalle(DBConn p_dbcAccess,
                                        DateTime p_dtFechaini,
                                        DateTime p_dtFechafin,
                                        string p_strCodinimarca,
                                        string p_strCodfinmarca,
                                        ref DataSet p_dsResult,
                                        string p_strTabla,
                                        StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Carm..CLILLAMADAS_ZBAJASDETALLE",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParamF("@fechaini", p_dtFechaini),
                                          p_dbcAccess.MakeParamF("@fechafin", p_dtFechafin),
                                          p_dbcAccess.MakeParam("@codinimarca", p_strCodinimarca),
                                          p_dbcAccess.MakeParam("@codfinmarca", p_strCodfinmarca),
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
        /// Método Fijo: ZBajasGral
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= "p_dtFechaini">Fecha Inicial</param>
        /// <param name= "p_dtFechafin">Fecha Fin</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int ZBajasGral(DBConn p_dbcAccess,
                                     DateTime p_dtFechaini,
                                     DateTime p_dtFechafin,
                                     ref DataSet p_dsResult,
                                     string p_strTabla,
                                     StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Carm..CLILLAMADAS_ZBAJASGRAL",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParamF("@fechaini", p_dtFechaini),
                                          p_dbcAccess.MakeParamF("@fechafin", p_dtFechafin),
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
        /// Método Fijo: ZReajustesXClieXAnio
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= "p_iNroavalon">Numero de Avalon</param>
        /// <param name= "p_iAnio">Anio a obtener historico</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int ZReajustesXClieXAnio(DBConn p_dbcAccess,
                                               int p_iNroavalon,
                                               int p_iAnio,
                                               ref DataSet p_dsResult,
                                               string p_strTabla,
                                               StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Carm..CLILLAMADAS_ZREAJUSTESXCLIEXANIO",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@nroavalon", p_iNroavalon),
                                          p_dbcAccess.MakeParam("@anio", p_iAnio),
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
        /// Método Fijo: ZReajustesXMes
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= "p_iAnio">Anio</param>
        /// <param name= "p_iMes">Mes</param>
        /// <param name= "p_strInicodmarca">Inicio Codigo Marca</param>
        /// <param name= "p_strEndcodmarca">End Codigo Marca</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int ZReajustesXMes(DBConn p_dbcAccess,
                                         int p_iAnio,
                                         int p_iMes,
                                         string p_strInicodmarca,
                                         string p_strEndcodmarca,
                                         ref DataSet p_dsResult,
                                         string p_strTabla,
                                         StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Carm..CLILLAMADAS_ZREAJUSTESXMES",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@anio", p_iAnio),
                                          p_dbcAccess.MakeParam("@mes", p_iMes),
                                          p_dbcAccess.MakeParam("@inicodmarca", p_strInicodmarca),
                                          p_dbcAccess.MakeParam("@endcodmarca", p_strEndcodmarca),
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
        /// Método Fijo: ZReclamosDetalle
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= "p_dtFechaini">Fecha Inicial</param>
        /// <param name= "p_dtFechafin">Fecha Fin</param>
        /// <param name= "p_strCodmarcaini">Codigo Marca Inicial</param>
        /// <param name= "p_strCodmarcafin">Codigo Marca Fin</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int ZReclamosDetalle(DBConn p_dbcAccess,
                                           DateTime p_dtFechaini,
                                           DateTime p_dtFechafin,
                                           string p_strCodmarcaini,
                                           string p_strCodmarcafin,
                                           ref DataSet p_dsResult,
                                           string p_strTabla,
                                           StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Carm..CLILLAMADAS_ZRECLAMOSDETALLE",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParamF("@fechaini", p_dtFechaini),
                                          p_dbcAccess.MakeParamF("@fechafin", p_dtFechafin),
                                          p_dbcAccess.MakeParam("@codmarcaini", p_strCodmarcaini),
                                          p_dbcAccess.MakeParam("@codmarcafin", p_strCodmarcafin),
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
        /// Método Fijo: ZReclamosGral
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= "p_dtFechaini">Fecha Inicial</param>
        /// <param name= "p_dtFechafin">Fecha Fin</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int ZReclamosGral(DBConn p_dbcAccess,
                                        DateTime p_dtFechaini,
                                        DateTime p_dtFechafin,
                                        ref DataSet p_dsResult,
                                        string p_strTabla,
                                        StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Carm..CLILLAMADAS_ZRECLAMOSGRAL",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParamF("@fechaini", p_dtFechaini),
                                          p_dbcAccess.MakeParamF("@fechafin", p_dtFechafin),
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
        /// Método Fijo: ZRecuperosDetalle
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= "p_dtFechaini">Fecha Inicial</param>
        /// <param name= "p_dtFechafin">Fecha Fin</param>
        /// <param name= "p_strCodmarcaini">Codigo Marca Inicial</param>
        /// <param name= "p_strCodmarcafin">Codigo Marca Fin</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int ZRecuperosDetalle(DBConn p_dbcAccess,
                                            DateTime p_dtFechaini,
                                            DateTime p_dtFechafin,
                                            string p_strCodmarcaini,
                                            string p_strCodmarcafin,
                                            ref DataSet p_dsResult,
                                            string p_strTabla,
                                            StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Carm..CLILLAMADAS_ZRECUPEROSDETALLE",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParamF("@fechaini", p_dtFechaini),
                                          p_dbcAccess.MakeParamF("@fechafin", p_dtFechafin),
                                          p_dbcAccess.MakeParam("@codmarcaini", p_strCodmarcaini),
                                          p_dbcAccess.MakeParam("@codmarcafin", p_strCodmarcafin),
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
        /// Método Fijo: ZRecuperosGral
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= "p_dtFechaini">Fecha Inicial</param>
        /// <param name= "p_dtFechafin">Fecha Fin</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int ZRecuperosGral(DBConn p_dbcAccess,
                                         DateTime p_dtFechaini,
                                         DateTime p_dtFechafin,
                                         ref DataSet p_dsResult,
                                         string p_strTabla,
                                         StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Carm..CLILLAMADAS_ZRECUPEROSGRAL",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParamF("@fechaini", p_dtFechaini),
                                          p_dbcAccess.MakeParamF("@fechafin", p_dtFechafin),
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
                p_dtResult.Columns["cll_des_motivo"].Caption= "V1MotivoCN1";
                p_dtResult.Columns["cll_ede_rsocial"].Caption= "V1Razón SocialCN1";
                p_dtResult.Columns["cll_cod_codmotivo"].Caption= "V1Código de motivoCN1";
                p_dtResult.Columns["cll_nom_codusuario"].Caption= "V1Código del usuarioCN1";
                p_dtResult.Columns["cll_fyh_frealizada"].Caption= "V1Fecha RealizadaDN1";
                p_dtResult.Columns["cll_nro_numcliente"].Caption= "V1Número de clienteNN1";
                p_dtResult.Columns["cll_nro_numcontacto"].Caption= "V1Número de contactoNN1";
                p_dtResult.Columns["cll_nro_numllamada"].Caption= "V1Número de llamadaNN1";
                p_dtResult.Columns["cll_txt_resultado"].Caption= "V1ResultadoCN1";
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
