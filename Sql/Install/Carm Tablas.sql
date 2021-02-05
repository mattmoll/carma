/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : CategoriasLlamada
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

print 'Tabla: CategoriasLlamada'

if exists (select * from sysobjects where id = object_id('dbo.CategoriasLlamada'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.CategoriasLlamada
end
go

print '   - Creando la nueva tabla'

create table CategoriasLlamada
   (
      ctl_rcd_cod tngs_codigo_r,
      ctl_des_des tngs_descripcion,
      ctl_cd1_tipo tngs_codigo_1,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint CategoriasLlamada_pk primary key clustered
      (
         ctl_rcd_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on CategoriasLlamada to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: CategoriasLlamada
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : CliContactos
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

print 'Tabla: CliContactos'

if exists (select * from sysobjects where id = object_id('dbo.CliContactos'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.CliContactos
end
go

print '   - Creando la nueva tabla'

create table CliContactos
   (
      clc_nro_numcliente tngs_numero,
      clc_nro_numcontacto tngs_numero,
      clc_des_nombre tngs_descripcion,
      clc_des_cargo tngs_descripcion,
      clc_des_titulo tngs_descripcion,
      clc_tel_celular tngs_telefono,
      clc_tel_telefono1 tngs_telefono,
      clc_tel_telefono2 tngs_telefono,
      clc_tel_interno tngs_telefono,
      clc_xld_email tngs_descripcion_xl,
      clc_des_secretaria tngs_descripcion,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint CliContactos_pk primary key clustered
      (
         clc_nro_numcliente,
         clc_nro_numcontacto
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on CliContactos to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: CliContactos
//--------------------------------------------------------------------------*/
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
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : CliEntrevistas
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

print 'Tabla: CliEntrevistas'

if exists (select * from sysobjects where id = object_id('dbo.CliEntrevistas'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.CliEntrevistas
end
go

print '   - Creando la nueva tabla'

create table CliEntrevistas
   (
      cle_nro_numcliente tngs_numero,
      cle_nro_numentrev tngs_numero,
      cle_fyh_fcoordinada tngs_fecyhor,
      cle_fyh_frealizada tngs_fecyhor,
      cle_cd6_codvend tngs_codigo_6,
      cle_ede_motcambiof tngs_descripcion_e,
      cle_des_nombre tngs_descripcion,
      cle_tel_telefono tngs_telefono,
      cle_des_cargo tngs_descripcion,
      cle_des_titulo tngs_descripcion,
      cle_tel_celular tngs_telefono,
      cle_xld_email tngs_descripcion_xl,
      cle_xld_direccion tngs_descripcion_xl,
      cle_txt_observaciones tngs_texto,
      cle_rcd_codresultado tngs_codigo_r,
      cle_ede_informe tngs_descripcion_e,
      cle_des_secretaria tngs_descripcion,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint CliEntrevistas_pk primary key clustered
      (
         cle_nro_numcliente,
         cle_nro_numentrev
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on CliEntrevistas to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: CliEntrevistas
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : CliGrupoFamiliar
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

print 'Tabla: CliGrupoFamiliar'

if exists (select * from sysobjects where id = object_id('dbo.CliGrupoFamiliar'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.CliGrupoFamiliar
end
go

print '   - Creando la nueva tabla'

create table CliGrupoFamiliar
   (
      cgf_nro_numcliente tngs_numero,
      cgf_nro_numintegrante tngs_numero,
      cgf_ede_apellido tngs_descripcion_e,
      cgf_ede_nombre tngs_descripcion_e,
      cgf_rcd_codparentesco tngs_codigo_r,
      cgf_d20_dni tngs_descripcion_20,
      cgf_fec_fechanacimiento tngs_fecha,
      cgf_ede_obrasocial tngs_descripcion_e,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint CliGrupoFamiliar_pk primary key clustered
      (
         cgf_nro_numcliente,
         cgf_nro_numintegrante
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on CliGrupoFamiliar to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: CliGrupoFamiliar
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : CliLlamadas
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

print 'Tabla: CliLlamadas'

if exists (select * from sysobjects where id = object_id('dbo.CliLlamadas'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.CliLlamadas
end
go

print '   - Creando la nueva tabla'

create table CliLlamadas
   (
      cll_nro_numcliente tngs_numero,
      cll_nro_numllamada tngs_numero,
      cll_cod_codmotivo tngs_codigo,
      cll_fyh_frealizada tngs_fecyhor,
      cll_txt_resultado tngs_texto,
      cll_nom_codusuario tngs_nombre,
      cll_cd1_baja tngs_codigo_1,
      cll_nro_numcontacto tngs_numero,
      cll_txt_obsprogramada tngs_texto,
      cll_imp_abonoanterior tngs_importe,
      cll_imp_abonorecuperado tngs_importe,
      cll_nom_programador tngs_nombre,
      cll_imp_ajuste tngs_importe,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint CliLlamadas_pk primary key clustered
      (
         cll_nro_numcliente,
         cll_nro_numllamada
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on CliLlamadas to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: CliLlamadas
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : CliNotas
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

print 'Tabla: CliNotas'

if exists (select * from sysobjects where id = object_id('dbo.CliNotas'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.CliNotas
end
go

print '   - Creando la nueva tabla'

create table CliNotas
   (
      cln_nro_numcliente tngs_numero,
      cln_fyh_fechayhora tngs_fecyhor,
      cln_des_titulo tngs_descripcion,
      cln_xld_texto tngs_descripcion_xl,
      cln_cd1_tipo tngs_codigo_1,
      cln_nom_escritor tngs_nombre,
      cln_nom_removedor tngs_nombre,
      cln_fyh_fyhremovida tngs_fecyhor,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint CliNotas_pk primary key clustered
      (
         cln_nro_numcliente,
         cln_fyh_fechayhora
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on CliNotas to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: CliNotas
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : CliServicios
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

print 'Tabla: CliServicios'

if exists (select * from sysobjects where id = object_id('dbo.CliServicios'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.CliServicios
end
go

print '   - Creando la nueva tabla'

create table CliServicios
   (
      cls_nro_numcliente tngs_numero,
      cls_nro_item tngs_numero,
      cls_cod_codservicio tngs_codigo,
      cls_imp_coseguro tngs_importe,
      cls_imp_valorprestacion tngs_importe,
      cls_nro_cantestprestaciones tngs_numero,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint CliServicios_pk primary key clustered
      (
         cls_nro_numcliente,
         cls_nro_item
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on CliServicios to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: CliServicios
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : CliVentas
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

print 'Tabla: CliVentas'

if exists (select * from sysobjects where id = object_id('dbo.CliVentas'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.CliVentas
end
go

print '   - Creando la nueva tabla'

create table CliVentas
   (
      clv_nro_numcliente tngs_numero,
      clv_fyh_fecha tngs_fecyhor,
      clv_cd6_codvendedor tngs_codigo_6,
      clv_rcd_codtipocontrato tngs_codigo_r,
      clv_imp_abono tngs_importe,
      clv_nro_cantcapitas tngs_numero,
      clv_imp_valorcapita tngs_importe,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint CliVentas_pk primary key clustered
      (
         clv_nro_numcliente,
         clv_fyh_fecha
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on CliVentas to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: CliVentas
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : ConversionColores
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

print 'Tabla: ConversionColores'

if exists (select * from sysobjects where id = object_id('dbo.ConversionColores'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.ConversionColores
end
go

print '   - Creando la nueva tabla'

create table ConversionColores
   (
      con_cod_cod tngs_codigo,
      con_des_coloraconvertir tngs_descripcion,
      con_cd1_colorconvertido tngs_codigo_1,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint ConversionColores_pk primary key clustered
      (
         con_cod_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on ConversionColores to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: ConversionColores
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : Franquicias
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

print 'Tabla: Franquicias'

if exists (select * from sysobjects where id = object_id('dbo.Franquicias'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Franquicias
end
go

print '   - Creando la nueva tabla'

create table Franquicias
   (
      frq_cod_cod tngs_codigo,
      frq_des_des tngs_descripcion,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Franquicias_pk primary key clustered
      (
         frq_cod_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Franquicias to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Franquicias
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : Localidades
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

print 'Tabla: Localidades'

if exists (select * from sysobjects where id = object_id('dbo.Localidades'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Localidades
end
go

print '   - Creando la nueva tabla'

create table Localidades
   (
      loc_ecd_codpost tngs_codigo_e,
      loc_ede_nombre tngs_descripcion_e,
      loc_rcd_codzona tngs_codigo_r,
      loc_ede_partido tngs_descripcion_e,
      loc_des_provincia tngs_descripcion,
      loc_ede_nomgoogle tngs_descripcion_e,
      loc_cd1_directa tngs_codigo_1,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Localidades_pk primary key clustered
      (
         loc_ecd_codpost
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Localidades to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Localidades
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : LogClientes
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

print 'Tabla: LogClientes'

if exists (select * from sysobjects where id = object_id('dbo.LogClientes'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.LogClientes
end
go

print '   - Creando la nueva tabla'

create table LogClientes
   (
      lgc_nro_nro tngs_numero,
      lgc_nro_nrocliente tngs_numero,
      lgc_nro_nroavalon tngs_numero,
      lgc_ede_rsocial tngs_descripcion_e,
      lgc_des_nomfantasia tngs_descripcion,
      lgc_des_accion tngs_descripcion,
      lgc_nom_usuario tngs_nombre,
      lgc_fyh_fecha tngs_fecyhor,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint LogClientes_pk primary key clustered
      (
         lgc_nro_nro
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on LogClientes to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: LogClientes
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : Marcas
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

print 'Tabla: Marcas'

if exists (select * from sysobjects where id = object_id('dbo.Marcas'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Marcas
end
go

print '   - Creando la nueva tabla'

create table Marcas
   (
      mrc_rcd_cod tngs_codigo_r,
      mrc_ede_des tngs_descripcion_e,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Marcas_pk primary key clustered
      (
         mrc_rcd_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Marcas to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Marcas
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : MotivosLlamada
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

print 'Tabla: MotivosLlamada'

if exists (select * from sysobjects where id = object_id('dbo.MotivosLlamada'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.MotivosLlamada
end
go

print '   - Creando la nueva tabla'

create table MotivosLlamada
   (
      mot_cod_cod tngs_codigo,
      mot_des_des tngs_descripcion,
      mot_rcd_codcategoria tngs_codigo_r,
      mot_cd1_esreclamo tngs_codigo_1,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint MotivosLlamada_pk primary key clustered
      (
         mot_cod_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on MotivosLlamada to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: MotivosLlamada
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : Parametros
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

print 'Tabla: Parametros'

if exists (select * from sysobjects where id = object_id('dbo.Parametros'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Parametros
end
go

print '   - Creando la nueva tabla'

create table Parametros
   (
      par_xcd_codigo tngs_codigo_x,
      par_des_descripcion tngs_descripcion,
      par_xde_valor tngs_descripcion_x,
      par_est_editable tngs_estado,
      par_est_sololectura tngs_estado,
      par_rob_detalle tngs_observaciones_r,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Parametros_pk primary key clustered
      (
         par_xcd_codigo
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Parametros to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Parametros
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : Parentescos
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

print 'Tabla: Parentescos'

if exists (select * from sysobjects where id = object_id('dbo.Parentescos'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Parentescos
end
go

print '   - Creando la nueva tabla'

create table Parentescos
   (
      prt_rcd_cod tngs_codigo_r,
      prt_des_des tngs_descripcion,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Parentescos_pk primary key clustered
      (
         prt_rcd_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Parentescos to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Parentescos
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : Planes
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

print 'Tabla: Planes'

if exists (select * from sysobjects where id = object_id('dbo.Planes'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Planes
end
go

print '   - Creando la nueva tabla'

create table Planes
   (
      pln_cod_cod tngs_codigo,
      pln_des_des tngs_descripcion,
      pln_cod_codplanavalon tngs_codigo,
      pln_d80_tcontratoavalon tngs_descripcion_80,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Planes_pk primary key clustered
      (
         pln_cod_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Planes to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Planes
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : PlnServicios
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

print 'Tabla: PlnServicios'

if exists (select * from sysobjects where id = object_id('dbo.PlnServicios'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.PlnServicios
end
go

print '   - Creando la nueva tabla'

create table PlnServicios
   (
      pls_cod_codplan tngs_codigo,
      pls_cod_codservicio tngs_codigo,
      pls_nro_cprestlibres tngs_numero,
      pls_imp_valorprestacion tngs_importe,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint PlnServicios_pk primary key clustered
      (
         pls_cod_codplan,
         pls_cod_codservicio
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on PlnServicios to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: PlnServicios
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : PreciosServicios
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

print 'Tabla: PreciosServicios'

if exists (select * from sysobjects where id = object_id('dbo.PreciosServicios'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.PreciosServicios
end
go

print '   - Creando la nueva tabla'

create table PreciosServicios
   (
      prs_cd1_color tngs_codigo_1,
      prs_fec_fecha tngs_fecha,
      prs_imp_precio tngs_importe,
      prs_imp_coseguro tngs_importe,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint PreciosServicios_pk primary key clustered
      (
         prs_cd1_color,
         prs_fec_fecha
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on PreciosServicios to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: PreciosServicios
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : ResEntrevista
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

print 'Tabla: ResEntrevista'

if exists (select * from sysobjects where id = object_id('dbo.ResEntrevista'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.ResEntrevista
end
go

print '   - Creando la nueva tabla'

create table ResEntrevista
   (
      ren_rcd_cod tngs_codigo_r,
      ren_des_des tngs_descripcion,
      ren_cd1_codfiltro tngs_codigo_1,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint ResEntrevista_pk primary key clustered
      (
         ren_rcd_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on ResEntrevista to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: ResEntrevista
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : Rubros
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

print 'Tabla: Rubros'

if exists (select * from sysobjects where id = object_id('dbo.Rubros'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Rubros
end
go

print '   - Creando la nueva tabla'

create table Rubros
   (
      rbr_rcd_cod tngs_codigo_r,
      rbr_des_des tngs_descripcion,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Rubros_pk primary key clustered
      (
         rbr_rcd_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Rubros to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Rubros
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : Servicios
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

print 'Tabla: Servicios'

if exists (select * from sysobjects where id = object_id('dbo.Servicios'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Servicios
end
go

print '   - Creando la nueva tabla'

create table Servicios
   (
      srv_cod_cod tngs_codigo,
      srv_des_des tngs_descripcion,
      srv_xld_explicacion tngs_descripcion_xl,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Servicios_pk primary key clustered
      (
         srv_cod_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Servicios to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Servicios
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : SituacionesIVA
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

print 'Tabla: SituacionesIVA'

if exists (select * from sysobjects where id = object_id('dbo.SituacionesIVA'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.SituacionesIVA
end
go

print '   - Creando la nueva tabla'

create table SituacionesIVA
   (
      siv_rcd_codigo tngs_codigo_r,
      siv_des_descripcion tngs_descripcion,
      siv_cd1_discrimina tngs_codigo_1,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint SituacionesIVA_pk primary key clustered
      (
         siv_rcd_codigo
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on SituacionesIVA to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: SituacionesIVA
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : Supervisores
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

print 'Tabla: Supervisores'

if exists (select * from sysobjects where id = object_id('dbo.Supervisores'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Supervisores
end
go

print '   - Creando la nueva tabla'

create table Supervisores
   (
      sup_cd6_cod tngs_codigo_6,
      sup_nom_apellido tngs_nombre,
      sup_nom_nombre tngs_nombre,
      sup_nom_usuario tngs_nombre,
      sup_tel_tel tngs_telefono,
      sup_tel_cel tngs_telefono,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Supervisores_pk primary key clustered
      (
         sup_cd6_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Supervisores to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Supervisores
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : Talonarios
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

print 'Tabla: Talonarios'

if exists (select * from sysobjects where id = object_id('dbo.Talonarios'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Talonarios
end
go

print '   - Creando la nueva tabla'

create table Talonarios
   (
      tal_xcd_codigo tngs_codigo_x,
      tal_des_descripcion tngs_descripcion,
      tal_cd1_tipo tngs_codigo_1,
      tal_nro_valor tngs_numero,
      tal_fyh_referencia tngs_fecyhor,
      tal_rob_detalle tngs_observaciones_r,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Talonarios_pk primary key clustered
      (
         tal_xcd_codigo
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Talonarios to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Talonarios
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : TipoCont
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

print 'Tabla: TipoCont'

if exists (select * from sysobjects where id = object_id('dbo.TipoCont'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.TipoCont
end
go

print '   - Creando la nueva tabla'

create table TipoCont
   (
      tcn_rcd_cod tngs_codigo_r,
      tcn_des_des tngs_descripcion,
      tcn_cd1_modo tngs_codigo_1,
      tcn_rcd_tcontratoavalon tngs_codigo_r,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint TipoCont_pk primary key clustered
      (
         tcn_rcd_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on TipoCont to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: TipoCont
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : TipoInst
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

print 'Tabla: TipoInst'

if exists (select * from sysobjects where id = object_id('dbo.TipoInst'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.TipoInst
end
go

print '   - Creando la nueva tabla'

create table TipoInst
   (
      tin_cod_cod tngs_codigo,
      tin_des_des tngs_descripcion,
      tin_rcd_codrubro tngs_codigo_r,
      tin_cd1_mayorista tngs_codigo_1,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint TipoInst_pk primary key clustered
      (
         tin_cod_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on TipoInst to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: TipoInst
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : TipoVend
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

print 'Tabla: TipoVend'

if exists (select * from sysobjects where id = object_id('dbo.TipoVend'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.TipoVend
end
go

print '   - Creando la nueva tabla'

create table TipoVend
   (
      tvn_rcd_cod tngs_codigo_r,
      tvn_des_des tngs_descripcion,
      tvn_cd1_vemayor tngs_codigo_1,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint TipoVend_pk primary key clustered
      (
         tvn_rcd_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on TipoVend to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: TipoVend
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : Vendedores
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

print 'Tabla: Vendedores'

if exists (select * from sysobjects where id = object_id('dbo.Vendedores'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Vendedores
end
go

print '   - Creando la nueva tabla'

create table Vendedores
   (
      vnd_cd6_cod tngs_codigo_6,
      vnd_des_apellido tngs_descripcion,
      vnd_des_nombre tngs_descripcion,
      vnd_nom_usuario tngs_nombre,
      vnd_tel_tel1 tngs_telefono,
      vnd_tel_celular tngs_telefono,
      vnd_tel_tel2 tngs_telefono,
      vnd_fec_fecnacim tngs_fecha,
      vnd_ede_direccion tngs_descripcion_e,
      vnd_cd6_codsuperv tngs_codigo_6,
      vnd_rcd_codtvend tngs_codigo_r,
      vnd_txt_horarios tngs_texto,
      vnd_cd1_historico tngs_codigo_1,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Vendedores_pk primary key clustered
      (
         vnd_cd6_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Vendedores to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Vendedores
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : Zonas
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

print 'Tabla: Zonas'

if exists (select * from sysobjects where id = object_id('dbo.Zonas'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Zonas
end
go

print '   - Creando la nueva tabla'

create table Zonas
   (
      zns_rcd_cod tngs_codigo_r,
      zns_des_nombre tngs_descripcion,
      zns_txt_geoloc tngs_texto,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Zonas_pk primary key clustered
      (
         zns_rcd_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Zonas to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Zonas
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Indices)                    
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

/*-----------------------------------------------------*/
/* Selecciono la base en la que se crearan los indices */
/*-----------------------------------------------------*/

use TNGS_Carm
go

/*-----------------------------------------------
// Crea el indice: is1
//-----------------------------------------------*/

print 'Indice: Clientes_is1'

print '    - Creando el nuevo indice'

create index Clientes_is1 on Clientes
   (
       cli_cd6_codvend
   )
go

print '  '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los indices de la tabla: Clientes
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Indices)                    
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : CliEntrevistas
//----------------------------------------------------------------------------
// © 1999-2021 by TNG Software                                      Gndr 5.20
//---------------------------------------------------------------------------*/

/* ***************************************************************************
/  Atencion!!!
/     Este archivo fue generado por un programa en forma automática. Cualquier
/     modificación que se realize sobre él se perderá en la próxima
/     regeneración.
/  **************************************************************************/

/*-----------------------------------------------------*/
/* Selecciono la base en la que se crearan los indices */
/*-----------------------------------------------------*/

use TNGS_Carm
go

/*-----------------------------------------------
// Crea el indice: is1
//-----------------------------------------------*/

print 'Indice: CliEntrevistas_is1'

print '    - Creando el nuevo indice'

create index CliEntrevistas_is1 on CliEntrevistas
   (
       cle_cd6_codvend,cle_fyh_fcoordinada
   )
go

print '  '
go

/*-----------------------------------------------
// Crea el indice: is2
//-----------------------------------------------*/

print 'Indice: CliEntrevistas_is2'

print '    - Creando el nuevo indice'

create index CliEntrevistas_is2 on CliEntrevistas
   (
       cle_fyh_frealizada
   )
go

print '  '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los indices de la tabla: CliEntrevistas
//--------------------------------------------------------------------------*/
