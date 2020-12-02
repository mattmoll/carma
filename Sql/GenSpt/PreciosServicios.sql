/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 01/12/2020 21:33
// Sistema     : Carm
// Tabla       : PreciosServicios
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

print 'Store Procedure: dbo.PRECIOSSERVICIOS_UP'

if exists (select * from sysobjects where id = object_id('dbo.PRECIOSSERVICIOS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PRECIOSSERVICIOS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PRECIOSSERVICIOS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select prs_cd1_color,
                prs_fec_fecha,
                prs_imp_precio,
                prs_imp_coseguro,
                TNGS_Carm..PreciosServicios.instante,
                TNGS_Carm..PreciosServicios.deleted,
                TNGS_Carm..PreciosServicios.usuario,
                TNGS_Carm..PreciosServicios.version
           from TNGS_Carm..PreciosServicios
          where deleted = 0
          order by prs_cd1_color,
                prs_fec_fecha
      end
   else
      begin
         Select prs_cd1_color,
                prs_fec_fecha,
                prs_imp_precio,
                prs_imp_coseguro,
                TNGS_Carm..PreciosServicios.instante,
                TNGS_Carm..PreciosServicios.deleted,
                TNGS_Carm..PreciosServicios.usuario,
                TNGS_Carm..PreciosServicios.version
           from TNGS_Carm..PreciosServicios
          order by prs_cd1_color,
                prs_fec_fecha
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PRECIOSSERVICIOS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@prs_cd1_color">Color</param>
--- <param name="@prs_fec_fecha">Fecha</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PRECIOSSERVICIOS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.PRECIOSSERVICIOS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PRECIOSSERVICIOS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PRECIOSSERVICIOS_CHKVERSION
(
@prs_cd1_color tngs_codigo_1,
@prs_fec_fecha tngs_fecha,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Carm..PreciosServicios
    where prs_cd1_color = @prs_cd1_color
      and prs_fec_fecha = @prs_fec_fecha
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PRECIOSSERVICIOS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@prs_cd1_color">Color</param>
--- <param name="@prs_fec_fecha">Fecha</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PRECIOSSERVICIOS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.PRECIOSSERVICIOS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PRECIOSSERVICIOS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PRECIOSSERVICIOS_SEARCH
(
@prs_cd1_color tngs_codigo_1,
@prs_fec_fecha tngs_fecha,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select prs_cd1_color,
                prs_fec_fecha,
                prs_imp_precio,
                prs_imp_coseguro,
                TNGS_Carm..PreciosServicios.instante,
                TNGS_Carm..PreciosServicios.deleted,
                TNGS_Carm..PreciosServicios.usuario,
                TNGS_Carm..PreciosServicios.version
           from TNGS_Carm..PreciosServicios
          where prs_cd1_color = @prs_cd1_color
            and prs_fec_fecha = @prs_fec_fecha
            and deleted = 0
      end
   else
      begin
         Select prs_cd1_color,
                prs_fec_fecha,
                prs_imp_precio,
                prs_imp_coseguro,
                TNGS_Carm..PreciosServicios.instante,
                TNGS_Carm..PreciosServicios.deleted,
                TNGS_Carm..PreciosServicios.usuario,
                TNGS_Carm..PreciosServicios.version
           from TNGS_Carm..PreciosServicios
          where prs_cd1_color = @prs_cd1_color
            and prs_fec_fecha = @prs_fec_fecha
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PRECIOSSERVICIOS_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@prs_cd1_color">Color</param>
--- <param name="@prs_fec_fecha">Fecha</param>
--- <param name="@prs_imp_precio">Precio</param>
--- <param name="@prs_imp_coseguro">coseguro</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PRECIOSSERVICIOS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.PRECIOSSERVICIOS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PRECIOSSERVICIOS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PRECIOSSERVICIOS_INSERT
(
@prs_cd1_color tngs_codigo_1,
@prs_fec_fecha tngs_fecha,
@prs_imp_precio tngs_importe,
@prs_imp_coseguro tngs_importe,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Carm..PreciosServicios
   values (
           @prs_cd1_color,
           @prs_fec_fecha,
           @prs_imp_precio,
           @prs_imp_coseguro,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PRECIOSSERVICIOS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@prs_cd1_color">Color</param>
--- <param name="@prs_fec_fecha">Fecha</param>
--- <param name="@prs_imp_precio">Precio</param>
--- <param name="@prs_imp_coseguro">coseguro</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PRECIOSSERVICIOS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.PRECIOSSERVICIOS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PRECIOSSERVICIOS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PRECIOSSERVICIOS_UPDATE
(
@prs_cd1_color tngs_codigo_1,
@prs_fec_fecha tngs_fecha,
@prs_imp_precio tngs_importe,
@prs_imp_coseguro tngs_importe,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..PreciosServicios
      set prs_imp_precio= @prs_imp_precio,
          prs_imp_coseguro= @prs_imp_coseguro,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where prs_cd1_color = @prs_cd1_color
      and prs_fec_fecha = @prs_fec_fecha

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PRECIOSSERVICIOS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@prs_cd1_color">Color</param>
--- <param name="@prs_fec_fecha">Fecha</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PRECIOSSERVICIOS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.PRECIOSSERVICIOS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PRECIOSSERVICIOS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PRECIOSSERVICIOS_DELETE
(
@prs_cd1_color tngs_codigo_1,
@prs_fec_fecha tngs_fecha,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..PreciosServicios
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where prs_cd1_color = @prs_cd1_color
      and prs_fec_fecha = @prs_fec_fecha

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PRECIOSSERVICIOS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@prs_cd1_color">Color</param>
--- <param name="@prs_fec_fecha">Fecha</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PRECIOSSERVICIOS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.PRECIOSSERVICIOS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PRECIOSSERVICIOS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PRECIOSSERVICIOS_RECALL
(
@prs_cd1_color tngs_codigo_1,
@prs_fec_fecha tngs_fecha,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..PreciosServicios
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where prs_cd1_color = @prs_cd1_color
      and prs_fec_fecha = @prs_fec_fecha

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PRECIOSSERVICIOS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@prs_cd1_color">Color</param>
--- <param name="@prs_fec_fecha">Fecha</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PRECIOSSERVICIOS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.PRECIOSSERVICIOS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PRECIOSSERVICIOS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PRECIOSSERVICIOS_DROP
(
@prs_cd1_color tngs_codigo_1,
@prs_fec_fecha tngs_fecha,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..PreciosServicios
    where prs_cd1_color = @prs_cd1_color
      and prs_fec_fecha = @prs_fec_fecha

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PRECIOSSERVICIOS_DROP to tngsmodulos

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

print 'Store Procedure: dbo.PRECIOSSERVICIOS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.PRECIOSSERVICIOS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PRECIOSSERVICIOS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PRECIOSSERVICIOS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Carm..PreciosServicios
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PRECIOSSERVICIOS_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: GetHistorialColor
--- </summary>
--- <param name="@color">Color</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PRECIOSSERVICIOS_GETHISTORIALCOLOR'

if exists (select * from sysobjects where id = object_id('dbo.PRECIOSSERVICIOS_GETHISTORIALCOLOR'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PRECIOSSERVICIOS_GETHISTORIALCOLOR
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PRECIOSSERVICIOS_GETHISTORIALCOLOR
(
@color tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Select prs_cd1_color,
          prs_fec_fecha,
          prs_imp_precio,
          prs_imp_coseguro,
          TNGS_Carm..PreciosServicios.instante,
          TNGS_Carm..PreciosServicios.deleted,
          TNGS_Carm..PreciosServicios.usuario,
          TNGS_Carm..PreciosServicios.version
     from TNGS_Carm..PreciosServicios 
   where prs_cd1_color = @color 
   order by prs_fec_fecha desc 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PRECIOSSERVICIOS_GETHISTORIALCOLOR to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: PreciosServicios
//--------------------------------------------------------------------------*/
