/*---------------------------------------------------------------------------
//                   TNG Software (Scripts iniciales de la Base)
//---------------------------------------------------------------------------
// Fecha              : 15/07/2013 01:42
// Base de Datos      : TNGS_Sima
// Objetivo           : Creación de de la base
//----------------------------------------------------------------------------
// © 1999-2013 by TNG Software                                      Gndr 5.00
//---------------------------------------------------------------------------*/

/* ***************************************************************************
/  Atencion!!!
/     Este archivo fue generado por un programa en forma automática. Cualquier
/     modificación que se realize sobre él se perderá en la próxima
/     regeneración.
/  **************************************************************************/

/*---------------------------*/
/* Selecciono la base master */
/*---------------------------*/

use master
go

/*-------------------------------*/
/* Defino el path                */
/*-------------------------------*/

declare @path char(250)
select @path= 'XXXXX'

Error
	  Debe completar el path donde se ubicarán las tablas
	  OJO!!!!!  NO debe terminar en \
	  Ejemplo:  'D:\SQLData'

	  Debe completar tambien el tamaño de los archivos inciales

/*--------------------------------------------------------------------------*/
/* Creacion de las base de datos                                            */
/*--------------------------------------------------------------------------*/

declare @create char(8000)
select @create= 'create database TNGS_Sima ' +
                'on primary ' +
                '( name= TNGS_Sima, ' +
                '  filename= ''' + ltrim(rtrim(@path)) + '\TNGS_Sima.mdf' + ''', ' +
                '  size= XXXXMB, ' +
                '  filegrowth= 10% ) ' +
                'log on ' +
                '( name= TNGS_Sima_log, ' +
                '  filename= ''' + ltrim(rtrim(@path)) + '\TNGS_Sima.ldf' + ''', ' +
                '  size= XXXMB, ' +
                '  filegrowth= 2% ) ;'
execute (@create)

alter database TNGS_Sima
set recovery simple;
go

/*--------------------------------------------------------------------------*/
/* Fin del programa: Scrp02.sql                                             */
/*--------------------------------------------------------------------------*/
