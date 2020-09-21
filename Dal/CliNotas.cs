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
    // Fecha                    : 20/09/2020 03:42
    // Sistema                  : Carm
    // Clase para Administrar   : Notas de los Clientes
    // Basada en la Tabla       : CliNotas
    //----------------------------------------------------------------------------
    // © 1996-2020 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    //****************************************************************************
    // Atencion!!!
    //    Esta clase fue generada por un programa en forma automática. Cualquier
    //    modificación que se realize sobre ella se perderá en la próxima
    //    regeneración.
    //****************************************************************************

    /// <summary>
    /// Modulo DAL de Acceso a la tabla: CliNotas
    /// </summary>
    public static class CliNotas
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
                                      "TNGS_Carm..CLINOTAS_UP",
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
        /// <param name="p_iNumcliente">Numero del Cliente</param>
        /// <param name="p_dtFechayhora">Fecha y Hora</param>
        /// <param name="p_iFxdVersion">Número de version a verificar</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void ChkVersion(DBConn p_dbcAccess,
                                      int p_iNumcliente,
                                      DateTime p_dtFechayhora,
                                      int p_iFxdVersion,
                                      ref DataSet p_dsResult,
                                      string p_strTabla,
                                      StatMsg p_smResult)
        {
            try {
                // Verificamos el número de versión
                DBRuts.Exec_DS(p_dbcAccess,
                               "TNGS_Carm..CLINOTAS_CHKVERSION",
                               new DbParameter[] {
                                   p_dbcAccess.MakeParam("@cln_nro_numcliente", p_iNumcliente),
                                   p_dbcAccess.MakeParam("@cln_fyh_fechayhora", p_dtFechayhora),
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
        /// <param name="p_iNumcliente">Numero del Cliente</param>
        /// <param name="p_dtFechayhora">Fecha y Hora</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Search(DBConn p_dbcAccess,
                                 int p_iNumcliente,
                                 DateTime p_dtFechayhora,
                                 bool p_bOnlyActive,
                                 ref DataSet p_dsResult,
                                 string p_strTabla,
                                 StatMsg p_smResult)
        {
            try {
                // Recuperamos el registro de la clave
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Carm..CLINOTAS_SEARCH",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@cln_nro_numcliente", p_iNumcliente),
                                          p_dbcAccess.MakeParam("@cln_fyh_fechayhora", p_dtFechayhora),
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
        /// <param name="p_iNumcliente">Numero del Cliente</param>
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
                                      "TNGS_Carm..CLINOTAS_FSEARCH",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@cln_nro_numcliente", p_iNumcliente),
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
        /// <param name="p_iNumcliente">Numero del Cliente</param>
        /// <param name="p_dtFechayhora">Fecha y Hora</param>
        /// <param name="p_strTitulo">Título</param>
        /// <param name="p_strTexto">Texto</param>
        /// <param name="p_strTipo">Tipo</param>
        /// <param name="p_strEscritor">Usuario Escritor</param>
        /// <param name="p_strRemovedor">Usuario Removedor</param>
        /// <param name="p_dtFyhremovida">Fecha y Hora Removida</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Insert(DBConn p_dbcAccess,
                                 int p_iNumcliente,
                                 DateTime p_dtFechayhora,
                                 string p_strTitulo,
                                 string p_strTexto,
                                 string p_strTipo,
                                 string p_strEscritor,
                                 string p_strRemovedor,
                                 DateTime p_dtFyhremovida,
                                 StatMsg p_smResult)
        {
            try {
                // Insertamos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..CLINOTAS_INSERT",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@cln_nro_numcliente", p_iNumcliente),
                                       p_dbcAccess.MakeParam("@cln_fyh_fechayhora", p_dtFechayhora),
                                       p_dbcAccess.MakeParam("@cln_des_titulo", p_strTitulo),
                                       p_dbcAccess.MakeParam("@cln_xld_texto", p_strTexto),
                                       p_dbcAccess.MakeParam("@cln_cd1_tipo", p_strTipo),
                                       p_dbcAccess.MakeParam("@cln_nom_escritor", p_strEscritor),
                                       p_dbcAccess.MakeParam("@cln_nom_removedor", p_strRemovedor),
                                       p_dbcAccess.MakeParam("@cln_fyh_fyhremovida", p_dtFyhremovida),
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
        /// <param name="p_iNumcliente">Numero del Cliente</param>
        /// <param name="p_dtFechayhora">Fecha y Hora</param>
        /// <param name="p_strTitulo">Título</param>
        /// <param name="p_strTexto">Texto</param>
        /// <param name="p_strTipo">Tipo</param>
        /// <param name="p_strEscritor">Usuario Escritor</param>
        /// <param name="p_strRemovedor">Usuario Removedor</param>
        /// <param name="p_dtFyhremovida">Fecha y Hora Removida</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Update(DBConn p_dbcAccess,
                                 int p_iNumcliente,
                                 DateTime p_dtFechayhora,
                                 string p_strTitulo,
                                 string p_strTexto,
                                 string p_strTipo,
                                 string p_strEscritor,
                                 string p_strRemovedor,
                                 DateTime p_dtFyhremovida,
                                 StatMsg p_smResult)
        {
            try {
                // Modificamos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..CLINOTAS_UPDATE",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@cln_nro_numcliente", p_iNumcliente),
                                       p_dbcAccess.MakeParam("@cln_fyh_fechayhora", p_dtFechayhora),
                                       p_dbcAccess.MakeParam("@cln_des_titulo", p_strTitulo),
                                       p_dbcAccess.MakeParam("@cln_xld_texto", p_strTexto),
                                       p_dbcAccess.MakeParam("@cln_cd1_tipo", p_strTipo),
                                       p_dbcAccess.MakeParam("@cln_nom_escritor", p_strEscritor),
                                       p_dbcAccess.MakeParam("@cln_nom_removedor", p_strRemovedor),
                                       p_dbcAccess.MakeParam("@cln_fyh_fyhremovida", p_dtFyhremovida),
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
        /// <param name="p_iNumcliente">Numero del Cliente</param>
        /// <param name="p_dtFechayhora">Fecha y Hora</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Delete(DBConn p_dbcAccess,
                                 int p_iNumcliente,
                                 DateTime p_dtFechayhora,
                                 StatMsg p_smResult)
        {
            try {
                // Borramos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..CLINOTAS_DELETE",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@cln_nro_numcliente", p_iNumcliente),
                                       p_dbcAccess.MakeParam("@cln_fyh_fechayhora", p_dtFechayhora),
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
        /// <param name="p_iNumcliente">Numero del Cliente</param>
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
                                   "TNGS_Carm..CLINOTAS_FDELETE",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@cln_nro_numcliente", p_iNumcliente),
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
        /// <param name="p_iNumcliente">Numero del Cliente</param>
        /// <param name="p_dtFechayhora">Fecha y Hora</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Recall(DBConn p_dbcAccess,
                                 int p_iNumcliente,
                                 DateTime p_dtFechayhora,
                                 StatMsg p_smResult)
        {
            try {
                // Borramos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..CLINOTAS_RECALL",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@cln_nro_numcliente", p_iNumcliente),
                                       p_dbcAccess.MakeParam("@cln_fyh_fechayhora", p_dtFechayhora),
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
        /// <param name="p_iNumcliente">Numero del Cliente</param>
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
                                   "TNGS_Carm..CLINOTAS_FRECALL",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@cln_nro_numcliente", p_iNumcliente),
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
        /// <param name="p_iNumcliente">Numero del Cliente</param>
        /// <param name="p_dtFechayhora">Fecha y Hora</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Drop(DBConn p_dbcAccess,
                               int p_iNumcliente,
                               DateTime p_dtFechayhora,
                               StatMsg p_smResult)
        {
            try {
                // Borramos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..CLINOTAS_DROP",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@cln_nro_numcliente", p_iNumcliente),
                                       p_dbcAccess.MakeParam("@cln_fyh_fechayhora", p_dtFechayhora),
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
        /// <param name="p_iNumcliente">Numero del Cliente</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int FDrop(DBConn p_dbcAccess,
                                int p_iNumcliente,
                                StatMsg p_smResult)
        {
            try {
                // Borramos los registro de la clave foranea
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..CLINOTAS_FDROP",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@cln_nro_numcliente", p_iNumcliente),
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
                                   "TNGS_Carm..CLINOTAS_PACK",
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
        /// <param name="p_iNumcliente">Numero del Cliente</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int FPack(DBConn p_dbcAccess,
                                int p_iNumcliente,
                                StatMsg p_smResult)
        {
            try {
                // Borramos los registro de la clave foranea
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..CLINOTAS_FPACK",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@cln_nro_numcliente", p_iNumcliente),
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
        /// <param name= "p_iNrocliente">Numero del cliente a borrar las notas</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int BorraPorCliente(DBConn p_dbcAccess,
                                          int p_iNrocliente,
                                          StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..CLINOTAS_BORRAPORCLIENTE",
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
        /// Método Fijo: CantidadNotas
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= "p_iNrocliente">Numero del Cliente</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int CantidadNotas(DBConn p_dbcAccess,
                                        int p_iNrocliente,
                                        ref DataSet p_dsResult,
                                        string p_strTabla,
                                        StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Carm..CLINOTAS_CANTIDADNOTAS",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@nrocliente", p_iNrocliente),
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
        /// Método Fijo: Remover
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= "p_strRemovedor">Usuario Removedor</param>
        /// <param name= "p_dtFyhremovida">Fecha y Hora Removida</param>
        /// <param name= "p_iNrocliente">Numero del cliente</param>
        /// <param name= "p_dtFechayhora">Fecha y Hora de la nota</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Remover(DBConn p_dbcAccess,
                                  string p_strRemovedor,
                                  DateTime p_dtFyhremovida,
                                  int p_iNrocliente,
                                  DateTime p_dtFechayhora,
                                  StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..CLINOTAS_REMOVER",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@removedor", p_strRemovedor),
                                       p_dbcAccess.MakeParam("@fyhremovida", p_dtFyhremovida),
                                       p_dbcAccess.MakeParam("@nrocliente", p_iNrocliente),
                                       p_dbcAccess.MakeParam("@fechayhora", p_dtFechayhora),
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
                p_dtResult.Columns["cln_cd1_borrada"].Caption= "V1BorradaCN2";
                p_dtResult.Columns["cln_nom_escritor"].Caption= "V1Usuario EscritorCN1";
                p_dtResult.Columns["cln_fyh_fechayhora"].Caption= "V1Fecha y HoraDN1";
                p_dtResult.Columns["cln_fyh_fyhremovida"].Caption= "V1Fecha y Hora RemovidaDN1";
                p_dtResult.Columns["cln_nro_numcliente"].Caption= "V1Numero del ClienteNN1";
                p_dtResult.Columns["cln_nom_removedor"].Caption= "V1Usuario RemovedorCN1";
                p_dtResult.Columns["cln_cd1_tipo"].Caption= "V1TipoCN2";
                p_dtResult.Columns["cln_des_titulo"].Caption= "V1TítuloCN1";
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
