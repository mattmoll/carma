/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 18/12/2020 03:40
// Sistema     : Carm
// Tabla       : TipoCont
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

print 'Store Procedure: dbo.TIPOCONT_UP'

if exists (select * from sysobjects where id = object_id('dbo.TIPOCONT_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOCONT_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOCONT_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select tcn_rcd_cod,
                tcn_des_des,
                tcn_cd1_modo,
                tcn_rcd_tcontratoavalon,
                TNGS_Carm..TipoCont.instante,
                TNGS_Carm..TipoCont.deleted,
                TNGS_Carm..TipoCont.usuario,
                TNGS_Carm..TipoCont.version
           from TNGS_Carm..TipoCont
          where deleted = 0
          order by tcn_rcd_cod
      end
   else
      begin
         Select tcn_rcd_cod,
                tcn_des_des,
                tcn_cd1_modo,
                tcn_rcd_tcontratoavalon,
                TNGS_Carm..TipoCont.instante,
                TNGS_Carm..TipoCont.deleted,
                TNGS_Carm..TipoCont.usuario,
                TNGS_Carm..TipoCont.version
           from TNGS_Carm..TipoCont
          order by tcn_rcd_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOCONT_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@tcn_rcd_cod">Código</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TIPOCONT_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.TIPOCONT_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOCONT_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOCONT_CHKVERSION
(
@tcn_rcd_cod tngs_codigo_r,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Carm..TipoCont
    where tcn_rcd_cod = @tcn_rcd_cod
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOCONT_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@tcn_rcd_cod">Código</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TIPOCONT_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.TIPOCONT_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOCONT_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOCONT_SEARCH
(
@tcn_rcd_cod tngs_codigo_r,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select tcn_rcd_cod,
                tcn_des_des,
                tcn_cd1_modo,
                tcn_rcd_tcontratoavalon,
                TNGS_Carm..TipoCont.instante,
                TNGS_Carm..TipoCont.deleted,
                TNGS_Carm..TipoCont.usuario,
                TNGS_Carm..TipoCont.version
           from TNGS_Carm..TipoCont
          where tcn_rcd_cod = @tcn_rcd_cod
            and deleted = 0
      end
   else
      begin
         Select tcn_rcd_cod,
                tcn_des_des,
                tcn_cd1_modo,
                tcn_rcd_tcontratoavalon,
                TNGS_Carm..TipoCont.instante,
                TNGS_Carm..TipoCont.deleted,
                TNGS_Carm..TipoCont.usuario,
                TNGS_Carm..TipoCont.version
           from TNGS_Carm..TipoCont
          where tcn_rcd_cod = @tcn_rcd_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOCONT_SEARCH to tngsmodulos

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

print 'Store Procedure: dbo.TIPOCONT_GETMAXKEY'

if exists (select * from sysobjects where id = object_id('dbo.TIPOCONT_GETMAXKEY'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOCONT_GETMAXKEY
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOCONT_GETMAXKEY
(
@dummy tngs_codigo_1
)
as
begin

   Select isnull(max(tcn_rcd_cod), '0') as tcn_rcd_cod
     from TNGS_Carm..TipoCont

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOCONT_GETMAXKEY to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@tcn_rcd_cod">Código</param>
--- <param name="@tcn_des_des">Descripción</param>
--- <param name="@tcn_cd1_modo">Modo Venta</param>
--- <param name="@tcn_rcd_tcontratoavalon">Tipo Contrato Avalon</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TIPOCONT_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.TIPOCONT_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOCONT_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOCONT_INSERT
(
@tcn_rcd_cod tngs_codigo_r,
@tcn_des_des tngs_descripcion,
@tcn_cd1_modo tngs_codigo_1,
@tcn_rcd_tcontratoavalon tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Carm..TipoCont
   values (
           @tcn_rcd_cod,
           @tcn_des_des,
           @tcn_cd1_modo,
           @tcn_rcd_tcontratoavalon,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOCONT_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@tcn_rcd_cod">Código</param>
--- <param name="@tcn_des_des">Descripción</param>
--- <param name="@tcn_cd1_modo">Modo Venta</param>
--- <param name="@tcn_rcd_tcontratoavalon">Tipo Contrato Avalon</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TIPOCONT_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.TIPOCONT_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOCONT_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOCONT_UPDATE
(
@tcn_rcd_cod tngs_codigo_r,
@tcn_des_des tngs_descripcion,
@tcn_cd1_modo tngs_codigo_1,
@tcn_rcd_tcontratoavalon tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..TipoCont
      set tcn_des_des= @tcn_des_des,
          tcn_cd1_modo= @tcn_cd1_modo,
          tcn_rcd_tcontratoavalon= @tcn_rcd_tcontratoavalon,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where tcn_rcd_cod = @tcn_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOCONT_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@tcn_rcd_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TIPOCONT_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.TIPOCONT_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOCONT_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOCONT_DELETE
(
@tcn_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..TipoCont
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where tcn_rcd_cod = @tcn_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOCONT_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@tcn_rcd_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TIPOCONT_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.TIPOCONT_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOCONT_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOCONT_RECALL
(
@tcn_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..TipoCont
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where tcn_rcd_cod = @tcn_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOCONT_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@tcn_rcd_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TIPOCONT_DROP'

if exists (select * from sysobjects where id = object_id('dbo.TIPOCONT_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOCONT_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOCONT_DROP
(
@tcn_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..TipoCont
    where tcn_rcd_cod = @tcn_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOCONT_DROP to tngsmodulos

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

print 'Store Procedure: dbo.TIPOCONT_PACK'

if exists (select * from sysobjects where id = object_id('dbo.TIPOCONT_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOCONT_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOCONT_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Carm..TipoCont
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOCONT_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: TipoCont
//--------------------------------------------------------------------------*/
