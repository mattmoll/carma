/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 22/08/2020 01:51
// Sistema     : Carm
// Tabla       : CliServicios
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

print 'Store Procedure: dbo.CLISERVICIOS_UP'

if exists (select * from sysobjects where id = object_id('dbo.CLISERVICIOS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLISERVICIOS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLISERVICIOS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select cls_nro_numcliente,
                cls_nro_item,
                cls_cod_codservicio,
                isnull(srv_des_des,'') as cls_des_serv,
                cls_imp_coseguro,
                cls_imp_valorprestacion,
                cls_nro_cantestprestaciones,
                TNGS_Carm..CliServicios.instante,
                TNGS_Carm..CliServicios.deleted,
                TNGS_Carm..CliServicios.usuario,
                TNGS_Carm..CliServicios.version
           from TNGS_Carm..CliServicios
                left outer join TNGS_Carm..Servicios
                  on cls_cod_codservicio = srv_cod_cod
          where TNGS_Carm..CliServicios.deleted = 0
          order by cls_nro_numcliente,
                cls_nro_item
      end
   else
      begin
         Select cls_nro_numcliente,
                cls_nro_item,
                cls_cod_codservicio,
                isnull(srv_des_des,'') as cls_des_serv,
                cls_imp_coseguro,
                cls_imp_valorprestacion,
                cls_nro_cantestprestaciones,
                TNGS_Carm..CliServicios.instante,
                TNGS_Carm..CliServicios.deleted,
                TNGS_Carm..CliServicios.usuario,
                TNGS_Carm..CliServicios.version
           from TNGS_Carm..CliServicios
                left outer join TNGS_Carm..Servicios
                  on cls_cod_codservicio = srv_cod_cod
          order by cls_nro_numcliente,
                cls_nro_item
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLISERVICIOS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@cls_nro_numcliente">Número Cliente</param>
--- <param name="@cls_nro_item">Item</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLISERVICIOS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.CLISERVICIOS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLISERVICIOS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLISERVICIOS_CHKVERSION
(
@cls_nro_numcliente tngs_numero,
@cls_nro_item tngs_numero,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Carm..CliServicios
    where cls_nro_numcliente = @cls_nro_numcliente
      and cls_nro_item = @cls_nro_item
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLISERVICIOS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@cls_nro_numcliente">Número Cliente</param>
--- <param name="@cls_nro_item">Item</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLISERVICIOS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.CLISERVICIOS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLISERVICIOS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLISERVICIOS_SEARCH
(
@cls_nro_numcliente tngs_numero,
@cls_nro_item tngs_numero,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select cls_nro_numcliente,
                cls_nro_item,
                cls_cod_codservicio,
                isnull(srv_des_des,'') as cls_des_serv,
                cls_imp_coseguro,
                cls_imp_valorprestacion,
                cls_nro_cantestprestaciones,
                TNGS_Carm..CliServicios.instante,
                TNGS_Carm..CliServicios.deleted,
                TNGS_Carm..CliServicios.usuario,
                TNGS_Carm..CliServicios.version
           from TNGS_Carm..CliServicios
                left outer join TNGS_Carm..Servicios
                  on cls_cod_codservicio = srv_cod_cod
          where cls_nro_numcliente = @cls_nro_numcliente
            and cls_nro_item = @cls_nro_item
            and TNGS_Carm..CliServicios.deleted = 0
      end
   else
      begin
         Select cls_nro_numcliente,
                cls_nro_item,
                cls_cod_codservicio,
                isnull(srv_des_des,'') as cls_des_serv,
                cls_imp_coseguro,
                cls_imp_valorprestacion,
                cls_nro_cantestprestaciones,
                TNGS_Carm..CliServicios.instante,
                TNGS_Carm..CliServicios.deleted,
                TNGS_Carm..CliServicios.usuario,
                TNGS_Carm..CliServicios.version
           from TNGS_Carm..CliServicios
                left outer join TNGS_Carm..Servicios
                  on cls_cod_codservicio = srv_cod_cod
          where cls_nro_numcliente = @cls_nro_numcliente
            and cls_nro_item = @cls_nro_item
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLISERVICIOS_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca los registros de una clave foranea
--- </summary>
--- <param name="@cls_nro_numcliente">Número Cliente</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLISERVICIOS_FSEARCH'

if exists (select * from sysobjects where id = object_id('dbo.CLISERVICIOS_FSEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLISERVICIOS_FSEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLISERVICIOS_FSEARCH
(
@cls_nro_numcliente tngs_numero,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select cls_nro_numcliente,
                cls_nro_item,
                cls_cod_codservicio,
                isnull(srv_des_des,'') as cls_des_serv,
                cls_imp_coseguro,
                cls_imp_valorprestacion,
                cls_nro_cantestprestaciones,
                TNGS_Carm..CliServicios.instante,
                TNGS_Carm..CliServicios.deleted,
                TNGS_Carm..CliServicios.usuario,
                TNGS_Carm..CliServicios.version
           from TNGS_Carm..CliServicios
                left outer join TNGS_Carm..Servicios
                  on cls_cod_codservicio = srv_cod_cod
          where cls_nro_numcliente = @cls_nro_numcliente
            and TNGS_Carm..CliServicios.deleted = 0
          order by cls_nro_item
      end
   else
      begin
         Select cls_nro_numcliente,
                cls_nro_item,
                cls_cod_codservicio,
                isnull(srv_des_des,'') as cls_des_serv,
                cls_imp_coseguro,
                cls_imp_valorprestacion,
                cls_nro_cantestprestaciones,
                TNGS_Carm..CliServicios.instante,
                TNGS_Carm..CliServicios.deleted,
                TNGS_Carm..CliServicios.usuario,
                TNGS_Carm..CliServicios.version
           from TNGS_Carm..CliServicios
                left outer join TNGS_Carm..Servicios
                  on cls_cod_codservicio = srv_cod_cod
          where cls_nro_numcliente = @cls_nro_numcliente
          order by cls_nro_item
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLISERVICIOS_FSEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@cls_nro_numcliente">Número Cliente</param>
--- <param name="@cls_nro_item">Item</param>
--- <param name="@cls_cod_codservicio">Código de Servicio</param>
--- <param name="@cls_imp_coseguro">Coseguro</param>
--- <param name="@cls_imp_valorprestacion">Valor Prestación</param>
--- <param name="@cls_nro_cantestprestaciones">Cant. Estimada Prestaciones</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLISERVICIOS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.CLISERVICIOS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLISERVICIOS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLISERVICIOS_INSERT
(
@cls_nro_numcliente tngs_numero,
@cls_nro_item tngs_numero,
@cls_cod_codservicio tngs_codigo,
@cls_imp_coseguro tngs_importe,
@cls_imp_valorprestacion tngs_importe,
@cls_nro_cantestprestaciones tngs_numero,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Carm..CliServicios
   values (
           @cls_nro_numcliente,
           @cls_nro_item,
           @cls_cod_codservicio,
           @cls_imp_coseguro,
           @cls_imp_valorprestacion,
           @cls_nro_cantestprestaciones,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLISERVICIOS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@cls_nro_numcliente">Número Cliente</param>
--- <param name="@cls_nro_item">Item</param>
--- <param name="@cls_cod_codservicio">Código de Servicio</param>
--- <param name="@cls_imp_coseguro">Coseguro</param>
--- <param name="@cls_imp_valorprestacion">Valor Prestación</param>
--- <param name="@cls_nro_cantestprestaciones">Cant. Estimada Prestaciones</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLISERVICIOS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.CLISERVICIOS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLISERVICIOS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLISERVICIOS_UPDATE
(
@cls_nro_numcliente tngs_numero,
@cls_nro_item tngs_numero,
@cls_cod_codservicio tngs_codigo,
@cls_imp_coseguro tngs_importe,
@cls_imp_valorprestacion tngs_importe,
@cls_nro_cantestprestaciones tngs_numero,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..CliServicios
      set cls_cod_codservicio= @cls_cod_codservicio,
          cls_imp_coseguro= @cls_imp_coseguro,
          cls_imp_valorprestacion= @cls_imp_valorprestacion,
          cls_nro_cantestprestaciones= @cls_nro_cantestprestaciones,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where cls_nro_numcliente = @cls_nro_numcliente
      and cls_nro_item = @cls_nro_item

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLISERVICIOS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@cls_nro_numcliente">Número Cliente</param>
--- <param name="@cls_nro_item">Item</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLISERVICIOS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.CLISERVICIOS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLISERVICIOS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLISERVICIOS_DELETE
(
@cls_nro_numcliente tngs_numero,
@cls_nro_item tngs_numero,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..CliServicios
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where cls_nro_numcliente = @cls_nro_numcliente
      and cls_nro_item = @cls_nro_item

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLISERVICIOS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro por clave foranea
--- </summary>
--- <param name="@cls_nro_numcliente">Número Cliente</param>
--- <param name="@instante">Instante del delete</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLISERVICIOS_FDELETE'

if exists (select * from sysobjects where id = object_id('dbo.CLISERVICIOS_FDELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLISERVICIOS_FDELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLISERVICIOS_FDELETE
(
@cls_nro_numcliente tngs_numero,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         select @instante= getdate()
      end

   Update TNGS_Carm..CliServicios
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= @instante,
          usuario = @usuario
    where cls_nro_numcliente = @cls_nro_numcliente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLISERVICIOS_FDELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@cls_nro_numcliente">Número Cliente</param>
--- <param name="@cls_nro_item">Item</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLISERVICIOS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.CLISERVICIOS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLISERVICIOS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLISERVICIOS_RECALL
(
@cls_nro_numcliente tngs_numero,
@cls_nro_item tngs_numero,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..CliServicios
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where cls_nro_numcliente = @cls_nro_numcliente
      and cls_nro_item = @cls_nro_item

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLISERVICIOS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera lógicamente los registros de una clave foranea
--- </summary>
--- <param name="@cls_nro_numcliente">Número Cliente</param>
--- <param name="@instante">Instante de referencia</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLISERVICIOS_FRECALL'

if exists (select * from sysobjects where id = object_id('dbo.CLISERVICIOS_FRECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLISERVICIOS_FRECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLISERVICIOS_FRECALL
(
@cls_nro_numcliente tngs_numero,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         Update TNGS_Carm..CliServicios
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where cls_nro_numcliente = @cls_nro_numcliente
      end
   else
      begin
         Update TNGS_Carm..CliServicios
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where cls_nro_numcliente = @cls_nro_numcliente
            and instante= @instante
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLISERVICIOS_FRECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@cls_nro_numcliente">Número Cliente</param>
--- <param name="@cls_nro_item">Item</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLISERVICIOS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.CLISERVICIOS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLISERVICIOS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLISERVICIOS_DROP
(
@cls_nro_numcliente tngs_numero,
@cls_nro_item tngs_numero,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..CliServicios
    where cls_nro_numcliente = @cls_nro_numcliente
      and cls_nro_item = @cls_nro_item

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLISERVICIOS_DROP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro por clave foránea
--- </summary>
--- <param name="@cls_nro_numcliente">Número Cliente</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLISERVICIOS_FDROP'

if exists (select * from sysobjects where id = object_id('dbo.CLISERVICIOS_FDROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLISERVICIOS_FDROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLISERVICIOS_FDROP
(
@cls_nro_numcliente tngs_numero,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..CliServicios
    where cls_nro_numcliente = @cls_nro_numcliente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLISERVICIOS_FDROP to tngsmodulos

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

print 'Store Procedure: dbo.CLISERVICIOS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.CLISERVICIOS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLISERVICIOS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLISERVICIOS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Carm..CliServicios
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLISERVICIOS_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente los registro borrados lógicamente por clave foránea
--- </summary>
--- <param name="@cls_nro_numcliente">Número Cliente</param>
--- <param name="@usuario">Usuario que realiza el pack</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLISERVICIOS_FPACK'

if exists (select * from sysobjects where id = object_id('dbo.CLISERVICIOS_FPACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLISERVICIOS_FPACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLISERVICIOS_FPACK
(
@cls_nro_numcliente tngs_numero,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..CliServicios
    where cls_nro_numcliente = @cls_nro_numcliente
      and deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLISERVICIOS_FPACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: BorraPorCliente
--- </summary>
--- <param name="@nrocliente">Numero del cliente a borrar los servicios</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLISERVICIOS_BORRAPORCLIENTE'

if exists (select * from sysobjects where id = object_id('dbo.CLISERVICIOS_BORRAPORCLIENTE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLISERVICIOS_BORRAPORCLIENTE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLISERVICIOS_BORRAPORCLIENTE
(
@nrocliente tngs_numero,
@usuario tngs_nombre
)
as
begin

   delete from CliServicios 
   where cls_nro_numcliente = @nrocliente 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLISERVICIOS_BORRAPORCLIENTE to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: CliServicios
//--------------------------------------------------------------------------*/
