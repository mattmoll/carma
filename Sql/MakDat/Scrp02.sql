/*---------------------------------------------------------------------------
//                   TNG Software (Scripts iniciales de la Base)
//---------------------------------------------------------------------------
// Fecha              : 03/12/2020 22:16
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
