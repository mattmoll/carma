/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 10/06/2021 21:20
// Sistema     : Carm
// Tabla       : ConversionColores
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

print 'Store Procedure: dbo.CONVERSIONCOLORES_UP'

if exists (select * from sysobjects where id = object_id('dbo.CONVERSIONCOLORES_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONVERSIONCOLORES_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONVERSIONCOLORES_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select con_cod_cod,
                con_des_coloraconvertir,
                con_cd1_colorconvertido,
                TNGS_Carm..ConversionColores.instante,
                TNGS_Carm..ConversionColores.deleted,
                TNGS_Carm..ConversionColores.usuario,
                TNGS_Carm..ConversionColores.version
           from TNGS_Carm..ConversionColores
          where deleted = 0
          order by con_cod_cod
      end
   else
      begin
         Select con_cod_cod,
                con_des_coloraconvertir,
                con_cd1_colorconvertido,
                TNGS_Carm..ConversionColores.instante,
                TNGS_Carm..ConversionColores.deleted,
                TNGS_Carm..ConversionColores.usuario,
                TNGS_Carm..ConversionColores.version
           from TNGS_Carm..ConversionColores
          order by con_cod_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONVERSIONCOLORES_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@con_cod_cod">Código</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONVERSIONCOLORES_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.CONVERSIONCOLORES_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONVERSIONCOLORES_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONVERSIONCOLORES_CHKVERSION
(
@con_cod_cod tngs_codigo,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Carm..ConversionColores
    where con_cod_cod = @con_cod_cod
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONVERSIONCOLORES_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@con_cod_cod">Código</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONVERSIONCOLORES_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.CONVERSIONCOLORES_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONVERSIONCOLORES_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONVERSIONCOLORES_SEARCH
(
@con_cod_cod tngs_codigo,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select con_cod_cod,
                con_des_coloraconvertir,
                con_cd1_colorconvertido,
                TNGS_Carm..ConversionColores.instante,
                TNGS_Carm..ConversionColores.deleted,
                TNGS_Carm..ConversionColores.usuario,
                TNGS_Carm..ConversionColores.version
           from TNGS_Carm..ConversionColores
          where con_cod_cod = @con_cod_cod
            and deleted = 0
      end
   else
      begin
         Select con_cod_cod,
                con_des_coloraconvertir,
                con_cd1_colorconvertido,
                TNGS_Carm..ConversionColores.instante,
                TNGS_Carm..ConversionColores.deleted,
                TNGS_Carm..ConversionColores.usuario,
                TNGS_Carm..ConversionColores.version
           from TNGS_Carm..ConversionColores
          where con_cod_cod = @con_cod_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONVERSIONCOLORES_SEARCH to tngsmodulos

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

print 'Store Procedure: dbo.CONVERSIONCOLORES_GETMAXKEY'

if exists (select * from sysobjects where id = object_id('dbo.CONVERSIONCOLORES_GETMAXKEY'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONVERSIONCOLORES_GETMAXKEY
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONVERSIONCOLORES_GETMAXKEY
(
@dummy tngs_codigo_1
)
as
begin

   Select isnull(max(con_cod_cod), '0') as con_cod_cod
     from TNGS_Carm..ConversionColores

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONVERSIONCOLORES_GETMAXKEY to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@con_cod_cod">Código</param>
--- <param name="@con_des_coloraconvertir">Color a Convertir</param>
--- <param name="@con_cd1_colorconvertido">Color Convertido</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONVERSIONCOLORES_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.CONVERSIONCOLORES_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONVERSIONCOLORES_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONVERSIONCOLORES_INSERT
(
@con_cod_cod tngs_codigo,
@con_des_coloraconvertir tngs_descripcion,
@con_cd1_colorconvertido tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Carm..ConversionColores
   values (
           @con_cod_cod,
           @con_des_coloraconvertir,
           @con_cd1_colorconvertido,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONVERSIONCOLORES_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@con_cod_cod">Código</param>
--- <param name="@con_des_coloraconvertir">Color a Convertir</param>
--- <param name="@con_cd1_colorconvertido">Color Convertido</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONVERSIONCOLORES_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.CONVERSIONCOLORES_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONVERSIONCOLORES_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONVERSIONCOLORES_UPDATE
(
@con_cod_cod tngs_codigo,
@con_des_coloraconvertir tngs_descripcion,
@con_cd1_colorconvertido tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..ConversionColores
      set con_des_coloraconvertir= @con_des_coloraconvertir,
          con_cd1_colorconvertido= @con_cd1_colorconvertido,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where con_cod_cod = @con_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONVERSIONCOLORES_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@con_cod_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONVERSIONCOLORES_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.CONVERSIONCOLORES_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONVERSIONCOLORES_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONVERSIONCOLORES_DELETE
(
@con_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..ConversionColores
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where con_cod_cod = @con_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONVERSIONCOLORES_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@con_cod_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONVERSIONCOLORES_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.CONVERSIONCOLORES_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONVERSIONCOLORES_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONVERSIONCOLORES_RECALL
(
@con_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..ConversionColores
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where con_cod_cod = @con_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONVERSIONCOLORES_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@con_cod_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONVERSIONCOLORES_DROP'

if exists (select * from sysobjects where id = object_id('dbo.CONVERSIONCOLORES_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONVERSIONCOLORES_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONVERSIONCOLORES_DROP
(
@con_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..ConversionColores
    where con_cod_cod = @con_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONVERSIONCOLORES_DROP to tngsmodulos

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

print 'Store Procedure: dbo.CONVERSIONCOLORES_PACK'

if exists (select * from sysobjects where id = object_id('dbo.CONVERSIONCOLORES_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONVERSIONCOLORES_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONVERSIONCOLORES_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Carm..ConversionColores
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONVERSIONCOLORES_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: getConvertido
--- </summary>
--- <param name="@coloraconvertir">Color a Convertir</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONVERSIONCOLORES_GETCONVERTIDO'

if exists (select * from sysobjects where id = object_id('dbo.CONVERSIONCOLORES_GETCONVERTIDO'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONVERSIONCOLORES_GETCONVERTIDO
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONVERSIONCOLORES_GETCONVERTIDO
(
@coloraconvertir tngs_descripcion,
@usuario tngs_nombre
)
as
begin

   select con_cd1_colorconvertido 
   	from ConversionColores 
   where con_des_coloraconvertir = @coloraconvertir 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONVERSIONCOLORES_GETCONVERTIDO to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: ConversionColores
//--------------------------------------------------------------------------*/
