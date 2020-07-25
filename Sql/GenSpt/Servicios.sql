/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 25/07/2020 18:14
// Sistema     : Carm
// Tabla       : Servicios
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

print 'Store Procedure: dbo.SERVICIOS_UP'

if exists (select * from sysobjects where id = object_id('dbo.SERVICIOS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SERVICIOS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SERVICIOS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select srv_cod_cod,
                srv_des_des,
                srv_xld_explicacion,
                TNGS_Carm..Servicios.instante,
                TNGS_Carm..Servicios.deleted,
                TNGS_Carm..Servicios.usuario,
                TNGS_Carm..Servicios.version
           from TNGS_Carm..Servicios
          where deleted = 0
          order by srv_cod_cod
      end
   else
      begin
         Select srv_cod_cod,
                srv_des_des,
                srv_xld_explicacion,
                TNGS_Carm..Servicios.instante,
                TNGS_Carm..Servicios.deleted,
                TNGS_Carm..Servicios.usuario,
                TNGS_Carm..Servicios.version
           from TNGS_Carm..Servicios
          order by srv_cod_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SERVICIOS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@srv_cod_cod">Código</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.SERVICIOS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.SERVICIOS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SERVICIOS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SERVICIOS_CHKVERSION
(
@srv_cod_cod tngs_codigo,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Carm..Servicios
    where srv_cod_cod = @srv_cod_cod
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SERVICIOS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@srv_cod_cod">Código</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.SERVICIOS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.SERVICIOS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SERVICIOS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SERVICIOS_SEARCH
(
@srv_cod_cod tngs_codigo,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select srv_cod_cod,
                srv_des_des,
                srv_xld_explicacion,
                TNGS_Carm..Servicios.instante,
                TNGS_Carm..Servicios.deleted,
                TNGS_Carm..Servicios.usuario,
                TNGS_Carm..Servicios.version
           from TNGS_Carm..Servicios
          where srv_cod_cod = @srv_cod_cod
            and deleted = 0
      end
   else
      begin
         Select srv_cod_cod,
                srv_des_des,
                srv_xld_explicacion,
                TNGS_Carm..Servicios.instante,
                TNGS_Carm..Servicios.deleted,
                TNGS_Carm..Servicios.usuario,
                TNGS_Carm..Servicios.version
           from TNGS_Carm..Servicios
          where srv_cod_cod = @srv_cod_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SERVICIOS_SEARCH to tngsmodulos

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

print 'Store Procedure: dbo.SERVICIOS_GETMAXKEY'

if exists (select * from sysobjects where id = object_id('dbo.SERVICIOS_GETMAXKEY'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SERVICIOS_GETMAXKEY
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SERVICIOS_GETMAXKEY
(
@dummy tngs_codigo_1
)
as
begin

   Select isnull(max(srv_cod_cod), '0') as srv_cod_cod
     from TNGS_Carm..Servicios

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SERVICIOS_GETMAXKEY to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@srv_cod_cod">Código</param>
--- <param name="@srv_des_des">Descripción</param>
--- <param name="@srv_xld_explicacion">Descripcion Extendida</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.SERVICIOS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.SERVICIOS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SERVICIOS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SERVICIOS_INSERT
(
@srv_cod_cod tngs_codigo,
@srv_des_des tngs_descripcion,
@srv_xld_explicacion tngs_descripcion_xl,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Carm..Servicios
   values (
           @srv_cod_cod,
           @srv_des_des,
           @srv_xld_explicacion,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SERVICIOS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@srv_cod_cod">Código</param>
--- <param name="@srv_des_des">Descripción</param>
--- <param name="@srv_xld_explicacion">Descripcion Extendida</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.SERVICIOS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.SERVICIOS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SERVICIOS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SERVICIOS_UPDATE
(
@srv_cod_cod tngs_codigo,
@srv_des_des tngs_descripcion,
@srv_xld_explicacion tngs_descripcion_xl,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Servicios
      set srv_des_des= @srv_des_des,
          srv_xld_explicacion= @srv_xld_explicacion,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where srv_cod_cod = @srv_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SERVICIOS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@srv_cod_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.SERVICIOS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.SERVICIOS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SERVICIOS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SERVICIOS_DELETE
(
@srv_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Servicios
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where srv_cod_cod = @srv_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SERVICIOS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@srv_cod_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.SERVICIOS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.SERVICIOS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SERVICIOS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SERVICIOS_RECALL
(
@srv_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Servicios
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where srv_cod_cod = @srv_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SERVICIOS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@srv_cod_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.SERVICIOS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.SERVICIOS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SERVICIOS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SERVICIOS_DROP
(
@srv_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..Servicios
    where srv_cod_cod = @srv_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SERVICIOS_DROP to tngsmodulos

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

print 'Store Procedure: dbo.SERVICIOS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.SERVICIOS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SERVICIOS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SERVICIOS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Carm..Servicios
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SERVICIOS_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: GetServiciosFull
--- </summary>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.SERVICIOS_GETSERVICIOSFULL'

if exists (select * from sysobjects where id = object_id('dbo.SERVICIOS_GETSERVICIOSFULL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SERVICIOS_GETSERVICIOSFULL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SERVICIOS_GETSERVICIOSFULL
(
@usuario tngs_nombre
)
as
begin

   select srv_cod_cod,srv_des_des, 0 as dummy,-2 as pls_nro_cprestlibres, 1 as pls_imp_valorprestacion 
   from Servicios 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SERVICIOS_GETSERVICIOSFULL to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Servicios
//--------------------------------------------------------------------------*/
