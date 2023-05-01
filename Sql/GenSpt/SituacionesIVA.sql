/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 30/04/2023 21:00
// Sistema     : Carm
// Tabla       : SituacionesIVA
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

print 'Store Procedure: dbo.SITUACIONESIVA_UP'

if exists (select * from sysobjects where id = object_id('dbo.SITUACIONESIVA_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SITUACIONESIVA_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SITUACIONESIVA_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select siv_rcd_codigo,
                siv_des_descripcion,
                siv_cd1_discrimina,
                TNGS_Carm..SituacionesIVA.instante,
                TNGS_Carm..SituacionesIVA.deleted,
                TNGS_Carm..SituacionesIVA.usuario,
                TNGS_Carm..SituacionesIVA.version
           from TNGS_Carm..SituacionesIVA
          where deleted = 0
          order by siv_rcd_codigo
      end
   else
      begin
         Select siv_rcd_codigo,
                siv_des_descripcion,
                siv_cd1_discrimina,
                TNGS_Carm..SituacionesIVA.instante,
                TNGS_Carm..SituacionesIVA.deleted,
                TNGS_Carm..SituacionesIVA.usuario,
                TNGS_Carm..SituacionesIVA.version
           from TNGS_Carm..SituacionesIVA
          order by siv_rcd_codigo
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SITUACIONESIVA_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@siv_rcd_codigo">Codigo</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.SITUACIONESIVA_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.SITUACIONESIVA_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SITUACIONESIVA_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SITUACIONESIVA_CHKVERSION
(
@siv_rcd_codigo tngs_codigo_r,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Carm..SituacionesIVA
    where siv_rcd_codigo = @siv_rcd_codigo
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SITUACIONESIVA_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@siv_rcd_codigo">Codigo</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.SITUACIONESIVA_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.SITUACIONESIVA_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SITUACIONESIVA_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SITUACIONESIVA_SEARCH
(
@siv_rcd_codigo tngs_codigo_r,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select siv_rcd_codigo,
                siv_des_descripcion,
                siv_cd1_discrimina,
                TNGS_Carm..SituacionesIVA.instante,
                TNGS_Carm..SituacionesIVA.deleted,
                TNGS_Carm..SituacionesIVA.usuario,
                TNGS_Carm..SituacionesIVA.version
           from TNGS_Carm..SituacionesIVA
          where siv_rcd_codigo = @siv_rcd_codigo
            and deleted = 0
      end
   else
      begin
         Select siv_rcd_codigo,
                siv_des_descripcion,
                siv_cd1_discrimina,
                TNGS_Carm..SituacionesIVA.instante,
                TNGS_Carm..SituacionesIVA.deleted,
                TNGS_Carm..SituacionesIVA.usuario,
                TNGS_Carm..SituacionesIVA.version
           from TNGS_Carm..SituacionesIVA
          where siv_rcd_codigo = @siv_rcd_codigo
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SITUACIONESIVA_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@siv_rcd_codigo">Codigo</param>
--- <param name="@siv_des_descripcion">Descripcion</param>
--- <param name="@siv_cd1_discrimina">Discrimina</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.SITUACIONESIVA_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.SITUACIONESIVA_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SITUACIONESIVA_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SITUACIONESIVA_INSERT
(
@siv_rcd_codigo tngs_codigo_r,
@siv_des_descripcion tngs_descripcion,
@siv_cd1_discrimina tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Carm..SituacionesIVA
   values (
           @siv_rcd_codigo,
           @siv_des_descripcion,
           @siv_cd1_discrimina,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SITUACIONESIVA_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@siv_rcd_codigo">Codigo</param>
--- <param name="@siv_des_descripcion">Descripcion</param>
--- <param name="@siv_cd1_discrimina">Discrimina</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.SITUACIONESIVA_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.SITUACIONESIVA_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SITUACIONESIVA_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SITUACIONESIVA_UPDATE
(
@siv_rcd_codigo tngs_codigo_r,
@siv_des_descripcion tngs_descripcion,
@siv_cd1_discrimina tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..SituacionesIVA
      set siv_des_descripcion= @siv_des_descripcion,
          siv_cd1_discrimina= @siv_cd1_discrimina,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where siv_rcd_codigo = @siv_rcd_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SITUACIONESIVA_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@siv_rcd_codigo">Codigo</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.SITUACIONESIVA_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.SITUACIONESIVA_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SITUACIONESIVA_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SITUACIONESIVA_DELETE
(
@siv_rcd_codigo tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..SituacionesIVA
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where siv_rcd_codigo = @siv_rcd_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SITUACIONESIVA_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@siv_rcd_codigo">Codigo</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.SITUACIONESIVA_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.SITUACIONESIVA_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SITUACIONESIVA_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SITUACIONESIVA_RECALL
(
@siv_rcd_codigo tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..SituacionesIVA
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where siv_rcd_codigo = @siv_rcd_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SITUACIONESIVA_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@siv_rcd_codigo">Codigo</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.SITUACIONESIVA_DROP'

if exists (select * from sysobjects where id = object_id('dbo.SITUACIONESIVA_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SITUACIONESIVA_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SITUACIONESIVA_DROP
(
@siv_rcd_codigo tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..SituacionesIVA
    where siv_rcd_codigo = @siv_rcd_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SITUACIONESIVA_DROP to tngsmodulos

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

print 'Store Procedure: dbo.SITUACIONESIVA_PACK'

if exists (select * from sysobjects where id = object_id('dbo.SITUACIONESIVA_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SITUACIONESIVA_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SITUACIONESIVA_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Carm..SituacionesIVA
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SITUACIONESIVA_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: SituacionesIVA
//--------------------------------------------------------------------------*/
