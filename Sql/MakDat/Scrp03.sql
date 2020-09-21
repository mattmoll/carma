/*---------------------------------------------------------------------------
//                   TNG Software (Scripts iniciales de la Base)
//---------------------------------------------------------------------------
// Fecha              : 20/09/2020 20:55
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
