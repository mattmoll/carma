/*---------------------------------------------------------------------------
//                   TNG Software (Scripts iniciales de la Base)
//---------------------------------------------------------------------------
// Fecha              : 25/07/2020 18:48
// Base de Datos      : TNGS_Carm
// Objetivo           : Creación de los usuarios de la base
//----------------------------------------------------------------------------
// © 1999-2020 by TNG Software                                      Gndr 5.20
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
// Fecha              : 25/07/2020 18:48
// Base de Datos      : TNGS_Carm
// Objetivo           : Creación de los tipos de datos
//----------------------------------------------------------------------------
// © 1999-2020 by TNG Software                                      Gndr 5.20
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
// Fecha              : 25/07/2020 18:48
// Base de Datos      : TNGS_Carm
// Objetivo           : Creación de las funciones básicas
//----------------------------------------------------------------------------
// © 1999-2020 by TNG Software                                      Gndr 5.20
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
