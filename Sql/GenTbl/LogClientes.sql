/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 25/07/2020 18:48
// Base de Datos      : TNGS_Carm
// Tabla              : LogClientes
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

print 'Tabla: LogClientes'

if exists (select * from sysobjects where id = object_id('dbo.LogClientes'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.LogClientes
end
go

print '   - Creando la nueva tabla'

create table LogClientes
   (
      lgc_nro_nro tngs_numero,
      lgc_nro_nrocliente tngs_numero,
      lgc_nro_nroavalon tngs_numero,
      lgc_ede_rsocial tngs_descripcion_e,
      lgc_des_nomfantasia tngs_descripcion,
      lgc_des_accion tngs_descripcion,
      lgc_nom_usuario tngs_nombre,
      lgc_fyh_fecha tngs_fecyhor,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint LogClientes_pk primary key clustered
      (
         lgc_nro_nro
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on LogClientes to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: LogClientes
//--------------------------------------------------------------------------*/
