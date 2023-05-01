/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 30/04/2023 21:00
// Sistema     : Carm
// Tabla       : CliNotas
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

print 'Store Procedure: dbo.CLINOTAS_UP'

if exists (select * from sysobjects where id = object_id('dbo.CLINOTAS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLINOTAS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLINOTAS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select cln_nro_numcliente,
                cln_fyh_fechayhora,
                cln_des_titulo,
                cln_xld_texto,
                cln_cd1_tipo,
                dbo.CLINOTAS_ESTABORRADA(cln_nro_numcliente,cln_fyh_fechayhora) as cln_cd1_borrada,
                cln_nom_escritor,
                cln_nom_removedor,
                cln_fyh_fyhremovida,
                TNGS_Carm..CliNotas.instante,
                TNGS_Carm..CliNotas.deleted,
                TNGS_Carm..CliNotas.usuario,
                TNGS_Carm..CliNotas.version
           from TNGS_Carm..CliNotas
          where deleted = 0
          order by cln_nro_numcliente,
                cln_fyh_fechayhora
      end
   else
      begin
         Select cln_nro_numcliente,
                cln_fyh_fechayhora,
                cln_des_titulo,
                cln_xld_texto,
                cln_cd1_tipo,
                dbo.CLINOTAS_ESTABORRADA(cln_nro_numcliente,cln_fyh_fechayhora) as cln_cd1_borrada,
                cln_nom_escritor,
                cln_nom_removedor,
                cln_fyh_fyhremovida,
                TNGS_Carm..CliNotas.instante,
                TNGS_Carm..CliNotas.deleted,
                TNGS_Carm..CliNotas.usuario,
                TNGS_Carm..CliNotas.version
           from TNGS_Carm..CliNotas
          order by cln_nro_numcliente,
                cln_fyh_fechayhora
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLINOTAS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@cln_nro_numcliente">Numero del Cliente</param>
--- <param name="@cln_fyh_fechayhora">Fecha y Hora</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLINOTAS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.CLINOTAS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLINOTAS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLINOTAS_CHKVERSION
(
@cln_nro_numcliente tngs_numero,
@cln_fyh_fechayhora tngs_fecyhor,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Carm..CliNotas
    where cln_nro_numcliente = @cln_nro_numcliente
      and cln_fyh_fechayhora = @cln_fyh_fechayhora
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLINOTAS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@cln_nro_numcliente">Numero del Cliente</param>
--- <param name="@cln_fyh_fechayhora">Fecha y Hora</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLINOTAS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.CLINOTAS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLINOTAS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLINOTAS_SEARCH
(
@cln_nro_numcliente tngs_numero,
@cln_fyh_fechayhora tngs_fecyhor,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select cln_nro_numcliente,
                cln_fyh_fechayhora,
                cln_des_titulo,
                cln_xld_texto,
                cln_cd1_tipo,
                dbo.CLINOTAS_ESTABORRADA(cln_nro_numcliente,cln_fyh_fechayhora) as cln_cd1_borrada,
                cln_nom_escritor,
                cln_nom_removedor,
                cln_fyh_fyhremovida,
                TNGS_Carm..CliNotas.instante,
                TNGS_Carm..CliNotas.deleted,
                TNGS_Carm..CliNotas.usuario,
                TNGS_Carm..CliNotas.version
           from TNGS_Carm..CliNotas
          where cln_nro_numcliente = @cln_nro_numcliente
            and cln_fyh_fechayhora = @cln_fyh_fechayhora
            and deleted = 0
      end
   else
      begin
         Select cln_nro_numcliente,
                cln_fyh_fechayhora,
                cln_des_titulo,
                cln_xld_texto,
                cln_cd1_tipo,
                dbo.CLINOTAS_ESTABORRADA(cln_nro_numcliente,cln_fyh_fechayhora) as cln_cd1_borrada,
                cln_nom_escritor,
                cln_nom_removedor,
                cln_fyh_fyhremovida,
                TNGS_Carm..CliNotas.instante,
                TNGS_Carm..CliNotas.deleted,
                TNGS_Carm..CliNotas.usuario,
                TNGS_Carm..CliNotas.version
           from TNGS_Carm..CliNotas
          where cln_nro_numcliente = @cln_nro_numcliente
            and cln_fyh_fechayhora = @cln_fyh_fechayhora
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLINOTAS_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca los registros de una clave foranea
--- </summary>
--- <param name="@cln_nro_numcliente">Numero del Cliente</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLINOTAS_FSEARCH'

if exists (select * from sysobjects where id = object_id('dbo.CLINOTAS_FSEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLINOTAS_FSEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLINOTAS_FSEARCH
(
@cln_nro_numcliente tngs_numero,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select cln_nro_numcliente,
                cln_fyh_fechayhora,
                cln_des_titulo,
                cln_xld_texto,
                cln_cd1_tipo,
                dbo.CLINOTAS_ESTABORRADA(cln_nro_numcliente,cln_fyh_fechayhora) as cln_cd1_borrada,
                cln_nom_escritor,
                cln_nom_removedor,
                cln_fyh_fyhremovida,
                TNGS_Carm..CliNotas.instante,
                TNGS_Carm..CliNotas.deleted,
                TNGS_Carm..CliNotas.usuario,
                TNGS_Carm..CliNotas.version
           from TNGS_Carm..CliNotas
          where cln_nro_numcliente = @cln_nro_numcliente
            and deleted = 0
          order by cln_fyh_fechayhora
      end
   else
      begin
         Select cln_nro_numcliente,
                cln_fyh_fechayhora,
                cln_des_titulo,
                cln_xld_texto,
                cln_cd1_tipo,
                dbo.CLINOTAS_ESTABORRADA(cln_nro_numcliente,cln_fyh_fechayhora) as cln_cd1_borrada,
                cln_nom_escritor,
                cln_nom_removedor,
                cln_fyh_fyhremovida,
                TNGS_Carm..CliNotas.instante,
                TNGS_Carm..CliNotas.deleted,
                TNGS_Carm..CliNotas.usuario,
                TNGS_Carm..CliNotas.version
           from TNGS_Carm..CliNotas
          where cln_nro_numcliente = @cln_nro_numcliente
          order by cln_fyh_fechayhora
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLINOTAS_FSEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@cln_nro_numcliente">Numero del Cliente</param>
--- <param name="@cln_fyh_fechayhora">Fecha y Hora</param>
--- <param name="@cln_des_titulo">Título</param>
--- <param name="@cln_xld_texto">Texto</param>
--- <param name="@cln_cd1_tipo">Tipo</param>
--- <param name="@cln_nom_escritor">Usuario Escritor</param>
--- <param name="@cln_nom_removedor">Usuario Removedor</param>
--- <param name="@cln_fyh_fyhremovida">Fecha y Hora Removida</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLINOTAS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.CLINOTAS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLINOTAS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLINOTAS_INSERT
(
@cln_nro_numcliente tngs_numero,
@cln_fyh_fechayhora tngs_fecyhor,
@cln_des_titulo tngs_descripcion,
@cln_xld_texto tngs_descripcion_xl,
@cln_cd1_tipo tngs_codigo_1,
@cln_nom_escritor tngs_nombre,
@cln_nom_removedor tngs_nombre,
@cln_fyh_fyhremovida tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Carm..CliNotas
   values (
           @cln_nro_numcliente,
           @cln_fyh_fechayhora,
           @cln_des_titulo,
           @cln_xld_texto,
           @cln_cd1_tipo,
           @cln_nom_escritor,
           @cln_nom_removedor,
           @cln_fyh_fyhremovida,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLINOTAS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@cln_nro_numcliente">Numero del Cliente</param>
--- <param name="@cln_fyh_fechayhora">Fecha y Hora</param>
--- <param name="@cln_des_titulo">Título</param>
--- <param name="@cln_xld_texto">Texto</param>
--- <param name="@cln_cd1_tipo">Tipo</param>
--- <param name="@cln_nom_escritor">Usuario Escritor</param>
--- <param name="@cln_nom_removedor">Usuario Removedor</param>
--- <param name="@cln_fyh_fyhremovida">Fecha y Hora Removida</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLINOTAS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.CLINOTAS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLINOTAS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLINOTAS_UPDATE
(
@cln_nro_numcliente tngs_numero,
@cln_fyh_fechayhora tngs_fecyhor,
@cln_des_titulo tngs_descripcion,
@cln_xld_texto tngs_descripcion_xl,
@cln_cd1_tipo tngs_codigo_1,
@cln_nom_escritor tngs_nombre,
@cln_nom_removedor tngs_nombre,
@cln_fyh_fyhremovida tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..CliNotas
      set cln_des_titulo= @cln_des_titulo,
          cln_xld_texto= @cln_xld_texto,
          cln_cd1_tipo= @cln_cd1_tipo,
          cln_nom_escritor= @cln_nom_escritor,
          cln_nom_removedor= @cln_nom_removedor,
          cln_fyh_fyhremovida= @cln_fyh_fyhremovida,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where cln_nro_numcliente = @cln_nro_numcliente
      and cln_fyh_fechayhora = @cln_fyh_fechayhora

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLINOTAS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@cln_nro_numcliente">Numero del Cliente</param>
--- <param name="@cln_fyh_fechayhora">Fecha y Hora</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLINOTAS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.CLINOTAS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLINOTAS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLINOTAS_DELETE
(
@cln_nro_numcliente tngs_numero,
@cln_fyh_fechayhora tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..CliNotas
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where cln_nro_numcliente = @cln_nro_numcliente
      and cln_fyh_fechayhora = @cln_fyh_fechayhora

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLINOTAS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro por clave foranea
--- </summary>
--- <param name="@cln_nro_numcliente">Numero del Cliente</param>
--- <param name="@instante">Instante del delete</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLINOTAS_FDELETE'

if exists (select * from sysobjects where id = object_id('dbo.CLINOTAS_FDELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLINOTAS_FDELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLINOTAS_FDELETE
(
@cln_nro_numcliente tngs_numero,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         select @instante= getdate()
      end

   Update TNGS_Carm..CliNotas
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= @instante,
          usuario = @usuario
    where cln_nro_numcliente = @cln_nro_numcliente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLINOTAS_FDELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@cln_nro_numcliente">Numero del Cliente</param>
--- <param name="@cln_fyh_fechayhora">Fecha y Hora</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLINOTAS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.CLINOTAS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLINOTAS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLINOTAS_RECALL
(
@cln_nro_numcliente tngs_numero,
@cln_fyh_fechayhora tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..CliNotas
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where cln_nro_numcliente = @cln_nro_numcliente
      and cln_fyh_fechayhora = @cln_fyh_fechayhora

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLINOTAS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera lógicamente los registros de una clave foranea
--- </summary>
--- <param name="@cln_nro_numcliente">Numero del Cliente</param>
--- <param name="@instante">Instante de referencia</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLINOTAS_FRECALL'

if exists (select * from sysobjects where id = object_id('dbo.CLINOTAS_FRECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLINOTAS_FRECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLINOTAS_FRECALL
(
@cln_nro_numcliente tngs_numero,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         Update TNGS_Carm..CliNotas
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where cln_nro_numcliente = @cln_nro_numcliente
      end
   else
      begin
         Update TNGS_Carm..CliNotas
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where cln_nro_numcliente = @cln_nro_numcliente
            and instante= @instante
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLINOTAS_FRECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@cln_nro_numcliente">Numero del Cliente</param>
--- <param name="@cln_fyh_fechayhora">Fecha y Hora</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLINOTAS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.CLINOTAS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLINOTAS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLINOTAS_DROP
(
@cln_nro_numcliente tngs_numero,
@cln_fyh_fechayhora tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..CliNotas
    where cln_nro_numcliente = @cln_nro_numcliente
      and cln_fyh_fechayhora = @cln_fyh_fechayhora

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLINOTAS_DROP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro por clave foránea
--- </summary>
--- <param name="@cln_nro_numcliente">Numero del Cliente</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLINOTAS_FDROP'

if exists (select * from sysobjects where id = object_id('dbo.CLINOTAS_FDROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLINOTAS_FDROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLINOTAS_FDROP
(
@cln_nro_numcliente tngs_numero,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..CliNotas
    where cln_nro_numcliente = @cln_nro_numcliente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLINOTAS_FDROP to tngsmodulos

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

print 'Store Procedure: dbo.CLINOTAS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.CLINOTAS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLINOTAS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLINOTAS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Carm..CliNotas
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLINOTAS_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente los registro borrados lógicamente por clave foránea
--- </summary>
--- <param name="@cln_nro_numcliente">Numero del Cliente</param>
--- <param name="@usuario">Usuario que realiza el pack</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLINOTAS_FPACK'

if exists (select * from sysobjects where id = object_id('dbo.CLINOTAS_FPACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLINOTAS_FPACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLINOTAS_FPACK
(
@cln_nro_numcliente tngs_numero,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..CliNotas
    where cln_nro_numcliente = @cln_nro_numcliente
      and deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLINOTAS_FPACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: BorraPorCliente
--- </summary>
--- <param name="@nrocliente">Numero del cliente a borrar las notas</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLINOTAS_BORRAPORCLIENTE'

if exists (select * from sysobjects where id = object_id('dbo.CLINOTAS_BORRAPORCLIENTE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLINOTAS_BORRAPORCLIENTE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLINOTAS_BORRAPORCLIENTE
(
@nrocliente tngs_numero,
@usuario tngs_nombre
)
as
begin

   delete from CliNotas 
   where cln_nro_numcliente = @nrocliente 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLINOTAS_BORRAPORCLIENTE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: CantidadNotas
--- </summary>
--- <param name="@nrocliente">Numero del Cliente</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLINOTAS_CANTIDADNOTAS'

if exists (select * from sysobjects where id = object_id('dbo.CLINOTAS_CANTIDADNOTAS'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLINOTAS_CANTIDADNOTAS
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLINOTAS_CANTIDADNOTAS
(
@nrocliente tngs_numero,
@usuario tngs_nombre
)
as
begin

   select count(*) from TNGS_Carm..CliNotas 
   	where cln_nro_numcliente=@nrocliente and 
   		  (dbo.CLINOTAS_ESTABORRADA(@nrocliente,cln_fyh_fechayhora)) = 'N' 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLINOTAS_CANTIDADNOTAS to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: Remover
--- </summary>
--- <param name="@removedor">Usuario Removedor</param>
--- <param name="@fyhremovida">Fecha y Hora Removida</param>
--- <param name="@nrocliente">Numero del cliente</param>
--- <param name="@fechayhora">Fecha y Hora de la nota</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLINOTAS_REMOVER'

if exists (select * from sysobjects where id = object_id('dbo.CLINOTAS_REMOVER'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLINOTAS_REMOVER
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLINOTAS_REMOVER
(
@removedor tngs_nombre,
@fyhremovida tngs_fecyhor,
@nrocliente tngs_numero,
@fechayhora tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   update TNGS_Carm..CliNotas 
   	set cln_nom_removedor = @removedor, 
   		cln_fyh_fyhremovida = @fyhremovida 
   	where cln_nro_numcliente = @nrocliente 
   		  and cln_fyh_fechayhora = @fechayhora 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLINOTAS_REMOVER to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: CliNotas
//--------------------------------------------------------------------------*/
