/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 05/02/2021 12:21
// Sistema     : Carm
// Tabla       : Planes
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

print 'Store Procedure: dbo.PLANES_UP'

if exists (select * from sysobjects where id = object_id('dbo.PLANES_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PLANES_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PLANES_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select pln_cod_cod,
                pln_des_des,
                pln_cod_codplanavalon,
                pln_d80_tcontratoavalon,
                TNGS_Carm..Planes.instante,
                TNGS_Carm..Planes.deleted,
                TNGS_Carm..Planes.usuario,
                TNGS_Carm..Planes.version
           from TNGS_Carm..Planes
          where deleted = 0
          order by pln_cod_cod
      end
   else
      begin
         Select pln_cod_cod,
                pln_des_des,
                pln_cod_codplanavalon,
                pln_d80_tcontratoavalon,
                TNGS_Carm..Planes.instante,
                TNGS_Carm..Planes.deleted,
                TNGS_Carm..Planes.usuario,
                TNGS_Carm..Planes.version
           from TNGS_Carm..Planes
          order by pln_cod_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PLANES_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@pln_cod_cod">Código</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PLANES_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.PLANES_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PLANES_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PLANES_CHKVERSION
(
@pln_cod_cod tngs_codigo,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Carm..Planes
    where pln_cod_cod = @pln_cod_cod
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PLANES_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@pln_cod_cod">Código</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PLANES_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.PLANES_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PLANES_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PLANES_SEARCH
(
@pln_cod_cod tngs_codigo,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select pln_cod_cod,
                pln_des_des,
                pln_cod_codplanavalon,
                pln_d80_tcontratoavalon,
                TNGS_Carm..Planes.instante,
                TNGS_Carm..Planes.deleted,
                TNGS_Carm..Planes.usuario,
                TNGS_Carm..Planes.version
           from TNGS_Carm..Planes
          where pln_cod_cod = @pln_cod_cod
            and deleted = 0
      end
   else
      begin
         Select pln_cod_cod,
                pln_des_des,
                pln_cod_codplanavalon,
                pln_d80_tcontratoavalon,
                TNGS_Carm..Planes.instante,
                TNGS_Carm..Planes.deleted,
                TNGS_Carm..Planes.usuario,
                TNGS_Carm..Planes.version
           from TNGS_Carm..Planes
          where pln_cod_cod = @pln_cod_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PLANES_SEARCH to tngsmodulos

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

print 'Store Procedure: dbo.PLANES_GETMAXKEY'

if exists (select * from sysobjects where id = object_id('dbo.PLANES_GETMAXKEY'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PLANES_GETMAXKEY
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PLANES_GETMAXKEY
(
@dummy tngs_codigo_1
)
as
begin

   Select isnull(max(pln_cod_cod), '0') as pln_cod_cod
     from TNGS_Carm..Planes

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PLANES_GETMAXKEY to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@pln_cod_cod">Código</param>
--- <param name="@pln_des_des">Descripción</param>
--- <param name="@pln_cod_codplanavalon">Cod Plan Avalon</param>
--- <param name="@pln_d80_tcontratoavalon">Lista de T Contratos Avalon</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PLANES_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.PLANES_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PLANES_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PLANES_INSERT
(
@pln_cod_cod tngs_codigo,
@pln_des_des tngs_descripcion,
@pln_cod_codplanavalon tngs_codigo,
@pln_d80_tcontratoavalon tngs_descripcion_80,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Carm..Planes
   values (
           @pln_cod_cod,
           @pln_des_des,
           @pln_cod_codplanavalon,
           @pln_d80_tcontratoavalon,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PLANES_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@pln_cod_cod">Código</param>
--- <param name="@pln_des_des">Descripción</param>
--- <param name="@pln_cod_codplanavalon">Cod Plan Avalon</param>
--- <param name="@pln_d80_tcontratoavalon">Lista de T Contratos Avalon</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PLANES_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.PLANES_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PLANES_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PLANES_UPDATE
(
@pln_cod_cod tngs_codigo,
@pln_des_des tngs_descripcion,
@pln_cod_codplanavalon tngs_codigo,
@pln_d80_tcontratoavalon tngs_descripcion_80,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Planes
      set pln_des_des= @pln_des_des,
          pln_cod_codplanavalon= @pln_cod_codplanavalon,
          pln_d80_tcontratoavalon= @pln_d80_tcontratoavalon,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where pln_cod_cod = @pln_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PLANES_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@pln_cod_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PLANES_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.PLANES_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PLANES_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PLANES_DELETE
(
@pln_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Planes
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where pln_cod_cod = @pln_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PLANES_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@pln_cod_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PLANES_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.PLANES_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PLANES_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PLANES_RECALL
(
@pln_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Planes
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where pln_cod_cod = @pln_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PLANES_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@pln_cod_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PLANES_DROP'

if exists (select * from sysobjects where id = object_id('dbo.PLANES_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PLANES_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PLANES_DROP
(
@pln_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..Planes
    where pln_cod_cod = @pln_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PLANES_DROP to tngsmodulos

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

print 'Store Procedure: dbo.PLANES_PACK'

if exists (select * from sysobjects where id = object_id('dbo.PLANES_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PLANES_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PLANES_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Carm..Planes
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PLANES_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: GetPlanesFromTCont
--- </summary>
--- <param name="@codtcont">Codigo de Tipo de Contrato</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PLANES_GETPLANESFROMTCONT'

if exists (select * from sysobjects where id = object_id('dbo.PLANES_GETPLANESFROMTCONT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PLANES_GETPLANESFROMTCONT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PLANES_GETPLANESFROMTCONT
(
@codtcont tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   select distinct pln_cod_cod,pln_des_des,Planes.deleted 
   from Planes 
   join TipoCont on CHARINDEX(tcn_rcd_tcontratoavalon + ',',pln_d80_tcontratoavalon) <> 0 
   where tcn_rcd_cod = @codtcont 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PLANES_GETPLANESFROMTCONT to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Planes
//--------------------------------------------------------------------------*/
