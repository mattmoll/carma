/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 01/12/2020 21:33
// Base de Datos      : TNGS_Carm
// Tabla              : Franquicias
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
