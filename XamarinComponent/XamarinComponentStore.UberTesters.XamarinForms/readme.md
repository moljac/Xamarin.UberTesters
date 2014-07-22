# HowTo #

## Content ##

1. 	compile.bat  
	compiles all relevant projects
2.  component-create.bat (Windows) and component-create.sh (MacOSX - not ready)
	build xam package for comppnent submission
	
	
## Steps ##

1. 	replace all occurrences of ComponentName with desired name for component   
	do replace all on project
	1.	in compile.bat which triggers compilation of projects
	2.  component-create.bat under Windows or component-create.sh under MacOSX
	
2.	replace all occurrences of HolisticWare with relevant company name
3.	start component-create.bat under Windows or component-create.sh under MacOSX




## Errors Encountered ##


File does not exist 'icons/HolisticWare-SharpSerializer_128x128.png' when adding 'HolisticWare-SharpSerializer-1.0/compo
nent/icons/HolisticWare-SharpSerializer_128x128.png'.
  at Xamarin.Components.Packaging.Xamify.Xamify.WriteFile (ICSharpCode.SharpZipLib.Zip.ZipOutputStream zipStream, System
.String entryName, System.String filePath) [0x00000] in <filename unknown>:0
  at Xamarin.Components.Packaging.Xamify.Xamify.CreatePackage (Xamarin.Components.Packaging.Xamify.PackageSpec spec) [0x
00000] in <filename unknown>:0
  at Xamarin.Components.CreateCommand.Run (System.String[] args) [0x00000] in <filename unknown>:0
  at Xamarin.Components.Application.Main (System.String[] args) [0x00000] in <filename unknown>:0
Press any key to continue . . .


Filenames must match


sample-component_128x128.png
sample-component_512x512.png

HolisticWare-SharpSerializer_128x128.png
HolisticWare-SharpSerializer_512x512.png