@echo off
call scripts\ver.cmd
call scripts\assemblyVersion.cmd
call scripts\build.cmd
call scripts\package.cmd
call scripts\tag.cmd
