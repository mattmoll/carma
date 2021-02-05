/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : Talonarios
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

print 'Tabla: Talonarios'

if exists (select * from sysobjects where id = object_id('dbo.Talonarios'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Talonarios
end
go

print '   - Creando la nueva tabla'

create table Talonarios
   (
      tal_xcd_codigo tngs_codigo_x,
      tal_des_descripcion tngs_descripcion,
      tal_cd1_tipo tngs_codigo_1,
      tal_nro_valor tngs_numero,
      tal_fyh_referencia tngs_fecyhor,
      tal_rob_detalle tngs_observaciones_r,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Talonarios_pk primary key clustered
      (
         tal_xcd_codigo
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Talonarios to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Talonarios
//--------------------------------------------------------------------------*/
