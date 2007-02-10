@echo off
call %~dp0\ver.cmd

mkdir %VER%%APPENDBUILD%
mkdir %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsConsole
copy ..\nMars\ReadMe.txt %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsConsole
copy ..\nMars\Changes.txt %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsConsole
copy ..\nMars\License.txt %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsConsole
copy ..\nMars\Bin\Release\nMars.RedCode.dll %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsConsole
copy ..\nMars\Bin\Release\nMars.Parser.dll %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsConsole
copy ..\nMars\Bin\Release\nMars.Engine.dll %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsConsole
copy ..\nMars\Bin\Release\nMars.Debugger.dll %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsConsole
copy ..\nMars\Bin\Release\nMars.exe %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsConsole
copy ..\nMars\Bin\Release\nMars.exe.config %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsConsole

mkdir %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsIDE
copy ..\nMars\ReadMe.txt %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsIDE
copy ..\nMars\Changes.txt %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsIDE
copy ..\nMars\Packages.txt %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsIDE
copy ..\nMars\License.txt %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsIDE
copy ..\nMars\Bin\Release\nMars.RedCode.dll %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsIDE
copy ..\nMars\Bin\Release\nMars.Parser.dll %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsIDE
copy ..\nMars\Bin\Release\nMars.Engine.dll %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsIDE
copy ..\nMars\Bin\Release\nMars.Graphics.dll %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsIDE
copy ..\nMars\Bin\Release\nMars.Debugger.dll %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsIDE
copy ..\nMars\Bin\Release\nMars.IDE.Debugger.dll %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsIDE
copy ..\nMars\Bin\Release\nMars.exe %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsIDE
copy ..\nMars\Bin\Release\nMars.IDE.exe %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsIDE
copy ..\nMars\Bin\Release\nMars.exe.config %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsIDE
copy ..\nMars\Bin\Release\nMars.IDE.exe.config %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsIDE

mkdir %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsShellPy
copy ..\nMars\Bin\Release\nMars.ShellPy.dll %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsShellPy
copy ..\nMars\Bin\Release\IronPython.dll %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsShellPy
copy ..\nMars\Bin\Release\IronMath.dll %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsShellPy

mkdir %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsTest
copy ..\nMars\Bin\Release\nMars.Test.exe %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsTest
copy ..\nMars\Bin\Release\pMars.dll %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsTest
copy ..\nMars\Bin\Release\pMars.DllWrapper.dll %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsTest

cd %VER%%APPENDBUILD%
zip -r -9 nMarsConsole.%VER%%APPENDBUILD%.bin.zip %VER%%APPENDBUILD%.nMarsConsole
zip -r -9 nMarsIDE.%VER%%APPENDBUILD%.win.zip %VER%%APPENDBUILD%.nMarsIDE
zip -r -9 nMarsShellPy.%VER%%APPENDBUILD%.bin.zip %VER%%APPENDBUILD%.nMarsShellPy
zip -r -9 nMarsTest.%VER%%APPENDBUILD%.win.zip %VER%%APPENDBUILD%.nMarsTest
cd ..

copy ..\nMars\Bin\Release\nMars.msi %VER%%APPENDBUILD%\nMarsIDE.%VER%%APPENDBUILD%.win.msi