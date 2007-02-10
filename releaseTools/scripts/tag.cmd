@echo off
call %~dp0\ver.cmd

echo %VER%.%BUILDREV%> %~dp0\..\..\nMars\nMars.ver
svn ci -m "version" %~dp0\..\..\nMars\nMars.ver

svn cp https://nmars.svn.sourceforge.net/svnroot/nmars/trunk https://nmars.svn.sourceforge.net/svnroot/nmars/tags/release-%VER%%APPENDBUILD% -m "release %VER%%APPENDBUILD% tag"
