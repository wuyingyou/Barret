SET MSBUILD=%WINDIR%\Microsoft.NET\Framework\v4.0.30319\MsBuild.exe
IF NOT EXIST "%MSBUILD%" GOTO NOMSB

"%MSBUILD%" CarSalePlatform.sln /t:rebuild /p:configuration=Debug /verbosity:quiet 
GOTO :EOF

:NOMSB
echo. 
echo MSBUILD not found 
echo. 
GOTO :EOF 