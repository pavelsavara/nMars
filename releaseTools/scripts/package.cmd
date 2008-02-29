@echo off
call %~dp0\ver.cmd

mkdir %VER%%APPENDBUILD%
mkdir %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsConsole
copy ..\%nDir%\ReadMe.txt %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsConsole
copy ..\%nDir%\Changes.txt %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsConsole
copy ..\%nDir%\License.txt %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsConsole
copy ..\%nDir%\Bin\Release\nMars.RedCode.dll %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsConsole
copy ..\%nDir%\Bin\Release\nMars.Parser.dll %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsConsole
copy ..\%nDir%\Bin\Release\nMars.Engine.dll %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsConsole
copy ..\%nDir%\Bin\Release\nMars.Debugger.dll %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsConsole
copy ..\%nDir%\Bin\Release\nMars.exe %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsConsole
copy ..\%nDir%\Bin\Release\nMars.exe.config %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsConsole

mkdir %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsIDE
copy ..\%nDir%\ReadMe.txt %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsIDE
copy ..\%nDir%\Changes.txt %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsIDE
copy ..\%nDir%\License.txt %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsIDE
copy ..\%nDir%\Bin\Release\nMars.RedCode.dll %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsIDE
copy ..\%nDir%\Bin\Release\nMars.Parser.dll %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsIDE
copy ..\%nDir%\Bin\Release\nMars.Engine.dll %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsIDE
copy ..\%nDir%\Bin\Release\nMars.Graphics.dll %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsIDE
copy ..\%nDir%\Bin\Release\nMars.Debugger.dll %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsIDE
copy ..\%nDir%\Bin\Release\nMars.exe %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsIDE
copy ..\%nDir%\Bin\Release\nMars.IDE.exe %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsIDE
copy ..\%nDir%\Bin\Release\nMars.exe.config %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsIDE
copy ..\%nDir%\Bin\Release\nMars.IDE.exe.config %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsIDE

mkdir %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsFull
copy ..\%nDir%\ReadMe.txt %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsFull
copy ..\%nDir%\Changes.txt %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsFull
copy ..\%nDir%\License.txt %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsFull
copy ..\%nDir%\Bin\Release\nMars.RedCode.dll %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsFull
copy ..\%nDir%\Bin\Release\nMars.Parser.dll %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsFull
copy ..\%nDir%\Bin\Release\nMars.Engine.dll %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsFull
copy ..\%nDir%\Bin\Release\nMars.Graphics.dll %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsFull
copy ..\%nDir%\Bin\Release\nMars.Debugger.dll %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsFull
copy ..\%nDir%\Bin\Release\nMars.exe %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsFull
copy ..\%nDir%\Bin\Release\nMars.IDE.exe %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsFull
copy ..\%nDir%\Bin\Release\nMars.exe.config %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsFull
copy ..\%nDir%\Bin\Release\nMars.IDE.exe.config %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsFull
copy ..\%nDir%\Bin\Release\nMars.ShellPy.dll %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsFull
copy ..\%nDir%\Bin\Release\IronPython.dll %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsFull
copy ..\%nDir%\Bin\Release\IronMath.dll %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsFull


mkdir %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsShellPy
copy ..\%nDir%\Bin\Release\nMars.ShellPy.dll %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsShellPy
copy ..\%nDir%\Bin\Release\IronPython.dll %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsShellPy
copy ..\%nDir%\Bin\Release\IronMath.dll %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsShellPy

mkdir %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsTest
copy ..\%nDir%\Bin\Release\nMars.Test.exe %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsTest
copy ..\%nDir%\Bin\Release\pMars.dll %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsTest
copy ..\%nDir%\Bin\Release\pMars.DllWrapper.dll %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsTest

cd %VER%%APPENDBUILD%
zip -r -9 nMarsConsole.%VER%%APPENDBUILD%.bin.zip %VER%%APPENDBUILD%.nMarsConsole
zip -r -9 nMarsIDE.%VER%%APPENDBUILD%.zip %VER%%APPENDBUILD%.nMarsIDE
zip -r -9 nMarsFull.%VER%%APPENDBUILD%.zip %VER%%APPENDBUILD%.nMarsFull
zip -r -9 nMarsShellPy.%VER%%APPENDBUILD%.bin.zip %VER%%APPENDBUILD%.nMarsShellPy
zip -r -9 nMarsTest.%VER%%APPENDBUILD%.win.zip %VER%%APPENDBUILD%.nMarsTest
cd ..

copy ..\%nDir%\Bin\Release\nMars.msi %VER%%APPENDBUILD%\nMarsFull.%VER%%APPENDBUILD%.win.msi
