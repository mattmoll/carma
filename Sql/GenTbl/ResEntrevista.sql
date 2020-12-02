/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 01/12/2020 21:33
// Base de Datos      : TNGS_Carm
// Tabla              : ResEntrevista
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
