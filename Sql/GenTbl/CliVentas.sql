/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 01/12/2020 21:33
// Base de Datos      : TNGS_Carm
// Tabla              : CliVentas
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

print 'Tabla: CliVentas'

if exists (select * from sysobjects where id = object_id('dbo.CliVentas'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.CliVentas
end
go

print '   - Creando la nueva tabla'

create table CliVentas
   (
      clv_nro_numcliente tngs_numero,
      clv_fyh_fecha tngs_fecyhor,
      clv_cd6_codvendedor tngs_codigo_6,
      clv_rcd_codtipocontrato tngs_codigo_r,
      clv_imp_abono tngs_importe,
      clv_nro_cantcapitas tngs_numero,
      clv_imp_valorcapita tngs_importe,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint CliVentas_pk primary key clustered
      (
         clv_nro_numcliente,
         clv_fyh_fecha
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on CliVentas to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: CliVentas
//--------------------------------------------------------------------------*/
