@echo off
call %~dp0\ver.cmd

mkdir nMarsBinary.%VER%%APPENDBUILD%
copy ..\nMars\ReadMe.txt nMarsBinary.%VER%%APPENDBUILD%
copy ..\nMars\Changes.txt nMarsBinary.%VER%%APPENDBUILD%
copy ..\nMars\Usage.txt nMarsBinary.%VER%%APPENDBUILD%
copy ..\nMars\Bin\Release\nMars.RedCode.dll nMarsBinary.%VER%%APPENDBUILD%
copy ..\nMars\Bin\Release\nMars.Parser.exe nMarsBinary.%VER%%APPENDBUILD%
copy ..\nMars\Bin\Release\nMars.Engine.exe nMarsBinary.%VER%%APPENDBUILD%
copy ..\nMars\Bin\Release\pMars.DllWrapper.exe nMarsBinary.%VER%%APPENDBUILD%
copy ..\nMars\Bin\Release\nMars.Test.exe nMarsBinary.%VER%%APPENDBUILD%
copy ..\nMars\Bin\Release\nMars.Debugger.exe nMarsBinary.%VER%%APPENDBUILD%
zip -r -9 nMars.%VER%%APPENDBUILD%.bin.zip nMarsBinary.%VER%%APPENDBUILD%

mkdir nMarsIdeBinary.%VER%%APPENDBUILD%
copy ..\nMars\ReadMe.txt nMarsIdeBinary.%VER%%APPENDBUILD%
copy ..\nMars\Changes.txt nMarsIdeBinary.%VER%%APPENDBUILD%
copy ..\nMars\Usage.txt nMarsIdeBinary.%VER%%APPENDBUILD%
copy ..\nMars\Bin\Release\nMars.RedCode.dll nMarsIdeBinary.%VER%%APPENDBUILD%
copy ..\nMars\Bin\Release\nMars.Parser.exe nMarsIdeBinary.%VER%%APPENDBUILD%
copy ..\nMars\Bin\Release\nMars.Engine.exe nMarsIdeBinary.%VER%%APPENDBUILD%
copy ..\nMars\Bin\Release\nMars.IDE.exe nMarsIdeBinary.%VER%%APPENDBUILD%
zip -r -9 nMarsIde.%VER%%APPENDBUILD%.bin.zip nMarsIdeBinary.%VER%%APPENDBUILD%

mkdir nMarsDbgPyBinary.%VER%%APPENDBUILD%
copy ..\nMars\ReadMe.txt nMarsDbgPyBinary.%VER%%APPENDBUILD%
copy ..\nMars\Changes.txt nMarsDbgPyBinary.%VER%%APPENDBUILD%
copy ..\nMars\Usage.txt nMarsDbgPyBinary.%VER%%APPENDBUILD%
copy ..\nMars\Bin\Release\IronPython.dll nMarsDbgPyBinary.%VER%%APPENDBUILD%
copy ..\nMars\Bin\Release\IronMath.dll nMarsDbgPyBinary.%VER%%APPENDBUILD%
copy ..\nMars\Bin\Release\nMars.DbgShellPy.dll nMarsDbgPyBinary.%VER%%APPENDBUILD%
zip -r -9 nMarsDbgPy.%VER%%APPENDBUILD%.zip nMarsDbgPyBinary.%VER%%APPENDBUILD%
