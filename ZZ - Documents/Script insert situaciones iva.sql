USE [TNGS_Carm]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO

insert into SituacionesIva values('CF', 'CONSUMIDOR FINAL', 'N', '1-1-2020', 0, 'Migracion', 0)
insert into SituacionesIva values('EX', 'EXENTO ', 'N', '1-1-2020', 0, 'Migracion', 0)
insert into SituacionesIva values('MT', 'MONOTRIBUTISTA', 'N', '1-1-2020', 0, 'Migracion', 0)
insert into SituacionesIva values('RI', 'RESPONSABLE INSCRIPTO', 'N', '1-1-2020', 0, 'Migracion', 0)

select * from SituacionesIva