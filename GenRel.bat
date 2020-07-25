@echo off

if exist "XX - Release" goto NoCreate

md "XX - Release"
md "XX - Release\Hlp"
md "XX - Release\Img"
md "XX - Release\Plg"
md "XX - Release\Prg"

:NoCreate

rem **
rem ** Copiamos los elementos del Help
rem **
copy Hlp\*.*                                                                       "XX - Release\Hlp"
copy Hlp\Img\*.*                                                                   "XX - Release\Hlp\Img"

rem **
rem ** Copiamos las Imágenes
rem **
copy Img\*.jpg                                                                     "XX - Release\Img"

rem **
rem ** Copiamos los elementos TNGS
rem **
copy "T:\Ambiente0520\DNet0520\Release_Uil\Bohman.MonthCalendar.520.dll"         "XX - Release\Prg"
copy "T:\Ambiente0520\DNet0520\Release_Uil\MikeHankey.XPControlLib.520.dll"      "XX - Release\Prg"
copy "T:\Ambiente0520\DNet0520\Release_Uil\MS.TabStripControlLibrary.520.dll"    "XX - Release\Prg"
copy "T:\Ambiente0520\DNet0520\Release_Uil\netchartdir.dll"                      "XX - Release\Prg"
copy "T:\Ambiente0520\DNet0520\Release_Uil\PS.TaskDialog.520.dll"                "XX - Release\Prg"
copy "T:\Ambiente0520\DNet0520\Release_Uil\WeifenLuo.WinFormsUI.Docking.520.dll" "XX - Release\Prg"
REM copy "T:\Ambiente0520\DNet0520\Release_Uil\lame_enc.dll"                         "XX - Release\Prg"

copy "T:\Ambiente0520\DNet0520\Release_Uil\TNGS.NetApp.520.dll"                  "XX - Release\Prg"
copy "T:\Ambiente0520\DNet0520\Release_Uil\TNGS.NetAppSupport.520.dll"           "XX - Release\Prg"
copy "T:\Ambiente0520\DNet0520\Release_Uil\TNGS.NetAppBll.520.dll"               "XX - Release\Prg"
copy "T:\Ambiente0520\DNet0520\Release_Uil\TNGS.NetControls.520.dll"             "XX - Release\Prg"
copy "T:\Ambiente0520\DNet0520\Release_Uil\TNGS.NetIPlugin.520.dll"              "XX - Release\Prg"
copy "T:\Ambiente0520\DNet0520\Release_Uil\TNGS.NetOffice.520.dll"               "XX - Release\Prg"
copy "T:\Ambiente0520\DNet0520\Release_Uil\TNGS.NetRoutines.520.dll"             "XX - Release\Prg"
copy "T:\Ambiente0520\DNet0520\Release_Uil\TNGS.NetSocket.520.dll"               "XX - Release\Prg"
copy "T:\Sima0200\ExternalLibraries\Bunifu_UI_v1.52.dll"                         "XX - Release\Prg"

rem **
rem ** Copiamos los elementos del Proyecto: Sima
rem **
REM copy Pin\Def\bin\Release\Avln.PlgDef.dll                                           "XX - Release\Prg"
REM copy Pin\<TODO>\bin\Release\Avln.<TODO>.Plugin.dll                                         "XX - Release\Plg"

copy Dal\bin\Release\Sima.Dal.dll                                                  "XX - Release\Prg"
copy Bel\bin\Release\Sima.Bel.dll                                                  "XX - Release\Prg"
copy Bll\bin\Release\Sima.Bll.dll                                                  "XX - Release\Prg"
copy Shr\bin\Release\Sima.Shr.dll                                                  "XX - Release\Prg"

copy Prg\Ar\bin\Release\Sima.Ar.exe                                                "XX - Release\Prg"
copy Prg\Ct\bin\Release\Sima.Ct.exe                                                "XX - Release\Prg"
copy Prg\Re\bin\Release\Sima.Re.exe                                                "XX - Release\Prg"
copy Prg\Rp\bin\Release\Sima.Rp.exe                                                "XX - Release\Prg"
copy Prg\Tg\bin\Release\Sima.Tg.exe                                                "XX - Release\Prg"

REM copy Prg\<TODO>\bin\release\Avln.<TODO>.exe                                                "XX - Release\Prg"


REM echo .
REM echo Generando EUse
REM echo .
REM cd "XX - Release\EUse"
REM T:\Ambiente0520\@NetExternalTools\ilmerge /internalize:Excludes.txt ..\Prg\Avln.Shr.dll ..\Prg\Avln.Bel.dll ..\Prg\Avln.Bll.dll ..\Prg\Avln.Dal.dll ..\Prg\Bohman.MonthCalendar.520.dll ..\Prg\MikeHankey.XPControlLib.520.dll ..\Prg\MS.TabStripControlLibrary.520.dll ..\Prg\netchartdir.dll ..\Prg\WeifenLuo.WinFormsUI.Docking.520.dll ..\Prg\TNGS.NetAppBll.520.dll ..\Prg\TNGS.NetControls.520.dll ..\Prg\TNGS.NetOffice.520.dll ..\Prg\TNGS.NetRoutines.520.dll ..\Prg\TNGS.NetSocket.520.dll /out:Avln.Shr.EUse.dll
REM cd ..
REM cd ..

pause

