@echo off
call %~dp0\ver.cmd

svn export https://nmars.svn.sourceforge.net/svnroot/nmars/trunk %VER%%APPENDBUILD%\%VER%%APPENDBUILD%.nMarsSources


cd %VER%%APPENDBUILD%
zip -r -9 nMars.%VER%%APPENDBUILD%.src.zip %VER%%APPENDBUILD%.nMarsSources
cd ..

