/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 20/09/2020 20:59
// Sistema     : Carm
// Tabla       : CliLlamadas
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

print 'Store Procedure: dbo.CLILLAMADAS_UP'

if exists (select * from sysobjects where id = object_id('dbo.CLILLAMADAS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLILLAMADAS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLILLAMADAS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select cll_nro_numcliente,
                cli_ede_rsocial as cll_ede_rsocial,
                cll_nro_numllamada,
                cll_cod_codmotivo,
                isnull(mot_des_des, '') as cll_des_motivo,
                cll_fyh_frealizada,
                cll_txt_resultado,
                cll_nom_codusuario,
                cll_cd1_baja,
                cll_nro_numcontacto,
                clc_des_nombre as cll_nom_contac,
                cll_txt_obsprogramada,
                cll_imp_abonoanterior,
                cll_imp_abonorecuperado,
                cll_nom_programador,
                cll_imp_ajuste,
                TNGS_Carm..CliLlamadas.instante,
                TNGS_Carm..CliLlamadas.deleted,
                TNGS_Carm..CliLlamadas.usuario,
                TNGS_Carm..CliLlamadas.version
           from TNGS_Carm..CliLlamadas
                left outer join TNGS_Carm..MotivosLlamada
                  on cll_cod_codmotivo = mot_cod_cod
                join TNGS_Carm..Clientes
                  on cll_nro_numcliente = cli_nro_numero
                join TNGS_Carm..CliContactos
                  on cll_nro_numcliente = clc_nro_numcliente
                 and cll_nro_numcontacto = clc_nro_numcontacto
          where TNGS_Carm..CliLlamadas.deleted = 0
          order by cll_nro_numcliente,
                cll_nro_numllamada
      end
   else
      begin
         Select cll_nro_numcliente,
                cli_ede_rsocial as cll_ede_rsocial,
                cll_nro_numllamada,
                cll_cod_codmotivo,
                isnull(mot_des_des, '') as cll_des_motivo,
                cll_fyh_frealizada,
                cll_txt_resultado,
                cll_nom_codusuario,
                cll_cd1_baja,
                cll_nro_numcontacto,
                clc_des_nombre as cll_nom_contac,
                cll_txt_obsprogramada,
                cll_imp_abonoanterior,
                cll_imp_abonorecuperado,
                cll_nom_programador,
                cll_imp_ajuste,
                TNGS_Carm..CliLlamadas.instante,
                TNGS_Carm..CliLlamadas.deleted,
                TNGS_Carm..CliLlamadas.usuario,
                TNGS_Carm..CliLlamadas.version
           from TNGS_Carm..CliLlamadas
                left outer join TNGS_Carm..MotivosLlamada
                  on cll_cod_codmotivo = mot_cod_cod
                join TNGS_Carm..Clientes
                  on cll_nro_numcliente = cli_nro_numero
                join TNGS_Carm..CliContactos
                  on cll_nro_numcliente = clc_nro_numcliente
                 and cll_nro_numcontacto = clc_nro_numcontacto
          order by cll_nro_numcliente,
                cll_nro_numllamada
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLILLAMADAS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@cll_nro_numcliente">Número de cliente</param>
--- <param name="@cll_nro_numllamada">Número de llamada</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLILLAMADAS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.CLILLAMADAS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLILLAMADAS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLILLAMADAS_CHKVERSION
(
@cll_nro_numcliente tngs_numero,
@cll_nro_numllamada tngs_numero,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Carm..CliLlamadas
    where cll_nro_numcliente = @cll_nro_numcliente
      and cll_nro_numllamada = @cll_nro_numllamada
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLILLAMADAS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@cll_nro_numcliente">Número de cliente</param>
--- <param name="@cll_nro_numllamada">Número de llamada</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLILLAMADAS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.CLILLAMADAS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLILLAMADAS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLILLAMADAS_SEARCH
(
@cll_nro_numcliente tngs_numero,
@cll_nro_numllamada tngs_numero,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select cll_nro_numcliente,
                cli_ede_rsocial as cll_ede_rsocial,
                cll_nro_numllamada,
                cll_cod_codmotivo,
                isnull(mot_des_des, '') as cll_des_motivo,
                cll_fyh_frealizada,
                cll_txt_resultado,
                cll_nom_codusuario,
                cll_cd1_baja,
                cll_nro_numcontacto,
                clc_des_nombre as cll_nom_contac,
                cll_txt_obsprogramada,
                cll_imp_abonoanterior,
                cll_imp_abonorecuperado,
                cll_nom_programador,
                cll_imp_ajuste,
                TNGS_Carm..CliLlamadas.instante,
                TNGS_Carm..CliLlamadas.deleted,
                TNGS_Carm..CliLlamadas.usuario,
                TNGS_Carm..CliLlamadas.version
           from TNGS_Carm..CliLlamadas
                left outer join TNGS_Carm..MotivosLlamada
                  on cll_cod_codmotivo = mot_cod_cod
                join TNGS_Carm..Clientes
                  on cll_nro_numcliente = cli_nro_numero
                join TNGS_Carm..CliContactos
                  on cll_nro_numcliente = clc_nro_numcliente
                 and cll_nro_numcontacto = clc_nro_numcontacto
          where cll_nro_numcliente = @cll_nro_numcliente
            and cll_nro_numllamada = @cll_nro_numllamada
            and TNGS_Carm..CliLlamadas.deleted = 0
      end
   else
      begin
         Select cll_nro_numcliente,
                cli_ede_rsocial as cll_ede_rsocial,
                cll_nro_numllamada,
                cll_cod_codmotivo,
                isnull(mot_des_des, '') as cll_des_motivo,
                cll_fyh_frealizada,
                cll_txt_resultado,
                cll_nom_codusuario,
                cll_cd1_baja,
                cll_nro_numcontacto,
                clc_des_nombre as cll_nom_contac,
                cll_txt_obsprogramada,
                cll_imp_abonoanterior,
                cll_imp_abonorecuperado,
                cll_nom_programador,
                cll_imp_ajuste,
                TNGS_Carm..CliLlamadas.instante,
                TNGS_Carm..CliLlamadas.deleted,
                TNGS_Carm..CliLlamadas.usuario,
                TNGS_Carm..CliLlamadas.version
           from TNGS_Carm..CliLlamadas
                left outer join TNGS_Carm..MotivosLlamada
                  on cll_cod_codmotivo = mot_cod_cod
                join TNGS_Carm..Clientes
                  on cll_nro_numcliente = cli_nro_numero
                join TNGS_Carm..CliContactos
                  on cll_nro_numcliente = clc_nro_numcliente
                 and cll_nro_numcontacto = clc_nro_numcontacto
          where cll_nro_numcliente = @cll_nro_numcliente
            and cll_nro_numllamada = @cll_nro_numllamada
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLILLAMADAS_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca los registros de una clave foranea
--- </summary>
--- <param name="@cll_nro_numcliente">Número de cliente</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLILLAMADAS_FSEARCH'

if exists (select * from sysobjects where id = object_id('dbo.CLILLAMADAS_FSEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLILLAMADAS_FSEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLILLAMADAS_FSEARCH
(
@cll_nro_numcliente tngs_numero,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select cll_nro_numcliente,
                cli_ede_rsocial as cll_ede_rsocial,
                cll_nro_numllamada,
                cll_cod_codmotivo,
                isnull(mot_des_des, '') as cll_des_motivo,
                cll_fyh_frealizada,
                cll_txt_resultado,
                cll_nom_codusuario,
                cll_cd1_baja,
                cll_nro_numcontacto,
                clc_des_nombre as cll_nom_contac,
                cll_txt_obsprogramada,
                cll_imp_abonoanterior,
                cll_imp_abonorecuperado,
                cll_nom_programador,
                cll_imp_ajuste,
                TNGS_Carm..CliLlamadas.instante,
                TNGS_Carm..CliLlamadas.deleted,
                TNGS_Carm..CliLlamadas.usuario,
                TNGS_Carm..CliLlamadas.version
           from TNGS_Carm..CliLlamadas
                left outer join TNGS_Carm..MotivosLlamada
                  on cll_cod_codmotivo = mot_cod_cod
                join TNGS_Carm..Clientes
                  on cll_nro_numcliente = cli_nro_numero
                join TNGS_Carm..CliContactos
                  on cll_nro_numcliente = clc_nro_numcliente
                 and cll_nro_numcontacto = clc_nro_numcontacto
          where cll_nro_numcliente = @cll_nro_numcliente
            and TNGS_Carm..CliLlamadas.deleted = 0
          order by cll_nro_numllamada
      end
   else
      begin
         Select cll_nro_numcliente,
                cli_ede_rsocial as cll_ede_rsocial,
                cll_nro_numllamada,
                cll_cod_codmotivo,
                isnull(mot_des_des, '') as cll_des_motivo,
                cll_fyh_frealizada,
                cll_txt_resultado,
                cll_nom_codusuario,
                cll_cd1_baja,
                cll_nro_numcontacto,
                clc_des_nombre as cll_nom_contac,
                cll_txt_obsprogramada,
                cll_imp_abonoanterior,
                cll_imp_abonorecuperado,
                cll_nom_programador,
                cll_imp_ajuste,
                TNGS_Carm..CliLlamadas.instante,
                TNGS_Carm..CliLlamadas.deleted,
                TNGS_Carm..CliLlamadas.usuario,
                TNGS_Carm..CliLlamadas.version
           from TNGS_Carm..CliLlamadas
                left outer join TNGS_Carm..MotivosLlamada
                  on cll_cod_codmotivo = mot_cod_cod
                join TNGS_Carm..Clientes
                  on cll_nro_numcliente = cli_nro_numero
                join TNGS_Carm..CliContactos
                  on cll_nro_numcliente = clc_nro_numcliente
                 and cll_nro_numcontacto = clc_nro_numcontacto
          where cll_nro_numcliente = @cll_nro_numcliente
          order by cll_nro_numllamada
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLILLAMADAS_FSEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@cll_nro_numcliente">Número de cliente</param>
--- <param name="@cll_nro_numllamada">Número de llamada</param>
--- <param name="@cll_cod_codmotivo">Código de motivo</param>
--- <param name="@cll_fyh_frealizada">Fecha Realizada</param>
--- <param name="@cll_txt_resultado">Resultado</param>
--- <param name="@cll_nom_codusuario">Código del usuario</param>
--- <param name="@cll_cd1_baja">Produjo Baja</param>
--- <param name="@cll_nro_numcontacto">Número de contacto</param>
--- <param name="@cll_txt_obsprogramada">Observación</param>
--- <param name="@cll_imp_abonoanterior">Abono Anterior</param>
--- <param name="@cll_imp_abonorecuperado">Abono Recuperador</param>
--- <param name="@cll_nom_programador">Usuario Programador</param>
--- <param name="@cll_imp_ajuste">Ajuste</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLILLAMADAS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.CLILLAMADAS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLILLAMADAS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLILLAMADAS_INSERT
(
@cll_nro_numcliente tngs_numero,
@cll_nro_numllamada tngs_numero,
@cll_cod_codmotivo tngs_codigo,
@cll_fyh_frealizada tngs_fecyhor,
@cll_txt_resultado tngs_texto,
@cll_nom_codusuario tngs_nombre,
@cll_cd1_baja tngs_codigo_1,
@cll_nro_numcontacto tngs_numero,
@cll_txt_obsprogramada tngs_texto,
@cll_imp_abonoanterior tngs_importe,
@cll_imp_abonorecuperado tngs_importe,
@cll_nom_programador tngs_nombre,
@cll_imp_ajuste tngs_importe,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Carm..CliLlamadas
   values (
           @cll_nro_numcliente,
           @cll_nro_numllamada,
           @cll_cod_codmotivo,
           @cll_fyh_frealizada,
           @cll_txt_resultado,
           @cll_nom_codusuario,
           @cll_cd1_baja,
           @cll_nro_numcontacto,
           @cll_txt_obsprogramada,
           @cll_imp_abonoanterior,
           @cll_imp_abonorecuperado,
           @cll_nom_programador,
           @cll_imp_ajuste,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLILLAMADAS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@cll_nro_numcliente">Número de cliente</param>
--- <param name="@cll_nro_numllamada">Número de llamada</param>
--- <param name="@cll_cod_codmotivo">Código de motivo</param>
--- <param name="@cll_fyh_frealizada">Fecha Realizada</param>
--- <param name="@cll_txt_resultado">Resultado</param>
--- <param name="@cll_nom_codusuario">Código del usuario</param>
--- <param name="@cll_cd1_baja">Produjo Baja</param>
--- <param name="@cll_nro_numcontacto">Número de contacto</param>
--- <param name="@cll_txt_obsprogramada">Observación</param>
--- <param name="@cll_imp_abonoanterior">Abono Anterior</param>
--- <param name="@cll_imp_abonorecuperado">Abono Recuperador</param>
--- <param name="@cll_nom_programador">Usuario Programador</param>
--- <param name="@cll_imp_ajuste">Ajuste</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLILLAMADAS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.CLILLAMADAS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLILLAMADAS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLILLAMADAS_UPDATE
(
@cll_nro_numcliente tngs_numero,
@cll_nro_numllamada tngs_numero,
@cll_cod_codmotivo tngs_codigo,
@cll_fyh_frealizada tngs_fecyhor,
@cll_txt_resultado tngs_texto,
@cll_nom_codusuario tngs_nombre,
@cll_cd1_baja tngs_codigo_1,
@cll_nro_numcontacto tngs_numero,
@cll_txt_obsprogramada tngs_texto,
@cll_imp_abonoanterior tngs_importe,
@cll_imp_abonorecuperado tngs_importe,
@cll_nom_programador tngs_nombre,
@cll_imp_ajuste tngs_importe,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..CliLlamadas
      set cll_cod_codmotivo= @cll_cod_codmotivo,
          cll_fyh_frealizada= @cll_fyh_frealizada,
          cll_txt_resultado= @cll_txt_resultado,
          cll_nom_codusuario= @cll_nom_codusuario,
          cll_cd1_baja= @cll_cd1_baja,
          cll_nro_numcontacto= @cll_nro_numcontacto,
          cll_txt_obsprogramada= @cll_txt_obsprogramada,
          cll_imp_abonoanterior= @cll_imp_abonoanterior,
          cll_imp_abonorecuperado= @cll_imp_abonorecuperado,
          cll_nom_programador= @cll_nom_programador,
          cll_imp_ajuste= @cll_imp_ajuste,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where cll_nro_numcliente = @cll_nro_numcliente
      and cll_nro_numllamada = @cll_nro_numllamada

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLILLAMADAS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@cll_nro_numcliente">Número de cliente</param>
--- <param name="@cll_nro_numllamada">Número de llamada</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLILLAMADAS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.CLILLAMADAS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLILLAMADAS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLILLAMADAS_DELETE
(
@cll_nro_numcliente tngs_numero,
@cll_nro_numllamada tngs_numero,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..CliLlamadas
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where cll_nro_numcliente = @cll_nro_numcliente
      and cll_nro_numllamada = @cll_nro_numllamada

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLILLAMADAS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro por clave foranea
--- </summary>
--- <param name="@cll_nro_numcliente">Número de cliente</param>
--- <param name="@instante">Instante del delete</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLILLAMADAS_FDELETE'

if exists (select * from sysobjects where id = object_id('dbo.CLILLAMADAS_FDELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLILLAMADAS_FDELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLILLAMADAS_FDELETE
(
@cll_nro_numcliente tngs_numero,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         select @instante= getdate()
      end

   Update TNGS_Carm..CliLlamadas
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= @instante,
          usuario = @usuario
    where cll_nro_numcliente = @cll_nro_numcliente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLILLAMADAS_FDELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@cll_nro_numcliente">Número de cliente</param>
--- <param name="@cll_nro_numllamada">Número de llamada</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLILLAMADAS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.CLILLAMADAS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLILLAMADAS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLILLAMADAS_RECALL
(
@cll_nro_numcliente tngs_numero,
@cll_nro_numllamada tngs_numero,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..CliLlamadas
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where cll_nro_numcliente = @cll_nro_numcliente
      and cll_nro_numllamada = @cll_nro_numllamada

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLILLAMADAS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera lógicamente los registros de una clave foranea
--- </summary>
--- <param name="@cll_nro_numcliente">Número de cliente</param>
--- <param name="@instante">Instante de referencia</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLILLAMADAS_FRECALL'

if exists (select * from sysobjects where id = object_id('dbo.CLILLAMADAS_FRECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLILLAMADAS_FRECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLILLAMADAS_FRECALL
(
@cll_nro_numcliente tngs_numero,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         Update TNGS_Carm..CliLlamadas
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where cll_nro_numcliente = @cll_nro_numcliente
      end
   else
      begin
         Update TNGS_Carm..CliLlamadas
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where cll_nro_numcliente = @cll_nro_numcliente
            and instante= @instante
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLILLAMADAS_FRECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@cll_nro_numcliente">Número de cliente</param>
--- <param name="@cll_nro_numllamada">Número de llamada</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLILLAMADAS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.CLILLAMADAS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLILLAMADAS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLILLAMADAS_DROP
(
@cll_nro_numcliente tngs_numero,
@cll_nro_numllamada tngs_numero,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..CliLlamadas
    where cll_nro_numcliente = @cll_nro_numcliente
      and cll_nro_numllamada = @cll_nro_numllamada

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLILLAMADAS_DROP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro por clave foránea
--- </summary>
--- <param name="@cll_nro_numcliente">Número de cliente</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLILLAMADAS_FDROP'

if exists (select * from sysobjects where id = object_id('dbo.CLILLAMADAS_FDROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLILLAMADAS_FDROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLILLAMADAS_FDROP
(
@cll_nro_numcliente tngs_numero,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..CliLlamadas
    where cll_nro_numcliente = @cll_nro_numcliente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLILLAMADAS_FDROP to tngsmodulos

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

print 'Store Procedure: dbo.CLILLAMADAS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.CLILLAMADAS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLILLAMADAS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLILLAMADAS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Carm..CliLlamadas
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLILLAMADAS_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente los registro borrados lógicamente por clave foránea
--- </summary>
--- <param name="@cll_nro_numcliente">Número de cliente</param>
--- <param name="@usuario">Usuario que realiza el pack</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLILLAMADAS_FPACK'

if exists (select * from sysobjects where id = object_id('dbo.CLILLAMADAS_FPACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLILLAMADAS_FPACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLILLAMADAS_FPACK
(
@cll_nro_numcliente tngs_numero,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..CliLlamadas
    where cll_nro_numcliente = @cll_nro_numcliente
      and deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLILLAMADAS_FPACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: BorraPorCliente
--- </summary>
--- <param name="@nrocliente">Numero del cliente a borrar las llamadas</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLILLAMADAS_BORRAPORCLIENTE'

if exists (select * from sysobjects where id = object_id('dbo.CLILLAMADAS_BORRAPORCLIENTE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLILLAMADAS_BORRAPORCLIENTE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLILLAMADAS_BORRAPORCLIENTE
(
@nrocliente tngs_numero,
@usuario tngs_nombre
)
as
begin

   delete from CliLlamadas 
   where cll_nro_numcliente= @nrocliente 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLILLAMADAS_BORRAPORCLIENTE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: GetLlamadProgVend
--- </summary>
--- <param name="@codusuario">Nombre codigo usuario</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLILLAMADAS_GETLLAMADPROGVEND'

if exists (select * from sysobjects where id = object_id('dbo.CLILLAMADAS_GETLLAMADPROGVEND'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLILLAMADAS_GETLLAMADPROGVEND
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLILLAMADAS_GETLLAMADPROGVEND
(
@codusuario tngs_nombre,
@usuario tngs_nombre
)
as
begin

   Select cll_nro_numcliente,
          cli_ede_rsocial as cll_ede_rsocial,
          cll_nro_numllamada,
          cll_cod_codmotivo,
          isnull(mot_des_des, '') as cll_des_motivo,
          cll_fyh_frealizada,
          cll_txt_resultado,
          cll_nom_codusuario,
          cll_cd1_baja,
          cll_nro_numcontacto,
          clc_des_nombre as cll_nom_contac,
          cll_txt_obsprogramada,
          cll_imp_abonoanterior,
          cll_imp_abonorecuperado,
          cll_nom_programador,
          cll_imp_ajuste,
          TNGS_Carm..CliLlamadas.instante,
          TNGS_Carm..CliLlamadas.deleted,
          TNGS_Carm..CliLlamadas.usuario,
          TNGS_Carm..CliLlamadas.version
     from TNGS_Carm..CliLlamadas 
          left outer join TNGS_Carm..MotivosLlamada
            on cll_cod_codmotivo = mot_cod_cod
          join TNGS_Carm..Clientes
            on cll_nro_numcliente = cli_nro_numero
          join TNGS_Carm..CliContactos
            on cll_nro_numcliente = clc_nro_numcliente
           and cll_nro_numcontacto = clc_nro_numcontacto
    where cll_nom_codusuario = @codusuario and cll_cod_codmotivo = '' 
    
      order by cll_fyh_frealizada 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLILLAMADAS_GETLLAMADPROGVEND to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: GetProgramadas
--- </summary>
--- <param name="@codusuario">Nombre codigo usuario</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLILLAMADAS_GETPROGRAMADAS'

if exists (select * from sysobjects where id = object_id('dbo.CLILLAMADAS_GETPROGRAMADAS'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLILLAMADAS_GETPROGRAMADAS
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLILLAMADAS_GETPROGRAMADAS
(
@codusuario tngs_nombre,
@usuario tngs_nombre
)
as
begin

   select cll_nro_numcliente, cll_nro_numllamada, cli_ede_rsocial, cll_fyh_frealizada, clc_des_nombre, cll_txt_obsprogramada 
   from CliLlamadas 
   join CliContactos on cll_nro_numcontacto = clc_nro_numcontacto 
   join Clientes on cli_nro_numero = cll_nro_numcliente 
    
    where cll_nom_codusuario = @codusuario and cll_cod_codmotivo = '' 
    
      order by cll_fyh_frealizada 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLILLAMADAS_GETPROGRAMADAS to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: ZBajasDetalle
--- </summary>
--- <param name="@fechaini">Fecha Inicial</param>
--- <param name="@fechafin">Fecha Fin</param>
--- <param name="@codinimarca">Codigo Inicial Marca</param>
--- <param name="@codfinmarca">Codigo Fin Marca</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLILLAMADAS_ZBAJASDETALLE'

if exists (select * from sysobjects where id = object_id('dbo.CLILLAMADAS_ZBAJASDETALLE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLILLAMADAS_ZBAJASDETALLE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLILLAMADAS_ZBAJASDETALLE
(
@fechaini tngs_fecha,
@fechafin tngs_fecha,
@codinimarca tngs_codigo_r,
@codfinmarca tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   select ctl_des_des, mot_des_des, cli_nro_nroavalon, cli_ede_rsocial, 
   	   isnull(clv_imp_abono, 0) as cls_imp_abono, cll_fyh_frealizada, cll_nom_codusuario, isnull(mrc_des_des, '') as mrc_des_des 
      from CliLlamadas 
      	join MotivosLlamada on cll_cod_codmotivo = mot_cod_cod 
      	join CategoriasLlamada on ctl_rcd_cod  = mot_rcd_codcategoria 
      	left outer join CliVentas on clv_nro_numcliente = cll_nro_numcliente and cll_fyh_frealizada > clv_fyh_fecha 
      	join Clientes on cli_nro_numero = cll_nro_numcliente 
      	left outer join Marcas on mrc_rcd_cod = cli_rcd_codmarca 
      where cll_cd1_baja = 'S' and 
   	  cll_fyh_frealizada between @fechaini and @fechafin and 
         cli_rcd_codmarca between @codinimarca and @codfinmarca 
      order by ctl_des_des, mot_des_des 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLILLAMADAS_ZBAJASDETALLE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: ZBajasGral
--- </summary>
--- <param name="@fechaini">Fecha Inicial</param>
--- <param name="@fechafin">Fecha Fin</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLILLAMADAS_ZBAJASGRAL'

if exists (select * from sysobjects where id = object_id('dbo.CLILLAMADAS_ZBAJASGRAL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLILLAMADAS_ZBAJASGRAL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLILLAMADAS_ZBAJASGRAL
(
@fechaini tngs_fecha,
@fechafin tngs_fecha,
@usuario tngs_nombre
)
as
begin

      select MAX(ctl_des_des) as ctl_des_des ,max(mot_des_des) as mot_des_des, COUNT(distinct cli_nro_numero) as cantclientes, 
      	   isnull(SUM(clv_imp_abono), 0) as cls_imp_abono, isnull(SUM(clv_nro_cantcapitas),0) as cls_nro_capitas 
      from CliLlamadas 
      	join MotivosLlamada on cll_cod_codmotivo = mot_cod_cod 
      	join CategoriasLlamada on ctl_rcd_cod  = mot_rcd_codcategoria 
      	left outer join CliVentas on clv_nro_numcliente = cll_nro_numcliente and cll_fyh_frealizada > clv_fyh_fecha 
      	join Clientes on cli_nro_numero = cll_nro_numcliente 
      where cll_cd1_baja = 'S' and 
   	  cll_fyh_frealizada between @fechaini and @fechafin 
      group by mot_rcd_codcategoria, mot_cod_cod 
    

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLILLAMADAS_ZBAJASGRAL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: ZReajustesXClieXAnio
--- </summary>
--- <param name="@nroavalon">Numero de Avalon</param>
--- <param name="@anio">Anio a obtener historico</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLILLAMADAS_ZREAJUSTESXCLIEXANIO'

if exists (select * from sysobjects where id = object_id('dbo.CLILLAMADAS_ZREAJUSTESXCLIEXANIO'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLILLAMADAS_ZREAJUSTESXCLIEXANIO
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLILLAMADAS_ZREAJUSTESXCLIEXANIO
(
@nroavalon tngs_numero,
@anio tngs_numero,
@usuario tngs_nombre
)
as
begin

   select cll_fyh_frealizada, cll_imp_abonoanterior, 
          cll_imp_abonoanterior + cll_imp_ajuste as valor_ajustado, cll_imp_ajuste as diferencia 
   from CliLlamadas 
   join Clientes on cll_nro_numcliente = cli_nro_numero 
   where cli_nro_nroavalon = @nroavalon and YEAR(cll_fyh_frealizada) = @anio 
         and cll_imp_ajuste <> 0 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLILLAMADAS_ZREAJUSTESXCLIEXANIO to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: ZReajustesXMes
--- </summary>
--- <param name="@anio">Anio</param>
--- <param name="@mes">Mes</param>
--- <param name="@inicodmarca">Inicio Codigo Marca</param>
--- <param name="@endcodmarca">End Codigo Marca</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLILLAMADAS_ZREAJUSTESXMES'

if exists (select * from sysobjects where id = object_id('dbo.CLILLAMADAS_ZREAJUSTESXMES'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLILLAMADAS_ZREAJUSTESXMES
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLILLAMADAS_ZREAJUSTESXMES
(
@anio tngs_numero,
@mes tngs_numero,
@inicodmarca tngs_codigo_r,
@endcodmarca tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   select cll_nro_numcliente, cli_nro_nroavalon, mrc_des_des, cli_ede_rsocial, cll_nom_codusuario, cll_fyh_frealizada, cll_imp_abonoanterior, cll_imp_abonoanterior + cll_imp_ajuste as valor_ajustado, 
   cll_imp_ajuste as diferencia 
   from CliLlamadas 
   join Clientes on cll_nro_numcliente = cli_nro_numero 
   join Marcas on mrc_rcd_cod = cli_rcd_codmarca 
   where YEAR(cll_fyh_frealizada) = @anio 
     and MONTH(cll_fyh_frealizada) = @mes 
     and cll_imp_ajuste <> 0 
     and cli_rcd_codmarca between @inicodmarca and @endcodmarca 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLILLAMADAS_ZREAJUSTESXMES to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: ZReclamosDetalle
--- </summary>
--- <param name="@fechaini">Fecha Inicial</param>
--- <param name="@fechafin">Fecha Fin</param>
--- <param name="@codmarcaini">Codigo Marca Inicial</param>
--- <param name="@codmarcafin">Codigo Marca Fin</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLILLAMADAS_ZRECLAMOSDETALLE'

if exists (select * from sysobjects where id = object_id('dbo.CLILLAMADAS_ZRECLAMOSDETALLE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLILLAMADAS_ZRECLAMOSDETALLE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLILLAMADAS_ZRECLAMOSDETALLE
(
@fechaini tngs_fecha,
@fechafin tngs_fecha,
@codmarcaini tngs_codigo_r,
@codmarcafin tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   select ctl_des_des, mot_des_des, cli_ede_rsocial, 
          cli_nro_nroavalon, cll_fyh_frealizada, mrc_des_des, cll_nom_codusuario, 
   SUBSTRING(cll_txt_resultado, 1, 200) as comentario 
    from CliLlamadas 
       join MotivosLlamada on cll_cod_codmotivo = mot_cod_cod 
       join CategoriasLlamada on ctl_rcd_cod  = mot_rcd_codcategoria 
       join Clientes on cli_nro_numero = cll_nro_numcliente 
       left outer join Marcas on mrc_rcd_cod = cli_rcd_codmarca 
   where mot_cd1_esreclamo = 'S' and 
   	  cll_fyh_frealizada between @fechaini and @fechafin 
         and cli_rcd_codmarca between @codmarcaini and @codmarcafin 
   	  order by ctl_des_des, mot_des_des 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLILLAMADAS_ZRECLAMOSDETALLE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: ZReclamosGral
--- </summary>
--- <param name="@fechaini">Fecha Inicial</param>
--- <param name="@fechafin">Fecha Fin</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLILLAMADAS_ZRECLAMOSGRAL'

if exists (select * from sysobjects where id = object_id('dbo.CLILLAMADAS_ZRECLAMOSGRAL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLILLAMADAS_ZRECLAMOSGRAL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLILLAMADAS_ZRECLAMOSGRAL
(
@fechaini tngs_fecha,
@fechafin tngs_fecha,
@usuario tngs_nombre
)
as
begin

   select MAX(ctl_des_des) as ctl_des_des ,max(mot_des_des) as mot_des_des, 
   		COUNT(distinct cli_nro_numero) as cantclientes, COUNT(*) as cantreclamos 
    
   from CliLlamadas 
   	join MotivosLlamada on cll_cod_codmotivo = mot_cod_cod 
   	join CategoriasLlamada on ctl_rcd_cod  = mot_rcd_codcategoria 
   	join Clientes on cli_nro_numero = cll_nro_numcliente 
   where mot_cd1_esreclamo = 'S' and 
   	  cll_fyh_frealizada between @fechaini and @fechafin 
   group by mot_rcd_codcategoria, mot_cod_cod 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLILLAMADAS_ZRECLAMOSGRAL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: ZRecuperosDetalle
--- </summary>
--- <param name="@fechaini">Fecha Inicial</param>
--- <param name="@fechafin">Fecha Fin</param>
--- <param name="@codmarcaini">Codigo Marca Inicial</param>
--- <param name="@codmarcafin">Codigo Marca Fin</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLILLAMADAS_ZRECUPEROSDETALLE'

if exists (select * from sysobjects where id = object_id('dbo.CLILLAMADAS_ZRECUPEROSDETALLE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLILLAMADAS_ZRECUPEROSDETALLE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLILLAMADAS_ZRECUPEROSDETALLE
(
@fechaini tngs_fecha,
@fechafin tngs_fecha,
@codmarcaini tngs_codigo_r,
@codmarcafin tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   select ctl_des_des, mot_des_des, cli_ede_rsocial, 
          cli_nro_nroavalon, cll_fyh_frealizada, 
          cll_imp_abonoanterior, cll_imp_abonorecuperado, 
          cll_imp_abonorecuperado - cll_imp_abonoanterior as rentabilidad, 
          mrc_des_des 
    from CliLlamadas 
       join MotivosLlamada on cll_cod_codmotivo = mot_cod_cod 
       join CategoriasLlamada on ctl_rcd_cod  = mot_rcd_codcategoria 
       join Clientes on cli_nro_numero = cll_nro_numcliente 
       left outer join Marcas on mrc_rcd_cod = cli_rcd_codmarca 
       where cll_imp_abonorecuperado <> 0 and 
             cll_fyh_frealizada between @fechaini and @fechafin 
             and cli_rcd_codmarca between @codmarcaini and @codmarcafin 
       order by ctl_des_des, mot_des_des 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLILLAMADAS_ZRECUPEROSDETALLE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: ZRecuperosGral
--- </summary>
--- <param name="@fechaini">Fecha Inicial</param>
--- <param name="@fechafin">Fecha Fin</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLILLAMADAS_ZRECUPEROSGRAL'

if exists (select * from sysobjects where id = object_id('dbo.CLILLAMADAS_ZRECUPEROSGRAL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLILLAMADAS_ZRECUPEROSGRAL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLILLAMADAS_ZRECUPEROSGRAL
(
@fechaini tngs_fecha,
@fechafin tngs_fecha,
@usuario tngs_nombre
)
as
begin

      select MAX(ctl_des_des) as ctl_des_des ,max(mot_des_des) as mot_des_des, COUNT(*) as cantclientes, 
      	   isnull(SUM(cll_imp_abonoanterior), 0) as cll_imp_abonoanterior, 
      	   isnull(SUM(cll_imp_abonorecuperado),0) as cll_imp_abonorecuperado, 
      	   ISNULL(SUM(cll_imp_abonorecuperado) - SUM(cll_imp_abonoanterior) , 0) as rentabilidad 
      from CliLlamadas 
      	join MotivosLlamada on cll_cod_codmotivo = mot_cod_cod 
      	join CategoriasLlamada on ctl_rcd_cod  = mot_rcd_codcategoria 
       join Clientes on cli_nro_numero = cll_nro_numcliente 
      where cll_imp_abonorecuperado <> 0 and 
            cll_fyh_frealizada between @fechaini and @fechafin 
      group by mot_rcd_codcategoria, mot_cod_cod 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLILLAMADAS_ZRECUPEROSGRAL to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: CliLlamadas
//--------------------------------------------------------------------------*/
