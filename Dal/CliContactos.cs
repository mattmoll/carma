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
    // Clase para Administrar   : Contactos de los Clientes
    // Basada en la Tabla       : CliContactos
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
    /// Modulo DAL de Acceso a la tabla: CliContactos
    /// </summary>
    public static class CliContactos
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
                                      "TNGS_Carm..CLICONTACTOS_UP",
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
        /// <param name="p_iNumcontacto">Número</param>
        /// <param name="p_iFxdVersion">Número de version a verificar</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void ChkVersion(DBConn p_dbcAccess,
                                      int p_iNumcliente,
                                      int p_iNumcontacto,
                                      int p_iFxdVersion,
                                      ref DataSet p_dsResult,
                                      string p_strTabla,
                                      StatMsg p_smResult)
        {
            try {
                // Verificamos el número de versión
                DBRuts.Exec_DS(p_dbcAccess,
                               "TNGS_Carm..CLICONTACTOS_CHKVERSION",
                               new DbParameter[] {
                                   p_dbcAccess.MakeParam("@clc_nro_numcliente", p_iNumcliente),
                                   p_dbcAccess.MakeParam("@clc_nro_numcontacto", p_iNumcontacto),
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
        /// <param name="p_iNumcontacto">Número</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Search(DBConn p_dbcAccess,
                                 int p_iNumcliente,
                                 int p_iNumcontacto,
                                 bool p_bOnlyActive,
                                 ref DataSet p_dsResult,
                                 string p_strTabla,
                                 StatMsg p_smResult)
        {
            try {
                // Recuperamos el registro de la clave
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Carm..CLICONTACTOS_SEARCH",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@clc_nro_numcliente", p_iNumcliente),
                                          p_dbcAccess.MakeParam("@clc_nro_numcontacto", p_iNumcontacto),
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
                                      "TNGS_Carm..CLICONTACTOS_FSEARCH",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@clc_nro_numcliente", p_iNumcliente),
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
        /// <param name="p_iNumcontacto">Número</param>
        /// <param name="p_strNombre">Apellido y Nombre</param>
        /// <param name="p_strCargo">Cargo</param>
        /// <param name="p_strTitulo">Título</param>
        /// <param name="p_strCelular">Celular</param>
        /// <param name="p_strTelefono1">Teléfono 1</param>
        /// <param name="p_strTelefono2">Teléfono 2</param>
        /// <param name="p_strInterno">Interno</param>
        /// <param name="p_strEmail">Email</param>
        /// <param name="p_strSecretaria">Secretaria</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Insert(DBConn p_dbcAccess,
                                 int p_iNumcliente,
                                 int p_iNumcontacto,
                                 string p_strNombre,
                                 string p_strCargo,
                                 string p_strTitulo,
                                 string p_strCelular,
                                 string p_strTelefono1,
                                 string p_strTelefono2,
                                 string p_strInterno,
                                 string p_strEmail,
                                 string p_strSecretaria,
                                 StatMsg p_smResult)
        {
            try {
                // Insertamos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..CLICONTACTOS_INSERT",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@clc_nro_numcliente", p_iNumcliente),
                                       p_dbcAccess.MakeParam("@clc_nro_numcontacto", p_iNumcontacto),
                                       p_dbcAccess.MakeParam("@clc_des_nombre", p_strNombre),
                                       p_dbcAccess.MakeParam("@clc_des_cargo", p_strCargo),
                                       p_dbcAccess.MakeParam("@clc_des_titulo", p_strTitulo),
                                       p_dbcAccess.MakeParam("@clc_tel_celular", p_strCelular),
                                       p_dbcAccess.MakeParam("@clc_tel_telefono1", p_strTelefono1),
                                       p_dbcAccess.MakeParam("@clc_tel_telefono2", p_strTelefono2),
                                       p_dbcAccess.MakeParam("@clc_tel_interno", p_strInterno),
                                       p_dbcAccess.MakeParam("@clc_xld_email", p_strEmail),
                                       p_dbcAccess.MakeParam("@clc_des_secretaria", p_strSecretaria),
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
        /// <param name="p_iNumcontacto">Número</param>
        /// <param name="p_strNombre">Apellido y Nombre</param>
        /// <param name="p_strCargo">Cargo</param>
        /// <param name="p_strTitulo">Título</param>
        /// <param name="p_strCelular">Celular</param>
        /// <param name="p_strTelefono1">Teléfono 1</param>
        /// <param name="p_strTelefono2">Teléfono 2</param>
        /// <param name="p_strInterno">Interno</param>
        /// <param name="p_strEmail">Email</param>
        /// <param name="p_strSecretaria">Secretaria</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Update(DBConn p_dbcAccess,
                                 int p_iNumcliente,
                                 int p_iNumcontacto,
                                 string p_strNombre,
                                 string p_strCargo,
                                 string p_strTitulo,
                                 string p_strCelular,
                                 string p_strTelefono1,
                                 string p_strTelefono2,
                                 string p_strInterno,
                                 string p_strEmail,
                                 string p_strSecretaria,
                                 StatMsg p_smResult)
        {
            try {
                // Modificamos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..CLICONTACTOS_UPDATE",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@clc_nro_numcliente", p_iNumcliente),
                                       p_dbcAccess.MakeParam("@clc_nro_numcontacto", p_iNumcontacto),
                                       p_dbcAccess.MakeParam("@clc_des_nombre", p_strNombre),
                                       p_dbcAccess.MakeParam("@clc_des_cargo", p_strCargo),
                                       p_dbcAccess.MakeParam("@clc_des_titulo", p_strTitulo),
                                       p_dbcAccess.MakeParam("@clc_tel_celular", p_strCelular),
                                       p_dbcAccess.MakeParam("@clc_tel_telefono1", p_strTelefono1),
                                       p_dbcAccess.MakeParam("@clc_tel_telefono2", p_strTelefono2),
                                       p_dbcAccess.MakeParam("@clc_tel_interno", p_strInterno),
                                       p_dbcAccess.MakeParam("@clc_xld_email", p_strEmail),
                                       p_dbcAccess.MakeParam("@clc_des_secretaria", p_strSecretaria),
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
        /// <param name="p_iNumcontacto">Número</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Delete(DBConn p_dbcAccess,
                                 int p_iNumcliente,
                                 int p_iNumcontacto,
                                 StatMsg p_smResult)
        {
            try {
                // Borramos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..CLICONTACTOS_DELETE",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@clc_nro_numcliente", p_iNumcliente),
                                       p_dbcAccess.MakeParam("@clc_nro_numcontacto", p_iNumcontacto),
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
                                   "TNGS_Carm..CLICONTACTOS_FDELETE",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@clc_nro_numcliente", p_iNumcliente),
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
        /// <param name="p_iNumcontacto">Número</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Recall(DBConn p_dbcAccess,
                                 int p_iNumcliente,
                                 int p_iNumcontacto,
                                 StatMsg p_smResult)
        {
            try {
                // Borramos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..CLICONTACTOS_RECALL",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@clc_nro_numcliente", p_iNumcliente),
                                       p_dbcAccess.MakeParam("@clc_nro_numcontacto", p_iNumcontacto),
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
                                   "TNGS_Carm..CLICONTACTOS_FRECALL",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@clc_nro_numcliente", p_iNumcliente),
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
        /// <param name="p_iNumcontacto">Número</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Drop(DBConn p_dbcAccess,
                               int p_iNumcliente,
                               int p_iNumcontacto,
                               StatMsg p_smResult)
        {
            try {
                // Borramos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..CLICONTACTOS_DROP",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@clc_nro_numcliente", p_iNumcliente),
                                       p_dbcAccess.MakeParam("@clc_nro_numcontacto", p_iNumcontacto),
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
                                   "TNGS_Carm..CLICONTACTOS_FDROP",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@clc_nro_numcliente", p_iNumcliente),
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
                                   "TNGS_Carm..CLICONTACTOS_PACK",
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
                                   "TNGS_Carm..CLICONTACTOS_FPACK",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@clc_nro_numcliente", p_iNumcliente),
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
        /// <param name= "p_iNrocliente">Numero del cliente a borrar sus contactos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int BorraPorCliente(DBConn p_dbcAccess,
                                          int p_iNrocliente,
                                          StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..CLICONTACTOS_BORRAPORCLIENTE",
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
                p_dtResult.Columns["clc_cd1_activo"].Caption= "V1ActivoCN2";
                p_dtResult.Columns["clc_des_rsocial"].Caption= "V1Razon SocialCN1";
                p_dtResult.Columns["clc_des_cargo"].Caption= "V1CargoCN1";
                p_dtResult.Columns["clc_tel_celular"].Caption= "V1CelularCN1";
                p_dtResult.Columns["clc_xld_email"].Caption= "V1EmailCN1";
                p_dtResult.Columns["clc_tel_interno"].Caption= "V1InternoCN1";
                p_dtResult.Columns["clc_des_nombre"].Caption= "V1Apellido y NombreCN1";
                p_dtResult.Columns["clc_nro_numcliente"].Caption= "V1Número de clienteNN1";
                p_dtResult.Columns["clc_nro_numcontacto"].Caption= "V1NúmeroNN2";
                p_dtResult.Columns["clc_des_secretaria"].Caption= "V1SecretariaCN1";
                p_dtResult.Columns["clc_tel_telefono1"].Caption= "V1Teléfono 1CN1";
                p_dtResult.Columns["clc_tel_telefono2"].Caption= "V1Teléfono 2CN1";
                p_dtResult.Columns["clc_des_titulo"].Caption= "V1TítuloCN1";
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
