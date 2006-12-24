@echo off
call scripts\ver.cmd
call scripts\clean.cmd
call scripts\assemblyVersion.cmd
call scripts\build.cmd
call scripts\package.cmd
call scripts\packagep.cmd
rem call scripts\packages.cmd
rem call scripts\tag.cmd
