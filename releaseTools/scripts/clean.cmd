@echo off
call %~dp0\ver.cmd

rm -rf nMarsSources.%VER%%APPENDBUILD%
rm -rf nMarsBinary.%VER%%APPENDBUILD%
rm -rf npMarsBinary.%VER%%APPENDBUILD%.win32
rm -rf nMarsDbgPyBinary.%VER%%APPENDBUILD%
rm -f nMars.%VER%%APPENDBUILD%.src.zip
rm -f nMars.%VER%%APPENDBUILD%.bin.zip
rm -f npMars.%VER%%APPENDBUILD%.win32.zip
rm -f nMarsDbgPy.%VER%%APPENDBUILD%.zip