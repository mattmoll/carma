/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 05/02/2021 12:23
// Base de Datos      : TNGS_Carm
// Tabla              : Planes
//----------------------------------------------------------------------------
// � 1999-2021 by TNG Software                                      Gndr 5.20
//---------------------------------------------------------------------------*/

/* ***************************************************************************
/  Atencion!!!
/     Este archivo fue generado por un programa en forma autom�tica. Cualquier
/     modificaci�n que se realize sobre �l se perder� en la pr�xima
/     regeneraci�n.
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
