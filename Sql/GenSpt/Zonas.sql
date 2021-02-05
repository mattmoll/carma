/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 05/02/2021 12:21
// Sistema     : Carm
// Tabla       : Zonas
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

print 'Store Procedure: dbo.ZONAS_UP'

if exists (select * from sysobjects where id = object_id('dbo.ZONAS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ZONAS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ZONAS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select zns_rcd_cod,
                zns_des_nombre,
                zns_txt_geoloc,
                TNGS_Carm..Zonas.instante,
                TNGS_Carm..Zonas.deleted,
                TNGS_Carm..Zonas.usuario,
                TNGS_Carm..Zonas.version
           from TNGS_Carm..Zonas
          where deleted = 0
          order by zns_rcd_cod
      end
   else
      begin
         Select zns_rcd_cod,
                zns_des_nombre,
                zns_txt_geoloc,
                TNGS_Carm..Zonas.instante,
                TNGS_Carm..Zonas.deleted,
                TNGS_Carm..Zonas.usuario,
                TNGS_Carm..Zonas.version
           from TNGS_Carm..Zonas
          order by zns_rcd_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ZONAS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@zns_rcd_cod">Código</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ZONAS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.ZONAS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ZONAS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ZONAS_CHKVERSION
(
@zns_rcd_cod tngs_codigo_r,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Carm..Zonas
    where zns_rcd_cod = @zns_rcd_cod
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ZONAS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@zns_rcd_cod">Código</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ZONAS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.ZONAS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ZONAS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ZONAS_SEARCH
(
@zns_rcd_cod tngs_codigo_r,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select zns_rcd_cod,
                zns_des_nombre,
                zns_txt_geoloc,
                TNGS_Carm..Zonas.instante,
                TNGS_Carm..Zonas.deleted,
                TNGS_Carm..Zonas.usuario,
                TNGS_Carm..Zonas.version
           from TNGS_Carm..Zonas
          where zns_rcd_cod = @zns_rcd_cod
            and deleted = 0
      end
   else
      begin
         Select zns_rcd_cod,
                zns_des_nombre,
                zns_txt_geoloc,
                TNGS_Carm..Zonas.instante,
                TNGS_Carm..Zonas.deleted,
                TNGS_Carm..Zonas.usuario,
                TNGS_Carm..Zonas.version
           from TNGS_Carm..Zonas
          where zns_rcd_cod = @zns_rcd_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ZONAS_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca la clave máxima de la tabla
--- </summary>
--- <param name="@reservado">Reservado para futuras expansiones</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ZONAS_GETMAXKEY'

if exists (select * from sysobjects where id = object_id('dbo.ZONAS_GETMAXKEY'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ZONAS_GETMAXKEY
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ZONAS_GETMAXKEY
(
@dummy tngs_codigo_1
)
as
begin

   Select isnull(max(zns_rcd_cod), '0') as zns_rcd_cod
     from TNGS_Carm..Zonas

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ZONAS_GETMAXKEY to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@zns_rcd_cod">Código</param>
--- <param name="@zns_des_nombre">Nombre de la zona</param>
--- <param name="@zns_txt_geoloc">Geolocalización</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ZONAS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.ZONAS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ZONAS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ZONAS_INSERT
(
@zns_rcd_cod tngs_codigo_r,
@zns_des_nombre tngs_descripcion,
@zns_txt_geoloc tngs_texto,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Carm..Zonas
   values (
           @zns_rcd_cod,
           @zns_des_nombre,
           @zns_txt_geoloc,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ZONAS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@zns_rcd_cod">Código</param>
--- <param name="@zns_des_nombre">Nombre de la zona</param>
--- <param name="@zns_txt_geoloc">Geolocalización</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ZONAS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.ZONAS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ZONAS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ZONAS_UPDATE
(
@zns_rcd_cod tngs_codigo_r,
@zns_des_nombre tngs_descripcion,
@zns_txt_geoloc tngs_texto,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Zonas
      set zns_des_nombre= @zns_des_nombre,
          zns_txt_geoloc= @zns_txt_geoloc,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where zns_rcd_cod = @zns_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ZONAS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@zns_rcd_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ZONAS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.ZONAS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ZONAS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ZONAS_DELETE
(
@zns_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Zonas
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where zns_rcd_cod = @zns_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ZONAS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@zns_rcd_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ZONAS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.ZONAS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ZONAS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ZONAS_RECALL
(
@zns_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Zonas
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where zns_rcd_cod = @zns_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ZONAS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@zns_rcd_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ZONAS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.ZONAS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ZONAS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ZONAS_DROP
(
@zns_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..Zonas
    where zns_rcd_cod = @zns_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ZONAS_DROP to tngsmodulos

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

print 'Store Procedure: dbo.ZONAS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.ZONAS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ZONAS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ZONAS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Carm..Zonas
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ZONAS_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Zonas
//--------------------------------------------------------------------------*/
