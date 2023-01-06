/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 06/01/2023 01:01
// Sistema     : Carm
// Tabla       : Marcas
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

print 'Store Procedure: dbo.MARCAS_UP'

if exists (select * from sysobjects where id = object_id('dbo.MARCAS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MARCAS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MARCAS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mrc_rcd_cod,
                mrc_ede_des,
                mrc_ecd_codlocalidad,
                isnull(loc_ede_nombre, '') as des_localidad,
                TNGS_Carm..Marcas.instante,
                TNGS_Carm..Marcas.deleted,
                TNGS_Carm..Marcas.usuario,
                TNGS_Carm..Marcas.version
           from TNGS_Carm..Marcas
                join TNGS_Carm..Localidades
                  on mrc_ecd_codlocalidad = loc_ecd_codpost
          where TNGS_Carm..Marcas.deleted = 0
          order by mrc_rcd_cod
      end
   else
      begin
         Select mrc_rcd_cod,
                mrc_ede_des,
                mrc_ecd_codlocalidad,
                isnull(loc_ede_nombre, '') as des_localidad,
                TNGS_Carm..Marcas.instante,
                TNGS_Carm..Marcas.deleted,
                TNGS_Carm..Marcas.usuario,
                TNGS_Carm..Marcas.version
           from TNGS_Carm..Marcas
                join TNGS_Carm..Localidades
                  on mrc_ecd_codlocalidad = loc_ecd_codpost
          order by mrc_rcd_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MARCAS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@mrc_rcd_cod">Codigo</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MARCAS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.MARCAS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MARCAS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MARCAS_CHKVERSION
(
@mrc_rcd_cod tngs_codigo_r,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Carm..Marcas
    where mrc_rcd_cod = @mrc_rcd_cod
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MARCAS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@mrc_rcd_cod">Codigo</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MARCAS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.MARCAS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MARCAS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MARCAS_SEARCH
(
@mrc_rcd_cod tngs_codigo_r,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mrc_rcd_cod,
                mrc_ede_des,
                mrc_ecd_codlocalidad,
                isnull(loc_ede_nombre, '') as des_localidad,
                TNGS_Carm..Marcas.instante,
                TNGS_Carm..Marcas.deleted,
                TNGS_Carm..Marcas.usuario,
                TNGS_Carm..Marcas.version
           from TNGS_Carm..Marcas
                join TNGS_Carm..Localidades
                  on mrc_ecd_codlocalidad = loc_ecd_codpost
          where mrc_rcd_cod = @mrc_rcd_cod
            and TNGS_Carm..Marcas.deleted = 0
      end
   else
      begin
         Select mrc_rcd_cod,
                mrc_ede_des,
                mrc_ecd_codlocalidad,
                isnull(loc_ede_nombre, '') as des_localidad,
                TNGS_Carm..Marcas.instante,
                TNGS_Carm..Marcas.deleted,
                TNGS_Carm..Marcas.usuario,
                TNGS_Carm..Marcas.version
           from TNGS_Carm..Marcas
                join TNGS_Carm..Localidades
                  on mrc_ecd_codlocalidad = loc_ecd_codpost
          where mrc_rcd_cod = @mrc_rcd_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MARCAS_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@mrc_rcd_cod">Codigo</param>
--- <param name="@mrc_ede_des">Descripcion</param>
--- <param name="@mrc_ecd_codlocalidad">Localidad</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MARCAS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.MARCAS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MARCAS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MARCAS_INSERT
(
@mrc_rcd_cod tngs_codigo_r,
@mrc_ede_des tngs_descripcion_e,
@mrc_ecd_codlocalidad tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Carm..Marcas
   values (
           @mrc_rcd_cod,
           @mrc_ede_des,
           @mrc_ecd_codlocalidad,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MARCAS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@mrc_rcd_cod">Codigo</param>
--- <param name="@mrc_ede_des">Descripcion</param>
--- <param name="@mrc_ecd_codlocalidad">Localidad</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MARCAS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.MARCAS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MARCAS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MARCAS_UPDATE
(
@mrc_rcd_cod tngs_codigo_r,
@mrc_ede_des tngs_descripcion_e,
@mrc_ecd_codlocalidad tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Marcas
      set mrc_ede_des= @mrc_ede_des,
          mrc_ecd_codlocalidad= @mrc_ecd_codlocalidad,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mrc_rcd_cod = @mrc_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MARCAS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@mrc_rcd_cod">Codigo</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MARCAS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.MARCAS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MARCAS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MARCAS_DELETE
(
@mrc_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Marcas
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mrc_rcd_cod = @mrc_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MARCAS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@mrc_rcd_cod">Codigo</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MARCAS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.MARCAS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MARCAS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MARCAS_RECALL
(
@mrc_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Marcas
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mrc_rcd_cod = @mrc_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MARCAS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@mrc_rcd_cod">Codigo</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MARCAS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.MARCAS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MARCAS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MARCAS_DROP
(
@mrc_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..Marcas
    where mrc_rcd_cod = @mrc_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MARCAS_DROP to tngsmodulos

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

print 'Store Procedure: dbo.MARCAS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.MARCAS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MARCAS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MARCAS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Carm..Marcas
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MARCAS_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Marcas
//--------------------------------------------------------------------------*/
