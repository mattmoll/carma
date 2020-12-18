/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Indices)                    
//----------------------------------------------------------------------------
// Fecha              : 16/12/2020 09:59
// Base de Datos      : TNGS_Carm
// Tabla              : Clientes
//----------------------------------------------------------------------------
// © 1999-2020 by TNG Software                                      Gndr 5.20
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
