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
