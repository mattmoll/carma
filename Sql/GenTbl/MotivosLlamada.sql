/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 25/07/2020 18:48
// Base de Datos      : TNGS_Carm
// Tabla              : MotivosLlamada
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
