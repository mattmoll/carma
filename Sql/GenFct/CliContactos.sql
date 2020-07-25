/*----------------------------------------------------------------------------
//                         TNG Software Fcts Generator
//----------------------------------------------------------------------------
// Fecha       : 25/07/2020 18:14
// Sistema     : Carm
// Tabla       : CliContactos
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
     from TNGS_Sima..CliContactos 
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
