/*----------------------------------------------------------------------------
//                         TNG Software Fcts Generator
//----------------------------------------------------------------------------
// Fecha       : 01/12/2020 21:33
// Sistema     : Carm
// Tabla       : Clientes
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
