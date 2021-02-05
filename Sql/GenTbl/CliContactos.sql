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
