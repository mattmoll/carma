/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 04/01/2023 00:02
// Base de Datos      : TNGS_Carm
// Tabla              : ListasDePrecios
//----------------------------------------------------------------------------
// © 1999-2023 by TNG Software                                      Gndr 5.20
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

print 'Tabla: ListasDePrecios'

if exists (select * from sysobjects where id = object_id('dbo.ListasDePrecios'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.ListasDePrecios
end
go

print '   - Creando la nueva tabla'

create table ListasDePrecios
   (
      lpr_cod_cod tngs_codigo,
      lpr_des_des tngs_descripcion,
      lpr_cod_codplan tngs_codigo,
      lpr_rcd_codmarca tngs_codigo_r,
      lpr_imp_precio1p tngs_importe,
      lpr_imp_precio2p tngs_importe,
      lpr_imp_precio3p tngs_importe,
      lpr_imp_precio4p tngs_importe,
      lpr_imp_precio5p tngs_importe,
      lpr_imp_precio6p tngs_importe,
      lpr_imp_precio7p tngs_importe,
      lpr_imp_precio8p tngs_importe,
      lpr_imp_precio9p tngs_importe,
      lpr_imp_precio10p tngs_importe,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint ListasDePrecios_pk primary key clustered
      (
         lpr_cod_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on ListasDePrecios to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: ListasDePrecios
//--------------------------------------------------------------------------*/
