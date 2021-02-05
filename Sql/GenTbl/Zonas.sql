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
