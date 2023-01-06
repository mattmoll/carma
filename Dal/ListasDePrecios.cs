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
    // Clase para Administrar   : Listas de Precios
    // Basada en la Tabla       : ListasDePrecios
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
    /// Modulo DAL de Acceso a la tabla: ListasDePrecios
    /// </summary>
    public static class ListasDePrecios
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
                                      "TNGS_Carm..LISTASDEPRECIOS_UP",
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
        /// <param name="p_strCod">Código</param>
        /// <param name="p_iFxdVersion">Número de version a verificar</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void ChkVersion(DBConn p_dbcAccess,
                                      string p_strCod,
                                      int p_iFxdVersion,
                                      ref DataSet p_dsResult,
                                      string p_strTabla,
                                      StatMsg p_smResult)
        {
            try {
                // Verificamos el número de versión
                DBRuts.Exec_DS(p_dbcAccess,
                               "TNGS_Carm..LISTASDEPRECIOS_CHKVERSION",
                               new DbParameter[] {
                                   p_dbcAccess.MakeParam("@lpr_cod_cod", p_strCod),
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
        /// <param name="p_strCod">Código</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Search(DBConn p_dbcAccess,
                                 string p_strCod,
                                 bool p_bOnlyActive,
                                 ref DataSet p_dsResult,
                                 string p_strTabla,
                                 StatMsg p_smResult)
        {
            try {
                // Recuperamos el registro de la clave
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Carm..LISTASDEPRECIOS_SEARCH",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@lpr_cod_cod", p_strCod),
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
        /// <param name="p_strCod">Código</param>
        /// <param name="p_strDes">Descripción</param>
        /// <param name="p_strCodplan">Plan</param>
        /// <param name="p_strCodmarca">Marca</param>
        /// <param name="p_dcPrecio1p">Precio 1 P</param>
        /// <param name="p_dcPrecio2p">Precio 2 P</param>
        /// <param name="p_dcPrecio3p">Precio 3 P</param>
        /// <param name="p_dcPrecio4p">Precio 4 P</param>
        /// <param name="p_dcPrecio5p">Precio 5 P</param>
        /// <param name="p_dcPrecio6p">Precio 6 P</param>
        /// <param name="p_dcPrecio7p">Precio 7 P</param>
        /// <param name="p_dcPrecio8p">Precio 8 P</param>
        /// <param name="p_dcPrecio9p">Precio 9 P</param>
        /// <param name="p_dcPrecio10p">Precio 10 P</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Insert(DBConn p_dbcAccess,
                                 string p_strCod,
                                 string p_strDes,
                                 string p_strCodplan,
                                 string p_strCodmarca,
                                 decimal p_dcPrecio1p,
                                 decimal p_dcPrecio2p,
                                 decimal p_dcPrecio3p,
                                 decimal p_dcPrecio4p,
                                 decimal p_dcPrecio5p,
                                 decimal p_dcPrecio6p,
                                 decimal p_dcPrecio7p,
                                 decimal p_dcPrecio8p,
                                 decimal p_dcPrecio9p,
                                 decimal p_dcPrecio10p,
                                 StatMsg p_smResult)
        {
            try {
                // Insertamos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..LISTASDEPRECIOS_INSERT",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@lpr_cod_cod", p_strCod),
                                       p_dbcAccess.MakeParam("@lpr_des_des", p_strDes),
                                       p_dbcAccess.MakeParam("@lpr_cod_codplan", p_strCodplan),
                                       p_dbcAccess.MakeParam("@lpr_rcd_codmarca", p_strCodmarca),
                                       p_dbcAccess.MakeParam("@lpr_imp_precio1p", p_dcPrecio1p),
                                       p_dbcAccess.MakeParam("@lpr_imp_precio2p", p_dcPrecio2p),
                                       p_dbcAccess.MakeParam("@lpr_imp_precio3p", p_dcPrecio3p),
                                       p_dbcAccess.MakeParam("@lpr_imp_precio4p", p_dcPrecio4p),
                                       p_dbcAccess.MakeParam("@lpr_imp_precio5p", p_dcPrecio5p),
                                       p_dbcAccess.MakeParam("@lpr_imp_precio6p", p_dcPrecio6p),
                                       p_dbcAccess.MakeParam("@lpr_imp_precio7p", p_dcPrecio7p),
                                       p_dbcAccess.MakeParam("@lpr_imp_precio8p", p_dcPrecio8p),
                                       p_dbcAccess.MakeParam("@lpr_imp_precio9p", p_dcPrecio9p),
                                       p_dbcAccess.MakeParam("@lpr_imp_precio10p", p_dcPrecio10p),
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
        /// <param name="p_strCod">Código</param>
        /// <param name="p_strDes">Descripción</param>
        /// <param name="p_strCodplan">Plan</param>
        /// <param name="p_strCodmarca">Marca</param>
        /// <param name="p_dcPrecio1p">Precio 1 P</param>
        /// <param name="p_dcPrecio2p">Precio 2 P</param>
        /// <param name="p_dcPrecio3p">Precio 3 P</param>
        /// <param name="p_dcPrecio4p">Precio 4 P</param>
        /// <param name="p_dcPrecio5p">Precio 5 P</param>
        /// <param name="p_dcPrecio6p">Precio 6 P</param>
        /// <param name="p_dcPrecio7p">Precio 7 P</param>
        /// <param name="p_dcPrecio8p">Precio 8 P</param>
        /// <param name="p_dcPrecio9p">Precio 9 P</param>
        /// <param name="p_dcPrecio10p">Precio 10 P</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Update(DBConn p_dbcAccess,
                                 string p_strCod,
                                 string p_strDes,
                                 string p_strCodplan,
                                 string p_strCodmarca,
                                 decimal p_dcPrecio1p,
                                 decimal p_dcPrecio2p,
                                 decimal p_dcPrecio3p,
                                 decimal p_dcPrecio4p,
                                 decimal p_dcPrecio5p,
                                 decimal p_dcPrecio6p,
                                 decimal p_dcPrecio7p,
                                 decimal p_dcPrecio8p,
                                 decimal p_dcPrecio9p,
                                 decimal p_dcPrecio10p,
                                 StatMsg p_smResult)
        {
            try {
                // Modificamos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..LISTASDEPRECIOS_UPDATE",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@lpr_cod_cod", p_strCod),
                                       p_dbcAccess.MakeParam("@lpr_des_des", p_strDes),
                                       p_dbcAccess.MakeParam("@lpr_cod_codplan", p_strCodplan),
                                       p_dbcAccess.MakeParam("@lpr_rcd_codmarca", p_strCodmarca),
                                       p_dbcAccess.MakeParam("@lpr_imp_precio1p", p_dcPrecio1p),
                                       p_dbcAccess.MakeParam("@lpr_imp_precio2p", p_dcPrecio2p),
                                       p_dbcAccess.MakeParam("@lpr_imp_precio3p", p_dcPrecio3p),
                                       p_dbcAccess.MakeParam("@lpr_imp_precio4p", p_dcPrecio4p),
                                       p_dbcAccess.MakeParam("@lpr_imp_precio5p", p_dcPrecio5p),
                                       p_dbcAccess.MakeParam("@lpr_imp_precio6p", p_dcPrecio6p),
                                       p_dbcAccess.MakeParam("@lpr_imp_precio7p", p_dcPrecio7p),
                                       p_dbcAccess.MakeParam("@lpr_imp_precio8p", p_dcPrecio8p),
                                       p_dbcAccess.MakeParam("@lpr_imp_precio9p", p_dcPrecio9p),
                                       p_dbcAccess.MakeParam("@lpr_imp_precio10p", p_dcPrecio10p),
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
        /// <param name="p_strCod">Código</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Delete(DBConn p_dbcAccess,
                                 string p_strCod,
                                 StatMsg p_smResult)
        {
            try {
                // Borramos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..LISTASDEPRECIOS_DELETE",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@lpr_cod_cod", p_strCod),
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
        /// <param name="p_strCod">Código</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Recall(DBConn p_dbcAccess,
                                 string p_strCod,
                                 StatMsg p_smResult)
        {
            try {
                // Borramos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..LISTASDEPRECIOS_RECALL",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@lpr_cod_cod", p_strCod),
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
        /// <param name="p_strCod">Código</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Drop(DBConn p_dbcAccess,
                               string p_strCod,
                               StatMsg p_smResult)
        {
            try {
                // Borramos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..LISTASDEPRECIOS_DROP",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@lpr_cod_cod", p_strCod),
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
                                   "TNGS_Carm..LISTASDEPRECIOS_PACK",
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
                p_dtResult.Columns["des_marca"].Caption= "V1MarcaCN1";
                p_dtResult.Columns["des_plan"].Caption= "V1PlanCN1";
                p_dtResult.Columns["lpr_cod_cod"].Caption= "V1CódigoCN1";
                p_dtResult.Columns["lpr_des_des"].Caption= "V1DescripciónCN1";
                p_dtResult.Columns["lpr_imp_precio10p"].Caption= "V1Precio 10 P2N1";
                p_dtResult.Columns["lpr_imp_precio1p"].Caption= "V1Precio 1 P2N1";
                p_dtResult.Columns["lpr_imp_precio2p"].Caption= "V1Precio 2 P2N1";
                p_dtResult.Columns["lpr_imp_precio3p"].Caption= "V1Precio 3 P2N1";
                p_dtResult.Columns["lpr_imp_precio4p"].Caption= "V1Precio 4 P2N1";
                p_dtResult.Columns["lpr_imp_precio5p"].Caption= "V1Precio 5 P2N1";
                p_dtResult.Columns["lpr_imp_precio6p"].Caption= "V1Precio 6 P2N1";
                p_dtResult.Columns["lpr_imp_precio7p"].Caption= "V1Precio 7 P2N1";
                p_dtResult.Columns["lpr_imp_precio8p"].Caption= "V1Precio 8 P2N1";
                p_dtResult.Columns["lpr_imp_precio9p"].Caption= "V1Precio 9 P2N1";
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
