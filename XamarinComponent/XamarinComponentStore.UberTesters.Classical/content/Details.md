# Ubertesters 

Ubertesters is mobile beta testing solution (like Testflight),  but with support for 
iOS, Android and Windows Phone.

Ubertesters component supports:

* 	Xamarin.iOS
* 	Xamarin.Android


## Usage

###	Android

1.	Install Ubertesters component
2.	Set Ubertesters framework project data and Android permissions		
	1.	Open  http://beta.ubertesters.com/projects and select project,	
		go to SDK Integration		
	2.	Copy "Ubertesters Project ID"
	3.	Add "Ubertesters Project ID" to app's "AndroidManifest.xml" meta-data with 		
		attribute android:name="ubertesters_project_id"
	
```xml		
	<application android:label="UberTesters.Application.XamarinAndroid">
		<!-- 
			Ubertesters project id 

			Ubertesters portal +/ ProjectName +/ SDK Integration
		-->
		<meta-data android:name="ubertesters_project_id" android:value="project-id-copied-from-ubertesters-site" />
	</application>
	<!-- 
		Ubertesters permissions
	-->
	<uses-permission android:name="android.permission.GET_TASKS" />
	<uses-permission android:name="android.permission.WRITE_EXTERNAL_STORAGE" />
	<uses-permission android:name="android.permission.SYSTEM_ALERT_WINDOW" />
```	
	In Xamarin permissions can be added as assembly attributes:			
```csharp
	// Ubertesters Permissions (if not defined in AndroidManifest.xml)
	[assembly: UsesPermission(Android.Manifest.Permission.Internet)]
	[assembly: UsesPermission(Android.Manifest.Permission.WriteExternalStorage)]
	[assembly: UsesPermission(Android.Manifest.Permission.SystemAlertWindow)]
```
3.	Initialize Ubertesters framework		
	either in main Activity or in Application object

```csharp
	[Application]
	public class Application : Android.App.Application
	{
		public Application(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
			return;
		}

		public override void OnCreate()
		{
			base.OnCreate ();

			Ubertesters.Initialize
						(
						  this 	// context
						, UbertestersSDK.Common.Models.LockingMode.LockingModeLockAppIfBuildNotExist
						);

			return;
		}
	}
```	
4.	Use Ubertesters framework
	1.	logging (remote)
```csharp
	Ubertesters.Logger().Info("Info");
	Ubertesters.Logger().Warn("Warn");
	Ubertesters.Logger().Error("Error");
```
	2.	screenshot making
```csharp
	Ubertesters.TakeScreenshot();
```
	3.	showing Ubertesters page
```csharp
	Ubertesters.ShowUtPage(); 
	Ubertesters.HideUtPage(); 
```

### iOS

1. 	Install Ubertesters component		
2.	Set Ubertesters framework project data and Android permissions		
	Add "Ubertesters Project ID" to your app's "Info.plist" file		
	1.	Open  http://beta.ubertesters.com/projects and select project,	
		go to SDK Integration		
	2.	Copy "Ubertesters Project ID"
	3.	Add "Ubertesters Project ID" to your app's Info.plist with key "ubertesters_project_id"
```xml
	<key>ubertesters_project_id</key>
	<string>project-id-copied-from-ubertesters-site</string>
```	



## Other Resources

* 	[http://ubertesters.com](http://ubertesters.com)
* 	[http://ubertesters.com/download-sdk/](http://ubertesters.com/download-sdk/)

