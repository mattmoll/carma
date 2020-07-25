/*----------------------------------------------------------------------------
//                         TNG Software Fcts Generator
//----------------------------------------------------------------------------
// Fecha       : 25/07/2020 18:14
// Sistema     : Carm
// Tabla       : CliEntrevistas
//----------------------------------------------------------------------------
// © 1999-2020 by TNG Software                                      Gndr 5.20
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
     from TNGS_Sima..CliEntrevistas 
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
     from TNGS_Sima..CliEntrevistas 
    
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
