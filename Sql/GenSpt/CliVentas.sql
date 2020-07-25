/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 25/07/2020 18:14
// Sistema     : Carm
// Tabla       : CliVentas
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

print 'Store Procedure: dbo.CLIVENTAS_UP'

if exists (select * from sysobjects where id = object_id('dbo.CLIVENTAS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIVENTAS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIVENTAS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select clv_nro_numcliente,
                clv_fyh_fecha,
                dbo.VENDEDORES_GETFULLNAME(clv_cd6_codvendedor) as vnd_des_desvend,
                clv_cd6_codvendedor,
                tcn_des_des as clv_des_destcon,
                clv_rcd_codtipocontrato,
                clv_imp_abono,
                clv_nro_cantcapitas,
                clv_imp_valorcapita,
                clv_rcd_codmarca,
                TNGS_Carm..CliVentas.instante,
                TNGS_Carm..CliVentas.deleted,
                TNGS_Carm..CliVentas.usuario,
                TNGS_Carm..CliVentas.version
           from TNGS_Carm..CliVentas
                join TNGS_Carm..TipoCont
                  on clv_rcd_codtipocontrato = tcn_rcd_cod
                join TNGS_Carm..Vendedores
                  on clv_cd6_codvendedor = vnd_cd6_cod
          where TNGS_Carm..CliVentas.deleted = 0
          order by clv_nro_numcliente,
                clv_fyh_fecha
      end
   else
      begin
         Select clv_nro_numcliente,
                clv_fyh_fecha,
                dbo.VENDEDORES_GETFULLNAME(clv_cd6_codvendedor) as vnd_des_desvend,
                clv_cd6_codvendedor,
                tcn_des_des as clv_des_destcon,
                clv_rcd_codtipocontrato,
                clv_imp_abono,
                clv_nro_cantcapitas,
                clv_imp_valorcapita,
                clv_rcd_codmarca,
                TNGS_Carm..CliVentas.instante,
                TNGS_Carm..CliVentas.deleted,
                TNGS_Carm..CliVentas.usuario,
                TNGS_Carm..CliVentas.version
           from TNGS_Carm..CliVentas
                join TNGS_Carm..TipoCont
                  on clv_rcd_codtipocontrato = tcn_rcd_cod
                join TNGS_Carm..Vendedores
                  on clv_cd6_codvendedor = vnd_cd6_cod
          order by clv_nro_numcliente,
                clv_fyh_fecha
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIVENTAS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@clv_nro_numcliente">Numero Cliente</param>
--- <param name="@clv_fyh_fecha">Fecha Venta</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIVENTAS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.CLIVENTAS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIVENTAS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIVENTAS_CHKVERSION
(
@clv_nro_numcliente tngs_numero,
@clv_fyh_fecha tngs_fecyhor,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Carm..CliVentas
    where clv_nro_numcliente = @clv_nro_numcliente
      and clv_fyh_fecha = @clv_fyh_fecha
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIVENTAS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@clv_nro_numcliente">Numero Cliente</param>
--- <param name="@clv_fyh_fecha">Fecha Venta</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIVENTAS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.CLIVENTAS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIVENTAS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIVENTAS_SEARCH
(
@clv_nro_numcliente tngs_numero,
@clv_fyh_fecha tngs_fecyhor,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select clv_nro_numcliente,
                clv_fyh_fecha,
                dbo.VENDEDORES_GETFULLNAME(clv_cd6_codvendedor) as vnd_des_desvend,
                clv_cd6_codvendedor,
                tcn_des_des as clv_des_destcon,
                clv_rcd_codtipocontrato,
                clv_imp_abono,
                clv_nro_cantcapitas,
                clv_imp_valorcapita,
                clv_rcd_codmarca,
                TNGS_Carm..CliVentas.instante,
                TNGS_Carm..CliVentas.deleted,
                TNGS_Carm..CliVentas.usuario,
                TNGS_Carm..CliVentas.version
           from TNGS_Carm..CliVentas
                join TNGS_Carm..TipoCont
                  on clv_rcd_codtipocontrato = tcn_rcd_cod
                join TNGS_Carm..Vendedores
                  on clv_cd6_codvendedor = vnd_cd6_cod
          where clv_nro_numcliente = @clv_nro_numcliente
            and clv_fyh_fecha = @clv_fyh_fecha
            and TNGS_Carm..CliVentas.deleted = 0
      end
   else
      begin
         Select clv_nro_numcliente,
                clv_fyh_fecha,
                dbo.VENDEDORES_GETFULLNAME(clv_cd6_codvendedor) as vnd_des_desvend,
                clv_cd6_codvendedor,
                tcn_des_des as clv_des_destcon,
                clv_rcd_codtipocontrato,
                clv_imp_abono,
                clv_nro_cantcapitas,
                clv_imp_valorcapita,
                clv_rcd_codmarca,
                TNGS_Carm..CliVentas.instante,
                TNGS_Carm..CliVentas.deleted,
                TNGS_Carm..CliVentas.usuario,
                TNGS_Carm..CliVentas.version
           from TNGS_Carm..CliVentas
                join TNGS_Carm..TipoCont
                  on clv_rcd_codtipocontrato = tcn_rcd_cod
                join TNGS_Carm..Vendedores
                  on clv_cd6_codvendedor = vnd_cd6_cod
          where clv_nro_numcliente = @clv_nro_numcliente
            and clv_fyh_fecha = @clv_fyh_fecha
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIVENTAS_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca los registros de una clave foranea
--- </summary>
--- <param name="@clv_nro_numcliente">Numero Cliente</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIVENTAS_FSEARCH'

if exists (select * from sysobjects where id = object_id('dbo.CLIVENTAS_FSEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIVENTAS_FSEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIVENTAS_FSEARCH
(
@clv_nro_numcliente tngs_numero,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select clv_nro_numcliente,
                clv_fyh_fecha,
                dbo.VENDEDORES_GETFULLNAME(clv_cd6_codvendedor) as vnd_des_desvend,
                clv_cd6_codvendedor,
                tcn_des_des as clv_des_destcon,
                clv_rcd_codtipocontrato,
                clv_imp_abono,
                clv_nro_cantcapitas,
                clv_imp_valorcapita,
                clv_rcd_codmarca,
                TNGS_Carm..CliVentas.instante,
                TNGS_Carm..CliVentas.deleted,
                TNGS_Carm..CliVentas.usuario,
                TNGS_Carm..CliVentas.version
           from TNGS_Carm..CliVentas
                join TNGS_Carm..TipoCont
                  on clv_rcd_codtipocontrato = tcn_rcd_cod
                join TNGS_Carm..Vendedores
                  on clv_cd6_codvendedor = vnd_cd6_cod
          where clv_nro_numcliente = @clv_nro_numcliente
            and TNGS_Carm..CliVentas.deleted = 0
          order by clv_fyh_fecha
      end
   else
      begin
         Select clv_nro_numcliente,
                clv_fyh_fecha,
                dbo.VENDEDORES_GETFULLNAME(clv_cd6_codvendedor) as vnd_des_desvend,
                clv_cd6_codvendedor,
                tcn_des_des as clv_des_destcon,
                clv_rcd_codtipocontrato,
                clv_imp_abono,
                clv_nro_cantcapitas,
                clv_imp_valorcapita,
                clv_rcd_codmarca,
                TNGS_Carm..CliVentas.instante,
                TNGS_Carm..CliVentas.deleted,
                TNGS_Carm..CliVentas.usuario,
                TNGS_Carm..CliVentas.version
           from TNGS_Carm..CliVentas
                join TNGS_Carm..TipoCont
                  on clv_rcd_codtipocontrato = tcn_rcd_cod
                join TNGS_Carm..Vendedores
                  on clv_cd6_codvendedor = vnd_cd6_cod
          where clv_nro_numcliente = @clv_nro_numcliente
          order by clv_fyh_fecha
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIVENTAS_FSEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@clv_nro_numcliente">Numero Cliente</param>
--- <param name="@clv_fyh_fecha">Fecha Venta</param>
--- <param name="@clv_cd6_codvendedor">Vendedor</param>
--- <param name="@clv_rcd_codtipocontrato">Tipo Contrato</param>
--- <param name="@clv_imp_abono">Abono</param>
--- <param name="@clv_nro_cantcapitas">Capitas</param>
--- <param name="@clv_imp_valorcapita">Valor Capita</param>
--- <param name="@clv_rcd_codmarca">Marca</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIVENTAS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.CLIVENTAS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIVENTAS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIVENTAS_INSERT
(
@clv_nro_numcliente tngs_numero,
@clv_fyh_fecha tngs_fecyhor,
@clv_cd6_codvendedor tngs_codigo_6,
@clv_rcd_codtipocontrato tngs_codigo_r,
@clv_imp_abono tngs_importe,
@clv_nro_cantcapitas tngs_numero,
@clv_imp_valorcapita tngs_importe,
@clv_rcd_codmarca tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Carm..CliVentas
   values (
           @clv_nro_numcliente,
           @clv_fyh_fecha,
           @clv_cd6_codvendedor,
           @clv_rcd_codtipocontrato,
           @clv_imp_abono,
           @clv_nro_cantcapitas,
           @clv_imp_valorcapita,
           @clv_rcd_codmarca,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIVENTAS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@clv_nro_numcliente">Numero Cliente</param>
--- <param name="@clv_fyh_fecha">Fecha Venta</param>
--- <param name="@clv_cd6_codvendedor">Vendedor</param>
--- <param name="@clv_rcd_codtipocontrato">Tipo Contrato</param>
--- <param name="@clv_imp_abono">Abono</param>
--- <param name="@clv_nro_cantcapitas">Capitas</param>
--- <param name="@clv_imp_valorcapita">Valor Capita</param>
--- <param name="@clv_rcd_codmarca">Marca</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIVENTAS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.CLIVENTAS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIVENTAS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIVENTAS_UPDATE
(
@clv_nro_numcliente tngs_numero,
@clv_fyh_fecha tngs_fecyhor,
@clv_cd6_codvendedor tngs_codigo_6,
@clv_rcd_codtipocontrato tngs_codigo_r,
@clv_imp_abono tngs_importe,
@clv_nro_cantcapitas tngs_numero,
@clv_imp_valorcapita tngs_importe,
@clv_rcd_codmarca tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..CliVentas
      set clv_cd6_codvendedor= @clv_cd6_codvendedor,
          clv_rcd_codtipocontrato= @clv_rcd_codtipocontrato,
          clv_imp_abono= @clv_imp_abono,
          clv_nro_cantcapitas= @clv_nro_cantcapitas,
          clv_imp_valorcapita= @clv_imp_valorcapita,
          clv_rcd_codmarca= @clv_rcd_codmarca,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where clv_nro_numcliente = @clv_nro_numcliente
      and clv_fyh_fecha = @clv_fyh_fecha

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIVENTAS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@clv_nro_numcliente">Numero Cliente</param>
--- <param name="@clv_fyh_fecha">Fecha Venta</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIVENTAS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.CLIVENTAS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIVENTAS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIVENTAS_DELETE
(
@clv_nro_numcliente tngs_numero,
@clv_fyh_fecha tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..CliVentas
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where clv_nro_numcliente = @clv_nro_numcliente
      and clv_fyh_fecha = @clv_fyh_fecha

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIVENTAS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro por clave foranea
--- </summary>
--- <param name="@clv_nro_numcliente">Numero Cliente</param>
--- <param name="@instante">Instante del delete</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIVENTAS_FDELETE'

if exists (select * from sysobjects where id = object_id('dbo.CLIVENTAS_FDELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIVENTAS_FDELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIVENTAS_FDELETE
(
@clv_nro_numcliente tngs_numero,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         select @instante= getdate()
      end

   Update TNGS_Carm..CliVentas
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= @instante,
          usuario = @usuario
    where clv_nro_numcliente = @clv_nro_numcliente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIVENTAS_FDELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@clv_nro_numcliente">Numero Cliente</param>
--- <param name="@clv_fyh_fecha">Fecha Venta</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIVENTAS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.CLIVENTAS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIVENTAS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIVENTAS_RECALL
(
@clv_nro_numcliente tngs_numero,
@clv_fyh_fecha tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..CliVentas
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where clv_nro_numcliente = @clv_nro_numcliente
      and clv_fyh_fecha = @clv_fyh_fecha

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIVENTAS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera lógicamente los registros de una clave foranea
--- </summary>
--- <param name="@clv_nro_numcliente">Numero Cliente</param>
--- <param name="@instante">Instante de referencia</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIVENTAS_FRECALL'

if exists (select * from sysobjects where id = object_id('dbo.CLIVENTAS_FRECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIVENTAS_FRECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIVENTAS_FRECALL
(
@clv_nro_numcliente tngs_numero,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         Update TNGS_Carm..CliVentas
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where clv_nro_numcliente = @clv_nro_numcliente
      end
   else
      begin
         Update TNGS_Carm..CliVentas
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where clv_nro_numcliente = @clv_nro_numcliente
            and instante= @instante
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIVENTAS_FRECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@clv_nro_numcliente">Numero Cliente</param>
--- <param name="@clv_fyh_fecha">Fecha Venta</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIVENTAS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.CLIVENTAS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIVENTAS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIVENTAS_DROP
(
@clv_nro_numcliente tngs_numero,
@clv_fyh_fecha tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..CliVentas
    where clv_nro_numcliente = @clv_nro_numcliente
      and clv_fyh_fecha = @clv_fyh_fecha

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIVENTAS_DROP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro por clave foránea
--- </summary>
--- <param name="@clv_nro_numcliente">Numero Cliente</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIVENTAS_FDROP'

if exists (select * from sysobjects where id = object_id('dbo.CLIVENTAS_FDROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIVENTAS_FDROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIVENTAS_FDROP
(
@clv_nro_numcliente tngs_numero,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..CliVentas
    where clv_nro_numcliente = @clv_nro_numcliente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIVENTAS_FDROP to tngsmodulos

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

print 'Store Procedure: dbo.CLIVENTAS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.CLIVENTAS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIVENTAS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIVENTAS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Carm..CliVentas
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIVENTAS_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente los registro borrados lógicamente por clave foránea
--- </summary>
--- <param name="@clv_nro_numcliente">Numero Cliente</param>
--- <param name="@usuario">Usuario que realiza el pack</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIVENTAS_FPACK'

if exists (select * from sysobjects where id = object_id('dbo.CLIVENTAS_FPACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIVENTAS_FPACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIVENTAS_FPACK
(
@clv_nro_numcliente tngs_numero,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..CliVentas
    where clv_nro_numcliente = @clv_nro_numcliente
      and deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIVENTAS_FPACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: ZDetalleVentas
--- </summary>
--- <param name="@anio">Anio</param>
--- <param name="@mes">Mes</param>
--- <param name="@codmarcaini">Cod Marca Inicial</param>
--- <param name="@codmarcafin">Cod Marca Fin</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIVENTAS_ZDETALLEVENTAS'

if exists (select * from sysobjects where id = object_id('dbo.CLIVENTAS_ZDETALLEVENTAS'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIVENTAS_ZDETALLEVENTAS
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIVENTAS_ZDETALLEVENTAS
(
@anio tngs_numero,
@mes tngs_numero,
@codmarcaini tngs_codigo_r,
@codmarcafin tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   select clv_nro_numcliente, cli_ede_rsocial, clv_fyh_fecha, ltrim(rtrim(vnd_des_nombre)) + ' ' + vnd_des_apellido as vendedor, clv_imp_abono, mrc_des_des 
   from CliVentas 
       join Clientes on cli_nro_numero = clv_nro_numcliente 
   	join Vendedores on clv_cd6_codvendedor = vnd_cd6_cod 
   	join Marcas on mrc_rcd_cod = clv_rcd_codmarca 
   where year(clv_fyh_fecha) = @anio and month(clv_fyh_fecha) = @mes 
   and clv_rcd_codmarca between @codmarcaini and @codmarcafin 
   order by clv_fyh_fecha 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIVENTAS_ZDETALLEVENTAS to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: ZVentasPorMes
--- </summary>
--- <param name="@anioinicio">Anio de inicio</param>
--- <param name="@codmarcaini">Codigo inicial de marca</param>
--- <param name="@codmarcafin">Codigo Final de marca</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIVENTAS_ZVENTASPORMES'

if exists (select * from sysobjects where id = object_id('dbo.CLIVENTAS_ZVENTASPORMES'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIVENTAS_ZVENTASPORMES
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIVENTAS_ZVENTASPORMES
(
@anioinicio tngs_numero,
@codmarcaini tngs_codigo_r,
@codmarcafin tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Set Language spanish 
   select DATENAME(month, DATEADD(month, MONTH(clv_fyh_fecha)-1, CAST('2008-01-01' AS datetime))) as Mes, 
   	COUNT(*) as CantidadClientes, 
   	SUM(clv_imp_abono) as AbonosClientes 
   from CliVentas 
       join Clientes on cli_nro_numero = clv_nro_numcliente 
   where year(clv_fyh_fecha) = @anioinicio 
   and clv_rcd_codmarca between @codmarcaini and @codmarcafin 
   group by MONTH(clv_fyh_fecha) 
   order by MONTH(clv_fyh_fecha) 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIVENTAS_ZVENTASPORMES to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: CliVentas
//--------------------------------------------------------------------------*/
