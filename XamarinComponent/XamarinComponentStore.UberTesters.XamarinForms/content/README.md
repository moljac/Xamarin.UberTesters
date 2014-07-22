# Xamarin Component ComponentName #

ComponentName for ...

* 	
*	

Serialization

* 	[]()



```shell
:: component-create.bat
@echo off

setlocal ENABLEDELAYEDEXPANSION

call .\compile.bat




set MONO="%PROGRAMFILES%\Mono-3.0.9\bin\mono.exe"
set XPKG=bin.apps\xpkg\xpkg.exe
set RAKE=C:\bin\Ruby200\bin\rake


:: rake downloads xpkg and runs:

set PACKAGE=ComponentName

set ASSEMBLIES=^
	..\ComponentName.Library.MonoForAndroid\bin\Debug\ComponentName.Library.MonoForAndroid.dll ^
	..\ComponentName.Library.MonoTouch\bin\Debug\ComponentName.Library.MonoTouch.dll


	
:: http://www.dostips.com/DtTipsStringManipulation.php
:: 

echo ===========================================================================
echo starting services
for %%A IN (%ASSEMBLIES%) DO (
	echo -----------------------------------
	echo %%A
	set FILENAME=%%~nA
	echo !FILENAME!

	:: not sure for filenames, so let's do some string replacements
	set FILENAME=!FILENAME:.Library=!
	set FILENAME=!FILENAME:.monodroid=.Android!
	set FILENAME=!FILENAME:.MonoDroid=.Android!
	set FILENAME=!FILENAME:.monoforandroid=.Android!
	set FILENAME=!FILENAME:.MonoForAndroid=.Android!

	set FILENAME=!FILENAME:.monotouch=.iOS!
	set FILENAME=!FILENAME:.MonoTouch=.iOS!

	set FILENAME=!FILENAME!.dll
	echo !FILENAME!
	
	echo f | xcopy /f /y %%A .\content\bin\!FILENAME!
)

echo ===========================================================================

DEL /Q *.xam *.xam.zip

%MONO% ^
	%XPKG% ^
	create %PACKAGE%-1.0.xam ^
	--name="HolisticWare ComponentName component" ^
	--summary="HolisticWare featuring ComponentName" ^
	--publisher="HolisticWare LLC" ^
	--website="http://holisticware.net/" ^
	--details="content/Details.md" ^
	--license="content/License.md" ^
	--getting-started="content/GettingStarted.md" ^
	--icon="content/icons/%PACKAGE%_128x128.png" ^
	--icon="content/icons/%PACKAGE%_512x512.png" ^
	--library="ios":"content/bin/%PACKAGE%.iOS.dll" ^
	--library="android":"content/bin/%PACKAGE%.Android.dll" ^
	--sample="Sample for iOS. %PACKAGE% sample for iOS.":"content/samples/%PACKAGE%.iOS.sln" ^
	--sample="Sample for Android. %PACKAGE% sample for Android.":"content/samples/%PACKAGE%.Android.sln"
	

@IF %ERRORLEVEL% NEQ 0 PAUSE
```


To build this sample component:

```shell
# Download xpkg
curl -L https://components.xamarin.com/submit/xpkg > xpkg.zip
mkdir xpkg
unzip -o -d xpkg xpkg.zip

# Create the component package
mono xpkg/xpkg.exe create sample-component-1.0.xam \
    --name="My ComponentName Component" \
    --summary="Add a huge amount of ComponentNameness to your Xamarin apps." \
    --publisher="ComponentName Corp, Inc." \
    --website="http://ComponentNamecorp.com/component" \
    --details="Details.md" \
    --license="License.md" \
    --getting-started="GettingStarted.md" \
    --icon="icons/ComponentName_128x128.png" \
    --icon="icons/ComponentName_512x512.png" \
    --library="ios":"bin/ComponentName.iOS.dll" \
    --library="android":"bin/ComponentName.Android.dll" \
    --sample="iOS Sample. Demonstrates ComponentNameness on iOS.":"samples/ComponentName.iOS.sln" \
    --sample="Android Sample. Demonstrates ComponentNameness on Android":"samples/ComponentName.Android.sln"
```

There's a Rakefile in this repo that will do these steps for you if you
simply type `rake`:

```shell
$ rake
* Downloading xpkg...
* Creating sample-component-1.0.xam...
mono xpkg/xpkg.exe create sample-component-1.0.xam \
    --name="My ComponentName Component" \
    --summary="Add a huge amount of ComponentNameness to your Xamarin apps." \
    --publisher="ComponentName Corp, Inc." \
    --website="http://ComponentNamecorp.com/component" \
    --details="Details.md" \
    --license="License.md" \
    --getting-started="GettingStarted.md" \
    --icon="icons/ComponentName_128x128.png" \
    --icon="icons/ComponentName_512x512.png" \
    --library="ios":"bin/ComponentName.iOS.dll" \
    --library="android":"bin/ComponentName.Android.dll" \
    --sample="iOS Sample. Demonstrates ComponentNameness on iOS.":"samples/ComponentName.iOS.sln" \
    --sample="Android Sample. Demonstrates ComponentNameness on Android":"samples/ComponentName.Android.sln"
* Created sample-component-1.0.xam
```
