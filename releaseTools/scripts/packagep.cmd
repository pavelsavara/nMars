@echo off
call %~dp0\ver.cmd

mkdir pMarsBinary.%PVER%.win32
copy ..\nMars\pMars\Dll\pMarsDll.h pMarsBinary.%PVER%.win32
copy ..\nMars\Bin\Release\pMars.dll pMarsBinary.%PVER%.win32
copy ..\nMars\Bin\Release\SDL.dll pMarsBinary.%PVER%.win32
copy ..\nMars\Bin\Release\pMars.exe pMarsBinary.%PVER%.win32
copy ..\nMars\Bin\Release\pMars-s.exe pMarsBinary.%PVER%.win32
copy ..\nMars\Bin\Release\pMars-SDL.exe pMarsBinary.%PVER%.win32
zip -r -9 pMars.%PVER%.win32.zip pMarsBinary.%PVER%.win32