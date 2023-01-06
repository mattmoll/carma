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
    // Clase para Administrar   : Ventas de los Clientes
    // Basada en la Tabla       : CliVentas
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
    /// Modulo DAL de Acceso a la tabla: CliVentas
    /// </summary>
    public static class CliVentas
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
                                      "TNGS_Carm..CLIVENTAS_UP",
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
        /// <param name="p_iNumcliente">Numero Cliente</param>
        /// <param name="p_dtFecha">Fecha Venta</param>
        /// <param name="p_iFxdVersion">Número de version a verificar</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void ChkVersion(DBConn p_dbcAccess,
                                      int p_iNumcliente,
                                      DateTime p_dtFecha,
                                      int p_iFxdVersion,
                                      ref DataSet p_dsResult,
                                      string p_strTabla,
                                      StatMsg p_smResult)
        {
            try {
                // Verificamos el número de versión
                DBRuts.Exec_DS(p_dbcAccess,
                               "TNGS_Carm..CLIVENTAS_CHKVERSION",
                               new DbParameter[] {
                                   p_dbcAccess.MakeParam("@clv_nro_numcliente", p_iNumcliente),
                                   p_dbcAccess.MakeParam("@clv_fyh_fecha", p_dtFecha),
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
        /// <param name="p_iNumcliente">Numero Cliente</param>
        /// <param name="p_dtFecha">Fecha Venta</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Search(DBConn p_dbcAccess,
                                 int p_iNumcliente,
                                 DateTime p_dtFecha,
                                 bool p_bOnlyActive,
                                 ref DataSet p_dsResult,
                                 string p_strTabla,
                                 StatMsg p_smResult)
        {
            try {
                // Recuperamos el registro de la clave
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Carm..CLIVENTAS_SEARCH",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@clv_nro_numcliente", p_iNumcliente),
                                          p_dbcAccess.MakeParam("@clv_fyh_fecha", p_dtFecha),
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
        /// <param name="p_iNumcliente">Numero Cliente</param>
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
                                      "TNGS_Carm..CLIVENTAS_FSEARCH",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@clv_nro_numcliente", p_iNumcliente),
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
        /// <param name="p_iNumcliente">Numero Cliente</param>
        /// <param name="p_dtFecha">Fecha Venta</param>
        /// <param name="p_strCodvendedor">Vendedor</param>
        /// <param name="p_dcAbono">Abono</param>
        /// <param name="p_iCantcapitas">Cant Personas</param>
        /// <param name="p_strCodplan">Plan</param>
        /// <param name="p_strCodlistaprecios">Lista de Precios</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Insert(DBConn p_dbcAccess,
                                 int p_iNumcliente,
                                 DateTime p_dtFecha,
                                 string p_strCodvendedor,
                                 decimal p_dcAbono,
                                 int p_iCantcapitas,
                                 string p_strCodplan,
                                 string p_strCodlistaprecios,
                                 StatMsg p_smResult)
        {
            try {
                // Insertamos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..CLIVENTAS_INSERT",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@clv_nro_numcliente", p_iNumcliente),
                                       p_dbcAccess.MakeParam("@clv_fyh_fecha", p_dtFecha),
                                       p_dbcAccess.MakeParam("@clv_cd6_codvendedor", p_strCodvendedor),
                                       p_dbcAccess.MakeParam("@clv_imp_abono", p_dcAbono),
                                       p_dbcAccess.MakeParam("@clv_nro_cantcapitas", p_iCantcapitas),
                                       p_dbcAccess.MakeParam("@clv_cod_codplan", p_strCodplan),
                                       p_dbcAccess.MakeParam("@clv_cod_codlistaprecios", p_strCodlistaprecios),
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
        /// <param name="p_iNumcliente">Numero Cliente</param>
        /// <param name="p_dtFecha">Fecha Venta</param>
        /// <param name="p_strCodvendedor">Vendedor</param>
        /// <param name="p_dcAbono">Abono</param>
        /// <param name="p_iCantcapitas">Cant Personas</param>
        /// <param name="p_strCodplan">Plan</param>
        /// <param name="p_strCodlistaprecios">Lista de Precios</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Update(DBConn p_dbcAccess,
                                 int p_iNumcliente,
                                 DateTime p_dtFecha,
                                 string p_strCodvendedor,
                                 decimal p_dcAbono,
                                 int p_iCantcapitas,
                                 string p_strCodplan,
                                 string p_strCodlistaprecios,
                                 StatMsg p_smResult)
        {
            try {
                // Modificamos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..CLIVENTAS_UPDATE",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@clv_nro_numcliente", p_iNumcliente),
                                       p_dbcAccess.MakeParam("@clv_fyh_fecha", p_dtFecha),
                                       p_dbcAccess.MakeParam("@clv_cd6_codvendedor", p_strCodvendedor),
                                       p_dbcAccess.MakeParam("@clv_imp_abono", p_dcAbono),
                                       p_dbcAccess.MakeParam("@clv_nro_cantcapitas", p_iCantcapitas),
                                       p_dbcAccess.MakeParam("@clv_cod_codplan", p_strCodplan),
                                       p_dbcAccess.MakeParam("@clv_cod_codlistaprecios", p_strCodlistaprecios),
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
        /// <param name="p_iNumcliente">Numero Cliente</param>
        /// <param name="p_dtFecha">Fecha Venta</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Delete(DBConn p_dbcAccess,
                                 int p_iNumcliente,
                                 DateTime p_dtFecha,
                                 StatMsg p_smResult)
        {
            try {
                // Borramos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..CLIVENTAS_DELETE",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@clv_nro_numcliente", p_iNumcliente),
                                       p_dbcAccess.MakeParam("@clv_fyh_fecha", p_dtFecha),
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
        /// <param name="p_iNumcliente">Numero Cliente</param>
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
                                   "TNGS_Carm..CLIVENTAS_FDELETE",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@clv_nro_numcliente", p_iNumcliente),
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
        /// <param name="p_iNumcliente">Numero Cliente</param>
        /// <param name="p_dtFecha">Fecha Venta</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Recall(DBConn p_dbcAccess,
                                 int p_iNumcliente,
                                 DateTime p_dtFecha,
                                 StatMsg p_smResult)
        {
            try {
                // Borramos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..CLIVENTAS_RECALL",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@clv_nro_numcliente", p_iNumcliente),
                                       p_dbcAccess.MakeParam("@clv_fyh_fecha", p_dtFecha),
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
        /// <param name="p_iNumcliente">Numero Cliente</param>
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
                                   "TNGS_Carm..CLIVENTAS_FRECALL",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@clv_nro_numcliente", p_iNumcliente),
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
        /// <param name="p_iNumcliente">Numero Cliente</param>
        /// <param name="p_dtFecha">Fecha Venta</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Drop(DBConn p_dbcAccess,
                               int p_iNumcliente,
                               DateTime p_dtFecha,
                               StatMsg p_smResult)
        {
            try {
                // Borramos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..CLIVENTAS_DROP",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@clv_nro_numcliente", p_iNumcliente),
                                       p_dbcAccess.MakeParam("@clv_fyh_fecha", p_dtFecha),
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
        /// <param name="p_iNumcliente">Numero Cliente</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int FDrop(DBConn p_dbcAccess,
                                int p_iNumcliente,
                                StatMsg p_smResult)
        {
            try {
                // Borramos los registro de la clave foranea
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..CLIVENTAS_FDROP",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@clv_nro_numcliente", p_iNumcliente),
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
                                   "TNGS_Carm..CLIVENTAS_PACK",
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
        /// <param name="p_iNumcliente">Numero Cliente</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int FPack(DBConn p_dbcAccess,
                                int p_iNumcliente,
                                StatMsg p_smResult)
        {
            try {
                // Borramos los registro de la clave foranea
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..CLIVENTAS_FPACK",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@clv_nro_numcliente", p_iNumcliente),
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
        /// Método Fijo: ZDetalleVentas
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= "p_iAnio">Anio</param>
        /// <param name= "p_iMes">Mes</param>
        /// <param name= "p_strCodmarcaini">Cod Marca Inicial</param>
        /// <param name= "p_strCodmarcafin">Cod Marca Fin</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int ZDetalleVentas(DBConn p_dbcAccess,
                                         int p_iAnio,
                                         int p_iMes,
                                         string p_strCodmarcaini,
                                         string p_strCodmarcafin,
                                         ref DataSet p_dsResult,
                                         string p_strTabla,
                                         StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Carm..CLIVENTAS_ZDETALLEVENTAS",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@anio", p_iAnio),
                                          p_dbcAccess.MakeParam("@mes", p_iMes),
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
        /// Método Fijo: ZVentasPorMes
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= "p_iAnioinicio">Anio de inicio</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int ZVentasPorMes(DBConn p_dbcAccess,
                                        int p_iAnioinicio,
                                        ref DataSet p_dsResult,
                                        string p_strTabla,
                                        StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Carm..CLIVENTAS_ZVENTASPORMES",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@anioinicio", p_iAnioinicio),
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
                p_dtResult.Columns["des_plan"].Caption= "V1PlanCN1";
                p_dtResult.Columns["listaprecios"].Caption= "V1Lista PreciosCN1";
                p_dtResult.Columns["vnd_des_desvend"].Caption= "V1VendedorCN1";
                p_dtResult.Columns["clv_imp_abono"].Caption= "V1Abono2N1";
                p_dtResult.Columns["clv_nro_cantcapitas"].Caption= "V1Cant PersonasNN1";
                p_dtResult.Columns["clv_fyh_fecha"].Caption= "V1Fecha VentaDN1";
                p_dtResult.Columns["clv_nro_numcliente"].Caption= "V1Numero ClienteNN1";
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
