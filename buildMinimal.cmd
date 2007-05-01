@echo off
if not exist nMars.snk call nMars.snk.cmd
"C:\WINDOWS\Microsoft.NET\Framework\v2.0.50727\MSBuild.exe" nMarsMinimal.sln /t:Rebuild /p:Configuration=Release 
