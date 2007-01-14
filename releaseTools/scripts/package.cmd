@echo off
call %~dp0\ver.cmd

mkdir nMarsConsole.%VER%%APPENDBUILD%
copy ..\nMars\ReadMe.txt nMarsConsole.%VER%%APPENDBUILD%
copy ..\nMars\Changes.txt nMarsConsole.%VER%%APPENDBUILD%
copy ..\nMars\Usage.txt nMarsConsole.%VER%%APPENDBUILD%
copy ..\nMars\Bin\Release\nMars.RedCode.dll nMarsConsole.%VER%%APPENDBUILD%
copy ..\nMars\Bin\Release\nMars.Parser.dll nMarsConsole.%VER%%APPENDBUILD%
copy ..\nMars\Bin\Release\nMars.Engine.dll nMarsConsole.%VER%%APPENDBUILD%
copy ..\nMars\Bin\Release\nMars.Debugger.dll nMarsConsole.%VER%%APPENDBUILD%
copy ..\nMars\Bin\Release\nMars.exe nMarsConsole.%VER%%APPENDBUILD%
zip -r -9 nMarsConsole.%VER%%APPENDBUILD%.bin.zip nMarsConsole.%VER%%APPENDBUILD%

copy ..\nMars\Bin\Release\nMars.msi nMarsIDE.%VER%%APPENDBUILD%.win.msi