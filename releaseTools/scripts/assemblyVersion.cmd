@echo off
call %~dp0\ver.cmd

echo using System.Reflection;> %~dp0\..\..\nMars\nMars.RedCode\Properties\VersionInfo.cs 
echo [assembly: AssemblyCompany("Pavel Savara")]>> %~dp0\..\..\nMars\nMars.RedCode\Properties\VersionInfo.cs 
echo [assembly: AssemblyProduct("nMars - Corewars MARS for .NET ")]>> %~dp0\..\..\nMars\nMars.RedCode\Properties\VersionInfo.cs 
echo [assembly: AssemblyVersion("%VER%.%BUILD%")]>> %~dp0\..\..\nMars\nMars.RedCode\Properties\VersionInfo.cs 
echo [assembly: AssemblyFileVersion("%VER%.%BUILD%")]>> %~dp0\..\..\nMars\nMars.RedCode\Properties\VersionInfo.cs 
echo [assembly: AssemblyCopyright("http://sourceforge.net/projects/nmars")]>> %~dp0\..\..\nMars\nMars.RedCode\Properties\VersionInfo.cs 
echo [assembly: AssemblyDescription("http://sourceforge.net/projects/nmars")]>> %~dp0\..\..\nMars\nMars.RedCode\Properties\VersionInfo.cs

type %~dp0\..\..\nMars\pMars\pMarsVerision.a.rc > %~dp0\..\..\nMars\pMars\pMarsVerision.rc
echo  FILEVERSION 0,%PVERMA%,%PVERMI%,0 >> %~dp0\..\..\nMars\pMars\pMarsVerision.rc
echo  PRODUCTVERSION 0,%PVERMA%,%PVERMI%,0 >> %~dp0\..\..\nMars\pMars\pMarsVerision.rc
type %~dp0\..\..\nMars\pMars\pMarsVerision.k.rc >> %~dp0\..\..\nMars\pMars\pMarsVerision.rc
echo             VALUE "ProductVersion", "0, %PVERMA%, %PVERMI%, 0" >> %~dp0\..\..\nMars\pMars\pMarsVerision.rc
echo             VALUE "FileVersion", "0, %PVERMA%, %PVERMI%, 0" >> %~dp0\..\..\nMars\pMars\pMarsVerision.rc
type %~dp0\..\..\nMars\pMars\pMarsVerision.z.rc >> %~dp0\..\..\nMars\pMars\pMarsVerision.rc
