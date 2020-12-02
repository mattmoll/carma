/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 01/12/2020 21:33
// Base de Datos      : TNGS_Carm
// Tabla              : CliGrupoFamiliar
//----------------------------------------------------------------------------
// � 1999-2020 by TNG Software                                      Gndr 5.20
//---------------------------------------------------------------------------*/

/* ***************************************************************************
/  Atencion!!!
/     Este archivo fue generado por un programa en forma autom�tica. Cualquier
/     modificaci�n que se realize sobre �l se perder� en la pr�xima
/     regeneraci�n.
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
      cgf_nro_numfamiliar tngs_numero,
      cgf_des_nombre tngs_descripcion,
      cgf_des_apellido tngs_descripcion,
      cgf_d20_dni tngs_descripcion_20,
      cgf_fec_fecnacimiento tngs_fecha,
      cgf_ede_obrasocial tngs_descripcion_e,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint CliGrupoFamiliar_pk primary key clustered
      (
         cgf_nro_numcliente,
         cgf_nro_numfamiliar
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
