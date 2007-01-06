@echo off
call %~dp0\ver.cmd

echo using System.Reflection;> %~dp0\..\..\nMars\nMars.RedCode\Properties\VersionInfo.cs 
echo [assembly: AssemblyCompany("Pavel Savara")]>> %~dp0\..\..\nMars\nMars.RedCode\Properties\VersionInfo.cs 
echo [assembly: AssemblyProduct("nMars - Corewars MARS for .NET ")]>> %~dp0\..\..\nMars\nMars.RedCode\Properties\VersionInfo.cs 
echo [assembly: AssemblyVersion("%VER%.%BUILD%")]>> %~dp0\..\..\nMars\nMars.RedCode\Properties\VersionInfo.cs 
echo [assembly: AssemblyFileVersion("%VER%.%BUILD%")]>> %~dp0\..\..\nMars\nMars.RedCode\Properties\VersionInfo.cs 
echo [assembly: AssemblyCopyright("http://sourceforge.net/projects/nmars")]>> %~dp0\..\..\nMars\nMars.RedCode\Properties\VersionInfo.cs 
echo [assembly: AssemblyDescription("http://sourceforge.net/projects/nmars")]>> %~dp0\..\..\nMars\nMars.RedCode\Properties\VersionInfo.cs
svn ci -m "version" %~dp0\..\..\nMars\nMars.RedCode\Properties\VersionInfo.cs 

type %~dp0\pMarsVersion.a.rc > %~dp0\..\..\nMars\pMars\src\pMarsVersion.rc
echo  FILEVERSION 0,%PVERMA%,%PVERMI%,%PVERBU% >> %~dp0\..\..\nMars\pMars\src\pMarsVersion.rc
echo  PRODUCTVERSION 0,%PVERMA%,%PVERMI%,%PVERBU% >> %~dp0\..\..\nMars\pMars\src\pMarsVersion.rc
type %~dp0\pMarsVersion.k.rc >> %~dp0\..\..\nMars\pMars\src\pMarsVersion.rc
echo             VALUE "ProductVersion", "0, %PVERMA%, %PVERMI%, %PVERBU%" >> %~dp0\..\..\nMars\pMars\src\pMarsVersion.rc
echo             VALUE "FileVersion", "0, %PVERMA%, %PVERMI%, %PVERBU%" >> %~dp0\..\..\nMars\pMars\src\pMarsVersion.rc
type %~dp0\pMarsVersion.z.rc >> %~dp0\..\..\nMars\pMars\src\pMarsVersion.rc
svn ci -m "version" %~dp0\..\..\nMars\pMars\src\pMarsVersion.rc