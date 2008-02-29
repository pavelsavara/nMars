@echo off
call %~dp0\ver.cmd
rem "C:\Program Files\Microsoft Visual Studio 8\Common7\IDE\devenv.exe" %~dp0\..\..\%nDir%\nMars.sln /Rebuild Release
rem "C:\Program Files\Microsoft Visual Studio 8\Common7\IDE\devenv.exe" %~dp0\..\..\%nDir%\pMars\pMars.sln /Rebuild Releas
"c:\Program Files\Microsoft Visual Studio 9.0\Common7\IDE\devenv.exe" %~dp0\..\..\%nDir%\nMars.sln /Rebuild Release
"c:\Program Files\Microsoft Visual Studio 9.0\Common7\IDE\devenv.exe" %~dp0\..\..\%nDir%\pMars\pMars.sln /Rebuild Releas
