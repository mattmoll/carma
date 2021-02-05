/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 05/02/2021 12:21
// Sistema     : Carm
// Tabla       : Parentescos
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

print 'Store Procedure: dbo.PARENTESCOS_UP'

if exists (select * from sysobjects where id = object_id('dbo.PARENTESCOS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PARENTESCOS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PARENTESCOS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select prt_rcd_cod,
                prt_des_des,
                TNGS_Carm..Parentescos.instante,
                TNGS_Carm..Parentescos.deleted,
                TNGS_Carm..Parentescos.usuario,
                TNGS_Carm..Parentescos.version
           from TNGS_Carm..Parentescos
          where deleted = 0
          order by prt_rcd_cod
      end
   else
      begin
         Select prt_rcd_cod,
                prt_des_des,
                TNGS_Carm..Parentescos.instante,
                TNGS_Carm..Parentescos.deleted,
                TNGS_Carm..Parentescos.usuario,
                TNGS_Carm..Parentescos.version
           from TNGS_Carm..Parentescos
          order by prt_rcd_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PARENTESCOS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@prt_rcd_cod">Codigo</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PARENTESCOS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.PARENTESCOS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PARENTESCOS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PARENTESCOS_CHKVERSION
(
@prt_rcd_cod tngs_codigo_r,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Carm..Parentescos
    where prt_rcd_cod = @prt_rcd_cod
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PARENTESCOS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@prt_rcd_cod">Codigo</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PARENTESCOS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.PARENTESCOS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PARENTESCOS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PARENTESCOS_SEARCH
(
@prt_rcd_cod tngs_codigo_r,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select prt_rcd_cod,
                prt_des_des,
                TNGS_Carm..Parentescos.instante,
                TNGS_Carm..Parentescos.deleted,
                TNGS_Carm..Parentescos.usuario,
                TNGS_Carm..Parentescos.version
           from TNGS_Carm..Parentescos
          where prt_rcd_cod = @prt_rcd_cod
            and deleted = 0
      end
   else
      begin
         Select prt_rcd_cod,
                prt_des_des,
                TNGS_Carm..Parentescos.instante,
                TNGS_Carm..Parentescos.deleted,
                TNGS_Carm..Parentescos.usuario,
                TNGS_Carm..Parentescos.version
           from TNGS_Carm..Parentescos
          where prt_rcd_cod = @prt_rcd_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PARENTESCOS_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@prt_rcd_cod">Codigo</param>
--- <param name="@prt_des_des">Descripcion</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PARENTESCOS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.PARENTESCOS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PARENTESCOS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PARENTESCOS_INSERT
(
@prt_rcd_cod tngs_codigo_r,
@prt_des_des tngs_descripcion,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Carm..Parentescos
   values (
           @prt_rcd_cod,
           @prt_des_des,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PARENTESCOS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@prt_rcd_cod">Codigo</param>
--- <param name="@prt_des_des">Descripcion</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PARENTESCOS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.PARENTESCOS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PARENTESCOS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PARENTESCOS_UPDATE
(
@prt_rcd_cod tngs_codigo_r,
@prt_des_des tngs_descripcion,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Parentescos
      set prt_des_des= @prt_des_des,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where prt_rcd_cod = @prt_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PARENTESCOS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@prt_rcd_cod">Codigo</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PARENTESCOS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.PARENTESCOS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PARENTESCOS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PARENTESCOS_DELETE
(
@prt_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Parentescos
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where prt_rcd_cod = @prt_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PARENTESCOS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@prt_rcd_cod">Codigo</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PARENTESCOS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.PARENTESCOS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PARENTESCOS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PARENTESCOS_RECALL
(
@prt_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Parentescos
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where prt_rcd_cod = @prt_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PARENTESCOS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@prt_rcd_cod">Codigo</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PARENTESCOS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.PARENTESCOS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PARENTESCOS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PARENTESCOS_DROP
(
@prt_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..Parentescos
    where prt_rcd_cod = @prt_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PARENTESCOS_DROP to tngsmodulos

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

print 'Store Procedure: dbo.PARENTESCOS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.PARENTESCOS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PARENTESCOS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PARENTESCOS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Carm..Parentescos
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PARENTESCOS_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Parentescos
//--------------------------------------------------------------------------*/
