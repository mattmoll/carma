/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 01/12/2020 21:33
// Sistema     : Carm
// Tabla       : CliEntrevistas
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
/* Selecciono la base en la que se crearan los SPs */
/*-------------------------------------------------*/

use TNGS_Carm
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Levanta todos los registros de una tabla
--- </summary>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTREVISTAS_UP'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTREVISTAS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTREVISTAS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTREVISTAS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select cle_nro_numcliente,
                cle_nro_numentrev,
                TNGS_Carm.dbo.CliEntrevistas_GetEsPendiente(cle_nro_numentrev,cle_nro_numcliente) as cle_cd1_pend,
                cli_ede_rsocial as cle_des_rsocial,
                cle_fyh_fcoordinada,
                cle_fyh_frealizada,
                cle_cd6_codvend,
                TNGS_Carm.dbo.Vendedores_GetFullName(cle_cd6_codvend) as cle_des_vend,
                cle_ede_motcambiof,
                cle_des_nombre,
                TNGS_Carm.dbo.CliEntrevistas_FueBorrada (cle_nro_numcliente,cle_nro_numentrev) as cle_cd1_borrada,
                cle_tel_telefono,
                cle_des_cargo,
                cle_des_titulo,
                cle_tel_celular,
                cle_xld_email,
                cle_xld_direccion,
                cle_txt_observaciones,
                cle_rcd_codresultado,
                cle_ede_informe,
                cle_des_secretaria,
                TNGS_Carm..CliEntrevistas.instante,
                TNGS_Carm..CliEntrevistas.deleted,
                TNGS_Carm..CliEntrevistas.usuario,
                TNGS_Carm..CliEntrevistas.version
           from TNGS_Carm..CliEntrevistas
                join TNGS_Carm..Clientes
                  on cle_nro_numcliente = cli_nro_numero
          where TNGS_Carm..CliEntrevistas.deleted = 0
          order by cle_nro_numcliente,
                cle_nro_numentrev
      end
   else
      begin
         Select cle_nro_numcliente,
                cle_nro_numentrev,
                TNGS_Carm.dbo.CliEntrevistas_GetEsPendiente(cle_nro_numentrev,cle_nro_numcliente) as cle_cd1_pend,
                cli_ede_rsocial as cle_des_rsocial,
                cle_fyh_fcoordinada,
                cle_fyh_frealizada,
                cle_cd6_codvend,
                TNGS_Carm.dbo.Vendedores_GetFullName(cle_cd6_codvend) as cle_des_vend,
                cle_ede_motcambiof,
                cle_des_nombre,
                TNGS_Carm.dbo.CliEntrevistas_FueBorrada (cle_nro_numcliente,cle_nro_numentrev) as cle_cd1_borrada,
                cle_tel_telefono,
                cle_des_cargo,
                cle_des_titulo,
                cle_tel_celular,
                cle_xld_email,
                cle_xld_direccion,
                cle_txt_observaciones,
                cle_rcd_codresultado,
                cle_ede_informe,
                cle_des_secretaria,
                TNGS_Carm..CliEntrevistas.instante,
                TNGS_Carm..CliEntrevistas.deleted,
                TNGS_Carm..CliEntrevistas.usuario,
                TNGS_Carm..CliEntrevistas.version
           from TNGS_Carm..CliEntrevistas
                join TNGS_Carm..Clientes
                  on cle_nro_numcliente = cli_nro_numero
          order by cle_nro_numcliente,
                cle_nro_numentrev
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTREVISTAS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@cle_nro_numcliente">Número de cliente</param>
--- <param name="@cle_nro_numentrev">Número</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTREVISTAS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTREVISTAS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTREVISTAS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTREVISTAS_CHKVERSION
(
@cle_nro_numcliente tngs_numero,
@cle_nro_numentrev tngs_numero,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Carm..CliEntrevistas
    where cle_nro_numcliente = @cle_nro_numcliente
      and cle_nro_numentrev = @cle_nro_numentrev
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTREVISTAS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@cle_nro_numcliente">Número de cliente</param>
--- <param name="@cle_nro_numentrev">Número</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTREVISTAS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTREVISTAS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTREVISTAS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTREVISTAS_SEARCH
(
@cle_nro_numcliente tngs_numero,
@cle_nro_numentrev tngs_numero,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select cle_nro_numcliente,
                cle_nro_numentrev,
                TNGS_Carm.dbo.CliEntrevistas_GetEsPendiente(cle_nro_numentrev,cle_nro_numcliente) as cle_cd1_pend,
                cli_ede_rsocial as cle_des_rsocial,
                cle_fyh_fcoordinada,
                cle_fyh_frealizada,
                cle_cd6_codvend,
                TNGS_Carm.dbo.Vendedores_GetFullName(cle_cd6_codvend) as cle_des_vend,
                cle_ede_motcambiof,
                cle_des_nombre,
                TNGS_Carm.dbo.CliEntrevistas_FueBorrada (cle_nro_numcliente,cle_nro_numentrev) as cle_cd1_borrada,
                cle_tel_telefono,
                cle_des_cargo,
                cle_des_titulo,
                cle_tel_celular,
                cle_xld_email,
                cle_xld_direccion,
                cle_txt_observaciones,
                cle_rcd_codresultado,
                cle_ede_informe,
                cle_des_secretaria,
                TNGS_Carm..CliEntrevistas.instante,
                TNGS_Carm..CliEntrevistas.deleted,
                TNGS_Carm..CliEntrevistas.usuario,
                TNGS_Carm..CliEntrevistas.version
           from TNGS_Carm..CliEntrevistas
                join TNGS_Carm..Clientes
                  on cle_nro_numcliente = cli_nro_numero
          where cle_nro_numcliente = @cle_nro_numcliente
            and cle_nro_numentrev = @cle_nro_numentrev
            and TNGS_Carm..CliEntrevistas.deleted = 0
      end
   else
      begin
         Select cle_nro_numcliente,
                cle_nro_numentrev,
                TNGS_Carm.dbo.CliEntrevistas_GetEsPendiente(cle_nro_numentrev,cle_nro_numcliente) as cle_cd1_pend,
                cli_ede_rsocial as cle_des_rsocial,
                cle_fyh_fcoordinada,
                cle_fyh_frealizada,
                cle_cd6_codvend,
                TNGS_Carm.dbo.Vendedores_GetFullName(cle_cd6_codvend) as cle_des_vend,
                cle_ede_motcambiof,
                cle_des_nombre,
                TNGS_Carm.dbo.CliEntrevistas_FueBorrada (cle_nro_numcliente,cle_nro_numentrev) as cle_cd1_borrada,
                cle_tel_telefono,
                cle_des_cargo,
                cle_des_titulo,
                cle_tel_celular,
                cle_xld_email,
                cle_xld_direccion,
                cle_txt_observaciones,
                cle_rcd_codresultado,
                cle_ede_informe,
                cle_des_secretaria,
                TNGS_Carm..CliEntrevistas.instante,
                TNGS_Carm..CliEntrevistas.deleted,
                TNGS_Carm..CliEntrevistas.usuario,
                TNGS_Carm..CliEntrevistas.version
           from TNGS_Carm..CliEntrevistas
                join TNGS_Carm..Clientes
                  on cle_nro_numcliente = cli_nro_numero
          where cle_nro_numcliente = @cle_nro_numcliente
            and cle_nro_numentrev = @cle_nro_numentrev
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTREVISTAS_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca los registros de una clave foranea
--- </summary>
--- <param name="@cle_nro_numcliente">Número de cliente</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTREVISTAS_FSEARCH'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTREVISTAS_FSEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTREVISTAS_FSEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTREVISTAS_FSEARCH
(
@cle_nro_numcliente tngs_numero,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select cle_nro_numcliente,
                cle_nro_numentrev,
                TNGS_Carm.dbo.CliEntrevistas_GetEsPendiente(cle_nro_numentrev,cle_nro_numcliente) as cle_cd1_pend,
                cli_ede_rsocial as cle_des_rsocial,
                cle_fyh_fcoordinada,
                cle_fyh_frealizada,
                cle_cd6_codvend,
                TNGS_Carm.dbo.Vendedores_GetFullName(cle_cd6_codvend) as cle_des_vend,
                cle_ede_motcambiof,
                cle_des_nombre,
                TNGS_Carm.dbo.CliEntrevistas_FueBorrada (cle_nro_numcliente,cle_nro_numentrev) as cle_cd1_borrada,
                cle_tel_telefono,
                cle_des_cargo,
                cle_des_titulo,
                cle_tel_celular,
                cle_xld_email,
                cle_xld_direccion,
                cle_txt_observaciones,
                cle_rcd_codresultado,
                cle_ede_informe,
                cle_des_secretaria,
                TNGS_Carm..CliEntrevistas.instante,
                TNGS_Carm..CliEntrevistas.deleted,
                TNGS_Carm..CliEntrevistas.usuario,
                TNGS_Carm..CliEntrevistas.version
           from TNGS_Carm..CliEntrevistas
                join TNGS_Carm..Clientes
                  on cle_nro_numcliente = cli_nro_numero
          where cle_nro_numcliente = @cle_nro_numcliente
            and TNGS_Carm..CliEntrevistas.deleted = 0
          order by cle_nro_numentrev
      end
   else
      begin
         Select cle_nro_numcliente,
                cle_nro_numentrev,
                TNGS_Carm.dbo.CliEntrevistas_GetEsPendiente(cle_nro_numentrev,cle_nro_numcliente) as cle_cd1_pend,
                cli_ede_rsocial as cle_des_rsocial,
                cle_fyh_fcoordinada,
                cle_fyh_frealizada,
                cle_cd6_codvend,
                TNGS_Carm.dbo.Vendedores_GetFullName(cle_cd6_codvend) as cle_des_vend,
                cle_ede_motcambiof,
                cle_des_nombre,
                TNGS_Carm.dbo.CliEntrevistas_FueBorrada (cle_nro_numcliente,cle_nro_numentrev) as cle_cd1_borrada,
                cle_tel_telefono,
                cle_des_cargo,
                cle_des_titulo,
                cle_tel_celular,
                cle_xld_email,
                cle_xld_direccion,
                cle_txt_observaciones,
                cle_rcd_codresultado,
                cle_ede_informe,
                cle_des_secretaria,
                TNGS_Carm..CliEntrevistas.instante,
                TNGS_Carm..CliEntrevistas.deleted,
                TNGS_Carm..CliEntrevistas.usuario,
                TNGS_Carm..CliEntrevistas.version
           from TNGS_Carm..CliEntrevistas
                join TNGS_Carm..Clientes
                  on cle_nro_numcliente = cli_nro_numero
          where cle_nro_numcliente = @cle_nro_numcliente
          order by cle_nro_numentrev
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTREVISTAS_FSEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@cle_nro_numcliente">Número de cliente</param>
--- <param name="@cle_nro_numentrev">Número</param>
--- <param name="@cle_fyh_fcoordinada">Fecha coordinada</param>
--- <param name="@cle_fyh_frealizada">Fecha realizada</param>
--- <param name="@cle_cd6_codvend">Código de Vendedor</param>
--- <param name="@cle_ede_motcambiof">Motivo cambio fecha</param>
--- <param name="@cle_des_nombre">Nombre</param>
--- <param name="@cle_tel_telefono">Teléfono</param>
--- <param name="@cle_des_cargo">Cargo</param>
--- <param name="@cle_des_titulo">Título</param>
--- <param name="@cle_tel_celular">Celular</param>
--- <param name="@cle_xld_email">Email</param>
--- <param name="@cle_xld_direccion">Dirección</param>
--- <param name="@cle_txt_observaciones">Observaciones</param>
--- <param name="@cle_rcd_codresultado">Código de resultado</param>
--- <param name="@cle_ede_informe">Informe</param>
--- <param name="@cle_des_secretaria">Secretaria</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTREVISTAS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTREVISTAS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTREVISTAS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTREVISTAS_INSERT
(
@cle_nro_numcliente tngs_numero,
@cle_nro_numentrev tngs_numero,
@cle_fyh_fcoordinada tngs_fecyhor,
@cle_fyh_frealizada tngs_fecyhor,
@cle_cd6_codvend tngs_codigo_6,
@cle_ede_motcambiof tngs_descripcion_e,
@cle_des_nombre tngs_descripcion,
@cle_tel_telefono tngs_telefono,
@cle_des_cargo tngs_descripcion,
@cle_des_titulo tngs_descripcion,
@cle_tel_celular tngs_telefono,
@cle_xld_email tngs_descripcion_xl,
@cle_xld_direccion tngs_descripcion_xl,
@cle_txt_observaciones tngs_texto,
@cle_rcd_codresultado tngs_codigo_r,
@cle_ede_informe tngs_descripcion_e,
@cle_des_secretaria tngs_descripcion,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Carm..CliEntrevistas
   values (
           @cle_nro_numcliente,
           @cle_nro_numentrev,
           @cle_fyh_fcoordinada,
           @cle_fyh_frealizada,
           @cle_cd6_codvend,
           @cle_ede_motcambiof,
           @cle_des_nombre,
           @cle_tel_telefono,
           @cle_des_cargo,
           @cle_des_titulo,
           @cle_tel_celular,
           @cle_xld_email,
           @cle_xld_direccion,
           @cle_txt_observaciones,
           @cle_rcd_codresultado,
           @cle_ede_informe,
           @cle_des_secretaria,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTREVISTAS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@cle_nro_numcliente">Número de cliente</param>
--- <param name="@cle_nro_numentrev">Número</param>
--- <param name="@cle_fyh_fcoordinada">Fecha coordinada</param>
--- <param name="@cle_fyh_frealizada">Fecha realizada</param>
--- <param name="@cle_cd6_codvend">Código de Vendedor</param>
--- <param name="@cle_ede_motcambiof">Motivo cambio fecha</param>
--- <param name="@cle_des_nombre">Nombre</param>
--- <param name="@cle_tel_telefono">Teléfono</param>
--- <param name="@cle_des_cargo">Cargo</param>
--- <param name="@cle_des_titulo">Título</param>
--- <param name="@cle_tel_celular">Celular</param>
--- <param name="@cle_xld_email">Email</param>
--- <param name="@cle_xld_direccion">Dirección</param>
--- <param name="@cle_txt_observaciones">Observaciones</param>
--- <param name="@cle_rcd_codresultado">Código de resultado</param>
--- <param name="@cle_ede_informe">Informe</param>
--- <param name="@cle_des_secretaria">Secretaria</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTREVISTAS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTREVISTAS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTREVISTAS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTREVISTAS_UPDATE
(
@cle_nro_numcliente tngs_numero,
@cle_nro_numentrev tngs_numero,
@cle_fyh_fcoordinada tngs_fecyhor,
@cle_fyh_frealizada tngs_fecyhor,
@cle_cd6_codvend tngs_codigo_6,
@cle_ede_motcambiof tngs_descripcion_e,
@cle_des_nombre tngs_descripcion,
@cle_tel_telefono tngs_telefono,
@cle_des_cargo tngs_descripcion,
@cle_des_titulo tngs_descripcion,
@cle_tel_celular tngs_telefono,
@cle_xld_email tngs_descripcion_xl,
@cle_xld_direccion tngs_descripcion_xl,
@cle_txt_observaciones tngs_texto,
@cle_rcd_codresultado tngs_codigo_r,
@cle_ede_informe tngs_descripcion_e,
@cle_des_secretaria tngs_descripcion,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..CliEntrevistas
      set cle_fyh_fcoordinada= @cle_fyh_fcoordinada,
          cle_fyh_frealizada= @cle_fyh_frealizada,
          cle_cd6_codvend= @cle_cd6_codvend,
          cle_ede_motcambiof= @cle_ede_motcambiof,
          cle_des_nombre= @cle_des_nombre,
          cle_tel_telefono= @cle_tel_telefono,
          cle_des_cargo= @cle_des_cargo,
          cle_des_titulo= @cle_des_titulo,
          cle_tel_celular= @cle_tel_celular,
          cle_xld_email= @cle_xld_email,
          cle_xld_direccion= @cle_xld_direccion,
          cle_txt_observaciones= @cle_txt_observaciones,
          cle_rcd_codresultado= @cle_rcd_codresultado,
          cle_ede_informe= @cle_ede_informe,
          cle_des_secretaria= @cle_des_secretaria,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where cle_nro_numcliente = @cle_nro_numcliente
      and cle_nro_numentrev = @cle_nro_numentrev

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTREVISTAS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@cle_nro_numcliente">Número de cliente</param>
--- <param name="@cle_nro_numentrev">Número</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTREVISTAS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTREVISTAS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTREVISTAS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTREVISTAS_DELETE
(
@cle_nro_numcliente tngs_numero,
@cle_nro_numentrev tngs_numero,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..CliEntrevistas
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where cle_nro_numcliente = @cle_nro_numcliente
      and cle_nro_numentrev = @cle_nro_numentrev

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTREVISTAS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro por clave foranea
--- </summary>
--- <param name="@cle_nro_numcliente">Número de cliente</param>
--- <param name="@instante">Instante del delete</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTREVISTAS_FDELETE'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTREVISTAS_FDELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTREVISTAS_FDELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTREVISTAS_FDELETE
(
@cle_nro_numcliente tngs_numero,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         select @instante= getdate()
      end

   Update TNGS_Carm..CliEntrevistas
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= @instante,
          usuario = @usuario
    where cle_nro_numcliente = @cle_nro_numcliente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTREVISTAS_FDELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@cle_nro_numcliente">Número de cliente</param>
--- <param name="@cle_nro_numentrev">Número</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTREVISTAS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTREVISTAS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTREVISTAS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTREVISTAS_RECALL
(
@cle_nro_numcliente tngs_numero,
@cle_nro_numentrev tngs_numero,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..CliEntrevistas
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where cle_nro_numcliente = @cle_nro_numcliente
      and cle_nro_numentrev = @cle_nro_numentrev

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTREVISTAS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera lógicamente los registros de una clave foranea
--- </summary>
--- <param name="@cle_nro_numcliente">Número de cliente</param>
--- <param name="@instante">Instante de referencia</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTREVISTAS_FRECALL'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTREVISTAS_FRECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTREVISTAS_FRECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTREVISTAS_FRECALL
(
@cle_nro_numcliente tngs_numero,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         Update TNGS_Carm..CliEntrevistas
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where cle_nro_numcliente = @cle_nro_numcliente
      end
   else
      begin
         Update TNGS_Carm..CliEntrevistas
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where cle_nro_numcliente = @cle_nro_numcliente
            and instante= @instante
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTREVISTAS_FRECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@cle_nro_numcliente">Número de cliente</param>
--- <param name="@cle_nro_numentrev">Número</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTREVISTAS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTREVISTAS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTREVISTAS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTREVISTAS_DROP
(
@cle_nro_numcliente tngs_numero,
@cle_nro_numentrev tngs_numero,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..CliEntrevistas
    where cle_nro_numcliente = @cle_nro_numcliente
      and cle_nro_numentrev = @cle_nro_numentrev

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTREVISTAS_DROP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro por clave foránea
--- </summary>
--- <param name="@cle_nro_numcliente">Número de cliente</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTREVISTAS_FDROP'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTREVISTAS_FDROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTREVISTAS_FDROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTREVISTAS_FDROP
(
@cle_nro_numcliente tngs_numero,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..CliEntrevistas
    where cle_nro_numcliente = @cle_nro_numcliente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTREVISTAS_FDROP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente los registros borrados lógicamente
--- </summary>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTREVISTAS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTREVISTAS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTREVISTAS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTREVISTAS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Carm..CliEntrevistas
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTREVISTAS_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente los registro borrados lógicamente por clave foránea
--- </summary>
--- <param name="@cle_nro_numcliente">Número de cliente</param>
--- <param name="@usuario">Usuario que realiza el pack</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTREVISTAS_FPACK'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTREVISTAS_FPACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTREVISTAS_FPACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTREVISTAS_FPACK
(
@cle_nro_numcliente tngs_numero,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..CliEntrevistas
    where cle_nro_numcliente = @cle_nro_numcliente
      and deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTREVISTAS_FPACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: BorraPorCliente
--- </summary>
--- <param name="@nrocliente">Numero de cliente a borrar entrevistas</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTREVISTAS_BORRAPORCLIENTE'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTREVISTAS_BORRAPORCLIENTE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTREVISTAS_BORRAPORCLIENTE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTREVISTAS_BORRAPORCLIENTE
(
@nrocliente tngs_numero,
@usuario tngs_nombre
)
as
begin

   delete from CliEntrevistas 
   where cle_nro_numcliente  = @nrocliente 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTREVISTAS_BORRAPORCLIENTE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: GetCodVend
--- </summary>
--- <param name="@nrocliente">Numero del Cliente</param>
--- <param name="@nroentrev">Numero de la Entrevista</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTREVISTAS_GETCODVEND'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTREVISTAS_GETCODVEND'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTREVISTAS_GETCODVEND
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTREVISTAS_GETCODVEND
(
@nrocliente tngs_numero,
@nroentrev tngs_numero,
@usuario tngs_nombre
)
as
begin

   select cle_cd6_codvend 
   from CliEntrevistas 
   where cle_nro_numcliente = @nrocliente and cle_nro_numentrev = @nroentrev 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTREVISTAS_GETCODVEND to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: GetEntrevPendVend
--- </summary>
--- <param name="@codvend">Código de vendedor</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTREVISTAS_GETENTREVPENDVEND'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTREVISTAS_GETENTREVPENDVEND'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTREVISTAS_GETENTREVPENDVEND
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTREVISTAS_GETENTREVPENDVEND
(
@codvend tngs_codigo_6,
@usuario tngs_nombre
)
as
begin

   Select cle_nro_numcliente,
          cle_nro_numentrev,
          TNGS_Carm.dbo.CliEntrevistas_GetEsPendiente(cle_nro_numentrev,cle_nro_numcliente) as cle_cd1_pend,
          cli_ede_rsocial as cle_des_rsocial,
          cle_fyh_fcoordinada,
          cle_fyh_frealizada,
          cle_cd6_codvend,
          TNGS_Carm.dbo.Vendedores_GetFullName(cle_cd6_codvend) as cle_des_vend,
          cle_ede_motcambiof,
          cle_des_nombre,
          TNGS_Carm.dbo.CliEntrevistas_FueBorrada (cle_nro_numcliente,cle_nro_numentrev) as cle_cd1_borrada,
          cle_tel_telefono,
          cle_des_cargo,
          cle_des_titulo,
          cle_tel_celular,
          cle_xld_email,
          cle_xld_direccion,
          cle_txt_observaciones,
          cle_rcd_codresultado,
          cle_ede_informe,
          cle_des_secretaria,
          TNGS_Carm..CliEntrevistas.instante,
          TNGS_Carm..CliEntrevistas.deleted,
          TNGS_Carm..CliEntrevistas.usuario,
          TNGS_Carm..CliEntrevistas.version
     from TNGS_Carm..CliEntrevistas 
          join TNGS_Carm..Clientes
            on cle_nro_numcliente = cli_nro_numero
       where 
           cli_cd6_codvend = @codvend and 
           cle_fyh_fcoordinada > getdate() and 
           cle_rcd_codresultado = ' ' and 
           TNGS_Carm..CliEntrevistas.deleted = 0.0000 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTREVISTAS_GETENTREVPENDVEND to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: GetEntrevistasCli
--- </summary>
--- <param name="@cliente">Numero del Cliente</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTREVISTAS_GETENTREVISTASCLI'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTREVISTAS_GETENTREVISTASCLI'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTREVISTAS_GETENTREVISTASCLI
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTREVISTAS_GETENTREVISTASCLI
(
@cliente tngs_numero,
@usuario tngs_nombre
)
as
begin

   Select cle_nro_numcliente,
          cle_nro_numentrev,
          TNGS_Carm.dbo.CliEntrevistas_GetEsPendiente(cle_nro_numentrev,cle_nro_numcliente) as cle_cd1_pend,
          cli_ede_rsocial as cle_des_rsocial,
          cle_fyh_fcoordinada,
          cle_fyh_frealizada,
          cle_cd6_codvend,
          TNGS_Carm.dbo.Vendedores_GetFullName(cle_cd6_codvend) as cle_des_vend,
          cle_ede_motcambiof,
          cle_des_nombre,
          TNGS_Carm.dbo.CliEntrevistas_FueBorrada (cle_nro_numcliente,cle_nro_numentrev) as cle_cd1_borrada,
          cle_tel_telefono,
          cle_des_cargo,
          cle_des_titulo,
          cle_tel_celular,
          cle_xld_email,
          cle_xld_direccion,
          cle_txt_observaciones,
          cle_rcd_codresultado,
          cle_ede_informe,
          cle_des_secretaria,
          TNGS_Carm..CliEntrevistas.instante,
          TNGS_Carm..CliEntrevistas.deleted,
          TNGS_Carm..CliEntrevistas.usuario,
          TNGS_Carm..CliEntrevistas.version
     from TNGS_Carm..CliEntrevistas 
          join TNGS_Carm..Clientes
            on cle_nro_numcliente = cli_nro_numero
    
      join TNGS_Carm..Vendedores 
         on cle_cd6_codvend = vnd_cd6_cod 
    
     where cle_nro_numcliente = @cliente 
    
      order by case when year(cle_fyh_frealizada)<> 1900 then '3000-01-01' 
                    else cle_fyh_frealizada end 
    

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTREVISTAS_GETENTREVISTASCLI to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: GetEntrevistasIncom
--- </summary>
--- <param name="@numcliente">Número de cliente</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTREVISTAS_GETENTREVISTASINCOM'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTREVISTAS_GETENTREVISTASINCOM'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTREVISTAS_GETENTREVISTASINCOM
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTREVISTAS_GETENTREVISTASINCOM
(
@numcliente tngs_numero,
@usuario tngs_nombre
)
as
begin

   SELECT 
       cle_nro_numentrev, 
     cli_ede_rsocial, 
     cle_fyh_fcoordinada, 
     cle_des_nombre, 
     cle_des_cargo 
    
   FROM 
    TNGS_Carm..Clientes 
    join TNGS_Carm..CliEntrevistas 
     on cle_nro_numcliente = cli_nro_numero 
    
   WHERE 
    cli_nro_numero = @numcliente and 
    cle_fyh_fcoordinada < getdate() and 
    cle_rcd_codresultado = ' ' 
    and TNGS_Carm..CliEntrevistas.deleted = 0.0000 
    
    
   ORDER BY cle_fyh_fcoordinada ASC 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTREVISTAS_GETENTREVISTASINCOM to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: GetEntrevistasPend
--- </summary>
--- <param name="@codvend">Código de vendedor</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTREVISTAS_GETENTREVISTASPEND'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTREVISTAS_GETENTREVISTASPEND'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTREVISTAS_GETENTREVISTASPEND
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTREVISTAS_GETENTREVISTASPEND
(
@codvend tngs_codigo_6,
@usuario tngs_nombre
)
as
begin

   select 
       TNGS_Carm..CliEntrevistas.cle_nro_numentrev, 
       cli_ede_rsocial, 
       TNGS_Carm..CliEntrevistas.cle_fyh_fcoordinada, 
       TNGS_Carm..CliEntrevistas.cle_des_nombre, 
       TNGS_Carm..CliEntrevistas.cle_des_cargo 
   from 
       TNGS_Carm..Clientes 
    
       join TNGS_Carm..CliEntrevistas 
           on cle_nro_numcliente = cli_nro_numero 
       where 
           cli_cd6_codvend = @codvend and 
           cle_fyh_fcoordinada > getdate() and 
           cle_rcd_codresultado <> ' ' and 
           TNGS_Carm..CliEntrevistas.deleted = 0.0000 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTREVISTAS_GETENTREVISTASPEND to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: GetEntrevistasVenc
--- </summary>
--- <param name="@codvend">Código de vendedor</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTREVISTAS_GETENTREVISTASVENC'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTREVISTAS_GETENTREVISTASVENC'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTREVISTAS_GETENTREVISTASVENC
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTREVISTAS_GETENTREVISTASVENC
(
@codvend tngs_codigo_6,
@usuario tngs_nombre
)
as
begin

   SELECT 
       TNGS_Carm..CliEntrevistas.cle_nro_numentrev, 
       cli_ede_rsocial, 
       TNGS_Carm..CliEntrevistas.cle_fyh_fcoordinada, 
       TNGS_Carm..CliEntrevistas.cle_des_nombre, 
       TNGS_Carm..CliEntrevistas.cle_des_cargo, 
       TNGS_Carm..Clientes.cli_nro_numero 
   FROM 
       TNGS_Carm..Clientes 
    
       JOIN TNGS_Carm..CliEntrevistas 
           ON cle_nro_numcliente = cli_nro_numero 
       WHERE 
           cli_cd6_codvend = @codvend and 
           cle_fyh_fcoordinada < getdate() and 
           cle_rcd_codresultado = ' 'and 
           TNGS_Carm..CliEntrevistas.deleted = 0.0000 
    
   ORDER BY cli_nro_numero, cle_fyh_fcoordinada 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTREVISTAS_GETENTREVISTASVENC to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: SaveCompletarEntrev
--- </summary>
--- <param name="@frealizada">Fecha realizada</param>
--- <param name="@numentrev">Número de entrevista</param>
--- <param name="@motivo">Motivo de cambio de fecha</param>
--- <param name="@informe">Informe de resultado</param>
--- <param name="@codresultado">Codigo del Resultado de la entrev.</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTREVISTAS_SAVECOMPLETARENTREV'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTREVISTAS_SAVECOMPLETARENTREV'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTREVISTAS_SAVECOMPLETARENTREV
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTREVISTAS_SAVECOMPLETARENTREV
(
@frealizada tngs_fecyhor,
@numentrev tngs_numero,
@motivo tngs_descripcion_e,
@informe tngs_descripcion_e,
@codresultado tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   update TNGS_Carm..CliEntrevistas 
        set 
            cle_fyh_frealizada = @frealizada, 
            cle_ede_motcambiof = @motivo, 
            cle_ede_informe = @informe, 
            cle_rcd_codresultado = @codresultado 
        where 
            cle_nro_numentrev = @numentrev 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTREVISTAS_SAVECOMPLETARENTREV to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: CliEntrevistas
//--------------------------------------------------------------------------*/
