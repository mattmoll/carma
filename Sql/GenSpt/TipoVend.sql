/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 20/09/2020 20:59
// Sistema     : Carm
// Tabla       : TipoVend
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

print 'Store Procedure: dbo.TIPOVEND_UP'

if exists (select * from sysobjects where id = object_id('dbo.TIPOVEND_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOVEND_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOVEND_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select tvn_rcd_cod,
                tvn_des_des,
                tvn_cd1_vemayor,
                TNGS_Carm..TipoVend.instante,
                TNGS_Carm..TipoVend.deleted,
                TNGS_Carm..TipoVend.usuario,
                TNGS_Carm..TipoVend.version
           from TNGS_Carm..TipoVend
          where deleted = 0
          order by tvn_rcd_cod
      end
   else
      begin
         Select tvn_rcd_cod,
                tvn_des_des,
                tvn_cd1_vemayor,
                TNGS_Carm..TipoVend.instante,
                TNGS_Carm..TipoVend.deleted,
                TNGS_Carm..TipoVend.usuario,
                TNGS_Carm..TipoVend.version
           from TNGS_Carm..TipoVend
          order by tvn_rcd_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOVEND_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@tvn_rcd_cod">Codigo</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TIPOVEND_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.TIPOVEND_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOVEND_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOVEND_CHKVERSION
(
@tvn_rcd_cod tngs_codigo_r,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Carm..TipoVend
    where tvn_rcd_cod = @tvn_rcd_cod
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOVEND_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@tvn_rcd_cod">Codigo</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TIPOVEND_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.TIPOVEND_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOVEND_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOVEND_SEARCH
(
@tvn_rcd_cod tngs_codigo_r,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select tvn_rcd_cod,
                tvn_des_des,
                tvn_cd1_vemayor,
                TNGS_Carm..TipoVend.instante,
                TNGS_Carm..TipoVend.deleted,
                TNGS_Carm..TipoVend.usuario,
                TNGS_Carm..TipoVend.version
           from TNGS_Carm..TipoVend
          where tvn_rcd_cod = @tvn_rcd_cod
            and deleted = 0
      end
   else
      begin
         Select tvn_rcd_cod,
                tvn_des_des,
                tvn_cd1_vemayor,
                TNGS_Carm..TipoVend.instante,
                TNGS_Carm..TipoVend.deleted,
                TNGS_Carm..TipoVend.usuario,
                TNGS_Carm..TipoVend.version
           from TNGS_Carm..TipoVend
          where tvn_rcd_cod = @tvn_rcd_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOVEND_SEARCH to tngsmodulos

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

print 'Store Procedure: dbo.TIPOVEND_GETMAXKEY'

if exists (select * from sysobjects where id = object_id('dbo.TIPOVEND_GETMAXKEY'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOVEND_GETMAXKEY
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOVEND_GETMAXKEY
(
@dummy tngs_codigo_1
)
as
begin

   Select isnull(max(tvn_rcd_cod), '0') as tvn_rcd_cod
     from TNGS_Carm..TipoVend

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOVEND_GETMAXKEY to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@tvn_rcd_cod">Codigo</param>
--- <param name="@tvn_des_des">Descripcion</param>
--- <param name="@tvn_cd1_vemayor">Ve Mayoristas</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TIPOVEND_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.TIPOVEND_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOVEND_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOVEND_INSERT
(
@tvn_rcd_cod tngs_codigo_r,
@tvn_des_des tngs_descripcion,
@tvn_cd1_vemayor tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Carm..TipoVend
   values (
           @tvn_rcd_cod,
           @tvn_des_des,
           @tvn_cd1_vemayor,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOVEND_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@tvn_rcd_cod">Codigo</param>
--- <param name="@tvn_des_des">Descripcion</param>
--- <param name="@tvn_cd1_vemayor">Ve Mayoristas</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TIPOVEND_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.TIPOVEND_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOVEND_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOVEND_UPDATE
(
@tvn_rcd_cod tngs_codigo_r,
@tvn_des_des tngs_descripcion,
@tvn_cd1_vemayor tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..TipoVend
      set tvn_des_des= @tvn_des_des,
          tvn_cd1_vemayor= @tvn_cd1_vemayor,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where tvn_rcd_cod = @tvn_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOVEND_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@tvn_rcd_cod">Codigo</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TIPOVEND_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.TIPOVEND_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOVEND_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOVEND_DELETE
(
@tvn_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..TipoVend
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where tvn_rcd_cod = @tvn_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOVEND_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@tvn_rcd_cod">Codigo</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TIPOVEND_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.TIPOVEND_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOVEND_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOVEND_RECALL
(
@tvn_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..TipoVend
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where tvn_rcd_cod = @tvn_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOVEND_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@tvn_rcd_cod">Codigo</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TIPOVEND_DROP'

if exists (select * from sysobjects where id = object_id('dbo.TIPOVEND_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOVEND_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOVEND_DROP
(
@tvn_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..TipoVend
    where tvn_rcd_cod = @tvn_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOVEND_DROP to tngsmodulos

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

print 'Store Procedure: dbo.TIPOVEND_PACK'

if exists (select * from sysobjects where id = object_id('dbo.TIPOVEND_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOVEND_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOVEND_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Carm..TipoVend
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOVEND_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: TipoVend
//--------------------------------------------------------------------------*/
