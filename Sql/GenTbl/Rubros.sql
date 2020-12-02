/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 01/12/2020 21:33
// Base de Datos      : TNGS_Carm
// Tabla              : Rubros
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
