/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 04/01/2023 00:01
// Sistema     : Carm
// Tabla       : CategoriasLlamada
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

print 'Store Procedure: dbo.CATEGORIASLLAMADA_UP'

if exists (select * from sysobjects where id = object_id('dbo.CATEGORIASLLAMADA_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CATEGORIASLLAMADA_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CATEGORIASLLAMADA_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select ctl_rcd_cod,
                ctl_des_des,
                ctl_cd1_tipo,
                TNGS_Carm..CategoriasLlamada.instante,
                TNGS_Carm..CategoriasLlamada.deleted,
                TNGS_Carm..CategoriasLlamada.usuario,
                TNGS_Carm..CategoriasLlamada.version
           from TNGS_Carm..CategoriasLlamada
          where deleted = 0
          order by ctl_rcd_cod
      end
   else
      begin
         Select ctl_rcd_cod,
                ctl_des_des,
                ctl_cd1_tipo,
                TNGS_Carm..CategoriasLlamada.instante,
                TNGS_Carm..CategoriasLlamada.deleted,
                TNGS_Carm..CategoriasLlamada.usuario,
                TNGS_Carm..CategoriasLlamada.version
           from TNGS_Carm..CategoriasLlamada
          order by ctl_rcd_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CATEGORIASLLAMADA_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@ctl_rcd_cod">Codigo</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CATEGORIASLLAMADA_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.CATEGORIASLLAMADA_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CATEGORIASLLAMADA_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CATEGORIASLLAMADA_CHKVERSION
(
@ctl_rcd_cod tngs_codigo_r,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Carm..CategoriasLlamada
    where ctl_rcd_cod = @ctl_rcd_cod
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CATEGORIASLLAMADA_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@ctl_rcd_cod">Codigo</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CATEGORIASLLAMADA_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.CATEGORIASLLAMADA_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CATEGORIASLLAMADA_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CATEGORIASLLAMADA_SEARCH
(
@ctl_rcd_cod tngs_codigo_r,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select ctl_rcd_cod,
                ctl_des_des,
                ctl_cd1_tipo,
                TNGS_Carm..CategoriasLlamada.instante,
                TNGS_Carm..CategoriasLlamada.deleted,
                TNGS_Carm..CategoriasLlamada.usuario,
                TNGS_Carm..CategoriasLlamada.version
           from TNGS_Carm..CategoriasLlamada
          where ctl_rcd_cod = @ctl_rcd_cod
            and deleted = 0
      end
   else
      begin
         Select ctl_rcd_cod,
                ctl_des_des,
                ctl_cd1_tipo,
                TNGS_Carm..CategoriasLlamada.instante,
                TNGS_Carm..CategoriasLlamada.deleted,
                TNGS_Carm..CategoriasLlamada.usuario,
                TNGS_Carm..CategoriasLlamada.version
           from TNGS_Carm..CategoriasLlamada
          where ctl_rcd_cod = @ctl_rcd_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CATEGORIASLLAMADA_SEARCH to tngsmodulos

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

print 'Store Procedure: dbo.CATEGORIASLLAMADA_GETMAXKEY'

if exists (select * from sysobjects where id = object_id('dbo.CATEGORIASLLAMADA_GETMAXKEY'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CATEGORIASLLAMADA_GETMAXKEY
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CATEGORIASLLAMADA_GETMAXKEY
(
@dummy tngs_codigo_1
)
as
begin

   Select isnull(max(ctl_rcd_cod), '0') as ctl_rcd_cod
     from TNGS_Carm..CategoriasLlamada

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CATEGORIASLLAMADA_GETMAXKEY to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@ctl_rcd_cod">Codigo</param>
--- <param name="@ctl_des_des">Categoría</param>
--- <param name="@ctl_cd1_tipo">Tipo de llamada</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CATEGORIASLLAMADA_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.CATEGORIASLLAMADA_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CATEGORIASLLAMADA_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CATEGORIASLLAMADA_INSERT
(
@ctl_rcd_cod tngs_codigo_r,
@ctl_des_des tngs_descripcion,
@ctl_cd1_tipo tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Carm..CategoriasLlamada
   values (
           @ctl_rcd_cod,
           @ctl_des_des,
           @ctl_cd1_tipo,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CATEGORIASLLAMADA_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@ctl_rcd_cod">Codigo</param>
--- <param name="@ctl_des_des">Categoría</param>
--- <param name="@ctl_cd1_tipo">Tipo de llamada</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CATEGORIASLLAMADA_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.CATEGORIASLLAMADA_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CATEGORIASLLAMADA_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CATEGORIASLLAMADA_UPDATE
(
@ctl_rcd_cod tngs_codigo_r,
@ctl_des_des tngs_descripcion,
@ctl_cd1_tipo tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..CategoriasLlamada
      set ctl_des_des= @ctl_des_des,
          ctl_cd1_tipo= @ctl_cd1_tipo,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where ctl_rcd_cod = @ctl_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CATEGORIASLLAMADA_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@ctl_rcd_cod">Codigo</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CATEGORIASLLAMADA_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.CATEGORIASLLAMADA_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CATEGORIASLLAMADA_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CATEGORIASLLAMADA_DELETE
(
@ctl_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..CategoriasLlamada
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where ctl_rcd_cod = @ctl_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CATEGORIASLLAMADA_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@ctl_rcd_cod">Codigo</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CATEGORIASLLAMADA_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.CATEGORIASLLAMADA_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CATEGORIASLLAMADA_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CATEGORIASLLAMADA_RECALL
(
@ctl_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..CategoriasLlamada
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where ctl_rcd_cod = @ctl_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CATEGORIASLLAMADA_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@ctl_rcd_cod">Codigo</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CATEGORIASLLAMADA_DROP'

if exists (select * from sysobjects where id = object_id('dbo.CATEGORIASLLAMADA_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CATEGORIASLLAMADA_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CATEGORIASLLAMADA_DROP
(
@ctl_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..CategoriasLlamada
    where ctl_rcd_cod = @ctl_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CATEGORIASLLAMADA_DROP to tngsmodulos

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

print 'Store Procedure: dbo.CATEGORIASLLAMADA_PACK'

if exists (select * from sysobjects where id = object_id('dbo.CATEGORIASLLAMADA_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CATEGORIASLLAMADA_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CATEGORIASLLAMADA_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Carm..CategoriasLlamada
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CATEGORIASLLAMADA_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: CategoriasLlamada
//--------------------------------------------------------------------------*/
