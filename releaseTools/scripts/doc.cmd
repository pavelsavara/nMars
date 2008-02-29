@echo off
call %~dp0\ver.cmd
"C:\Program Files\EWSoftware\Sandcastle Help File Builder\SandcastleBuilderConsole.exe" /v %~dp0\..\..\%nDir%\nMars.shfb
