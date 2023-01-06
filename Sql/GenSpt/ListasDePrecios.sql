/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 06/01/2023 01:01
// Sistema     : Carm
// Tabla       : ListasDePrecios
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

print 'Store Procedure: dbo.LISTASDEPRECIOS_UP'

if exists (select * from sysobjects where id = object_id('dbo.LISTASDEPRECIOS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.LISTASDEPRECIOS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.LISTASDEPRECIOS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select lpr_cod_cod,
                lpr_des_des,
                mrc_ede_des as des_marca,
                pln_des_des as des_plan,
                lpr_cod_codplan,
                lpr_rcd_codmarca,
                lpr_imp_precio1p,
                lpr_imp_precio2p,
                lpr_imp_precio3p,
                lpr_imp_precio4p,
                lpr_imp_precio5p,
                lpr_imp_precio6p,
                lpr_imp_precio7p,
                lpr_imp_precio8p,
                lpr_imp_precio9p,
                lpr_imp_precio10p,
                TNGS_Carm..ListasDePrecios.instante,
                TNGS_Carm..ListasDePrecios.deleted,
                TNGS_Carm..ListasDePrecios.usuario,
                TNGS_Carm..ListasDePrecios.version
           from TNGS_Carm..ListasDePrecios
                join TNGS_Carm..Marcas
                  on lpr_rcd_codmarca = mrc_rcd_cod
                join TNGS_Carm..Planes
                  on lpr_cod_codplan = pln_cod_cod
          where TNGS_Carm..ListasDePrecios.deleted = 0
          order by lpr_cod_cod
      end
   else
      begin
         Select lpr_cod_cod,
                lpr_des_des,
                mrc_ede_des as des_marca,
                pln_des_des as des_plan,
                lpr_cod_codplan,
                lpr_rcd_codmarca,
                lpr_imp_precio1p,
                lpr_imp_precio2p,
                lpr_imp_precio3p,
                lpr_imp_precio4p,
                lpr_imp_precio5p,
                lpr_imp_precio6p,
                lpr_imp_precio7p,
                lpr_imp_precio8p,
                lpr_imp_precio9p,
                lpr_imp_precio10p,
                TNGS_Carm..ListasDePrecios.instante,
                TNGS_Carm..ListasDePrecios.deleted,
                TNGS_Carm..ListasDePrecios.usuario,
                TNGS_Carm..ListasDePrecios.version
           from TNGS_Carm..ListasDePrecios
                join TNGS_Carm..Marcas
                  on lpr_rcd_codmarca = mrc_rcd_cod
                join TNGS_Carm..Planes
                  on lpr_cod_codplan = pln_cod_cod
          order by lpr_cod_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.LISTASDEPRECIOS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@lpr_cod_cod">Código</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.LISTASDEPRECIOS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.LISTASDEPRECIOS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.LISTASDEPRECIOS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.LISTASDEPRECIOS_CHKVERSION
(
@lpr_cod_cod tngs_codigo,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Carm..ListasDePrecios
    where lpr_cod_cod = @lpr_cod_cod
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.LISTASDEPRECIOS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@lpr_cod_cod">Código</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.LISTASDEPRECIOS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.LISTASDEPRECIOS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.LISTASDEPRECIOS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.LISTASDEPRECIOS_SEARCH
(
@lpr_cod_cod tngs_codigo,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select lpr_cod_cod,
                lpr_des_des,
                mrc_ede_des as des_marca,
                pln_des_des as des_plan,
                lpr_cod_codplan,
                lpr_rcd_codmarca,
                lpr_imp_precio1p,
                lpr_imp_precio2p,
                lpr_imp_precio3p,
                lpr_imp_precio4p,
                lpr_imp_precio5p,
                lpr_imp_precio6p,
                lpr_imp_precio7p,
                lpr_imp_precio8p,
                lpr_imp_precio9p,
                lpr_imp_precio10p,
                TNGS_Carm..ListasDePrecios.instante,
                TNGS_Carm..ListasDePrecios.deleted,
                TNGS_Carm..ListasDePrecios.usuario,
                TNGS_Carm..ListasDePrecios.version
           from TNGS_Carm..ListasDePrecios
                join TNGS_Carm..Marcas
                  on lpr_rcd_codmarca = mrc_rcd_cod
                join TNGS_Carm..Planes
                  on lpr_cod_codplan = pln_cod_cod
          where lpr_cod_cod = @lpr_cod_cod
            and TNGS_Carm..ListasDePrecios.deleted = 0
      end
   else
      begin
         Select lpr_cod_cod,
                lpr_des_des,
                mrc_ede_des as des_marca,
                pln_des_des as des_plan,
                lpr_cod_codplan,
                lpr_rcd_codmarca,
                lpr_imp_precio1p,
                lpr_imp_precio2p,
                lpr_imp_precio3p,
                lpr_imp_precio4p,
                lpr_imp_precio5p,
                lpr_imp_precio6p,
                lpr_imp_precio7p,
                lpr_imp_precio8p,
                lpr_imp_precio9p,
                lpr_imp_precio10p,
                TNGS_Carm..ListasDePrecios.instante,
                TNGS_Carm..ListasDePrecios.deleted,
                TNGS_Carm..ListasDePrecios.usuario,
                TNGS_Carm..ListasDePrecios.version
           from TNGS_Carm..ListasDePrecios
                join TNGS_Carm..Marcas
                  on lpr_rcd_codmarca = mrc_rcd_cod
                join TNGS_Carm..Planes
                  on lpr_cod_codplan = pln_cod_cod
          where lpr_cod_cod = @lpr_cod_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.LISTASDEPRECIOS_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@lpr_cod_cod">Código</param>
--- <param name="@lpr_des_des">Descripción</param>
--- <param name="@lpr_cod_codplan">Plan</param>
--- <param name="@lpr_rcd_codmarca">Marca</param>
--- <param name="@lpr_imp_precio1p">Precio 1 P</param>
--- <param name="@lpr_imp_precio2p">Precio 2 P</param>
--- <param name="@lpr_imp_precio3p">Precio 3 P</param>
--- <param name="@lpr_imp_precio4p">Precio 4 P</param>
--- <param name="@lpr_imp_precio5p">Precio 5 P</param>
--- <param name="@lpr_imp_precio6p">Precio 6 P</param>
--- <param name="@lpr_imp_precio7p">Precio 7 P</param>
--- <param name="@lpr_imp_precio8p">Precio 8 P</param>
--- <param name="@lpr_imp_precio9p">Precio 9 P</param>
--- <param name="@lpr_imp_precio10p">Precio 10 P</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.LISTASDEPRECIOS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.LISTASDEPRECIOS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.LISTASDEPRECIOS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.LISTASDEPRECIOS_INSERT
(
@lpr_cod_cod tngs_codigo,
@lpr_des_des tngs_descripcion,
@lpr_cod_codplan tngs_codigo,
@lpr_rcd_codmarca tngs_codigo_r,
@lpr_imp_precio1p tngs_importe,
@lpr_imp_precio2p tngs_importe,
@lpr_imp_precio3p tngs_importe,
@lpr_imp_precio4p tngs_importe,
@lpr_imp_precio5p tngs_importe,
@lpr_imp_precio6p tngs_importe,
@lpr_imp_precio7p tngs_importe,
@lpr_imp_precio8p tngs_importe,
@lpr_imp_precio9p tngs_importe,
@lpr_imp_precio10p tngs_importe,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Carm..ListasDePrecios
   values (
           @lpr_cod_cod,
           @lpr_des_des,
           @lpr_cod_codplan,
           @lpr_rcd_codmarca,
           @lpr_imp_precio1p,
           @lpr_imp_precio2p,
           @lpr_imp_precio3p,
           @lpr_imp_precio4p,
           @lpr_imp_precio5p,
           @lpr_imp_precio6p,
           @lpr_imp_precio7p,
           @lpr_imp_precio8p,
           @lpr_imp_precio9p,
           @lpr_imp_precio10p,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.LISTASDEPRECIOS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@lpr_cod_cod">Código</param>
--- <param name="@lpr_des_des">Descripción</param>
--- <param name="@lpr_cod_codplan">Plan</param>
--- <param name="@lpr_rcd_codmarca">Marca</param>
--- <param name="@lpr_imp_precio1p">Precio 1 P</param>
--- <param name="@lpr_imp_precio2p">Precio 2 P</param>
--- <param name="@lpr_imp_precio3p">Precio 3 P</param>
--- <param name="@lpr_imp_precio4p">Precio 4 P</param>
--- <param name="@lpr_imp_precio5p">Precio 5 P</param>
--- <param name="@lpr_imp_precio6p">Precio 6 P</param>
--- <param name="@lpr_imp_precio7p">Precio 7 P</param>
--- <param name="@lpr_imp_precio8p">Precio 8 P</param>
--- <param name="@lpr_imp_precio9p">Precio 9 P</param>
--- <param name="@lpr_imp_precio10p">Precio 10 P</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.LISTASDEPRECIOS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.LISTASDEPRECIOS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.LISTASDEPRECIOS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.LISTASDEPRECIOS_UPDATE
(
@lpr_cod_cod tngs_codigo,
@lpr_des_des tngs_descripcion,
@lpr_cod_codplan tngs_codigo,
@lpr_rcd_codmarca tngs_codigo_r,
@lpr_imp_precio1p tngs_importe,
@lpr_imp_precio2p tngs_importe,
@lpr_imp_precio3p tngs_importe,
@lpr_imp_precio4p tngs_importe,
@lpr_imp_precio5p tngs_importe,
@lpr_imp_precio6p tngs_importe,
@lpr_imp_precio7p tngs_importe,
@lpr_imp_precio8p tngs_importe,
@lpr_imp_precio9p tngs_importe,
@lpr_imp_precio10p tngs_importe,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..ListasDePrecios
      set lpr_des_des= @lpr_des_des,
          lpr_cod_codplan= @lpr_cod_codplan,
          lpr_rcd_codmarca= @lpr_rcd_codmarca,
          lpr_imp_precio1p= @lpr_imp_precio1p,
          lpr_imp_precio2p= @lpr_imp_precio2p,
          lpr_imp_precio3p= @lpr_imp_precio3p,
          lpr_imp_precio4p= @lpr_imp_precio4p,
          lpr_imp_precio5p= @lpr_imp_precio5p,
          lpr_imp_precio6p= @lpr_imp_precio6p,
          lpr_imp_precio7p= @lpr_imp_precio7p,
          lpr_imp_precio8p= @lpr_imp_precio8p,
          lpr_imp_precio9p= @lpr_imp_precio9p,
          lpr_imp_precio10p= @lpr_imp_precio10p,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where lpr_cod_cod = @lpr_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.LISTASDEPRECIOS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@lpr_cod_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.LISTASDEPRECIOS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.LISTASDEPRECIOS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.LISTASDEPRECIOS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.LISTASDEPRECIOS_DELETE
(
@lpr_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..ListasDePrecios
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where lpr_cod_cod = @lpr_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.LISTASDEPRECIOS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@lpr_cod_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.LISTASDEPRECIOS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.LISTASDEPRECIOS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.LISTASDEPRECIOS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.LISTASDEPRECIOS_RECALL
(
@lpr_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..ListasDePrecios
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where lpr_cod_cod = @lpr_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.LISTASDEPRECIOS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@lpr_cod_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.LISTASDEPRECIOS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.LISTASDEPRECIOS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.LISTASDEPRECIOS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.LISTASDEPRECIOS_DROP
(
@lpr_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..ListasDePrecios
    where lpr_cod_cod = @lpr_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.LISTASDEPRECIOS_DROP to tngsmodulos

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

print 'Store Procedure: dbo.LISTASDEPRECIOS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.LISTASDEPRECIOS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.LISTASDEPRECIOS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.LISTASDEPRECIOS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Carm..ListasDePrecios
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.LISTASDEPRECIOS_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: ListasDePrecios
//--------------------------------------------------------------------------*/
