/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : PreciosServicios
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

print 'Tabla: PreciosServicios'

if exists (select * from sysobjects where id = object_id('dbo.PreciosServicios'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.PreciosServicios
end
go

print '   - Creando la nueva tabla'

create table PreciosServicios
   (
      prs_cd1_color tngs_codigo_1,
      prs_fec_fecha tngs_fecha,
      prs_imp_precio tngs_importe,
      prs_imp_coseguro tngs_importe,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint PreciosServicios_pk primary key clustered
      (
         prs_cd1_color,
         prs_fec_fecha
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on PreciosServicios to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: PreciosServicios
//--------------------------------------------------------------------------*/
