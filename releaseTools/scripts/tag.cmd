@echo off
call %~dp0\ver.cmd

svn cp https://nmars.svn.sourceforge.net/svnroot/nmars/trunk https://nmars.svn.sourceforge.net/svnroot/nmars/tags/release-%VER%%APPENDBUILD% -m "release %VER%%APPENDBUILD% tag"
