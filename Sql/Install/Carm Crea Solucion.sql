/*---------------------------------------------------------------------------
//                   TNG Software (Scripts iniciales de la Base)
//---------------------------------------------------------------------------
// Fecha              : 10/06/2021 21:33
// Base de Datos      : TNGS_Carm
// Objetivo           : Creación de los usuarios de la base
//----------------------------------------------------------------------------
// © 1999-2021 by TNG Software                                      Gndr 5.20
//---------------------------------------------------------------------------*/

/* ***************************************************************************
/  Atencion!!!
/     Este archivo fue generado por un programa en forma automática. Cualquier
/     modificación que se realize sobre él se perderá en la próxima
/     regeneración.
/  **************************************************************************/

/*-------------------------------*/
/* Selecciono la base de trabajo */
/*-------------------------------*/

use TNGS_Carm
go

/*--------------------------------------------------------------------------*/
/* Creacion de los usuarios                                                 */
/*--------------------------------------------------------------------------*/

print 'Creando Usuario:  tngsmodulos'
print ' '

if not exists (select * from sysusers where name = 'tngsmodulos' and uid < 16382)
   EXEC sp_adduser 'tngsmodulos', 'tngsmodulos', 'public'
go

print 'Creando Usuario:  tngsqbe'
print ' '

if not exists (select * from sysusers where name = 'tngsqbe' and uid < 16382)
   EXEC sp_adduser 'tngsqbe', 'tngsqbe', 'public'
go

print 'Creando Usuario:  tngsview'
print ' '

if not exists (select * from sysusers where name = 'tngsview' and uid < 16382)
   EXEC sp_adduser 'tngsview', 'tngsview', 'public'
go

/*--------------------------------------------------------------------------*/
/* Fin del programa: Scrp01.sql                                             */
/*--------------------------------------------------------------------------*/
/*---------------------------------------------------------------------------
//                   TNG Software (Scripts iniciales de la Base)
//---------------------------------------------------------------------------
// Fecha              : 10/06/2021 21:33
// Base de Datos      : TNGS_Carm
// Objetivo           : Creación de los tipos de datos
//----------------------------------------------------------------------------
// © 1999-2021 by TNG Software                                      Gndr 5.20
//---------------------------------------------------------------------------*/

/* ***************************************************************************
/  Atencion!!!
/     Este archivo fue generado por un programa en forma automática. Cualquier
/     modificación que se realize sobre él se perderá en la próxima
/     regeneración.
/  **************************************************************************/

/*-------------------------------*/
/* Selecciono la base de trabajo */
/*-------------------------------*/

use TNGS_Carm
go

/*--------------------------------------------------------------------------*/
/* Creacion de los tipos de datos                                           */
/*--------------------------------------------------------------------------*/

set nocount on

print 'Creando tipos de dato:'

print '                        - codigo_1'
EXEC sp_addtype tngs_codigo_1, 'char (1)', 'NOT NULL'
go

print '                        - codigo_r'
EXEC sp_addtype tngs_codigo_r, 'char (2)', 'NOT NULL'
go

print '                        - codigo_3'
EXEC sp_addtype tngs_codigo_3, 'char (3)', 'NOT NULL'
go

print '                        - codigo'
EXEC sp_addtype tngs_codigo, 'char (4)', 'NOT NULL'
go

print '                        - codigo_5'
EXEC sp_addtype tngs_codigo_5, 'char (5)', 'NOT NULL'
go

print '                        - codigo_6'
EXEC sp_addtype tngs_codigo_6, 'char (6)', 'NOT NULL'
go

print '                        - codigo_7'
EXEC sp_addtype tngs_codigo_7, 'char (7)', 'NOT NULL'
go

print '                        - codigo_e'
EXEC sp_addtype tngs_codigo_e, 'char (8)', 'NOT NULL'
go

print '                        - codigo_9'
EXEC sp_addtype tngs_codigo_9, 'char (9)', 'NOT NULL'
go

print '                        - codigo_x'
EXEC sp_addtype tngs_codigo_x, 'char (10)', 'NOT NULL'
go

print '                        - codigo_12'
EXEC sp_addtype tngs_codigo_12, 'char (12)', 'NOT NULL'
go

print '                        - codigo_15'
EXEC sp_addtype tngs_codigo_15, 'char (15)', 'NOT NULL'
go

print '                        - codigo_xl'
EXEC sp_addtype tngs_codigo_xl, 'char (20)', 'NOT NULL'
go

print '                        - codigo_30'
EXEC sp_addtype tngs_codigo_30, 'char (30)', 'NOT NULL'
go

print '                        - descripcion_2'
EXEC sp_addtype tngs_descripcion_2, 'char (2)', 'NOT NULL'
go

print '                        - descripcion_4'
EXEC sp_addtype tngs_descripcion_4, 'char (4)', 'NOT NULL'
go

print '                        - descripcion_6'
EXEC sp_addtype tngs_descripcion_6, 'char (6)', 'NOT NULL'
go

print '                        - descripcion_10'
EXEC sp_addtype tngs_descripcion_10, 'char (10)', 'NOT NULL'
go

print '                        - descripcion_r'
EXEC sp_addtype tngs_descripcion_r, 'char (15)', 'NOT NULL'
go

print '                        - descripcion_20'
EXEC sp_addtype tngs_descripcion_20, 'char (20)', 'NOT NULL'
go

print '                        - descripcion'
EXEC sp_addtype tngs_descripcion, 'char (30)', 'NOT NULL'
go

print '                        - descripcion_40'
EXEC sp_addtype tngs_descripcion_40, 'char (40)', 'NOT NULL'
go

print '                        - descripcion_50'
EXEC sp_addtype tngs_descripcion_50, 'char (50)', 'NOT NULL'
go

print '                        - descripcion_e'
EXEC sp_addtype tngs_descripcion_e, 'char (60)', 'NOT NULL'
go

print '                        - descripcion_80'
EXEC sp_addtype tngs_descripcion_80, 'varchar (80)', 'NOT NULL'
go

print '                        - descripcion_100'
EXEC sp_addtype tngs_descripcion_100, 'varchar (100)', 'NOT NULL'
go

print '                        - descripcion_x'
EXEC sp_addtype tngs_descripcion_x, 'varchar (120)', 'NOT NULL'
go

print '                        - descripcion_150'
EXEC sp_addtype tngs_descripcion_150, 'varchar (150)', 'NOT NULL'
go

print '                        - descripcion_200'
EXEC sp_addtype tngs_descripcion_200, 'varchar (200)', 'NOT NULL'
go

print '                        - descripcion_xl'
EXEC sp_addtype tngs_descripcion_xl, 'varchar (240)', 'NOT NULL'
go

print '                        - estado'
EXEC sp_addtype tngs_estado, 'char (1)', 'NOT NULL'
go

print '                        - nombre'
EXEC sp_addtype tngs_nombre, 'char (20)', 'NOT NULL'
go

print '                        - codpos'
EXEC sp_addtype tngs_codpos, 'char (8)', 'NOT NULL'
go

print '                        - cuit'
EXEC sp_addtype tngs_cuit, 'char (13)', 'NOT NULL'
go

print '                        - cbu'
EXEC sp_addtype tngs_cbu, 'char (25)', 'NOT NULL'
go

print '                        - email'
EXEC sp_addtype tngs_email, 'varchar (60)', 'NOT NULL'
go

print '                        - telefono'
EXEC sp_addtype tngs_telefono, 'char (30)', 'NOT NULL'
go

print '                        - telefono_e'
EXEC sp_addtype tngs_telefono_e, 'varchar (60)', 'NOT NULL'
go

print '                        - mes'
EXEC sp_addtype tngs_mes, 'char (6)', 'NOT NULL'
go

print '                        - clave'
EXEC sp_addtype tngs_clave, 'char (32)', 'NOT NULL'
go

print '                        - observaciones_r'
EXEC sp_addtype tngs_observaciones_r, 'varchar (254)', 'NOT NULL'
go

print '                        - observaciones'
EXEC sp_addtype tngs_observaciones, 'text', 'NOT NULL'
go

print '                        - texto'
EXEC sp_addtype tngs_texto, 'text', 'NOT NULL'
go

print '                        - texto'
EXEC sp_addtype tngs_texto, 'text', 'NOT NULL'
go

print '                        - numero'
EXEC sp_addtype tngs_numero, 'int', 'NOT NULL'
go

print '                        - cantidad'
EXEC sp_addtype tngs_cantidad, 'int', 'NOT NULL'
go

print '                        - item'
EXEC sp_addtype tngs_item, 'int', 'NOT NULL'
go

print '                        - importe'
EXEC sp_addtype tngs_importe, 'money', 'NOT NULL'
go

print '                        - precio'
EXEC sp_addtype tngs_precio, 'money', 'NOT NULL'
go

print '                        - porcentaje'
EXEC sp_addtype tngs_porcentaje, 'money', 'NOT NULL'
go

print '                        - valor'
EXEC sp_addtype tngs_valor, 'float', 'NOT NULL'
go

print '                        - valor'
EXEC sp_addtype tngs_valor, 'float', 'NOT NULL'
go

print '                        - tiempo'
EXEC sp_addtype tngs_tiempo, 'int', 'NOT NULL'
go

print '                        - numero_e'
EXEC sp_addtype tngs_numero_e, 'bigint', 'NOT NULL'
go

print '                        - fecha'
EXEC sp_addtype tngs_fecha, 'datetime', 'NOT NULL'
go

print '                        - hora'
EXEC sp_addtype tngs_hora, 'datetime', 'NOT NULL'
go

print '                        - fecyhor'
EXEC sp_addtype tngs_fecyhor, 'datetime', 'NOT NULL'
go

print '                        - borrado'
EXEC sp_addtype tngs_borrado, 'money', 'NOT NULL'
go

/*--------------------------------------------------------------------------*/
/* Fin del programa: Scrp02.sql                                             */
/*--------------------------------------------------------------------------*/
/*---------------------------------------------------------------------------
//                   TNG Software (Scripts iniciales de la Base)
//---------------------------------------------------------------------------
// Fecha              : 10/06/2021 21:33
// Base de Datos      : TNGS_Carm
// Objetivo           : Creación de las funciones básicas
//----------------------------------------------------------------------------
// © 1999-2021 by TNG Software                                      Gndr 5.20
//---------------------------------------------------------------------------*/

/* ***************************************************************************
/  Atencion!!!
/     Este archivo fue generado por un programa en forma automática. Cualquier
/     modificación que se realize sobre él se perderá en la próxima
/     regeneración.
/  **************************************************************************/

/*-------------------------------*/
/* Selecciono la base de trabajo */
/*-------------------------------*/

use TNGS_Carm
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Función : Trim
--- </summary>
--- <param name="@texto">Texto a trimear</param>
---
---////////////////////////////////////////////////////////

print 'Function: TNGS_TRIM'

if exists (select * from sysobjects where id = object_id('TNGS_TRIM'))
begin
   print '       - Borrando la vieja Función'
   drop function TNGS_TRIM
end
go

print '       - Creando la nueva Función'
go

create function TNGS_TRIM
(
@texto varchar(8000)
)
returns varchar(8000)
as
begin

   return ltrim(rtrim(@texto))

end
go

print '       - Asignando permisos a la Función'

grant execute on TNGS_TRIM to tngsmodulos
grant execute on TNGS_TRIM to tngsqbe

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Función : MakeDateTime
--- </summary>
--- <param name="@texto">Texto a convertir</param>
---
---////////////////////////////////////////////////////////

print 'Function: TNGS_MAKEDATETIME'

if exists (select * from sysobjects where id = object_id('TNGS_MAKEDATETIME'))
begin
   print '       - Borrando la vieja Función'
   drop function TNGS_MAKEDATETIME
end
go

print '       - Creando la nueva Función'
go

create function TNGS_MAKEDATETIME
(
@texto varchar(30)
)
returns datetime
as
begin

   return convert(datetime, @texto, 103)

end
go

print '       - Asignando permisos a la Función'

grant execute on TNGS_MAKEDATETIME to tngsmodulos
grant execute on TNGS_MAKEDATETIME to tngsqbe

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Función : GetDate
--- </summary>
--- <param name="@fecyhor">Fecha y Hora a procesar</param>
---
---////////////////////////////////////////////////////////

print 'Function: TNGS_GETDATE'

if exists (select * from sysobjects where id = object_id('TNGS_GETDATE'))
begin
   print '       - Borrando la vieja Función'
   drop function TNGS_GETDATE
end
go

print '       - Creando la nueva Función'
go

create function TNGS_GETDATE
(
@fecyhor datetime
)
returns datetime
as
begin

   return convert(datetime, convert(char(30), @fecyhor, 101), 101)

end
go

print '       - Asignando permisos a la Función'

grant execute on TNGS_GETDATE to tngsmodulos
grant execute on TNGS_GETDATE to tngsqbe

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Función : GetTime
--- </summary>
--- <param name="@fecyhor">Fecha y Hora a procesar</param>
---
---////////////////////////////////////////////////////////

print 'Function: TNGS_GETTIME'

if exists (select * from sysobjects where id = object_id('TNGS_GETTIME'))
begin
   print '       - Borrando la vieja Función'
   drop function TNGS_GETTIME
end
go

print '       - Creando la nueva Función'
go

create function TNGS_GETTIME
(
@fecyhor datetime
)
returns datetime
as
begin

   return convert(datetime, convert(char(30), @fecyhor, 108), 108)

end
go

print '       - Asignando permisos a la Función'

grant execute on TNGS_GETTIME to tngsmodulos
grant execute on TNGS_GETTIME to tngsqbe

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Función : PadR
--- </summary>
--- <param name="@texto">Texto sobre el que realizar el PADR</param>
--- <param name="@largo">Longitud del PAD</param>
--- <param name="@caracter">Caracter del PAD</param>
---
---////////////////////////////////////////////////////////

print 'Function: TNGS_PADR'

if exists (select * from sysobjects where id = object_id('TNGS_PADR'))
begin
   print '       - Borrando la vieja Función'
   drop function TNGS_PADR
end
go

print '       - Creando la nueva Función'
go

create function TNGS_PADR
(
@texto varchar(100),
@largo smallint, 
@caracter varchar(1)
)
returns varchar(100)
as
   begin
      declare @strlen smallint

      select @strlen= datalength(ltrim(rtrim(@texto)))

      if @strlen >= @largo
         begin
            set @texto= left(ltrim(rtrim(@texto)), @largo)
         end
      else
         begin
            declare @rlargo smallint

            set @rlargo= @largo - @strlen
            set @texto= ltrim(rtrim(@texto)) + left(replicate(@caracter, @rlargo + 2), @rlargo)
      end

      return (@texto)
   end
go

print '       - Asignando permisos a la Función'

grant execute on TNGS_PADR to tngsmodulos
grant execute on TNGS_PADR to tngsqbe

print ' '
go


---////////////////////////////////////////////////////////
---
--- <summary>
--- Función : PadL
--- </summary>
--- <param name="@texto">Texto sobre el que realizar el PADL</param>
--- <param name="@largo">Longitud del PAD</param>
--- <param name="@caracter">Caracter del PAD</param>
---
---////////////////////////////////////////////////////////

print 'Function: TNGS_PADL'

if exists (select * from sysobjects where id = object_id('TNGS_PADL'))
begin
   print '       - Borrando la vieja Función'
   drop function TNGS_PADL
end
go

print '       - Creando la nueva Función'
go

create function TNGS_PADL
(
@texto varchar(100),
@largo smallint, 
@caracter varchar(1)
)
returns varchar(100)
as
   begin
      declare @strlen smallint

      select @strlen= datalength(ltrim(rtrim(@texto)))

      if @strlen >= @largo
         begin
            set @texto= left(ltrim(rtrim(@texto)), @largo)
         end
      else
         begin
            declare @rlargo smallint

            set @rlargo= @largo - @strlen
            set @texto= left(replicate(@caracter, @rlargo + 2), @rlargo) + ltrim(rtrim(@texto))
      end

      return (@texto)
   end
go

print '       - Asignando permisos a la Función'

grant execute on TNGS_PADL to tngsmodulos
grant execute on TNGS_PADL to tngsqbe

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Función : MAKESINO
--- </summary>
--- <param name="@sino">Caracter S/N</param>
---
---////////////////////////////////////////////////////////

print 'Function: TNGS_MAKEYESNO'

if exists (select * from sysobjects where id = object_id('TNGS_MAKEYESNO'))
begin
   print '       - Borrando la vieja Función'
   drop function TNGS_MAKEYESNO
end
go

print '       - Creando la nueva Función'
go

create function TNGS_MAKEYESNO
(
@sino char(1)
)
returns varchar(11)
as
   begin

      return case @sino
                when 'S' then 'SI'
                when 'N' then 'NO'
                else 'DESCONOCIDO'
             end

   end
go

print '       - Asignando permisos a la Función'

grant execute on TNGS_MAKEYESNO to tngsmodulos
grant execute on TNGS_MAKEYESNO to tngsqbe

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Función : MAKEVTEXT
--- </summary>
--- <param name="@sexo">Sexo</param>
---
---////////////////////////////////////////////////////////

print 'Function: TNGS_MAKEVTEXT'

if exists (select * from sysobjects where id = object_id('TNGS_MAKEVTEXT'))
begin
   print '       - Borrando la vieja Función'
   drop function TNGS_MAKEVTEXT
end
go

print '       - Creando la nueva Función'
go

create function TNGS_MAKEVTEXT
(
@texto text
)
returns varchar(60)
as
   begin
      declare @ret varchar(60),
              @temp varchar(60)

      select @temp= ltrim(rtrim(substring(@texto, 61, 60))),
             @ret= ltrim(rtrim(substring(@texto, 1, 60)))

      if @temp <> ' '
         begin
            select @ret= rtrim(substring(@ret, 1, 57)) + '...'
         end

      return (@ret)
   end

go

print '       - Asignando permisos a la Función'

grant execute on TNGS_MAKEVTEXT to tngsmodulos
grant execute on TNGS_MAKEVTEXT to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------*/
/* Fin del programa: Scrp03.sql                                             */
/*--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : CategoriasLlamada
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
/* Selecciono la base en la que se creara la tabla */
/*-------------------------------------------------*/

use TNGS_Carm
go

/*-----------------------------------*/
/* Crea la tabla en la base indicada */
/*-----------------------------------*/

print 'Tabla: CategoriasLlamada'

