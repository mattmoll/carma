/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 04/01/2023 00:01
// Sistema     : Carm
// Tabla       : Supervisores
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

print 'Store Procedure: dbo.SUPERVISORES_UP'

if exists (select * from sysobjects where id = object_id('dbo.SUPERVISORES_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SUPERVISORES_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SUPERVISORES_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select sup_cd6_cod,
                sup_nom_apellido,
                sup_nom_nombre,
                sup_nom_usuario,
                ltrim(rtrim(sup_nom_apellido)) + ' ' + ltrim(rtrim(sup_nom_nombre)) as sup_ede_nya,
                sup_tel_tel,
                sup_tel_cel,
                TNGS_Carm..Supervisores.instante,
                TNGS_Carm..Supervisores.deleted,
                TNGS_Carm..Supervisores.usuario,
                TNGS_Carm..Supervisores.version
           from TNGS_Carm..Supervisores
          where deleted = 0
          order by sup_cd6_cod
      end
   else
      begin
         Select sup_cd6_cod,
                sup_nom_apellido,
                sup_nom_nombre,
                sup_nom_usuario,
                ltrim(rtrim(sup_nom_apellido)) + ' ' + ltrim(rtrim(sup_nom_nombre)) as sup_ede_nya,
                sup_tel_tel,
                sup_tel_cel,
                TNGS_Carm..Supervisores.instante,
                TNGS_Carm..Supervisores.deleted,
                TNGS_Carm..Supervisores.usuario,
                TNGS_Carm..Supervisores.version
           from TNGS_Carm..Supervisores
          order by sup_cd6_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SUPERVISORES_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@sup_cd6_cod">Código</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.SUPERVISORES_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.SUPERVISORES_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SUPERVISORES_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SUPERVISORES_CHKVERSION
(
@sup_cd6_cod tngs_codigo_6,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Carm..Supervisores
    where sup_cd6_cod = @sup_cd6_cod
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SUPERVISORES_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@sup_cd6_cod">Código</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.SUPERVISORES_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.SUPERVISORES_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SUPERVISORES_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SUPERVISORES_SEARCH
(
@sup_cd6_cod tngs_codigo_6,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select sup_cd6_cod,
                sup_nom_apellido,
                sup_nom_nombre,
                sup_nom_usuario,
                ltrim(rtrim(sup_nom_apellido)) + ' ' + ltrim(rtrim(sup_nom_nombre)) as sup_ede_nya,
                sup_tel_tel,
                sup_tel_cel,
                TNGS_Carm..Supervisores.instante,
                TNGS_Carm..Supervisores.deleted,
                TNGS_Carm..Supervisores.usuario,
                TNGS_Carm..Supervisores.version
           from TNGS_Carm..Supervisores
          where sup_cd6_cod = @sup_cd6_cod
            and deleted = 0
      end
   else
      begin
         Select sup_cd6_cod,
                sup_nom_apellido,
                sup_nom_nombre,
                sup_nom_usuario,
                ltrim(rtrim(sup_nom_apellido)) + ' ' + ltrim(rtrim(sup_nom_nombre)) as sup_ede_nya,
                sup_tel_tel,
                sup_tel_cel,
                TNGS_Carm..Supervisores.instante,
                TNGS_Carm..Supervisores.deleted,
                TNGS_Carm..Supervisores.usuario,
                TNGS_Carm..Supervisores.version
           from TNGS_Carm..Supervisores
          where sup_cd6_cod = @sup_cd6_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SUPERVISORES_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@sup_cd6_cod">Código</param>
--- <param name="@sup_nom_apellido">Apellido</param>
--- <param name="@sup_nom_nombre">Nombre</param>
--- <param name="@sup_nom_usuario">Usuario del Sistema</param>
--- <param name="@sup_tel_tel">Télefono</param>
--- <param name="@sup_tel_cel">Celular</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.SUPERVISORES_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.SUPERVISORES_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SUPERVISORES_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SUPERVISORES_INSERT
(
@sup_cd6_cod tngs_codigo_6,
@sup_nom_apellido tngs_nombre,
@sup_nom_nombre tngs_nombre,
@sup_nom_usuario tngs_nombre,
@sup_tel_tel tngs_telefono,
@sup_tel_cel tngs_telefono,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Carm..Supervisores
   values (
           @sup_cd6_cod,
           @sup_nom_apellido,
           @sup_nom_nombre,
           @sup_nom_usuario,
           @sup_tel_tel,
           @sup_tel_cel,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SUPERVISORES_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@sup_cd6_cod">Código</param>
--- <param name="@sup_nom_apellido">Apellido</param>
--- <param name="@sup_nom_nombre">Nombre</param>
--- <param name="@sup_nom_usuario">Usuario del Sistema</param>
--- <param name="@sup_tel_tel">Télefono</param>
--- <param name="@sup_tel_cel">Celular</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.SUPERVISORES_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.SUPERVISORES_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SUPERVISORES_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SUPERVISORES_UPDATE
(
@sup_cd6_cod tngs_codigo_6,
@sup_nom_apellido tngs_nombre,
@sup_nom_nombre tngs_nombre,
@sup_nom_usuario tngs_nombre,
@sup_tel_tel tngs_telefono,
@sup_tel_cel tngs_telefono,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Supervisores
      set sup_nom_apellido= @sup_nom_apellido,
          sup_nom_nombre= @sup_nom_nombre,
          sup_nom_usuario= @sup_nom_usuario,
          sup_tel_tel= @sup_tel_tel,
          sup_tel_cel= @sup_tel_cel,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where sup_cd6_cod = @sup_cd6_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SUPERVISORES_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@sup_cd6_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.SUPERVISORES_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.SUPERVISORES_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SUPERVISORES_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SUPERVISORES_DELETE
(
@sup_cd6_cod tngs_codigo_6,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Supervisores
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where sup_cd6_cod = @sup_cd6_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SUPERVISORES_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@sup_cd6_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.SUPERVISORES_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.SUPERVISORES_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SUPERVISORES_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SUPERVISORES_RECALL
(
@sup_cd6_cod tngs_codigo_6,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Supervisores
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where sup_cd6_cod = @sup_cd6_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SUPERVISORES_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@sup_cd6_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.SUPERVISORES_DROP'

if exists (select * from sysobjects where id = object_id('dbo.SUPERVISORES_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SUPERVISORES_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SUPERVISORES_DROP
(
@sup_cd6_cod tngs_codigo_6,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..Supervisores
    where sup_cd6_cod = @sup_cd6_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SUPERVISORES_DROP to tngsmodulos

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

print 'Store Procedure: dbo.SUPERVISORES_PACK'

if exists (select * from sysobjects where id = object_id('dbo.SUPERVISORES_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SUPERVISORES_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SUPERVISORES_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Carm..Supervisores
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SUPERVISORES_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Supervisores
//--------------------------------------------------------------------------*/
