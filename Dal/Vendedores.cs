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
    // Fecha                    : 09/08/2020 22:32
    // Sistema                  : Carm
    // Clase para Administrar   : Vendedores
    // Basada en la Tabla       : Vendedores
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
    /// Modulo DAL de Acceso a la tabla: Vendedores
    /// </summary>
    public static class Vendedores
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
                                      "TNGS_Carm..VENDEDORES_UP",
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
                               "TNGS_Carm..VENDEDORES_CHKVERSION",
                               new DbParameter[] {
                                   p_dbcAccess.MakeParam("@vnd_cd6_cod", p_strCod),
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
                                      "TNGS_Carm..VENDEDORES_SEARCH",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@vnd_cd6_cod", p_strCod),
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
        /// <param name="p_strApellido">Apellido</param>
        /// <param name="p_strNombre">Nombre</param>
        /// <param name="p_strUsuario">Usuario Sistema</param>
        /// <param name="p_strTel1">Telefono1</param>
        /// <param name="p_strCelular">Celular</param>
        /// <param name="p_strTel2">Telefono2</param>
        /// <param name="p_dtFecnacim">Fecha Nacimiento</param>
        /// <param name="p_strDireccion">Dirección</param>
        /// <param name="p_strCodsuperv">Supervisor</param>
        /// <param name="p_strCodtvend">Tipo Vendedor</param>
        /// <param name="p_strHorarios">Horarios</param>
        /// <param name="p_strHistorico">Es Historico</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Insert(DBConn p_dbcAccess,
                                 string p_strCod,
                                 string p_strApellido,
                                 string p_strNombre,
                                 string p_strUsuario,
                                 string p_strTel1,
                                 string p_strCelular,
                                 string p_strTel2,
                                 DateTime p_dtFecnacim,
                                 string p_strDireccion,
                                 string p_strCodsuperv,
                                 string p_strCodtvend,
                                 string p_strHorarios,
                                 string p_strHistorico,
                                 StatMsg p_smResult)
        {
            try {
                // Insertamos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..VENDEDORES_INSERT",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@vnd_cd6_cod", p_strCod),
                                       p_dbcAccess.MakeParam("@vnd_des_apellido", p_strApellido),
                                       p_dbcAccess.MakeParam("@vnd_des_nombre", p_strNombre),
                                       p_dbcAccess.MakeParam("@vnd_nom_usuario", p_strUsuario),
                                       p_dbcAccess.MakeParam("@vnd_tel_tel1", p_strTel1),
                                       p_dbcAccess.MakeParam("@vnd_tel_celular", p_strCelular),
                                       p_dbcAccess.MakeParam("@vnd_tel_tel2", p_strTel2),
                                       p_dbcAccess.MakeParamF("@vnd_fec_fecnacim", p_dtFecnacim),
                                       p_dbcAccess.MakeParam("@vnd_ede_direccion", p_strDireccion),
                                       p_dbcAccess.MakeParam("@vnd_cd6_codsuperv", p_strCodsuperv),
                                       p_dbcAccess.MakeParam("@vnd_rcd_codtvend", p_strCodtvend),
                                       p_dbcAccess.MakeParam("@vnd_txt_horarios", p_strHorarios),
                                       p_dbcAccess.MakeParam("@vnd_cd1_historico", p_strHistorico),
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
        /// <param name="p_strApellido">Apellido</param>
        /// <param name="p_strNombre">Nombre</param>
        /// <param name="p_strUsuario">Usuario Sistema</param>
        /// <param name="p_strTel1">Telefono1</param>
        /// <param name="p_strCelular">Celular</param>
        /// <param name="p_strTel2">Telefono2</param>
        /// <param name="p_dtFecnacim">Fecha Nacimiento</param>
        /// <param name="p_strDireccion">Dirección</param>
        /// <param name="p_strCodsuperv">Supervisor</param>
        /// <param name="p_strCodtvend">Tipo Vendedor</param>
        /// <param name="p_strHorarios">Horarios</param>
        /// <param name="p_strHistorico">Es Historico</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Update(DBConn p_dbcAccess,
                                 string p_strCod,
                                 string p_strApellido,
                                 string p_strNombre,
                                 string p_strUsuario,
                                 string p_strTel1,
                                 string p_strCelular,
                                 string p_strTel2,
                                 DateTime p_dtFecnacim,
                                 string p_strDireccion,
                                 string p_strCodsuperv,
                                 string p_strCodtvend,
                                 string p_strHorarios,
                                 string p_strHistorico,
                                 StatMsg p_smResult)
        {
            try {
                // Modificamos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..VENDEDORES_UPDATE",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@vnd_cd6_cod", p_strCod),
                                       p_dbcAccess.MakeParam("@vnd_des_apellido", p_strApellido),
                                       p_dbcAccess.MakeParam("@vnd_des_nombre", p_strNombre),
                                       p_dbcAccess.MakeParam("@vnd_nom_usuario", p_strUsuario),
                                       p_dbcAccess.MakeParam("@vnd_tel_tel1", p_strTel1),
                                       p_dbcAccess.MakeParam("@vnd_tel_celular", p_strCelular),
                                       p_dbcAccess.MakeParam("@vnd_tel_tel2", p_strTel2),
                                       p_dbcAccess.MakeParamF("@vnd_fec_fecnacim", p_dtFecnacim),
                                       p_dbcAccess.MakeParam("@vnd_ede_direccion", p_strDireccion),
                                       p_dbcAccess.MakeParam("@vnd_cd6_codsuperv", p_strCodsuperv),
                                       p_dbcAccess.MakeParam("@vnd_rcd_codtvend", p_strCodtvend),
                                       p_dbcAccess.MakeParam("@vnd_txt_horarios", p_strHorarios),
                                       p_dbcAccess.MakeParam("@vnd_cd1_historico", p_strHistorico),
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
                                   "TNGS_Carm..VENDEDORES_DELETE",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@vnd_cd6_cod", p_strCod),
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
                                   "TNGS_Carm..VENDEDORES_RECALL",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@vnd_cd6_cod", p_strCod),
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
                                   "TNGS_Carm..VENDEDORES_DROP",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@vnd_cd6_cod", p_strCod),
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
                                   "TNGS_Carm..VENDEDORES_PACK",
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
        /// Método Fijo: GetCodVend
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int GetCodVend(DBConn p_dbcAccess,
                                     ref DataSet p_dsResult,
                                     string p_strTabla,
                                     StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Carm..VENDEDORES_GETCODVEND",
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
        /// Método Fijo: GetEntrevistas
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= "p_strCodvend">Código de vendedor</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int GetEntrevistas(DBConn p_dbcAccess,
                                         string p_strCodvend,
                                         ref DataSet p_dsResult,
                                         string p_strTabla,
                                         StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Carm..VENDEDORES_GETENTREVISTAS",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@codvend", p_strCodvend),
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
        /// Método Fijo: GetEntrevistasHist
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= "p_strCodvend">Código de vendedor</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int GetEntrevistasHist(DBConn p_dbcAccess,
                                             string p_strCodvend,
                                             ref DataSet p_dsResult,
                                             string p_strTabla,
                                             StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Carm..VENDEDORES_GETENTREVISTASHIST",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@codvend", p_strCodvend),
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
        /// Método Fijo: GetLlamadas
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int GetLlamadas(DBConn p_dbcAccess,
                                      ref DataSet p_dsResult,
                                      string p_strTabla,
                                      StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Carm..VENDEDORES_GETLLAMADAS",
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
        /// Método Fijo: GetSolicitudes
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= "p_strCodvend">Código de vendedor</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int GetSolicitudes(DBConn p_dbcAccess,
                                         string p_strCodvend,
                                         ref DataSet p_dsResult,
                                         string p_strTabla,
                                         StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Carm..VENDEDORES_GETSOLICITUDES",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@codvend", p_strCodvend),
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
        /// Método Fijo: GetVendedorFromUsu
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int GetVendedorFromUsu(DBConn p_dbcAccess,
                                             ref DataSet p_dsResult,
                                             string p_strTabla,
                                             StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Carm..VENDEDORES_GETVENDEDORFROMUSU",
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
        /// Método Fijo: ZEntrevistasBasico
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= "p_dtFechaini">Fecha Inicio de busqueda</param>
        /// <param name= "p_dtFechafin">Fecha Fin de busqueda</param>
        /// <param name= "p_strCodinivendedor">Codigo inicial Vendedor</param>
        /// <param name= "p_strCodfinvendedor">Codigo Fin Vendedor</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int ZEntrevistasBasico(DBConn p_dbcAccess,
                                             DateTime p_dtFechaini,
                                             DateTime p_dtFechafin,
                                             string p_strCodinivendedor,
                                             string p_strCodfinvendedor,
                                             ref DataSet p_dsResult,
                                             string p_strTabla,
                                             StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Carm..VENDEDORES_ZENTREVISTASBASICO",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@fechaini", p_dtFechaini),
                                          p_dbcAccess.MakeParam("@fechafin", p_dtFechafin),
                                          p_dbcAccess.MakeParam("@codinivendedor", p_strCodinivendedor),
                                          p_dbcAccess.MakeParam("@codfinvendedor", p_strCodfinvendedor),
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
        /// Método Fijo: ZLlamadasProgramadas
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= "p_strUsuarioprogramador">Usuario que programo la llamada</param>
        /// <param name= "p_dtFechaini">Fecha inicial</param>
        /// <param name= "p_dtFechafin">Fecha fin</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int ZLlamadasProgramadas(DBConn p_dbcAccess,
                                               string p_strUsuarioprogramador,
                                               DateTime p_dtFechaini,
                                               DateTime p_dtFechafin,
                                               ref DataSet p_dsResult,
                                               string p_strTabla,
                                               StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Carm..VENDEDORES_ZLLAMADASPROGRAMADAS",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@usuarioprogramador", p_strUsuarioprogramador),
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
        /// Método Fijo: ZLlamados
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= "p_dtFechaini">Fecha de Inicio Busqueda</param>
        /// <param name= "p_dtFechafin">Fecha de Fin Busqueda</param>
        /// <param name= "p_strTipo">Tipo de Llamadas (E/S)</param>
        /// <param name= "p_strCodcatini">Codigo Categoria Ini</param>
        /// <param name= "p_strCodcatfin">Codigo Categoria Fin</param>
        /// <param name= "p_strCodinivendedor">Codigo inicial Vendedor</param>
        /// <param name= "p_strCodfinvendedor">Codigo Vendedor Fin</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int ZLlamados(DBConn p_dbcAccess,
                                    DateTime p_dtFechaini,
                                    DateTime p_dtFechafin,
                                    string p_strTipo,
                                    string p_strCodcatini,
                                    string p_strCodcatfin,
                                    string p_strCodinivendedor,
                                    string p_strCodfinvendedor,
                                    ref DataSet p_dsResult,
                                    string p_strTabla,
                                    StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Carm..VENDEDORES_ZLLAMADOS",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@fechaini", p_dtFechaini),
                                          p_dbcAccess.MakeParam("@fechafin", p_dtFechafin),
                                          p_dbcAccess.MakeParam("@tipo", p_strTipo),
                                          p_dbcAccess.MakeParam("@codcatini", p_strCodcatini),
                                          p_dbcAccess.MakeParam("@codcatfin", p_strCodcatfin),
                                          p_dbcAccess.MakeParam("@codinivendedor", p_strCodinivendedor),
                                          p_dbcAccess.MakeParam("@codfinvendedor", p_strCodfinvendedor),
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
        /// Método Fijo: ZReservasBasico
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= "p_strCodvendini">Codigo Inicial de Vendedor</param>
        /// <param name= "p_strCodvendfin">Codigo Final de Vendedor</param>
        /// <param name= "p_dtFechaini">Fecha Inicial de Reservas</param>
        /// <param name= "p_dtFechafin">Fecha Final de Reservas</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int ZReservasBasico(DBConn p_dbcAccess,
                                          string p_strCodvendini,
                                          string p_strCodvendfin,
                                          DateTime p_dtFechaini,
                                          DateTime p_dtFechafin,
                                          ref DataSet p_dsResult,
                                          string p_strTabla,
                                          StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Carm..VENDEDORES_ZRESERVASBASICO",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@codvendini", p_strCodvendini),
                                          p_dbcAccess.MakeParam("@codvendfin", p_strCodvendfin),
                                          p_dbcAccess.MakeParam("@fechaini", p_dtFechaini),
                                          p_dbcAccess.MakeParam("@fechafin", p_dtFechafin),
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
        /// Método Fijo: ZVencidas
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= "p_strCodvendini">Codigo Vendedor Inicial</param>
        /// <param name= "p_strCodvendfin">Codigo Vendedor Fin</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int ZVencidas(DBConn p_dbcAccess,
                                    string p_strCodvendini,
                                    string p_strCodvendfin,
                                    ref DataSet p_dsResult,
                                    string p_strTabla,
                                    StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Carm..VENDEDORES_ZVENCIDAS",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@codvendini", p_strCodvendini),
                                          p_dbcAccess.MakeParam("@codvendfin", p_strCodvendfin),
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
        /// Método Fijo: ZVentas
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= "p_dtFechaini">Fecha Inicial de la busqueda</param>
        /// <param name= "p_dtFechafin">Fecha Fianl de la busqueda</param>
        /// <param name= "p_strCodvendini">Codigo Inicial de Vendedor</param>
        /// <param name= "p_strCodvendfin">Codigo Final de Vendedor</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int ZVentas(DBConn p_dbcAccess,
                                  DateTime p_dtFechaini,
                                  DateTime p_dtFechafin,
                                  string p_strCodvendini,
                                  string p_strCodvendfin,
                                  ref DataSet p_dsResult,
                                  string p_strTabla,
                                  StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Carm..VENDEDORES_ZVENTAS",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@fechaini", p_dtFechaini),
                                          p_dbcAccess.MakeParam("@fechafin", p_dtFechafin),
                                          p_dbcAccess.MakeParam("@codvendini", p_strCodvendini),
                                          p_dbcAccess.MakeParam("@codvendfin", p_strCodvendfin),
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
        /// Método Fijo: ZVentasDetalle
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= "p_dtFechaini">Fecha Inicial de la busqueda</param>
        /// <param name= "p_dtFechafin">Fecha Fianl de la busqueda</param>
        /// <param name= "p_strCodvendini">Codigo Inicial de Vendedor</param>
        /// <param name= "p_strCodvendfin">Codigo Final de Vendedor</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int ZVentasDetalle(DBConn p_dbcAccess,
                                         DateTime p_dtFechaini,
                                         DateTime p_dtFechafin,
                                         string p_strCodvendini,
                                         string p_strCodvendfin,
                                         ref DataSet p_dsResult,
                                         string p_strTabla,
                                         StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Carm..VENDEDORES_ZVENTASDETALLE",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@fechaini", p_dtFechaini),
                                          p_dbcAccess.MakeParam("@fechafin", p_dtFechafin),
                                          p_dbcAccess.MakeParam("@codvendini", p_strCodvendini),
                                          p_dbcAccess.MakeParam("@codvendfin", p_strCodvendfin),
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
                p_dtResult.Columns["vnd_cd1_vemayor"].Caption= "V1Ve MayoristasCN1";
                p_dtResult.Columns["vnd_des_tipovnd"].Caption= "V1Tipo vendedorCN1";
                p_dtResult.Columns["vnd_ede_nya"].Caption= "V1Nombre CompletoCN1";
                p_dtResult.Columns["vnd_nom_superv"].Caption= "V1SupervisorCN1";
                p_dtResult.Columns["vnd_des_apellido"].Caption= "V1ApellidoCN1";
                p_dtResult.Columns["vnd_tel_celular"].Caption= "V1CelularCN1";
                p_dtResult.Columns["vnd_cd6_cod"].Caption= "V1CódigoCN1";
                p_dtResult.Columns["vnd_rcd_codtvend"].Caption= "V1Tipo VendedorCN1";
                p_dtResult.Columns["vnd_cd1_historico"].Caption= "V1Es HistoricoCN1";
                p_dtResult.Columns["vnd_des_nombre"].Caption= "V1NombreCN1";
                p_dtResult.Columns["vnd_tel_tel1"].Caption= "V1Telefono1CN1";
                p_dtResult.Columns["vnd_tel_tel2"].Caption= "V1Telefono2CN1";
                p_dtResult.Columns["vnd_nom_usuario"].Caption= "V1Usuario SistemaCN1";
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
