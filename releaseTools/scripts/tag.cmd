@echo off
call %~dp0\ver.cmd

svn cp https://svn.sourceforge.net/svnroot/nmars/trunk https://svn.sourceforge.net/svnroot/nmars/tags/release-%VER% -m "release %VER% tag"
