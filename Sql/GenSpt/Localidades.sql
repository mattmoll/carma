/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 01/12/2020 21:33
// Sistema     : Carm
// Tabla       : Localidades
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

print 'Store Procedure: dbo.LOCALIDADES_UP'

if exists (select * from sysobjects where id = object_id('dbo.LOCALIDADES_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.LOCALIDADES_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.LOCALIDADES_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select loc_ecd_codpost,
                loc_ede_nombre,
                loc_rcd_codzona,
                zns_des_nombre as loc_des_zona,
                loc_ede_partido,
                loc_des_provincia,
                loc_ede_nomgoogle,
                loc_cd1_directa,
                TNGS_Carm..Localidades.instante,
                TNGS_Carm..Localidades.deleted,
                TNGS_Carm..Localidades.usuario,
                TNGS_Carm..Localidades.version
           from TNGS_Carm..Localidades
                join TNGS_Carm..Zonas
                  on loc_rcd_codzona = zns_rcd_cod
          where TNGS_Carm..Localidades.deleted = 0
          order by loc_ecd_codpost
      end
   else
      begin
         Select loc_ecd_codpost,
                loc_ede_nombre,
                loc_rcd_codzona,
                zns_des_nombre as loc_des_zona,
                loc_ede_partido,
                loc_des_provincia,
                loc_ede_nomgoogle,
                loc_cd1_directa,
                TNGS_Carm..Localidades.instante,
                TNGS_Carm..Localidades.deleted,
                TNGS_Carm..Localidades.usuario,
                TNGS_Carm..Localidades.version
           from TNGS_Carm..Localidades
                join TNGS_Carm..Zonas
                  on loc_rcd_codzona = zns_rcd_cod
          order by loc_ecd_codpost
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.LOCALIDADES_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@loc_ecd_codpost">Código postal</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.LOCALIDADES_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.LOCALIDADES_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.LOCALIDADES_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.LOCALIDADES_CHKVERSION
(
@loc_ecd_codpost tngs_codigo_e,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Carm..Localidades
    where loc_ecd_codpost = @loc_ecd_codpost
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.LOCALIDADES_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@loc_ecd_codpost">Código postal</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.LOCALIDADES_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.LOCALIDADES_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.LOCALIDADES_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.LOCALIDADES_SEARCH
(
@loc_ecd_codpost tngs_codigo_e,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select loc_ecd_codpost,
                loc_ede_nombre,
                loc_rcd_codzona,
                zns_des_nombre as loc_des_zona,
                loc_ede_partido,
                loc_des_provincia,
                loc_ede_nomgoogle,
                loc_cd1_directa,
                TNGS_Carm..Localidades.instante,
                TNGS_Carm..Localidades.deleted,
                TNGS_Carm..Localidades.usuario,
                TNGS_Carm..Localidades.version
           from TNGS_Carm..Localidades
                join TNGS_Carm..Zonas
                  on loc_rcd_codzona = zns_rcd_cod
          where loc_ecd_codpost = @loc_ecd_codpost
            and TNGS_Carm..Localidades.deleted = 0
      end
   else
      begin
         Select loc_ecd_codpost,
                loc_ede_nombre,
                loc_rcd_codzona,
                zns_des_nombre as loc_des_zona,
                loc_ede_partido,
                loc_des_provincia,
                loc_ede_nomgoogle,
                loc_cd1_directa,
                TNGS_Carm..Localidades.instante,
                TNGS_Carm..Localidades.deleted,
                TNGS_Carm..Localidades.usuario,
                TNGS_Carm..Localidades.version
           from TNGS_Carm..Localidades
                join TNGS_Carm..Zonas
                  on loc_rcd_codzona = zns_rcd_cod
          where loc_ecd_codpost = @loc_ecd_codpost
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.LOCALIDADES_SEARCH to tngsmodulos

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

print 'Store Procedure: dbo.LOCALIDADES_GETMAXKEY'

if exists (select * from sysobjects where id = object_id('dbo.LOCALIDADES_GETMAXKEY'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.LOCALIDADES_GETMAXKEY
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.LOCALIDADES_GETMAXKEY
(
@dummy tngs_codigo_1
)
as
begin

   Select isnull(max(loc_ecd_codpost), '0') as loc_ecd_codpost
     from TNGS_Carm..Localidades

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.LOCALIDADES_GETMAXKEY to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@loc_ecd_codpost">Código postal</param>
--- <param name="@loc_ede_nombre">Nombre</param>
--- <param name="@loc_rcd_codzona">Zona</param>
--- <param name="@loc_ede_partido">Partido</param>
--- <param name="@loc_des_provincia">Provincia</param>
--- <param name="@loc_ede_nomgoogle">Nombre en google</param>
--- <param name="@loc_cd1_directa">Busqueda Directa</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.LOCALIDADES_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.LOCALIDADES_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.LOCALIDADES_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.LOCALIDADES_INSERT
(
@loc_ecd_codpost tngs_codigo_e,
@loc_ede_nombre tngs_descripcion_e,
@loc_rcd_codzona tngs_codigo_r,
@loc_ede_partido tngs_descripcion_e,
@loc_des_provincia tngs_descripcion,
@loc_ede_nomgoogle tngs_descripcion_e,
@loc_cd1_directa tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Carm..Localidades
   values (
           @loc_ecd_codpost,
           @loc_ede_nombre,
           @loc_rcd_codzona,
           @loc_ede_partido,
           @loc_des_provincia,
           @loc_ede_nomgoogle,
           @loc_cd1_directa,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.LOCALIDADES_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@loc_ecd_codpost">Código postal</param>
--- <param name="@loc_ede_nombre">Nombre</param>
--- <param name="@loc_rcd_codzona">Zona</param>
--- <param name="@loc_ede_partido">Partido</param>
--- <param name="@loc_des_provincia">Provincia</param>
--- <param name="@loc_ede_nomgoogle">Nombre en google</param>
--- <param name="@loc_cd1_directa">Busqueda Directa</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.LOCALIDADES_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.LOCALIDADES_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.LOCALIDADES_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.LOCALIDADES_UPDATE
(
@loc_ecd_codpost tngs_codigo_e,
@loc_ede_nombre tngs_descripcion_e,
@loc_rcd_codzona tngs_codigo_r,
@loc_ede_partido tngs_descripcion_e,
@loc_des_provincia tngs_descripcion,
@loc_ede_nomgoogle tngs_descripcion_e,
@loc_cd1_directa tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Localidades
      set loc_ede_nombre= @loc_ede_nombre,
          loc_rcd_codzona= @loc_rcd_codzona,
          loc_ede_partido= @loc_ede_partido,
          loc_des_provincia= @loc_des_provincia,
          loc_ede_nomgoogle= @loc_ede_nomgoogle,
          loc_cd1_directa= @loc_cd1_directa,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where loc_ecd_codpost = @loc_ecd_codpost

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.LOCALIDADES_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@loc_ecd_codpost">Código postal</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.LOCALIDADES_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.LOCALIDADES_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.LOCALIDADES_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.LOCALIDADES_DELETE
(
@loc_ecd_codpost tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Localidades
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where loc_ecd_codpost = @loc_ecd_codpost

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.LOCALIDADES_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@loc_ecd_codpost">Código postal</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.LOCALIDADES_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.LOCALIDADES_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.LOCALIDADES_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.LOCALIDADES_RECALL
(
@loc_ecd_codpost tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Localidades
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where loc_ecd_codpost = @loc_ecd_codpost

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.LOCALIDADES_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@loc_ecd_codpost">Código postal</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.LOCALIDADES_DROP'

if exists (select * from sysobjects where id = object_id('dbo.LOCALIDADES_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.LOCALIDADES_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.LOCALIDADES_DROP
(
@loc_ecd_codpost tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..Localidades
    where loc_ecd_codpost = @loc_ecd_codpost

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.LOCALIDADES_DROP to tngsmodulos

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

print 'Store Procedure: dbo.LOCALIDADES_PACK'

if exists (select * from sysobjects where id = object_id('dbo.LOCALIDADES_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.LOCALIDADES_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.LOCALIDADES_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Carm..Localidades
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.LOCALIDADES_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: Find
--- </summary>
--- <param name="@localidad">Nombre de la localidad</param>
--- <param name="@provinciad">Provincia desde</param>
--- <param name="@provinciah">Provincia hasta</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.LOCALIDADES_FIND'

if exists (select * from sysobjects where id = object_id('dbo.LOCALIDADES_FIND'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.LOCALIDADES_FIND
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.LOCALIDADES_FIND
(
@localidad tngs_descripcion_e,
@provinciad tngs_descripcion,
@provinciah tngs_descripcion,
@usuario tngs_nombre
)
as
begin

    
   Select loc_ecd_codpost,
          loc_ede_nombre,
          loc_rcd_codzona,
          zns_des_nombre as loc_des_zona,
          loc_ede_partido,
          loc_des_provincia,
          loc_ede_nomgoogle,
          loc_cd1_directa,
          TNGS_Carm..Localidades.instante,
          TNGS_Carm..Localidades.deleted,
          TNGS_Carm..Localidades.usuario,
          TNGS_Carm..Localidades.version
     from TNGS_Carm..Localidades 
          join TNGS_Carm..Zonas
            on loc_rcd_codzona = zns_rcd_cod
    where loc_des_provincia >= @provinciad 
      and loc_des_provincia <= @provinciah 
      and loc_ede_nombre like '%' + ltrim(rtrim(@localidad)) + '%' 
      and zonas.deleted = 0 
      and localidades.deleted = 0 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.LOCALIDADES_FIND to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: GetCodPostal
--- </summary>
--- <param name="@localidad">Nombre de la Localidad a Buscar</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.LOCALIDADES_GETCODPOSTAL'

if exists (select * from sysobjects where id = object_id('dbo.LOCALIDADES_GETCODPOSTAL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.LOCALIDADES_GETCODPOSTAL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.LOCALIDADES_GETCODPOSTAL
(
@localidad tngs_descripcion_e,
@usuario tngs_nombre
)
as
begin

   select 
   		loc_ecd_codpost 
   	from 
   		TNGS_Carm..Localidades 
   	where 
   		loc_ede_nombre = @localidad and loc_cd1_directa = 'S' 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.LOCALIDADES_GETCODPOSTAL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: GetDirectaWithLike
--- </summary>
--- <param name="@locabuscar">Letras de Loc a Buscar</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.LOCALIDADES_GETDIRECTAWITHLIKE'

if exists (select * from sysobjects where id = object_id('dbo.LOCALIDADES_GETDIRECTAWITHLIKE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.LOCALIDADES_GETDIRECTAWITHLIKE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.LOCALIDADES_GETDIRECTAWITHLIKE
(
@locabuscar tngs_codigo_30,
@usuario tngs_nombre
)
as
begin

   Select loc_ecd_codpost,
          loc_ede_nombre,
          loc_rcd_codzona,
          zns_des_nombre as loc_des_zona,
          loc_ede_partido,
          loc_des_provincia,
          loc_ede_nomgoogle,
          loc_cd1_directa,
          TNGS_Carm..Localidades.instante,
          TNGS_Carm..Localidades.deleted,
          TNGS_Carm..Localidades.usuario,
          TNGS_Carm..Localidades.version
     from TNGS_Carm..Localidades 
          join TNGS_Carm..Zonas
            on loc_rcd_codzona = zns_rcd_cod
       where loc_cd1_directa = 'S' and loc_ede_nombre like '%' + rtrim(@locabuscar)+'%' 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.LOCALIDADES_GETDIRECTAWITHLIKE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: GetLocalidadesZona
--- </summary>
--- <param name="@codzona">Código de zona</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.LOCALIDADES_GETLOCALIDADESZONA'

if exists (select * from sysobjects where id = object_id('dbo.LOCALIDADES_GETLOCALIDADESZONA'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.LOCALIDADES_GETLOCALIDADESZONA
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.LOCALIDADES_GETLOCALIDADESZONA
(
@codzona tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

    
   select 
         loc_ecd_codpost, 
         loc_ede_nombre 
   from 
         TNGS_Carm..Localidades 
   where 
         loc_rcd_codzona = @codzona 
    

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.LOCALIDADES_GETLOCALIDADESZONA to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: GetPartidos
--- </summary>
--- <param name="@provincia">Nombre de la provincia</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.LOCALIDADES_GETPARTIDOS'

if exists (select * from sysobjects where id = object_id('dbo.LOCALIDADES_GETPARTIDOS'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.LOCALIDADES_GETPARTIDOS
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.LOCALIDADES_GETPARTIDOS
(
@provincia tngs_descripcion,
@usuario tngs_nombre
)
as
begin

   Select distinct loc_ede_partido, 
    
          deleted 
    
     from TNGS_Carm..Localidades 
    
   where loc_des_provincia = @provincia 
    
      and deleted = 0 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.LOCALIDADES_GETPARTIDOS to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: GetProvincias
--- </summary>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.LOCALIDADES_GETPROVINCIAS'

if exists (select * from sysobjects where id = object_id('dbo.LOCALIDADES_GETPROVINCIAS'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.LOCALIDADES_GETPROVINCIAS
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.LOCALIDADES_GETPROVINCIAS
(
@usuario tngs_nombre
)
as
begin

   Select distinct loc_des_provincia, 
    
          deleted 
    
     from TNGS_Carm..Localidades 
    
   where deleted = 0 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.LOCALIDADES_GETPROVINCIAS to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: UpFullByPartido
--- </summary>
--- <param name="@provincia">Provincia a buscar</param>
--- <param name="@partido">Partido a buscar</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.LOCALIDADES_UPFULLBYPARTIDO'

if exists (select * from sysobjects where id = object_id('dbo.LOCALIDADES_UPFULLBYPARTIDO'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.LOCALIDADES_UPFULLBYPARTIDO
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.LOCALIDADES_UPFULLBYPARTIDO
(
@provincia tngs_descripcion,
@partido tngs_descripcion_e,
@usuario tngs_nombre
)
as
begin

   Select loc_ecd_codpost,
          loc_ede_nombre,
          loc_rcd_codzona,
          zns_des_nombre as loc_des_zona,
          loc_ede_partido,
          loc_des_provincia,
          loc_ede_nomgoogle,
          loc_cd1_directa,
          TNGS_Carm..Localidades.instante,
          TNGS_Carm..Localidades.deleted,
          TNGS_Carm..Localidades.usuario,
          TNGS_Carm..Localidades.version
     from TNGS_Carm..Localidades 
          join TNGS_Carm..Zonas
            on loc_rcd_codzona = zns_rcd_cod
    where loc_des_provincia = @provincia 
      and loc_ede_partido = @partido 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.LOCALIDADES_UPFULLBYPARTIDO to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Localidades
//--------------------------------------------------------------------------*/
