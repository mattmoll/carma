/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 22/08/2020 00:49
// Sistema     : Carm
// Tabla       : Franquicias
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

print 'Store Procedure: dbo.FRANQUICIAS_UP'

if exists (select * from sysobjects where id = object_id('dbo.FRANQUICIAS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.FRANQUICIAS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.FRANQUICIAS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select frq_cod_cod,
                frq_des_des,
                TNGS_Carm..Franquicias.instante,
                TNGS_Carm..Franquicias.deleted,
                TNGS_Carm..Franquicias.usuario,
                TNGS_Carm..Franquicias.version
           from TNGS_Carm..Franquicias
          where deleted = 0
          order by frq_cod_cod
      end
   else
      begin
         Select frq_cod_cod,
                frq_des_des,
                TNGS_Carm..Franquicias.instante,
                TNGS_Carm..Franquicias.deleted,
                TNGS_Carm..Franquicias.usuario,
                TNGS_Carm..Franquicias.version
           from TNGS_Carm..Franquicias
          order by frq_cod_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.FRANQUICIAS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@frq_cod_cod">Codigo</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.FRANQUICIAS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.FRANQUICIAS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.FRANQUICIAS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.FRANQUICIAS_CHKVERSION
(
@frq_cod_cod tngs_codigo,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Carm..Franquicias
    where frq_cod_cod = @frq_cod_cod
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.FRANQUICIAS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@frq_cod_cod">Codigo</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.FRANQUICIAS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.FRANQUICIAS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.FRANQUICIAS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.FRANQUICIAS_SEARCH
(
@frq_cod_cod tngs_codigo,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select frq_cod_cod,
                frq_des_des,
                TNGS_Carm..Franquicias.instante,
                TNGS_Carm..Franquicias.deleted,
                TNGS_Carm..Franquicias.usuario,
                TNGS_Carm..Franquicias.version
           from TNGS_Carm..Franquicias
          where frq_cod_cod = @frq_cod_cod
            and deleted = 0
      end
   else
      begin
         Select frq_cod_cod,
                frq_des_des,
                TNGS_Carm..Franquicias.instante,
                TNGS_Carm..Franquicias.deleted,
                TNGS_Carm..Franquicias.usuario,
                TNGS_Carm..Franquicias.version
           from TNGS_Carm..Franquicias
          where frq_cod_cod = @frq_cod_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.FRANQUICIAS_SEARCH to tngsmodulos

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

print 'Store Procedure: dbo.FRANQUICIAS_GETMAXKEY'

if exists (select * from sysobjects where id = object_id('dbo.FRANQUICIAS_GETMAXKEY'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.FRANQUICIAS_GETMAXKEY
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.FRANQUICIAS_GETMAXKEY
(
@dummy tngs_codigo_1
)
as
begin

   Select isnull(max(frq_cod_cod), '0') as frq_cod_cod
     from TNGS_Carm..Franquicias

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.FRANQUICIAS_GETMAXKEY to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@frq_cod_cod">Codigo</param>
--- <param name="@frq_des_des">Descripcion</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.FRANQUICIAS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.FRANQUICIAS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.FRANQUICIAS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.FRANQUICIAS_INSERT
(
@frq_cod_cod tngs_codigo,
@frq_des_des tngs_descripcion,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Carm..Franquicias
   values (
           @frq_cod_cod,
           @frq_des_des,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.FRANQUICIAS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@frq_cod_cod">Codigo</param>
--- <param name="@frq_des_des">Descripcion</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.FRANQUICIAS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.FRANQUICIAS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.FRANQUICIAS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.FRANQUICIAS_UPDATE
(
@frq_cod_cod tngs_codigo,
@frq_des_des tngs_descripcion,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Franquicias
      set frq_des_des= @frq_des_des,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where frq_cod_cod = @frq_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.FRANQUICIAS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@frq_cod_cod">Codigo</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.FRANQUICIAS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.FRANQUICIAS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.FRANQUICIAS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.FRANQUICIAS_DELETE
(
@frq_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Franquicias
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where frq_cod_cod = @frq_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.FRANQUICIAS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@frq_cod_cod">Codigo</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.FRANQUICIAS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.FRANQUICIAS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.FRANQUICIAS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.FRANQUICIAS_RECALL
(
@frq_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Franquicias
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where frq_cod_cod = @frq_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.FRANQUICIAS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@frq_cod_cod">Codigo</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.FRANQUICIAS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.FRANQUICIAS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.FRANQUICIAS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.FRANQUICIAS_DROP
(
@frq_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..Franquicias
    where frq_cod_cod = @frq_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.FRANQUICIAS_DROP to tngsmodulos

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

print 'Store Procedure: dbo.FRANQUICIAS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.FRANQUICIAS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.FRANQUICIAS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.FRANQUICIAS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Carm..Franquicias
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.FRANQUICIAS_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Franquicias
//--------------------------------------------------------------------------*/
