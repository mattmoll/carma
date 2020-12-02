/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 01/12/2020 09:41
// Base de Datos      : TNGS_Carm
// Tabla              : SituacionesIVA
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

print 'Tabla: SituacionesIVA'

if exists (select * from sysobjects where id = object_id('dbo.SituacionesIVA'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.SituacionesIVA
end
go

print '   - Creando la nueva tabla'

create table SituacionesIVA
   (
      siv_rcd_codigo tngs_codigo_r,
      siv_des_descripcion tngs_descripcion,
      siv_cd1_discrimina tngs_codigo_1,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint SituacionesIVA_pk primary key clustered
      (
         siv_rcd_codigo
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on SituacionesIVA to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: SituacionesIVA
//--------------------------------------------------------------------------*/
