@echo off
call "%PROGRAMFILES%\Microsoft Visual Studio 10.0\VC\vcvarsall.bat"


rmdir /q /s .\bin\
rmdir /q /s .\bin\

:: =============================================================================================
:: select solution file sln to compile all projects
::		..\ComponentName.sln
:: project files to narrow selection
:: output of compilation is in <ProjectName>\bin\Debug.msbuild\
set PROJECTS=^
	..\ComponentName.Library.MonoTouch\ComponentName.Library.MonoTouch.csproj ^
	..\ComponentName.Library.MonoForAndroid\ComponentName.Library.MonoForAndroid.csproj 

set CONFIGURATION=Debug
::set CONFIGURATION=Release

for %%p IN (%PROJECTS%) DO (
	echo ------------------------------------------------------------------
	echo %%p
	msbuild %%p ^
			/p:Configuration=%CONFIGURATION% ^
			/property:OutDir=.\bin\%CONFIGURATION%.msbuild\
)
:: =============================================================================================

@IF %ERRORLEVEL% NEQ 0 PAUSE	
