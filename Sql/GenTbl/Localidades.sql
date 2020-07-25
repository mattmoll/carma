/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 25/07/2020 18:48
// Base de Datos      : TNGS_Carm
// Tabla              : Localidades
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

print 'Tabla: Localidades'

if exists (select * from sysobjects where id = object_id('dbo.Localidades'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Localidades
end
go

print '   - Creando la nueva tabla'

create table Localidades
   (
      loc_ecd_codpost tngs_codigo_e,
      loc_ede_nombre tngs_descripcion_e,
      loc_rcd_codzona tngs_codigo_r,
      loc_ede_partido tngs_descripcion_e,
      loc_des_provincia tngs_descripcion,
      loc_ede_nomgoogle tngs_descripcion_e,
      loc_cd1_directa tngs_codigo_1,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Localidades_pk primary key clustered
      (
         loc_ecd_codpost
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Localidades to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Localidades
//--------------------------------------------------------------------------*/
