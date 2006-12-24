@echo off
call %~dp0\ver.cmd

svn export https://nmars.svn.sourceforge.net/svnroot/nmars/trunk nMarsSources.%VER%%APPENDBUILD%
zip -r -9 nMars.%VER%%APPENDBUILD%.src.zip nMarsSources.%VER%%APPENDBUILD%