if exists (select * from sysobjects where id = object_id('dbo.CategoriasLlamada'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.CategoriasLlamada
end
go

print '   - Creando la nueva tabla'

create table CategoriasLlamada
   (
      ctl_rcd_cod tngs_codigo_r,
      ctl_des_des tngs_descripcion,
      ctl_cd1_tipo tngs_codigo_1,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint CategoriasLlamada_pk primary key clustered
      (
         ctl_rcd_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on CategoriasLlamada to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: CategoriasLlamada
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : CliContactos
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
/* Selecciono la base en la que se creara la tabla */
/*-------------------------------------------------*/

use TNGS_Carm
go

/*-----------------------------------*/
/* Crea la tabla en la base indicada */
/*-----------------------------------*/

print 'Tabla: CliContactos'

if exists (select * from sysobjects where id = object_id('dbo.CliContactos'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.CliContactos
end
go

print '   - Creando la nueva tabla'

create table CliContactos
   (
      clc_nro_numcliente tngs_numero,
      clc_nro_numcontacto tngs_numero,
      clc_des_nombre tngs_descripcion,
      clc_des_cargo tngs_descripcion,
      clc_des_titulo tngs_descripcion,
      clc_tel_celular tngs_telefono,
      clc_tel_telefono1 tngs_telefono,
      clc_tel_telefono2 tngs_telefono,
      clc_tel_interno tngs_telefono,
      clc_xld_email tngs_descripcion_xl,
      clc_des_secretaria tngs_descripcion,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint CliContactos_pk primary key clustered
      (
         clc_nro_numcliente,
         clc_nro_numcontacto
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on CliContactos to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: CliContactos
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : Clientes
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
/* Selecciono la base en la que se creara la tabla */
/*-------------------------------------------------*/

use TNGS_Carm
go

/*-----------------------------------*/
/* Crea la tabla en la base indicada */
/*-----------------------------------*/

print 'Tabla: Clientes'

if exists (select * from sysobjects where id = object_id('dbo.Clientes'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Clientes
end
go

print '   - Creando la nueva tabla'

create table Clientes
   (
      cli_nro_numero tngs_numero,
      cli_ede_rsocial tngs_descripcion_e,
      cli_des_nombrefant tngs_descripcion,
      cli_cod_codtinst tngs_codigo,
      cli_cod_codfrq tngs_codigo,
      cli_cd1_alta tngs_codigo_1,
      cli_tel_telefono1 tngs_telefono,
      cli_tel_celular tngs_telefono,
      cli_tel_telefono2 tngs_telefono,
      cli_tel_fax tngs_telefono,
      cli_ede_direccion tngs_descripcion_e,
      cli_nro_altura tngs_numero,
      cli_rde_piso tngs_descripcion_r,
      cli_rde_oficina tngs_descripcion_r,
      cli_ecd_codlocalidad tngs_codigo_e,
      cli_des_cuil tngs_descripcion,
      cli_xld_url tngs_descripcion_xl,
      cli_cd6_codvend tngs_codigo_6,
      cli_fec_fechaingreso tngs_fecha,
      cli_nro_cantempleados tngs_numero,
      cli_txt_cobertura tngs_texto,
      cli_nom_cargador tngs_nombre,
      cli_txt_observacion tngs_texto,
      cli_xld_email tngs_descripcion_xl,
      cli_nro_nroavalon tngs_numero,
      cli_imp_abono tngs_importe,
      cli_rcd_codtipocont tngs_codigo_r,
      cli_imp_deuda tngs_importe,
      cli_cd1_sexo tngs_codigo_1,
      cli_des_tarjetacred tngs_descripcion,
      cli_cd1_fueclienteantes tngs_codigo_1,
      cli_ede_titular tngs_descripcion_e,
      cli_ede_direccioncobertura tngs_descripcion_e,
      cli_nro_alturacobertura tngs_numero,
      cli_rde_pisocobertura tngs_descripcion_r,
      cli_rde_oficinacobertura tngs_descripcion_r,
      cli_ecd_codloccobertura tngs_codigo_e,
      cli_rcd_codmarca tngs_codigo_r,
      cli_rcd_tipocliente tngs_codigo_r,
      cli_xde_apellido tngs_descripcion_x,
      cli_fec_fechanacimiento tngs_fecha,
      cli_rcd_situacioniva tngs_codigo_r,
      cli_ede_nombre tngs_descripcion_e,
      cli_rcd_codrubro tngs_codigo_r,
      cli_fec_fecultimocontacto tngs_fecha,
      cli_fec_fechaproxcontacto tngs_fecha,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Clientes_pk primary key clustered
      (
         cli_nro_numero
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Clientes to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Clientes
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : CliEntrevistas
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
/* Selecciono la base en la que se creara la tabla */
/*-------------------------------------------------*/

use TNGS_Carm
go

/*-----------------------------------*/
/* Crea la tabla en la base indicada */
/*-----------------------------------*/

print 'Tabla: CliEntrevistas'

if exists (select * from sysobjects where id = object_id('dbo.CliEntrevistas'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.CliEntrevistas
end
go

print '   - Creando la nueva tabla'

create table CliEntrevistas
   (
      cle_nro_numcliente tngs_numero,
      cle_nro_numentrev tngs_numero,
      cle_fyh_fcoordinada tngs_fecyhor,
      cle_fyh_frealizada tngs_fecyhor,
      cle_cd6_codvend tngs_codigo_6,
      cle_ede_motcambiof tngs_descripcion_e,
      cle_des_nombre tngs_descripcion,
      cle_tel_telefono tngs_telefono,
      cle_des_cargo tngs_descripcion,
      cle_des_titulo tngs_descripcion,
      cle_tel_celular tngs_telefono,
      cle_xld_email tngs_descripcion_xl,
      cle_xld_direccion tngs_descripcion_xl,
      cle_txt_observaciones tngs_texto,
      cle_rcd_codresultado tngs_codigo_r,
      cle_ede_informe tngs_descripcion_e,
      cle_des_secretaria tngs_descripcion,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint CliEntrevistas_pk primary key clustered
      (
         cle_nro_numcliente,
         cle_nro_numentrev
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on CliEntrevistas to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: CliEntrevistas
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : CliGrupoFamiliar
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
/* Selecciono la base en la que se creara la tabla */
/*-------------------------------------------------*/

use TNGS_Carm
go

/*-----------------------------------*/
/* Crea la tabla en la base indicada */
/*-----------------------------------*/

print 'Tabla: CliGrupoFamiliar'

if exists (select * from sysobjects where id = object_id('dbo.CliGrupoFamiliar'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.CliGrupoFamiliar
end
go

print '   - Creando la nueva tabla'

create table CliGrupoFamiliar
   (
      cgf_nro_numcliente tngs_numero,
      cgf_nro_numintegrante tngs_numero,
      cgf_ede_apellido tngs_descripcion_e,
      cgf_ede_nombre tngs_descripcion_e,
      cgf_rcd_codparentesco tngs_codigo_r,
      cgf_d20_dni tngs_descripcion_20,
      cgf_fec_fechanacimiento tngs_fecha,
      cgf_ede_obrasocial tngs_descripcion_e,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint CliGrupoFamiliar_pk primary key clustered
      (
         cgf_nro_numcliente,
         cgf_nro_numintegrante
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on CliGrupoFamiliar to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: CliGrupoFamiliar
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : CliLlamadas
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
/* Selecciono la base en la que se creara la tabla */
/*-------------------------------------------------*/

use TNGS_Carm
go

/*-----------------------------------*/
/* Crea la tabla en la base indicada */
/*-----------------------------------*/

print 'Tabla: CliLlamadas'

if exists (select * from sysobjects where id = object_id('dbo.CliLlamadas'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.CliLlamadas
end
go

print '   - Creando la nueva tabla'

create table CliLlamadas
   (
      cll_nro_numcliente tngs_numero,
      cll_nro_numllamada tngs_numero,
      cll_cod_codmotivo tngs_codigo,
      cll_fyh_frealizada tngs_fecyhor,
      cll_txt_resultado tngs_texto,
      cll_nom_codusuario tngs_nombre,
      cll_cd1_baja tngs_codigo_1,
      cll_nro_numcontacto tngs_numero,
      cll_txt_obsprogramada tngs_texto,
      cll_imp_abonoanterior tngs_importe,
      cll_imp_abonorecuperado tngs_importe,
      cll_nom_programador tngs_nombre,
      cll_imp_ajuste tngs_importe,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint CliLlamadas_pk primary key clustered
      (
         cll_nro_numcliente,
         cll_nro_numllamada
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on CliLlamadas to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: CliLlamadas
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : CliNotas
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
/* Selecciono la base en la que se creara la tabla */
/*-------------------------------------------------*/

use TNGS_Carm
go

/*-----------------------------------*/
/* Crea la tabla en la base indicada */
/*-----------------------------------*/

print 'Tabla: CliNotas'

if exists (select * from sysobjects where id = object_id('dbo.CliNotas'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.CliNotas
end
go

print '   - Creando la nueva tabla'

create table CliNotas
   (
      cln_nro_numcliente tngs_numero,
      cln_fyh_fechayhora tngs_fecyhor,
      cln_des_titulo tngs_descripcion,
      cln_xld_texto tngs_descripcion_xl,
      cln_cd1_tipo tngs_codigo_1,
      cln_nom_escritor tngs_nombre,
      cln_nom_removedor tngs_nombre,
      cln_fyh_fyhremovida tngs_fecyhor,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint CliNotas_pk primary key clustered
      (
         cln_nro_numcliente,
         cln_fyh_fechayhora
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on CliNotas to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: CliNotas
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : CliServicios
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
/* Selecciono la base en la que se creara la tabla */
/*-------------------------------------------------*/

use TNGS_Carm
go

/*-----------------------------------*/
/* Crea la tabla en la base indicada */
/*-----------------------------------*/

print 'Tabla: CliServicios'

if exists (select * from sysobjects where id = object_id('dbo.CliServicios'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.CliServicios
end
go

print '   - Creando la nueva tabla'

create table CliServicios
   (
      cls_nro_numcliente tngs_numero,
      cls_nro_item tngs_numero,
      cls_cod_codservicio tngs_codigo,
      cls_imp_coseguro tngs_importe,
      cls_imp_valorprestacion tngs_importe,
      cls_nro_cantestprestaciones tngs_numero,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint CliServicios_pk primary key clustered
      (
         cls_nro_numcliente,
         cls_nro_item
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on CliServicios to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: CliServicios
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : CliVentas
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
/* Selecciono la base en la que se creara la tabla */
/*-------------------------------------------------*/

use TNGS_Carm
go

/*-----------------------------------*/
/* Crea la tabla en la base indicada */
/*-----------------------------------*/

print 'Tabla: CliVentas'

if exists (select * from sysobjects where id = object_id('dbo.CliVentas'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.CliVentas
end
go

print '   - Creando la nueva tabla'

create table CliVentas
   (
      clv_nro_numcliente tngs_numero,
      clv_fyh_fecha tngs_fecyhor,
      clv_cd6_codvendedor tngs_codigo_6,
      clv_rcd_codtipocontrato tngs_codigo_r,
      clv_imp_abono tngs_importe,
      clv_nro_cantcapitas tngs_numero,
      clv_imp_valorcapita tngs_importe,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint CliVentas_pk primary key clustered
      (
         clv_nro_numcliente,
         clv_fyh_fecha
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on CliVentas to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: CliVentas
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : ConversionColores
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
/* Selecciono la base en la que se creara la tabla */
/*-------------------------------------------------*/

use TNGS_Carm
go

/*-----------------------------------*/
/* Crea la tabla en la base indicada */
/*-----------------------------------*/

print 'Tabla: ConversionColores'

if exists (select * from sysobjects where id = object_id('dbo.ConversionColores'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.ConversionColores
end
go

print '   - Creando la nueva tabla'

create table ConversionColores
   (
      con_cod_cod tngs_codigo,
      con_des_coloraconvertir tngs_descripcion,
      con_cd1_colorconvertido tngs_codigo_1,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint ConversionColores_pk primary key clustered
      (
         con_cod_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on ConversionColores to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: ConversionColores
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : Franquicias
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
/* Selecciono la base en la que se creara la tabla */
/*-------------------------------------------------*/

use TNGS_Carm
go

/*-----------------------------------*/
/* Crea la tabla en la base indicada */
/*-----------------------------------*/

print 'Tabla: Franquicias'

if exists (select * from sysobjects where id = object_id('dbo.Franquicias'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Franquicias
end
go

print '   - Creando la nueva tabla'

create table Franquicias
   (
      frq_cod_cod tngs_codigo,
      frq_des_des tngs_descripcion,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Franquicias_pk primary key clustered
      (
         frq_cod_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Franquicias to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Franquicias
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : Localidades
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
/* Selecciono la base en la que se creara la tabla */
/*-------------------------------------------------*/

use TNGS_Carm
go

/*-----------------------------------*/
/* Crea la tabla en la base indicada */
/*-----------------------------------*/

print 'Tabla: Localidades'

if exists (select * from sysobjects where id = object_id('dbo.Localidades'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Localidades
end
go

print '   - Creando la nueva tabla'

create table Localidades
   (
      loc_ecd_codpost tngs_codigo_e,
      loc_ede_nombre tngs_descripcion_e,
      loc_rcd_codzona tngs_codigo_r,
      loc_ede_partido tngs_descripcion_e,
      loc_des_provincia tngs_descripcion,
      loc_ede_nomgoogle tngs_descripcion_e,
      loc_cd1_directa tngs_codigo_1,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Localidades_pk primary key clustered
      (
         loc_ecd_codpost
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Localidades to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Localidades
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : LogClientes
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
/* Selecciono la base en la que se creara la tabla */
/*-------------------------------------------------*/

use TNGS_Carm
go

/*-----------------------------------*/
/* Crea la tabla en la base indicada */
/*-----------------------------------*/

print 'Tabla: LogClientes'

if exists (select * from sysobjects where id = object_id('dbo.LogClientes'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.LogClientes
end
go

print '   - Creando la nueva tabla'

create table LogClientes
   (
      lgc_nro_nro tngs_numero,
      lgc_nro_nrocliente tngs_numero,
      lgc_nro_nroavalon tngs_numero,
      lgc_ede_rsocial tngs_descripcion_e,
      lgc_des_nomfantasia tngs_descripcion,
      lgc_des_accion tngs_descripcion,
      lgc_nom_usuario tngs_nombre,
      lgc_fyh_fecha tngs_fecyhor,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint LogClientes_pk primary key clustered
      (
         lgc_nro_nro
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on LogClientes to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: LogClientes
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : Marcas
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
/* Selecciono la base en la que se creara la tabla */
/*-------------------------------------------------*/

use TNGS_Carm
go

/*-----------------------------------*/
/* Crea la tabla en la base indicada */
/*-----------------------------------*/

print 'Tabla: Marcas'

if exists (select * from sysobjects where id = object_id('dbo.Marcas'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Marcas
end
go

print '   - Creando la nueva tabla'

create table Marcas
   (
      mrc_rcd_cod tngs_codigo_r,
      mrc_ede_des tngs_descripcion_e,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Marcas_pk primary key clustered
      (
         mrc_rcd_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Marcas to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Marcas
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : MotivosLlamada
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
/* Selecciono la base en la que se creara la tabla */
/*-------------------------------------------------*/

use TNGS_Carm
go

/*-----------------------------------*/
/* Crea la tabla en la base indicada */
/*-----------------------------------*/

print 'Tabla: MotivosLlamada'

if exists (select * from sysobjects where id = object_id('dbo.MotivosLlamada'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.MotivosLlamada
end
go

print '   - Creando la nueva tabla'

create table MotivosLlamada
   (
      mot_cod_cod tngs_codigo,
      mot_des_des tngs_descripcion,
      mot_rcd_codcategoria tngs_codigo_r,
      mot_cd1_esreclamo tngs_codigo_1,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint MotivosLlamada_pk primary key clustered
      (
         mot_cod_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on MotivosLlamada to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: MotivosLlamada
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : Parametros
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
/* Selecciono la base en la que se creara la tabla */
/*-------------------------------------------------*/

use TNGS_Carm
go

/*-----------------------------------*/
/* Crea la tabla en la base indicada */
/*-----------------------------------*/

print 'Tabla: Parametros'

if exists (select * from sysobjects where id = object_id('dbo.Parametros'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Parametros
end
go

print '   - Creando la nueva tabla'

create table Parametros
   (
      par_xcd_codigo tngs_codigo_x,
      par_des_descripcion tngs_descripcion,
      par_xde_valor tngs_descripcion_x,
      par_est_editable tngs_estado,
      par_est_sololectura tngs_estado,
      par_rob_detalle tngs_observaciones_r,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Parametros_pk primary key clustered
      (
         par_xcd_codigo
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Parametros to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Parametros
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : Parentescos
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
/* Selecciono la base en la que se creara la tabla */
/*-------------------------------------------------*/

use TNGS_Carm
go

/*-----------------------------------*/
/* Crea la tabla en la base indicada */
/*-----------------------------------*/

print 'Tabla: Parentescos'

if exists (select * from sysobjects where id = object_id('dbo.Parentescos'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Parentescos
end
go

print '   - Creando la nueva tabla'

create table Parentescos
   (
      prt_rcd_cod tngs_codigo_r,
      prt_des_des tngs_descripcion,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Parentescos_pk primary key clustered
      (
         prt_rcd_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Parentescos to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Parentescos
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : Planes
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
/* Selecciono la base en la que se creara la tabla */
/*-------------------------------------------------*/

use TNGS_Carm
go

/*-----------------------------------*/
/* Crea la tabla en la base indicada */
/*-----------------------------------*/

print 'Tabla: Planes'

if exists (select * from sysobjects where id = object_id('dbo.Planes'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Planes
end
go

print '   - Creando la nueva tabla'

create table Planes
   (
      pln_cod_cod tngs_codigo,
      pln_des_des tngs_descripcion,
      pln_cod_codplanavalon tngs_codigo,
      pln_d80_tcontratoavalon tngs_descripcion_80,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Planes_pk primary key clustered
      (
         pln_cod_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Planes to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Planes
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : PlnServicios
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
/* Selecciono la base en la que se creara la tabla */
/*-------------------------------------------------*/

use TNGS_Carm
go

/*-----------------------------------*/
/* Crea la tabla en la base indicada */
/*-----------------------------------*/

print 'Tabla: PlnServicios'

if exists (select * from sysobjects where id = object_id('dbo.PlnServicios'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.PlnServicios
end
go

print '   - Creando la nueva tabla'

create table PlnServicios
   (
      pls_cod_codplan tngs_codigo,
      pls_cod_codservicio tngs_codigo,
      pls_nro_cprestlibres tngs_numero,
      pls_imp_valorprestacion tngs_importe,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint PlnServicios_pk primary key clustered
      (
         pls_cod_codplan,
         pls_cod_codservicio
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on PlnServicios to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: PlnServicios
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : PreciosServicios
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
/* Selecciono la base en la que se creara la tabla */
/*-------------------------------------------------*/

use TNGS_Carm
go

/*-----------------------------------*/
/* Crea la tabla en la base indicada */
/*-----------------------------------*/

print 'Tabla: PreciosServicios'

if exists (select * from sysobjects where id = object_id('dbo.PreciosServicios'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.PreciosServicios
end
go

print '   - Creando la nueva tabla'

create table PreciosServicios
   (
      prs_cd1_color tngs_codigo_1,
      prs_fec_fecha tngs_fecha,
      prs_imp_precio tngs_importe,
      prs_imp_coseguro tngs_importe,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint PreciosServicios_pk primary key clustered
      (
         prs_cd1_color,
         prs_fec_fecha
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on PreciosServicios to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: PreciosServicios
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : ResEntrevista
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
/* Selecciono la base en la que se creara la tabla */
/*-------------------------------------------------*/

use TNGS_Carm
go

/*-----------------------------------*/
/* Crea la tabla en la base indicada */
/*-----------------------------------*/

print 'Tabla: ResEntrevista'

if exists (select * from sysobjects where id = object_id('dbo.ResEntrevista'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.ResEntrevista
end
go

print '   - Creando la nueva tabla'

create table ResEntrevista
   (
      ren_rcd_cod tngs_codigo_r,
      ren_des_des tngs_descripcion,
      ren_cd1_codfiltro tngs_codigo_1,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint ResEntrevista_pk primary key clustered
      (
         ren_rcd_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on ResEntrevista to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: ResEntrevista
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : Rubros
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
/* Selecciono la base en la que se creara la tabla */
/*-------------------------------------------------*/

use TNGS_Carm
go

/*-----------------------------------*/
/* Crea la tabla en la base indicada */
/*-----------------------------------*/

print 'Tabla: Rubros'

if exists (select * from sysobjects where id = object_id('dbo.Rubros'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Rubros
end
go

print '   - Creando la nueva tabla'

create table Rubros
   (
      rbr_rcd_cod tngs_codigo_r,
      rbr_des_des tngs_descripcion,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Rubros_pk primary key clustered
      (
         rbr_rcd_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Rubros to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Rubros
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : Servicios
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
/* Selecciono la base en la que se creara la tabla */
/*-------------------------------------------------*/

use TNGS_Carm
go

/*-----------------------------------*/
/* Crea la tabla en la base indicada */
/*-----------------------------------*/

print 'Tabla: Servicios'

if exists (select * from sysobjects where id = object_id('dbo.Servicios'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Servicios
end
go

print '   - Creando la nueva tabla'

create table Servicios
   (
      srv_cod_cod tngs_codigo,
      srv_des_des tngs_descripcion,
      srv_xld_explicacion tngs_descripcion_xl,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Servicios_pk primary key clustered
      (
         srv_cod_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Servicios to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Servicios
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : SituacionesIVA
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
/* Selecciono la base en la que se creara la tabla */
/*-------------------------------------------------*/

use TNGS_Carm
go

/*-----------------------------------*/
/* Crea la tabla en la base indicada */
/*-----------------------------------*/

print 'Tabla: SituacionesIVA'

if exists (select * from sysobjects where id = object_id('dbo.SituacionesIVA'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.SituacionesIVA
end
go

print '   - Creando la nueva tabla'

create table SituacionesIVA
   (
      siv_rcd_codigo tngs_codigo_r,
      siv_des_descripcion tngs_descripcion,
      siv_cd1_discrimina tngs_codigo_1,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint SituacionesIVA_pk primary key clustered
      (
         siv_rcd_codigo
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on SituacionesIVA to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: SituacionesIVA
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : Supervisores
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
/* Selecciono la base en la que se creara la tabla */
/*-------------------------------------------------*/

use TNGS_Carm
go

/*-----------------------------------*/
/* Crea la tabla en la base indicada */
/*-----------------------------------*/

print 'Tabla: Supervisores'

if exists (select * from sysobjects where id = object_id('dbo.Supervisores'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Supervisores
end
go

print '   - Creando la nueva tabla'

create table Supervisores
   (
      sup_cd6_cod tngs_codigo_6,
      sup_nom_apellido tngs_nombre,
      sup_nom_nombre tngs_nombre,
      sup_nom_usuario tngs_nombre,
      sup_tel_tel tngs_telefono,
      sup_tel_cel tngs_telefono,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Supervisores_pk primary key clustered
      (
         sup_cd6_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Supervisores to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Supervisores
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : Talonarios
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
/* Selecciono la base en la que se creara la tabla */
/*-------------------------------------------------*/

use TNGS_Carm
go

/*-----------------------------------*/
/* Crea la tabla en la base indicada */
/*-----------------------------------*/

print 'Tabla: Talonarios'

if exists (select * from sysobjects where id = object_id('dbo.Talonarios'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Talonarios
end
go

print '   - Creando la nueva tabla'

create table Talonarios
   (
      tal_xcd_codigo tngs_codigo_x,
      tal_des_descripcion tngs_descripcion,
      tal_cd1_tipo tngs_codigo_1,
      tal_nro_valor tngs_numero,
      tal_fyh_referencia tngs_fecyhor,
      tal_rob_detalle tngs_observaciones_r,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Talonarios_pk primary key clustered
      (
         tal_xcd_codigo
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Talonarios to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Talonarios
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : TipoCont
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
/* Selecciono la base en la que se creara la tabla */
/*-------------------------------------------------*/

use TNGS_Carm
go

/*-----------------------------------*/
/* Crea la tabla en la base indicada */
/*-----------------------------------*/

print 'Tabla: TipoCont'

if exists (select * from sysobjects where id = object_id('dbo.TipoCont'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.TipoCont
end
go

print '   - Creando la nueva tabla'

create table TipoCont
   (
      tcn_rcd_cod tngs_codigo_r,
      tcn_des_des tngs_descripcion,
      tcn_cd1_modo tngs_codigo_1,
      tcn_rcd_tcontratoavalon tngs_codigo_r,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint TipoCont_pk primary key clustered
      (
         tcn_rcd_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on TipoCont to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: TipoCont
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : TipoInst
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
/* Selecciono la base en la que se creara la tabla */
/*-------------------------------------------------*/

use TNGS_Carm
go

/*-----------------------------------*/
/* Crea la tabla en la base indicada */
/*-----------------------------------*/

print 'Tabla: TipoInst'

if exists (select * from sysobjects where id = object_id('dbo.TipoInst'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.TipoInst
end
go

print '   - Creando la nueva tabla'

create table TipoInst
   (
      tin_cod_cod tngs_codigo,
      tin_des_des tngs_descripcion,
      tin_rcd_codrubro tngs_codigo_r,
      tin_cd1_mayorista tngs_codigo_1,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint TipoInst_pk primary key clustered
      (
         tin_cod_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on TipoInst to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: TipoInst
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : TipoVend
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
/* Selecciono la base en la que se creara la tabla */
/*-------------------------------------------------*/

use TNGS_Carm
go

/*-----------------------------------*/
/* Crea la tabla en la base indicada */
/*-----------------------------------*/

print 'Tabla: TipoVend'

if exists (select * from sysobjects where id = object_id('dbo.TipoVend'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.TipoVend
end
go

print '   - Creando la nueva tabla'

create table TipoVend
   (
      tvn_rcd_cod tngs_codigo_r,
      tvn_des_des tngs_descripcion,
      tvn_cd1_vemayor tngs_codigo_1,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint TipoVend_pk primary key clustered
      (
         tvn_rcd_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on TipoVend to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: TipoVend
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : Vendedores
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
/* Selecciono la base en la que se creara la tabla */
/*-------------------------------------------------*/

use TNGS_Carm
go

/*-----------------------------------*/
/* Crea la tabla en la base indicada */
/*-----------------------------------*/

print 'Tabla: Vendedores'

if exists (select * from sysobjects where id = object_id('dbo.Vendedores'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Vendedores
end
go

print '   - Creando la nueva tabla'

create table Vendedores
   (
      vnd_cd6_cod tngs_codigo_6,
      vnd_des_apellido tngs_descripcion,
      vnd_des_nombre tngs_descripcion,
      vnd_nom_usuario tngs_nombre,
      vnd_tel_tel1 tngs_telefono,
      vnd_tel_celular tngs_telefono,
      vnd_tel_tel2 tngs_telefono,
      vnd_fec_fecnacim tngs_fecha,
      vnd_ede_direccion tngs_descripcion_e,
      vnd_cd6_codsuperv tngs_codigo_6,
      vnd_rcd_codtvend tngs_codigo_r,
      vnd_txt_horarios tngs_texto,
      vnd_cd1_historico tngs_codigo_1,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Vendedores_pk primary key clustered
      (
         vnd_cd6_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Vendedores to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Vendedores
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : Zonas
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
/* Selecciono la base en la que se creara la tabla */
/*-------------------------------------------------*/

use TNGS_Carm
go

/*-----------------------------------*/
/* Crea la tabla en la base indicada */
/*-----------------------------------*/

print 'Tabla: Zonas'

if exists (select * from sysobjects where id = object_id('dbo.Zonas'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Zonas
end
go

print '   - Creando la nueva tabla'

create table Zonas
   (
      zns_rcd_cod tngs_codigo_r,
      zns_des_nombre tngs_descripcion,
      zns_txt_geoloc tngs_texto,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Zonas_pk primary key clustered
      (
         zns_rcd_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Zonas to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Zonas
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Indices)                    
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : Clientes
//----------------------------------------------------------------------------
// © 1999-2021 by TNG Software                                      Gndr 5.20
//---------------------------------------------------------------------------*/

/* ***************************************************************************
/  Atencion!!!
/     Este archivo fue generado por un programa en forma automática. Cualquier
/     modificación que se realize sobre él se perderá en la próxima
/     regeneración.
/  **************************************************************************/

/*-----------------------------------------------------*/
/* Selecciono la base en la que se crearan los indices */
/*-----------------------------------------------------*/

use TNGS_Carm
go

/*-----------------------------------------------
// Crea el indice: is1
//-----------------------------------------------*/

print 'Indice: Clientes_is1'

print '    - Creando el nuevo indice'

create index Clientes_is1 on Clientes
   (
       cli_cd6_codvend
   )
go

print '  '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los indices de la tabla: Clientes
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Indices)                    
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : CliEntrevistas
//----------------------------------------------------------------------------
// © 1999-2021 by TNG Software                                      Gndr 5.20
//---------------------------------------------------------------------------*/

/* ***************************************************************************
/  Atencion!!!
/     Este archivo fue generado por un programa en forma automática. Cualquier
/     modificación que se realize sobre él se perderá en la próxima
/     regeneración.
/  **************************************************************************/

/*-----------------------------------------------------*/
/* Selecciono la base en la que se crearan los indices */
/*-----------------------------------------------------*/

use TNGS_Carm
go

/*-----------------------------------------------
// Crea el indice: is1
//-----------------------------------------------*/

print 'Indice: CliEntrevistas_is1'

print '    - Creando el nuevo indice'

create index CliEntrevistas_is1 on CliEntrevistas
   (
       cle_cd6_codvend,cle_fyh_fcoordinada
   )
go

print '  '
go

/*-----------------------------------------------
// Crea el indice: is2
//-----------------------------------------------*/

print 'Indice: CliEntrevistas_is2'

print '    - Creando el nuevo indice'

create index CliEntrevistas_is2 on CliEntrevistas
   (
       cle_fyh_frealizada
   )
go

print '  '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los indices de la tabla: CliEntrevistas
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software Fcts Generator
//----------------------------------------------------------------------------
// Fecha       : 05/02/2021 12:21
// Sistema     : Carm
// Tabla       : CategoriasLlamada
//----------------------------------------------------------------------------
// © 1999-2021 by TNG Software                                      Gndr 5.20
//---------------------------------------------------------------------------*/

/* ***************************************************************************
/  Atencion!!!
/     Este archivo fue generado por un programa en forma automática. Cualquier
/     modificación que se realize sobre él se perderá en la próxima
/     regeneración.
/  **************************************************************************/

/*--------------------------------------------------*/
/* Selecciono la base en la que se crearan las Fcts */
/*--------------------------------------------------*/

use TNGS_Carm
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Función : GetTipo
--- </summary>
--- <param name="@tipo">Tipo de Llamada</param>
---
---////////////////////////////////////////////////////////

print 'Function: CATEGORIASLLAMADA_GETTIPO'

if exists (select * from sysobjects where id = object_id('CATEGORIASLLAMADA_GETTIPO'))
begin
   print '       - Borrando la vieja Función'
   drop function CATEGORIASLLAMADA_GETTIPO
end
go

print '       - Creando la nueva Función'
go

create function CATEGORIASLLAMADA_GETTIPO
(
@tipo tngs_codigo_1
)
returns varchar(10)
as
begin

   declare @ret varchar(10) 
    
   select @ret =  case @tipo 
                      when 'E' then 'Entrante' 
                      else 'Saliente' 
                  end 
    
   return @ret 

end
go

print '       - Asignando permisos a la Función'

grant execute on CATEGORIASLLAMADA_GETTIPO to tngsmodulos
grant execute on CATEGORIASLLAMADA_GETTIPO to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de las Funciones de la tabla: CategoriasLlamada
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software Fcts Generator
//----------------------------------------------------------------------------
// Fecha       : 05/02/2021 12:21
// Sistema     : Carm
// Tabla       : CliContactos
//----------------------------------------------------------------------------
// © 1999-2021 by TNG Software                                      Gndr 5.20
//---------------------------------------------------------------------------*/

/* ***************************************************************************
/  Atencion!!!
/     Este archivo fue generado por un programa en forma automática. Cualquier
/     modificación que se realize sobre él se perderá en la próxima
/     regeneración.
/  **************************************************************************/

/*--------------------------------------------------*/
/* Selecciono la base en la que se crearan las Fcts */
/*--------------------------------------------------*/

use TNGS_Carm
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Función : EstaActivo
--- </summary>
--- <param name="@numcliente">Numero del Cliente</param>
--- <param name="@numcontacto">Numero del Contacto</param>
---
---////////////////////////////////////////////////////////

print 'Function: CLICONTACTOS_ESTAACTIVO'

if exists (select * from sysobjects where id = object_id('CLICONTACTOS_ESTAACTIVO'))
begin
   print '       - Borrando la vieja Función'
   drop function CLICONTACTOS_ESTAACTIVO
end
go

print '       - Creando la nueva Función'
go

create function CLICONTACTOS_ESTAACTIVO
(
@numcliente tngs_numero,
@numcontacto tngs_numero
)
returns char(1)
as
begin

   declare @ret char(1) 
    
   select @ret = case 
                    when CliContactos.deleted = 0 then 'S' 
                    else 'N' 
                 end 
     from TNGS_Carm..CliContactos 
     where clc_nro_numcliente = @numcliente 
   			and clc_nro_numcontacto = @numcontacto 
    
   return @ret 

end
go

print '       - Asignando permisos a la Función'

grant execute on CLICONTACTOS_ESTAACTIVO to tngsmodulos
grant execute on CLICONTACTOS_ESTAACTIVO to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de las Funciones de la tabla: CliContactos
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software Fcts Generator
//----------------------------------------------------------------------------
// Fecha       : 05/02/2021 12:21
// Sistema     : Carm
// Tabla       : Clientes
//----------------------------------------------------------------------------
// © 1999-2021 by TNG Software                                      Gndr 5.20
//---------------------------------------------------------------------------*/

/* ***************************************************************************
/  Atencion!!!
/     Este archivo fue generado por un programa en forma automática. Cualquier
/     modificación que se realize sobre él se perderá en la próxima
/     regeneración.
/  **************************************************************************/

/*--------------------------------------------------*/
/* Selecciono la base en la que se crearan las Fcts */
/*--------------------------------------------------*/

use TNGS_Carm
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Función : EntrevPendientes
--- </summary>
--- <param name="@cliente">Numero de cliente</param>
---
---////////////////////////////////////////////////////////

print 'Function: CLIENTES_ENTREVPENDIENTES'

if exists (select * from sysobjects where id = object_id('CLIENTES_ENTREVPENDIENTES'))
begin
   print '       - Borrando la vieja Función'
   drop function CLIENTES_ENTREVPENDIENTES
end
go

print '       - Creando la nueva Función'
go

create function CLIENTES_ENTREVPENDIENTES
(
@cliente tngs_numero
)
returns char(1)
as
begin

   declare @ret char(1) 
    
   select @ret = case 
                    when count(*) > 0 then 'S' 
                    else ' ' 
                 end 
     from TNGS_Carm..CliEntrevistas 
    where cle_nro_numcliente = @cliente 
      and year(cle_fyh_frealizada) = 1900 
      and cle_fyh_fcoordinada > getdate() 
      and TNGS_Carm..CliEntrevistas.deleted = 0.0000 
    
    
   return @ret 

end
go

print '       - Asignando permisos a la Función'

grant execute on CLIENTES_ENTREVPENDIENTES to tngsmodulos
grant execute on CLIENTES_ENTREVPENDIENTES to tngsqbe

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Función : EntrevRealizadas
--- </summary>
--- <param name="@cliente">Numero de cliente</param>
---
---////////////////////////////////////////////////////////

print 'Function: CLIENTES_ENTREVREALIZADAS'

if exists (select * from sysobjects where id = object_id('CLIENTES_ENTREVREALIZADAS'))
begin
   print '       - Borrando la vieja Función'
   drop function CLIENTES_ENTREVREALIZADAS
end
go

print '       - Creando la nueva Función'
go

create function CLIENTES_ENTREVREALIZADAS
(
@cliente tngs_numero
)
returns int
as
begin

   declare @ret int 
    
   select @ret = count(*) 
     from TNGS_Carm..CliEntrevistas 
    where cle_nro_numcliente = @cliente 
      and year(cle_fyh_frealizada) <> 1900 
      and TNGS_Carm..CliEntrevistas.deleted = 0.0000 
    
   return @ret 

end
go

print '       - Asignando permisos a la Función'

grant execute on CLIENTES_ENTREVREALIZADAS to tngsmodulos
grant execute on CLIENTES_ENTREVREALIZADAS to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de las Funciones de la tabla: Clientes
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software Fcts Generator
//----------------------------------------------------------------------------
// Fecha       : 05/02/2021 12:21
// Sistema     : Carm
// Tabla       : CliEntrevistas
//----------------------------------------------------------------------------
// © 1999-2021 by TNG Software                                      Gndr 5.20
//---------------------------------------------------------------------------*/

/* ***************************************************************************
/  Atencion!!!
/     Este archivo fue generado por un programa en forma automática. Cualquier
/     modificación que se realize sobre él se perderá en la próxima
/     regeneración.
/  **************************************************************************/

/*--------------------------------------------------*/
/* Selecciono la base en la que se crearan las Fcts */
/*--------------------------------------------------*/

use TNGS_Carm
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Función : FueBorrada
--- </summary>
--- <param name="@numcliente">Numero del Cliente</param>
--- <param name="@numentrev">Numero de la Entrevista</param>
---
---////////////////////////////////////////////////////////

print 'Function: CLIENTREVISTAS_FUEBORRADA'

if exists (select * from sysobjects where id = object_id('CLIENTREVISTAS_FUEBORRADA'))
begin
   print '       - Borrando la vieja Función'
   drop function CLIENTREVISTAS_FUEBORRADA
end
go

print '       - Creando la nueva Función'
go

create function CLIENTREVISTAS_FUEBORRADA
(
@numcliente tngs_numero,
@numentrev tngs_numero
)
returns char(1)
as
begin

   declare @ret char(1) 
    
   select @ret = case 
                    when CliEntrevistas.deleted = 0.0000 then 'N' 
                    else 'S' 
                 end 
     from TNGS_Carm..CliEntrevistas 
     where cle_nro_numcliente = @numcliente 
   			and cle_nro_numentrev = @numentrev 
    
   return @ret 

end
go

print '       - Asignando permisos a la Función'

grant execute on CLIENTREVISTAS_FUEBORRADA to tngsmodulos
grant execute on CLIENTREVISTAS_FUEBORRADA to tngsqbe

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Función : GetEsPendiente
--- </summary>
--- <param name="@numentrev">Numero Entrevista</param>
--- <param name="@numcliente">Numero Cliente</param>
---
---////////////////////////////////////////////////////////

print 'Function: CLIENTREVISTAS_GETESPENDIENTE'

if exists (select * from sysobjects where id = object_id('CLIENTREVISTAS_GETESPENDIENTE'))
begin
   print '       - Borrando la vieja Función'
   drop function CLIENTREVISTAS_GETESPENDIENTE
end
go

print '       - Creando la nueva Función'
go

create function CLIENTREVISTAS_GETESPENDIENTE
(
@numentrev tngs_numero,
@numcliente tngs_numero
)
returns varchar(1)
as
begin

   declare @ret varchar(1) 
    
   select @ret =  case when year (cle_fyh_frealizada) = 1900 then 'S' 
         else 'N' end 
     from TNGS_Carm..CliEntrevistas 
    
   where cle_nro_numcliente = @numcliente and 
         cle_nro_numentrev = @numentrev 
    
    
    
   return @ret 

end
go

print '       - Asignando permisos a la Función'

grant execute on CLIENTREVISTAS_GETESPENDIENTE to tngsmodulos
grant execute on CLIENTREVISTAS_GETESPENDIENTE to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de las Funciones de la tabla: CliEntrevistas
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software Fcts Generator
//----------------------------------------------------------------------------
// Fecha       : 05/02/2021 12:21
// Sistema     : Carm
// Tabla       : CliNotas
//----------------------------------------------------------------------------
// © 1999-2021 by TNG Software                                      Gndr 5.20
//---------------------------------------------------------------------------*/

/* ***************************************************************************
/  Atencion!!!
/     Este archivo fue generado por un programa en forma automática. Cualquier
/     modificación que se realize sobre él se perderá en la próxima
/     regeneración.
/  **************************************************************************/

/*--------------------------------------------------*/
/* Selecciono la base en la que se crearan las Fcts */
/*--------------------------------------------------*/

use TNGS_Carm
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Función : EstaBorrada
--- </summary>
--- <param name="@nrocliente">Numero del Cliente</param>
--- <param name="@fyhcreada">Fecha y Hora en que fue Creada</param>
---
---////////////////////////////////////////////////////////

print 'Function: CLINOTAS_ESTABORRADA'

if exists (select * from sysobjects where id = object_id('CLINOTAS_ESTABORRADA'))
begin
   print '       - Borrando la vieja Función'
   drop function CLINOTAS_ESTABORRADA
end
go

print '       - Creando la nueva Función'
go

create function CLINOTAS_ESTABORRADA
(
@nrocliente tngs_numero,
@fyhcreada tngs_fecyhor
)
returns char(1)
as
begin

   declare @ret char(1) 
    
   select @ret = case 
                    when ltrim(rtrim(CliNotas.cln_nom_removedor)) = '' then 'N' 
                    else 'S' 
                 end 
     from TNGS_Carm..CliNotas 
     where cln_nro_numcliente = @nrocliente 
   			and cln_fyh_fechayhora = @fyhcreada 
    
   return @ret 

end
go

print '       - Asignando permisos a la Función'

grant execute on CLINOTAS_ESTABORRADA to tngsmodulos
grant execute on CLINOTAS_ESTABORRADA to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de las Funciones de la tabla: CliNotas
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software Fcts Generator
//----------------------------------------------------------------------------
// Fecha       : 05/02/2021 12:21
// Sistema     : Carm
// Tabla       : Localidades
//----------------------------------------------------------------------------
// © 1999-2021 by TNG Software                                      Gndr 5.20
//---------------------------------------------------------------------------*/

/* ***************************************************************************
/  Atencion!!!
/     Este archivo fue generado por un programa en forma automática. Cualquier
/     modificación que se realize sobre él se perderá en la próxima
/     regeneración.
/  **************************************************************************/

/*--------------------------------------------------*/
/* Selecciono la base en la que se crearan las Fcts */
/*--------------------------------------------------*/

use TNGS_Carm
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Función : GetDesZona
--- </summary>
--- <param name="@codloc">Codigo de Localidad</param>
---
---////////////////////////////////////////////////////////

print 'Function: LOCALIDADES_GETDESZONA'

if exists (select * from sysobjects where id = object_id('LOCALIDADES_GETDESZONA'))
begin
   print '       - Borrando la vieja Función'
   drop function LOCALIDADES_GETDESZONA
end
go

print '       - Creando la nueva Función'
go

create function LOCALIDADES_GETDESZONA
(
@codloc tngs_codigo_e
)
returns varchar (30)
as
begin

    
   declare @ret varchar (30) 
    
   select @ret = zns_des_nombre from TNGS_Carm..Zonas 
    
   join TNGS_Carm..Localidades on loc_rcd_codzona = zns_rcd_cod 
    
   where loc_ecd_codpost = @codloc 
    
   return @ret 

end
go

print '       - Asignando permisos a la Función'

grant execute on LOCALIDADES_GETDESZONA to tngsmodulos
grant execute on LOCALIDADES_GETDESZONA to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de las Funciones de la tabla: Localidades
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software Fcts Generator
//----------------------------------------------------------------------------
// Fecha       : 05/02/2021 12:21
// Sistema     : Carm
// Tabla       : Vendedores
//----------------------------------------------------------------------------
// © 1999-2021 by TNG Software                                      Gndr 5.20
//---------------------------------------------------------------------------*/

/* ***************************************************************************
/  Atencion!!!
/     Este archivo fue generado por un programa en forma automática. Cualquier
/     modificación que se realize sobre él se perderá en la próxima
/     regeneración.
/  **************************************************************************/

/*--------------------------------------------------*/
/* Selecciono la base en la que se crearan las Fcts */
/*--------------------------------------------------*/

use TNGS_Carm
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Función : CantReservasAct
--- </summary>
--- <param name="@codvend">Codigo del Vendedor</param>
---
---////////////////////////////////////////////////////////

print 'Function: VENDEDORES_CANTRESERVASACT'

if exists (select * from sysobjects where id = object_id('VENDEDORES_CANTRESERVASACT'))
begin
   print '       - Borrando la vieja Función'
   drop function VENDEDORES_CANTRESERVASACT
end
go

print '       - Creando la nueva Función'
go

create function VENDEDORES_CANTRESERVASACT
(
@codvend tngs_codigo_6
)
returns int
as
begin

   declare @ret int 
    
   SELECT @ret = COUNT (*) 
    
       FROM TNGS_Carm..Clientes 
    
       WHERE cli_cd6_codvend = @codvend and cli_cd1_alta = 'N' 
    
    
   return @ret 

end
go

print '       - Asignando permisos a la Función'

grant execute on VENDEDORES_CANTRESERVASACT to tngsmodulos
grant execute on VENDEDORES_CANTRESERVASACT to tngsqbe

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Función : GetFullName
--- </summary>
--- <param name="@codvend">Codigo del Vendedor</param>
---
---////////////////////////////////////////////////////////

print 'Function: VENDEDORES_GETFULLNAME'

if exists (select * from sysobjects where id = object_id('VENDEDORES_GETFULLNAME'))
begin
   print '       - Borrando la vieja Función'
   drop function VENDEDORES_GETFULLNAME
end
go

print '       - Creando la nueva Función'
go

create function VENDEDORES_GETFULLNAME
(
@codvend tngs_codigo_6
)
returns varchar(60)
as
begin

   declare @ret varchar(60) 
    
   select @ret =  rtrim(vnd_des_nombre) + ' '+ vnd_des_apellido 
     from TNGS_Carm..Vendedores 
    
      where vnd_cd6_cod = @codvend 
    
    
   return @ret 

end
go

print '       - Asignando permisos a la Función'

grant execute on VENDEDORES_GETFULLNAME to tngsmodulos
grant execute on VENDEDORES_GETFULLNAME to tngsqbe

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Función : GetJefeVentas
--- </summary>
--- <param name="@codvend">Codigo de Vendedor</param>
---
---////////////////////////////////////////////////////////

print 'Function: VENDEDORES_GETJEFEVENTAS'

if exists (select * from sysobjects where id = object_id('VENDEDORES_GETJEFEVENTAS'))
begin
   print '       - Borrando la vieja Función'
   drop function VENDEDORES_GETJEFEVENTAS
end
go

print '       - Creando la nueva Función'
go

create function VENDEDORES_GETJEFEVENTAS
(
@codvend tngs_codigo_6
)
returns varchar(60)
as
begin

   declare @ret varchar(60) 
    
   select @ret = rtrim(jvt_nom_nombre) + ' '+ jvt_nom_apellido 
     from TNGS_Carm..JefesVentas 
     join TNGS_Carm..Supervisores on sup_cd6_codjefevtas = jvt_cd6_cod 
     join TNGS_Carm..Vendedores on vnd_cd6_codsuperv = sup_cd6_cod 
    
      where vnd_cd6_cod = @codvend 
    
    
   return @ret 

end
go

print '       - Asignando permisos a la Función'

grant execute on VENDEDORES_GETJEFEVENTAS to tngsmodulos
grant execute on VENDEDORES_GETJEFEVENTAS to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de las Funciones de la tabla: Vendedores
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 04/01/2023 00:01
// Sistema     : Carm
// Tabla       : CategoriasLlamada
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

print 'Store Procedure: dbo.CATEGORIASLLAMADA_UP'

if exists (select * from sysobjects where id = object_id('dbo.CATEGORIASLLAMADA_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CATEGORIASLLAMADA_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CATEGORIASLLAMADA_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select ctl_rcd_cod,
                ctl_des_des,
                ctl_cd1_tipo,
                TNGS_Carm..CategoriasLlamada.instante,
                TNGS_Carm..CategoriasLlamada.deleted,
                TNGS_Carm..CategoriasLlamada.usuario,
                TNGS_Carm..CategoriasLlamada.version
           from TNGS_Carm..CategoriasLlamada
          where deleted = 0
          order by ctl_rcd_cod
      end
   else
      begin
         Select ctl_rcd_cod,
                ctl_des_des,
                ctl_cd1_tipo,
                TNGS_Carm..CategoriasLlamada.instante,
                TNGS_Carm..CategoriasLlamada.deleted,
                TNGS_Carm..CategoriasLlamada.usuario,
                TNGS_Carm..CategoriasLlamada.version
           from TNGS_Carm..CategoriasLlamada
          order by ctl_rcd_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CATEGORIASLLAMADA_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@ctl_rcd_cod">Codigo</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CATEGORIASLLAMADA_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.CATEGORIASLLAMADA_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CATEGORIASLLAMADA_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CATEGORIASLLAMADA_CHKVERSION
(
@ctl_rcd_cod tngs_codigo_r,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Carm..CategoriasLlamada
    where ctl_rcd_cod = @ctl_rcd_cod
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CATEGORIASLLAMADA_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@ctl_rcd_cod">Codigo</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CATEGORIASLLAMADA_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.CATEGORIASLLAMADA_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CATEGORIASLLAMADA_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CATEGORIASLLAMADA_SEARCH
(
@ctl_rcd_cod tngs_codigo_r,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select ctl_rcd_cod,
                ctl_des_des,
                ctl_cd1_tipo,
                TNGS_Carm..CategoriasLlamada.instante,
                TNGS_Carm..CategoriasLlamada.deleted,
                TNGS_Carm..CategoriasLlamada.usuario,
                TNGS_Carm..CategoriasLlamada.version
           from TNGS_Carm..CategoriasLlamada
          where ctl_rcd_cod = @ctl_rcd_cod
            and deleted = 0
      end
   else
      begin
         Select ctl_rcd_cod,
                ctl_des_des,
                ctl_cd1_tipo,
                TNGS_Carm..CategoriasLlamada.instante,
                TNGS_Carm..CategoriasLlamada.deleted,
                TNGS_Carm..CategoriasLlamada.usuario,
                TNGS_Carm..CategoriasLlamada.version
           from TNGS_Carm..CategoriasLlamada
          where ctl_rcd_cod = @ctl_rcd_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CATEGORIASLLAMADA_SEARCH to tngsmodulos

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

print 'Store Procedure: dbo.CATEGORIASLLAMADA_GETMAXKEY'

if exists (select * from sysobjects where id = object_id('dbo.CATEGORIASLLAMADA_GETMAXKEY'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CATEGORIASLLAMADA_GETMAXKEY
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CATEGORIASLLAMADA_GETMAXKEY
(
@dummy tngs_codigo_1
)
as
begin

   Select isnull(max(ctl_rcd_cod), '0') as ctl_rcd_cod
     from TNGS_Carm..CategoriasLlamada

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CATEGORIASLLAMADA_GETMAXKEY to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@ctl_rcd_cod">Codigo</param>
--- <param name="@ctl_des_des">Categoría</param>
--- <param name="@ctl_cd1_tipo">Tipo de llamada</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CATEGORIASLLAMADA_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.CATEGORIASLLAMADA_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CATEGORIASLLAMADA_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CATEGORIASLLAMADA_INSERT
(
@ctl_rcd_cod tngs_codigo_r,
@ctl_des_des tngs_descripcion,
@ctl_cd1_tipo tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Carm..CategoriasLlamada
   values (
           @ctl_rcd_cod,
           @ctl_des_des,
           @ctl_cd1_tipo,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CATEGORIASLLAMADA_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@ctl_rcd_cod">Codigo</param>
--- <param name="@ctl_des_des">Categoría</param>
--- <param name="@ctl_cd1_tipo">Tipo de llamada</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CATEGORIASLLAMADA_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.CATEGORIASLLAMADA_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CATEGORIASLLAMADA_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CATEGORIASLLAMADA_UPDATE
(
@ctl_rcd_cod tngs_codigo_r,
@ctl_des_des tngs_descripcion,
@ctl_cd1_tipo tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..CategoriasLlamada
      set ctl_des_des= @ctl_des_des,
          ctl_cd1_tipo= @ctl_cd1_tipo,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where ctl_rcd_cod = @ctl_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CATEGORIASLLAMADA_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@ctl_rcd_cod">Codigo</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CATEGORIASLLAMADA_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.CATEGORIASLLAMADA_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CATEGORIASLLAMADA_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CATEGORIASLLAMADA_DELETE
(
@ctl_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..CategoriasLlamada
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where ctl_rcd_cod = @ctl_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CATEGORIASLLAMADA_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@ctl_rcd_cod">Codigo</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CATEGORIASLLAMADA_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.CATEGORIASLLAMADA_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CATEGORIASLLAMADA_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CATEGORIASLLAMADA_RECALL
(
@ctl_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..CategoriasLlamada
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where ctl_rcd_cod = @ctl_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CATEGORIASLLAMADA_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@ctl_rcd_cod">Codigo</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CATEGORIASLLAMADA_DROP'

if exists (select * from sysobjects where id = object_id('dbo.CATEGORIASLLAMADA_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CATEGORIASLLAMADA_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CATEGORIASLLAMADA_DROP
(
@ctl_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..CategoriasLlamada
    where ctl_rcd_cod = @ctl_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CATEGORIASLLAMADA_DROP to tngsmodulos

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

print 'Store Procedure: dbo.CATEGORIASLLAMADA_PACK'

if exists (select * from sysobjects where id = object_id('dbo.CATEGORIASLLAMADA_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CATEGORIASLLAMADA_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CATEGORIASLLAMADA_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Carm..CategoriasLlamada
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CATEGORIASLLAMADA_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: CategoriasLlamada
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 04/01/2023 00:01
// Sistema     : Carm
// Tabla       : CliContactos
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

print 'Store Procedure: dbo.CLICONTACTOS_UP'

if exists (select * from sysobjects where id = object_id('dbo.CLICONTACTOS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLICONTACTOS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLICONTACTOS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select clc_nro_numcliente,
                cli_ede_rsocial as clc_des_rsocial,
                clc_nro_numcontacto,
                clc_des_nombre,
                clc_des_cargo,
                clc_des_titulo,
                TNGS_Carm.dbo.CliContactos_EstaActivo (clc_nro_numcliente,clc_nro_numcontacto) as clc_cd1_activo,
                clc_tel_celular,
                clc_tel_telefono1,
                clc_tel_telefono2,
                clc_tel_interno,
                clc_xld_email,
                clc_des_secretaria,
                TNGS_Carm..CliContactos.instante,
                TNGS_Carm..CliContactos.deleted,
                TNGS_Carm..CliContactos.usuario,
                TNGS_Carm..CliContactos.version
           from TNGS_Carm..CliContactos
                join TNGS_Carm..Clientes
                  on clc_nro_numcliente = cli_nro_numero
          where TNGS_Carm..CliContactos.deleted = 0
          order by clc_nro_numcliente,
                clc_nro_numcontacto
      end
   else
      begin
         Select clc_nro_numcliente,
                cli_ede_rsocial as clc_des_rsocial,
                clc_nro_numcontacto,
                clc_des_nombre,
                clc_des_cargo,
                clc_des_titulo,
                TNGS_Carm.dbo.CliContactos_EstaActivo (clc_nro_numcliente,clc_nro_numcontacto) as clc_cd1_activo,
                clc_tel_celular,
                clc_tel_telefono1,
                clc_tel_telefono2,
                clc_tel_interno,
                clc_xld_email,
                clc_des_secretaria,
                TNGS_Carm..CliContactos.instante,
                TNGS_Carm..CliContactos.deleted,
                TNGS_Carm..CliContactos.usuario,
                TNGS_Carm..CliContactos.version
           from TNGS_Carm..CliContactos
                join TNGS_Carm..Clientes
                  on clc_nro_numcliente = cli_nro_numero
          order by clc_nro_numcliente,
                clc_nro_numcontacto
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLICONTACTOS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@clc_nro_numcliente">Número de cliente</param>
--- <param name="@clc_nro_numcontacto">Número</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLICONTACTOS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.CLICONTACTOS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLICONTACTOS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLICONTACTOS_CHKVERSION
(
@clc_nro_numcliente tngs_numero,
@clc_nro_numcontacto tngs_numero,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Carm..CliContactos
    where clc_nro_numcliente = @clc_nro_numcliente
      and clc_nro_numcontacto = @clc_nro_numcontacto
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLICONTACTOS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@clc_nro_numcliente">Número de cliente</param>
--- <param name="@clc_nro_numcontacto">Número</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLICONTACTOS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.CLICONTACTOS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLICONTACTOS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLICONTACTOS_SEARCH
(
@clc_nro_numcliente tngs_numero,
@clc_nro_numcontacto tngs_numero,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select clc_nro_numcliente,
                cli_ede_rsocial as clc_des_rsocial,
                clc_nro_numcontacto,
                clc_des_nombre,
                clc_des_cargo,
                clc_des_titulo,
                TNGS_Carm.dbo.CliContactos_EstaActivo (clc_nro_numcliente,clc_nro_numcontacto) as clc_cd1_activo,
                clc_tel_celular,
                clc_tel_telefono1,
                clc_tel_telefono2,
                clc_tel_interno,
                clc_xld_email,
                clc_des_secretaria,
                TNGS_Carm..CliContactos.instante,
                TNGS_Carm..CliContactos.deleted,
                TNGS_Carm..CliContactos.usuario,
                TNGS_Carm..CliContactos.version
           from TNGS_Carm..CliContactos
                join TNGS_Carm..Clientes
                  on clc_nro_numcliente = cli_nro_numero
          where clc_nro_numcliente = @clc_nro_numcliente
            and clc_nro_numcontacto = @clc_nro_numcontacto
            and TNGS_Carm..CliContactos.deleted = 0
      end
   else
      begin
         Select clc_nro_numcliente,
                cli_ede_rsocial as clc_des_rsocial,
                clc_nro_numcontacto,
                clc_des_nombre,
                clc_des_cargo,
                clc_des_titulo,
                TNGS_Carm.dbo.CliContactos_EstaActivo (clc_nro_numcliente,clc_nro_numcontacto) as clc_cd1_activo,
                clc_tel_celular,
                clc_tel_telefono1,
                clc_tel_telefono2,
                clc_tel_interno,
                clc_xld_email,
                clc_des_secretaria,
                TNGS_Carm..CliContactos.instante,
                TNGS_Carm..CliContactos.deleted,
                TNGS_Carm..CliContactos.usuario,
                TNGS_Carm..CliContactos.version
           from TNGS_Carm..CliContactos
                join TNGS_Carm..Clientes
                  on clc_nro_numcliente = cli_nro_numero
          where clc_nro_numcliente = @clc_nro_numcliente
            and clc_nro_numcontacto = @clc_nro_numcontacto
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLICONTACTOS_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca los registros de una clave foranea
--- </summary>
--- <param name="@clc_nro_numcliente">Número de cliente</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLICONTACTOS_FSEARCH'

if exists (select * from sysobjects where id = object_id('dbo.CLICONTACTOS_FSEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLICONTACTOS_FSEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLICONTACTOS_FSEARCH
(
@clc_nro_numcliente tngs_numero,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select clc_nro_numcliente,
                cli_ede_rsocial as clc_des_rsocial,
                clc_nro_numcontacto,
                clc_des_nombre,
                clc_des_cargo,
                clc_des_titulo,
                TNGS_Carm.dbo.CliContactos_EstaActivo (clc_nro_numcliente,clc_nro_numcontacto) as clc_cd1_activo,
                clc_tel_celular,
                clc_tel_telefono1,
                clc_tel_telefono2,
                clc_tel_interno,
                clc_xld_email,
                clc_des_secretaria,
                TNGS_Carm..CliContactos.instante,
                TNGS_Carm..CliContactos.deleted,
                TNGS_Carm..CliContactos.usuario,
                TNGS_Carm..CliContactos.version
           from TNGS_Carm..CliContactos
                join TNGS_Carm..Clientes
                  on clc_nro_numcliente = cli_nro_numero
          where clc_nro_numcliente = @clc_nro_numcliente
            and TNGS_Carm..CliContactos.deleted = 0
          order by clc_nro_numcontacto
      end
   else
      begin
         Select clc_nro_numcliente,
                cli_ede_rsocial as clc_des_rsocial,
                clc_nro_numcontacto,
                clc_des_nombre,
                clc_des_cargo,
                clc_des_titulo,
                TNGS_Carm.dbo.CliContactos_EstaActivo (clc_nro_numcliente,clc_nro_numcontacto) as clc_cd1_activo,
                clc_tel_celular,
                clc_tel_telefono1,
                clc_tel_telefono2,
                clc_tel_interno,
                clc_xld_email,
                clc_des_secretaria,
                TNGS_Carm..CliContactos.instante,
                TNGS_Carm..CliContactos.deleted,
                TNGS_Carm..CliContactos.usuario,
                TNGS_Carm..CliContactos.version
           from TNGS_Carm..CliContactos
                join TNGS_Carm..Clientes
                  on clc_nro_numcliente = cli_nro_numero
          where clc_nro_numcliente = @clc_nro_numcliente
          order by clc_nro_numcontacto
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLICONTACTOS_FSEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@clc_nro_numcliente">Número de cliente</param>
--- <param name="@clc_nro_numcontacto">Número</param>
--- <param name="@clc_des_nombre">Apellido y Nombre</param>
--- <param name="@clc_des_cargo">Cargo</param>
--- <param name="@clc_des_titulo">Título</param>
--- <param name="@clc_tel_celular">Celular</param>
--- <param name="@clc_tel_telefono1">Teléfono 1</param>
--- <param name="@clc_tel_telefono2">Teléfono 2</param>
--- <param name="@clc_tel_interno">Interno</param>
--- <param name="@clc_xld_email">Email</param>
--- <param name="@clc_des_secretaria">Secretaria</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLICONTACTOS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.CLICONTACTOS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLICONTACTOS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLICONTACTOS_INSERT
(
@clc_nro_numcliente tngs_numero,
@clc_nro_numcontacto tngs_numero,
@clc_des_nombre tngs_descripcion,
@clc_des_cargo tngs_descripcion,
@clc_des_titulo tngs_descripcion,
@clc_tel_celular tngs_telefono,
@clc_tel_telefono1 tngs_telefono,
@clc_tel_telefono2 tngs_telefono,
@clc_tel_interno tngs_telefono,
@clc_xld_email tngs_descripcion_xl,
@clc_des_secretaria tngs_descripcion,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Carm..CliContactos
   values (
           @clc_nro_numcliente,
           @clc_nro_numcontacto,
           @clc_des_nombre,
           @clc_des_cargo,
           @clc_des_titulo,
           @clc_tel_celular,
           @clc_tel_telefono1,
           @clc_tel_telefono2,
           @clc_tel_interno,
           @clc_xld_email,
           @clc_des_secretaria,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLICONTACTOS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@clc_nro_numcliente">Número de cliente</param>
--- <param name="@clc_nro_numcontacto">Número</param>
--- <param name="@clc_des_nombre">Apellido y Nombre</param>
--- <param name="@clc_des_cargo">Cargo</param>
--- <param name="@clc_des_titulo">Título</param>
--- <param name="@clc_tel_celular">Celular</param>
--- <param name="@clc_tel_telefono1">Teléfono 1</param>
--- <param name="@clc_tel_telefono2">Teléfono 2</param>
--- <param name="@clc_tel_interno">Interno</param>
--- <param name="@clc_xld_email">Email</param>
--- <param name="@clc_des_secretaria">Secretaria</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLICONTACTOS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.CLICONTACTOS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLICONTACTOS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLICONTACTOS_UPDATE
(
@clc_nro_numcliente tngs_numero,
@clc_nro_numcontacto tngs_numero,
@clc_des_nombre tngs_descripcion,
@clc_des_cargo tngs_descripcion,
@clc_des_titulo tngs_descripcion,
@clc_tel_celular tngs_telefono,
@clc_tel_telefono1 tngs_telefono,
@clc_tel_telefono2 tngs_telefono,
@clc_tel_interno tngs_telefono,
@clc_xld_email tngs_descripcion_xl,
@clc_des_secretaria tngs_descripcion,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..CliContactos
      set clc_des_nombre= @clc_des_nombre,
          clc_des_cargo= @clc_des_cargo,
          clc_des_titulo= @clc_des_titulo,
          clc_tel_celular= @clc_tel_celular,
          clc_tel_telefono1= @clc_tel_telefono1,
          clc_tel_telefono2= @clc_tel_telefono2,
          clc_tel_interno= @clc_tel_interno,
          clc_xld_email= @clc_xld_email,
          clc_des_secretaria= @clc_des_secretaria,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where clc_nro_numcliente = @clc_nro_numcliente
      and clc_nro_numcontacto = @clc_nro_numcontacto

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLICONTACTOS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@clc_nro_numcliente">Número de cliente</param>
--- <param name="@clc_nro_numcontacto">Número</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLICONTACTOS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.CLICONTACTOS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLICONTACTOS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLICONTACTOS_DELETE
(
@clc_nro_numcliente tngs_numero,
@clc_nro_numcontacto tngs_numero,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..CliContactos
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where clc_nro_numcliente = @clc_nro_numcliente
      and clc_nro_numcontacto = @clc_nro_numcontacto

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLICONTACTOS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro por clave foranea
--- </summary>
--- <param name="@clc_nro_numcliente">Número de cliente</param>
--- <param name="@instante">Instante del delete</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLICONTACTOS_FDELETE'

if exists (select * from sysobjects where id = object_id('dbo.CLICONTACTOS_FDELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLICONTACTOS_FDELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLICONTACTOS_FDELETE
(
@clc_nro_numcliente tngs_numero,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         select @instante= getdate()
      end

   Update TNGS_Carm..CliContactos
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= @instante,
          usuario = @usuario
    where clc_nro_numcliente = @clc_nro_numcliente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLICONTACTOS_FDELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@clc_nro_numcliente">Número de cliente</param>
--- <param name="@clc_nro_numcontacto">Número</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLICONTACTOS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.CLICONTACTOS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLICONTACTOS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLICONTACTOS_RECALL
(
@clc_nro_numcliente tngs_numero,
@clc_nro_numcontacto tngs_numero,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..CliContactos
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where clc_nro_numcliente = @clc_nro_numcliente
      and clc_nro_numcontacto = @clc_nro_numcontacto

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLICONTACTOS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera lógicamente los registros de una clave foranea
--- </summary>
--- <param name="@clc_nro_numcliente">Número de cliente</param>
--- <param name="@instante">Instante de referencia</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLICONTACTOS_FRECALL'

if exists (select * from sysobjects where id = object_id('dbo.CLICONTACTOS_FRECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLICONTACTOS_FRECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLICONTACTOS_FRECALL
(
@clc_nro_numcliente tngs_numero,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         Update TNGS_Carm..CliContactos
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where clc_nro_numcliente = @clc_nro_numcliente
      end
   else
      begin
         Update TNGS_Carm..CliContactos
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where clc_nro_numcliente = @clc_nro_numcliente
            and instante= @instante
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLICONTACTOS_FRECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@clc_nro_numcliente">Número de cliente</param>
--- <param name="@clc_nro_numcontacto">Número</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLICONTACTOS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.CLICONTACTOS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLICONTACTOS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLICONTACTOS_DROP
(
@clc_nro_numcliente tngs_numero,
@clc_nro_numcontacto tngs_numero,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..CliContactos
    where clc_nro_numcliente = @clc_nro_numcliente
      and clc_nro_numcontacto = @clc_nro_numcontacto

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLICONTACTOS_DROP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro por clave foránea
--- </summary>
--- <param name="@clc_nro_numcliente">Número de cliente</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLICONTACTOS_FDROP'

if exists (select * from sysobjects where id = object_id('dbo.CLICONTACTOS_FDROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLICONTACTOS_FDROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLICONTACTOS_FDROP
(
@clc_nro_numcliente tngs_numero,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..CliContactos
    where clc_nro_numcliente = @clc_nro_numcliente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLICONTACTOS_FDROP to tngsmodulos

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

print 'Store Procedure: dbo.CLICONTACTOS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.CLICONTACTOS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLICONTACTOS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLICONTACTOS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Carm..CliContactos
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLICONTACTOS_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente los registro borrados lógicamente por clave foránea
--- </summary>
--- <param name="@clc_nro_numcliente">Número de cliente</param>
--- <param name="@usuario">Usuario que realiza el pack</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLICONTACTOS_FPACK'

if exists (select * from sysobjects where id = object_id('dbo.CLICONTACTOS_FPACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLICONTACTOS_FPACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLICONTACTOS_FPACK
(
@clc_nro_numcliente tngs_numero,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..CliContactos
    where clc_nro_numcliente = @clc_nro_numcliente
      and deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLICONTACTOS_FPACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: BorraPorCliente
--- </summary>
--- <param name="@nrocliente">Numero del cliente a borrar sus contactos</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLICONTACTOS_BORRAPORCLIENTE'

if exists (select * from sysobjects where id = object_id('dbo.CLICONTACTOS_BORRAPORCLIENTE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLICONTACTOS_BORRAPORCLIENTE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLICONTACTOS_BORRAPORCLIENTE
(
@nrocliente tngs_numero,
@usuario tngs_nombre
)
as
begin

   delete from CliContactos 
   where clc_nro_numcliente = @nrocliente 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLICONTACTOS_BORRAPORCLIENTE to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: CliContactos
//--------------------------------------------------------------------------*/
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
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 04/01/2023 00:01
// Sistema     : Carm
// Tabla       : CliEntrevistas
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

print 'Store Procedure: dbo.CLIENTREVISTAS_UP'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTREVISTAS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTREVISTAS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTREVISTAS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select cle_nro_numcliente,
                cle_nro_numentrev,
                TNGS_Carm.dbo.CliEntrevistas_GetEsPendiente(cle_nro_numentrev,cle_nro_numcliente) as cle_cd1_pend,
                cli_ede_rsocial as cle_des_rsocial,
                cle_fyh_fcoordinada,
                cle_fyh_frealizada,
                cle_cd6_codvend,
                TNGS_Carm.dbo.Vendedores_GetFullName(cle_cd6_codvend) as cle_des_vend,
                cle_ede_motcambiof,
                cle_des_nombre,
                TNGS_Carm.dbo.CliEntrevistas_FueBorrada (cle_nro_numcliente,cle_nro_numentrev) as cle_cd1_borrada,
                cle_tel_telefono,
                cle_des_cargo,
                cle_des_titulo,
                cle_tel_celular,
                cle_xld_email,
                cle_xld_direccion,
                cle_txt_observaciones,
                cle_rcd_codresultado,
                cle_ede_informe,
                cle_des_secretaria,
                TNGS_Carm..CliEntrevistas.instante,
                TNGS_Carm..CliEntrevistas.deleted,
                TNGS_Carm..CliEntrevistas.usuario,
                TNGS_Carm..CliEntrevistas.version
           from TNGS_Carm..CliEntrevistas
                join TNGS_Carm..Clientes
                  on cle_nro_numcliente = cli_nro_numero
          where TNGS_Carm..CliEntrevistas.deleted = 0
          order by cle_nro_numcliente,
                cle_nro_numentrev
      end
   else
      begin
         Select cle_nro_numcliente,
                cle_nro_numentrev,
                TNGS_Carm.dbo.CliEntrevistas_GetEsPendiente(cle_nro_numentrev,cle_nro_numcliente) as cle_cd1_pend,
                cli_ede_rsocial as cle_des_rsocial,
                cle_fyh_fcoordinada,
                cle_fyh_frealizada,
                cle_cd6_codvend,
                TNGS_Carm.dbo.Vendedores_GetFullName(cle_cd6_codvend) as cle_des_vend,
                cle_ede_motcambiof,
                cle_des_nombre,
                TNGS_Carm.dbo.CliEntrevistas_FueBorrada (cle_nro_numcliente,cle_nro_numentrev) as cle_cd1_borrada,
                cle_tel_telefono,
                cle_des_cargo,
                cle_des_titulo,
                cle_tel_celular,
                cle_xld_email,
                cle_xld_direccion,
                cle_txt_observaciones,
                cle_rcd_codresultado,
                cle_ede_informe,
                cle_des_secretaria,
                TNGS_Carm..CliEntrevistas.instante,
                TNGS_Carm..CliEntrevistas.deleted,
                TNGS_Carm..CliEntrevistas.usuario,
                TNGS_Carm..CliEntrevistas.version
           from TNGS_Carm..CliEntrevistas
                join TNGS_Carm..Clientes
                  on cle_nro_numcliente = cli_nro_numero
          order by cle_nro_numcliente,
                cle_nro_numentrev
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTREVISTAS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@cle_nro_numcliente">Número de cliente</param>
--- <param name="@cle_nro_numentrev">Número</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTREVISTAS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTREVISTAS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTREVISTAS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTREVISTAS_CHKVERSION
(
@cle_nro_numcliente tngs_numero,
@cle_nro_numentrev tngs_numero,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Carm..CliEntrevistas
    where cle_nro_numcliente = @cle_nro_numcliente
      and cle_nro_numentrev = @cle_nro_numentrev
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTREVISTAS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@cle_nro_numcliente">Número de cliente</param>
--- <param name="@cle_nro_numentrev">Número</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTREVISTAS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTREVISTAS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTREVISTAS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTREVISTAS_SEARCH
(
@cle_nro_numcliente tngs_numero,
@cle_nro_numentrev tngs_numero,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select cle_nro_numcliente,
                cle_nro_numentrev,
                TNGS_Carm.dbo.CliEntrevistas_GetEsPendiente(cle_nro_numentrev,cle_nro_numcliente) as cle_cd1_pend,
                cli_ede_rsocial as cle_des_rsocial,
                cle_fyh_fcoordinada,
                cle_fyh_frealizada,
                cle_cd6_codvend,
                TNGS_Carm.dbo.Vendedores_GetFullName(cle_cd6_codvend) as cle_des_vend,
                cle_ede_motcambiof,
                cle_des_nombre,
                TNGS_Carm.dbo.CliEntrevistas_FueBorrada (cle_nro_numcliente,cle_nro_numentrev) as cle_cd1_borrada,
                cle_tel_telefono,
                cle_des_cargo,
                cle_des_titulo,
                cle_tel_celular,
                cle_xld_email,
                cle_xld_direccion,
                cle_txt_observaciones,
                cle_rcd_codresultado,
                cle_ede_informe,
                cle_des_secretaria,
                TNGS_Carm..CliEntrevistas.instante,
                TNGS_Carm..CliEntrevistas.deleted,
                TNGS_Carm..CliEntrevistas.usuario,
                TNGS_Carm..CliEntrevistas.version
           from TNGS_Carm..CliEntrevistas
                join TNGS_Carm..Clientes
                  on cle_nro_numcliente = cli_nro_numero
          where cle_nro_numcliente = @cle_nro_numcliente
            and cle_nro_numentrev = @cle_nro_numentrev
            and TNGS_Carm..CliEntrevistas.deleted = 0
      end
   else
      begin
         Select cle_nro_numcliente,
                cle_nro_numentrev,
                TNGS_Carm.dbo.CliEntrevistas_GetEsPendiente(cle_nro_numentrev,cle_nro_numcliente) as cle_cd1_pend,
                cli_ede_rsocial as cle_des_rsocial,
                cle_fyh_fcoordinada,
                cle_fyh_frealizada,
                cle_cd6_codvend,
                TNGS_Carm.dbo.Vendedores_GetFullName(cle_cd6_codvend) as cle_des_vend,
                cle_ede_motcambiof,
                cle_des_nombre,
                TNGS_Carm.dbo.CliEntrevistas_FueBorrada (cle_nro_numcliente,cle_nro_numentrev) as cle_cd1_borrada,
                cle_tel_telefono,
                cle_des_cargo,
                cle_des_titulo,
                cle_tel_celular,
                cle_xld_email,
                cle_xld_direccion,
                cle_txt_observaciones,
                cle_rcd_codresultado,
                cle_ede_informe,
                cle_des_secretaria,
                TNGS_Carm..CliEntrevistas.instante,
                TNGS_Carm..CliEntrevistas.deleted,
                TNGS_Carm..CliEntrevistas.usuario,
                TNGS_Carm..CliEntrevistas.version
           from TNGS_Carm..CliEntrevistas
                join TNGS_Carm..Clientes
                  on cle_nro_numcliente = cli_nro_numero
          where cle_nro_numcliente = @cle_nro_numcliente
            and cle_nro_numentrev = @cle_nro_numentrev
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTREVISTAS_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca los registros de una clave foranea
--- </summary>
--- <param name="@cle_nro_numcliente">Número de cliente</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTREVISTAS_FSEARCH'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTREVISTAS_FSEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTREVISTAS_FSEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTREVISTAS_FSEARCH
(
@cle_nro_numcliente tngs_numero,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select cle_nro_numcliente,
                cle_nro_numentrev,
                TNGS_Carm.dbo.CliEntrevistas_GetEsPendiente(cle_nro_numentrev,cle_nro_numcliente) as cle_cd1_pend,
                cli_ede_rsocial as cle_des_rsocial,
                cle_fyh_fcoordinada,
                cle_fyh_frealizada,
                cle_cd6_codvend,
                TNGS_Carm.dbo.Vendedores_GetFullName(cle_cd6_codvend) as cle_des_vend,
                cle_ede_motcambiof,
                cle_des_nombre,
                TNGS_Carm.dbo.CliEntrevistas_FueBorrada (cle_nro_numcliente,cle_nro_numentrev) as cle_cd1_borrada,
                cle_tel_telefono,
                cle_des_cargo,
                cle_des_titulo,
                cle_tel_celular,
                cle_xld_email,
                cle_xld_direccion,
                cle_txt_observaciones,
                cle_rcd_codresultado,
                cle_ede_informe,
                cle_des_secretaria,
                TNGS_Carm..CliEntrevistas.instante,
                TNGS_Carm..CliEntrevistas.deleted,
                TNGS_Carm..CliEntrevistas.usuario,
                TNGS_Carm..CliEntrevistas.version
           from TNGS_Carm..CliEntrevistas
                join TNGS_Carm..Clientes
                  on cle_nro_numcliente = cli_nro_numero
          where cle_nro_numcliente = @cle_nro_numcliente
            and TNGS_Carm..CliEntrevistas.deleted = 0
          order by cle_nro_numentrev
      end
   else
      begin
         Select cle_nro_numcliente,
                cle_nro_numentrev,
                TNGS_Carm.dbo.CliEntrevistas_GetEsPendiente(cle_nro_numentrev,cle_nro_numcliente) as cle_cd1_pend,
                cli_ede_rsocial as cle_des_rsocial,
                cle_fyh_fcoordinada,
                cle_fyh_frealizada,
                cle_cd6_codvend,
                TNGS_Carm.dbo.Vendedores_GetFullName(cle_cd6_codvend) as cle_des_vend,
                cle_ede_motcambiof,
                cle_des_nombre,
                TNGS_Carm.dbo.CliEntrevistas_FueBorrada (cle_nro_numcliente,cle_nro_numentrev) as cle_cd1_borrada,
                cle_tel_telefono,
                cle_des_cargo,
                cle_des_titulo,
                cle_tel_celular,
                cle_xld_email,
                cle_xld_direccion,
                cle_txt_observaciones,
                cle_rcd_codresultado,
                cle_ede_informe,
                cle_des_secretaria,
                TNGS_Carm..CliEntrevistas.instante,
                TNGS_Carm..CliEntrevistas.deleted,
                TNGS_Carm..CliEntrevistas.usuario,
                TNGS_Carm..CliEntrevistas.version
           from TNGS_Carm..CliEntrevistas
                join TNGS_Carm..Clientes
                  on cle_nro_numcliente = cli_nro_numero
          where cle_nro_numcliente = @cle_nro_numcliente
          order by cle_nro_numentrev
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTREVISTAS_FSEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@cle_nro_numcliente">Número de cliente</param>
--- <param name="@cle_nro_numentrev">Número</param>
--- <param name="@cle_fyh_fcoordinada">Fecha coordinada</param>
--- <param name="@cle_fyh_frealizada">Fecha realizada</param>
--- <param name="@cle_cd6_codvend">Código de Vendedor</param>
--- <param name="@cle_ede_motcambiof">Motivo cambio fecha</param>
--- <param name="@cle_des_nombre">Nombre</param>
--- <param name="@cle_tel_telefono">Teléfono</param>
--- <param name="@cle_des_cargo">Cargo</param>
--- <param name="@cle_des_titulo">Título</param>
--- <param name="@cle_tel_celular">Celular</param>
--- <param name="@cle_xld_email">Email</param>
--- <param name="@cle_xld_direccion">Dirección</param>
--- <param name="@cle_txt_observaciones">Observaciones</param>
--- <param name="@cle_rcd_codresultado">Código de resultado</param>
--- <param name="@cle_ede_informe">Informe</param>
--- <param name="@cle_des_secretaria">Secretaria</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTREVISTAS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTREVISTAS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTREVISTAS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTREVISTAS_INSERT
(
@cle_nro_numcliente tngs_numero,
@cle_nro_numentrev tngs_numero,
@cle_fyh_fcoordinada tngs_fecyhor,
@cle_fyh_frealizada tngs_fecyhor,
@cle_cd6_codvend tngs_codigo_6,
@cle_ede_motcambiof tngs_descripcion_e,
@cle_des_nombre tngs_descripcion,
@cle_tel_telefono tngs_telefono,
@cle_des_cargo tngs_descripcion,
@cle_des_titulo tngs_descripcion,
@cle_tel_celular tngs_telefono,
@cle_xld_email tngs_descripcion_xl,
@cle_xld_direccion tngs_descripcion_xl,
@cle_txt_observaciones tngs_texto,
@cle_rcd_codresultado tngs_codigo_r,
@cle_ede_informe tngs_descripcion_e,
@cle_des_secretaria tngs_descripcion,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Carm..CliEntrevistas
   values (
           @cle_nro_numcliente,
           @cle_nro_numentrev,
           @cle_fyh_fcoordinada,
           @cle_fyh_frealizada,
           @cle_cd6_codvend,
           @cle_ede_motcambiof,
           @cle_des_nombre,
           @cle_tel_telefono,
           @cle_des_cargo,
           @cle_des_titulo,
           @cle_tel_celular,
           @cle_xld_email,
           @cle_xld_direccion,
           @cle_txt_observaciones,
           @cle_rcd_codresultado,
           @cle_ede_informe,
           @cle_des_secretaria,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTREVISTAS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@cle_nro_numcliente">Número de cliente</param>
--- <param name="@cle_nro_numentrev">Número</param>
--- <param name="@cle_fyh_fcoordinada">Fecha coordinada</param>
--- <param name="@cle_fyh_frealizada">Fecha realizada</param>
--- <param name="@cle_cd6_codvend">Código de Vendedor</param>
--- <param name="@cle_ede_motcambiof">Motivo cambio fecha</param>
--- <param name="@cle_des_nombre">Nombre</param>
--- <param name="@cle_tel_telefono">Teléfono</param>
--- <param name="@cle_des_cargo">Cargo</param>
--- <param name="@cle_des_titulo">Título</param>
--- <param name="@cle_tel_celular">Celular</param>
--- <param name="@cle_xld_email">Email</param>
--- <param name="@cle_xld_direccion">Dirección</param>
--- <param name="@cle_txt_observaciones">Observaciones</param>
--- <param name="@cle_rcd_codresultado">Código de resultado</param>
--- <param name="@cle_ede_informe">Informe</param>
--- <param name="@cle_des_secretaria">Secretaria</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTREVISTAS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTREVISTAS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTREVISTAS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTREVISTAS_UPDATE
(
@cle_nro_numcliente tngs_numero,
@cle_nro_numentrev tngs_numero,
@cle_fyh_fcoordinada tngs_fecyhor,
@cle_fyh_frealizada tngs_fecyhor,
@cle_cd6_codvend tngs_codigo_6,
@cle_ede_motcambiof tngs_descripcion_e,
@cle_des_nombre tngs_descripcion,
@cle_tel_telefono tngs_telefono,
@cle_des_cargo tngs_descripcion,
@cle_des_titulo tngs_descripcion,
@cle_tel_celular tngs_telefono,
@cle_xld_email tngs_descripcion_xl,
@cle_xld_direccion tngs_descripcion_xl,
@cle_txt_observaciones tngs_texto,
@cle_rcd_codresultado tngs_codigo_r,
@cle_ede_informe tngs_descripcion_e,
@cle_des_secretaria tngs_descripcion,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..CliEntrevistas
      set cle_fyh_fcoordinada= @cle_fyh_fcoordinada,
          cle_fyh_frealizada= @cle_fyh_frealizada,
          cle_cd6_codvend= @cle_cd6_codvend,
          cle_ede_motcambiof= @cle_ede_motcambiof,
          cle_des_nombre= @cle_des_nombre,
          cle_tel_telefono= @cle_tel_telefono,
          cle_des_cargo= @cle_des_cargo,
          cle_des_titulo= @cle_des_titulo,
          cle_tel_celular= @cle_tel_celular,
          cle_xld_email= @cle_xld_email,
          cle_xld_direccion= @cle_xld_direccion,
          cle_txt_observaciones= @cle_txt_observaciones,
          cle_rcd_codresultado= @cle_rcd_codresultado,
          cle_ede_informe= @cle_ede_informe,
          cle_des_secretaria= @cle_des_secretaria,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where cle_nro_numcliente = @cle_nro_numcliente
      and cle_nro_numentrev = @cle_nro_numentrev

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTREVISTAS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@cle_nro_numcliente">Número de cliente</param>
--- <param name="@cle_nro_numentrev">Número</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTREVISTAS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTREVISTAS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTREVISTAS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTREVISTAS_DELETE
(
@cle_nro_numcliente tngs_numero,
@cle_nro_numentrev tngs_numero,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..CliEntrevistas
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where cle_nro_numcliente = @cle_nro_numcliente
      and cle_nro_numentrev = @cle_nro_numentrev

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTREVISTAS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro por clave foranea
--- </summary>
--- <param name="@cle_nro_numcliente">Número de cliente</param>
--- <param name="@instante">Instante del delete</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTREVISTAS_FDELETE'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTREVISTAS_FDELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTREVISTAS_FDELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTREVISTAS_FDELETE
(
@cle_nro_numcliente tngs_numero,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         select @instante= getdate()
      end

   Update TNGS_Carm..CliEntrevistas
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= @instante,
          usuario = @usuario
    where cle_nro_numcliente = @cle_nro_numcliente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTREVISTAS_FDELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@cle_nro_numcliente">Número de cliente</param>
--- <param name="@cle_nro_numentrev">Número</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTREVISTAS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTREVISTAS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTREVISTAS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTREVISTAS_RECALL
(
@cle_nro_numcliente tngs_numero,
@cle_nro_numentrev tngs_numero,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..CliEntrevistas
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where cle_nro_numcliente = @cle_nro_numcliente
      and cle_nro_numentrev = @cle_nro_numentrev

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTREVISTAS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera lógicamente los registros de una clave foranea
--- </summary>
--- <param name="@cle_nro_numcliente">Número de cliente</param>
--- <param name="@instante">Instante de referencia</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTREVISTAS_FRECALL'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTREVISTAS_FRECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTREVISTAS_FRECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTREVISTAS_FRECALL
(
@cle_nro_numcliente tngs_numero,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         Update TNGS_Carm..CliEntrevistas
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where cle_nro_numcliente = @cle_nro_numcliente
      end
   else
      begin
         Update TNGS_Carm..CliEntrevistas
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where cle_nro_numcliente = @cle_nro_numcliente
            and instante= @instante
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTREVISTAS_FRECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@cle_nro_numcliente">Número de cliente</param>
--- <param name="@cle_nro_numentrev">Número</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTREVISTAS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTREVISTAS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTREVISTAS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTREVISTAS_DROP
(
@cle_nro_numcliente tngs_numero,
@cle_nro_numentrev tngs_numero,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..CliEntrevistas
    where cle_nro_numcliente = @cle_nro_numcliente
      and cle_nro_numentrev = @cle_nro_numentrev

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTREVISTAS_DROP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro por clave foránea
--- </summary>
--- <param name="@cle_nro_numcliente">Número de cliente</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTREVISTAS_FDROP'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTREVISTAS_FDROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTREVISTAS_FDROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTREVISTAS_FDROP
(
@cle_nro_numcliente tngs_numero,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..CliEntrevistas
    where cle_nro_numcliente = @cle_nro_numcliente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTREVISTAS_FDROP to tngsmodulos

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

print 'Store Procedure: dbo.CLIENTREVISTAS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTREVISTAS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTREVISTAS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTREVISTAS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Carm..CliEntrevistas
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTREVISTAS_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente los registro borrados lógicamente por clave foránea
--- </summary>
--- <param name="@cle_nro_numcliente">Número de cliente</param>
--- <param name="@usuario">Usuario que realiza el pack</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTREVISTAS_FPACK'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTREVISTAS_FPACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTREVISTAS_FPACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTREVISTAS_FPACK
(
@cle_nro_numcliente tngs_numero,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..CliEntrevistas
    where cle_nro_numcliente = @cle_nro_numcliente
      and deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTREVISTAS_FPACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: BorraPorCliente
--- </summary>
--- <param name="@nrocliente">Numero de cliente a borrar entrevistas</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTREVISTAS_BORRAPORCLIENTE'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTREVISTAS_BORRAPORCLIENTE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTREVISTAS_BORRAPORCLIENTE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTREVISTAS_BORRAPORCLIENTE
(
@nrocliente tngs_numero,
@usuario tngs_nombre
)
as
begin

   delete from CliEntrevistas 
   where cle_nro_numcliente  = @nrocliente 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTREVISTAS_BORRAPORCLIENTE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: GetCodVend
--- </summary>
--- <param name="@nrocliente">Numero del Cliente</param>
--- <param name="@nroentrev">Numero de la Entrevista</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTREVISTAS_GETCODVEND'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTREVISTAS_GETCODVEND'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTREVISTAS_GETCODVEND
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTREVISTAS_GETCODVEND
(
@nrocliente tngs_numero,
@nroentrev tngs_numero,
@usuario tngs_nombre
)
as
begin

   select cle_cd6_codvend 
   from CliEntrevistas 
   where cle_nro_numcliente = @nrocliente and cle_nro_numentrev = @nroentrev 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTREVISTAS_GETCODVEND to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: GetEntrevPendVend
--- </summary>
--- <param name="@codvend">Código de vendedor</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTREVISTAS_GETENTREVPENDVEND'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTREVISTAS_GETENTREVPENDVEND'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTREVISTAS_GETENTREVPENDVEND
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTREVISTAS_GETENTREVPENDVEND
(
@codvend tngs_codigo_6,
@usuario tngs_nombre
)
as
begin

   Select cle_nro_numcliente,
          cle_nro_numentrev,
          TNGS_Carm.dbo.CliEntrevistas_GetEsPendiente(cle_nro_numentrev,cle_nro_numcliente) as cle_cd1_pend,
          cli_ede_rsocial as cle_des_rsocial,
          cle_fyh_fcoordinada,
          cle_fyh_frealizada,
          cle_cd6_codvend,
          TNGS_Carm.dbo.Vendedores_GetFullName(cle_cd6_codvend) as cle_des_vend,
          cle_ede_motcambiof,
          cle_des_nombre,
          TNGS_Carm.dbo.CliEntrevistas_FueBorrada (cle_nro_numcliente,cle_nro_numentrev) as cle_cd1_borrada,
          cle_tel_telefono,
          cle_des_cargo,
          cle_des_titulo,
          cle_tel_celular,
          cle_xld_email,
          cle_xld_direccion,
          cle_txt_observaciones,
          cle_rcd_codresultado,
          cle_ede_informe,
          cle_des_secretaria,
          TNGS_Carm..CliEntrevistas.instante,
          TNGS_Carm..CliEntrevistas.deleted,
          TNGS_Carm..CliEntrevistas.usuario,
          TNGS_Carm..CliEntrevistas.version
     from TNGS_Carm..CliEntrevistas 
          join TNGS_Carm..Clientes
            on cle_nro_numcliente = cli_nro_numero
       where 
           cli_cd6_codvend = @codvend and 
           cle_fyh_fcoordinada > getdate() and 
           cle_rcd_codresultado = ' ' and 
           TNGS_Carm..CliEntrevistas.deleted = 0.0000 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTREVISTAS_GETENTREVPENDVEND to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: GetEntrevistasCli
--- </summary>
--- <param name="@cliente">Numero del Cliente</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTREVISTAS_GETENTREVISTASCLI'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTREVISTAS_GETENTREVISTASCLI'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTREVISTAS_GETENTREVISTASCLI
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTREVISTAS_GETENTREVISTASCLI
(
@cliente tngs_numero,
@usuario tngs_nombre
)
as
begin

   Select cle_nro_numcliente,
          cle_nro_numentrev,
          TNGS_Carm.dbo.CliEntrevistas_GetEsPendiente(cle_nro_numentrev,cle_nro_numcliente) as cle_cd1_pend,
          cli_ede_rsocial as cle_des_rsocial,
          cle_fyh_fcoordinada,
          cle_fyh_frealizada,
          cle_cd6_codvend,
          TNGS_Carm.dbo.Vendedores_GetFullName(cle_cd6_codvend) as cle_des_vend,
          cle_ede_motcambiof,
          cle_des_nombre,
          TNGS_Carm.dbo.CliEntrevistas_FueBorrada (cle_nro_numcliente,cle_nro_numentrev) as cle_cd1_borrada,
          cle_tel_telefono,
          cle_des_cargo,
          cle_des_titulo,
          cle_tel_celular,
          cle_xld_email,
          cle_xld_direccion,
          cle_txt_observaciones,
          cle_rcd_codresultado,
          cle_ede_informe,
          cle_des_secretaria,
          TNGS_Carm..CliEntrevistas.instante,
          TNGS_Carm..CliEntrevistas.deleted,
          TNGS_Carm..CliEntrevistas.usuario,
          TNGS_Carm..CliEntrevistas.version
     from TNGS_Carm..CliEntrevistas 
          join TNGS_Carm..Clientes
            on cle_nro_numcliente = cli_nro_numero
    
      join TNGS_Carm..Vendedores 
         on cle_cd6_codvend = vnd_cd6_cod 
    
     where cle_nro_numcliente = @cliente 
    
      order by case when year(cle_fyh_frealizada)<> 1900 then '3000-01-01' 
                    else cle_fyh_frealizada end 
    

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTREVISTAS_GETENTREVISTASCLI to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: GetEntrevistasIncom
--- </summary>
--- <param name="@numcliente">Número de cliente</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTREVISTAS_GETENTREVISTASINCOM'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTREVISTAS_GETENTREVISTASINCOM'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTREVISTAS_GETENTREVISTASINCOM
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTREVISTAS_GETENTREVISTASINCOM
(
@numcliente tngs_numero,
@usuario tngs_nombre
)
as
begin

   SELECT 
       cle_nro_numentrev, 
     cli_ede_rsocial, 
     cle_fyh_fcoordinada, 
     cle_des_nombre, 
     cle_des_cargo 
    
   FROM 
    TNGS_Carm..Clientes 
    join TNGS_Carm..CliEntrevistas 
     on cle_nro_numcliente = cli_nro_numero 
    
   WHERE 
    cli_nro_numero = @numcliente and 
    cle_fyh_fcoordinada < getdate() and 
    cle_rcd_codresultado = ' ' 
    and TNGS_Carm..CliEntrevistas.deleted = 0.0000 
    
    
   ORDER BY cle_fyh_fcoordinada ASC 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTREVISTAS_GETENTREVISTASINCOM to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: GetEntrevistasPend
--- </summary>
--- <param name="@codvend">Código de vendedor</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTREVISTAS_GETENTREVISTASPEND'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTREVISTAS_GETENTREVISTASPEND'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTREVISTAS_GETENTREVISTASPEND
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTREVISTAS_GETENTREVISTASPEND
(
@codvend tngs_codigo_6,
@usuario tngs_nombre
)
as
begin

   select 
       TNGS_Carm..CliEntrevistas.cle_nro_numentrev, 
       cli_ede_rsocial, 
       TNGS_Carm..CliEntrevistas.cle_fyh_fcoordinada, 
       TNGS_Carm..CliEntrevistas.cle_des_nombre, 
       TNGS_Carm..CliEntrevistas.cle_des_cargo 
   from 
       TNGS_Carm..Clientes 
    
       join TNGS_Carm..CliEntrevistas 
           on cle_nro_numcliente = cli_nro_numero 
       where 
           cli_cd6_codvend = @codvend and 
           cle_fyh_fcoordinada > getdate() and 
           cle_rcd_codresultado <> ' ' and 
           TNGS_Carm..CliEntrevistas.deleted = 0.0000 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTREVISTAS_GETENTREVISTASPEND to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: GetEntrevistasVenc
--- </summary>
--- <param name="@codvend">Código de vendedor</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTREVISTAS_GETENTREVISTASVENC'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTREVISTAS_GETENTREVISTASVENC'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTREVISTAS_GETENTREVISTASVENC
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTREVISTAS_GETENTREVISTASVENC
(
@codvend tngs_codigo_6,
@usuario tngs_nombre
)
as
begin

   SELECT 
       TNGS_Carm..CliEntrevistas.cle_nro_numentrev, 
       cli_ede_rsocial, 
       TNGS_Carm..CliEntrevistas.cle_fyh_fcoordinada, 
       TNGS_Carm..CliEntrevistas.cle_des_nombre, 
       TNGS_Carm..CliEntrevistas.cle_des_cargo, 
       TNGS_Carm..Clientes.cli_nro_numero 
   FROM 
       TNGS_Carm..Clientes 
    
       JOIN TNGS_Carm..CliEntrevistas 
           ON cle_nro_numcliente = cli_nro_numero 
       WHERE 
           cli_cd6_codvend = @codvend and 
           cle_fyh_fcoordinada < getdate() and 
           cle_rcd_codresultado = ' 'and 
           TNGS_Carm..CliEntrevistas.deleted = 0.0000 
    
   ORDER BY cli_nro_numero, cle_fyh_fcoordinada 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTREVISTAS_GETENTREVISTASVENC to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: SaveCompletarEntrev
--- </summary>
--- <param name="@frealizada">Fecha realizada</param>
--- <param name="@numentrev">Número de entrevista</param>
--- <param name="@motivo">Motivo de cambio de fecha</param>
--- <param name="@informe">Informe de resultado</param>
--- <param name="@codresultado">Codigo del Resultado de la entrev.</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIENTREVISTAS_SAVECOMPLETARENTREV'

if exists (select * from sysobjects where id = object_id('dbo.CLIENTREVISTAS_SAVECOMPLETARENTREV'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIENTREVISTAS_SAVECOMPLETARENTREV
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIENTREVISTAS_SAVECOMPLETARENTREV
(
@frealizada tngs_fecyhor,
@numentrev tngs_numero,
@motivo tngs_descripcion_e,
@informe tngs_descripcion_e,
@codresultado tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   update TNGS_Carm..CliEntrevistas 
        set 
            cle_fyh_frealizada = @frealizada, 
            cle_ede_motcambiof = @motivo, 
            cle_ede_informe = @informe, 
            cle_rcd_codresultado = @codresultado 
        where 
            cle_nro_numentrev = @numentrev 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIENTREVISTAS_SAVECOMPLETARENTREV to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: CliEntrevistas
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 04/01/2023 00:01
// Sistema     : Carm
// Tabla       : CliGrupoFamiliar
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

print 'Store Procedure: dbo.CLIGRUPOFAMILIAR_UP'

if exists (select * from sysobjects where id = object_id('dbo.CLIGRUPOFAMILIAR_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIGRUPOFAMILIAR_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIGRUPOFAMILIAR_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select cgf_nro_numcliente,
                cgf_nro_numintegrante,
                cgf_ede_apellido,
                cgf_ede_nombre,
                cgf_rcd_codparentesco,
                prt_des_des as des_parentesco,
                cgf_d20_dni,
                cgf_fec_fechanacimiento,
                cgf_ede_obrasocial,
                TNGS_Carm..CliGrupoFamiliar.instante,
                TNGS_Carm..CliGrupoFamiliar.deleted,
                TNGS_Carm..CliGrupoFamiliar.usuario,
                TNGS_Carm..CliGrupoFamiliar.version
           from TNGS_Carm..CliGrupoFamiliar
                join TNGS_Carm..Parentescos
                  on cgf_rcd_codparentesco = prt_rcd_cod
          where TNGS_Carm..CliGrupoFamiliar.deleted = 0
          order by cgf_nro_numcliente,
                cgf_nro_numintegrante
      end
   else
      begin
         Select cgf_nro_numcliente,
                cgf_nro_numintegrante,
                cgf_ede_apellido,
                cgf_ede_nombre,
                cgf_rcd_codparentesco,
                prt_des_des as des_parentesco,
                cgf_d20_dni,
                cgf_fec_fechanacimiento,
                cgf_ede_obrasocial,
                TNGS_Carm..CliGrupoFamiliar.instante,
                TNGS_Carm..CliGrupoFamiliar.deleted,
                TNGS_Carm..CliGrupoFamiliar.usuario,
                TNGS_Carm..CliGrupoFamiliar.version
           from TNGS_Carm..CliGrupoFamiliar
                join TNGS_Carm..Parentescos
                  on cgf_rcd_codparentesco = prt_rcd_cod
          order by cgf_nro_numcliente,
                cgf_nro_numintegrante
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIGRUPOFAMILIAR_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@cgf_nro_numcliente">Nro Cliente</param>
--- <param name="@cgf_nro_numintegrante">Nro Integrante GF</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIGRUPOFAMILIAR_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.CLIGRUPOFAMILIAR_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIGRUPOFAMILIAR_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIGRUPOFAMILIAR_CHKVERSION
(
@cgf_nro_numcliente tngs_numero,
@cgf_nro_numintegrante tngs_numero,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Carm..CliGrupoFamiliar
    where cgf_nro_numcliente = @cgf_nro_numcliente
      and cgf_nro_numintegrante = @cgf_nro_numintegrante
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIGRUPOFAMILIAR_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@cgf_nro_numcliente">Nro Cliente</param>
--- <param name="@cgf_nro_numintegrante">Nro Integrante GF</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIGRUPOFAMILIAR_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.CLIGRUPOFAMILIAR_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIGRUPOFAMILIAR_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIGRUPOFAMILIAR_SEARCH
(
@cgf_nro_numcliente tngs_numero,
@cgf_nro_numintegrante tngs_numero,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select cgf_nro_numcliente,
                cgf_nro_numintegrante,
                cgf_ede_apellido,
                cgf_ede_nombre,
                cgf_rcd_codparentesco,
                prt_des_des as des_parentesco,
                cgf_d20_dni,
                cgf_fec_fechanacimiento,
                cgf_ede_obrasocial,
                TNGS_Carm..CliGrupoFamiliar.instante,
                TNGS_Carm..CliGrupoFamiliar.deleted,
                TNGS_Carm..CliGrupoFamiliar.usuario,
                TNGS_Carm..CliGrupoFamiliar.version
           from TNGS_Carm..CliGrupoFamiliar
                join TNGS_Carm..Parentescos
                  on cgf_rcd_codparentesco = prt_rcd_cod
          where cgf_nro_numcliente = @cgf_nro_numcliente
            and cgf_nro_numintegrante = @cgf_nro_numintegrante
            and TNGS_Carm..CliGrupoFamiliar.deleted = 0
      end
   else
      begin
         Select cgf_nro_numcliente,
                cgf_nro_numintegrante,
                cgf_ede_apellido,
                cgf_ede_nombre,
                cgf_rcd_codparentesco,
                prt_des_des as des_parentesco,
                cgf_d20_dni,
                cgf_fec_fechanacimiento,
                cgf_ede_obrasocial,
                TNGS_Carm..CliGrupoFamiliar.instante,
                TNGS_Carm..CliGrupoFamiliar.deleted,
                TNGS_Carm..CliGrupoFamiliar.usuario,
                TNGS_Carm..CliGrupoFamiliar.version
           from TNGS_Carm..CliGrupoFamiliar
                join TNGS_Carm..Parentescos
                  on cgf_rcd_codparentesco = prt_rcd_cod
          where cgf_nro_numcliente = @cgf_nro_numcliente
            and cgf_nro_numintegrante = @cgf_nro_numintegrante
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIGRUPOFAMILIAR_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca los registros de una clave foranea
--- </summary>
--- <param name="@cgf_nro_numcliente">Nro Cliente</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIGRUPOFAMILIAR_FSEARCH'

if exists (select * from sysobjects where id = object_id('dbo.CLIGRUPOFAMILIAR_FSEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIGRUPOFAMILIAR_FSEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIGRUPOFAMILIAR_FSEARCH
(
@cgf_nro_numcliente tngs_numero,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select cgf_nro_numcliente,
                cgf_nro_numintegrante,
                cgf_ede_apellido,
                cgf_ede_nombre,
                cgf_rcd_codparentesco,
                prt_des_des as des_parentesco,
                cgf_d20_dni,
                cgf_fec_fechanacimiento,
                cgf_ede_obrasocial,
                TNGS_Carm..CliGrupoFamiliar.instante,
                TNGS_Carm..CliGrupoFamiliar.deleted,
                TNGS_Carm..CliGrupoFamiliar.usuario,
                TNGS_Carm..CliGrupoFamiliar.version
           from TNGS_Carm..CliGrupoFamiliar
                join TNGS_Carm..Parentescos
                  on cgf_rcd_codparentesco = prt_rcd_cod
          where cgf_nro_numcliente = @cgf_nro_numcliente
            and TNGS_Carm..CliGrupoFamiliar.deleted = 0
          order by cgf_nro_numintegrante
      end
   else
      begin
         Select cgf_nro_numcliente,
                cgf_nro_numintegrante,
                cgf_ede_apellido,
                cgf_ede_nombre,
                cgf_rcd_codparentesco,
                prt_des_des as des_parentesco,
                cgf_d20_dni,
                cgf_fec_fechanacimiento,
                cgf_ede_obrasocial,
                TNGS_Carm..CliGrupoFamiliar.instante,
                TNGS_Carm..CliGrupoFamiliar.deleted,
                TNGS_Carm..CliGrupoFamiliar.usuario,
                TNGS_Carm..CliGrupoFamiliar.version
           from TNGS_Carm..CliGrupoFamiliar
                join TNGS_Carm..Parentescos
                  on cgf_rcd_codparentesco = prt_rcd_cod
          where cgf_nro_numcliente = @cgf_nro_numcliente
          order by cgf_nro_numintegrante
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIGRUPOFAMILIAR_FSEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@cgf_nro_numcliente">Nro Cliente</param>
--- <param name="@cgf_nro_numintegrante">Nro Integrante GF</param>
--- <param name="@cgf_ede_apellido">Apellido</param>
--- <param name="@cgf_ede_nombre">Nombre</param>
--- <param name="@cgf_rcd_codparentesco">Parentesco</param>
--- <param name="@cgf_d20_dni">DNI</param>
--- <param name="@cgf_fec_fechanacimiento">Fecha Nacimiento</param>
--- <param name="@cgf_ede_obrasocial">Obra Social</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIGRUPOFAMILIAR_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.CLIGRUPOFAMILIAR_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIGRUPOFAMILIAR_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIGRUPOFAMILIAR_INSERT
(
@cgf_nro_numcliente tngs_numero,
@cgf_nro_numintegrante tngs_numero,
@cgf_ede_apellido tngs_descripcion_e,
@cgf_ede_nombre tngs_descripcion_e,
@cgf_rcd_codparentesco tngs_codigo_r,
@cgf_d20_dni tngs_descripcion_20,
@cgf_fec_fechanacimiento tngs_fecha,
@cgf_ede_obrasocial tngs_descripcion_e,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Carm..CliGrupoFamiliar
   values (
           @cgf_nro_numcliente,
           @cgf_nro_numintegrante,
           @cgf_ede_apellido,
           @cgf_ede_nombre,
           @cgf_rcd_codparentesco,
           @cgf_d20_dni,
           @cgf_fec_fechanacimiento,
           @cgf_ede_obrasocial,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIGRUPOFAMILIAR_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@cgf_nro_numcliente">Nro Cliente</param>
--- <param name="@cgf_nro_numintegrante">Nro Integrante GF</param>
--- <param name="@cgf_ede_apellido">Apellido</param>
--- <param name="@cgf_ede_nombre">Nombre</param>
--- <param name="@cgf_rcd_codparentesco">Parentesco</param>
--- <param name="@cgf_d20_dni">DNI</param>
--- <param name="@cgf_fec_fechanacimiento">Fecha Nacimiento</param>
--- <param name="@cgf_ede_obrasocial">Obra Social</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIGRUPOFAMILIAR_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.CLIGRUPOFAMILIAR_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIGRUPOFAMILIAR_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIGRUPOFAMILIAR_UPDATE
(
@cgf_nro_numcliente tngs_numero,
@cgf_nro_numintegrante tngs_numero,
@cgf_ede_apellido tngs_descripcion_e,
@cgf_ede_nombre tngs_descripcion_e,
@cgf_rcd_codparentesco tngs_codigo_r,
@cgf_d20_dni tngs_descripcion_20,
@cgf_fec_fechanacimiento tngs_fecha,
@cgf_ede_obrasocial tngs_descripcion_e,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..CliGrupoFamiliar
      set cgf_ede_apellido= @cgf_ede_apellido,
          cgf_ede_nombre= @cgf_ede_nombre,
          cgf_rcd_codparentesco= @cgf_rcd_codparentesco,
          cgf_d20_dni= @cgf_d20_dni,
          cgf_fec_fechanacimiento= @cgf_fec_fechanacimiento,
          cgf_ede_obrasocial= @cgf_ede_obrasocial,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where cgf_nro_numcliente = @cgf_nro_numcliente
      and cgf_nro_numintegrante = @cgf_nro_numintegrante

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIGRUPOFAMILIAR_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@cgf_nro_numcliente">Nro Cliente</param>
--- <param name="@cgf_nro_numintegrante">Nro Integrante GF</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIGRUPOFAMILIAR_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.CLIGRUPOFAMILIAR_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIGRUPOFAMILIAR_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIGRUPOFAMILIAR_DELETE
(
@cgf_nro_numcliente tngs_numero,
@cgf_nro_numintegrante tngs_numero,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..CliGrupoFamiliar
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where cgf_nro_numcliente = @cgf_nro_numcliente
      and cgf_nro_numintegrante = @cgf_nro_numintegrante

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIGRUPOFAMILIAR_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro por clave foranea
--- </summary>
--- <param name="@cgf_nro_numcliente">Nro Cliente</param>
--- <param name="@instante">Instante del delete</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIGRUPOFAMILIAR_FDELETE'

if exists (select * from sysobjects where id = object_id('dbo.CLIGRUPOFAMILIAR_FDELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIGRUPOFAMILIAR_FDELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIGRUPOFAMILIAR_FDELETE
(
@cgf_nro_numcliente tngs_numero,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         select @instante= getdate()
      end

   Update TNGS_Carm..CliGrupoFamiliar
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= @instante,
          usuario = @usuario
    where cgf_nro_numcliente = @cgf_nro_numcliente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIGRUPOFAMILIAR_FDELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@cgf_nro_numcliente">Nro Cliente</param>
--- <param name="@cgf_nro_numintegrante">Nro Integrante GF</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIGRUPOFAMILIAR_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.CLIGRUPOFAMILIAR_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIGRUPOFAMILIAR_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIGRUPOFAMILIAR_RECALL
(
@cgf_nro_numcliente tngs_numero,
@cgf_nro_numintegrante tngs_numero,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..CliGrupoFamiliar
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where cgf_nro_numcliente = @cgf_nro_numcliente
      and cgf_nro_numintegrante = @cgf_nro_numintegrante

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIGRUPOFAMILIAR_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera lógicamente los registros de una clave foranea
--- </summary>
--- <param name="@cgf_nro_numcliente">Nro Cliente</param>
--- <param name="@instante">Instante de referencia</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIGRUPOFAMILIAR_FRECALL'

if exists (select * from sysobjects where id = object_id('dbo.CLIGRUPOFAMILIAR_FRECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIGRUPOFAMILIAR_FRECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIGRUPOFAMILIAR_FRECALL
(
@cgf_nro_numcliente tngs_numero,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         Update TNGS_Carm..CliGrupoFamiliar
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where cgf_nro_numcliente = @cgf_nro_numcliente
      end
   else
      begin
         Update TNGS_Carm..CliGrupoFamiliar
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where cgf_nro_numcliente = @cgf_nro_numcliente
            and instante= @instante
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIGRUPOFAMILIAR_FRECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@cgf_nro_numcliente">Nro Cliente</param>
--- <param name="@cgf_nro_numintegrante">Nro Integrante GF</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIGRUPOFAMILIAR_DROP'

if exists (select * from sysobjects where id = object_id('dbo.CLIGRUPOFAMILIAR_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIGRUPOFAMILIAR_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIGRUPOFAMILIAR_DROP
(
@cgf_nro_numcliente tngs_numero,
@cgf_nro_numintegrante tngs_numero,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..CliGrupoFamiliar
    where cgf_nro_numcliente = @cgf_nro_numcliente
      and cgf_nro_numintegrante = @cgf_nro_numintegrante

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIGRUPOFAMILIAR_DROP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro por clave foránea
--- </summary>
--- <param name="@cgf_nro_numcliente">Nro Cliente</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIGRUPOFAMILIAR_FDROP'

if exists (select * from sysobjects where id = object_id('dbo.CLIGRUPOFAMILIAR_FDROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIGRUPOFAMILIAR_FDROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIGRUPOFAMILIAR_FDROP
(
@cgf_nro_numcliente tngs_numero,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..CliGrupoFamiliar
    where cgf_nro_numcliente = @cgf_nro_numcliente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIGRUPOFAMILIAR_FDROP to tngsmodulos

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

print 'Store Procedure: dbo.CLIGRUPOFAMILIAR_PACK'

if exists (select * from sysobjects where id = object_id('dbo.CLIGRUPOFAMILIAR_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIGRUPOFAMILIAR_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIGRUPOFAMILIAR_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Carm..CliGrupoFamiliar
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIGRUPOFAMILIAR_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente los registro borrados lógicamente por clave foránea
--- </summary>
--- <param name="@cgf_nro_numcliente">Nro Cliente</param>
--- <param name="@usuario">Usuario que realiza el pack</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIGRUPOFAMILIAR_FPACK'

if exists (select * from sysobjects where id = object_id('dbo.CLIGRUPOFAMILIAR_FPACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIGRUPOFAMILIAR_FPACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIGRUPOFAMILIAR_FPACK
(
@cgf_nro_numcliente tngs_numero,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..CliGrupoFamiliar
    where cgf_nro_numcliente = @cgf_nro_numcliente
      and deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIGRUPOFAMILIAR_FPACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: CliGrupoFamiliar
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 04/01/2023 00:01
// Sistema     : Carm
// Tabla       : CliLlamadas
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
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 04/01/2023 00:01
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
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 04/01/2023 00:01
// Sistema     : Carm
// Tabla       : CliServicios
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

print 'Store Procedure: dbo.CLISERVICIOS_UP'

if exists (select * from sysobjects where id = object_id('dbo.CLISERVICIOS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLISERVICIOS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLISERVICIOS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select cls_nro_numcliente,
                cls_nro_item,
                cls_cod_codservicio,
                isnull(srv_des_des,'') as cls_des_serv,
                cls_imp_coseguro,
                cls_imp_valorprestacion,
                cls_nro_cantestprestaciones,
                TNGS_Carm..CliServicios.instante,
                TNGS_Carm..CliServicios.deleted,
                TNGS_Carm..CliServicios.usuario,
                TNGS_Carm..CliServicios.version
           from TNGS_Carm..CliServicios
                left outer join TNGS_Carm..Servicios
                  on cls_cod_codservicio = srv_cod_cod
          where TNGS_Carm..CliServicios.deleted = 0
          order by cls_nro_numcliente,
                cls_nro_item
      end
   else
      begin
         Select cls_nro_numcliente,
                cls_nro_item,
                cls_cod_codservicio,
                isnull(srv_des_des,'') as cls_des_serv,
                cls_imp_coseguro,
                cls_imp_valorprestacion,
                cls_nro_cantestprestaciones,
                TNGS_Carm..CliServicios.instante,
                TNGS_Carm..CliServicios.deleted,
                TNGS_Carm..CliServicios.usuario,
                TNGS_Carm..CliServicios.version
           from TNGS_Carm..CliServicios
                left outer join TNGS_Carm..Servicios
                  on cls_cod_codservicio = srv_cod_cod
          order by cls_nro_numcliente,
                cls_nro_item
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLISERVICIOS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@cls_nro_numcliente">Número Cliente</param>
--- <param name="@cls_nro_item">Item</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLISERVICIOS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.CLISERVICIOS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLISERVICIOS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLISERVICIOS_CHKVERSION
(
@cls_nro_numcliente tngs_numero,
@cls_nro_item tngs_numero,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Carm..CliServicios
    where cls_nro_numcliente = @cls_nro_numcliente
      and cls_nro_item = @cls_nro_item
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLISERVICIOS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@cls_nro_numcliente">Número Cliente</param>
--- <param name="@cls_nro_item">Item</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLISERVICIOS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.CLISERVICIOS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLISERVICIOS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLISERVICIOS_SEARCH
(
@cls_nro_numcliente tngs_numero,
@cls_nro_item tngs_numero,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select cls_nro_numcliente,
                cls_nro_item,
                cls_cod_codservicio,
                isnull(srv_des_des,'') as cls_des_serv,
                cls_imp_coseguro,
                cls_imp_valorprestacion,
                cls_nro_cantestprestaciones,
                TNGS_Carm..CliServicios.instante,
                TNGS_Carm..CliServicios.deleted,
                TNGS_Carm..CliServicios.usuario,
                TNGS_Carm..CliServicios.version
           from TNGS_Carm..CliServicios
                left outer join TNGS_Carm..Servicios
                  on cls_cod_codservicio = srv_cod_cod
          where cls_nro_numcliente = @cls_nro_numcliente
            and cls_nro_item = @cls_nro_item
            and TNGS_Carm..CliServicios.deleted = 0
      end
   else
      begin
         Select cls_nro_numcliente,
                cls_nro_item,
                cls_cod_codservicio,
                isnull(srv_des_des,'') as cls_des_serv,
                cls_imp_coseguro,
                cls_imp_valorprestacion,
                cls_nro_cantestprestaciones,
                TNGS_Carm..CliServicios.instante,
                TNGS_Carm..CliServicios.deleted,
                TNGS_Carm..CliServicios.usuario,
                TNGS_Carm..CliServicios.version
           from TNGS_Carm..CliServicios
                left outer join TNGS_Carm..Servicios
                  on cls_cod_codservicio = srv_cod_cod
          where cls_nro_numcliente = @cls_nro_numcliente
            and cls_nro_item = @cls_nro_item
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLISERVICIOS_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca los registros de una clave foranea
--- </summary>
--- <param name="@cls_nro_numcliente">Número Cliente</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLISERVICIOS_FSEARCH'

if exists (select * from sysobjects where id = object_id('dbo.CLISERVICIOS_FSEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLISERVICIOS_FSEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLISERVICIOS_FSEARCH
(
@cls_nro_numcliente tngs_numero,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select cls_nro_numcliente,
                cls_nro_item,
                cls_cod_codservicio,
                isnull(srv_des_des,'') as cls_des_serv,
                cls_imp_coseguro,
                cls_imp_valorprestacion,
                cls_nro_cantestprestaciones,
                TNGS_Carm..CliServicios.instante,
                TNGS_Carm..CliServicios.deleted,
                TNGS_Carm..CliServicios.usuario,
                TNGS_Carm..CliServicios.version
           from TNGS_Carm..CliServicios
                left outer join TNGS_Carm..Servicios
                  on cls_cod_codservicio = srv_cod_cod
          where cls_nro_numcliente = @cls_nro_numcliente
            and TNGS_Carm..CliServicios.deleted = 0
          order by cls_nro_item
      end
   else
      begin
         Select cls_nro_numcliente,
                cls_nro_item,
                cls_cod_codservicio,
                isnull(srv_des_des,'') as cls_des_serv,
                cls_imp_coseguro,
                cls_imp_valorprestacion,
                cls_nro_cantestprestaciones,
                TNGS_Carm..CliServicios.instante,
                TNGS_Carm..CliServicios.deleted,
                TNGS_Carm..CliServicios.usuario,
                TNGS_Carm..CliServicios.version
           from TNGS_Carm..CliServicios
                left outer join TNGS_Carm..Servicios
                  on cls_cod_codservicio = srv_cod_cod
          where cls_nro_numcliente = @cls_nro_numcliente
          order by cls_nro_item
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLISERVICIOS_FSEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@cls_nro_numcliente">Número Cliente</param>
--- <param name="@cls_nro_item">Item</param>
--- <param name="@cls_cod_codservicio">Código de Servicio</param>
--- <param name="@cls_imp_coseguro">Coseguro</param>
--- <param name="@cls_imp_valorprestacion">Valor Prestación</param>
--- <param name="@cls_nro_cantestprestaciones">Cant. Estimada Prestaciones</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLISERVICIOS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.CLISERVICIOS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLISERVICIOS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLISERVICIOS_INSERT
(
@cls_nro_numcliente tngs_numero,
@cls_nro_item tngs_numero,
@cls_cod_codservicio tngs_codigo,
@cls_imp_coseguro tngs_importe,
@cls_imp_valorprestacion tngs_importe,
@cls_nro_cantestprestaciones tngs_numero,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Carm..CliServicios
   values (
           @cls_nro_numcliente,
           @cls_nro_item,
           @cls_cod_codservicio,
           @cls_imp_coseguro,
           @cls_imp_valorprestacion,
           @cls_nro_cantestprestaciones,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLISERVICIOS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@cls_nro_numcliente">Número Cliente</param>
--- <param name="@cls_nro_item">Item</param>
--- <param name="@cls_cod_codservicio">Código de Servicio</param>
--- <param name="@cls_imp_coseguro">Coseguro</param>
--- <param name="@cls_imp_valorprestacion">Valor Prestación</param>
--- <param name="@cls_nro_cantestprestaciones">Cant. Estimada Prestaciones</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLISERVICIOS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.CLISERVICIOS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLISERVICIOS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLISERVICIOS_UPDATE
(
@cls_nro_numcliente tngs_numero,
@cls_nro_item tngs_numero,
@cls_cod_codservicio tngs_codigo,
@cls_imp_coseguro tngs_importe,
@cls_imp_valorprestacion tngs_importe,
@cls_nro_cantestprestaciones tngs_numero,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..CliServicios
      set cls_cod_codservicio= @cls_cod_codservicio,
          cls_imp_coseguro= @cls_imp_coseguro,
          cls_imp_valorprestacion= @cls_imp_valorprestacion,
          cls_nro_cantestprestaciones= @cls_nro_cantestprestaciones,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where cls_nro_numcliente = @cls_nro_numcliente
      and cls_nro_item = @cls_nro_item

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLISERVICIOS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@cls_nro_numcliente">Número Cliente</param>
--- <param name="@cls_nro_item">Item</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLISERVICIOS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.CLISERVICIOS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLISERVICIOS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLISERVICIOS_DELETE
(
@cls_nro_numcliente tngs_numero,
@cls_nro_item tngs_numero,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..CliServicios
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where cls_nro_numcliente = @cls_nro_numcliente
      and cls_nro_item = @cls_nro_item

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLISERVICIOS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro por clave foranea
--- </summary>
--- <param name="@cls_nro_numcliente">Número Cliente</param>
--- <param name="@instante">Instante del delete</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLISERVICIOS_FDELETE'

if exists (select * from sysobjects where id = object_id('dbo.CLISERVICIOS_FDELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLISERVICIOS_FDELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLISERVICIOS_FDELETE
(
@cls_nro_numcliente tngs_numero,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         select @instante= getdate()
      end

   Update TNGS_Carm..CliServicios
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= @instante,
          usuario = @usuario
    where cls_nro_numcliente = @cls_nro_numcliente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLISERVICIOS_FDELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@cls_nro_numcliente">Número Cliente</param>
--- <param name="@cls_nro_item">Item</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLISERVICIOS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.CLISERVICIOS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLISERVICIOS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLISERVICIOS_RECALL
(
@cls_nro_numcliente tngs_numero,
@cls_nro_item tngs_numero,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..CliServicios
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where cls_nro_numcliente = @cls_nro_numcliente
      and cls_nro_item = @cls_nro_item

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLISERVICIOS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera lógicamente los registros de una clave foranea
--- </summary>
--- <param name="@cls_nro_numcliente">Número Cliente</param>
--- <param name="@instante">Instante de referencia</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLISERVICIOS_FRECALL'

if exists (select * from sysobjects where id = object_id('dbo.CLISERVICIOS_FRECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLISERVICIOS_FRECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLISERVICIOS_FRECALL
(
@cls_nro_numcliente tngs_numero,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         Update TNGS_Carm..CliServicios
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where cls_nro_numcliente = @cls_nro_numcliente
      end
   else
      begin
         Update TNGS_Carm..CliServicios
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where cls_nro_numcliente = @cls_nro_numcliente
            and instante= @instante
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLISERVICIOS_FRECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@cls_nro_numcliente">Número Cliente</param>
--- <param name="@cls_nro_item">Item</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLISERVICIOS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.CLISERVICIOS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLISERVICIOS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLISERVICIOS_DROP
(
@cls_nro_numcliente tngs_numero,
@cls_nro_item tngs_numero,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..CliServicios
    where cls_nro_numcliente = @cls_nro_numcliente
      and cls_nro_item = @cls_nro_item

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLISERVICIOS_DROP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro por clave foránea
--- </summary>
--- <param name="@cls_nro_numcliente">Número Cliente</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLISERVICIOS_FDROP'

if exists (select * from sysobjects where id = object_id('dbo.CLISERVICIOS_FDROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLISERVICIOS_FDROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLISERVICIOS_FDROP
(
@cls_nro_numcliente tngs_numero,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..CliServicios
    where cls_nro_numcliente = @cls_nro_numcliente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLISERVICIOS_FDROP to tngsmodulos

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

print 'Store Procedure: dbo.CLISERVICIOS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.CLISERVICIOS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLISERVICIOS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLISERVICIOS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Carm..CliServicios
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLISERVICIOS_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente los registro borrados lógicamente por clave foránea
--- </summary>
--- <param name="@cls_nro_numcliente">Número Cliente</param>
--- <param name="@usuario">Usuario que realiza el pack</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLISERVICIOS_FPACK'

if exists (select * from sysobjects where id = object_id('dbo.CLISERVICIOS_FPACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLISERVICIOS_FPACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLISERVICIOS_FPACK
(
@cls_nro_numcliente tngs_numero,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..CliServicios
    where cls_nro_numcliente = @cls_nro_numcliente
      and deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLISERVICIOS_FPACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: BorraPorCliente
--- </summary>
--- <param name="@nrocliente">Numero del cliente a borrar los servicios</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLISERVICIOS_BORRAPORCLIENTE'

if exists (select * from sysobjects where id = object_id('dbo.CLISERVICIOS_BORRAPORCLIENTE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLISERVICIOS_BORRAPORCLIENTE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLISERVICIOS_BORRAPORCLIENTE
(
@nrocliente tngs_numero,
@usuario tngs_nombre
)
as
begin

   delete from CliServicios 
   where cls_nro_numcliente = @nrocliente 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLISERVICIOS_BORRAPORCLIENTE to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: CliServicios
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 04/01/2023 00:01
// Sistema     : Carm
// Tabla       : CliVentas
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
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 04/01/2023 00:01
// Sistema     : Carm
// Tabla       : ConversionColores
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
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 04/01/2023 00:01
// Sistema     : Carm
// Tabla       : Franquicias
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

print 'Store Procedure: dbo.FRANQUICIAS_UP'

if exists (select * from sysobjects where id = object_id('dbo.FRANQUICIAS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.FRANQUICIAS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.FRANQUICIAS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select frq_cod_cod,
                frq_des_des,
                TNGS_Carm..Franquicias.instante,
                TNGS_Carm..Franquicias.deleted,
                TNGS_Carm..Franquicias.usuario,
                TNGS_Carm..Franquicias.version
           from TNGS_Carm..Franquicias
          where deleted = 0
          order by frq_cod_cod
      end
   else
      begin
         Select frq_cod_cod,
                frq_des_des,
                TNGS_Carm..Franquicias.instante,
                TNGS_Carm..Franquicias.deleted,
                TNGS_Carm..Franquicias.usuario,
                TNGS_Carm..Franquicias.version
           from TNGS_Carm..Franquicias
          order by frq_cod_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.FRANQUICIAS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@frq_cod_cod">Codigo</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.FRANQUICIAS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.FRANQUICIAS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.FRANQUICIAS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.FRANQUICIAS_CHKVERSION
(
@frq_cod_cod tngs_codigo,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Carm..Franquicias
    where frq_cod_cod = @frq_cod_cod
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.FRANQUICIAS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@frq_cod_cod">Codigo</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.FRANQUICIAS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.FRANQUICIAS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.FRANQUICIAS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.FRANQUICIAS_SEARCH
(
@frq_cod_cod tngs_codigo,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select frq_cod_cod,
                frq_des_des,
                TNGS_Carm..Franquicias.instante,
                TNGS_Carm..Franquicias.deleted,
                TNGS_Carm..Franquicias.usuario,
                TNGS_Carm..Franquicias.version
           from TNGS_Carm..Franquicias
          where frq_cod_cod = @frq_cod_cod
            and deleted = 0
      end
   else
      begin
         Select frq_cod_cod,
                frq_des_des,
                TNGS_Carm..Franquicias.instante,
                TNGS_Carm..Franquicias.deleted,
                TNGS_Carm..Franquicias.usuario,
                TNGS_Carm..Franquicias.version
           from TNGS_Carm..Franquicias
          where frq_cod_cod = @frq_cod_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.FRANQUICIAS_SEARCH to tngsmodulos

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

print 'Store Procedure: dbo.FRANQUICIAS_GETMAXKEY'

if exists (select * from sysobjects where id = object_id('dbo.FRANQUICIAS_GETMAXKEY'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.FRANQUICIAS_GETMAXKEY
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.FRANQUICIAS_GETMAXKEY
(
@dummy tngs_codigo_1
)
as
begin

   Select isnull(max(frq_cod_cod), '0') as frq_cod_cod
     from TNGS_Carm..Franquicias

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.FRANQUICIAS_GETMAXKEY to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@frq_cod_cod">Codigo</param>
--- <param name="@frq_des_des">Descripcion</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.FRANQUICIAS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.FRANQUICIAS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.FRANQUICIAS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.FRANQUICIAS_INSERT
(
@frq_cod_cod tngs_codigo,
@frq_des_des tngs_descripcion,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Carm..Franquicias
   values (
           @frq_cod_cod,
           @frq_des_des,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.FRANQUICIAS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@frq_cod_cod">Codigo</param>
--- <param name="@frq_des_des">Descripcion</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.FRANQUICIAS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.FRANQUICIAS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.FRANQUICIAS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.FRANQUICIAS_UPDATE
(
@frq_cod_cod tngs_codigo,
@frq_des_des tngs_descripcion,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Franquicias
      set frq_des_des= @frq_des_des,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where frq_cod_cod = @frq_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.FRANQUICIAS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@frq_cod_cod">Codigo</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.FRANQUICIAS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.FRANQUICIAS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.FRANQUICIAS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.FRANQUICIAS_DELETE
(
@frq_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Franquicias
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where frq_cod_cod = @frq_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.FRANQUICIAS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@frq_cod_cod">Codigo</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.FRANQUICIAS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.FRANQUICIAS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.FRANQUICIAS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.FRANQUICIAS_RECALL
(
@frq_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Franquicias
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where frq_cod_cod = @frq_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.FRANQUICIAS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@frq_cod_cod">Codigo</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.FRANQUICIAS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.FRANQUICIAS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.FRANQUICIAS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.FRANQUICIAS_DROP
(
@frq_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..Franquicias
    where frq_cod_cod = @frq_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.FRANQUICIAS_DROP to tngsmodulos

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

print 'Store Procedure: dbo.FRANQUICIAS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.FRANQUICIAS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.FRANQUICIAS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.FRANQUICIAS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Carm..Franquicias
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.FRANQUICIAS_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Franquicias
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 04/01/2023 00:01
// Sistema     : Carm
// Tabla       : ListasDePrecios
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

print 'Store Procedure: dbo.LISTASDEPRECIOS_UP'

if exists (select * from sysobjects where id = object_id('dbo.LISTASDEPRECIOS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.LISTASDEPRECIOS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.LISTASDEPRECIOS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select lpr_cod_cod,
                lpr_des_des,
                mrc_ede_des as des_marca,
                pln_des_des as des_plan,
                lpr_cod_codplan,
                lpr_rcd_codmarca,
                lpr_imp_precio1p,
                lpr_imp_precio2p,
                lpr_imp_precio3p,
                lpr_imp_precio4p,
                lpr_imp_precio5p,
                lpr_imp_precio6p,
                lpr_imp_precio7p,
                lpr_imp_precio8p,
                lpr_imp_precio9p,
                lpr_imp_precio10p,
                TNGS_Carm..ListasDePrecios.instante,
                TNGS_Carm..ListasDePrecios.deleted,
                TNGS_Carm..ListasDePrecios.usuario,
                TNGS_Carm..ListasDePrecios.version
           from TNGS_Carm..ListasDePrecios
                join TNGS_Carm..Marcas
                  on lpr_rcd_codmarca = mrc_rcd_cod
                join TNGS_Carm..Planes
                  on lpr_cod_codplan = pln_cod_cod
          where TNGS_Carm..ListasDePrecios.deleted = 0
          order by lpr_cod_cod
      end
   else
      begin
         Select lpr_cod_cod,
                lpr_des_des,
                mrc_ede_des as des_marca,
                pln_des_des as des_plan,
                lpr_cod_codplan,
                lpr_rcd_codmarca,
                lpr_imp_precio1p,
                lpr_imp_precio2p,
                lpr_imp_precio3p,
                lpr_imp_precio4p,
                lpr_imp_precio5p,
                lpr_imp_precio6p,
                lpr_imp_precio7p,
                lpr_imp_precio8p,
                lpr_imp_precio9p,
                lpr_imp_precio10p,
                TNGS_Carm..ListasDePrecios.instante,
                TNGS_Carm..ListasDePrecios.deleted,
                TNGS_Carm..ListasDePrecios.usuario,
                TNGS_Carm..ListasDePrecios.version
           from TNGS_Carm..ListasDePrecios
                join TNGS_Carm..Marcas
                  on lpr_rcd_codmarca = mrc_rcd_cod
                join TNGS_Carm..Planes
                  on lpr_cod_codplan = pln_cod_cod
          order by lpr_cod_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.LISTASDEPRECIOS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@lpr_cod_cod">Código</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.LISTASDEPRECIOS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.LISTASDEPRECIOS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.LISTASDEPRECIOS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.LISTASDEPRECIOS_CHKVERSION
(
@lpr_cod_cod tngs_codigo,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Carm..ListasDePrecios
    where lpr_cod_cod = @lpr_cod_cod
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.LISTASDEPRECIOS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@lpr_cod_cod">Código</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.LISTASDEPRECIOS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.LISTASDEPRECIOS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.LISTASDEPRECIOS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.LISTASDEPRECIOS_SEARCH
(
@lpr_cod_cod tngs_codigo,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select lpr_cod_cod,
                lpr_des_des,
                mrc_ede_des as des_marca,
                pln_des_des as des_plan,
                lpr_cod_codplan,
                lpr_rcd_codmarca,
                lpr_imp_precio1p,
                lpr_imp_precio2p,
                lpr_imp_precio3p,
                lpr_imp_precio4p,
                lpr_imp_precio5p,
                lpr_imp_precio6p,
                lpr_imp_precio7p,
                lpr_imp_precio8p,
                lpr_imp_precio9p,
                lpr_imp_precio10p,
                TNGS_Carm..ListasDePrecios.instante,
                TNGS_Carm..ListasDePrecios.deleted,
                TNGS_Carm..ListasDePrecios.usuario,
                TNGS_Carm..ListasDePrecios.version
           from TNGS_Carm..ListasDePrecios
                join TNGS_Carm..Marcas
                  on lpr_rcd_codmarca = mrc_rcd_cod
                join TNGS_Carm..Planes
                  on lpr_cod_codplan = pln_cod_cod
          where lpr_cod_cod = @lpr_cod_cod
            and TNGS_Carm..ListasDePrecios.deleted = 0
      end
   else
      begin
         Select lpr_cod_cod,
                lpr_des_des,
                mrc_ede_des as des_marca,
                pln_des_des as des_plan,
                lpr_cod_codplan,
                lpr_rcd_codmarca,
                lpr_imp_precio1p,
                lpr_imp_precio2p,
                lpr_imp_precio3p,
                lpr_imp_precio4p,
                lpr_imp_precio5p,
                lpr_imp_precio6p,
                lpr_imp_precio7p,
                lpr_imp_precio8p,
                lpr_imp_precio9p,
                lpr_imp_precio10p,
                TNGS_Carm..ListasDePrecios.instante,
                TNGS_Carm..ListasDePrecios.deleted,
                TNGS_Carm..ListasDePrecios.usuario,
                TNGS_Carm..ListasDePrecios.version
           from TNGS_Carm..ListasDePrecios
                join TNGS_Carm..Marcas
                  on lpr_rcd_codmarca = mrc_rcd_cod
                join TNGS_Carm..Planes
                  on lpr_cod_codplan = pln_cod_cod
          where lpr_cod_cod = @lpr_cod_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.LISTASDEPRECIOS_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@lpr_cod_cod">Código</param>
--- <param name="@lpr_des_des">Descripción</param>
--- <param name="@lpr_cod_codplan">Plan</param>
--- <param name="@lpr_rcd_codmarca">Marca</param>
--- <param name="@lpr_imp_precio1p">Precio 1 P</param>
--- <param name="@lpr_imp_precio2p">Precio 2 P</param>
--- <param name="@lpr_imp_precio3p">Precio 3 P</param>
--- <param name="@lpr_imp_precio4p">Precio 4 P</param>
--- <param name="@lpr_imp_precio5p">Precio 5 P</param>
--- <param name="@lpr_imp_precio6p">Precio 6 P</param>
--- <param name="@lpr_imp_precio7p">Precio 7 P</param>
--- <param name="@lpr_imp_precio8p">Precio 8 P</param>
--- <param name="@lpr_imp_precio9p">Precio 9 P</param>
--- <param name="@lpr_imp_precio10p">Precio 10 P</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.LISTASDEPRECIOS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.LISTASDEPRECIOS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.LISTASDEPRECIOS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.LISTASDEPRECIOS_INSERT
(
@lpr_cod_cod tngs_codigo,
@lpr_des_des tngs_descripcion,
@lpr_cod_codplan tngs_codigo,
@lpr_rcd_codmarca tngs_codigo_r,
@lpr_imp_precio1p tngs_importe,
@lpr_imp_precio2p tngs_importe,
@lpr_imp_precio3p tngs_importe,
@lpr_imp_precio4p tngs_importe,
@lpr_imp_precio5p tngs_importe,
@lpr_imp_precio6p tngs_importe,
@lpr_imp_precio7p tngs_importe,
@lpr_imp_precio8p tngs_importe,
@lpr_imp_precio9p tngs_importe,
@lpr_imp_precio10p tngs_importe,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Carm..ListasDePrecios
   values (
           @lpr_cod_cod,
           @lpr_des_des,
           @lpr_cod_codplan,
           @lpr_rcd_codmarca,
           @lpr_imp_precio1p,
           @lpr_imp_precio2p,
           @lpr_imp_precio3p,
           @lpr_imp_precio4p,
           @lpr_imp_precio5p,
           @lpr_imp_precio6p,
           @lpr_imp_precio7p,
           @lpr_imp_precio8p,
           @lpr_imp_precio9p,
           @lpr_imp_precio10p,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.LISTASDEPRECIOS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@lpr_cod_cod">Código</param>
--- <param name="@lpr_des_des">Descripción</param>
--- <param name="@lpr_cod_codplan">Plan</param>
--- <param name="@lpr_rcd_codmarca">Marca</param>
--- <param name="@lpr_imp_precio1p">Precio 1 P</param>
--- <param name="@lpr_imp_precio2p">Precio 2 P</param>
--- <param name="@lpr_imp_precio3p">Precio 3 P</param>
--- <param name="@lpr_imp_precio4p">Precio 4 P</param>
--- <param name="@lpr_imp_precio5p">Precio 5 P</param>
--- <param name="@lpr_imp_precio6p">Precio 6 P</param>
--- <param name="@lpr_imp_precio7p">Precio 7 P</param>
--- <param name="@lpr_imp_precio8p">Precio 8 P</param>
--- <param name="@lpr_imp_precio9p">Precio 9 P</param>
--- <param name="@lpr_imp_precio10p">Precio 10 P</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.LISTASDEPRECIOS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.LISTASDEPRECIOS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.LISTASDEPRECIOS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.LISTASDEPRECIOS_UPDATE
(
@lpr_cod_cod tngs_codigo,
@lpr_des_des tngs_descripcion,
@lpr_cod_codplan tngs_codigo,
@lpr_rcd_codmarca tngs_codigo_r,
@lpr_imp_precio1p tngs_importe,
@lpr_imp_precio2p tngs_importe,
@lpr_imp_precio3p tngs_importe,
@lpr_imp_precio4p tngs_importe,
@lpr_imp_precio5p tngs_importe,
@lpr_imp_precio6p tngs_importe,
@lpr_imp_precio7p tngs_importe,
@lpr_imp_precio8p tngs_importe,
@lpr_imp_precio9p tngs_importe,
@lpr_imp_precio10p tngs_importe,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..ListasDePrecios
      set lpr_des_des= @lpr_des_des,
          lpr_cod_codplan= @lpr_cod_codplan,
          lpr_rcd_codmarca= @lpr_rcd_codmarca,
          lpr_imp_precio1p= @lpr_imp_precio1p,
          lpr_imp_precio2p= @lpr_imp_precio2p,
          lpr_imp_precio3p= @lpr_imp_precio3p,
          lpr_imp_precio4p= @lpr_imp_precio4p,
          lpr_imp_precio5p= @lpr_imp_precio5p,
          lpr_imp_precio6p= @lpr_imp_precio6p,
          lpr_imp_precio7p= @lpr_imp_precio7p,
          lpr_imp_precio8p= @lpr_imp_precio8p,
          lpr_imp_precio9p= @lpr_imp_precio9p,
          lpr_imp_precio10p= @lpr_imp_precio10p,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where lpr_cod_cod = @lpr_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.LISTASDEPRECIOS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@lpr_cod_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.LISTASDEPRECIOS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.LISTASDEPRECIOS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.LISTASDEPRECIOS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.LISTASDEPRECIOS_DELETE
(
@lpr_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..ListasDePrecios
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where lpr_cod_cod = @lpr_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.LISTASDEPRECIOS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@lpr_cod_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.LISTASDEPRECIOS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.LISTASDEPRECIOS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.LISTASDEPRECIOS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.LISTASDEPRECIOS_RECALL
(
@lpr_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..ListasDePrecios
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where lpr_cod_cod = @lpr_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.LISTASDEPRECIOS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@lpr_cod_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.LISTASDEPRECIOS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.LISTASDEPRECIOS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.LISTASDEPRECIOS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.LISTASDEPRECIOS_DROP
(
@lpr_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..ListasDePrecios
    where lpr_cod_cod = @lpr_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.LISTASDEPRECIOS_DROP to tngsmodulos

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

print 'Store Procedure: dbo.LISTASDEPRECIOS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.LISTASDEPRECIOS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.LISTASDEPRECIOS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.LISTASDEPRECIOS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Carm..ListasDePrecios
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.LISTASDEPRECIOS_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: ListasDePrecios
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 04/01/2023 00:01
// Sistema     : Carm
// Tabla       : Localidades
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
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 04/01/2023 00:01
// Sistema     : Carm
// Tabla       : LogClientes
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

print 'Store Procedure: dbo.LOGCLIENTES_UP'

if exists (select * from sysobjects where id = object_id('dbo.LOGCLIENTES_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.LOGCLIENTES_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.LOGCLIENTES_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select lgc_nro_nro,
                lgc_nro_nrocliente,
                lgc_nro_nroavalon,
                lgc_ede_rsocial,
                lgc_des_nomfantasia,
                lgc_des_accion,
                lgc_nom_usuario,
                lgc_fyh_fecha,
                TNGS_Carm..LogClientes.instante,
                TNGS_Carm..LogClientes.deleted,
                TNGS_Carm..LogClientes.usuario,
                TNGS_Carm..LogClientes.version
           from TNGS_Carm..LogClientes
          where deleted = 0
          order by lgc_nro_nro
      end
   else
      begin
         Select lgc_nro_nro,
                lgc_nro_nrocliente,
                lgc_nro_nroavalon,
                lgc_ede_rsocial,
                lgc_des_nomfantasia,
                lgc_des_accion,
                lgc_nom_usuario,
                lgc_fyh_fecha,
                TNGS_Carm..LogClientes.instante,
                TNGS_Carm..LogClientes.deleted,
                TNGS_Carm..LogClientes.usuario,
                TNGS_Carm..LogClientes.version
           from TNGS_Carm..LogClientes
          order by lgc_nro_nro
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.LOGCLIENTES_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@lgc_nro_nro">Numero</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.LOGCLIENTES_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.LOGCLIENTES_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.LOGCLIENTES_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.LOGCLIENTES_CHKVERSION
(
@lgc_nro_nro tngs_numero,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Carm..LogClientes
    where lgc_nro_nro = @lgc_nro_nro
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.LOGCLIENTES_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@lgc_nro_nro">Numero</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.LOGCLIENTES_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.LOGCLIENTES_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.LOGCLIENTES_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.LOGCLIENTES_SEARCH
(
@lgc_nro_nro tngs_numero,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select lgc_nro_nro,
                lgc_nro_nrocliente,
                lgc_nro_nroavalon,
                lgc_ede_rsocial,
                lgc_des_nomfantasia,
                lgc_des_accion,
                lgc_nom_usuario,
                lgc_fyh_fecha,
                TNGS_Carm..LogClientes.instante,
                TNGS_Carm..LogClientes.deleted,
                TNGS_Carm..LogClientes.usuario,
                TNGS_Carm..LogClientes.version
           from TNGS_Carm..LogClientes
          where lgc_nro_nro = @lgc_nro_nro
            and deleted = 0
      end
   else
      begin
         Select lgc_nro_nro,
                lgc_nro_nrocliente,
                lgc_nro_nroavalon,
                lgc_ede_rsocial,
                lgc_des_nomfantasia,
                lgc_des_accion,
                lgc_nom_usuario,
                lgc_fyh_fecha,
                TNGS_Carm..LogClientes.instante,
                TNGS_Carm..LogClientes.deleted,
                TNGS_Carm..LogClientes.usuario,
                TNGS_Carm..LogClientes.version
           from TNGS_Carm..LogClientes
          where lgc_nro_nro = @lgc_nro_nro
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.LOGCLIENTES_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@lgc_nro_nro">Numero</param>
--- <param name="@lgc_nro_nrocliente">Número Cliente</param>
--- <param name="@lgc_nro_nroavalon">Número Avalon</param>
--- <param name="@lgc_ede_rsocial">Razon Social</param>
--- <param name="@lgc_des_nomfantasia">Nombre Fantasia</param>
--- <param name="@lgc_des_accion">Acción</param>
--- <param name="@lgc_nom_usuario">Usuario</param>
--- <param name="@lgc_fyh_fecha">Fecha</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.LOGCLIENTES_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.LOGCLIENTES_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.LOGCLIENTES_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.LOGCLIENTES_INSERT
(
@lgc_nro_nro tngs_numero,
@lgc_nro_nrocliente tngs_numero,
@lgc_nro_nroavalon tngs_numero,
@lgc_ede_rsocial tngs_descripcion_e,
@lgc_des_nomfantasia tngs_descripcion,
@lgc_des_accion tngs_descripcion,
@lgc_nom_usuario tngs_nombre,
@lgc_fyh_fecha tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Carm..LogClientes
   values (
           @lgc_nro_nro,
           @lgc_nro_nrocliente,
           @lgc_nro_nroavalon,
           @lgc_ede_rsocial,
           @lgc_des_nomfantasia,
           @lgc_des_accion,
           @lgc_nom_usuario,
           @lgc_fyh_fecha,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.LOGCLIENTES_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@lgc_nro_nro">Numero</param>
--- <param name="@lgc_nro_nrocliente">Número Cliente</param>
--- <param name="@lgc_nro_nroavalon">Número Avalon</param>
--- <param name="@lgc_ede_rsocial">Razon Social</param>
--- <param name="@lgc_des_nomfantasia">Nombre Fantasia</param>
--- <param name="@lgc_des_accion">Acción</param>
--- <param name="@lgc_nom_usuario">Usuario</param>
--- <param name="@lgc_fyh_fecha">Fecha</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.LOGCLIENTES_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.LOGCLIENTES_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.LOGCLIENTES_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.LOGCLIENTES_UPDATE
(
@lgc_nro_nro tngs_numero,
@lgc_nro_nrocliente tngs_numero,
@lgc_nro_nroavalon tngs_numero,
@lgc_ede_rsocial tngs_descripcion_e,
@lgc_des_nomfantasia tngs_descripcion,
@lgc_des_accion tngs_descripcion,
@lgc_nom_usuario tngs_nombre,
@lgc_fyh_fecha tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..LogClientes
      set lgc_nro_nrocliente= @lgc_nro_nrocliente,
          lgc_nro_nroavalon= @lgc_nro_nroavalon,
          lgc_ede_rsocial= @lgc_ede_rsocial,
          lgc_des_nomfantasia= @lgc_des_nomfantasia,
          lgc_des_accion= @lgc_des_accion,
          lgc_nom_usuario= @lgc_nom_usuario,
          lgc_fyh_fecha= @lgc_fyh_fecha,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where lgc_nro_nro = @lgc_nro_nro

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.LOGCLIENTES_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@lgc_nro_nro">Numero</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.LOGCLIENTES_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.LOGCLIENTES_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.LOGCLIENTES_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.LOGCLIENTES_DELETE
(
@lgc_nro_nro tngs_numero,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..LogClientes
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where lgc_nro_nro = @lgc_nro_nro

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.LOGCLIENTES_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@lgc_nro_nro">Numero</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.LOGCLIENTES_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.LOGCLIENTES_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.LOGCLIENTES_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.LOGCLIENTES_RECALL
(
@lgc_nro_nro tngs_numero,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..LogClientes
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where lgc_nro_nro = @lgc_nro_nro

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.LOGCLIENTES_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@lgc_nro_nro">Numero</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.LOGCLIENTES_DROP'

if exists (select * from sysobjects where id = object_id('dbo.LOGCLIENTES_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.LOGCLIENTES_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.LOGCLIENTES_DROP
(
@lgc_nro_nro tngs_numero,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..LogClientes
    where lgc_nro_nro = @lgc_nro_nro

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.LOGCLIENTES_DROP to tngsmodulos

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

print 'Store Procedure: dbo.LOGCLIENTES_PACK'

if exists (select * from sysobjects where id = object_id('dbo.LOGCLIENTES_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.LOGCLIENTES_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.LOGCLIENTES_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Carm..LogClientes
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.LOGCLIENTES_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: LogClientes
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 04/01/2023 00:01
// Sistema     : Carm
// Tabla       : Marcas
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

print 'Store Procedure: dbo.MARCAS_UP'

if exists (select * from sysobjects where id = object_id('dbo.MARCAS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MARCAS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MARCAS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mrc_rcd_cod,
                mrc_ede_des,
                mrc_ecd_codlocalidad,
                isnull(loc_ede_nombre, '') as des_localidad,
                TNGS_Carm..Marcas.instante,
                TNGS_Carm..Marcas.deleted,
                TNGS_Carm..Marcas.usuario,
                TNGS_Carm..Marcas.version
           from TNGS_Carm..Marcas
                join TNGS_Carm..Localidades
                  on mrc_ecd_codlocalidad = loc_ecd_codpost
          where TNGS_Carm..Marcas.deleted = 0
          order by mrc_rcd_cod
      end
   else
      begin
         Select mrc_rcd_cod,
                mrc_ede_des,
                mrc_ecd_codlocalidad,
                isnull(loc_ede_nombre, '') as des_localidad,
                TNGS_Carm..Marcas.instante,
                TNGS_Carm..Marcas.deleted,
                TNGS_Carm..Marcas.usuario,
                TNGS_Carm..Marcas.version
           from TNGS_Carm..Marcas
                join TNGS_Carm..Localidades
                  on mrc_ecd_codlocalidad = loc_ecd_codpost
          order by mrc_rcd_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MARCAS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@mrc_rcd_cod">Codigo</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MARCAS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.MARCAS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MARCAS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MARCAS_CHKVERSION
(
@mrc_rcd_cod tngs_codigo_r,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Carm..Marcas
    where mrc_rcd_cod = @mrc_rcd_cod
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MARCAS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@mrc_rcd_cod">Codigo</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MARCAS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.MARCAS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MARCAS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MARCAS_SEARCH
(
@mrc_rcd_cod tngs_codigo_r,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mrc_rcd_cod,
                mrc_ede_des,
                mrc_ecd_codlocalidad,
                isnull(loc_ede_nombre, '') as des_localidad,
                TNGS_Carm..Marcas.instante,
                TNGS_Carm..Marcas.deleted,
                TNGS_Carm..Marcas.usuario,
                TNGS_Carm..Marcas.version
           from TNGS_Carm..Marcas
                join TNGS_Carm..Localidades
                  on mrc_ecd_codlocalidad = loc_ecd_codpost
          where mrc_rcd_cod = @mrc_rcd_cod
            and TNGS_Carm..Marcas.deleted = 0
      end
   else
      begin
         Select mrc_rcd_cod,
                mrc_ede_des,
                mrc_ecd_codlocalidad,
                isnull(loc_ede_nombre, '') as des_localidad,
                TNGS_Carm..Marcas.instante,
                TNGS_Carm..Marcas.deleted,
                TNGS_Carm..Marcas.usuario,
                TNGS_Carm..Marcas.version
           from TNGS_Carm..Marcas
                join TNGS_Carm..Localidades
                  on mrc_ecd_codlocalidad = loc_ecd_codpost
          where mrc_rcd_cod = @mrc_rcd_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MARCAS_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@mrc_rcd_cod">Codigo</param>
--- <param name="@mrc_ede_des">Descripcion</param>
--- <param name="@mrc_ecd_codlocalidad">Localidad</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MARCAS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.MARCAS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MARCAS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MARCAS_INSERT
(
@mrc_rcd_cod tngs_codigo_r,
@mrc_ede_des tngs_descripcion_e,
@mrc_ecd_codlocalidad tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Carm..Marcas
   values (
           @mrc_rcd_cod,
           @mrc_ede_des,
           @mrc_ecd_codlocalidad,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MARCAS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@mrc_rcd_cod">Codigo</param>
--- <param name="@mrc_ede_des">Descripcion</param>
--- <param name="@mrc_ecd_codlocalidad">Localidad</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MARCAS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.MARCAS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MARCAS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MARCAS_UPDATE
(
@mrc_rcd_cod tngs_codigo_r,
@mrc_ede_des tngs_descripcion_e,
@mrc_ecd_codlocalidad tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Marcas
      set mrc_ede_des= @mrc_ede_des,
          mrc_ecd_codlocalidad= @mrc_ecd_codlocalidad,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mrc_rcd_cod = @mrc_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MARCAS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@mrc_rcd_cod">Codigo</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MARCAS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.MARCAS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MARCAS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MARCAS_DELETE
(
@mrc_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Marcas
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mrc_rcd_cod = @mrc_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MARCAS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@mrc_rcd_cod">Codigo</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MARCAS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.MARCAS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MARCAS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MARCAS_RECALL
(
@mrc_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Marcas
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mrc_rcd_cod = @mrc_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MARCAS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@mrc_rcd_cod">Codigo</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MARCAS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.MARCAS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MARCAS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MARCAS_DROP
(
@mrc_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..Marcas
    where mrc_rcd_cod = @mrc_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MARCAS_DROP to tngsmodulos

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

print 'Store Procedure: dbo.MARCAS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.MARCAS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MARCAS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MARCAS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Carm..Marcas
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MARCAS_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Marcas
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 04/01/2023 00:01
// Sistema     : Carm
// Tabla       : MotivosLlamada
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
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 04/01/2023 00:01
// Sistema     : Carm
// Tabla       : Parametros
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

print 'Store Procedure: dbo.PARAMETROS_UP'

if exists (select * from sysobjects where id = object_id('dbo.PARAMETROS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PARAMETROS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PARAMETROS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select par_xcd_codigo,
                par_des_descripcion,
                par_xde_valor,
                par_est_editable,
                par_est_sololectura,
                par_rob_detalle,
                TNGS_Carm..Parametros.instante,
                TNGS_Carm..Parametros.deleted,
                TNGS_Carm..Parametros.usuario,
                TNGS_Carm..Parametros.version
           from TNGS_Carm..Parametros
          where deleted = 0
          order by par_xcd_codigo
      end
   else
      begin
         Select par_xcd_codigo,
                par_des_descripcion,
                par_xde_valor,
                par_est_editable,
                par_est_sololectura,
                par_rob_detalle,
                TNGS_Carm..Parametros.instante,
                TNGS_Carm..Parametros.deleted,
                TNGS_Carm..Parametros.usuario,
                TNGS_Carm..Parametros.version
           from TNGS_Carm..Parametros
          order by par_xcd_codigo
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PARAMETROS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@par_xcd_codigo">Código</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PARAMETROS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.PARAMETROS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PARAMETROS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PARAMETROS_CHKVERSION
(
@par_xcd_codigo tngs_codigo_x,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Carm..Parametros
    where par_xcd_codigo = @par_xcd_codigo
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PARAMETROS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@par_xcd_codigo">Código</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PARAMETROS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.PARAMETROS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PARAMETROS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PARAMETROS_SEARCH
(
@par_xcd_codigo tngs_codigo_x,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select par_xcd_codigo,
                par_des_descripcion,
                par_xde_valor,
                par_est_editable,
                par_est_sololectura,
                par_rob_detalle,
                TNGS_Carm..Parametros.instante,
                TNGS_Carm..Parametros.deleted,
                TNGS_Carm..Parametros.usuario,
                TNGS_Carm..Parametros.version
           from TNGS_Carm..Parametros
          where par_xcd_codigo = @par_xcd_codigo
            and deleted = 0
      end
   else
      begin
         Select par_xcd_codigo,
                par_des_descripcion,
                par_xde_valor,
                par_est_editable,
                par_est_sololectura,
                par_rob_detalle,
                TNGS_Carm..Parametros.instante,
                TNGS_Carm..Parametros.deleted,
                TNGS_Carm..Parametros.usuario,
                TNGS_Carm..Parametros.version
           from TNGS_Carm..Parametros
          where par_xcd_codigo = @par_xcd_codigo
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PARAMETROS_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@par_xcd_codigo">Código</param>
--- <param name="@par_des_descripcion">Descripción</param>
--- <param name="@par_xde_valor">Valor</param>
--- <param name="@par_est_editable">Editable</param>
--- <param name="@par_est_sololectura">Sólo lectura</param>
--- <param name="@par_rob_detalle">Detalle</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PARAMETROS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.PARAMETROS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PARAMETROS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PARAMETROS_INSERT
(
@par_xcd_codigo tngs_codigo_x,
@par_des_descripcion tngs_descripcion,
@par_xde_valor tngs_descripcion_x,
@par_est_editable tngs_estado,
@par_est_sololectura tngs_estado,
@par_rob_detalle tngs_observaciones_r,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Carm..Parametros
   values (
           @par_xcd_codigo,
           @par_des_descripcion,
           @par_xde_valor,
           @par_est_editable,
           @par_est_sololectura,
           @par_rob_detalle,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PARAMETROS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@par_xcd_codigo">Código</param>
--- <param name="@par_des_descripcion">Descripción</param>
--- <param name="@par_xde_valor">Valor</param>
--- <param name="@par_est_editable">Editable</param>
--- <param name="@par_est_sololectura">Sólo lectura</param>
--- <param name="@par_rob_detalle">Detalle</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PARAMETROS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.PARAMETROS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PARAMETROS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PARAMETROS_UPDATE
(
@par_xcd_codigo tngs_codigo_x,
@par_des_descripcion tngs_descripcion,
@par_xde_valor tngs_descripcion_x,
@par_est_editable tngs_estado,
@par_est_sololectura tngs_estado,
@par_rob_detalle tngs_observaciones_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Parametros
      set par_des_descripcion= @par_des_descripcion,
          par_xde_valor= @par_xde_valor,
          par_est_editable= @par_est_editable,
          par_est_sololectura= @par_est_sololectura,
          par_rob_detalle= @par_rob_detalle,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where par_xcd_codigo = @par_xcd_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PARAMETROS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@par_xcd_codigo">Código</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PARAMETROS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.PARAMETROS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PARAMETROS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PARAMETROS_DELETE
(
@par_xcd_codigo tngs_codigo_x,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Parametros
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where par_xcd_codigo = @par_xcd_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PARAMETROS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@par_xcd_codigo">Código</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PARAMETROS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.PARAMETROS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PARAMETROS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PARAMETROS_RECALL
(
@par_xcd_codigo tngs_codigo_x,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Parametros
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where par_xcd_codigo = @par_xcd_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PARAMETROS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@par_xcd_codigo">Código</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PARAMETROS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.PARAMETROS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PARAMETROS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PARAMETROS_DROP
(
@par_xcd_codigo tngs_codigo_x,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..Parametros
    where par_xcd_codigo = @par_xcd_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PARAMETROS_DROP to tngsmodulos

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

print 'Store Procedure: dbo.PARAMETROS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.PARAMETROS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PARAMETROS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PARAMETROS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Carm..Parametros
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PARAMETROS_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Parametros
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 04/01/2023 00:01
// Sistema     : Carm
// Tabla       : Parentescos
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

print 'Store Procedure: dbo.PARENTESCOS_UP'

if exists (select * from sysobjects where id = object_id('dbo.PARENTESCOS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PARENTESCOS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PARENTESCOS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select prt_rcd_cod,
                prt_des_des,
                TNGS_Carm..Parentescos.instante,
                TNGS_Carm..Parentescos.deleted,
                TNGS_Carm..Parentescos.usuario,
                TNGS_Carm..Parentescos.version
           from TNGS_Carm..Parentescos
          where deleted = 0
          order by prt_rcd_cod
      end
   else
      begin
         Select prt_rcd_cod,
                prt_des_des,
                TNGS_Carm..Parentescos.instante,
                TNGS_Carm..Parentescos.deleted,
                TNGS_Carm..Parentescos.usuario,
                TNGS_Carm..Parentescos.version
           from TNGS_Carm..Parentescos
          order by prt_rcd_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PARENTESCOS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@prt_rcd_cod">Codigo</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PARENTESCOS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.PARENTESCOS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PARENTESCOS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PARENTESCOS_CHKVERSION
(
@prt_rcd_cod tngs_codigo_r,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Carm..Parentescos
    where prt_rcd_cod = @prt_rcd_cod
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PARENTESCOS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@prt_rcd_cod">Codigo</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PARENTESCOS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.PARENTESCOS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PARENTESCOS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PARENTESCOS_SEARCH
(
@prt_rcd_cod tngs_codigo_r,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select prt_rcd_cod,
                prt_des_des,
                TNGS_Carm..Parentescos.instante,
                TNGS_Carm..Parentescos.deleted,
                TNGS_Carm..Parentescos.usuario,
                TNGS_Carm..Parentescos.version
           from TNGS_Carm..Parentescos
          where prt_rcd_cod = @prt_rcd_cod
            and deleted = 0
      end
   else
      begin
         Select prt_rcd_cod,
                prt_des_des,
                TNGS_Carm..Parentescos.instante,
                TNGS_Carm..Parentescos.deleted,
                TNGS_Carm..Parentescos.usuario,
                TNGS_Carm..Parentescos.version
           from TNGS_Carm..Parentescos
          where prt_rcd_cod = @prt_rcd_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PARENTESCOS_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@prt_rcd_cod">Codigo</param>
--- <param name="@prt_des_des">Descripcion</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PARENTESCOS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.PARENTESCOS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PARENTESCOS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PARENTESCOS_INSERT
(
@prt_rcd_cod tngs_codigo_r,
@prt_des_des tngs_descripcion,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Carm..Parentescos
   values (
           @prt_rcd_cod,
           @prt_des_des,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PARENTESCOS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@prt_rcd_cod">Codigo</param>
--- <param name="@prt_des_des">Descripcion</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PARENTESCOS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.PARENTESCOS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PARENTESCOS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PARENTESCOS_UPDATE
(
@prt_rcd_cod tngs_codigo_r,
@prt_des_des tngs_descripcion,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Parentescos
      set prt_des_des= @prt_des_des,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where prt_rcd_cod = @prt_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PARENTESCOS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@prt_rcd_cod">Codigo</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PARENTESCOS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.PARENTESCOS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PARENTESCOS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PARENTESCOS_DELETE
(
@prt_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Parentescos
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where prt_rcd_cod = @prt_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PARENTESCOS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@prt_rcd_cod">Codigo</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PARENTESCOS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.PARENTESCOS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PARENTESCOS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PARENTESCOS_RECALL
(
@prt_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Parentescos
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where prt_rcd_cod = @prt_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PARENTESCOS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@prt_rcd_cod">Codigo</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PARENTESCOS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.PARENTESCOS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PARENTESCOS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PARENTESCOS_DROP
(
@prt_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..Parentescos
    where prt_rcd_cod = @prt_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PARENTESCOS_DROP to tngsmodulos

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

print 'Store Procedure: dbo.PARENTESCOS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.PARENTESCOS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PARENTESCOS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PARENTESCOS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Carm..Parentescos
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PARENTESCOS_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Parentescos
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 04/01/2023 00:01
// Sistema     : Carm
// Tabla       : Planes
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

print 'Store Procedure: dbo.PLANES_UP'

if exists (select * from sysobjects where id = object_id('dbo.PLANES_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PLANES_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PLANES_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select pln_cod_cod,
                pln_des_des,
                pln_cod_codplanavalon,
                pln_d80_tcontratoavalon,
                TNGS_Carm..Planes.instante,
                TNGS_Carm..Planes.deleted,
                TNGS_Carm..Planes.usuario,
                TNGS_Carm..Planes.version
           from TNGS_Carm..Planes
          where deleted = 0
          order by pln_cod_cod
      end
   else
      begin
         Select pln_cod_cod,
                pln_des_des,
                pln_cod_codplanavalon,
                pln_d80_tcontratoavalon,
                TNGS_Carm..Planes.instante,
                TNGS_Carm..Planes.deleted,
                TNGS_Carm..Planes.usuario,
                TNGS_Carm..Planes.version
           from TNGS_Carm..Planes
          order by pln_cod_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PLANES_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@pln_cod_cod">Código</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PLANES_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.PLANES_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PLANES_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PLANES_CHKVERSION
(
@pln_cod_cod tngs_codigo,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Carm..Planes
    where pln_cod_cod = @pln_cod_cod
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PLANES_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@pln_cod_cod">Código</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PLANES_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.PLANES_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PLANES_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PLANES_SEARCH
(
@pln_cod_cod tngs_codigo,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select pln_cod_cod,
                pln_des_des,
                pln_cod_codplanavalon,
                pln_d80_tcontratoavalon,
                TNGS_Carm..Planes.instante,
                TNGS_Carm..Planes.deleted,
                TNGS_Carm..Planes.usuario,
                TNGS_Carm..Planes.version
           from TNGS_Carm..Planes
          where pln_cod_cod = @pln_cod_cod
            and deleted = 0
      end
   else
      begin
         Select pln_cod_cod,
                pln_des_des,
                pln_cod_codplanavalon,
                pln_d80_tcontratoavalon,
                TNGS_Carm..Planes.instante,
                TNGS_Carm..Planes.deleted,
                TNGS_Carm..Planes.usuario,
                TNGS_Carm..Planes.version
           from TNGS_Carm..Planes
          where pln_cod_cod = @pln_cod_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PLANES_SEARCH to tngsmodulos

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

print 'Store Procedure: dbo.PLANES_GETMAXKEY'

if exists (select * from sysobjects where id = object_id('dbo.PLANES_GETMAXKEY'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PLANES_GETMAXKEY
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PLANES_GETMAXKEY
(
@dummy tngs_codigo_1
)
as
begin

   Select isnull(max(pln_cod_cod), '0') as pln_cod_cod
     from TNGS_Carm..Planes

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PLANES_GETMAXKEY to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@pln_cod_cod">Código</param>
--- <param name="@pln_des_des">Descripción</param>
--- <param name="@pln_cod_codplanavalon">Cod Plan Avalon</param>
--- <param name="@pln_d80_tcontratoavalon">Lista de T Contratos Avalon</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PLANES_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.PLANES_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PLANES_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PLANES_INSERT
(
@pln_cod_cod tngs_codigo,
@pln_des_des tngs_descripcion,
@pln_cod_codplanavalon tngs_codigo,
@pln_d80_tcontratoavalon tngs_descripcion_80,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Carm..Planes
   values (
           @pln_cod_cod,
           @pln_des_des,
           @pln_cod_codplanavalon,
           @pln_d80_tcontratoavalon,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PLANES_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@pln_cod_cod">Código</param>
--- <param name="@pln_des_des">Descripción</param>
--- <param name="@pln_cod_codplanavalon">Cod Plan Avalon</param>
--- <param name="@pln_d80_tcontratoavalon">Lista de T Contratos Avalon</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PLANES_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.PLANES_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PLANES_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PLANES_UPDATE
(
@pln_cod_cod tngs_codigo,
@pln_des_des tngs_descripcion,
@pln_cod_codplanavalon tngs_codigo,
@pln_d80_tcontratoavalon tngs_descripcion_80,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Planes
      set pln_des_des= @pln_des_des,
          pln_cod_codplanavalon= @pln_cod_codplanavalon,
          pln_d80_tcontratoavalon= @pln_d80_tcontratoavalon,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where pln_cod_cod = @pln_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PLANES_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@pln_cod_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PLANES_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.PLANES_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PLANES_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PLANES_DELETE
(
@pln_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Planes
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where pln_cod_cod = @pln_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PLANES_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@pln_cod_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PLANES_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.PLANES_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PLANES_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PLANES_RECALL
(
@pln_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Planes
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where pln_cod_cod = @pln_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PLANES_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@pln_cod_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PLANES_DROP'

if exists (select * from sysobjects where id = object_id('dbo.PLANES_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PLANES_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PLANES_DROP
(
@pln_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..Planes
    where pln_cod_cod = @pln_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PLANES_DROP to tngsmodulos

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

print 'Store Procedure: dbo.PLANES_PACK'

if exists (select * from sysobjects where id = object_id('dbo.PLANES_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PLANES_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PLANES_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Carm..Planes
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PLANES_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: GetPlanesFromTCont
--- </summary>
--- <param name="@codtcont">Codigo de Tipo de Contrato</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PLANES_GETPLANESFROMTCONT'

if exists (select * from sysobjects where id = object_id('dbo.PLANES_GETPLANESFROMTCONT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PLANES_GETPLANESFROMTCONT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PLANES_GETPLANESFROMTCONT
(
@codtcont tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   select distinct pln_cod_cod,pln_des_des,Planes.deleted 
   from Planes 
   join TipoCont on CHARINDEX(tcn_rcd_tcontratoavalon + ',',pln_d80_tcontratoavalon) <> 0 
   where tcn_rcd_cod = @codtcont 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PLANES_GETPLANESFROMTCONT to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Planes
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 04/01/2023 00:01
// Sistema     : Carm
// Tabla       : PlnServicios
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
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 04/01/2023 00:01
// Sistema     : Carm
// Tabla       : PreciosServicios
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

print 'Store Procedure: dbo.PRECIOSSERVICIOS_UP'

if exists (select * from sysobjects where id = object_id('dbo.PRECIOSSERVICIOS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PRECIOSSERVICIOS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PRECIOSSERVICIOS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select prs_cd1_color,
                prs_fec_fecha,
                prs_imp_precio,
                prs_imp_coseguro,
                TNGS_Carm..PreciosServicios.instante,
                TNGS_Carm..PreciosServicios.deleted,
                TNGS_Carm..PreciosServicios.usuario,
                TNGS_Carm..PreciosServicios.version
           from TNGS_Carm..PreciosServicios
          where deleted = 0
          order by prs_cd1_color,
                prs_fec_fecha
      end
   else
      begin
         Select prs_cd1_color,
                prs_fec_fecha,
                prs_imp_precio,
                prs_imp_coseguro,
                TNGS_Carm..PreciosServicios.instante,
                TNGS_Carm..PreciosServicios.deleted,
                TNGS_Carm..PreciosServicios.usuario,
                TNGS_Carm..PreciosServicios.version
           from TNGS_Carm..PreciosServicios
          order by prs_cd1_color,
                prs_fec_fecha
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PRECIOSSERVICIOS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@prs_cd1_color">Color</param>
--- <param name="@prs_fec_fecha">Fecha</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PRECIOSSERVICIOS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.PRECIOSSERVICIOS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PRECIOSSERVICIOS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PRECIOSSERVICIOS_CHKVERSION
(
@prs_cd1_color tngs_codigo_1,
@prs_fec_fecha tngs_fecha,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Carm..PreciosServicios
    where prs_cd1_color = @prs_cd1_color
      and prs_fec_fecha = @prs_fec_fecha
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PRECIOSSERVICIOS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@prs_cd1_color">Color</param>
--- <param name="@prs_fec_fecha">Fecha</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PRECIOSSERVICIOS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.PRECIOSSERVICIOS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PRECIOSSERVICIOS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PRECIOSSERVICIOS_SEARCH
(
@prs_cd1_color tngs_codigo_1,
@prs_fec_fecha tngs_fecha,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select prs_cd1_color,
                prs_fec_fecha,
                prs_imp_precio,
                prs_imp_coseguro,
                TNGS_Carm..PreciosServicios.instante,
                TNGS_Carm..PreciosServicios.deleted,
                TNGS_Carm..PreciosServicios.usuario,
                TNGS_Carm..PreciosServicios.version
           from TNGS_Carm..PreciosServicios
          where prs_cd1_color = @prs_cd1_color
            and prs_fec_fecha = @prs_fec_fecha
            and deleted = 0
      end
   else
      begin
         Select prs_cd1_color,
                prs_fec_fecha,
                prs_imp_precio,
                prs_imp_coseguro,
                TNGS_Carm..PreciosServicios.instante,
                TNGS_Carm..PreciosServicios.deleted,
                TNGS_Carm..PreciosServicios.usuario,
                TNGS_Carm..PreciosServicios.version
           from TNGS_Carm..PreciosServicios
          where prs_cd1_color = @prs_cd1_color
            and prs_fec_fecha = @prs_fec_fecha
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PRECIOSSERVICIOS_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@prs_cd1_color">Color</param>
--- <param name="@prs_fec_fecha">Fecha</param>
--- <param name="@prs_imp_precio">Precio</param>
--- <param name="@prs_imp_coseguro">coseguro</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PRECIOSSERVICIOS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.PRECIOSSERVICIOS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PRECIOSSERVICIOS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PRECIOSSERVICIOS_INSERT
(
@prs_cd1_color tngs_codigo_1,
@prs_fec_fecha tngs_fecha,
@prs_imp_precio tngs_importe,
@prs_imp_coseguro tngs_importe,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Carm..PreciosServicios
   values (
           @prs_cd1_color,
           @prs_fec_fecha,
           @prs_imp_precio,
           @prs_imp_coseguro,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PRECIOSSERVICIOS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@prs_cd1_color">Color</param>
--- <param name="@prs_fec_fecha">Fecha</param>
--- <param name="@prs_imp_precio">Precio</param>
--- <param name="@prs_imp_coseguro">coseguro</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PRECIOSSERVICIOS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.PRECIOSSERVICIOS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PRECIOSSERVICIOS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PRECIOSSERVICIOS_UPDATE
(
@prs_cd1_color tngs_codigo_1,
@prs_fec_fecha tngs_fecha,
@prs_imp_precio tngs_importe,
@prs_imp_coseguro tngs_importe,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..PreciosServicios
      set prs_imp_precio= @prs_imp_precio,
          prs_imp_coseguro= @prs_imp_coseguro,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where prs_cd1_color = @prs_cd1_color
      and prs_fec_fecha = @prs_fec_fecha

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PRECIOSSERVICIOS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@prs_cd1_color">Color</param>
--- <param name="@prs_fec_fecha">Fecha</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PRECIOSSERVICIOS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.PRECIOSSERVICIOS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PRECIOSSERVICIOS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PRECIOSSERVICIOS_DELETE
(
@prs_cd1_color tngs_codigo_1,
@prs_fec_fecha tngs_fecha,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..PreciosServicios
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where prs_cd1_color = @prs_cd1_color
      and prs_fec_fecha = @prs_fec_fecha

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PRECIOSSERVICIOS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@prs_cd1_color">Color</param>
--- <param name="@prs_fec_fecha">Fecha</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PRECIOSSERVICIOS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.PRECIOSSERVICIOS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PRECIOSSERVICIOS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PRECIOSSERVICIOS_RECALL
(
@prs_cd1_color tngs_codigo_1,
@prs_fec_fecha tngs_fecha,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..PreciosServicios
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where prs_cd1_color = @prs_cd1_color
      and prs_fec_fecha = @prs_fec_fecha

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PRECIOSSERVICIOS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@prs_cd1_color">Color</param>
--- <param name="@prs_fec_fecha">Fecha</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PRECIOSSERVICIOS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.PRECIOSSERVICIOS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PRECIOSSERVICIOS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PRECIOSSERVICIOS_DROP
(
@prs_cd1_color tngs_codigo_1,
@prs_fec_fecha tngs_fecha,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..PreciosServicios
    where prs_cd1_color = @prs_cd1_color
      and prs_fec_fecha = @prs_fec_fecha

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PRECIOSSERVICIOS_DROP to tngsmodulos

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

print 'Store Procedure: dbo.PRECIOSSERVICIOS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.PRECIOSSERVICIOS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PRECIOSSERVICIOS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PRECIOSSERVICIOS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Carm..PreciosServicios
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PRECIOSSERVICIOS_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: GetHistorialColor
--- </summary>
--- <param name="@color">Color</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PRECIOSSERVICIOS_GETHISTORIALCOLOR'

if exists (select * from sysobjects where id = object_id('dbo.PRECIOSSERVICIOS_GETHISTORIALCOLOR'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PRECIOSSERVICIOS_GETHISTORIALCOLOR
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PRECIOSSERVICIOS_GETHISTORIALCOLOR
(
@color tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Select prs_cd1_color,
          prs_fec_fecha,
          prs_imp_precio,
          prs_imp_coseguro,
          TNGS_Carm..PreciosServicios.instante,
          TNGS_Carm..PreciosServicios.deleted,
          TNGS_Carm..PreciosServicios.usuario,
          TNGS_Carm..PreciosServicios.version
     from TNGS_Carm..PreciosServicios 
   where prs_cd1_color = @color 
   order by prs_fec_fecha desc 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PRECIOSSERVICIOS_GETHISTORIALCOLOR to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: PreciosServicios
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 04/01/2023 00:01
// Sistema     : Carm
// Tabla       : ResEntrevista
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
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 04/01/2023 00:01
// Sistema     : Carm
// Tabla       : Rubros
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

print 'Store Procedure: dbo.RUBROS_UP'

if exists (select * from sysobjects where id = object_id('dbo.RUBROS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.RUBROS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.RUBROS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select rbr_rcd_cod,
                rbr_des_des,
                TNGS_Carm..Rubros.instante,
                TNGS_Carm..Rubros.deleted,
                TNGS_Carm..Rubros.usuario,
                TNGS_Carm..Rubros.version
           from TNGS_Carm..Rubros
          where deleted = 0
          order by rbr_rcd_cod
      end
   else
      begin
         Select rbr_rcd_cod,
                rbr_des_des,
                TNGS_Carm..Rubros.instante,
                TNGS_Carm..Rubros.deleted,
                TNGS_Carm..Rubros.usuario,
                TNGS_Carm..Rubros.version
           from TNGS_Carm..Rubros
          order by rbr_rcd_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.RUBROS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@rbr_rcd_cod">Código</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.RUBROS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.RUBROS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.RUBROS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.RUBROS_CHKVERSION
(
@rbr_rcd_cod tngs_codigo_r,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Carm..Rubros
    where rbr_rcd_cod = @rbr_rcd_cod
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.RUBROS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@rbr_rcd_cod">Código</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.RUBROS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.RUBROS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.RUBROS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.RUBROS_SEARCH
(
@rbr_rcd_cod tngs_codigo_r,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select rbr_rcd_cod,
                rbr_des_des,
                TNGS_Carm..Rubros.instante,
                TNGS_Carm..Rubros.deleted,
                TNGS_Carm..Rubros.usuario,
                TNGS_Carm..Rubros.version
           from TNGS_Carm..Rubros
          where rbr_rcd_cod = @rbr_rcd_cod
            and deleted = 0
      end
   else
      begin
         Select rbr_rcd_cod,
                rbr_des_des,
                TNGS_Carm..Rubros.instante,
                TNGS_Carm..Rubros.deleted,
                TNGS_Carm..Rubros.usuario,
                TNGS_Carm..Rubros.version
           from TNGS_Carm..Rubros
          where rbr_rcd_cod = @rbr_rcd_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.RUBROS_SEARCH to tngsmodulos

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

print 'Store Procedure: dbo.RUBROS_GETMAXKEY'

if exists (select * from sysobjects where id = object_id('dbo.RUBROS_GETMAXKEY'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.RUBROS_GETMAXKEY
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.RUBROS_GETMAXKEY
(
@dummy tngs_codigo_1
)
as
begin

   Select isnull(max(rbr_rcd_cod), '0') as rbr_rcd_cod
     from TNGS_Carm..Rubros

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.RUBROS_GETMAXKEY to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@rbr_rcd_cod">Código</param>
--- <param name="@rbr_des_des">Descripción</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.RUBROS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.RUBROS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.RUBROS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.RUBROS_INSERT
(
@rbr_rcd_cod tngs_codigo_r,
@rbr_des_des tngs_descripcion,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Carm..Rubros
   values (
           @rbr_rcd_cod,
           @rbr_des_des,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.RUBROS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@rbr_rcd_cod">Código</param>
--- <param name="@rbr_des_des">Descripción</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.RUBROS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.RUBROS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.RUBROS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.RUBROS_UPDATE
(
@rbr_rcd_cod tngs_codigo_r,
@rbr_des_des tngs_descripcion,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Rubros
      set rbr_des_des= @rbr_des_des,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where rbr_rcd_cod = @rbr_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.RUBROS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@rbr_rcd_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.RUBROS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.RUBROS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.RUBROS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.RUBROS_DELETE
(
@rbr_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Rubros
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where rbr_rcd_cod = @rbr_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.RUBROS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@rbr_rcd_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.RUBROS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.RUBROS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.RUBROS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.RUBROS_RECALL
(
@rbr_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Rubros
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where rbr_rcd_cod = @rbr_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.RUBROS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@rbr_rcd_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.RUBROS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.RUBROS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.RUBROS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.RUBROS_DROP
(
@rbr_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..Rubros
    where rbr_rcd_cod = @rbr_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.RUBROS_DROP to tngsmodulos

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

print 'Store Procedure: dbo.RUBROS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.RUBROS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.RUBROS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.RUBROS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Carm..Rubros
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.RUBROS_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Rubros
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 04/01/2023 00:01
// Sistema     : Carm
// Tabla       : Servicios
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

print 'Store Procedure: dbo.SERVICIOS_UP'

if exists (select * from sysobjects where id = object_id('dbo.SERVICIOS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SERVICIOS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SERVICIOS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select srv_cod_cod,
                srv_des_des,
                srv_xld_explicacion,
                TNGS_Carm..Servicios.instante,
                TNGS_Carm..Servicios.deleted,
                TNGS_Carm..Servicios.usuario,
                TNGS_Carm..Servicios.version
           from TNGS_Carm..Servicios
          where deleted = 0
          order by srv_cod_cod
      end
   else
      begin
         Select srv_cod_cod,
                srv_des_des,
                srv_xld_explicacion,
                TNGS_Carm..Servicios.instante,
                TNGS_Carm..Servicios.deleted,
                TNGS_Carm..Servicios.usuario,
                TNGS_Carm..Servicios.version
           from TNGS_Carm..Servicios
          order by srv_cod_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SERVICIOS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@srv_cod_cod">Código</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.SERVICIOS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.SERVICIOS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SERVICIOS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SERVICIOS_CHKVERSION
(
@srv_cod_cod tngs_codigo,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Carm..Servicios
    where srv_cod_cod = @srv_cod_cod
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SERVICIOS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@srv_cod_cod">Código</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.SERVICIOS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.SERVICIOS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SERVICIOS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SERVICIOS_SEARCH
(
@srv_cod_cod tngs_codigo,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select srv_cod_cod,
                srv_des_des,
                srv_xld_explicacion,
                TNGS_Carm..Servicios.instante,
                TNGS_Carm..Servicios.deleted,
                TNGS_Carm..Servicios.usuario,
                TNGS_Carm..Servicios.version
           from TNGS_Carm..Servicios
          where srv_cod_cod = @srv_cod_cod
            and deleted = 0
      end
   else
      begin
         Select srv_cod_cod,
                srv_des_des,
                srv_xld_explicacion,
                TNGS_Carm..Servicios.instante,
                TNGS_Carm..Servicios.deleted,
                TNGS_Carm..Servicios.usuario,
                TNGS_Carm..Servicios.version
           from TNGS_Carm..Servicios
          where srv_cod_cod = @srv_cod_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SERVICIOS_SEARCH to tngsmodulos

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

print 'Store Procedure: dbo.SERVICIOS_GETMAXKEY'

if exists (select * from sysobjects where id = object_id('dbo.SERVICIOS_GETMAXKEY'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SERVICIOS_GETMAXKEY
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SERVICIOS_GETMAXKEY
(
@dummy tngs_codigo_1
)
as
begin

   Select isnull(max(srv_cod_cod), '0') as srv_cod_cod
     from TNGS_Carm..Servicios

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SERVICIOS_GETMAXKEY to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@srv_cod_cod">Código</param>
--- <param name="@srv_des_des">Descripción</param>
--- <param name="@srv_xld_explicacion">Descripcion Extendida</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.SERVICIOS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.SERVICIOS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SERVICIOS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SERVICIOS_INSERT
(
@srv_cod_cod tngs_codigo,
@srv_des_des tngs_descripcion,
@srv_xld_explicacion tngs_descripcion_xl,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Carm..Servicios
   values (
           @srv_cod_cod,
           @srv_des_des,
           @srv_xld_explicacion,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SERVICIOS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@srv_cod_cod">Código</param>
--- <param name="@srv_des_des">Descripción</param>
--- <param name="@srv_xld_explicacion">Descripcion Extendida</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.SERVICIOS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.SERVICIOS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SERVICIOS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SERVICIOS_UPDATE
(
@srv_cod_cod tngs_codigo,
@srv_des_des tngs_descripcion,
@srv_xld_explicacion tngs_descripcion_xl,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Servicios
      set srv_des_des= @srv_des_des,
          srv_xld_explicacion= @srv_xld_explicacion,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where srv_cod_cod = @srv_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SERVICIOS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@srv_cod_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.SERVICIOS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.SERVICIOS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SERVICIOS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SERVICIOS_DELETE
(
@srv_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Servicios
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where srv_cod_cod = @srv_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SERVICIOS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@srv_cod_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.SERVICIOS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.SERVICIOS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SERVICIOS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SERVICIOS_RECALL
(
@srv_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Servicios
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where srv_cod_cod = @srv_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SERVICIOS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@srv_cod_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.SERVICIOS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.SERVICIOS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SERVICIOS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SERVICIOS_DROP
(
@srv_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..Servicios
    where srv_cod_cod = @srv_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SERVICIOS_DROP to tngsmodulos

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

print 'Store Procedure: dbo.SERVICIOS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.SERVICIOS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SERVICIOS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SERVICIOS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Carm..Servicios
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SERVICIOS_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: GetServiciosFull
--- </summary>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.SERVICIOS_GETSERVICIOSFULL'

if exists (select * from sysobjects where id = object_id('dbo.SERVICIOS_GETSERVICIOSFULL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SERVICIOS_GETSERVICIOSFULL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SERVICIOS_GETSERVICIOSFULL
(
@usuario tngs_nombre
)
as
begin

   select srv_cod_cod,srv_des_des, 0 as dummy,-2 as pls_nro_cprestlibres, 1 as pls_imp_valorprestacion 
   from Servicios 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SERVICIOS_GETSERVICIOSFULL to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Servicios
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 04/01/2023 00:01
// Sistema     : Carm
// Tabla       : SituacionesIVA
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

print 'Store Procedure: dbo.SITUACIONESIVA_UP'

if exists (select * from sysobjects where id = object_id('dbo.SITUACIONESIVA_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SITUACIONESIVA_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SITUACIONESIVA_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select siv_rcd_codigo,
                siv_des_descripcion,
                siv_cd1_discrimina,
                TNGS_Carm..SituacionesIVA.instante,
                TNGS_Carm..SituacionesIVA.deleted,
                TNGS_Carm..SituacionesIVA.usuario,
                TNGS_Carm..SituacionesIVA.version
           from TNGS_Carm..SituacionesIVA
          where deleted = 0
          order by siv_rcd_codigo
      end
   else
      begin
         Select siv_rcd_codigo,
                siv_des_descripcion,
                siv_cd1_discrimina,
                TNGS_Carm..SituacionesIVA.instante,
                TNGS_Carm..SituacionesIVA.deleted,
                TNGS_Carm..SituacionesIVA.usuario,
                TNGS_Carm..SituacionesIVA.version
           from TNGS_Carm..SituacionesIVA
          order by siv_rcd_codigo
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SITUACIONESIVA_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@siv_rcd_codigo">Codigo</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.SITUACIONESIVA_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.SITUACIONESIVA_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SITUACIONESIVA_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SITUACIONESIVA_CHKVERSION
(
@siv_rcd_codigo tngs_codigo_r,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Carm..SituacionesIVA
    where siv_rcd_codigo = @siv_rcd_codigo
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SITUACIONESIVA_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@siv_rcd_codigo">Codigo</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.SITUACIONESIVA_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.SITUACIONESIVA_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SITUACIONESIVA_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SITUACIONESIVA_SEARCH
(
@siv_rcd_codigo tngs_codigo_r,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select siv_rcd_codigo,
                siv_des_descripcion,
                siv_cd1_discrimina,
                TNGS_Carm..SituacionesIVA.instante,
                TNGS_Carm..SituacionesIVA.deleted,
                TNGS_Carm..SituacionesIVA.usuario,
                TNGS_Carm..SituacionesIVA.version
           from TNGS_Carm..SituacionesIVA
          where siv_rcd_codigo = @siv_rcd_codigo
            and deleted = 0
      end
   else
      begin
         Select siv_rcd_codigo,
                siv_des_descripcion,
                siv_cd1_discrimina,
                TNGS_Carm..SituacionesIVA.instante,
                TNGS_Carm..SituacionesIVA.deleted,
                TNGS_Carm..SituacionesIVA.usuario,
                TNGS_Carm..SituacionesIVA.version
           from TNGS_Carm..SituacionesIVA
          where siv_rcd_codigo = @siv_rcd_codigo
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SITUACIONESIVA_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@siv_rcd_codigo">Codigo</param>
--- <param name="@siv_des_descripcion">Descripcion</param>
--- <param name="@siv_cd1_discrimina">Discrimina</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.SITUACIONESIVA_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.SITUACIONESIVA_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SITUACIONESIVA_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SITUACIONESIVA_INSERT
(
@siv_rcd_codigo tngs_codigo_r,
@siv_des_descripcion tngs_descripcion,
@siv_cd1_discrimina tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Carm..SituacionesIVA
   values (
           @siv_rcd_codigo,
           @siv_des_descripcion,
           @siv_cd1_discrimina,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SITUACIONESIVA_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@siv_rcd_codigo">Codigo</param>
--- <param name="@siv_des_descripcion">Descripcion</param>
--- <param name="@siv_cd1_discrimina">Discrimina</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.SITUACIONESIVA_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.SITUACIONESIVA_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SITUACIONESIVA_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SITUACIONESIVA_UPDATE
(
@siv_rcd_codigo tngs_codigo_r,
@siv_des_descripcion tngs_descripcion,
@siv_cd1_discrimina tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..SituacionesIVA
      set siv_des_descripcion= @siv_des_descripcion,
          siv_cd1_discrimina= @siv_cd1_discrimina,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where siv_rcd_codigo = @siv_rcd_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SITUACIONESIVA_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@siv_rcd_codigo">Codigo</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.SITUACIONESIVA_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.SITUACIONESIVA_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SITUACIONESIVA_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SITUACIONESIVA_DELETE
(
@siv_rcd_codigo tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..SituacionesIVA
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where siv_rcd_codigo = @siv_rcd_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SITUACIONESIVA_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@siv_rcd_codigo">Codigo</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.SITUACIONESIVA_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.SITUACIONESIVA_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SITUACIONESIVA_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SITUACIONESIVA_RECALL
(
@siv_rcd_codigo tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..SituacionesIVA
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where siv_rcd_codigo = @siv_rcd_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SITUACIONESIVA_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@siv_rcd_codigo">Codigo</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.SITUACIONESIVA_DROP'

if exists (select * from sysobjects where id = object_id('dbo.SITUACIONESIVA_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SITUACIONESIVA_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SITUACIONESIVA_DROP
(
@siv_rcd_codigo tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..SituacionesIVA
    where siv_rcd_codigo = @siv_rcd_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SITUACIONESIVA_DROP to tngsmodulos

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

print 'Store Procedure: dbo.SITUACIONESIVA_PACK'

if exists (select * from sysobjects where id = object_id('dbo.SITUACIONESIVA_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SITUACIONESIVA_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SITUACIONESIVA_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Carm..SituacionesIVA
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SITUACIONESIVA_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: SituacionesIVA
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 04/01/2023 00:01
// Sistema     : Carm
// Tabla       : Supervisores
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

print 'Store Procedure: dbo.SUPERVISORES_UP'

if exists (select * from sysobjects where id = object_id('dbo.SUPERVISORES_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SUPERVISORES_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SUPERVISORES_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select sup_cd6_cod,
                sup_nom_apellido,
                sup_nom_nombre,
                sup_nom_usuario,
                ltrim(rtrim(sup_nom_apellido)) + ' ' + ltrim(rtrim(sup_nom_nombre)) as sup_ede_nya,
                sup_tel_tel,
                sup_tel_cel,
                TNGS_Carm..Supervisores.instante,
                TNGS_Carm..Supervisores.deleted,
                TNGS_Carm..Supervisores.usuario,
                TNGS_Carm..Supervisores.version
           from TNGS_Carm..Supervisores
          where deleted = 0
          order by sup_cd6_cod
      end
   else
      begin
         Select sup_cd6_cod,
                sup_nom_apellido,
                sup_nom_nombre,
                sup_nom_usuario,
                ltrim(rtrim(sup_nom_apellido)) + ' ' + ltrim(rtrim(sup_nom_nombre)) as sup_ede_nya,
                sup_tel_tel,
                sup_tel_cel,
                TNGS_Carm..Supervisores.instante,
                TNGS_Carm..Supervisores.deleted,
                TNGS_Carm..Supervisores.usuario,
                TNGS_Carm..Supervisores.version
           from TNGS_Carm..Supervisores
          order by sup_cd6_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SUPERVISORES_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@sup_cd6_cod">Código</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.SUPERVISORES_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.SUPERVISORES_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SUPERVISORES_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SUPERVISORES_CHKVERSION
(
@sup_cd6_cod tngs_codigo_6,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Carm..Supervisores
    where sup_cd6_cod = @sup_cd6_cod
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SUPERVISORES_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@sup_cd6_cod">Código</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.SUPERVISORES_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.SUPERVISORES_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SUPERVISORES_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SUPERVISORES_SEARCH
(
@sup_cd6_cod tngs_codigo_6,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select sup_cd6_cod,
                sup_nom_apellido,
                sup_nom_nombre,
                sup_nom_usuario,
                ltrim(rtrim(sup_nom_apellido)) + ' ' + ltrim(rtrim(sup_nom_nombre)) as sup_ede_nya,
                sup_tel_tel,
                sup_tel_cel,
                TNGS_Carm..Supervisores.instante,
                TNGS_Carm..Supervisores.deleted,
                TNGS_Carm..Supervisores.usuario,
                TNGS_Carm..Supervisores.version
           from TNGS_Carm..Supervisores
          where sup_cd6_cod = @sup_cd6_cod
            and deleted = 0
      end
   else
      begin
         Select sup_cd6_cod,
                sup_nom_apellido,
                sup_nom_nombre,
                sup_nom_usuario,
                ltrim(rtrim(sup_nom_apellido)) + ' ' + ltrim(rtrim(sup_nom_nombre)) as sup_ede_nya,
                sup_tel_tel,
                sup_tel_cel,
                TNGS_Carm..Supervisores.instante,
                TNGS_Carm..Supervisores.deleted,
                TNGS_Carm..Supervisores.usuario,
                TNGS_Carm..Supervisores.version
           from TNGS_Carm..Supervisores
          where sup_cd6_cod = @sup_cd6_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SUPERVISORES_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@sup_cd6_cod">Código</param>
--- <param name="@sup_nom_apellido">Apellido</param>
--- <param name="@sup_nom_nombre">Nombre</param>
--- <param name="@sup_nom_usuario">Usuario del Sistema</param>
--- <param name="@sup_tel_tel">Télefono</param>
--- <param name="@sup_tel_cel">Celular</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.SUPERVISORES_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.SUPERVISORES_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SUPERVISORES_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SUPERVISORES_INSERT
(
@sup_cd6_cod tngs_codigo_6,
@sup_nom_apellido tngs_nombre,
@sup_nom_nombre tngs_nombre,
@sup_nom_usuario tngs_nombre,
@sup_tel_tel tngs_telefono,
@sup_tel_cel tngs_telefono,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Carm..Supervisores
   values (
           @sup_cd6_cod,
           @sup_nom_apellido,
           @sup_nom_nombre,
           @sup_nom_usuario,
           @sup_tel_tel,
           @sup_tel_cel,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SUPERVISORES_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@sup_cd6_cod">Código</param>
--- <param name="@sup_nom_apellido">Apellido</param>
--- <param name="@sup_nom_nombre">Nombre</param>
--- <param name="@sup_nom_usuario">Usuario del Sistema</param>
--- <param name="@sup_tel_tel">Télefono</param>
--- <param name="@sup_tel_cel">Celular</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.SUPERVISORES_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.SUPERVISORES_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SUPERVISORES_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SUPERVISORES_UPDATE
(
@sup_cd6_cod tngs_codigo_6,
@sup_nom_apellido tngs_nombre,
@sup_nom_nombre tngs_nombre,
@sup_nom_usuario tngs_nombre,
@sup_tel_tel tngs_telefono,
@sup_tel_cel tngs_telefono,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Supervisores
      set sup_nom_apellido= @sup_nom_apellido,
          sup_nom_nombre= @sup_nom_nombre,
          sup_nom_usuario= @sup_nom_usuario,
          sup_tel_tel= @sup_tel_tel,
          sup_tel_cel= @sup_tel_cel,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where sup_cd6_cod = @sup_cd6_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SUPERVISORES_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@sup_cd6_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.SUPERVISORES_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.SUPERVISORES_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SUPERVISORES_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SUPERVISORES_DELETE
(
@sup_cd6_cod tngs_codigo_6,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Supervisores
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where sup_cd6_cod = @sup_cd6_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SUPERVISORES_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@sup_cd6_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.SUPERVISORES_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.SUPERVISORES_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SUPERVISORES_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SUPERVISORES_RECALL
(
@sup_cd6_cod tngs_codigo_6,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Supervisores
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where sup_cd6_cod = @sup_cd6_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SUPERVISORES_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@sup_cd6_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.SUPERVISORES_DROP'

if exists (select * from sysobjects where id = object_id('dbo.SUPERVISORES_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SUPERVISORES_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SUPERVISORES_DROP
(
@sup_cd6_cod tngs_codigo_6,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..Supervisores
    where sup_cd6_cod = @sup_cd6_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SUPERVISORES_DROP to tngsmodulos

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

print 'Store Procedure: dbo.SUPERVISORES_PACK'

if exists (select * from sysobjects where id = object_id('dbo.SUPERVISORES_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.SUPERVISORES_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.SUPERVISORES_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Carm..Supervisores
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.SUPERVISORES_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Supervisores
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 04/01/2023 00:01
// Sistema     : Carm
// Tabla       : Talonarios
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

print 'Store Procedure: dbo.TALONARIOS_UP'

if exists (select * from sysobjects where id = object_id('dbo.TALONARIOS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALONARIOS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALONARIOS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select tal_xcd_codigo,
                tal_des_descripcion,
                tal_cd1_tipo,
                tal_nro_valor,
                tal_fyh_referencia,
                tal_rob_detalle,
                TNGS_Carm..Talonarios.instante,
                TNGS_Carm..Talonarios.deleted,
                TNGS_Carm..Talonarios.usuario,
                TNGS_Carm..Talonarios.version
           from TNGS_Carm..Talonarios
          where deleted = 0
          order by tal_xcd_codigo
      end
   else
      begin
         Select tal_xcd_codigo,
                tal_des_descripcion,
                tal_cd1_tipo,
                tal_nro_valor,
                tal_fyh_referencia,
                tal_rob_detalle,
                TNGS_Carm..Talonarios.instante,
                TNGS_Carm..Talonarios.deleted,
                TNGS_Carm..Talonarios.usuario,
                TNGS_Carm..Talonarios.version
           from TNGS_Carm..Talonarios
          order by tal_xcd_codigo
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALONARIOS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@tal_xcd_codigo">Código</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALONARIOS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.TALONARIOS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALONARIOS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALONARIOS_CHKVERSION
(
@tal_xcd_codigo tngs_codigo_x,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Carm..Talonarios
    where tal_xcd_codigo = @tal_xcd_codigo
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALONARIOS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@tal_xcd_codigo">Código</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALONARIOS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.TALONARIOS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALONARIOS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALONARIOS_SEARCH
(
@tal_xcd_codigo tngs_codigo_x,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select tal_xcd_codigo,
                tal_des_descripcion,
                tal_cd1_tipo,
                tal_nro_valor,
                tal_fyh_referencia,
                tal_rob_detalle,
                TNGS_Carm..Talonarios.instante,
                TNGS_Carm..Talonarios.deleted,
                TNGS_Carm..Talonarios.usuario,
                TNGS_Carm..Talonarios.version
           from TNGS_Carm..Talonarios with (XLOCK)
          where tal_xcd_codigo = @tal_xcd_codigo
            and deleted = 0
      end
   else
      begin
         Select tal_xcd_codigo,
                tal_des_descripcion,
                tal_cd1_tipo,
                tal_nro_valor,
                tal_fyh_referencia,
                tal_rob_detalle,
                TNGS_Carm..Talonarios.instante,
                TNGS_Carm..Talonarios.deleted,
                TNGS_Carm..Talonarios.usuario,
                TNGS_Carm..Talonarios.version
           from TNGS_Carm..Talonarios with (XLOCK)
          where tal_xcd_codigo = @tal_xcd_codigo
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALONARIOS_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@tal_xcd_codigo">Código</param>
--- <param name="@tal_des_descripcion">Descripción</param>
--- <param name="@tal_cd1_tipo">Tipo</param>
--- <param name="@tal_nro_valor">Número</param>
--- <param name="@tal_fyh_referencia">Referencia</param>
--- <param name="@tal_rob_detalle">Detalle</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALONARIOS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.TALONARIOS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALONARIOS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALONARIOS_INSERT
(
@tal_xcd_codigo tngs_codigo_x,
@tal_des_descripcion tngs_descripcion,
@tal_cd1_tipo tngs_codigo_1,
@tal_nro_valor tngs_numero,
@tal_fyh_referencia tngs_fecyhor,
@tal_rob_detalle tngs_observaciones_r,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Carm..Talonarios
   values (
           @tal_xcd_codigo,
           @tal_des_descripcion,
           @tal_cd1_tipo,
           @tal_nro_valor,
           @tal_fyh_referencia,
           @tal_rob_detalle,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALONARIOS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@tal_xcd_codigo">Código</param>
--- <param name="@tal_des_descripcion">Descripción</param>
--- <param name="@tal_cd1_tipo">Tipo</param>
--- <param name="@tal_nro_valor">Número</param>
--- <param name="@tal_fyh_referencia">Referencia</param>
--- <param name="@tal_rob_detalle">Detalle</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALONARIOS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.TALONARIOS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALONARIOS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALONARIOS_UPDATE
(
@tal_xcd_codigo tngs_codigo_x,
@tal_des_descripcion tngs_descripcion,
@tal_cd1_tipo tngs_codigo_1,
@tal_nro_valor tngs_numero,
@tal_fyh_referencia tngs_fecyhor,
@tal_rob_detalle tngs_observaciones_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Talonarios
      set tal_des_descripcion= @tal_des_descripcion,
          tal_cd1_tipo= @tal_cd1_tipo,
          tal_nro_valor= @tal_nro_valor,
          tal_fyh_referencia= @tal_fyh_referencia,
          tal_rob_detalle= @tal_rob_detalle,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where tal_xcd_codigo = @tal_xcd_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALONARIOS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@tal_xcd_codigo">Código</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALONARIOS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.TALONARIOS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALONARIOS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALONARIOS_DELETE
(
@tal_xcd_codigo tngs_codigo_x,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Talonarios
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where tal_xcd_codigo = @tal_xcd_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALONARIOS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@tal_xcd_codigo">Código</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALONARIOS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.TALONARIOS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALONARIOS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALONARIOS_RECALL
(
@tal_xcd_codigo tngs_codigo_x,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Talonarios
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where tal_xcd_codigo = @tal_xcd_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALONARIOS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@tal_xcd_codigo">Código</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALONARIOS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.TALONARIOS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALONARIOS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALONARIOS_DROP
(
@tal_xcd_codigo tngs_codigo_x,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..Talonarios
    where tal_xcd_codigo = @tal_xcd_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALONARIOS_DROP to tngsmodulos

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

print 'Store Procedure: dbo.TALONARIOS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.TALONARIOS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALONARIOS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALONARIOS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Carm..Talonarios
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALONARIOS_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Talonarios
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 04/01/2023 00:01
// Sistema     : Carm
// Tabla       : TipoCont
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

print 'Store Procedure: dbo.TIPOCONT_UP'

if exists (select * from sysobjects where id = object_id('dbo.TIPOCONT_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOCONT_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOCONT_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select tcn_rcd_cod,
                tcn_des_des,
                tcn_cd1_modo,
                tcn_rcd_tcontratoavalon,
                TNGS_Carm..TipoCont.instante,
                TNGS_Carm..TipoCont.deleted,
                TNGS_Carm..TipoCont.usuario,
                TNGS_Carm..TipoCont.version
           from TNGS_Carm..TipoCont
          where deleted = 0
          order by tcn_rcd_cod
      end
   else
      begin
         Select tcn_rcd_cod,
                tcn_des_des,
                tcn_cd1_modo,
                tcn_rcd_tcontratoavalon,
                TNGS_Carm..TipoCont.instante,
                TNGS_Carm..TipoCont.deleted,
                TNGS_Carm..TipoCont.usuario,
                TNGS_Carm..TipoCont.version
           from TNGS_Carm..TipoCont
          order by tcn_rcd_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOCONT_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@tcn_rcd_cod">Código</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TIPOCONT_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.TIPOCONT_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOCONT_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOCONT_CHKVERSION
(
@tcn_rcd_cod tngs_codigo_r,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Carm..TipoCont
    where tcn_rcd_cod = @tcn_rcd_cod
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOCONT_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@tcn_rcd_cod">Código</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TIPOCONT_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.TIPOCONT_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOCONT_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOCONT_SEARCH
(
@tcn_rcd_cod tngs_codigo_r,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select tcn_rcd_cod,
                tcn_des_des,
                tcn_cd1_modo,
                tcn_rcd_tcontratoavalon,
                TNGS_Carm..TipoCont.instante,
                TNGS_Carm..TipoCont.deleted,
                TNGS_Carm..TipoCont.usuario,
                TNGS_Carm..TipoCont.version
           from TNGS_Carm..TipoCont
          where tcn_rcd_cod = @tcn_rcd_cod
            and deleted = 0
      end
   else
      begin
         Select tcn_rcd_cod,
                tcn_des_des,
                tcn_cd1_modo,
                tcn_rcd_tcontratoavalon,
                TNGS_Carm..TipoCont.instante,
                TNGS_Carm..TipoCont.deleted,
                TNGS_Carm..TipoCont.usuario,
                TNGS_Carm..TipoCont.version
           from TNGS_Carm..TipoCont
          where tcn_rcd_cod = @tcn_rcd_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOCONT_SEARCH to tngsmodulos

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

print 'Store Procedure: dbo.TIPOCONT_GETMAXKEY'

if exists (select * from sysobjects where id = object_id('dbo.TIPOCONT_GETMAXKEY'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOCONT_GETMAXKEY
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOCONT_GETMAXKEY
(
@dummy tngs_codigo_1
)
as
begin

   Select isnull(max(tcn_rcd_cod), '0') as tcn_rcd_cod
     from TNGS_Carm..TipoCont

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOCONT_GETMAXKEY to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@tcn_rcd_cod">Código</param>
--- <param name="@tcn_des_des">Descripción</param>
--- <param name="@tcn_cd1_modo">Modo Venta</param>
--- <param name="@tcn_rcd_tcontratoavalon">Tipo Contrato Avalon</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TIPOCONT_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.TIPOCONT_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOCONT_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOCONT_INSERT
(
@tcn_rcd_cod tngs_codigo_r,
@tcn_des_des tngs_descripcion,
@tcn_cd1_modo tngs_codigo_1,
@tcn_rcd_tcontratoavalon tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Carm..TipoCont
   values (
           @tcn_rcd_cod,
           @tcn_des_des,
           @tcn_cd1_modo,
           @tcn_rcd_tcontratoavalon,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOCONT_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@tcn_rcd_cod">Código</param>
--- <param name="@tcn_des_des">Descripción</param>
--- <param name="@tcn_cd1_modo">Modo Venta</param>
--- <param name="@tcn_rcd_tcontratoavalon">Tipo Contrato Avalon</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TIPOCONT_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.TIPOCONT_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOCONT_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOCONT_UPDATE
(
@tcn_rcd_cod tngs_codigo_r,
@tcn_des_des tngs_descripcion,
@tcn_cd1_modo tngs_codigo_1,
@tcn_rcd_tcontratoavalon tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..TipoCont
      set tcn_des_des= @tcn_des_des,
          tcn_cd1_modo= @tcn_cd1_modo,
          tcn_rcd_tcontratoavalon= @tcn_rcd_tcontratoavalon,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where tcn_rcd_cod = @tcn_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOCONT_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@tcn_rcd_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TIPOCONT_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.TIPOCONT_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOCONT_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOCONT_DELETE
(
@tcn_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..TipoCont
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where tcn_rcd_cod = @tcn_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOCONT_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@tcn_rcd_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TIPOCONT_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.TIPOCONT_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOCONT_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOCONT_RECALL
(
@tcn_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..TipoCont
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where tcn_rcd_cod = @tcn_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOCONT_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@tcn_rcd_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TIPOCONT_DROP'

if exists (select * from sysobjects where id = object_id('dbo.TIPOCONT_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOCONT_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOCONT_DROP
(
@tcn_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..TipoCont
    where tcn_rcd_cod = @tcn_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOCONT_DROP to tngsmodulos

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

print 'Store Procedure: dbo.TIPOCONT_PACK'

if exists (select * from sysobjects where id = object_id('dbo.TIPOCONT_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOCONT_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOCONT_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Carm..TipoCont
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOCONT_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: TipoCont
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 04/01/2023 00:01
// Sistema     : Carm
// Tabla       : TipoInst
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

print 'Store Procedure: dbo.TIPOINST_UP'

if exists (select * from sysobjects where id = object_id('dbo.TIPOINST_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOINST_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOINST_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select tin_cod_cod,
                tin_des_des,
                tin_rcd_codrubro,
                rbr_des_des as tin_des_rubro,
                tin_cd1_mayorista,
                TNGS_Carm..TipoInst.instante,
                TNGS_Carm..TipoInst.deleted,
                TNGS_Carm..TipoInst.usuario,
                TNGS_Carm..TipoInst.version
           from TNGS_Carm..TipoInst
                join TNGS_Carm..Rubros
                  on tin_rcd_codrubro = rbr_rcd_cod
          where TNGS_Carm..TipoInst.deleted = 0
          order by tin_cod_cod
      end
   else
      begin
         Select tin_cod_cod,
                tin_des_des,
                tin_rcd_codrubro,
                rbr_des_des as tin_des_rubro,
                tin_cd1_mayorista,
                TNGS_Carm..TipoInst.instante,
                TNGS_Carm..TipoInst.deleted,
                TNGS_Carm..TipoInst.usuario,
                TNGS_Carm..TipoInst.version
           from TNGS_Carm..TipoInst
                join TNGS_Carm..Rubros
                  on tin_rcd_codrubro = rbr_rcd_cod
          order by tin_cod_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOINST_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@tin_cod_cod">Código</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TIPOINST_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.TIPOINST_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOINST_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOINST_CHKVERSION
(
@tin_cod_cod tngs_codigo,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Carm..TipoInst
    where tin_cod_cod = @tin_cod_cod
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOINST_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@tin_cod_cod">Código</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TIPOINST_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.TIPOINST_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOINST_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOINST_SEARCH
(
@tin_cod_cod tngs_codigo,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select tin_cod_cod,
                tin_des_des,
                tin_rcd_codrubro,
                rbr_des_des as tin_des_rubro,
                tin_cd1_mayorista,
                TNGS_Carm..TipoInst.instante,
                TNGS_Carm..TipoInst.deleted,
                TNGS_Carm..TipoInst.usuario,
                TNGS_Carm..TipoInst.version
           from TNGS_Carm..TipoInst
                join TNGS_Carm..Rubros
                  on tin_rcd_codrubro = rbr_rcd_cod
          where tin_cod_cod = @tin_cod_cod
            and TNGS_Carm..TipoInst.deleted = 0
      end
   else
      begin
         Select tin_cod_cod,
                tin_des_des,
                tin_rcd_codrubro,
                rbr_des_des as tin_des_rubro,
                tin_cd1_mayorista,
                TNGS_Carm..TipoInst.instante,
                TNGS_Carm..TipoInst.deleted,
                TNGS_Carm..TipoInst.usuario,
                TNGS_Carm..TipoInst.version
           from TNGS_Carm..TipoInst
                join TNGS_Carm..Rubros
                  on tin_rcd_codrubro = rbr_rcd_cod
          where tin_cod_cod = @tin_cod_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOINST_SEARCH to tngsmodulos

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

print 'Store Procedure: dbo.TIPOINST_GETMAXKEY'

if exists (select * from sysobjects where id = object_id('dbo.TIPOINST_GETMAXKEY'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOINST_GETMAXKEY
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOINST_GETMAXKEY
(
@dummy tngs_codigo_1
)
as
begin

   Select isnull(max(tin_cod_cod), '0') as tin_cod_cod
     from TNGS_Carm..TipoInst

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOINST_GETMAXKEY to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@tin_cod_cod">Código</param>
--- <param name="@tin_des_des">Descripción</param>
--- <param name="@tin_rcd_codrubro">Rubro</param>
--- <param name="@tin_cd1_mayorista">Mayorista</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TIPOINST_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.TIPOINST_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOINST_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOINST_INSERT
(
@tin_cod_cod tngs_codigo,
@tin_des_des tngs_descripcion,
@tin_rcd_codrubro tngs_codigo_r,
@tin_cd1_mayorista tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Carm..TipoInst
   values (
           @tin_cod_cod,
           @tin_des_des,
           @tin_rcd_codrubro,
           @tin_cd1_mayorista,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOINST_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@tin_cod_cod">Código</param>
--- <param name="@tin_des_des">Descripción</param>
--- <param name="@tin_rcd_codrubro">Rubro</param>
--- <param name="@tin_cd1_mayorista">Mayorista</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TIPOINST_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.TIPOINST_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOINST_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOINST_UPDATE
(
@tin_cod_cod tngs_codigo,
@tin_des_des tngs_descripcion,
@tin_rcd_codrubro tngs_codigo_r,
@tin_cd1_mayorista tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..TipoInst
      set tin_des_des= @tin_des_des,
          tin_rcd_codrubro= @tin_rcd_codrubro,
          tin_cd1_mayorista= @tin_cd1_mayorista,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where tin_cod_cod = @tin_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOINST_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@tin_cod_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TIPOINST_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.TIPOINST_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOINST_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOINST_DELETE
(
@tin_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..TipoInst
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where tin_cod_cod = @tin_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOINST_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@tin_cod_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TIPOINST_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.TIPOINST_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOINST_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOINST_RECALL
(
@tin_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..TipoInst
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where tin_cod_cod = @tin_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOINST_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@tin_cod_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TIPOINST_DROP'

if exists (select * from sysobjects where id = object_id('dbo.TIPOINST_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOINST_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOINST_DROP
(
@tin_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..TipoInst
    where tin_cod_cod = @tin_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOINST_DROP to tngsmodulos

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

print 'Store Procedure: dbo.TIPOINST_PACK'

if exists (select * from sysobjects where id = object_id('dbo.TIPOINST_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOINST_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOINST_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Carm..TipoInst
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOINST_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: GetTiposInstRubro
--- </summary>
--- <param name="@codrubro">Código de Rubro</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TIPOINST_GETTIPOSINSTRUBRO'

if exists (select * from sysobjects where id = object_id('dbo.TIPOINST_GETTIPOSINSTRUBRO'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOINST_GETTIPOSINSTRUBRO
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOINST_GETTIPOSINSTRUBRO
(
@codrubro tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   select 
         tin_cod_cod, 
         tin_des_des 
   from 
         TNGS_Carm..TipoInst 
   where 
         tin_rcd_codrubro = @codrubro 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOINST_GETTIPOSINSTRUBRO to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: TipoInst
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 04/01/2023 00:01
// Sistema     : Carm
// Tabla       : TipoVend
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

print 'Store Procedure: dbo.TIPOVEND_UP'

if exists (select * from sysobjects where id = object_id('dbo.TIPOVEND_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOVEND_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOVEND_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select tvn_rcd_cod,
                tvn_des_des,
                tvn_cd1_vemayor,
                TNGS_Carm..TipoVend.instante,
                TNGS_Carm..TipoVend.deleted,
                TNGS_Carm..TipoVend.usuario,
                TNGS_Carm..TipoVend.version
           from TNGS_Carm..TipoVend
          where deleted = 0
          order by tvn_rcd_cod
      end
   else
      begin
         Select tvn_rcd_cod,
                tvn_des_des,
                tvn_cd1_vemayor,
                TNGS_Carm..TipoVend.instante,
                TNGS_Carm..TipoVend.deleted,
                TNGS_Carm..TipoVend.usuario,
                TNGS_Carm..TipoVend.version
           from TNGS_Carm..TipoVend
          order by tvn_rcd_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOVEND_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@tvn_rcd_cod">Codigo</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TIPOVEND_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.TIPOVEND_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOVEND_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOVEND_CHKVERSION
(
@tvn_rcd_cod tngs_codigo_r,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Carm..TipoVend
    where tvn_rcd_cod = @tvn_rcd_cod
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOVEND_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@tvn_rcd_cod">Codigo</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TIPOVEND_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.TIPOVEND_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOVEND_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOVEND_SEARCH
(
@tvn_rcd_cod tngs_codigo_r,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select tvn_rcd_cod,
                tvn_des_des,
                tvn_cd1_vemayor,
                TNGS_Carm..TipoVend.instante,
                TNGS_Carm..TipoVend.deleted,
                TNGS_Carm..TipoVend.usuario,
                TNGS_Carm..TipoVend.version
           from TNGS_Carm..TipoVend
          where tvn_rcd_cod = @tvn_rcd_cod
            and deleted = 0
      end
   else
      begin
         Select tvn_rcd_cod,
                tvn_des_des,
                tvn_cd1_vemayor,
                TNGS_Carm..TipoVend.instante,
                TNGS_Carm..TipoVend.deleted,
                TNGS_Carm..TipoVend.usuario,
                TNGS_Carm..TipoVend.version
           from TNGS_Carm..TipoVend
          where tvn_rcd_cod = @tvn_rcd_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOVEND_SEARCH to tngsmodulos

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

print 'Store Procedure: dbo.TIPOVEND_GETMAXKEY'

if exists (select * from sysobjects where id = object_id('dbo.TIPOVEND_GETMAXKEY'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOVEND_GETMAXKEY
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOVEND_GETMAXKEY
(
@dummy tngs_codigo_1
)
as
begin

   Select isnull(max(tvn_rcd_cod), '0') as tvn_rcd_cod
     from TNGS_Carm..TipoVend

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOVEND_GETMAXKEY to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@tvn_rcd_cod">Codigo</param>
--- <param name="@tvn_des_des">Descripcion</param>
--- <param name="@tvn_cd1_vemayor">Ve Mayoristas</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TIPOVEND_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.TIPOVEND_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOVEND_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOVEND_INSERT
(
@tvn_rcd_cod tngs_codigo_r,
@tvn_des_des tngs_descripcion,
@tvn_cd1_vemayor tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Carm..TipoVend
   values (
           @tvn_rcd_cod,
           @tvn_des_des,
           @tvn_cd1_vemayor,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOVEND_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@tvn_rcd_cod">Codigo</param>
--- <param name="@tvn_des_des">Descripcion</param>
--- <param name="@tvn_cd1_vemayor">Ve Mayoristas</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TIPOVEND_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.TIPOVEND_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOVEND_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOVEND_UPDATE
(
@tvn_rcd_cod tngs_codigo_r,
@tvn_des_des tngs_descripcion,
@tvn_cd1_vemayor tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..TipoVend
      set tvn_des_des= @tvn_des_des,
          tvn_cd1_vemayor= @tvn_cd1_vemayor,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where tvn_rcd_cod = @tvn_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOVEND_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@tvn_rcd_cod">Codigo</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TIPOVEND_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.TIPOVEND_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOVEND_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOVEND_DELETE
(
@tvn_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..TipoVend
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where tvn_rcd_cod = @tvn_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOVEND_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@tvn_rcd_cod">Codigo</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TIPOVEND_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.TIPOVEND_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOVEND_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOVEND_RECALL
(
@tvn_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..TipoVend
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where tvn_rcd_cod = @tvn_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOVEND_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@tvn_rcd_cod">Codigo</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TIPOVEND_DROP'

if exists (select * from sysobjects where id = object_id('dbo.TIPOVEND_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOVEND_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOVEND_DROP
(
@tvn_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..TipoVend
    where tvn_rcd_cod = @tvn_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOVEND_DROP to tngsmodulos

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

print 'Store Procedure: dbo.TIPOVEND_PACK'

if exists (select * from sysobjects where id = object_id('dbo.TIPOVEND_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TIPOVEND_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TIPOVEND_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Carm..TipoVend
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TIPOVEND_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: TipoVend
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 04/01/2023 00:01
// Sistema     : Carm
// Tabla       : Vendedores
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
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 04/01/2023 00:01
// Sistema     : Carm
// Tabla       : Zonas
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

print 'Store Procedure: dbo.ZONAS_UP'

if exists (select * from sysobjects where id = object_id('dbo.ZONAS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ZONAS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ZONAS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select zns_rcd_cod,
                zns_des_nombre,
                zns_txt_geoloc,
                TNGS_Carm..Zonas.instante,
                TNGS_Carm..Zonas.deleted,
                TNGS_Carm..Zonas.usuario,
                TNGS_Carm..Zonas.version
           from TNGS_Carm..Zonas
          where deleted = 0
          order by zns_rcd_cod
      end
   else
      begin
         Select zns_rcd_cod,
                zns_des_nombre,
                zns_txt_geoloc,
                TNGS_Carm..Zonas.instante,
                TNGS_Carm..Zonas.deleted,
                TNGS_Carm..Zonas.usuario,
                TNGS_Carm..Zonas.version
           from TNGS_Carm..Zonas
          order by zns_rcd_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ZONAS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@zns_rcd_cod">Código</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ZONAS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.ZONAS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ZONAS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ZONAS_CHKVERSION
(
@zns_rcd_cod tngs_codigo_r,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Carm..Zonas
    where zns_rcd_cod = @zns_rcd_cod
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ZONAS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@zns_rcd_cod">Código</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ZONAS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.ZONAS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ZONAS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ZONAS_SEARCH
(
@zns_rcd_cod tngs_codigo_r,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select zns_rcd_cod,
                zns_des_nombre,
                zns_txt_geoloc,
                TNGS_Carm..Zonas.instante,
                TNGS_Carm..Zonas.deleted,
                TNGS_Carm..Zonas.usuario,
                TNGS_Carm..Zonas.version
           from TNGS_Carm..Zonas
          where zns_rcd_cod = @zns_rcd_cod
            and deleted = 0
      end
   else
      begin
         Select zns_rcd_cod,
                zns_des_nombre,
                zns_txt_geoloc,
                TNGS_Carm..Zonas.instante,
                TNGS_Carm..Zonas.deleted,
                TNGS_Carm..Zonas.usuario,
                TNGS_Carm..Zonas.version
           from TNGS_Carm..Zonas
          where zns_rcd_cod = @zns_rcd_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ZONAS_SEARCH to tngsmodulos

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

print 'Store Procedure: dbo.ZONAS_GETMAXKEY'

if exists (select * from sysobjects where id = object_id('dbo.ZONAS_GETMAXKEY'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ZONAS_GETMAXKEY
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ZONAS_GETMAXKEY
(
@dummy tngs_codigo_1
)
as
begin

   Select isnull(max(zns_rcd_cod), '0') as zns_rcd_cod
     from TNGS_Carm..Zonas

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ZONAS_GETMAXKEY to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@zns_rcd_cod">Código</param>
--- <param name="@zns_des_nombre">Nombre de la zona</param>
--- <param name="@zns_txt_geoloc">Geolocalización</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ZONAS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.ZONAS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ZONAS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ZONAS_INSERT
(
@zns_rcd_cod tngs_codigo_r,
@zns_des_nombre tngs_descripcion,
@zns_txt_geoloc tngs_texto,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Carm..Zonas
   values (
           @zns_rcd_cod,
           @zns_des_nombre,
           @zns_txt_geoloc,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ZONAS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@zns_rcd_cod">Código</param>
--- <param name="@zns_des_nombre">Nombre de la zona</param>
--- <param name="@zns_txt_geoloc">Geolocalización</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ZONAS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.ZONAS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ZONAS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ZONAS_UPDATE
(
@zns_rcd_cod tngs_codigo_r,
@zns_des_nombre tngs_descripcion,
@zns_txt_geoloc tngs_texto,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Zonas
      set zns_des_nombre= @zns_des_nombre,
          zns_txt_geoloc= @zns_txt_geoloc,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where zns_rcd_cod = @zns_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ZONAS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@zns_rcd_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ZONAS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.ZONAS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ZONAS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ZONAS_DELETE
(
@zns_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Zonas
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where zns_rcd_cod = @zns_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ZONAS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@zns_rcd_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ZONAS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.ZONAS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ZONAS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ZONAS_RECALL
(
@zns_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Zonas
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where zns_rcd_cod = @zns_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ZONAS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@zns_rcd_cod">Código</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ZONAS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.ZONAS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ZONAS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ZONAS_DROP
(
@zns_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..Zonas
    where zns_rcd_cod = @zns_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ZONAS_DROP to tngsmodulos

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

print 'Store Procedure: dbo.ZONAS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.ZONAS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ZONAS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ZONAS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Carm..Zonas
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ZONAS_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Zonas
//--------------------------------------------------------------------------*/
