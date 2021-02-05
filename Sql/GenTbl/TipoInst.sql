/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : TipoInst
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

print 'Tabla: TipoInst'

if exists (select * from sysobjects where id = object_id('dbo.TipoInst'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.TipoInst
end
go

print '   - Creando la nueva tabla'

create table TipoInst
   (
      tin_cod_cod tngs_codigo,
      tin_des_des tngs_descripcion,
      tin_rcd_codrubro tngs_codigo_r,
      tin_cd1_mayorista tngs_codigo_1,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint TipoInst_pk primary key clustered
      (
         tin_cod_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on TipoInst to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: TipoInst
//--------------------------------------------------------------------------*/
