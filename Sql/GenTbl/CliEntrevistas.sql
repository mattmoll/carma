/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 01/12/2020 21:33
// Base de Datos      : TNGS_Carm
// Tabla              : CliEntrevistas
//----------------------------------------------------------------------------
// © 1999-2020 by TNG Software                                      Gndr 5.20
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
