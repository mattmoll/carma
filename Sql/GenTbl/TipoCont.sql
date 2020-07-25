/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 25/07/2020 18:48
// Base de Datos      : TNGS_Carm
// Tabla              : TipoCont
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

print 'Tabla: TipoCont'

if exists (select * from sysobjects where id = object_id('dbo.TipoCont'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.TipoCont
end
go

print '   - Creando la nueva tabla'

create table TipoCont
   (
      tcn_rcd_cod tngs_codigo_r,
      tcn_des_des tngs_descripcion,
      tcn_cd1_modo tngs_codigo_1,
      tcn_rcd_tcontratoavalon tngs_codigo_r,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint TipoCont_pk primary key clustered
      (
         tcn_rcd_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on TipoCont to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: TipoCont
//--------------------------------------------------------------------------*/
