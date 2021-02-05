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
