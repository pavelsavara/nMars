@echo off
call %~dp0\ver.cmd

echo using System.Reflection;> ..\nMars\nMars.RedCode\Properties\VersionInfo.cs 
echo [assembly: AssemblyCompany("Pavel Savara")]>> ..\nMars\nMars.RedCode\Properties\VersionInfo.cs 
echo [assembly: AssemblyProduct("nMars - Corewars MARS for .NET ")]>> ..\nMars\nMars.RedCode\Properties\VersionInfo.cs 
echo [assembly: AssemblyVersion("%VER%.0.0")]>> ..\nMars\nMars.RedCode\Properties\VersionInfo.cs 
echo [assembly: AssemblyFileVersion("%VER%.0.0")]>> ..\nMars\nMars.RedCode\Properties\VersionInfo.cs 
echo [assembly: AssemblyCopyright("http://sourceforge.net/projects/nmars")]>> ..\nMars\nMars.RedCode\Properties\VersionInfo.cs 
echo [assembly: AssemblyDescription("http://sourceforge.net/projects/nmars")]>> ..\nMars\nMars.RedCode\Properties\VersionInfo.cs
