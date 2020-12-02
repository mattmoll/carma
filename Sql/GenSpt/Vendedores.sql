/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 01/12/2020 21:33
// Sistema     : Carm
// Tabla       : Vendedores
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

print 'Store Procedure: dbo.VENDEDORES_UP'

if exists (select * from sysobjects where id = object_id('dbo.VENDEDORES_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.VENDEDORES_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.VENDEDORES_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select vnd_cd6_cod,
                vnd_des_apellido,
                vnd_des_nombre,
                vnd_nom_usuario,
                TNGS_Carm.dbo.VENDEDORES_GETFULLNAME(vnd_cd6_cod) as vnd_ede_nya,
                vnd_tel_tel1,
                vnd_tel_celular,
                vnd_tel_tel2,
                vnd_fec_fecnacim,
                vnd_ede_direccion,
                vnd_cd6_codsuperv,
                rtrim(sup_nom_nombre) + ' '+ sup_nom_apellido as vnd_nom_superv,
                vnd_rcd_codtvend,
                tvn_cd1_vemayor as vnd_cd1_vemayor,
                tvn_des_des as vnd_des_tipovnd,
                vnd_txt_horarios,
                vnd_cd1_historico,
                TNGS_Carm..Vendedores.instante,
                TNGS_Carm..Vendedores.deleted,
                TNGS_Carm..Vendedores.usuario,
                TNGS_Carm..Vendedores.version
           from TNGS_Carm..Vendedores
                join TNGS_Carm..TipoVend
                  on vnd_rcd_codtvend = tvn_rcd_cod
                join TNGS_Carm..Supervisores
                  on vnd_cd6_codsuperv = sup_cd6_cod
          where TNGS_Carm..Vendedores.deleted = 0
          order by vnd_cd6_cod
      end
   else
      begin
         Select vnd_cd6_cod,
                vnd_des_apellido,
                vnd_des_nombre,
                vnd_nom_usuario,
                TNGS_Carm.dbo.VENDEDORES_GETFULLNAME(vnd_cd6_cod) as vnd_ede_nya,
                vnd_tel_tel1,
                vnd_tel_celular,
                vnd_tel_tel2,
                vnd_fec_fecnacim,
                vnd_ede_direccion,
                vnd_cd6_codsuperv,
                rtrim(sup_nom_nombre) + ' '+ sup_nom_apellido as vnd_nom_superv,
                vnd_rcd_codtvend,
                tvn_cd1_vemayor as vnd_cd1_vemayor,
                tvn_des_des as vnd_des_tipovnd,
                vnd_txt_horarios,
                vnd_cd1_historico,
                TNGS_Carm..Vendedores.instante,
                TNGS_Carm..Vendedores.deleted,
                TNGS_Carm..Vendedores.usuario,
                TNGS_Carm..Vendedores.version
           from TNGS_Carm..Vendedores
                join TNGS_Carm..TipoVend
                  on vnd_rcd_codtvend = tvn_rcd_cod
                join TNGS_Carm..Supervisores
                  on vnd_cd6_codsuperv = sup_cd6_cod
          order by vnd_cd6_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.VENDEDORES_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@vnd_cd6_cod">Código</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.VENDEDORES_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.VENDEDORES_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.VENDEDORES_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.VENDEDORES_CHKVERSION
(
@vnd_cd6_cod tngs_codigo_6,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Carm..Vendedores
    where vnd_cd6_cod = @vnd_cd6_cod
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.VENDEDORES_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@vnd_cd6_cod">Código</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.VENDEDORES_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.VENDEDORES_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.VENDEDORES_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.VENDEDORES_SEARCH
(
@vnd_cd6_cod tngs_codigo_6,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select vnd_cd6_cod,
                vnd_des_apellido,
                vnd_des_nombre,
                vnd_nom_usuario,
                TNGS_Carm.dbo.VENDEDORES_GETFULLNAME(vnd_cd6_cod) as vnd_ede_nya,
                vnd_tel_tel1,
                vnd_tel_celular,
                vnd_tel_tel2,
                vnd_fec_fecnacim,
                vnd_ede_direccion,
                vnd_cd6_codsuperv,
                rtrim(sup_nom_nombre) + ' '+ sup_nom_apellido as vnd_nom_superv,
                vnd_rcd_codtvend,
                tvn_cd1_vemayor as vnd_cd1_vemayor,
                tvn_des_des as vnd_des_tipovnd,
                vnd_txt_horarios,
                vnd_cd1_historico,
                TNGS_Carm..Vendedores.instante,
                TNGS_Carm..Vendedores.deleted,
                TNGS_Carm..Vendedores.usuario,
                TNGS_Carm..Vendedores.version
           from TNGS_Carm..Vendedores
                join TNGS_Carm..TipoVend
                  on vnd_rcd_codtvend = tvn_rcd_cod
                join TNGS_Carm..Supervisores
                  on vnd_cd6_codsuperv = sup_cd6_cod
          where vnd_cd6_cod = @vnd_cd6_cod
            and TNGS_Carm..Vendedores.deleted = 0
      end
   else
      begin
         Select vnd_cd6_cod,
                vnd_des_apellido,
                vnd_des_nombre,
                vnd_nom_usuario,
                TNGS_Carm.dbo.VENDEDORES_GETFULLNAME(vnd_cd6_cod) as vnd_ede_nya,
                vnd_tel_tel1,
                vnd_tel_celular,
                vnd_tel_tel2,
                vnd_fec_fecnacim,
                vnd_ede_direccion,
                vnd_cd6_codsuperv,
                rtrim(sup_nom_nombre) + ' '+ sup_nom_apellido as vnd_nom_superv,
                vnd_rcd_codtvend,
                tvn_cd1_vemayor as vnd_cd1_vemayor,
                tvn_des_des as vnd_des_tipovnd,
                vnd_txt_horarios,
                vnd_cd1_historico,
                TNGS_Carm..Vendedores.instante,
                TNGS_Carm..Vendedores.deleted,
                TNGS_Carm..Vendedores.usuario,
                TNGS_Carm..Vendedores.version
           from TNGS_Carm..Vendedores
                join TNGS_Carm..TipoVend
                  on vnd_rcd_codtvend = tvn_rcd_cod
                join TNGS_Carm..Supervisores
                  on vnd_cd6_codsuperv = sup_cd6_cod
          where vnd_cd6_cod = @vnd_cd6_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.VENDEDORES_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@vnd_cd6_cod">Código</param>
--- <param name="@vnd_des_apellido">Apellido</param>
--- <param name="@vnd_des_nombre">Nombre</param>
--- <param name="@vnd_nom_usuario">Usuario Sistema</param>
--- <param name="@vnd_tel_tel1">Telefono1</param>
--- <param name="@vnd_tel_celular">Celular</param>
--- <param name="@vnd_tel_tel2">Telefono2</param>
--- <param name="@vnd_fec_fecnacim">Fecha Nacimiento</param>
--- <param name="@vnd_ede_direccion">Dirección</param>
--- <param name="@vnd_cd6_codsuperv">Supervisor</param>
--- <param name="@vnd_rcd_codtvend">Tipo Vendedor</param>
--- <param name="@vnd_txt_horarios">Horarios</param>
--- <param name="@vnd_cd1_historico">Es Historico</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.VENDEDORES_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.VENDEDORES_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.VENDEDORES_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.VENDEDORES_INSERT
(
@vnd_cd6_cod tngs_codigo_6,
@vnd_des_apellido tngs_descripcion,
@vnd_des_nombre tngs_descripcion,
@vnd_nom_usuario tngs_nombre,
@vnd_tel_tel1 tngs_telefono,
@vnd_tel_celular tngs_telefono,
@vnd_tel_tel2 tngs_telefono,
@vnd_fec_fecnacim tngs_fecha,
@vnd_ede_direccion tngs_descripcion_e,
@vnd_cd6_codsuperv tngs_codigo_6,
@vnd_rcd_codtvend tngs_codigo_r,
@vnd_txt_horarios tngs_texto,
@vnd_cd1_historico tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Carm..Vendedores
   values (
           @vnd_cd6_cod,
           @vnd_des_apellido,
           @vnd_des_nombre,
           @vnd_nom_usuario,
           @vnd_tel_tel1,
           @vnd_tel_celular,
           @vnd_tel_tel2,
           @vnd_fec_fecnacim,
           @vnd_ede_direccion,
           @vnd_cd6_codsuperv,
           @vnd_rcd_codtvend,
           @vnd_txt_horarios,
           @vnd_cd1_historico,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.VENDEDORES_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@vnd_cd6_cod">Código</param>
--- <param name="@vnd_des_apellido">Apellido</param>
--- <param name="@vnd_des_nombre">Nombre</param>
--- <param name="@vnd_nom_usuario">Usuario Sistema</param>
--- <param name="@vnd_tel_tel1">Telefono1</param>
--- <param name="@vnd_tel_celular">Celular</param>
--- <param name="@vnd_tel_tel2">Telefono2</param>
--- <param name="@vnd_fec_fecnacim">Fecha Nacimiento</param>
--- <param name="@vnd_ede_direccion">Dirección</param>
--- <param name="@vnd_cd6_codsuperv">Supervisor</param>
--- <param name="@vnd_rcd_codtvend">Tipo Vendedor</param>
--- <param name="@vnd_txt_horarios">Horarios</param>
--- <param name="@vnd_cd1_historico">Es Historico</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.VENDEDORES_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.VENDEDORES_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.VENDEDORES_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.VENDEDORES_UPDATE
(
@vnd_cd6_cod tngs_codigo_6,
@vnd_des_apellido tngs_descripcion,
@vnd_des_nombre tngs_descripcion,
@vnd_nom_usuario tngs_nombre,
@vnd_tel_tel1 tngs_telefono,
@vnd_tel_celular tngs_telefono,
@vnd_tel_tel2 tngs_telefono,
@vnd_fec_fecnacim tngs_fecha,
@vnd_ede_direccion tngs_descripcion_e,
@vnd_cd6_codsuperv tngs_codigo_6,
@vnd_rcd_codtvend tngs_codigo_r,
@vnd_txt_horarios tngs_texto,
@vnd_cd1_historico tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Vendedores
      set vnd_des_apellido= @vnd_des_apellido,
          vnd_des_nombre= @vnd_des_nombre,
          vnd_nom_usuario= @vnd_nom_usuario,
          vnd_tel_tel1= @vnd_tel_tel1,
          vnd_tel_celular= @vnd_tel_celular,
          vnd_tel_tel2= @vnd_tel_tel2,
          vnd_fec_fecnacim= @vnd_fec_fecnacim,
          vnd_ede_direccion= @vnd_ede_direccion,
          vnd_cd6_codsuperv= @vnd_cd6_codsuperv,
          vnd_rcd_codtvend= @vnd_rcd_codtvend,
          vnd_txt_horarios= @vnd_txt_horarios,
          vnd_cd1_historico= @vnd_cd1_historico,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where vnd_cd6_cod = @vnd_cd6_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.VENDEDORES_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@vnd_cd6_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.VENDEDORES_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.VENDEDORES_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.VENDEDORES_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.VENDEDORES_DELETE
(
@vnd_cd6_cod tngs_codigo_6,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Vendedores
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where vnd_cd6_cod = @vnd_cd6_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.VENDEDORES_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@vnd_cd6_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.VENDEDORES_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.VENDEDORES_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.VENDEDORES_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.VENDEDORES_RECALL
(
@vnd_cd6_cod tngs_codigo_6,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Vendedores
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where vnd_cd6_cod = @vnd_cd6_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.VENDEDORES_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@vnd_cd6_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.VENDEDORES_DROP'

if exists (select * from sysobjects where id = object_id('dbo.VENDEDORES_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.VENDEDORES_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.VENDEDORES_DROP
(
@vnd_cd6_cod tngs_codigo_6,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..Vendedores
    where vnd_cd6_cod = @vnd_cd6_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.VENDEDORES_DROP to tngsmodulos

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

print 'Store Procedure: dbo.VENDEDORES_PACK'

if exists (select * from sysobjects where id = object_id('dbo.VENDEDORES_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.VENDEDORES_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.VENDEDORES_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Carm..Vendedores
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.VENDEDORES_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: GetCodVend
--- </summary>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.VENDEDORES_GETCODVEND'

if exists (select * from sysobjects where id = object_id('dbo.VENDEDORES_GETCODVEND'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.VENDEDORES_GETCODVEND
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.VENDEDORES_GETCODVEND
(
@usuario tngs_nombre
)
as
begin

   select 
   		vnd_cd6_cod 
   	from 
   		TNGS_Carm..Vendedores 
   	where 
   		vnd_nom_usuario = @usuario 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.VENDEDORES_GETCODVEND to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: GetEntrevistas
--- </summary>
--- <param name="@codvend">Código de vendedor</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.VENDEDORES_GETENTREVISTAS'

if exists (select * from sysobjects where id = object_id('dbo.VENDEDORES_GETENTREVISTAS'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.VENDEDORES_GETENTREVISTAS
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.VENDEDORES_GETENTREVISTAS
(
@codvend tngs_codigo_6,
@usuario tngs_nombre
)
as
begin

   SELECT 
    cli_ede_rsocial, 
    cle_fyh_fcoordinada, 
    case when year(cle_fyh_frealizada) = 1900 
      then 
       'Pendiente' 
      else 
       'Realizada' 
      end AS cle_des_estado, 
       cle_des_nombre, 
       cle_des_cargo, 
       cle_xld_direccion, 
    isnull(ren_des_des, '') as ren_des_des 
    
          FROM TNGS_Carm..Clientes 
    
    JOIN TNGS_Carm..CliEntrevistas 
     ON cli_nro_numero = cle_nro_numcliente 
    LEFT OUTER JOIN TNGS_Carm..ResEntrevista 
     ON ren_rcd_cod = cle_rcd_codresultado 
    
        WHERE cli_cd6_codvend = @codvend 
    
         ORDER BY cle_des_estado ASC, cli_ede_rsocial DESC, cle_fyh_fcoordinada DESC 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.VENDEDORES_GETENTREVISTAS to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: GetEntrevistasHist
--- </summary>
--- <param name="@codvend">Código de vendedor</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.VENDEDORES_GETENTREVISTASHIST'

if exists (select * from sysobjects where id = object_id('dbo.VENDEDORES_GETENTREVISTASHIST'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.VENDEDORES_GETENTREVISTASHIST
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.VENDEDORES_GETENTREVISTASHIST
(
@codvend tngs_codigo_6,
@usuario tngs_nombre
)
as
begin

   SELECT 
   	cli_ede_rsocial, 
       cle_fyh_fcoordinada, 
   	case when year(cle_fyh_frealizada) = 1900 
   		then 
   			'Pendiente' 
   		else 
   			'Realizada' 
   	end AS cle_des_estado, 
       cle_des_nombre, 
       cle_des_cargo, 
       cle_xld_direccion, 
   	isnull(ren_des_des, '') as ren_des_des 
    
       FROM TNGS_Carm..CliEntrevistas 
    
   	JOIN TNGS_Carm..Clientes 
   		ON cli_nro_numero = cle_nro_numcliente 
   	LEFT OUTER JOIN TNGS_Carm..ResEntrevista 
   		ON ren_rcd_cod = cle_rcd_codresultado 
    
        WHERE cle_cd6_codvend = @codvend 
    
         ORDER BY cle_des_estado ASC, cli_ede_rsocial DESC, cle_fyh_fcoordinada DESC 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.VENDEDORES_GETENTREVISTASHIST to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: GetLlamadas
--- </summary>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.VENDEDORES_GETLLAMADAS'

if exists (select * from sysobjects where id = object_id('dbo.VENDEDORES_GETLLAMADAS'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.VENDEDORES_GETLLAMADAS
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.VENDEDORES_GETLLAMADAS
(
@usuario tngs_nombre
)
as
begin

   SELECT 
     cli_nro_numero, 
     cli_ede_rsocial, 
     mot_des_des, 
     ctl_cd1_tipo, 
     cll_fyh_frealizada, 
     cll_txt_resultado 
    
    FROM TNGS_Carm..CliLlamadas 
    
    JOIN TNGS_Carm..Clientes 
     ON cll_nro_numcliente = cli_nro_numero 
    JOIN TNGS_Carm..MotivosLlamada 
     ON cll_cod_codmotivo = mot_cod_cod 
    Join TNGS_Carm..CategoriasLlamada 
     ON ctl_rcd_cod = mot_rcd_codcategoria 
    
     WHERE cll_nom_codusuario = 'MATI' 
    
    ORDER BY cll_fyh_frealizada DESC 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.VENDEDORES_GETLLAMADAS to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: GetSolicitudes
--- </summary>
--- <param name="@codvend">Código de vendedor</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.VENDEDORES_GETSOLICITUDES'

if exists (select * from sysobjects where id = object_id('dbo.VENDEDORES_GETSOLICITUDES'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.VENDEDORES_GETSOLICITUDES
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.VENDEDORES_GETSOLICITUDES
(
@codvend tngs_codigo_6,
@usuario tngs_nombre
)
as
begin

   SELECT 
    cli_ede_rsocial, 
    sol_fyh_fproceso, 
    sol_nom_autorizador, 
    case when sol_cd1_estado = 'A' 
      then 
       'Aprobado' 
      when sol_cd1_estado = 'R' 
      then 
       'Rechazado' 
      when sol_cd1_estado = 'P' 
      then 
       'Pendiente' 
     end AS sol_des_estado, 
    sol_xde_obssol, 
    sol_xde_obsaut 
    
    FROM TNGS_Carm..Solicitudes 
    
    JOIN TNGS_Carm..Clientes 
     ON sol_nro_numcliente = cli_nro_numero 
    
    WHERE 
     sol_cd6_codvend = @codvend 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.VENDEDORES_GETSOLICITUDES to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: GetVendedorFromUsu
--- </summary>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.VENDEDORES_GETVENDEDORFROMUSU'

if exists (select * from sysobjects where id = object_id('dbo.VENDEDORES_GETVENDEDORFROMUSU'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.VENDEDORES_GETVENDEDORFROMUSU
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.VENDEDORES_GETVENDEDORFROMUSU
(
@usuario tngs_nombre
)
as
begin

   Select vnd_cd6_cod,
          vnd_des_apellido,
          vnd_des_nombre,
          vnd_nom_usuario,
          TNGS_Carm.dbo.VENDEDORES_GETFULLNAME(vnd_cd6_cod) as vnd_ede_nya,
          vnd_tel_tel1,
          vnd_tel_celular,
          vnd_tel_tel2,
          vnd_fec_fecnacim,
          vnd_ede_direccion,
          vnd_cd6_codsuperv,
          rtrim(sup_nom_nombre) + ' '+ sup_nom_apellido as vnd_nom_superv,
          vnd_rcd_codtvend,
          tvn_cd1_vemayor as vnd_cd1_vemayor,
          tvn_des_des as vnd_des_tipovnd,
          vnd_txt_horarios,
          vnd_cd1_historico,
          TNGS_Carm..Vendedores.instante,
          TNGS_Carm..Vendedores.deleted,
          TNGS_Carm..Vendedores.usuario,
          TNGS_Carm..Vendedores.version
     from TNGS_Carm..Vendedores 
          join TNGS_Carm..TipoVend
            on vnd_rcd_codtvend = tvn_rcd_cod
          join TNGS_Carm..Supervisores
            on vnd_cd6_codsuperv = sup_cd6_cod
   where vnd_nom_usuario = @usuario 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.VENDEDORES_GETVENDEDORFROMUSU to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: ZEntrevistasBasico
--- </summary>
--- <param name="@fechaini">Fecha Inicio de busqueda</param>
--- <param name="@fechafin">Fecha Fin de busqueda</param>
--- <param name="@codinivendedor">Codigo inicial Vendedor</param>
--- <param name="@codfinvendedor">Codigo Fin Vendedor</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.VENDEDORES_ZENTREVISTASBASICO'

if exists (select * from sysobjects where id = object_id('dbo.VENDEDORES_ZENTREVISTASBASICO'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.VENDEDORES_ZENTREVISTASBASICO
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.VENDEDORES_ZENTREVISTASBASICO
(
@fechaini tngs_fecyhor,
@fechafin tngs_fecyhor,
@codinivendedor tngs_codigo_6,
@codfinvendedor tngs_codigo_6,
@usuario tngs_nombre
)
as
begin

   select  cli_ede_rsocial, 
           TNGS_Carm.dbo.VENDEDORES_GETFULLNAME(vnd_cd6_cod) as vnd_apeynom, 
   		cle_des_nombre, 
           cle_des_cargo, 
           cle_fyh_frealizada, 
           ren_des_des, 
           cle_ede_informe, 
           mrc_des_des 
    
       from CliEntrevistas 
    
   join Clientes on cli_nro_numero = cle_nro_numcliente 
   join Vendedores on vnd_cd6_cod = cle_cd6_codvend 
   join ResEntrevista on ren_rcd_cod = cle_rcd_codresultado 
   left outer join Marcas on mrc_rcd_cod = cli_rcd_codmarca 
    
   where vnd_cd6_cod between @codinivendedor and @codfinvendedor 
       and cle_fyh_frealizada > @fechaini 
       and cle_fyh_frealizada < @fechafin 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.VENDEDORES_ZENTREVISTASBASICO to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: ZLlamadasProgramadas
--- </summary>
--- <param name="@usuarioprogramador">Usuario que programo la llamada</param>
--- <param name="@fechaini">Fecha inicial</param>
--- <param name="@fechafin">Fecha fin</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.VENDEDORES_ZLLAMADASPROGRAMADAS'

if exists (select * from sysobjects where id = object_id('dbo.VENDEDORES_ZLLAMADASPROGRAMADAS'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.VENDEDORES_ZLLAMADASPROGRAMADAS
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.VENDEDORES_ZLLAMADASPROGRAMADAS
(
@usuarioprogramador tngs_nombre,
@fechaini tngs_fecha,
@fechafin tngs_fecha,
@usuario tngs_nombre
)
as
begin

   select cll_nro_numcliente, cll_nro_numllamada, cll_nom_codusuario, cll_fyh_frealizada, 
   	   case when cll_cod_codmotivo = '' then 'N' else 'S' end as completada, cll_txt_obsprogramada, 
   	   mrc_des_des 
    from CliLlamadas 
    join Clientes on cll_nro_numcliente = cli_nro_numero 
    left outer join Marcas on mrc_rcd_cod = cli_rcd_codmarca 
   where cll_nom_programador = @usuarioprogramador 
   and cll_fyh_frealizada between @fechaini and @fechafin 
    

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.VENDEDORES_ZLLAMADASPROGRAMADAS to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: ZLlamados
--- </summary>
--- <param name="@fechaini">Fecha de Inicio Busqueda</param>
--- <param name="@fechafin">Fecha de Fin Busqueda</param>
--- <param name="@tipo">Tipo de Llamadas (E/S)</param>
--- <param name="@codcatini">Codigo Categoria Ini</param>
--- <param name="@codcatfin">Codigo Categoria Fin</param>
--- <param name="@codinivendedor">Codigo inicial Vendedor</param>
--- <param name="@codfinvendedor">Codigo Vendedor Fin</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.VENDEDORES_ZLLAMADOS'

if exists (select * from sysobjects where id = object_id('dbo.VENDEDORES_ZLLAMADOS'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.VENDEDORES_ZLLAMADOS
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.VENDEDORES_ZLLAMADOS
(
@fechaini tngs_fecyhor,
@fechafin tngs_fecyhor,
@tipo tngs_codigo_1,
@codcatini tngs_codigo_r,
@codcatfin tngs_codigo_r,
@codinivendedor tngs_codigo_6,
@codfinvendedor tngs_codigo_6,
@usuario tngs_nombre
)
as
begin

    
   select cli_nro_nroavalon, 
          cli_ede_rsocial, 
   	   TNGS_Carm.dbo.VENDEDORES_GETFULLNAME(vnd_cd6_cod) as vnd_apeynom, 
   	   ctl_des_des, 
   	   TNGS_Carm.dbo.CATEGORIASLLAMADA_GETTIPO(ctl_cd1_tipo) as mot_tipo, 
   	   mot_des_des, 
   	   cll_fyh_frealizada, 
   	   cll_txt_resultado, 
   	   mrc_des_des 
   	 
       from CliLlamadas 
   join Vendedores on cll_nom_codusuario = vnd_nom_usuario 
   join Clientes on cli_nro_numero = cll_nro_numcliente 
   join MotivosLlamada on cll_cod_codmotivo = mot_cod_cod 
   join CategoriasLlamada on ctl_rcd_cod = mot_rcd_codcategoria 
   left outer join Marcas on mrc_rcd_cod = cli_rcd_codmarca 
   where cll_fyh_frealizada > @fechaini and 
   	  cll_fyh_frealizada < @fechafin and 
   	  ctl_cd1_tipo <> @tipo and 
   	  vnd_cd6_cod between @codinivendedor and @codfinvendedor and 
         ctl_rcd_cod between @codcatini and @codcatfin 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.VENDEDORES_ZLLAMADOS to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: ZReservasBasico
--- </summary>
--- <param name="@codvendini">Codigo Inicial de Vendedor</param>
--- <param name="@codvendfin">Codigo Final de Vendedor</param>
--- <param name="@fechaini">Fecha Inicial de Reservas</param>
--- <param name="@fechafin">Fecha Final de Reservas</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.VENDEDORES_ZRESERVASBASICO'

if exists (select * from sysobjects where id = object_id('dbo.VENDEDORES_ZRESERVASBASICO'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.VENDEDORES_ZRESERVASBASICO
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.VENDEDORES_ZRESERVASBASICO
(
@codvendini tngs_codigo_6,
@codvendfin tngs_codigo_6,
@fechaini tngs_fecyhor,
@fechafin tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   select TNGS_Carm.dbo.VENDEDORES_GETFULLNAME(vnd_cd6_cod) as vnd_apeynom, cli_ede_rsocial, 
   		tin_des_des,sol_fyh_fgeneracion as sol_finires, cli_fec_ffinres as sol_ffinres, 
   		mrc_des_des 
       from Solicitudes 
   join Clientes on cli_nro_numero = sol_nro_numcliente 
   join TipoInst on cli_cod_codtinst = tin_cod_cod 
   join Vendedores on vnd_cd6_cod = sol_cd6_codvend 
   left outer join Marcas on mrc_rcd_cod = cli_rcd_codmarca 
   where vnd_cd6_cod between @codvendini and @codvendfin 
       and sol_fyh_fproceso > @fechaini 
       and sol_fyh_fproceso < @fechafin 
   order by tin_des_des 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.VENDEDORES_ZRESERVASBASICO to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: ZVencidas
--- </summary>
--- <param name="@codvendini">Codigo Vendedor Inicial</param>
--- <param name="@codvendfin">Codigo Vendedor Fin</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.VENDEDORES_ZVENCIDAS'

if exists (select * from sysobjects where id = object_id('dbo.VENDEDORES_ZVENCIDAS'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.VENDEDORES_ZVENCIDAS
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.VENDEDORES_ZVENCIDAS
(
@codvendini tngs_codigo_6,
@codvendfin tngs_codigo_6,
@usuario tngs_nombre
)
as
begin

   select TNGS_Carm.dbo.VENDEDORES_GETFULLNAME(vnd_cd6_cod) as vnd_apeynom, cli_ede_rsocial, 
           cle_fyh_fcoordinada as cle_fcoord, sol_fyh_fgeneracion as sol_finires, 
           cli_fec_ffinres as sol_ffinres, mrc_des_des 
       from Solicitudes 
   join Clientes on cli_nro_numero = sol_nro_numcliente 
   join Vendedores on vnd_cd6_cod = sol_cd6_codvend 
   join CliEntrevistas on cli_nro_numero = cle_nro_numcliente 
   left outer join Marcas on mrc_rcd_cod = cli_rcd_codmarca 
   where vnd_cd6_cod between @codvendini and @codvendfin and 
   	  cli_fec_ffinres < GETDATE() and year(cli_fec_ffinres) <> 1900 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.VENDEDORES_ZVENCIDAS to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: ZVentas
--- </summary>
--- <param name="@fechaini">Fecha Inicial de la busqueda</param>
--- <param name="@fechafin">Fecha Fianl de la busqueda</param>
--- <param name="@codvendini">Codigo Inicial de Vendedor</param>
--- <param name="@codvendfin">Codigo Final de Vendedor</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.VENDEDORES_ZVENTAS'

if exists (select * from sysobjects where id = object_id('dbo.VENDEDORES_ZVENTAS'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.VENDEDORES_ZVENTAS
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.VENDEDORES_ZVENTAS
(
@fechaini tngs_fecyhor,
@fechafin tngs_fecyhor,
@codvendini tngs_codigo_6,
@codvendfin tngs_codigo_6,
@usuario tngs_nombre
)
as
begin

   select cle_nro_numcliente as nroCliente, 
   	   max(cle_cd6_codvend) as codVendedor, 
   	   max(vnd_cd6_codsuperv) as codSupervisorVendedor, 
   	   max(vnd_des_apellido) as apellidoVendedor 
     into #matTemp01 
     from CliEntrevistas 
     join ResEntrevista on cle_rcd_codresultado = ren_rcd_cod 
     join Vendedores on vnd_cd6_cod = cle_cd6_codvend 
     join Clientes on cli_nro_numero = cle_nro_numcliente 
    where ren_cd1_codfiltro = 'S' and cle_fyh_frealizada between @fechaini and @fechafin 
    group by cle_nro_numcliente 
    
    
    
    
    select 
   		max(mrc_des_des) as mrc_des_des, 
   	    max(rtrim(sup_nom_apellido) + ' '+ sup_nom_nombre ) as sup_nom_nomyape, 
   	    max(apellidoVendedor)as vnd_des_apellido, 
           count(distinct cli_nro_numero) as cantidad, 
           sum(clv_imp_abono) as clv_imp_abono 
     from CliVentas 
          join Clientes 
               join #matTemp01 
                 on cli_nro_numero = nroCliente 
            on cli_nro_numero = clv_nro_numcliente 
    
          left outer join Supervisores 
   	     on sup_cd6_cod = codSupervisorVendedor 
   where codVendedor between @codvendini and @codvendfin 
   order by clv_imp_abono desc 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.VENDEDORES_ZVENTAS to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: ZVentasDetalle
--- </summary>
--- <param name="@fechaini">Fecha Inicial de la busqueda</param>
--- <param name="@fechafin">Fecha Fianl de la busqueda</param>
--- <param name="@codvendini">Codigo Inicial de Vendedor</param>
--- <param name="@codvendfin">Codigo Final de Vendedor</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.VENDEDORES_ZVENTASDETALLE'

if exists (select * from sysobjects where id = object_id('dbo.VENDEDORES_ZVENTASDETALLE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.VENDEDORES_ZVENTASDETALLE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.VENDEDORES_ZVENTASDETALLE
(
@fechaini tngs_fecyhor,
@fechafin tngs_fecyhor,
@codvendini tngs_codigo_6,
@codvendfin tngs_codigo_6,
@usuario tngs_nombre
)
as
begin

   select cli_nro_numero, cli_nro_nroavalon, cli_ede_rsocial, mrc_des_des, clv_imp_abono, vnd_des_apellido, vnd_des_nombre from CliVentas 
   join Clientes on cli_nro_numero = clv_nro_numcliente 
   join Vendedores on vnd_cd6_cod = clv_cd6_codvendedor 
   join Marcas on cli_rcd_codmarca = mrc_rcd_cod 
   where clv_fyh_fecha between @fechaini and @fechafin 
     and clv_cd6_codvendedor between @codvendini and @codvendfin 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.VENDEDORES_ZVENTASDETALLE to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Vendedores
//--------------------------------------------------------------------------*/
