/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 25/07/2020 18:14
// Sistema     : Carm
// Tabla       : ResEntrevista
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

print 'Store Procedure: dbo.RESENTREVISTA_UP'

if exists (select * from sysobjects where id = object_id('dbo.RESENTREVISTA_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.RESENTREVISTA_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.RESENTREVISTA_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select ren_rcd_cod,
                ren_des_des,
                ren_cd1_codfiltro,
                TNGS_Carm..ResEntrevista.instante,
                TNGS_Carm..ResEntrevista.deleted,
                TNGS_Carm..ResEntrevista.usuario,
                TNGS_Carm..ResEntrevista.version
           from TNGS_Carm..ResEntrevista
          where deleted = 0
          order by ren_rcd_cod
      end
   else
      begin
         Select ren_rcd_cod,
                ren_des_des,
                ren_cd1_codfiltro,
                TNGS_Carm..ResEntrevista.instante,
                TNGS_Carm..ResEntrevista.deleted,
                TNGS_Carm..ResEntrevista.usuario,
                TNGS_Carm..ResEntrevista.version
           from TNGS_Carm..ResEntrevista
          order by ren_rcd_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.RESENTREVISTA_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@ren_rcd_cod">Código</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.RESENTREVISTA_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.RESENTREVISTA_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.RESENTREVISTA_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.RESENTREVISTA_CHKVERSION
(
@ren_rcd_cod tngs_codigo_r,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Carm..ResEntrevista
    where ren_rcd_cod = @ren_rcd_cod
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.RESENTREVISTA_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@ren_rcd_cod">Código</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.RESENTREVISTA_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.RESENTREVISTA_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.RESENTREVISTA_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.RESENTREVISTA_SEARCH
(
@ren_rcd_cod tngs_codigo_r,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select ren_rcd_cod,
                ren_des_des,
                ren_cd1_codfiltro,
                TNGS_Carm..ResEntrevista.instante,
                TNGS_Carm..ResEntrevista.deleted,
                TNGS_Carm..ResEntrevista.usuario,
                TNGS_Carm..ResEntrevista.version
           from TNGS_Carm..ResEntrevista
          where ren_rcd_cod = @ren_rcd_cod
            and deleted = 0
      end
   else
      begin
         Select ren_rcd_cod,
                ren_des_des,
                ren_cd1_codfiltro,
                TNGS_Carm..ResEntrevista.instante,
                TNGS_Carm..ResEntrevista.deleted,
                TNGS_Carm..ResEntrevista.usuario,
                TNGS_Carm..ResEntrevista.version
           from TNGS_Carm..ResEntrevista
          where ren_rcd_cod = @ren_rcd_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.RESENTREVISTA_SEARCH to tngsmodulos

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

print 'Store Procedure: dbo.RESENTREVISTA_GETMAXKEY'

if exists (select * from sysobjects where id = object_id('dbo.RESENTREVISTA_GETMAXKEY'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.RESENTREVISTA_GETMAXKEY
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.RESENTREVISTA_GETMAXKEY
(
@dummy tngs_codigo_1
)
as
begin

   Select isnull(max(ren_rcd_cod), '0') as ren_rcd_cod
     from TNGS_Carm..ResEntrevista

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.RESENTREVISTA_GETMAXKEY to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@ren_rcd_cod">Código</param>
--- <param name="@ren_des_des">Descripción</param>
--- <param name="@ren_cd1_codfiltro">Genera Contrato</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.RESENTREVISTA_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.RESENTREVISTA_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.RESENTREVISTA_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.RESENTREVISTA_INSERT
(
@ren_rcd_cod tngs_codigo_r,
@ren_des_des tngs_descripcion,
@ren_cd1_codfiltro tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Carm..ResEntrevista
   values (
           @ren_rcd_cod,
           @ren_des_des,
           @ren_cd1_codfiltro,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.RESENTREVISTA_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@ren_rcd_cod">Código</param>
--- <param name="@ren_des_des">Descripción</param>
--- <param name="@ren_cd1_codfiltro">Genera Contrato</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.RESENTREVISTA_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.RESENTREVISTA_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.RESENTREVISTA_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.RESENTREVISTA_UPDATE
(
@ren_rcd_cod tngs_codigo_r,
@ren_des_des tngs_descripcion,
@ren_cd1_codfiltro tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..ResEntrevista
      set ren_des_des= @ren_des_des,
          ren_cd1_codfiltro= @ren_cd1_codfiltro,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where ren_rcd_cod = @ren_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.RESENTREVISTA_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@ren_rcd_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.RESENTREVISTA_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.RESENTREVISTA_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.RESENTREVISTA_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.RESENTREVISTA_DELETE
(
@ren_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..ResEntrevista
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where ren_rcd_cod = @ren_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.RESENTREVISTA_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@ren_rcd_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.RESENTREVISTA_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.RESENTREVISTA_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.RESENTREVISTA_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.RESENTREVISTA_RECALL
(
@ren_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..ResEntrevista
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where ren_rcd_cod = @ren_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.RESENTREVISTA_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@ren_rcd_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.RESENTREVISTA_DROP'

if exists (select * from sysobjects where id = object_id('dbo.RESENTREVISTA_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.RESENTREVISTA_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.RESENTREVISTA_DROP
(
@ren_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..ResEntrevista
    where ren_rcd_cod = @ren_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.RESENTREVISTA_DROP to tngsmodulos

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

print 'Store Procedure: dbo.RESENTREVISTA_PACK'

if exists (select * from sysobjects where id = object_id('dbo.RESENTREVISTA_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.RESENTREVISTA_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.RESENTREVISTA_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Carm..ResEntrevista
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.RESENTREVISTA_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: ResEntrevista
//--------------------------------------------------------------------------*/
