/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 18/12/2020 03:40
// Sistema     : Carm
// Tabla       : MotivosLlamada
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

print 'Store Procedure: dbo.MOTIVOSLLAMADA_UP'

if exists (select * from sysobjects where id = object_id('dbo.MOTIVOSLLAMADA_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOTIVOSLLAMADA_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOTIVOSLLAMADA_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mot_cod_cod,
                mot_des_des,
                ctl_des_des as mot_des_categ,
                mot_rcd_codcategoria,
                mot_cd1_esreclamo,
                TNGS_Carm..MotivosLlamada.instante,
                TNGS_Carm..MotivosLlamada.deleted,
                TNGS_Carm..MotivosLlamada.usuario,
                TNGS_Carm..MotivosLlamada.version
           from TNGS_Carm..MotivosLlamada
                join TNGS_Carm..CategoriasLlamada
                  on mot_rcd_codcategoria = ctl_rcd_cod
          where TNGS_Carm..MotivosLlamada.deleted = 0
          order by mot_cod_cod
      end
   else
      begin
         Select mot_cod_cod,
                mot_des_des,
                ctl_des_des as mot_des_categ,
                mot_rcd_codcategoria,
                mot_cd1_esreclamo,
                TNGS_Carm..MotivosLlamada.instante,
                TNGS_Carm..MotivosLlamada.deleted,
                TNGS_Carm..MotivosLlamada.usuario,
                TNGS_Carm..MotivosLlamada.version
           from TNGS_Carm..MotivosLlamada
                join TNGS_Carm..CategoriasLlamada
                  on mot_rcd_codcategoria = ctl_rcd_cod
          order by mot_cod_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOTIVOSLLAMADA_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@mot_cod_cod">Código</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MOTIVOSLLAMADA_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.MOTIVOSLLAMADA_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOTIVOSLLAMADA_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOTIVOSLLAMADA_CHKVERSION
(
@mot_cod_cod tngs_codigo,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Carm..MotivosLlamada
    where mot_cod_cod = @mot_cod_cod
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOTIVOSLLAMADA_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@mot_cod_cod">Código</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MOTIVOSLLAMADA_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.MOTIVOSLLAMADA_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOTIVOSLLAMADA_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOTIVOSLLAMADA_SEARCH
(
@mot_cod_cod tngs_codigo,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mot_cod_cod,
                mot_des_des,
                ctl_des_des as mot_des_categ,
                mot_rcd_codcategoria,
                mot_cd1_esreclamo,
                TNGS_Carm..MotivosLlamada.instante,
                TNGS_Carm..MotivosLlamada.deleted,
                TNGS_Carm..MotivosLlamada.usuario,
                TNGS_Carm..MotivosLlamada.version
           from TNGS_Carm..MotivosLlamada
                join TNGS_Carm..CategoriasLlamada
                  on mot_rcd_codcategoria = ctl_rcd_cod
          where mot_cod_cod = @mot_cod_cod
            and TNGS_Carm..MotivosLlamada.deleted = 0
      end
   else
      begin
         Select mot_cod_cod,
                mot_des_des,
                ctl_des_des as mot_des_categ,
                mot_rcd_codcategoria,
                mot_cd1_esreclamo,
                TNGS_Carm..MotivosLlamada.instante,
                TNGS_Carm..MotivosLlamada.deleted,
                TNGS_Carm..MotivosLlamada.usuario,
                TNGS_Carm..MotivosLlamada.version
           from TNGS_Carm..MotivosLlamada
                join TNGS_Carm..CategoriasLlamada
                  on mot_rcd_codcategoria = ctl_rcd_cod
          where mot_cod_cod = @mot_cod_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOTIVOSLLAMADA_SEARCH to tngsmodulos

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

print 'Store Procedure: dbo.MOTIVOSLLAMADA_GETMAXKEY'

if exists (select * from sysobjects where id = object_id('dbo.MOTIVOSLLAMADA_GETMAXKEY'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOTIVOSLLAMADA_GETMAXKEY
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOTIVOSLLAMADA_GETMAXKEY
(
@dummy tngs_codigo_1
)
as
begin

   Select isnull(max(mot_cod_cod), '0') as mot_cod_cod
     from TNGS_Carm..MotivosLlamada

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOTIVOSLLAMADA_GETMAXKEY to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@mot_cod_cod">Código</param>
--- <param name="@mot_des_des">Motivo</param>
--- <param name="@mot_rcd_codcategoria">Categoria</param>
--- <param name="@mot_cd1_esreclamo">Reclamo</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MOTIVOSLLAMADA_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.MOTIVOSLLAMADA_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOTIVOSLLAMADA_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOTIVOSLLAMADA_INSERT
(
@mot_cod_cod tngs_codigo,
@mot_des_des tngs_descripcion,
@mot_rcd_codcategoria tngs_codigo_r,
@mot_cd1_esreclamo tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Carm..MotivosLlamada
   values (
           @mot_cod_cod,
           @mot_des_des,
           @mot_rcd_codcategoria,
           @mot_cd1_esreclamo,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOTIVOSLLAMADA_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@mot_cod_cod">Código</param>
--- <param name="@mot_des_des">Motivo</param>
--- <param name="@mot_rcd_codcategoria">Categoria</param>
--- <param name="@mot_cd1_esreclamo">Reclamo</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MOTIVOSLLAMADA_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.MOTIVOSLLAMADA_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOTIVOSLLAMADA_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOTIVOSLLAMADA_UPDATE
(
@mot_cod_cod tngs_codigo,
@mot_des_des tngs_descripcion,
@mot_rcd_codcategoria tngs_codigo_r,
@mot_cd1_esreclamo tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..MotivosLlamada
      set mot_des_des= @mot_des_des,
          mot_rcd_codcategoria= @mot_rcd_codcategoria,
          mot_cd1_esreclamo= @mot_cd1_esreclamo,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mot_cod_cod = @mot_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOTIVOSLLAMADA_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@mot_cod_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MOTIVOSLLAMADA_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.MOTIVOSLLAMADA_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOTIVOSLLAMADA_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOTIVOSLLAMADA_DELETE
(
@mot_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..MotivosLlamada
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mot_cod_cod = @mot_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOTIVOSLLAMADA_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@mot_cod_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MOTIVOSLLAMADA_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.MOTIVOSLLAMADA_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOTIVOSLLAMADA_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOTIVOSLLAMADA_RECALL
(
@mot_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..MotivosLlamada
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mot_cod_cod = @mot_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOTIVOSLLAMADA_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@mot_cod_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MOTIVOSLLAMADA_DROP'

if exists (select * from sysobjects where id = object_id('dbo.MOTIVOSLLAMADA_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOTIVOSLLAMADA_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOTIVOSLLAMADA_DROP
(
@mot_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..MotivosLlamada
    where mot_cod_cod = @mot_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOTIVOSLLAMADA_DROP to tngsmodulos

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

print 'Store Procedure: dbo.MOTIVOSLLAMADA_PACK'

if exists (select * from sysobjects where id = object_id('dbo.MOTIVOSLLAMADA_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOTIVOSLLAMADA_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOTIVOSLLAMADA_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Carm..MotivosLlamada
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOTIVOSLLAMADA_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: GetByCategoria
--- </summary>
--- <param name="@codcategoria">Codigo de categoria</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MOTIVOSLLAMADA_GETBYCATEGORIA'

if exists (select * from sysobjects where id = object_id('dbo.MOTIVOSLLAMADA_GETBYCATEGORIA'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOTIVOSLLAMADA_GETBYCATEGORIA
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOTIVOSLLAMADA_GETBYCATEGORIA
(
@codcategoria tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   select * from MotivosLlamada 
   where mot_rcd_codcategoria = @codcategoria 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOTIVOSLLAMADA_GETBYCATEGORIA to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: MotivosLlamada
//--------------------------------------------------------------------------*/
