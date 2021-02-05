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
