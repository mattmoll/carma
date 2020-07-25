/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 25/07/2020 18:48
// Base de Datos      : TNGS_Carm
// Tabla              : PlnServicios
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

print 'Tabla: PlnServicios'

if exists (select * from sysobjects where id = object_id('dbo.PlnServicios'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.PlnServicios
end
go

print '   - Creando la nueva tabla'

create table PlnServicios
   (
      pls_cod_codplan tngs_codigo,
      pls_cod_codservicio tngs_codigo,
      pls_nro_cprestlibres tngs_numero,
      pls_imp_valorprestacion tngs_importe,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint PlnServicios_pk primary key clustered
      (
         pls_cod_codplan,
         pls_cod_codservicio
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on PlnServicios to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: PlnServicios
//--------------------------------------------------------------------------*/
