/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 01/12/2020 21:33
// Base de Datos      : TNGS_Carm
// Tabla              : CliLlamadas
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

print 'Tabla: CliLlamadas'

if exists (select * from sysobjects where id = object_id('dbo.CliLlamadas'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.CliLlamadas
end
go

print '   - Creando la nueva tabla'

create table CliLlamadas
   (
      cll_nro_numcliente tngs_numero,
      cll_nro_numllamada tngs_numero,
      cll_cod_codmotivo tngs_codigo,
      cll_fyh_frealizada tngs_fecyhor,
      cll_txt_resultado tngs_texto,
      cll_nom_codusuario tngs_nombre,
      cll_cd1_baja tngs_codigo_1,
      cll_nro_numcontacto tngs_numero,
      cll_txt_obsprogramada tngs_texto,
      cll_imp_abonoanterior tngs_importe,
      cll_imp_abonorecuperado tngs_importe,
      cll_nom_programador tngs_nombre,
      cll_imp_ajuste tngs_importe,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint CliLlamadas_pk primary key clustered
      (
         cll_nro_numcliente,
         cll_nro_numllamada
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on CliLlamadas to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: CliLlamadas
//--------------------------------------------------------------------------*/
