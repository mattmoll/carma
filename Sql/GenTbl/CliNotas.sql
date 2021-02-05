/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : CliNotas
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

print 'Tabla: CliNotas'

if exists (select * from sysobjects where id = object_id('dbo.CliNotas'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.CliNotas
end
go

print '   - Creando la nueva tabla'

create table CliNotas
   (
      cln_nro_numcliente tngs_numero,
      cln_fyh_fechayhora tngs_fecyhor,
      cln_des_titulo tngs_descripcion,
      cln_xld_texto tngs_descripcion_xl,
      cln_cd1_tipo tngs_codigo_1,
      cln_nom_escritor tngs_nombre,
      cln_nom_removedor tngs_nombre,
      cln_fyh_fyhremovida tngs_fecyhor,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint CliNotas_pk primary key clustered
      (
         cln_nro_numcliente,
         cln_fyh_fechayhora
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on CliNotas to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: CliNotas
//--------------------------------------------------------------------------*/
