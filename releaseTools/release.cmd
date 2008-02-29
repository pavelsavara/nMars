@echo off
call scripts\ver.cmd
rem call scripts\clean.cmd
rem call scripts\assemblyVersion.cmd
rem call scripts\build.cmd
rem call scripts\package.cmd >> release%VER%%APPENDBUILD%.log
rem call scripts\packagep.cmd >> release%VER%%APPENDBUILD%.log
rem call scripts\packages.cmd >> release%VER%%APPENDBUILD%.log
call scripts\tag.cmd >> release%VER%%APPENDBUILD%.log
