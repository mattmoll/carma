/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 05/02/2021 12:21
// Sistema     : Carm
// Tabla       : TipoInst
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

print 'Store Procedure: dbo.TIPOINST_UP'

if exists (select * from sysobjects where id = object_id('dbo.TIPOINST_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOINST_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOINST_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select tin_cod_cod,
                tin_des_des,
                tin_rcd_codrubro,
                rbr_des_des as tin_des_rubro,
                tin_cd1_mayorista,
                TNGS_Carm..TipoInst.instante,
                TNGS_Carm..TipoInst.deleted,
                TNGS_Carm..TipoInst.usuario,
                TNGS_Carm..TipoInst.version
           from TNGS_Carm..TipoInst
                join TNGS_Carm..Rubros
                  on tin_rcd_codrubro = rbr_rcd_cod
          where TNGS_Carm..TipoInst.deleted = 0
          order by tin_cod_cod
      end
   else
      begin
         Select tin_cod_cod,
                tin_des_des,
                tin_rcd_codrubro,
                rbr_des_des as tin_des_rubro,
                tin_cd1_mayorista,
                TNGS_Carm..TipoInst.instante,
                TNGS_Carm..TipoInst.deleted,
                TNGS_Carm..TipoInst.usuario,
                TNGS_Carm..TipoInst.version
           from TNGS_Carm..TipoInst
                join TNGS_Carm..Rubros
                  on tin_rcd_codrubro = rbr_rcd_cod
          order by tin_cod_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOINST_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@tin_cod_cod">Código</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TIPOINST_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.TIPOINST_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOINST_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOINST_CHKVERSION
(
@tin_cod_cod tngs_codigo,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Carm..TipoInst
    where tin_cod_cod = @tin_cod_cod
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOINST_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@tin_cod_cod">Código</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TIPOINST_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.TIPOINST_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOINST_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOINST_SEARCH
(
@tin_cod_cod tngs_codigo,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select tin_cod_cod,
                tin_des_des,
                tin_rcd_codrubro,
                rbr_des_des as tin_des_rubro,
                tin_cd1_mayorista,
                TNGS_Carm..TipoInst.instante,
                TNGS_Carm..TipoInst.deleted,
                TNGS_Carm..TipoInst.usuario,
                TNGS_Carm..TipoInst.version
           from TNGS_Carm..TipoInst
                join TNGS_Carm..Rubros
                  on tin_rcd_codrubro = rbr_rcd_cod
          where tin_cod_cod = @tin_cod_cod
            and TNGS_Carm..TipoInst.deleted = 0
      end
   else
      begin
         Select tin_cod_cod,
                tin_des_des,
                tin_rcd_codrubro,
                rbr_des_des as tin_des_rubro,
                tin_cd1_mayorista,
                TNGS_Carm..TipoInst.instante,
                TNGS_Carm..TipoInst.deleted,
                TNGS_Carm..TipoInst.usuario,
                TNGS_Carm..TipoInst.version
           from TNGS_Carm..TipoInst
                join TNGS_Carm..Rubros
                  on tin_rcd_codrubro = rbr_rcd_cod
          where tin_cod_cod = @tin_cod_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOINST_SEARCH to tngsmodulos

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

print 'Store Procedure: dbo.TIPOINST_GETMAXKEY'

if exists (select * from sysobjects where id = object_id('dbo.TIPOINST_GETMAXKEY'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOINST_GETMAXKEY
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOINST_GETMAXKEY
(
@dummy tngs_codigo_1
)
as
begin

   Select isnull(max(tin_cod_cod), '0') as tin_cod_cod
     from TNGS_Carm..TipoInst

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOINST_GETMAXKEY to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@tin_cod_cod">Código</param>
--- <param name="@tin_des_des">Descripción</param>
--- <param name="@tin_rcd_codrubro">Rubro</param>
--- <param name="@tin_cd1_mayorista">Mayorista</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TIPOINST_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.TIPOINST_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOINST_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOINST_INSERT
(
@tin_cod_cod tngs_codigo,
@tin_des_des tngs_descripcion,
@tin_rcd_codrubro tngs_codigo_r,
@tin_cd1_mayorista tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Carm..TipoInst
   values (
           @tin_cod_cod,
           @tin_des_des,
           @tin_rcd_codrubro,
           @tin_cd1_mayorista,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOINST_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@tin_cod_cod">Código</param>
--- <param name="@tin_des_des">Descripción</param>
--- <param name="@tin_rcd_codrubro">Rubro</param>
--- <param name="@tin_cd1_mayorista">Mayorista</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TIPOINST_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.TIPOINST_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOINST_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOINST_UPDATE
(
@tin_cod_cod tngs_codigo,
@tin_des_des tngs_descripcion,
@tin_rcd_codrubro tngs_codigo_r,
@tin_cd1_mayorista tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..TipoInst
      set tin_des_des= @tin_des_des,
          tin_rcd_codrubro= @tin_rcd_codrubro,
          tin_cd1_mayorista= @tin_cd1_mayorista,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where tin_cod_cod = @tin_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOINST_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@tin_cod_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TIPOINST_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.TIPOINST_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOINST_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOINST_DELETE
(
@tin_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..TipoInst
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where tin_cod_cod = @tin_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOINST_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@tin_cod_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TIPOINST_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.TIPOINST_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOINST_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOINST_RECALL
(
@tin_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..TipoInst
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where tin_cod_cod = @tin_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOINST_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@tin_cod_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TIPOINST_DROP'

if exists (select * from sysobjects where id = object_id('dbo.TIPOINST_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOINST_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOINST_DROP
(
@tin_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..TipoInst
    where tin_cod_cod = @tin_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOINST_DROP to tngsmodulos

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

print 'Store Procedure: dbo.TIPOINST_PACK'

if exists (select * from sysobjects where id = object_id('dbo.TIPOINST_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOINST_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOINST_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Carm..TipoInst
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOINST_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: GetTiposInstRubro
--- </summary>
--- <param name="@codrubro">Código de Rubro</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TIPOINST_GETTIPOSINSTRUBRO'

if exists (select * from sysobjects where id = object_id('dbo.TIPOINST_GETTIPOSINSTRUBRO'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOINST_GETTIPOSINSTRUBRO
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOINST_GETTIPOSINSTRUBRO
(
@codrubro tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   select 
         tin_cod_cod, 
         tin_des_des 
   from 
         TNGS_Carm..TipoInst 
   where 
         tin_rcd_codrubro = @codrubro 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOINST_GETTIPOSINSTRUBRO to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: TipoInst
//--------------------------------------------------------------------------*/
