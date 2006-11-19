@echo off
call %~dp0\ver.cmd
"C:\Program Files\Microsoft Visual Studio 8\Common7\IDE\devenv.exe" %~dp0\..\..\nMars\nMars.sln /Rebuild Release
"C:\Program Files\Microsoft Visual Studio 8\Common7\IDE\devenv.exe" %~dp0\..\..\nMars\pMars\pMars.sln /Rebuild Release