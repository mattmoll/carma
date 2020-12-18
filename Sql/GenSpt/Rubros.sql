/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 18/12/2020 01:46
// Sistema     : Carm
// Tabla       : Rubros
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

print 'Store Procedure: dbo.RUBROS_UP'

if exists (select * from sysobjects where id = object_id('dbo.RUBROS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.RUBROS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.RUBROS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select rbr_rcd_cod,
                rbr_des_des,
                TNGS_Carm..Rubros.instante,
                TNGS_Carm..Rubros.deleted,
                TNGS_Carm..Rubros.usuario,
                TNGS_Carm..Rubros.version
           from TNGS_Carm..Rubros
          where deleted = 0
          order by rbr_rcd_cod
      end
   else
      begin
         Select rbr_rcd_cod,
                rbr_des_des,
                TNGS_Carm..Rubros.instante,
                TNGS_Carm..Rubros.deleted,
                TNGS_Carm..Rubros.usuario,
                TNGS_Carm..Rubros.version
           from TNGS_Carm..Rubros
          order by rbr_rcd_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.RUBROS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@rbr_rcd_cod">Código</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.RUBROS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.RUBROS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.RUBROS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.RUBROS_CHKVERSION
(
@rbr_rcd_cod tngs_codigo_r,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Carm..Rubros
    where rbr_rcd_cod = @rbr_rcd_cod
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.RUBROS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@rbr_rcd_cod">Código</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.RUBROS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.RUBROS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.RUBROS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.RUBROS_SEARCH
(
@rbr_rcd_cod tngs_codigo_r,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select rbr_rcd_cod,
                rbr_des_des,
                TNGS_Carm..Rubros.instante,
                TNGS_Carm..Rubros.deleted,
                TNGS_Carm..Rubros.usuario,
                TNGS_Carm..Rubros.version
           from TNGS_Carm..Rubros
          where rbr_rcd_cod = @rbr_rcd_cod
            and deleted = 0
      end
   else
      begin
         Select rbr_rcd_cod,
                rbr_des_des,
                TNGS_Carm..Rubros.instante,
                TNGS_Carm..Rubros.deleted,
                TNGS_Carm..Rubros.usuario,
                TNGS_Carm..Rubros.version
           from TNGS_Carm..Rubros
          where rbr_rcd_cod = @rbr_rcd_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.RUBROS_SEARCH to tngsmodulos

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

print 'Store Procedure: dbo.RUBROS_GETMAXKEY'

if exists (select * from sysobjects where id = object_id('dbo.RUBROS_GETMAXKEY'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.RUBROS_GETMAXKEY
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.RUBROS_GETMAXKEY
(
@dummy tngs_codigo_1
)
as
begin

   Select isnull(max(rbr_rcd_cod), '0') as rbr_rcd_cod
     from TNGS_Carm..Rubros

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.RUBROS_GETMAXKEY to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@rbr_rcd_cod">Código</param>
--- <param name="@rbr_des_des">Descripción</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.RUBROS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.RUBROS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.RUBROS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.RUBROS_INSERT
(
@rbr_rcd_cod tngs_codigo_r,
@rbr_des_des tngs_descripcion,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Carm..Rubros
   values (
           @rbr_rcd_cod,
           @rbr_des_des,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.RUBROS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@rbr_rcd_cod">Código</param>
--- <param name="@rbr_des_des">Descripción</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.RUBROS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.RUBROS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.RUBROS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.RUBROS_UPDATE
(
@rbr_rcd_cod tngs_codigo_r,
@rbr_des_des tngs_descripcion,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Rubros
      set rbr_des_des= @rbr_des_des,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where rbr_rcd_cod = @rbr_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.RUBROS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@rbr_rcd_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.RUBROS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.RUBROS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.RUBROS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.RUBROS_DELETE
(
@rbr_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Rubros
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where rbr_rcd_cod = @rbr_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.RUBROS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@rbr_rcd_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.RUBROS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.RUBROS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.RUBROS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.RUBROS_RECALL
(
@rbr_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Rubros
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where rbr_rcd_cod = @rbr_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.RUBROS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@rbr_rcd_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.RUBROS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.RUBROS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.RUBROS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.RUBROS_DROP
(
@rbr_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..Rubros
    where rbr_rcd_cod = @rbr_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.RUBROS_DROP to tngsmodulos

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

print 'Store Procedure: dbo.RUBROS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.RUBROS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.RUBROS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.RUBROS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Carm..Rubros
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.RUBROS_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Rubros
//--------------------------------------------------------------------------*/
