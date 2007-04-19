@echo off
call scripts\ver.cmd
call scripts\clean.cmd
call scripts\assemblyVersion.cmd
call scripts\build.cmd
call scripts\package.cmd >> release%VER%%APPENDBUILD%.log
rem call scripts\packagep.cmd >> release%VER%%APPENDBUILD%.log
call scripts\packages.cmd >> release%VER%%APPENDBUILD%.log
rem call scripts\tag.cmd >> release%VER%%APPENDBUILD%.log
