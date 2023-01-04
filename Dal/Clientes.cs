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
    // Fecha                    : 03/01/2023 23:43
    // Sistema                  : Carm
    // Clase para Administrar   : Clientes
    // Basada en la Tabla       : Clientes
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
    /// Modulo DAL de Acceso a la tabla: Clientes
    /// </summary>
    public static class Clientes
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
                                      "TNGS_Carm..CLIENTES_UP",
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
        /// <param name="p_iNumero">Número de cliente</param>
        /// <param name="p_iFxdVersion">Número de version a verificar</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void ChkVersion(DBConn p_dbcAccess,
                                      int p_iNumero,
                                      int p_iFxdVersion,
                                      ref DataSet p_dsResult,
                                      string p_strTabla,
                                      StatMsg p_smResult)
        {
            try {
                // Verificamos el número de versión
                DBRuts.Exec_DS(p_dbcAccess,
                               "TNGS_Carm..CLIENTES_CHKVERSION",
                               new DbParameter[] {
                                   p_dbcAccess.MakeParam("@cli_nro_numero", p_iNumero),
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
        /// <param name="p_iNumero">Número de cliente</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Search(DBConn p_dbcAccess,
                                 int p_iNumero,
                                 bool p_bOnlyActive,
                                 ref DataSet p_dsResult,
                                 string p_strTabla,
                                 StatMsg p_smResult)
        {
            try {
                // Recuperamos el registro de la clave
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Carm..CLIENTES_SEARCH",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@cli_nro_numero", p_iNumero),
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
        /// <param name="p_iNumero">Número de cliente</param>
        /// <param name="p_strRsocial">Razón social</param>
        /// <param name="p_strNombrefant">Nombre de fantasía</param>
        /// <param name="p_strCodtinst">Tipo de Institucion</param>
        /// <param name="p_strCodfrq">Franquicia</param>
        /// <param name="p_strAlta">Alta en Avalon</param>
        /// <param name="p_strTelefono1">Teléfono 1</param>
        /// <param name="p_strCelular">Celular</param>
        /// <param name="p_strTelefono2">Teléfono 2</param>
        /// <param name="p_strFax">Fax</param>
        /// <param name="p_strDireccion">Dirección</param>
        /// <param name="p_iAltura">Altura</param>
        /// <param name="p_strPiso">Piso</param>
        /// <param name="p_strOficina">Oficina</param>
        /// <param name="p_strCodlocalidad">Código de localidad</param>
        /// <param name="p_strCuil">Cuil</param>
        /// <param name="p_strUrl">Url</param>
        /// <param name="p_strCodvend">Código de vendedor</param>
        /// <param name="p_dtFechaingreso">Fecha de ingreso</param>
        /// <param name="p_iCantempleados">Cantidad de Empleados</param>
        /// <param name="p_strCobertura">Cobertura</param>
        /// <param name="p_strCargador">Usuario Cargador</param>
        /// <param name="p_strObservacion">Observacion</param>
        /// <param name="p_strEmail">E-Mail</param>
        /// <param name="p_iNroavalon">Número Avalon</param>
        /// <param name="p_dcAbono">Abono</param>
        /// <param name="p_strCodtipocont">Tipo Contrato</param>
        /// <param name="p_dcDeuda">Deuda</param>
        /// <param name="p_strSexo">Sexo</param>
        /// <param name="p_strTarjetacred">Tarjeta de Crédito</param>
        /// <param name="p_strFueclienteantes">Fue Cliente Antes</param>
        /// <param name="p_strTitular">Titular</param>
        /// <param name="p_strDireccioncobertura">Direccion Cobertura</param>
        /// <param name="p_iAlturacobertura">Altura Cobertura</param>
        /// <param name="p_strPisocobertura">Piso Cobertura</param>
        /// <param name="p_strOficinacobertura">Oficina Cobertura</param>
        /// <param name="p_strCodloccobertura">Localidad Cobertura</param>
        /// <param name="p_strCodmarca">Marca</param>
        /// <param name="p_strTipocliente">Tipo Cliente</param>
        /// <param name="p_dtFechanacimiento">Fecha nacimiento</param>
        /// <param name="p_strSituacioniva">Situacion IVA</param>
        /// <param name="p_strApellido">Apellido</param>
        /// <param name="p_strNombre">Nombre</param>
        /// <param name="p_strCodrubro">Rubro</param>
        /// <param name="p_dtFecultimocontacto">Fecha Último Contacto</param>
        /// <param name="p_dtFechaproxcontacto">Fecha Próximo Contacto</param>
        /// <param name="p_strRellamar">Volver a Llamar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Insert(DBConn p_dbcAccess,
                                 int p_iNumero,
                                 string p_strRsocial,
                                 string p_strNombrefant,
                                 string p_strCodtinst,
                                 string p_strCodfrq,
                                 string p_strAlta,
                                 string p_strTelefono1,
                                 string p_strCelular,
                                 string p_strTelefono2,
                                 string p_strFax,
                                 string p_strDireccion,
                                 int p_iAltura,
                                 string p_strPiso,
                                 string p_strOficina,
                                 string p_strCodlocalidad,
                                 string p_strCuil,
                                 string p_strUrl,
                                 string p_strCodvend,
                                 DateTime p_dtFechaingreso,
                                 int p_iCantempleados,
                                 string p_strCobertura,
                                 string p_strCargador,
                                 string p_strObservacion,
                                 string p_strEmail,
                                 int p_iNroavalon,
                                 decimal p_dcAbono,
                                 string p_strCodtipocont,
                                 decimal p_dcDeuda,
                                 string p_strSexo,
                                 string p_strTarjetacred,
                                 string p_strFueclienteantes,
                                 string p_strTitular,
                                 string p_strDireccioncobertura,
                                 int p_iAlturacobertura,
                                 string p_strPisocobertura,
                                 string p_strOficinacobertura,
                                 string p_strCodloccobertura,
                                 string p_strCodmarca,
                                 string p_strTipocliente,
                                 DateTime p_dtFechanacimiento,
                                 string p_strSituacioniva,
                                 string p_strApellido,
                                 string p_strNombre,
                                 string p_strCodrubro,
                                 DateTime p_dtFecultimocontacto,
                                 DateTime p_dtFechaproxcontacto,
                                 string p_strRellamar,
                                 StatMsg p_smResult)
        {
            try {
                // Insertamos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..CLIENTES_INSERT",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@cli_nro_numero", p_iNumero),
                                       p_dbcAccess.MakeParam("@cli_ede_rsocial", p_strRsocial),
                                       p_dbcAccess.MakeParam("@cli_des_nombrefant", p_strNombrefant),
                                       p_dbcAccess.MakeParam("@cli_cod_codtinst", p_strCodtinst),
                                       p_dbcAccess.MakeParam("@cli_cod_codfrq", p_strCodfrq),
                                       p_dbcAccess.MakeParam("@cli_cd1_alta", p_strAlta),
                                       p_dbcAccess.MakeParam("@cli_tel_telefono1", p_strTelefono1),
                                       p_dbcAccess.MakeParam("@cli_tel_celular", p_strCelular),
                                       p_dbcAccess.MakeParam("@cli_tel_telefono2", p_strTelefono2),
                                       p_dbcAccess.MakeParam("@cli_tel_fax", p_strFax),
                                       p_dbcAccess.MakeParam("@cli_ede_direccion", p_strDireccion),
                                       p_dbcAccess.MakeParam("@cli_nro_altura", p_iAltura),
                                       p_dbcAccess.MakeParam("@cli_rde_piso", p_strPiso),
                                       p_dbcAccess.MakeParam("@cli_rde_oficina", p_strOficina),
                                       p_dbcAccess.MakeParam("@cli_ecd_codlocalidad", p_strCodlocalidad),
                                       p_dbcAccess.MakeParam("@cli_des_cuil", p_strCuil),
                                       p_dbcAccess.MakeParam("@cli_xld_url", p_strUrl),
                                       p_dbcAccess.MakeParam("@cli_cd6_codvend", p_strCodvend),
                                       p_dbcAccess.MakeParamF("@cli_fec_fechaingreso", p_dtFechaingreso),
                                       p_dbcAccess.MakeParam("@cli_nro_cantempleados", p_iCantempleados),
                                       p_dbcAccess.MakeParam("@cli_txt_cobertura", p_strCobertura),
                                       p_dbcAccess.MakeParam("@cli_nom_cargador", p_strCargador),
                                       p_dbcAccess.MakeParam("@cli_txt_observacion", p_strObservacion),
                                       p_dbcAccess.MakeParam("@cli_xld_email", p_strEmail),
                                       p_dbcAccess.MakeParam("@cli_nro_nroavalon", p_iNroavalon),
                                       p_dbcAccess.MakeParam("@cli_imp_abono", p_dcAbono),
                                       p_dbcAccess.MakeParam("@cli_rcd_codtipocont", p_strCodtipocont),
                                       p_dbcAccess.MakeParam("@cli_imp_deuda", p_dcDeuda),
                                       p_dbcAccess.MakeParam("@cli_cd1_sexo", p_strSexo),
                                       p_dbcAccess.MakeParam("@cli_des_tarjetacred", p_strTarjetacred),
                                       p_dbcAccess.MakeParam("@cli_cd1_fueclienteantes", p_strFueclienteantes),
                                       p_dbcAccess.MakeParam("@cli_ede_titular", p_strTitular),
                                       p_dbcAccess.MakeParam("@cli_ede_direccioncobertura", p_strDireccioncobertura),
                                       p_dbcAccess.MakeParam("@cli_nro_alturacobertura", p_iAlturacobertura),
                                       p_dbcAccess.MakeParam("@cli_rde_pisocobertura", p_strPisocobertura),
                                       p_dbcAccess.MakeParam("@cli_rde_oficinacobertura", p_strOficinacobertura),
                                       p_dbcAccess.MakeParam("@cli_ecd_codloccobertura", p_strCodloccobertura),
                                       p_dbcAccess.MakeParam("@cli_rcd_codmarca", p_strCodmarca),
                                       p_dbcAccess.MakeParam("@cli_rcd_tipocliente", p_strTipocliente),
                                       p_dbcAccess.MakeParamF("@cli_fec_fechanacimiento", p_dtFechanacimiento),
                                       p_dbcAccess.MakeParam("@cli_rcd_situacioniva", p_strSituacioniva),
                                       p_dbcAccess.MakeParam("@cli_xde_apellido", p_strApellido),
                                       p_dbcAccess.MakeParam("@cli_ede_nombre", p_strNombre),
                                       p_dbcAccess.MakeParam("@cli_rcd_codrubro", p_strCodrubro),
                                       p_dbcAccess.MakeParamF("@cli_fec_fecultimocontacto", p_dtFecultimocontacto),
                                       p_dbcAccess.MakeParamF("@cli_fec_fechaproxcontacto", p_dtFechaproxcontacto),
                                       p_dbcAccess.MakeParam("@cli_cd1_rellamar", p_strRellamar),
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
        /// <param name="p_iNumero">Número de cliente</param>
        /// <param name="p_strRsocial">Razón social</param>
        /// <param name="p_strNombrefant">Nombre de fantasía</param>
        /// <param name="p_strCodtinst">Tipo de Institucion</param>
        /// <param name="p_strCodfrq">Franquicia</param>
        /// <param name="p_strAlta">Alta en Avalon</param>
        /// <param name="p_strTelefono1">Teléfono 1</param>
        /// <param name="p_strCelular">Celular</param>
        /// <param name="p_strTelefono2">Teléfono 2</param>
        /// <param name="p_strFax">Fax</param>
        /// <param name="p_strDireccion">Dirección</param>
        /// <param name="p_iAltura">Altura</param>
        /// <param name="p_strPiso">Piso</param>
        /// <param name="p_strOficina">Oficina</param>
        /// <param name="p_strCodlocalidad">Código de localidad</param>
        /// <param name="p_strCuil">Cuil</param>
        /// <param name="p_strUrl">Url</param>
        /// <param name="p_strCodvend">Código de vendedor</param>
        /// <param name="p_dtFechaingreso">Fecha de ingreso</param>
        /// <param name="p_iCantempleados">Cantidad de Empleados</param>
        /// <param name="p_strCobertura">Cobertura</param>
        /// <param name="p_strCargador">Usuario Cargador</param>
        /// <param name="p_strObservacion">Observacion</param>
        /// <param name="p_strEmail">E-Mail</param>
        /// <param name="p_iNroavalon">Número Avalon</param>
        /// <param name="p_dcAbono">Abono</param>
        /// <param name="p_strCodtipocont">Tipo Contrato</param>
        /// <param name="p_dcDeuda">Deuda</param>
        /// <param name="p_strSexo">Sexo</param>
        /// <param name="p_strTarjetacred">Tarjeta de Crédito</param>
        /// <param name="p_strFueclienteantes">Fue Cliente Antes</param>
        /// <param name="p_strTitular">Titular</param>
        /// <param name="p_strDireccioncobertura">Direccion Cobertura</param>
        /// <param name="p_iAlturacobertura">Altura Cobertura</param>
        /// <param name="p_strPisocobertura">Piso Cobertura</param>
        /// <param name="p_strOficinacobertura">Oficina Cobertura</param>
        /// <param name="p_strCodloccobertura">Localidad Cobertura</param>
        /// <param name="p_strCodmarca">Marca</param>
        /// <param name="p_strTipocliente">Tipo Cliente</param>
        /// <param name="p_dtFechanacimiento">Fecha nacimiento</param>
        /// <param name="p_strSituacioniva">Situacion IVA</param>
        /// <param name="p_strApellido">Apellido</param>
        /// <param name="p_strNombre">Nombre</param>
        /// <param name="p_strCodrubro">Rubro</param>
        /// <param name="p_dtFecultimocontacto">Fecha Último Contacto</param>
        /// <param name="p_dtFechaproxcontacto">Fecha Próximo Contacto</param>
        /// <param name="p_strRellamar">Volver a Llamar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Update(DBConn p_dbcAccess,
                                 int p_iNumero,
                                 string p_strRsocial,
                                 string p_strNombrefant,
                                 string p_strCodtinst,
                                 string p_strCodfrq,
                                 string p_strAlta,
                                 string p_strTelefono1,
                                 string p_strCelular,
                                 string p_strTelefono2,
                                 string p_strFax,
                                 string p_strDireccion,
                                 int p_iAltura,
                                 string p_strPiso,
                                 string p_strOficina,
                                 string p_strCodlocalidad,
                                 string p_strCuil,
                                 string p_strUrl,
                                 string p_strCodvend,
                                 DateTime p_dtFechaingreso,
                                 int p_iCantempleados,
                                 string p_strCobertura,
                                 string p_strCargador,
                                 string p_strObservacion,
                                 string p_strEmail,
                                 int p_iNroavalon,
                                 decimal p_dcAbono,
                                 string p_strCodtipocont,
                                 decimal p_dcDeuda,
                                 string p_strSexo,
                                 string p_strTarjetacred,
                                 string p_strFueclienteantes,
                                 string p_strTitular,
                                 string p_strDireccioncobertura,
                                 int p_iAlturacobertura,
                                 string p_strPisocobertura,
                                 string p_strOficinacobertura,
                                 string p_strCodloccobertura,
                                 string p_strCodmarca,
                                 string p_strTipocliente,
                                 DateTime p_dtFechanacimiento,
                                 string p_strSituacioniva,
                                 string p_strApellido,
                                 string p_strNombre,
                                 string p_strCodrubro,
                                 DateTime p_dtFecultimocontacto,
                                 DateTime p_dtFechaproxcontacto,
                                 string p_strRellamar,
                                 StatMsg p_smResult)
        {
            try {
                // Modificamos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..CLIENTES_UPDATE",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@cli_nro_numero", p_iNumero),
                                       p_dbcAccess.MakeParam("@cli_ede_rsocial", p_strRsocial),
                                       p_dbcAccess.MakeParam("@cli_des_nombrefant", p_strNombrefant),
                                       p_dbcAccess.MakeParam("@cli_cod_codtinst", p_strCodtinst),
                                       p_dbcAccess.MakeParam("@cli_cod_codfrq", p_strCodfrq),
                                       p_dbcAccess.MakeParam("@cli_cd1_alta", p_strAlta),
                                       p_dbcAccess.MakeParam("@cli_tel_telefono1", p_strTelefono1),
                                       p_dbcAccess.MakeParam("@cli_tel_celular", p_strCelular),
                                       p_dbcAccess.MakeParam("@cli_tel_telefono2", p_strTelefono2),
                                       p_dbcAccess.MakeParam("@cli_tel_fax", p_strFax),
                                       p_dbcAccess.MakeParam("@cli_ede_direccion", p_strDireccion),
                                       p_dbcAccess.MakeParam("@cli_nro_altura", p_iAltura),
                                       p_dbcAccess.MakeParam("@cli_rde_piso", p_strPiso),
                                       p_dbcAccess.MakeParam("@cli_rde_oficina", p_strOficina),
                                       p_dbcAccess.MakeParam("@cli_ecd_codlocalidad", p_strCodlocalidad),
                                       p_dbcAccess.MakeParam("@cli_des_cuil", p_strCuil),
                                       p_dbcAccess.MakeParam("@cli_xld_url", p_strUrl),
                                       p_dbcAccess.MakeParam("@cli_cd6_codvend", p_strCodvend),
                                       p_dbcAccess.MakeParamF("@cli_fec_fechaingreso", p_dtFechaingreso),
                                       p_dbcAccess.MakeParam("@cli_nro_cantempleados", p_iCantempleados),
                                       p_dbcAccess.MakeParam("@cli_txt_cobertura", p_strCobertura),
                                       p_dbcAccess.MakeParam("@cli_nom_cargador", p_strCargador),
                                       p_dbcAccess.MakeParam("@cli_txt_observacion", p_strObservacion),
                                       p_dbcAccess.MakeParam("@cli_xld_email", p_strEmail),
                                       p_dbcAccess.MakeParam("@cli_nro_nroavalon", p_iNroavalon),
                                       p_dbcAccess.MakeParam("@cli_imp_abono", p_dcAbono),
                                       p_dbcAccess.MakeParam("@cli_rcd_codtipocont", p_strCodtipocont),
                                       p_dbcAccess.MakeParam("@cli_imp_deuda", p_dcDeuda),
                                       p_dbcAccess.MakeParam("@cli_cd1_sexo", p_strSexo),
                                       p_dbcAccess.MakeParam("@cli_des_tarjetacred", p_strTarjetacred),
                                       p_dbcAccess.MakeParam("@cli_cd1_fueclienteantes", p_strFueclienteantes),
                                       p_dbcAccess.MakeParam("@cli_ede_titular", p_strTitular),
                                       p_dbcAccess.MakeParam("@cli_ede_direccioncobertura", p_strDireccioncobertura),
                                       p_dbcAccess.MakeParam("@cli_nro_alturacobertura", p_iAlturacobertura),
                                       p_dbcAccess.MakeParam("@cli_rde_pisocobertura", p_strPisocobertura),
                                       p_dbcAccess.MakeParam("@cli_rde_oficinacobertura", p_strOficinacobertura),
                                       p_dbcAccess.MakeParam("@cli_ecd_codloccobertura", p_strCodloccobertura),
                                       p_dbcAccess.MakeParam("@cli_rcd_codmarca", p_strCodmarca),
                                       p_dbcAccess.MakeParam("@cli_rcd_tipocliente", p_strTipocliente),
                                       p_dbcAccess.MakeParamF("@cli_fec_fechanacimiento", p_dtFechanacimiento),
                                       p_dbcAccess.MakeParam("@cli_rcd_situacioniva", p_strSituacioniva),
                                       p_dbcAccess.MakeParam("@cli_xde_apellido", p_strApellido),
                                       p_dbcAccess.MakeParam("@cli_ede_nombre", p_strNombre),
                                       p_dbcAccess.MakeParam("@cli_rcd_codrubro", p_strCodrubro),
                                       p_dbcAccess.MakeParamF("@cli_fec_fecultimocontacto", p_dtFecultimocontacto),
                                       p_dbcAccess.MakeParamF("@cli_fec_fechaproxcontacto", p_dtFechaproxcontacto),
                                       p_dbcAccess.MakeParam("@cli_cd1_rellamar", p_strRellamar),
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
        /// <param name="p_iNumero">Número de cliente</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Delete(DBConn p_dbcAccess,
                                 int p_iNumero,
                                 StatMsg p_smResult)
        {
            try {
                // Borramos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..CLIENTES_DELETE",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@cli_nro_numero", p_iNumero),
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
        /// <param name="p_iNumero">Número de cliente</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Recall(DBConn p_dbcAccess,
                                 int p_iNumero,
                                 StatMsg p_smResult)
        {
            try {
                // Borramos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..CLIENTES_RECALL",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@cli_nro_numero", p_iNumero),
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
        /// <param name="p_iNumero">Número de cliente</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Drop(DBConn p_dbcAccess,
                               int p_iNumero,
                               StatMsg p_smResult)
        {
            try {
                // Borramos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..CLIENTES_DROP",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@cli_nro_numero", p_iNumero),
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
                                   "TNGS_Carm..CLIENTES_PACK",
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
        /// Método Fijo: BajaYBorraServicios
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= "p_iNrocliente">Numero de Cliente</param>
        /// <param name= "p_iCantdiascancel">Tope Cantidad de Dias Cancelacion Servicio</param>
        /// <param name= "p_strCodcompetencia">Codigo de Competencia</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int BajaYBorraServicios(DBConn p_dbcAccess,
                                              int p_iNrocliente,
                                              int p_iCantdiascancel,
                                              string p_strCodcompetencia,
                                              StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..CLIENTES_BAJAYBORRASERVICIOS",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@nrocliente", p_iNrocliente),
                                       p_dbcAccess.MakeParam("@cantdiascancel", p_iCantdiascancel),
                                       p_dbcAccess.MakeParam("@codcompetencia", p_strCodcompetencia),
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
        /// Método Fijo: BorraEntrevistasPend
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= "p_iNumcliente">Numero de Cliente</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int BorraEntrevistasPend(DBConn p_dbcAccess,
                                               int p_iNumcliente,
                                               StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..CLIENTES_BORRAENTREVISTASPEND",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@numcliente", p_iNumcliente),
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
        /// Método Fijo: CambiarMarcaVendido
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= "p_strValoralta">Valor Alta (S/N)</param>
        /// <param name= "p_iNrocliente">Numero de CLiente</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int CambiarMarcaVendido(DBConn p_dbcAccess,
                                              string p_strValoralta,
                                              int p_iNrocliente,
                                              StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..CLIENTES_CAMBIARMARCAVENDIDO",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@valoralta", p_strValoralta),
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
        /// Método Fijo: GetFromNroAvln
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= "p_iNroavalon">Numero de Avalon</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int GetFromNroAvln(DBConn p_dbcAccess,
                                         int p_iNroavalon,
                                         ref DataSet p_dsResult,
                                         string p_strTabla,
                                         StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Carm..CLIENTES_GETFROMNROAVLN",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@nroavalon", p_iNroavalon),
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
        /// Método Fijo: GetPorClaveAvalon
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= "p_iNroavalon">Numero de Avalon</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int GetPorClaveAvalon(DBConn p_dbcAccess,
                                            int p_iNroavalon,
                                            ref DataSet p_dsResult,
                                            string p_strTabla,
                                            StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Carm..CLIENTES_GETPORCLAVEAVALON",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@nroavalon", p_iNroavalon),
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
        /// Método Fijo: GetRSocialCliente
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= "p_iNumcliente">Número de cliente</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int GetRSocialCliente(DBConn p_dbcAccess,
                                            int p_iNumcliente,
                                            ref DataSet p_dsResult,
                                            string p_strTabla,
                                            StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Carm..CLIENTES_GETRSOCIALCLIENTE",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@numcliente", p_iNumcliente),
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
        /// Método Fijo: GetSinCodVend
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= "p_iNumero">Numero del cliente</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int GetSinCodVend(DBConn p_dbcAccess,
                                        int p_iNumero,
                                        ref DataSet p_dsResult,
                                        string p_strTabla,
                                        StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Carm..CLIENTES_GETSINCODVEND",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@numero", p_iNumero),
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
        /// Método Fijo: GetTodosLosClientes
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int GetTodosLosClientes(DBConn p_dbcAccess,
                                              ref DataSet p_dsResult,
                                              string p_strTabla,
                                              StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Carm..CLIENTES_GETTODOSLOSCLIENTES",
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
        /// Método Fijo: GetVendidos
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= "p_strCodvend">Codigo de Vendedor</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int GetVendidos(DBConn p_dbcAccess,
                                      string p_strCodvend,
                                      ref DataSet p_dsResult,
                                      string p_strTabla,
                                      StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Carm..CLIENTES_GETVENDIDOS",
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
        /// Método Fijo: UpdateAbono
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= "p_iNrocliente">Numero de Cliente</param>
        /// <param name= "p_dcNuevoabono">Nuevo Abono</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int UpdateAbono(DBConn p_dbcAccess,
                                      int p_iNrocliente,
                                      decimal p_dcNuevoabono,
                                      StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..CLIENTES_UPDATEABONO",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@nrocliente", p_iNrocliente),
                                       p_dbcAccess.MakeParam("@nuevoabono", p_dcNuevoabono),
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
        /// Método Fijo: ValidaDir
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= "p_strDir">Direccion del nuevo Cliente</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int ValidaDir(DBConn p_dbcAccess,
                                    string p_strDir,
                                    ref DataSet p_dsResult,
                                    string p_strTabla,
                                    StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Carm..CLIENTES_VALIDADIR",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@dir", p_strDir),
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
        /// Método Fijo: ValidaRSocial
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= "p_strRazonsocial">Razon Social del Nuevo Cliente</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int ValidaRSocial(DBConn p_dbcAccess,
                                        string p_strRazonsocial,
                                        ref DataSet p_dsResult,
                                        string p_strTabla,
                                        StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Carm..CLIENTES_VALIDARSOCIAL",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@razonsocial", p_strRazonsocial),
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
        /// Método Fijo: ValidaTelefono
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= "p_strTelefono">Telefono del Nuevo Cliente</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int ValidaTelefono(DBConn p_dbcAccess,
                                         string p_strTelefono,
                                         ref DataSet p_dsResult,
                                         string p_strTabla,
                                         StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Carm..CLIENTES_VALIDATELEFONO",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@telefono", p_strTelefono),
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
        /// Método Fijo: ValidarExistenciaAvl
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= "p_iNroavalon">Numero de Avalon</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int ValidarExistenciaAvl(DBConn p_dbcAccess,
                                               int p_iNroavalon,
                                               ref DataSet p_dsResult,
                                               string p_strTabla,
                                               StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Carm..CLIENTES_VALIDAREXISTENCIAAVL",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@nroavalon", p_iNroavalon),
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
        /// Método Fijo: Vendido
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= "p_iNumero">Numero del Cliente</param>
        /// <param name= "p_dcAbono">Abono vendido</param>
        /// <param name= "p_strCodtipocont">Cod Tipo de Contrato Vendido</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Vendido(DBConn p_dbcAccess,
                                  int p_iNumero,
                                  decimal p_dcAbono,
                                  string p_strCodtipocont,
                                  StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Carm..CLIENTES_VENDIDO",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@numero", p_iNumero),
                                       p_dbcAccess.MakeParam("@abono", p_dcAbono),
                                       p_dbcAccess.MakeParam("@codtipocont", p_strCodtipocont),
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
        /// Método Fijo: ZCargadores
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= "p_dtFechaini">Fecha Inicio</param>
        /// <param name= "p_dtFechafin">Fecha Fin</param>
        /// <param name= "p_strIninomcargador">Inicio Nombre cargador</param>
        /// <param name= "p_strFinnomcargador">Fin Nombre cargador</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int ZCargadores(DBConn p_dbcAccess,
                                      DateTime p_dtFechaini,
                                      DateTime p_dtFechafin,
                                      string p_strIninomcargador,
                                      string p_strFinnomcargador,
                                      ref DataSet p_dsResult,
                                      string p_strTabla,
                                      StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Carm..CLIENTES_ZCARGADORES",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParamF("@fechaini", p_dtFechaini),
                                          p_dbcAccess.MakeParamF("@fechafin", p_dtFechafin),
                                          p_dbcAccess.MakeParam("@ininomcargador", p_strIninomcargador),
                                          p_dbcAccess.MakeParam("@finnomcargador", p_strFinnomcargador),
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
        /// Método Fijo: ZLog
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= "p_strIninomusuario">Inicio nombre usuario</param>
        /// <param name= "p_strFinnomusuario">Fin nombre usuario</param>
        /// <param name= "p_dtFechaini">Fecha Inicio</param>
        /// <param name= "p_dtFechafin">Fecha Fin</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int ZLog(DBConn p_dbcAccess,
                               string p_strIninomusuario,
                               string p_strFinnomusuario,
                               DateTime p_dtFechaini,
                               DateTime p_dtFechafin,
                               ref DataSet p_dsResult,
                               string p_strTabla,
                               StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Carm..CLIENTES_ZLOG",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@ininomusuario", p_strIninomusuario),
                                          p_dbcAccess.MakeParam("@finnomusuario", p_strFinnomusuario),
                                          p_dbcAccess.MakeParam("@fechaini", p_dtFechaini),
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
                p_dtResult.Columns["cli_des_frq"].Caption= "V1FranquiciaCN1";
                p_dtResult.Columns["cli_des_loc"].Caption= "V1LocalidadCN1";
                p_dtResult.Columns["cli_des_prov"].Caption= "V1ProvinciaCN1";
                p_dtResult.Columns["cli_des_tinst"].Caption= "V1T InstitucionCN1";
                p_dtResult.Columns["cli_des_zona"].Caption= "V1ZonaCN1";
                p_dtResult.Columns["cli_ede_partido"].Caption= "V1PartidoCN1";
                p_dtResult.Columns["cli_rcd_codzona"].Caption= "V1ZonaCN1";
                p_dtResult.Columns["cli_cod_codfrq"].Caption= "V1FranquiciaCN1";
                p_dtResult.Columns["cli_ecd_codlocalidad"].Caption= "V1Código de localidadCN1";
                p_dtResult.Columns["cli_cod_codtinst"].Caption= "V1Tipo de InstitucionCN1";
                p_dtResult.Columns["cli_cd6_codvend"].Caption= "V1Código de vendedorCN1";
                p_dtResult.Columns["cli_des_nombrefant"].Caption= "V1Nombre de fantasíaCN1";
                p_dtResult.Columns["cli_cd1_rellamar"].Caption= "V1Volver a LlamarCN1";
                p_dtResult.Columns["cli_ede_rsocial"].Caption= "V1Razón socialCN1";
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
