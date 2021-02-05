/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : CliGrupoFamiliar
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

print 'Tabla: CliGrupoFamiliar'

if exists (select * from sysobjects where id = object_id('dbo.CliGrupoFamiliar'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.CliGrupoFamiliar
end
go

print '   - Creando la nueva tabla'

create table CliGrupoFamiliar
   (
      cgf_nro_numcliente tngs_numero,
      cgf_nro_numintegrante tngs_numero,
      cgf_ede_apellido tngs_descripcion_e,
      cgf_ede_nombre tngs_descripcion_e,
      cgf_rcd_codparentesco tngs_codigo_r,
      cgf_d20_dni tngs_descripcion_20,
      cgf_fec_fechanacimiento tngs_fecha,
      cgf_ede_obrasocial tngs_descripcion_e,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint CliGrupoFamiliar_pk primary key clustered
      (
         cgf_nro_numcliente,
         cgf_nro_numintegrante
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on CliGrupoFamiliar to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: CliGrupoFamiliar
//--------------------------------------------------------------------------*/
