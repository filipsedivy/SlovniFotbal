@echo off

:: == Promenne ==
set msBuild=%systemroot%\Microsoft.NET\Framework\v4.0.30319
set webNet=http://www.microsoft.com/cs-cz/download/details.aspx?id=17851

:: Nazev projektu, ktery se ma kompilovat
set project=SlovniFotbal

:: Vystupni slozka
set outputPath=%USERPROFILE%\Desktop\%project%

:: Nemazat ladici informace - pouze pro vyvojare (true|false)
set debug=false


:: == Kompilator ==
:: Evereni existence slozky
IF NOT EXIST "%msBuild%" GOTO compilerNotExists

:: Jdeme za projektem
cd ../src/

:: Instalace balicku chybnych
echo Probiha stahovani chybejicich knihoven
call "../build/NuGet.exe" restore %project%.sln

:: Vzdalene volani kompileru
echo Probiha kompilace projektu
call %msBuild%\msbuild.exe %project%.sln /p:Configuration=Release /p:OutputPath=%outputPath% /l:FileLogger,Microsoft.Build.Engine;logfile=MSBuild_ReleaseCompile.log

:: Odstraneni ladicich informaci
if %debug% == false (
del %USERPROFILE%\Desktop\%project%\%project%.pdb
del MSBuild_ReleaseCompile.log
)

:: Zobrazeni slozky
start %USERPROFILE%\Desktop\%project%
exit

:: Navestidlo, neexistince .NET
:compilerNotExists

:: Zobrazeni hlasky pomoci JavaScriptu
mshta javascript:alert("Nemate nainstalovan .NET Framework v4.0\n\nBude otevren webovy prohlizec");close();

:: Zobrazeni webove stranky ke stazeni .NET Frameworku
start %webNet%
exit
