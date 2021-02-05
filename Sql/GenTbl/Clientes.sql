/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : Clientes
//----------------------------------------------------------------------------
// © 1999-2021 by TNG Software                                      Gndr 5.20
//---------------------------------------------------------------------------*/

/* ***************************************************************************
/  Atencion!!!
/     Este archivo fue generado por un programa en forma automática. Cualquier
/     modificación que se realize sobre él se perderá en la próxima
/     regeneración.
/  **************************************************************************/

/*-------------------------------------------------*/
/* Selecciono la base en la que se creara la tabla */
/*-------------------------------------------------*/

use TNGS_Carm
go

/*-----------------------------------*/
/* Crea la tabla en la base indicada */
/*-----------------------------------*/

print 'Tabla: Clientes'

if exists (select * from sysobjects where id = object_id('dbo.Clientes'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Clientes
end
go

print '   - Creando la nueva tabla'

create table Clientes
   (
      cli_nro_numero tngs_numero,
      cli_ede_rsocial tngs_descripcion_e,
      cli_des_nombrefant tngs_descripcion,
      cli_cod_codtinst tngs_codigo,
      cli_cod_codfrq tngs_codigo,
      cli_cd1_alta tngs_codigo_1,
      cli_tel_telefono1 tngs_telefono,
      cli_tel_celular tngs_telefono,
      cli_tel_telefono2 tngs_telefono,
      cli_tel_fax tngs_telefono,
      cli_ede_direccion tngs_descripcion_e,
      cli_nro_altura tngs_numero,
      cli_rde_piso tngs_descripcion_r,
      cli_rde_oficina tngs_descripcion_r,
      cli_ecd_codlocalidad tngs_codigo_e,
      cli_des_cuil tngs_descripcion,
      cli_xld_url tngs_descripcion_xl,
      cli_cd6_codvend tngs_codigo_6,
      cli_fec_fechaingreso tngs_fecha,
      cli_nro_cantempleados tngs_numero,
      cli_txt_cobertura tngs_texto,
      cli_nom_cargador tngs_nombre,
      cli_txt_observacion tngs_texto,
      cli_xld_email tngs_descripcion_xl,
      cli_nro_nroavalon tngs_numero,
      cli_imp_abono tngs_importe,
      cli_rcd_codtipocont tngs_codigo_r,
      cli_imp_deuda tngs_importe,
      cli_cd1_sexo tngs_codigo_1,
      cli_des_tarjetacred tngs_descripcion,
      cli_cd1_fueclienteantes tngs_codigo_1,
      cli_ede_titular tngs_descripcion_e,
      cli_ede_direccioncobertura tngs_descripcion_e,
      cli_nro_alturacobertura tngs_numero,
      cli_rde_pisocobertura tngs_descripcion_r,
      cli_rde_oficinacobertura tngs_descripcion_r,
      cli_ecd_codloccobertura tngs_codigo_e,
      cli_rcd_codmarca tngs_codigo_r,
      cli_rcd_tipocliente tngs_codigo_r,
      cli_xde_apellido tngs_descripcion_x,
      cli_fec_fechanacimiento tngs_fecha,
      cli_rcd_situacioniva tngs_codigo_r,
      cli_ede_nombre tngs_descripcion_e,
      cli_rcd_codrubro tngs_codigo_r,
      cli_fec_fecultimocontacto tngs_fecha,
      cli_fec_fechaproxcontacto tngs_fecha,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Clientes_pk primary key clustered
      (
         cli_nro_numero
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Clientes to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Clientes
//--------------------------------------------------------------------------*/
