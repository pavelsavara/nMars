@echo off
call %~dp0\ver.cmd

svn export https://svn.sourceforge.net/svnroot/nmars/trunk nMarsSources.%VER%
zip -r -9 nMars.%VER%.src.zip nMarsSources.%VER%

mkdir nMarsBinary.%VER%
copy ..\nMars\ReadMe.txt nMarsBinary.%VER%
copy ..\nMars\Changes.txt nMarsBinary.%VER%
copy ..\nMars\Usage.txt nMarsBinary.%VER%
copy ..\nMars\Bin\Release\nMars.RedCode.dll nMarsBinary.%VER%
copy ..\nMars\Bin\Release\nMars.Parser.exe nMarsBinary.%VER%
copy ..\nMars\Bin\Release\nMars.Engine.exe nMarsBinary.%VER%
copy ..\nMars\Bin\Release\pMars.DllWrapper.exe nMarsBinary.%VER%
zip -r -9 nMars.%VER%.bin.zip nMarsBinary.%VER%

mkdir npMarsBinary.%VER%.win32
copy ..\nMars\ReadMe.txt npMarsBinary.%VER%.win32
copy ..\nMars\Changes.txt npMarsBinary.%VER%.win32
copy ..\nMars\Usage.txt npMarsBinary.%VER%.win32
copy ..\nMars\Bin\Release\pMars.dll npMarsBinary.%VER%.win32
copy ..\nMars\Bin\Release\SDL.dll npMarsBinary.%VER%.win32
copy ..\nMars\Bin\Release\pMars.exe npMarsBinary.%VER%.win32
copy ..\nMars\Bin\Release\pMarsSDL.exe npMarsBinary.%VER%.win32
zip -r -9 npMars.%VER%.win32.zip npMarsBinary.%VER%.win32