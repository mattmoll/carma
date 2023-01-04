/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 04/01/2023 00:01
// Sistema     : Carm
// Tabla       : Clientes
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

print 'Store Procedure: dbo.CLIENTES_UP'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTES_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTES_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTES_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select cli_nro_numero,
                cli_ede_rsocial,
                cli_des_nombrefant,
                ISNULL(tin_des_des, '') as cli_des_tinst,
                cli_cod_codtinst,
                cli_cod_codfrq,
                isnull(frq_des_des,'') as cli_des_frq,
                cli_cd1_alta,
                cli_tel_telefono1,
                cli_tel_celular,
                cli_tel_telefono2,
                cli_tel_fax,
                cli_ede_direccion,
                cli_nro_altura,
                cli_rde_piso,
                cli_rde_oficina,
                cli_ecd_codlocalidad,
                loc_ede_nombre as cli_des_loc,
                loc_des_provincia as cli_des_prov,
                TNGS_Carm.dbo.Localidades_GetDesZona (cli_ecd_codlocalidad) as cli_des_zona,
                loc_ede_partido as cli_ede_partido,
                loc_rcd_codzona as cli_rcd_codzona,
                cli_des_cuil,
                cli_xld_url,
                cli_cd6_codvend,
                cli_fec_fechaingreso,
                cli_nro_cantempleados,
                cli_txt_cobertura,
                cli_nom_cargador,
                cli_txt_observacion,
                cli_xld_email,
                cli_nro_nroavalon,
                cli_imp_abono,
                cli_rcd_codtipocont,
                cli_imp_deuda,
                cli_cd1_sexo,
                cli_des_tarjetacred,
                cli_cd1_fueclienteantes,
                cli_ede_titular,
                cli_ede_direccioncobertura,
                cli_nro_alturacobertura,
                cli_rde_pisocobertura,
                cli_rde_oficinacobertura,
                cli_ecd_codloccobertura,
                cli_rcd_codmarca,
                cli_rcd_tipocliente,
                cli_fec_fechanacimiento,
                cli_rcd_situacioniva,
                cli_xde_apellido,
                cli_ede_nombre,
                cli_rcd_codrubro,
                cli_fec_fecultimocontacto,
                cli_fec_fechaproxcontacto,
                cli_cd1_rellamar,
                TNGS_Carm..Clientes.instante,
                TNGS_Carm..Clientes.deleted,
                TNGS_Carm..Clientes.usuario,
                TNGS_Carm..Clientes.version
           from TNGS_Carm..Clientes
                left outer join TNGS_Carm..Franquicias
                  on cli_cod_codfrq = frq_cod_cod
                join TNGS_Carm..Localidades
                  on cli_ecd_codlocalidad = loc_ecd_codpost
                left outer join TNGS_Carm..TipoInst
                  on cli_cod_codtinst = tin_cod_cod
          where TNGS_Carm..Clientes.deleted = 0
          order by cli_nro_numero
      end
   else
      begin
         Select cli_nro_numero,
                cli_ede_rsocial,
                cli_des_nombrefant,
                ISNULL(tin_des_des, '') as cli_des_tinst,
                cli_cod_codtinst,
                cli_cod_codfrq,
                isnull(frq_des_des,'') as cli_des_frq,
                cli_cd1_alta,
                cli_tel_telefono1,
                cli_tel_celular,
                cli_tel_telefono2,
                cli_tel_fax,
                cli_ede_direccion,
                cli_nro_altura,
                cli_rde_piso,
                cli_rde_oficina,
                cli_ecd_codlocalidad,
                loc_ede_nombre as cli_des_loc,
                loc_des_provincia as cli_des_prov,
                TNGS_Carm.dbo.Localidades_GetDesZona (cli_ecd_codlocalidad) as cli_des_zona,
                loc_ede_partido as cli_ede_partido,
                loc_rcd_codzona as cli_rcd_codzona,
                cli_des_cuil,
                cli_xld_url,
                cli_cd6_codvend,
                cli_fec_fechaingreso,
                cli_nro_cantempleados,
                cli_txt_cobertura,
                cli_nom_cargador,
                cli_txt_observacion,
                cli_xld_email,
                cli_nro_nroavalon,
                cli_imp_abono,
                cli_rcd_codtipocont,
                cli_imp_deuda,
                cli_cd1_sexo,
                cli_des_tarjetacred,
                cli_cd1_fueclienteantes,
                cli_ede_titular,
                cli_ede_direccioncobertura,
                cli_nro_alturacobertura,
                cli_rde_pisocobertura,
                cli_rde_oficinacobertura,
                cli_ecd_codloccobertura,
                cli_rcd_codmarca,
                cli_rcd_tipocliente,
                cli_fec_fechanacimiento,
                cli_rcd_situacioniva,
                cli_xde_apellido,
                cli_ede_nombre,
                cli_rcd_codrubro,
                cli_fec_fecultimocontacto,
                cli_fec_fechaproxcontacto,
                cli_cd1_rellamar,
                TNGS_Carm..Clientes.instante,
                TNGS_Carm..Clientes.deleted,
                TNGS_Carm..Clientes.usuario,
                TNGS_Carm..Clientes.version
           from TNGS_Carm..Clientes
                left outer join TNGS_Carm..Franquicias
                  on cli_cod_codfrq = frq_cod_cod
                join TNGS_Carm..Localidades
                  on cli_ecd_codlocalidad = loc_ecd_codpost
                left outer join TNGS_Carm..TipoInst
                  on cli_cod_codtinst = tin_cod_cod
          order by cli_nro_numero
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTES_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@cli_nro_numero">Número de cliente</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTES_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTES_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTES_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTES_CHKVERSION
(
@cli_nro_numero tngs_numero,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Carm..Clientes
    where cli_nro_numero = @cli_nro_numero
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTES_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@cli_nro_numero">Número de cliente</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTES_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTES_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTES_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTES_SEARCH
(
@cli_nro_numero tngs_numero,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select cli_nro_numero,
                cli_ede_rsocial,
                cli_des_nombrefant,
                ISNULL(tin_des_des, '') as cli_des_tinst,
                cli_cod_codtinst,
                cli_cod_codfrq,
                isnull(frq_des_des,'') as cli_des_frq,
                cli_cd1_alta,
                cli_tel_telefono1,
                cli_tel_celular,
                cli_tel_telefono2,
                cli_tel_fax,
                cli_ede_direccion,
                cli_nro_altura,
                cli_rde_piso,
                cli_rde_oficina,
                cli_ecd_codlocalidad,
                loc_ede_nombre as cli_des_loc,
                loc_des_provincia as cli_des_prov,
                TNGS_Carm.dbo.Localidades_GetDesZona (cli_ecd_codlocalidad) as cli_des_zona,
                loc_ede_partido as cli_ede_partido,
                loc_rcd_codzona as cli_rcd_codzona,
                cli_des_cuil,
                cli_xld_url,
                cli_cd6_codvend,
                cli_fec_fechaingreso,
                cli_nro_cantempleados,
                cli_txt_cobertura,
                cli_nom_cargador,
                cli_txt_observacion,
                cli_xld_email,
                cli_nro_nroavalon,
                cli_imp_abono,
                cli_rcd_codtipocont,
                cli_imp_deuda,
                cli_cd1_sexo,
                cli_des_tarjetacred,
                cli_cd1_fueclienteantes,
                cli_ede_titular,
                cli_ede_direccioncobertura,
                cli_nro_alturacobertura,
                cli_rde_pisocobertura,
                cli_rde_oficinacobertura,
                cli_ecd_codloccobertura,
                cli_rcd_codmarca,
                cli_rcd_tipocliente,
                cli_fec_fechanacimiento,
                cli_rcd_situacioniva,
                cli_xde_apellido,
                cli_ede_nombre,
                cli_rcd_codrubro,
                cli_fec_fecultimocontacto,
                cli_fec_fechaproxcontacto,
                cli_cd1_rellamar,
                TNGS_Carm..Clientes.instante,
                TNGS_Carm..Clientes.deleted,
                TNGS_Carm..Clientes.usuario,
                TNGS_Carm..Clientes.version
           from TNGS_Carm..Clientes
                left outer join TNGS_Carm..Franquicias
                  on cli_cod_codfrq = frq_cod_cod
                join TNGS_Carm..Localidades
                  on cli_ecd_codlocalidad = loc_ecd_codpost
                left outer join TNGS_Carm..TipoInst
                  on cli_cod_codtinst = tin_cod_cod
          where cli_nro_numero = @cli_nro_numero
            and TNGS_Carm..Clientes.deleted = 0
      end
   else
      begin
         Select cli_nro_numero,
                cli_ede_rsocial,
                cli_des_nombrefant,
                ISNULL(tin_des_des, '') as cli_des_tinst,
                cli_cod_codtinst,
                cli_cod_codfrq,
                isnull(frq_des_des,'') as cli_des_frq,
                cli_cd1_alta,
                cli_tel_telefono1,
                cli_tel_celular,
                cli_tel_telefono2,
                cli_tel_fax,
                cli_ede_direccion,
                cli_nro_altura,
                cli_rde_piso,
                cli_rde_oficina,
                cli_ecd_codlocalidad,
                loc_ede_nombre as cli_des_loc,
                loc_des_provincia as cli_des_prov,
                TNGS_Carm.dbo.Localidades_GetDesZona (cli_ecd_codlocalidad) as cli_des_zona,
                loc_ede_partido as cli_ede_partido,
                loc_rcd_codzona as cli_rcd_codzona,
                cli_des_cuil,
                cli_xld_url,
                cli_cd6_codvend,
                cli_fec_fechaingreso,
                cli_nro_cantempleados,
                cli_txt_cobertura,
                cli_nom_cargador,
                cli_txt_observacion,
                cli_xld_email,
                cli_nro_nroavalon,
                cli_imp_abono,
                cli_rcd_codtipocont,
                cli_imp_deuda,
                cli_cd1_sexo,
                cli_des_tarjetacred,
                cli_cd1_fueclienteantes,
                cli_ede_titular,
                cli_ede_direccioncobertura,
                cli_nro_alturacobertura,
                cli_rde_pisocobertura,
                cli_rde_oficinacobertura,
                cli_ecd_codloccobertura,
                cli_rcd_codmarca,
                cli_rcd_tipocliente,
                cli_fec_fechanacimiento,
                cli_rcd_situacioniva,
                cli_xde_apellido,
                cli_ede_nombre,
                cli_rcd_codrubro,
                cli_fec_fecultimocontacto,
                cli_fec_fechaproxcontacto,
                cli_cd1_rellamar,
                TNGS_Carm..Clientes.instante,
                TNGS_Carm..Clientes.deleted,
                TNGS_Carm..Clientes.usuario,
                TNGS_Carm..Clientes.version
           from TNGS_Carm..Clientes
                left outer join TNGS_Carm..Franquicias
                  on cli_cod_codfrq = frq_cod_cod
                join TNGS_Carm..Localidades
                  on cli_ecd_codlocalidad = loc_ecd_codpost
                left outer join TNGS_Carm..TipoInst
                  on cli_cod_codtinst = tin_cod_cod
          where cli_nro_numero = @cli_nro_numero
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTES_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@cli_nro_numero">Número de cliente</param>
--- <param name="@cli_ede_rsocial">Razón social</param>
--- <param name="@cli_des_nombrefant">Nombre de fantasía</param>
--- <param name="@cli_cod_codtinst">Tipo de Institucion</param>
--- <param name="@cli_cod_codfrq">Franquicia</param>
--- <param name="@cli_cd1_alta">Alta en Avalon</param>
--- <param name="@cli_tel_telefono1">Teléfono 1</param>
--- <param name="@cli_tel_celular">Celular</param>
--- <param name="@cli_tel_telefono2">Teléfono 2</param>
--- <param name="@cli_tel_fax">Fax</param>
--- <param name="@cli_ede_direccion">Dirección</param>
--- <param name="@cli_nro_altura">Altura</param>
--- <param name="@cli_rde_piso">Piso</param>
--- <param name="@cli_rde_oficina">Oficina</param>
--- <param name="@cli_ecd_codlocalidad">Código de localidad</param>
--- <param name="@cli_des_cuil">Cuil</param>
--- <param name="@cli_xld_url">Url</param>
--- <param name="@cli_cd6_codvend">Código de vendedor</param>
--- <param name="@cli_fec_fechaingreso">Fecha de ingreso</param>
--- <param name="@cli_nro_cantempleados">Cantidad de Empleados</param>
--- <param name="@cli_txt_cobertura">Cobertura</param>
--- <param name="@cli_nom_cargador">Usuario Cargador</param>
--- <param name="@cli_txt_observacion">Observacion</param>
--- <param name="@cli_xld_email">E-Mail</param>
--- <param name="@cli_nro_nroavalon">Número Avalon</param>
--- <param name="@cli_imp_abono">Abono</param>
--- <param name="@cli_rcd_codtipocont">Tipo Contrato</param>
--- <param name="@cli_imp_deuda">Deuda</param>
--- <param name="@cli_cd1_sexo">Sexo</param>
--- <param name="@cli_des_tarjetacred">Tarjeta de Crédito</param>
--- <param name="@cli_cd1_fueclienteantes">Fue Cliente Antes</param>
--- <param name="@cli_ede_titular">Titular</param>
--- <param name="@cli_ede_direccioncobertura">Direccion Cobertura</param>
--- <param name="@cli_nro_alturacobertura">Altura Cobertura</param>
--- <param name="@cli_rde_pisocobertura">Piso Cobertura</param>
--- <param name="@cli_rde_oficinacobertura">Oficina Cobertura</param>
--- <param name="@cli_ecd_codloccobertura">Localidad Cobertura</param>
--- <param name="@cli_rcd_codmarca">Marca</param>
--- <param name="@cli_rcd_tipocliente">Tipo Cliente</param>
--- <param name="@cli_fec_fechanacimiento">Fecha nacimiento</param>
--- <param name="@cli_rcd_situacioniva">Situacion IVA</param>
--- <param name="@cli_xde_apellido">Apellido</param>
--- <param name="@cli_ede_nombre">Nombre</param>
--- <param name="@cli_rcd_codrubro">Rubro</param>
--- <param name="@cli_fec_fecultimocontacto">Fecha Último Contacto</param>
--- <param name="@cli_fec_fechaproxcontacto">Fecha Próximo Contacto</param>
--- <param name="@cli_cd1_rellamar">Volver a Llamar</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTES_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTES_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTES_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTES_INSERT
(
@cli_nro_numero tngs_numero,
@cli_ede_rsocial tngs_descripcion_e,
@cli_des_nombrefant tngs_descripcion,
@cli_cod_codtinst tngs_codigo,
@cli_cod_codfrq tngs_codigo,
@cli_cd1_alta tngs_codigo_1,
@cli_tel_telefono1 tngs_telefono,
@cli_tel_celular tngs_telefono,
@cli_tel_telefono2 tngs_telefono,
@cli_tel_fax tngs_telefono,
@cli_ede_direccion tngs_descripcion_e,
@cli_nro_altura tngs_numero,
@cli_rde_piso tngs_descripcion_r,
@cli_rde_oficina tngs_descripcion_r,
@cli_ecd_codlocalidad tngs_codigo_e,
@cli_des_cuil tngs_descripcion,
@cli_xld_url tngs_descripcion_xl,
@cli_cd6_codvend tngs_codigo_6,
@cli_fec_fechaingreso tngs_fecha,
@cli_nro_cantempleados tngs_numero,
@cli_txt_cobertura tngs_texto,
@cli_nom_cargador tngs_nombre,
@cli_txt_observacion tngs_texto,
@cli_xld_email tngs_descripcion_xl,
@cli_nro_nroavalon tngs_numero,
@cli_imp_abono tngs_importe,
@cli_rcd_codtipocont tngs_codigo_r,
@cli_imp_deuda tngs_importe,
@cli_cd1_sexo tngs_codigo_1,
@cli_des_tarjetacred tngs_descripcion,
@cli_cd1_fueclienteantes tngs_codigo_1,
@cli_ede_titular tngs_descripcion_e,
@cli_ede_direccioncobertura tngs_descripcion_e,
@cli_nro_alturacobertura tngs_numero,
@cli_rde_pisocobertura tngs_descripcion_r,
@cli_rde_oficinacobertura tngs_descripcion_r,
@cli_ecd_codloccobertura tngs_codigo_e,
@cli_rcd_codmarca tngs_codigo_r,
@cli_rcd_tipocliente tngs_codigo_r,
@cli_fec_fechanacimiento tngs_fecha,
@cli_rcd_situacioniva tngs_codigo_r,
@cli_xde_apellido tngs_descripcion_x,
@cli_ede_nombre tngs_descripcion_e,
@cli_rcd_codrubro tngs_codigo_r,
@cli_fec_fecultimocontacto tngs_fecha,
@cli_fec_fechaproxcontacto tngs_fecha,
@cli_cd1_rellamar tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Carm..Clientes
   values (
           @cli_nro_numero,
           @cli_ede_rsocial,
           @cli_des_nombrefant,
           @cli_cod_codtinst,
           @cli_cod_codfrq,
           @cli_cd1_alta,
           @cli_tel_telefono1,
           @cli_tel_celular,
           @cli_tel_telefono2,
           @cli_tel_fax,
           @cli_ede_direccion,
           @cli_nro_altura,
           @cli_rde_piso,
           @cli_rde_oficina,
           @cli_ecd_codlocalidad,
           @cli_des_cuil,
           @cli_xld_url,
           @cli_cd6_codvend,
           @cli_fec_fechaingreso,
           @cli_nro_cantempleados,
           @cli_txt_cobertura,
           @cli_nom_cargador,
           @cli_txt_observacion,
           @cli_xld_email,
           @cli_nro_nroavalon,
           @cli_imp_abono,
           @cli_rcd_codtipocont,
           @cli_imp_deuda,
           @cli_cd1_sexo,
           @cli_des_tarjetacred,
           @cli_cd1_fueclienteantes,
           @cli_ede_titular,
           @cli_ede_direccioncobertura,
           @cli_nro_alturacobertura,
           @cli_rde_pisocobertura,
           @cli_rde_oficinacobertura,
           @cli_ecd_codloccobertura,
           @cli_rcd_codmarca,
           @cli_rcd_tipocliente,
           @cli_fec_fechanacimiento,
           @cli_rcd_situacioniva,
           @cli_xde_apellido,
           @cli_ede_nombre,
           @cli_rcd_codrubro,
           @cli_fec_fecultimocontacto,
           @cli_fec_fechaproxcontacto,
           @cli_cd1_rellamar,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTES_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@cli_nro_numero">Número de cliente</param>
--- <param name="@cli_ede_rsocial">Razón social</param>
--- <param name="@cli_des_nombrefant">Nombre de fantasía</param>
--- <param name="@cli_cod_codtinst">Tipo de Institucion</param>
--- <param name="@cli_cod_codfrq">Franquicia</param>
--- <param name="@cli_cd1_alta">Alta en Avalon</param>
--- <param name="@cli_tel_telefono1">Teléfono 1</param>
--- <param name="@cli_tel_celular">Celular</param>
--- <param name="@cli_tel_telefono2">Teléfono 2</param>
--- <param name="@cli_tel_fax">Fax</param>
--- <param name="@cli_ede_direccion">Dirección</param>
--- <param name="@cli_nro_altura">Altura</param>
--- <param name="@cli_rde_piso">Piso</param>
--- <param name="@cli_rde_oficina">Oficina</param>
--- <param name="@cli_ecd_codlocalidad">Código de localidad</param>
--- <param name="@cli_des_cuil">Cuil</param>
--- <param name="@cli_xld_url">Url</param>
--- <param name="@cli_cd6_codvend">Código de vendedor</param>
--- <param name="@cli_fec_fechaingreso">Fecha de ingreso</param>
--- <param name="@cli_nro_cantempleados">Cantidad de Empleados</param>
--- <param name="@cli_txt_cobertura">Cobertura</param>
--- <param name="@cli_nom_cargador">Usuario Cargador</param>
--- <param name="@cli_txt_observacion">Observacion</param>
--- <param name="@cli_xld_email">E-Mail</param>
--- <param name="@cli_nro_nroavalon">Número Avalon</param>
--- <param name="@cli_imp_abono">Abono</param>
--- <param name="@cli_rcd_codtipocont">Tipo Contrato</param>
--- <param name="@cli_imp_deuda">Deuda</param>
--- <param name="@cli_cd1_sexo">Sexo</param>
--- <param name="@cli_des_tarjetacred">Tarjeta de Crédito</param>
--- <param name="@cli_cd1_fueclienteantes">Fue Cliente Antes</param>
--- <param name="@cli_ede_titular">Titular</param>
--- <param name="@cli_ede_direccioncobertura">Direccion Cobertura</param>
--- <param name="@cli_nro_alturacobertura">Altura Cobertura</param>
--- <param name="@cli_rde_pisocobertura">Piso Cobertura</param>
--- <param name="@cli_rde_oficinacobertura">Oficina Cobertura</param>
--- <param name="@cli_ecd_codloccobertura">Localidad Cobertura</param>
--- <param name="@cli_rcd_codmarca">Marca</param>
--- <param name="@cli_rcd_tipocliente">Tipo Cliente</param>
--- <param name="@cli_fec_fechanacimiento">Fecha nacimiento</param>
--- <param name="@cli_rcd_situacioniva">Situacion IVA</param>
--- <param name="@cli_xde_apellido">Apellido</param>
--- <param name="@cli_ede_nombre">Nombre</param>
--- <param name="@cli_rcd_codrubro">Rubro</param>
--- <param name="@cli_fec_fecultimocontacto">Fecha Último Contacto</param>
--- <param name="@cli_fec_fechaproxcontacto">Fecha Próximo Contacto</param>
--- <param name="@cli_cd1_rellamar">Volver a Llamar</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTES_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTES_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTES_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTES_UPDATE
(
@cli_nro_numero tngs_numero,
@cli_ede_rsocial tngs_descripcion_e,
@cli_des_nombrefant tngs_descripcion,
@cli_cod_codtinst tngs_codigo,
@cli_cod_codfrq tngs_codigo,
@cli_cd1_alta tngs_codigo_1,
@cli_tel_telefono1 tngs_telefono,
@cli_tel_celular tngs_telefono,
@cli_tel_telefono2 tngs_telefono,
@cli_tel_fax tngs_telefono,
@cli_ede_direccion tngs_descripcion_e,
@cli_nro_altura tngs_numero,
@cli_rde_piso tngs_descripcion_r,
@cli_rde_oficina tngs_descripcion_r,
@cli_ecd_codlocalidad tngs_codigo_e,
@cli_des_cuil tngs_descripcion,
@cli_xld_url tngs_descripcion_xl,
@cli_cd6_codvend tngs_codigo_6,
@cli_fec_fechaingreso tngs_fecha,
@cli_nro_cantempleados tngs_numero,
@cli_txt_cobertura tngs_texto,
@cli_nom_cargador tngs_nombre,
@cli_txt_observacion tngs_texto,
@cli_xld_email tngs_descripcion_xl,
@cli_nro_nroavalon tngs_numero,
@cli_imp_abono tngs_importe,
@cli_rcd_codtipocont tngs_codigo_r,
@cli_imp_deuda tngs_importe,
@cli_cd1_sexo tngs_codigo_1,
@cli_des_tarjetacred tngs_descripcion,
@cli_cd1_fueclienteantes tngs_codigo_1,
@cli_ede_titular tngs_descripcion_e,
@cli_ede_direccioncobertura tngs_descripcion_e,
@cli_nro_alturacobertura tngs_numero,
@cli_rde_pisocobertura tngs_descripcion_r,
@cli_rde_oficinacobertura tngs_descripcion_r,
@cli_ecd_codloccobertura tngs_codigo_e,
@cli_rcd_codmarca tngs_codigo_r,
@cli_rcd_tipocliente tngs_codigo_r,
@cli_fec_fechanacimiento tngs_fecha,
@cli_rcd_situacioniva tngs_codigo_r,
@cli_xde_apellido tngs_descripcion_x,
@cli_ede_nombre tngs_descripcion_e,
@cli_rcd_codrubro tngs_codigo_r,
@cli_fec_fecultimocontacto tngs_fecha,
@cli_fec_fechaproxcontacto tngs_fecha,
@cli_cd1_rellamar tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Clientes
      set cli_ede_rsocial= @cli_ede_rsocial,
          cli_des_nombrefant= @cli_des_nombrefant,
          cli_cod_codtinst= @cli_cod_codtinst,
          cli_cod_codfrq= @cli_cod_codfrq,
          cli_cd1_alta= @cli_cd1_alta,
          cli_tel_telefono1= @cli_tel_telefono1,
          cli_tel_celular= @cli_tel_celular,
          cli_tel_telefono2= @cli_tel_telefono2,
          cli_tel_fax= @cli_tel_fax,
          cli_ede_direccion= @cli_ede_direccion,
          cli_nro_altura= @cli_nro_altura,
          cli_rde_piso= @cli_rde_piso,
          cli_rde_oficina= @cli_rde_oficina,
          cli_ecd_codlocalidad= @cli_ecd_codlocalidad,
          cli_des_cuil= @cli_des_cuil,
          cli_xld_url= @cli_xld_url,
          cli_cd6_codvend= @cli_cd6_codvend,
          cli_fec_fechaingreso= @cli_fec_fechaingreso,
          cli_nro_cantempleados= @cli_nro_cantempleados,
          cli_txt_cobertura= @cli_txt_cobertura,
          cli_nom_cargador= @cli_nom_cargador,
          cli_txt_observacion= @cli_txt_observacion,
          cli_xld_email= @cli_xld_email,
          cli_nro_nroavalon= @cli_nro_nroavalon,
          cli_imp_abono= @cli_imp_abono,
          cli_rcd_codtipocont= @cli_rcd_codtipocont,
          cli_imp_deuda= @cli_imp_deuda,
          cli_cd1_sexo= @cli_cd1_sexo,
          cli_des_tarjetacred= @cli_des_tarjetacred,
          cli_cd1_fueclienteantes= @cli_cd1_fueclienteantes,
          cli_ede_titular= @cli_ede_titular,
          cli_ede_direccioncobertura= @cli_ede_direccioncobertura,
          cli_nro_alturacobertura= @cli_nro_alturacobertura,
          cli_rde_pisocobertura= @cli_rde_pisocobertura,
          cli_rde_oficinacobertura= @cli_rde_oficinacobertura,
          cli_ecd_codloccobertura= @cli_ecd_codloccobertura,
          cli_rcd_codmarca= @cli_rcd_codmarca,
          cli_rcd_tipocliente= @cli_rcd_tipocliente,
          cli_fec_fechanacimiento= @cli_fec_fechanacimiento,
          cli_rcd_situacioniva= @cli_rcd_situacioniva,
          cli_xde_apellido= @cli_xde_apellido,
          cli_ede_nombre= @cli_ede_nombre,
          cli_rcd_codrubro= @cli_rcd_codrubro,
          cli_fec_fecultimocontacto= @cli_fec_fecultimocontacto,
          cli_fec_fechaproxcontacto= @cli_fec_fechaproxcontacto,
          cli_cd1_rellamar= @cli_cd1_rellamar,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where cli_nro_numero = @cli_nro_numero

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTES_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@cli_nro_numero">Número de cliente</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTES_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTES_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTES_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTES_DELETE
(
@cli_nro_numero tngs_numero,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Clientes
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where cli_nro_numero = @cli_nro_numero

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTES_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@cli_nro_numero">Número de cliente</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTES_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTES_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTES_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTES_RECALL
(
@cli_nro_numero tngs_numero,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Clientes
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where cli_nro_numero = @cli_nro_numero

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTES_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@cli_nro_numero">Número de cliente</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTES_DROP'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTES_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTES_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTES_DROP
(
@cli_nro_numero tngs_numero,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..Clientes
    where cli_nro_numero = @cli_nro_numero

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTES_DROP to tngsmodulos

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

print 'Store Procedure: dbo.CLIENTES_PACK'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTES_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTES_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTES_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Carm..Clientes
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTES_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: BajaYBorraServicios
--- </summary>
--- <param name="@nrocliente">Numero de Cliente</param>
--- <param name="@cantdiascancel">Tope Cantidad de Dias Cancelacion Servicio</param>
--- <param name="@codcompetencia">Codigo de Competencia</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTES_BAJAYBORRASERVICIOS'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTES_BAJAYBORRASERVICIOS'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTES_BAJAYBORRASERVICIOS
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTES_BAJAYBORRASERVICIOS
(
@nrocliente tngs_numero,
@cantdiascancel tngs_numero,
@codcompetencia tngs_codigo,
@usuario tngs_nombre
)
as
begin

   update Clientes 
   set cli_cd1_alta = 'N', 
   	cli_cd6_codvend = '      ', 
       cli_imp_abono = 0, 
       cli_rcd_codtipocont = '  ' 
   where cli_nro_numero = @nrocliente 
    
   /* Borramos los servicios que tenia cargados el cliente */ 
   delete from CliServicios where cls_nro_numcliente = @nrocliente 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTES_BAJAYBORRASERVICIOS to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: BorraEntrevistasPend
--- </summary>
--- <param name="@numcliente">Numero de Cliente</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTES_BORRAENTREVISTASPEND'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTES_BORRAENTREVISTASPEND'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTES_BORRAENTREVISTASPEND
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTES_BORRAENTREVISTASPEND
(
@numcliente tngs_numero,
@usuario tngs_nombre
)
as
begin

   update TNGS_Carm..CliEntrevistas 
   set TNGS_Carm..CliEntrevistas.deleted = 1.0000, 
   	version = ((version+1) % 32767), 
             instante= getdate(), 
             usuario = @usuario 
    where cle_nro_numcliente = @numcliente 
      and year(cle_fyh_frealizada) = 1900 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTES_BORRAENTREVISTASPEND to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: CambiarMarcaVendido
--- </summary>
--- <param name="@valoralta">Valor Alta (S/N)</param>
--- <param name="@nrocliente">Numero de CLiente</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTES_CAMBIARMARCAVENDIDO'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTES_CAMBIARMARCAVENDIDO'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTES_CAMBIARMARCAVENDIDO
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTES_CAMBIARMARCAVENDIDO
(
@valoralta tngs_codigo_1,
@nrocliente tngs_numero,
@usuario tngs_nombre
)
as
begin

   update	Clientes 
   set		cli_cd1_alta = @valoralta 
   where	cli_nro_numero = @nrocliente 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTES_CAMBIARMARCAVENDIDO to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: GetFromNroAvln
--- </summary>
--- <param name="@nroavalon">Numero de Avalon</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTES_GETFROMNROAVLN'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTES_GETFROMNROAVLN'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTES_GETFROMNROAVLN
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTES_GETFROMNROAVLN
(
@nroavalon tngs_numero,
@usuario tngs_nombre
)
as
begin

   select * from Clientes where cli_nro_nroavalon = @nroavalon 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTES_GETFROMNROAVLN to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: GetPorClaveAvalon
--- </summary>
--- <param name="@nroavalon">Numero de Avalon</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTES_GETPORCLAVEAVALON'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTES_GETPORCLAVEAVALON'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTES_GETPORCLAVEAVALON
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTES_GETPORCLAVEAVALON
(
@nroavalon tngs_numero,
@usuario tngs_nombre
)
as
begin

   select * from Clientes where cli_nro_nroavalon = @nroavalon 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTES_GETPORCLAVEAVALON to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: GetRSocialCliente
--- </summary>
--- <param name="@numcliente">Número de cliente</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTES_GETRSOCIALCLIENTE'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTES_GETRSOCIALCLIENTE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTES_GETRSOCIALCLIENTE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTES_GETRSOCIALCLIENTE
(
@numcliente tngs_numero,
@usuario tngs_nombre
)
as
begin

   SELECT 
    
    cli_ede_rsocial 
    
    FROM 
     TNGS_Carm..Clientes 
    
    WHERE 
     cli_nro_numero = @numcliente 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTES_GETRSOCIALCLIENTE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: GetSinCodVend
--- </summary>
--- <param name="@numero">Numero del cliente</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTES_GETSINCODVEND'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTES_GETSINCODVEND'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTES_GETSINCODVEND
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTES_GETSINCODVEND
(
@numero tngs_numero,
@usuario tngs_nombre
)
as
begin

   Select cli_nro_numero, 
                   cli_ede_rsocial, 
                   cli_des_nombrefant, 
                   tin_des_des as cli_des_tinst, 
                   cli_cod_codtinst, 
                   tin_cd1_mayorista as cli_cd1_esmayo, 
                   cli_cod_codfrq, 
                   frq_des_des as cli_des_frq, 
                   cli_cd1_alta, 
                   cli_tel_telefono1, 
                   cli_tel_telefono2, 
                   cli_tel_fax, 
                   cli_ede_direccion, 
                   cli_rde_piso, 
                   cli_rde_oficina, 
                   cli_ecd_codlocalidad, 
                   loc_ede_nombre as cli_des_loc, 
                   cli_xld_url, 
                   cli_cd6_codvend, 
                   cli_fec_fingsima, 
                   cli_nro_cantempleados, 
                   cli_txt_cobertura, 
                   TNGS_Carm..Clientes.instante, 
                   TNGS_Carm..Clientes.deleted, 
                   TNGS_Carm..Clientes.usuario, 
                   TNGS_Carm..Clientes.version 
              from TNGS_Carm..Clientes 
                   join TNGS_Carm..TipoInst 
                     on cli_cod_codtinst = tin_cod_cod 
                   left outer join TNGS_Carm..Franquicias 
                     on cli_cod_codfrq = frq_cod_cod 
                   join TNGS_Carm..Localidades 
                     on cli_ecd_codlocalidad = loc_ecd_codpost 
    
             where cli_nro_numero = @numero 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTES_GETSINCODVEND to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: GetTodosLosClientes
--- </summary>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTES_GETTODOSLOSCLIENTES'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTES_GETTODOSLOSCLIENTES'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTES_GETTODOSLOSCLIENTES
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTES_GETTODOSLOSCLIENTES
(
@usuario tngs_nombre
)
as
begin

   SELECT 
     cli_nro_numero, 
           cli_ede_rsocial, 
           cli_des_nombrefant, 
           tin_des_des as cli_des_tinst, 
     rbr_des_des as cli_des_rubro, 
           case when (tin_cd1_mayorista = 'S') 
       then 1 
      when (tin_cd1_mayorista = 'N') 
       then 0 
     end as cli_cd1_esmayo, 
     isnull(vnd_nom_usuario, 'Sin reserva') AS cli_nom_usuario, 
           frq_des_des as cli_des_frq, 
           case when (cli_cd1_alta = 'S') 
       then 1 
      when (cli_cd1_alta = 'N') 
       then 0 
     end as cli_cd1_alta, 
           loc_ede_nombre as cli_des_loc, 
     case when (Clientes.deleted = 0.00) 
       then 'S' 
      else  'N' 
     end AS cli_cd1_validado 
    
      FROM TNGS_Carm..Clientes 
           JOIN TNGS_Carm..TipoInst 
             ON cli_cod_codtinst = tin_cod_cod 
           LEFT OUTER JOIN TNGS_Carm..Franquicias 
             ON cli_cod_codfrq = frq_cod_cod 
           JOIN TNGS_Carm..Localidades 
             ON cli_ecd_codlocalidad = loc_ecd_codpost 
     JOIN TNGS_Carm..Rubros 
       ON tin_rcd_codrubro = rbr_rcd_cod 
     LEFT OUTER JOIN TNGS_Carm..Vendedores 
       ON cli_cd6_codvend = vnd_nom_usuario 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTES_GETTODOSLOSCLIENTES to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: GetVendidos
--- </summary>
--- <param name="@codvend">Codigo de Vendedor</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTES_GETVENDIDOS'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTES_GETVENDIDOS'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTES_GETVENDIDOS
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTES_GETVENDIDOS
(
@codvend tngs_codigo_6,
@usuario tngs_nombre
)
as
begin

   select 
             cli_nro_numero, 
             cli_ede_rsocial, 
             cli_des_nombrefant, 
             TNGS_Carm.dbo.Clientes_EntrevPendientes(cli_nro_numero) as cli_ent_pendientes, 
             cli_tel_telefono1, 
             isnull(tin_des_des,'') as cli_des_tipoinst, 
             isnull(rbr_des_des,'') as cli_des_rubro, 
             TNGS_Carm.dbo.Clientes_EntrevPendientesVenc(cli_nro_numero) as cli_ent_pendientesvenc, 
             cli_ede_direccion, 
             loc_ede_nombre as cli_ede_localidad, 
             zns_des_nombre as cli_des_zona, 
             TNGS_Carm.dbo.Clientes_EntrevRealizadas(cli_nro_numero) as cli_ent_realizadas, 
             TNGS_Carm.dbo.Clientes_EntrevVencidas(cli_nro_numero) as cli_ent_vencidas, 
             case when (Clientes.deleted = 0.00) 
              then 'S' 
             else 'N'  end AS cli_cd1_validado 
       from 
             TNGS_Carm..Clientes 
     join TNGS_Carm..Localidades 
      on loc_ecd_codpost = cli_ecd_codlocalidad 
     join TNGS_Carm..Zonas 
      on zns_rcd_cod = loc_rcd_codzona 
     join TNGS_Carm..TipoInst 
      on tin_cod_cod = cli_cod_codtinst 
     join TNGS_Carm..Rubros 
      on rbr_rcd_cod = tin_rcd_codrubro 
     left outer join TNGS_Carm..Franquicias 
      on frq_cod_cod = cli_cod_codfrq 
    
       where cli_cd6_codvend = @codvend and cli_cd1_alta = 'S' 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTES_GETVENDIDOS to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: UpdateAbono
--- </summary>
--- <param name="@nrocliente">Numero de Cliente</param>
--- <param name="@nuevoabono">Nuevo Abono</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTES_UPDATEABONO'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTES_UPDATEABONO'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTES_UPDATEABONO
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTES_UPDATEABONO
(
@nrocliente tngs_numero,
@nuevoabono tngs_importe,
@usuario tngs_nombre
)
as
begin

   update clientes set cli_imp_abono = @nuevoabono where cli_nro_numero = @nrocliente 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTES_UPDATEABONO to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: ValidaDir
--- </summary>
--- <param name="@dir">Direccion del nuevo Cliente</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTES_VALIDADIR'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTES_VALIDADIR'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTES_VALIDADIR
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTES_VALIDADIR
(
@dir tngs_descripcion_e,
@usuario tngs_nombre
)
as
begin

   select cli_nro_numero 
   	from TNGS_Carm..Clientes 
   		where cli_ede_direccion =@dir 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTES_VALIDADIR to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: ValidaRSocial
--- </summary>
--- <param name="@razonsocial">Razon Social del Nuevo Cliente</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTES_VALIDARSOCIAL'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTES_VALIDARSOCIAL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTES_VALIDARSOCIAL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTES_VALIDARSOCIAL
(
@razonsocial tngs_descripcion,
@usuario tngs_nombre
)
as
begin

   select cli_nro_numero 
   	from TNGS_Carm..Clientes 
   		where cli_ede_rsocial = replace(@razonsocial, '°', 'º') 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTES_VALIDARSOCIAL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: ValidaTelefono
--- </summary>
--- <param name="@telefono">Telefono del Nuevo Cliente</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTES_VALIDATELEFONO'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTES_VALIDATELEFONO'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTES_VALIDATELEFONO
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTES_VALIDATELEFONO
(
@telefono tngs_telefono,
@usuario tngs_nombre
)
as
begin

   select cli_nro_numero 
   	from TNGS_Carm..Clientes 
   		where cli_tel_telefono1 = @telefono 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTES_VALIDATELEFONO to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: ValidarExistenciaAvl
--- </summary>
--- <param name="@nroavalon">Numero de Avalon</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTES_VALIDAREXISTENCIAAVL'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTES_VALIDAREXISTENCIAAVL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTES_VALIDAREXISTENCIAAVL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTES_VALIDAREXISTENCIAAVL
(
@nroavalon tngs_numero,
@usuario tngs_nombre
)
as
begin

   select COUNT(*) as cantidad 
   from Clientes 
   where cli_nro_nroavalon = @nroavalon 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTES_VALIDAREXISTENCIAAVL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: Vendido
--- </summary>
--- <param name="@numero">Numero del Cliente</param>
--- <param name="@abono">Abono vendido</param>
--- <param name="@codtipocont">Cod Tipo de Contrato Vendido</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTES_VENDIDO'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTES_VENDIDO'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTES_VENDIDO
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTES_VENDIDO
(
@numero tngs_numero,
@abono tngs_importe,
@codtipocont tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   update TNGS_Carm..Clientes 
    
      set cli_cd1_alta = 'S', 
          cli_cd6_codvend = '', /* Los clientes vendidos no tienen reservador, ni reserva. */ 
          cli_imp_abono = @abono, 
          cli_rcd_codtipocont = @codtipocont 
    
        where cli_nro_numero = @numero 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTES_VENDIDO to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: ZCargadores
--- </summary>
--- <param name="@fechaini">Fecha Inicio</param>
--- <param name="@fechafin">Fecha Fin</param>
--- <param name="@ininomcargador">Inicio Nombre cargador</param>
--- <param name="@finnomcargador">Fin Nombre cargador</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTES_ZCARGADORES'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTES_ZCARGADORES'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTES_ZCARGADORES
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTES_ZCARGADORES
(
@fechaini tngs_fecha,
@fechafin tngs_fecha,
@ininomcargador tngs_descripcion,
@finnomcargador tngs_descripcion,
@usuario tngs_nombre
)
as
begin

   select cli_nom_cargador, cli_nro_numero, cli_nro_nroavalon, cli_ede_rsocial,cli_fec_fingsima, 
   	   tin_des_des,cli_tel_telefono1, cli_tel_celular, cli_ede_direccion, 
   	   cli_nro_altura 
   from Clientes 
   	join TipoInst 
   		on cli_cod_codtinst = tin_cod_cod 
   where cli_nom_cargador between @ininomcargador and @finnomcargador and cli_fec_fingsima between @fechaini and @fechafin 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTES_ZCARGADORES to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: ZLog
--- </summary>
--- <param name="@ininomusuario">Inicio nombre usuario</param>
--- <param name="@finnomusuario">Fin nombre usuario</param>
--- <param name="@fechaini">Fecha Inicio</param>
--- <param name="@fechafin">Fecha Fin</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTES_ZLOG'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTES_ZLOG'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTES_ZLOG
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTES_ZLOG
(
@ininomusuario tngs_nombre,
@finnomusuario tngs_nombre,
@fechaini tngs_fecyhor,
@fechafin tngs_fecha,
@usuario tngs_nombre
)
as
begin

   select	lgc_nom_usuario, lgc_fyh_fecha, lgc_des_accion, 
   		lgc_nro_nrocliente, lgc_nro_nroavalon, lgc_ede_rsocial, lgc_des_nomfantasia 		 
   from LogClientes 
   where lgc_nom_usuario between @ininomusuario and @finnomusuario and lgc_fyh_fecha between @fechaini and @fechafin 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTES_ZLOG to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Clientes
//--------------------------------------------------------------------------*/
