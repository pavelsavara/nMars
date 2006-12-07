@echo off
call %~dp0\ver.cmd

svn export https://svn.sourceforge.net/svnroot/nmars/trunk nMarsSources.%VER%%APPENDBUILD%
zip -r -9 nMars.%VER%%APPENDBUILD%.src.zip nMarsSources.%VER%%APPENDBUILD%

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

mkdir nMarsDbgPyBinary.%VER%%APPENDBUILD%
copy ..\nMars\ReadMe.txt nMarsDbgPyBinary.%VER%%APPENDBUILD%
copy ..\nMars\Changes.txt nMarsDbgPyBinary.%VER%%APPENDBUILD%
copy ..\nMars\Usage.txt nMarsDbgPyBinary.%VER%%APPENDBUILD%
copy ..\nMars\Bin\Release\IronPython.dll nMarsDbgPyBinary.%VER%%APPENDBUILD%
copy ..\nMars\Bin\Release\IronMath.dll nMarsDbgPyBinary.%VER%%APPENDBUILD%
copy ..\nMars\Bin\Release\nMars.DbgShellPy.dll nMarsDbgPyBinary.%VER%%APPENDBUILD%
zip -r -9 nMarsDbgPy.%VER%%APPENDBUILD%.zip nMarsDbgPyBinary.%VER%%APPENDBUILD%
