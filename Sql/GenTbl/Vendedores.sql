/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 25/07/2020 18:48
// Base de Datos      : TNGS_Carm
// Tabla              : Vendedores
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

print 'Tabla: Vendedores'

if exists (select * from sysobjects where id = object_id('dbo.Vendedores'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Vendedores
end
go

print '   - Creando la nueva tabla'

create table Vendedores
   (
      vnd_cd6_cod tngs_codigo_6,
      vnd_des_apellido tngs_descripcion,
      vnd_des_nombre tngs_descripcion,
      vnd_nom_usuario tngs_nombre,
      vnd_tel_tel1 tngs_telefono,
      vnd_tel_celular tngs_telefono,
      vnd_tel_tel2 tngs_telefono,
      vnd_fec_fecnacim tngs_fecha,
      vnd_ede_direccion tngs_descripcion_e,
      vnd_ede_email tngs_descripcion_e,
      vnd_ede_contrasenia tngs_descripcion_e,
      vnd_cd6_codsuperv tngs_codigo_6,
      vnd_rcd_codtvend tngs_codigo_r,
      vnd_txt_horarios tngs_texto,
      vnd_ede_mailremitente tngs_descripcion_e,
      vnd_ede_nombreamostrar tngs_descripcion_e,
      vnd_rcd_coddominio tngs_codigo_r,
      vnd_cd1_historico tngs_codigo_1,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Vendedores_pk primary key clustered
      (
         vnd_cd6_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Vendedores to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Vendedores
//--------------------------------------------------------------------------*/
