/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 04/01/2023 00:01
// Sistema     : Carm
// Tabla       : LogClientes
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

print 'Store Procedure: dbo.LOGCLIENTES_UP'

if exists (select * from sysobjects where id = object_id('dbo.LOGCLIENTES_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.LOGCLIENTES_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.LOGCLIENTES_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select lgc_nro_nro,
                lgc_nro_nrocliente,
                lgc_nro_nroavalon,
                lgc_ede_rsocial,
                lgc_des_nomfantasia,
                lgc_des_accion,
                lgc_nom_usuario,
                lgc_fyh_fecha,
                TNGS_Carm..LogClientes.instante,
                TNGS_Carm..LogClientes.deleted,
                TNGS_Carm..LogClientes.usuario,
                TNGS_Carm..LogClientes.version
           from TNGS_Carm..LogClientes
          where deleted = 0
          order by lgc_nro_nro
      end
   else
      begin
         Select lgc_nro_nro,
                lgc_nro_nrocliente,
                lgc_nro_nroavalon,
                lgc_ede_rsocial,
                lgc_des_nomfantasia,
                lgc_des_accion,
                lgc_nom_usuario,
                lgc_fyh_fecha,
                TNGS_Carm..LogClientes.instante,
                TNGS_Carm..LogClientes.deleted,
                TNGS_Carm..LogClientes.usuario,
                TNGS_Carm..LogClientes.version
           from TNGS_Carm..LogClientes
          order by lgc_nro_nro
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.LOGCLIENTES_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@lgc_nro_nro">Numero</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.LOGCLIENTES_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.LOGCLIENTES_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.LOGCLIENTES_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.LOGCLIENTES_CHKVERSION
(
@lgc_nro_nro tngs_numero,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Carm..LogClientes
    where lgc_nro_nro = @lgc_nro_nro
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.LOGCLIENTES_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@lgc_nro_nro">Numero</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.LOGCLIENTES_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.LOGCLIENTES_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.LOGCLIENTES_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.LOGCLIENTES_SEARCH
(
@lgc_nro_nro tngs_numero,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select lgc_nro_nro,
                lgc_nro_nrocliente,
                lgc_nro_nroavalon,
                lgc_ede_rsocial,
                lgc_des_nomfantasia,
                lgc_des_accion,
                lgc_nom_usuario,
                lgc_fyh_fecha,
                TNGS_Carm..LogClientes.instante,
                TNGS_Carm..LogClientes.deleted,
                TNGS_Carm..LogClientes.usuario,
                TNGS_Carm..LogClientes.version
           from TNGS_Carm..LogClientes
          where lgc_nro_nro = @lgc_nro_nro
            and deleted = 0
      end
   else
      begin
         Select lgc_nro_nro,
                lgc_nro_nrocliente,
                lgc_nro_nroavalon,
                lgc_ede_rsocial,
                lgc_des_nomfantasia,
                lgc_des_accion,
                lgc_nom_usuario,
                lgc_fyh_fecha,
                TNGS_Carm..LogClientes.instante,
                TNGS_Carm..LogClientes.deleted,
                TNGS_Carm..LogClientes.usuario,
                TNGS_Carm..LogClientes.version
           from TNGS_Carm..LogClientes
          where lgc_nro_nro = @lgc_nro_nro
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.LOGCLIENTES_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@lgc_nro_nro">Numero</param>
--- <param name="@lgc_nro_nrocliente">Número Cliente</param>
--- <param name="@lgc_nro_nroavalon">Número Avalon</param>
--- <param name="@lgc_ede_rsocial">Razon Social</param>
--- <param name="@lgc_des_nomfantasia">Nombre Fantasia</param>
--- <param name="@lgc_des_accion">Acción</param>
--- <param name="@lgc_nom_usuario">Usuario</param>
--- <param name="@lgc_fyh_fecha">Fecha</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.LOGCLIENTES_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.LOGCLIENTES_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.LOGCLIENTES_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.LOGCLIENTES_INSERT
(
@lgc_nro_nro tngs_numero,
@lgc_nro_nrocliente tngs_numero,
@lgc_nro_nroavalon tngs_numero,
@lgc_ede_rsocial tngs_descripcion_e,
@lgc_des_nomfantasia tngs_descripcion,
@lgc_des_accion tngs_descripcion,
@lgc_nom_usuario tngs_nombre,
@lgc_fyh_fecha tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Carm..LogClientes
   values (
           @lgc_nro_nro,
           @lgc_nro_nrocliente,
           @lgc_nro_nroavalon,
           @lgc_ede_rsocial,
           @lgc_des_nomfantasia,
           @lgc_des_accion,
           @lgc_nom_usuario,
           @lgc_fyh_fecha,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.LOGCLIENTES_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@lgc_nro_nro">Numero</param>
--- <param name="@lgc_nro_nrocliente">Número Cliente</param>
--- <param name="@lgc_nro_nroavalon">Número Avalon</param>
--- <param name="@lgc_ede_rsocial">Razon Social</param>
--- <param name="@lgc_des_nomfantasia">Nombre Fantasia</param>
--- <param name="@lgc_des_accion">Acción</param>
--- <param name="@lgc_nom_usuario">Usuario</param>
--- <param name="@lgc_fyh_fecha">Fecha</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.LOGCLIENTES_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.LOGCLIENTES_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.LOGCLIENTES_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.LOGCLIENTES_UPDATE
(
@lgc_nro_nro tngs_numero,
@lgc_nro_nrocliente tngs_numero,
@lgc_nro_nroavalon tngs_numero,
@lgc_ede_rsocial tngs_descripcion_e,
@lgc_des_nomfantasia tngs_descripcion,
@lgc_des_accion tngs_descripcion,
@lgc_nom_usuario tngs_nombre,
@lgc_fyh_fecha tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..LogClientes
      set lgc_nro_nrocliente= @lgc_nro_nrocliente,
          lgc_nro_nroavalon= @lgc_nro_nroavalon,
          lgc_ede_rsocial= @lgc_ede_rsocial,
          lgc_des_nomfantasia= @lgc_des_nomfantasia,
          lgc_des_accion= @lgc_des_accion,
          lgc_nom_usuario= @lgc_nom_usuario,
          lgc_fyh_fecha= @lgc_fyh_fecha,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where lgc_nro_nro = @lgc_nro_nro

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.LOGCLIENTES_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@lgc_nro_nro">Numero</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.LOGCLIENTES_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.LOGCLIENTES_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.LOGCLIENTES_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.LOGCLIENTES_DELETE
(
@lgc_nro_nro tngs_numero,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..LogClientes
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where lgc_nro_nro = @lgc_nro_nro

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.LOGCLIENTES_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@lgc_nro_nro">Numero</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.LOGCLIENTES_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.LOGCLIENTES_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.LOGCLIENTES_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.LOGCLIENTES_RECALL
(
@lgc_nro_nro tngs_numero,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..LogClientes
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where lgc_nro_nro = @lgc_nro_nro

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.LOGCLIENTES_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@lgc_nro_nro">Numero</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.LOGCLIENTES_DROP'

if exists (select * from sysobjects where id = object_id('dbo.LOGCLIENTES_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.LOGCLIENTES_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.LOGCLIENTES_DROP
(
@lgc_nro_nro tngs_numero,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..LogClientes
    where lgc_nro_nro = @lgc_nro_nro

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.LOGCLIENTES_DROP to tngsmodulos

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

print 'Store Procedure: dbo.LOGCLIENTES_PACK'

if exists (select * from sysobjects where id = object_id('dbo.LOGCLIENTES_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.LOGCLIENTES_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.LOGCLIENTES_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Carm..LogClientes
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.LOGCLIENTES_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: LogClientes
//--------------------------------------------------------------------------*/
