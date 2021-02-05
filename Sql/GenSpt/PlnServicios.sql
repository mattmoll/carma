/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 05/02/2021 12:21
// Sistema     : Carm
// Tabla       : PlnServicios
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

print 'Store Procedure: dbo.PLNSERVICIOS_UP'

if exists (select * from sysobjects where id = object_id('dbo.PLNSERVICIOS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PLNSERVICIOS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PLNSERVICIOS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select pls_cod_codplan,
                pln_des_des as pls_des_plan,
                pls_cod_codservicio,
                srv_des_des as pls_des_serv,
                pls_nro_cprestlibres,
                pls_imp_valorprestacion,
                TNGS_Carm..PlnServicios.instante,
                TNGS_Carm..PlnServicios.deleted,
                TNGS_Carm..PlnServicios.usuario,
                TNGS_Carm..PlnServicios.version
           from TNGS_Carm..PlnServicios
                join TNGS_Carm..Planes
                  on pls_cod_codplan = pln_cod_cod
                join TNGS_Carm..Servicios
                  on pls_cod_codservicio = srv_cod_cod
          where TNGS_Carm..PlnServicios.deleted = 0
          order by pls_cod_codplan,
                pls_cod_codservicio
      end
   else
      begin
         Select pls_cod_codplan,
                pln_des_des as pls_des_plan,
                pls_cod_codservicio,
                srv_des_des as pls_des_serv,
                pls_nro_cprestlibres,
                pls_imp_valorprestacion,
                TNGS_Carm..PlnServicios.instante,
                TNGS_Carm..PlnServicios.deleted,
                TNGS_Carm..PlnServicios.usuario,
                TNGS_Carm..PlnServicios.version
           from TNGS_Carm..PlnServicios
                join TNGS_Carm..Planes
                  on pls_cod_codplan = pln_cod_cod
                join TNGS_Carm..Servicios
                  on pls_cod_codservicio = srv_cod_cod
          order by pls_cod_codplan,
                pls_cod_codservicio
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PLNSERVICIOS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@pls_cod_codplan">Código de Plan</param>
--- <param name="@pls_cod_codservicio">Código de Servicio</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PLNSERVICIOS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.PLNSERVICIOS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PLNSERVICIOS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PLNSERVICIOS_CHKVERSION
(
@pls_cod_codplan tngs_codigo,
@pls_cod_codservicio tngs_codigo,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Carm..PlnServicios
    where pls_cod_codplan = @pls_cod_codplan
      and pls_cod_codservicio = @pls_cod_codservicio
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PLNSERVICIOS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@pls_cod_codplan">Código de Plan</param>
--- <param name="@pls_cod_codservicio">Código de Servicio</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PLNSERVICIOS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.PLNSERVICIOS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PLNSERVICIOS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PLNSERVICIOS_SEARCH
(
@pls_cod_codplan tngs_codigo,
@pls_cod_codservicio tngs_codigo,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select pls_cod_codplan,
                pln_des_des as pls_des_plan,
                pls_cod_codservicio,
                srv_des_des as pls_des_serv,
                pls_nro_cprestlibres,
                pls_imp_valorprestacion,
                TNGS_Carm..PlnServicios.instante,
                TNGS_Carm..PlnServicios.deleted,
                TNGS_Carm..PlnServicios.usuario,
                TNGS_Carm..PlnServicios.version
           from TNGS_Carm..PlnServicios
                join TNGS_Carm..Planes
                  on pls_cod_codplan = pln_cod_cod
                join TNGS_Carm..Servicios
                  on pls_cod_codservicio = srv_cod_cod
          where pls_cod_codplan = @pls_cod_codplan
            and pls_cod_codservicio = @pls_cod_codservicio
            and TNGS_Carm..PlnServicios.deleted = 0
      end
   else
      begin
         Select pls_cod_codplan,
                pln_des_des as pls_des_plan,
                pls_cod_codservicio,
                srv_des_des as pls_des_serv,
                pls_nro_cprestlibres,
                pls_imp_valorprestacion,
                TNGS_Carm..PlnServicios.instante,
                TNGS_Carm..PlnServicios.deleted,
                TNGS_Carm..PlnServicios.usuario,
                TNGS_Carm..PlnServicios.version
           from TNGS_Carm..PlnServicios
                join TNGS_Carm..Planes
                  on pls_cod_codplan = pln_cod_cod
                join TNGS_Carm..Servicios
                  on pls_cod_codservicio = srv_cod_cod
          where pls_cod_codplan = @pls_cod_codplan
            and pls_cod_codservicio = @pls_cod_codservicio
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PLNSERVICIOS_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca los registros de una clave foranea
--- </summary>
--- <param name="@pls_cod_codplan">Código de Plan</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PLNSERVICIOS_FSEARCH'

if exists (select * from sysobjects where id = object_id('dbo.PLNSERVICIOS_FSEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PLNSERVICIOS_FSEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PLNSERVICIOS_FSEARCH
(
@pls_cod_codplan tngs_codigo,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select pls_cod_codplan,
                pln_des_des as pls_des_plan,
                pls_cod_codservicio,
                srv_des_des as pls_des_serv,
                pls_nro_cprestlibres,
                pls_imp_valorprestacion,
                TNGS_Carm..PlnServicios.instante,
                TNGS_Carm..PlnServicios.deleted,
                TNGS_Carm..PlnServicios.usuario,
                TNGS_Carm..PlnServicios.version
           from TNGS_Carm..PlnServicios
                join TNGS_Carm..Planes
                  on pls_cod_codplan = pln_cod_cod
                join TNGS_Carm..Servicios
                  on pls_cod_codservicio = srv_cod_cod
          where pls_cod_codplan = @pls_cod_codplan
            and TNGS_Carm..PlnServicios.deleted = 0
          order by pls_cod_codservicio
      end
   else
      begin
         Select pls_cod_codplan,
                pln_des_des as pls_des_plan,
                pls_cod_codservicio,
                srv_des_des as pls_des_serv,
                pls_nro_cprestlibres,
                pls_imp_valorprestacion,
                TNGS_Carm..PlnServicios.instante,
                TNGS_Carm..PlnServicios.deleted,
                TNGS_Carm..PlnServicios.usuario,
                TNGS_Carm..PlnServicios.version
           from TNGS_Carm..PlnServicios
                join TNGS_Carm..Planes
                  on pls_cod_codplan = pln_cod_cod
                join TNGS_Carm..Servicios
                  on pls_cod_codservicio = srv_cod_cod
          where pls_cod_codplan = @pls_cod_codplan
          order by pls_cod_codservicio
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PLNSERVICIOS_FSEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@pls_cod_codplan">Código de Plan</param>
--- <param name="@pls_cod_codservicio">Código de Servicio</param>
--- <param name="@pls_nro_cprestlibres">Cant. Prestaciones Libres</param>
--- <param name="@pls_imp_valorprestacion">Valor Prestación</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PLNSERVICIOS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.PLNSERVICIOS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PLNSERVICIOS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PLNSERVICIOS_INSERT
(
@pls_cod_codplan tngs_codigo,
@pls_cod_codservicio tngs_codigo,
@pls_nro_cprestlibres tngs_numero,
@pls_imp_valorprestacion tngs_importe,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Carm..PlnServicios
   values (
           @pls_cod_codplan,
           @pls_cod_codservicio,
           @pls_nro_cprestlibres,
           @pls_imp_valorprestacion,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PLNSERVICIOS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@pls_cod_codplan">Código de Plan</param>
--- <param name="@pls_cod_codservicio">Código de Servicio</param>
--- <param name="@pls_nro_cprestlibres">Cant. Prestaciones Libres</param>
--- <param name="@pls_imp_valorprestacion">Valor Prestación</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PLNSERVICIOS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.PLNSERVICIOS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PLNSERVICIOS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PLNSERVICIOS_UPDATE
(
@pls_cod_codplan tngs_codigo,
@pls_cod_codservicio tngs_codigo,
@pls_nro_cprestlibres tngs_numero,
@pls_imp_valorprestacion tngs_importe,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..PlnServicios
      set pls_nro_cprestlibres= @pls_nro_cprestlibres,
          pls_imp_valorprestacion= @pls_imp_valorprestacion,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where pls_cod_codplan = @pls_cod_codplan
      and pls_cod_codservicio = @pls_cod_codservicio

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PLNSERVICIOS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@pls_cod_codplan">Código de Plan</param>
--- <param name="@pls_cod_codservicio">Código de Servicio</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PLNSERVICIOS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.PLNSERVICIOS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PLNSERVICIOS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PLNSERVICIOS_DELETE
(
@pls_cod_codplan tngs_codigo,
@pls_cod_codservicio tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..PlnServicios
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where pls_cod_codplan = @pls_cod_codplan
      and pls_cod_codservicio = @pls_cod_codservicio

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PLNSERVICIOS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro por clave foranea
--- </summary>
--- <param name="@pls_cod_codplan">Código de Plan</param>
--- <param name="@instante">Instante del delete</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PLNSERVICIOS_FDELETE'

if exists (select * from sysobjects where id = object_id('dbo.PLNSERVICIOS_FDELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PLNSERVICIOS_FDELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PLNSERVICIOS_FDELETE
(
@pls_cod_codplan tngs_codigo,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         select @instante= getdate()
      end

   Update TNGS_Carm..PlnServicios
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= @instante,
          usuario = @usuario
    where pls_cod_codplan = @pls_cod_codplan

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PLNSERVICIOS_FDELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@pls_cod_codplan">Código de Plan</param>
--- <param name="@pls_cod_codservicio">Código de Servicio</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PLNSERVICIOS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.PLNSERVICIOS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PLNSERVICIOS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PLNSERVICIOS_RECALL
(
@pls_cod_codplan tngs_codigo,
@pls_cod_codservicio tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..PlnServicios
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where pls_cod_codplan = @pls_cod_codplan
      and pls_cod_codservicio = @pls_cod_codservicio

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PLNSERVICIOS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera lógicamente los registros de una clave foranea
--- </summary>
--- <param name="@pls_cod_codplan">Código de Plan</param>
--- <param name="@instante">Instante de referencia</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PLNSERVICIOS_FRECALL'

if exists (select * from sysobjects where id = object_id('dbo.PLNSERVICIOS_FRECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PLNSERVICIOS_FRECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PLNSERVICIOS_FRECALL
(
@pls_cod_codplan tngs_codigo,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         Update TNGS_Carm..PlnServicios
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where pls_cod_codplan = @pls_cod_codplan
      end
   else
      begin
         Update TNGS_Carm..PlnServicios
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where pls_cod_codplan = @pls_cod_codplan
            and instante= @instante
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PLNSERVICIOS_FRECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@pls_cod_codplan">Código de Plan</param>
--- <param name="@pls_cod_codservicio">Código de Servicio</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PLNSERVICIOS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.PLNSERVICIOS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PLNSERVICIOS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PLNSERVICIOS_DROP
(
@pls_cod_codplan tngs_codigo,
@pls_cod_codservicio tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..PlnServicios
    where pls_cod_codplan = @pls_cod_codplan
      and pls_cod_codservicio = @pls_cod_codservicio

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PLNSERVICIOS_DROP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro por clave foránea
--- </summary>
--- <param name="@pls_cod_codplan">Código de Plan</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PLNSERVICIOS_FDROP'

if exists (select * from sysobjects where id = object_id('dbo.PLNSERVICIOS_FDROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PLNSERVICIOS_FDROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PLNSERVICIOS_FDROP
(
@pls_cod_codplan tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..PlnServicios
    where pls_cod_codplan = @pls_cod_codplan

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PLNSERVICIOS_FDROP to tngsmodulos

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

print 'Store Procedure: dbo.PLNSERVICIOS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.PLNSERVICIOS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PLNSERVICIOS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PLNSERVICIOS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Carm..PlnServicios
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PLNSERVICIOS_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente los registro borrados lógicamente por clave foránea
--- </summary>
--- <param name="@pls_cod_codplan">Código de Plan</param>
--- <param name="@usuario">Usuario que realiza el pack</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PLNSERVICIOS_FPACK'

if exists (select * from sysobjects where id = object_id('dbo.PLNSERVICIOS_FPACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PLNSERVICIOS_FPACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PLNSERVICIOS_FPACK
(
@pls_cod_codplan tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..PlnServicios
    where pls_cod_codplan = @pls_cod_codplan
      and deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PLNSERVICIOS_FPACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: PlnServicios
//--------------------------------------------------------------------------*/
