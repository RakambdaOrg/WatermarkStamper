@ECHO OFF

echo Deleting old build dir
for /f %%i in ('cd') do set PROJECT_DIR=%%i
rd "%PROJECT_DIR%\WatermarkStamper\bin\Release" /S /Q

cd "%PROJECT_DIR%\WatermarkStamper"
echo Compiling
set msBuildDir=C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin
call "%msBuildDir%\MSBuild.exe" WatermarkStamper.csproj /p:Configuration=Release
set msBuildDir=

cd %PROJECT_DIR%
echo Done

:EOF
