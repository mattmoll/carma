/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 18/12/2020 01:46
// Sistema     : Carm
// Tabla       : CliContactos
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

print 'Store Procedure: dbo.CLICONTACTOS_UP'

if exists (select * from sysobjects where id = object_id('dbo.CLICONTACTOS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLICONTACTOS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLICONTACTOS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select clc_nro_numcliente,
                cli_ede_rsocial as clc_des_rsocial,
                clc_nro_numcontacto,
                clc_des_nombre,
                clc_des_cargo,
                clc_des_titulo,
                TNGS_Carm.dbo.CliContactos_EstaActivo (clc_nro_numcliente,clc_nro_numcontacto) as clc_cd1_activo,
                clc_tel_celular,
                clc_tel_telefono1,
                clc_tel_telefono2,
                clc_tel_interno,
                clc_xld_email,
                clc_des_secretaria,
                TNGS_Carm..CliContactos.instante,
                TNGS_Carm..CliContactos.deleted,
                TNGS_Carm..CliContactos.usuario,
                TNGS_Carm..CliContactos.version
           from TNGS_Carm..CliContactos
                join TNGS_Carm..Clientes
                  on clc_nro_numcliente = cli_nro_numero
          where TNGS_Carm..CliContactos.deleted = 0
          order by clc_nro_numcliente,
                clc_nro_numcontacto
      end
   else
      begin
         Select clc_nro_numcliente,
                cli_ede_rsocial as clc_des_rsocial,
                clc_nro_numcontacto,
                clc_des_nombre,
                clc_des_cargo,
                clc_des_titulo,
                TNGS_Carm.dbo.CliContactos_EstaActivo (clc_nro_numcliente,clc_nro_numcontacto) as clc_cd1_activo,
                clc_tel_celular,
                clc_tel_telefono1,
                clc_tel_telefono2,
                clc_tel_interno,
                clc_xld_email,
                clc_des_secretaria,
                TNGS_Carm..CliContactos.instante,
                TNGS_Carm..CliContactos.deleted,
                TNGS_Carm..CliContactos.usuario,
                TNGS_Carm..CliContactos.version
           from TNGS_Carm..CliContactos
                join TNGS_Carm..Clientes
                  on clc_nro_numcliente = cli_nro_numero
          order by clc_nro_numcliente,
                clc_nro_numcontacto
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLICONTACTOS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@clc_nro_numcliente">Número de cliente</param>
--- <param name="@clc_nro_numcontacto">Número</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLICONTACTOS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.CLICONTACTOS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLICONTACTOS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLICONTACTOS_CHKVERSION
(
@clc_nro_numcliente tngs_numero,
@clc_nro_numcontacto tngs_numero,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Carm..CliContactos
    where clc_nro_numcliente = @clc_nro_numcliente
      and clc_nro_numcontacto = @clc_nro_numcontacto
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLICONTACTOS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@clc_nro_numcliente">Número de cliente</param>
--- <param name="@clc_nro_numcontacto">Número</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLICONTACTOS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.CLICONTACTOS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLICONTACTOS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLICONTACTOS_SEARCH
(
@clc_nro_numcliente tngs_numero,
@clc_nro_numcontacto tngs_numero,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select clc_nro_numcliente,
                cli_ede_rsocial as clc_des_rsocial,
                clc_nro_numcontacto,
                clc_des_nombre,
                clc_des_cargo,
                clc_des_titulo,
                TNGS_Carm.dbo.CliContactos_EstaActivo (clc_nro_numcliente,clc_nro_numcontacto) as clc_cd1_activo,
                clc_tel_celular,
                clc_tel_telefono1,
                clc_tel_telefono2,
                clc_tel_interno,
                clc_xld_email,
                clc_des_secretaria,
                TNGS_Carm..CliContactos.instante,
                TNGS_Carm..CliContactos.deleted,
                TNGS_Carm..CliContactos.usuario,
                TNGS_Carm..CliContactos.version
           from TNGS_Carm..CliContactos
                join TNGS_Carm..Clientes
                  on clc_nro_numcliente = cli_nro_numero
          where clc_nro_numcliente = @clc_nro_numcliente
            and clc_nro_numcontacto = @clc_nro_numcontacto
            and TNGS_Carm..CliContactos.deleted = 0
      end
   else
      begin
         Select clc_nro_numcliente,
                cli_ede_rsocial as clc_des_rsocial,
                clc_nro_numcontacto,
                clc_des_nombre,
                clc_des_cargo,
                clc_des_titulo,
                TNGS_Carm.dbo.CliContactos_EstaActivo (clc_nro_numcliente,clc_nro_numcontacto) as clc_cd1_activo,
                clc_tel_celular,
                clc_tel_telefono1,
                clc_tel_telefono2,
                clc_tel_interno,
                clc_xld_email,
                clc_des_secretaria,
                TNGS_Carm..CliContactos.instante,
                TNGS_Carm..CliContactos.deleted,
                TNGS_Carm..CliContactos.usuario,
                TNGS_Carm..CliContactos.version
           from TNGS_Carm..CliContactos
                join TNGS_Carm..Clientes
                  on clc_nro_numcliente = cli_nro_numero
          where clc_nro_numcliente = @clc_nro_numcliente
            and clc_nro_numcontacto = @clc_nro_numcontacto
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLICONTACTOS_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca los registros de una clave foranea
--- </summary>
--- <param name="@clc_nro_numcliente">Número de cliente</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLICONTACTOS_FSEARCH'

if exists (select * from sysobjects where id = object_id('dbo.CLICONTACTOS_FSEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLICONTACTOS_FSEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLICONTACTOS_FSEARCH
(
@clc_nro_numcliente tngs_numero,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select clc_nro_numcliente,
                cli_ede_rsocial as clc_des_rsocial,
                clc_nro_numcontacto,
                clc_des_nombre,
                clc_des_cargo,
                clc_des_titulo,
                TNGS_Carm.dbo.CliContactos_EstaActivo (clc_nro_numcliente,clc_nro_numcontacto) as clc_cd1_activo,
                clc_tel_celular,
                clc_tel_telefono1,
                clc_tel_telefono2,
                clc_tel_interno,
                clc_xld_email,
                clc_des_secretaria,
                TNGS_Carm..CliContactos.instante,
                TNGS_Carm..CliContactos.deleted,
                TNGS_Carm..CliContactos.usuario,
                TNGS_Carm..CliContactos.version
           from TNGS_Carm..CliContactos
                join TNGS_Carm..Clientes
                  on clc_nro_numcliente = cli_nro_numero
          where clc_nro_numcliente = @clc_nro_numcliente
            and TNGS_Carm..CliContactos.deleted = 0
          order by clc_nro_numcontacto
      end
   else
      begin
         Select clc_nro_numcliente,
                cli_ede_rsocial as clc_des_rsocial,
                clc_nro_numcontacto,
                clc_des_nombre,
                clc_des_cargo,
                clc_des_titulo,
                TNGS_Carm.dbo.CliContactos_EstaActivo (clc_nro_numcliente,clc_nro_numcontacto) as clc_cd1_activo,
                clc_tel_celular,
                clc_tel_telefono1,
                clc_tel_telefono2,
                clc_tel_interno,
                clc_xld_email,
                clc_des_secretaria,
                TNGS_Carm..CliContactos.instante,
                TNGS_Carm..CliContactos.deleted,
                TNGS_Carm..CliContactos.usuario,
                TNGS_Carm..CliContactos.version
           from TNGS_Carm..CliContactos
                join TNGS_Carm..Clientes
                  on clc_nro_numcliente = cli_nro_numero
          where clc_nro_numcliente = @clc_nro_numcliente
          order by clc_nro_numcontacto
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLICONTACTOS_FSEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@clc_nro_numcliente">Número de cliente</param>
--- <param name="@clc_nro_numcontacto">Número</param>
--- <param name="@clc_des_nombre">Apellido y Nombre</param>
--- <param name="@clc_des_cargo">Cargo</param>
--- <param name="@clc_des_titulo">Título</param>
--- <param name="@clc_tel_celular">Celular</param>
--- <param name="@clc_tel_telefono1">Teléfono 1</param>
--- <param name="@clc_tel_telefono2">Teléfono 2</param>
--- <param name="@clc_tel_interno">Interno</param>
--- <param name="@clc_xld_email">Email</param>
--- <param name="@clc_des_secretaria">Secretaria</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLICONTACTOS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.CLICONTACTOS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLICONTACTOS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLICONTACTOS_INSERT
(
@clc_nro_numcliente tngs_numero,
@clc_nro_numcontacto tngs_numero,
@clc_des_nombre tngs_descripcion,
@clc_des_cargo tngs_descripcion,
@clc_des_titulo tngs_descripcion,
@clc_tel_celular tngs_telefono,
@clc_tel_telefono1 tngs_telefono,
@clc_tel_telefono2 tngs_telefono,
@clc_tel_interno tngs_telefono,
@clc_xld_email tngs_descripcion_xl,
@clc_des_secretaria tngs_descripcion,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Carm..CliContactos
   values (
           @clc_nro_numcliente,
           @clc_nro_numcontacto,
           @clc_des_nombre,
           @clc_des_cargo,
           @clc_des_titulo,
           @clc_tel_celular,
           @clc_tel_telefono1,
           @clc_tel_telefono2,
           @clc_tel_interno,
           @clc_xld_email,
           @clc_des_secretaria,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLICONTACTOS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@clc_nro_numcliente">Número de cliente</param>
--- <param name="@clc_nro_numcontacto">Número</param>
--- <param name="@clc_des_nombre">Apellido y Nombre</param>
--- <param name="@clc_des_cargo">Cargo</param>
--- <param name="@clc_des_titulo">Título</param>
--- <param name="@clc_tel_celular">Celular</param>
--- <param name="@clc_tel_telefono1">Teléfono 1</param>
--- <param name="@clc_tel_telefono2">Teléfono 2</param>
--- <param name="@clc_tel_interno">Interno</param>
--- <param name="@clc_xld_email">Email</param>
--- <param name="@clc_des_secretaria">Secretaria</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLICONTACTOS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.CLICONTACTOS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLICONTACTOS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLICONTACTOS_UPDATE
(
@clc_nro_numcliente tngs_numero,
@clc_nro_numcontacto tngs_numero,
@clc_des_nombre tngs_descripcion,
@clc_des_cargo tngs_descripcion,
@clc_des_titulo tngs_descripcion,
@clc_tel_celular tngs_telefono,
@clc_tel_telefono1 tngs_telefono,
@clc_tel_telefono2 tngs_telefono,
@clc_tel_interno tngs_telefono,
@clc_xld_email tngs_descripcion_xl,
@clc_des_secretaria tngs_descripcion,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..CliContactos
      set clc_des_nombre= @clc_des_nombre,
          clc_des_cargo= @clc_des_cargo,
          clc_des_titulo= @clc_des_titulo,
          clc_tel_celular= @clc_tel_celular,
          clc_tel_telefono1= @clc_tel_telefono1,
          clc_tel_telefono2= @clc_tel_telefono2,
          clc_tel_interno= @clc_tel_interno,
          clc_xld_email= @clc_xld_email,
          clc_des_secretaria= @clc_des_secretaria,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where clc_nro_numcliente = @clc_nro_numcliente
      and clc_nro_numcontacto = @clc_nro_numcontacto

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLICONTACTOS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@clc_nro_numcliente">Número de cliente</param>
--- <param name="@clc_nro_numcontacto">Número</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLICONTACTOS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.CLICONTACTOS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLICONTACTOS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLICONTACTOS_DELETE
(
@clc_nro_numcliente tngs_numero,
@clc_nro_numcontacto tngs_numero,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..CliContactos
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where clc_nro_numcliente = @clc_nro_numcliente
      and clc_nro_numcontacto = @clc_nro_numcontacto

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLICONTACTOS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro por clave foranea
--- </summary>
--- <param name="@clc_nro_numcliente">Número de cliente</param>
--- <param name="@instante">Instante del delete</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLICONTACTOS_FDELETE'

if exists (select * from sysobjects where id = object_id('dbo.CLICONTACTOS_FDELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLICONTACTOS_FDELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLICONTACTOS_FDELETE
(
@clc_nro_numcliente tngs_numero,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         select @instante= getdate()
      end

   Update TNGS_Carm..CliContactos
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= @instante,
          usuario = @usuario
    where clc_nro_numcliente = @clc_nro_numcliente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLICONTACTOS_FDELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@clc_nro_numcliente">Número de cliente</param>
--- <param name="@clc_nro_numcontacto">Número</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLICONTACTOS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.CLICONTACTOS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLICONTACTOS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLICONTACTOS_RECALL
(
@clc_nro_numcliente tngs_numero,
@clc_nro_numcontacto tngs_numero,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..CliContactos
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where clc_nro_numcliente = @clc_nro_numcliente
      and clc_nro_numcontacto = @clc_nro_numcontacto

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLICONTACTOS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera lógicamente los registros de una clave foranea
--- </summary>
--- <param name="@clc_nro_numcliente">Número de cliente</param>
--- <param name="@instante">Instante de referencia</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLICONTACTOS_FRECALL'

if exists (select * from sysobjects where id = object_id('dbo.CLICONTACTOS_FRECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLICONTACTOS_FRECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLICONTACTOS_FRECALL
(
@clc_nro_numcliente tngs_numero,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         Update TNGS_Carm..CliContactos
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where clc_nro_numcliente = @clc_nro_numcliente
      end
   else
      begin
         Update TNGS_Carm..CliContactos
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where clc_nro_numcliente = @clc_nro_numcliente
            and instante= @instante
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLICONTACTOS_FRECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@clc_nro_numcliente">Número de cliente</param>
--- <param name="@clc_nro_numcontacto">Número</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLICONTACTOS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.CLICONTACTOS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLICONTACTOS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLICONTACTOS_DROP
(
@clc_nro_numcliente tngs_numero,
@clc_nro_numcontacto tngs_numero,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..CliContactos
    where clc_nro_numcliente = @clc_nro_numcliente
      and clc_nro_numcontacto = @clc_nro_numcontacto

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLICONTACTOS_DROP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro por clave foránea
--- </summary>
--- <param name="@clc_nro_numcliente">Número de cliente</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLICONTACTOS_FDROP'

if exists (select * from sysobjects where id = object_id('dbo.CLICONTACTOS_FDROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLICONTACTOS_FDROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLICONTACTOS_FDROP
(
@clc_nro_numcliente tngs_numero,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..CliContactos
    where clc_nro_numcliente = @clc_nro_numcliente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLICONTACTOS_FDROP to tngsmodulos

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

print 'Store Procedure: dbo.CLICONTACTOS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.CLICONTACTOS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLICONTACTOS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLICONTACTOS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Carm..CliContactos
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLICONTACTOS_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente los registro borrados lógicamente por clave foránea
--- </summary>
--- <param name="@clc_nro_numcliente">Número de cliente</param>
--- <param name="@usuario">Usuario que realiza el pack</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLICONTACTOS_FPACK'

if exists (select * from sysobjects where id = object_id('dbo.CLICONTACTOS_FPACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLICONTACTOS_FPACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLICONTACTOS_FPACK
(
@clc_nro_numcliente tngs_numero,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..CliContactos
    where clc_nro_numcliente = @clc_nro_numcliente
      and deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLICONTACTOS_FPACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: BorraPorCliente
--- </summary>
--- <param name="@nrocliente">Numero del cliente a borrar sus contactos</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLICONTACTOS_BORRAPORCLIENTE'

if exists (select * from sysobjects where id = object_id('dbo.CLICONTACTOS_BORRAPORCLIENTE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLICONTACTOS_BORRAPORCLIENTE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLICONTACTOS_BORRAPORCLIENTE
(
@nrocliente tngs_numero,
@usuario tngs_nombre
)
as
begin

   delete from CliContactos 
   where clc_nro_numcliente = @nrocliente 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLICONTACTOS_BORRAPORCLIENTE to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: CliContactos
//--------------------------------------------------------------------------*/
