/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 25/07/2020 18:48
// Base de Datos      : TNGS_Carm
// Tabla              : CliServicios
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

print 'Tabla: CliServicios'

if exists (select * from sysobjects where id = object_id('dbo.CliServicios'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.CliServicios
end
go

print '   - Creando la nueva tabla'

create table CliServicios
   (
      cls_nro_numcliente tngs_numero,
      cls_nro_item tngs_numero,
      cls_cod_codservicio tngs_codigo,
      cls_imp_coseguro tngs_importe,
      cls_imp_valorprestacion tngs_importe,
      cls_nro_cantestprestaciones tngs_numero,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint CliServicios_pk primary key clustered
      (
         cls_nro_numcliente,
         cls_nro_item
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on CliServicios to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: CliServicios
//--------------------------------------------------------------------------*/
