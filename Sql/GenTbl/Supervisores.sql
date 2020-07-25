/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 25/07/2020 18:48
// Base de Datos      : TNGS_Carm
// Tabla              : Supervisores
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
