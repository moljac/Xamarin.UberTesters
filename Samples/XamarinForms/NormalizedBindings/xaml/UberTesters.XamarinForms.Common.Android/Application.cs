using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

//using UbertestersSDK;
using UbertestersSDK;

namespace UberTesters.XamarinForms.XamarinAndroid
{
	/// <summary>
	/// Application.
	/// http://stackoverflow.com/questions/13633092/efficiently-passing-custom-object-data-between-android-activities-mono-android
	/// http://stackoverflow.com/questions/22839417/define-a-base-class-for-application-class-in-xamarin-android-and-mvvmcross
	/// http://forums.xamarin.com/discussion/2147/what-is-the-recipe-to-have-a-working-application-derived-class
	/// </summary>
	[Application]
	public class Application : Android.App.Application
	{
		/// If ctor is missing
//		[Trace] error opening trace file: No such file or directory (2)
//		[Trace] Unexpected value from nativeGetEnabledTags: 0
//		[Trace] Unexpected value from nativeGetEnabledTags: 0
//		[Trace] Unexpected value from nativeGetEnabledTags: 0
//		[Mono] Image addref mscorlib[0xb9ea2c40] -> mscorlib.dll[0xb9e9c130]: 1
//		[Mono] AOT module 'mscorlib.dll.so' not found: Cannot load library: load_library(linker.cpp:745): library "/data/data/Ubertesters.Application.XamarinAndroid/lib/mscorlib.dll.so" not found
//		[Mono] Assembly mscorlib[0xb9ea2c40] added to domain RootDomain, ref_count=1
//			[Mono] Assembly Loader probing location: '/data/data/Ubertesters.Application.XamarinAndroid/files/.__override__/Ubertesters.Application.XamarinAndroid.dll'.
//			[Mono] Image addref Ubertesters.Application.XamarinAndroid[0xb9eb03a0] -> /data/data/Ubertesters.Application.XamarinAndroid/files/.__override__/Ubertesters.Application.XamarinAndroid.dll[0xb9ed6520]: 2
//			[Mono] Assembly Ubertesters.Application.XamarinAndroid[0xb9eb03a0] added to domain RootDomain, ref_count=1
//			[Mono] AOT module '/data/data/Ubertesters.Application.XamarinAndroid/files/.__override__/Ubertesters.Application.XamarinAndroid.dll.so' not found: Cannot load library: load_library(linker.cpp:745): library "/data/data/Ubertesters.Application.XamarinAndroid/lib//data/data/Ubertesters.Application.XamarinAndroid/files/.__override__/Ubertesters.Application.XamarinAndroid.dll.so" not found
//			[Mono] Assembly Loader loaded assembly from location: '/data/data/Ubertesters.Application.XamarinAndroid/files/.__override__/Ubertesters.Application.XamarinAndroid.dll'.
//			[Mono] Config attempting to parse: '/data/data/Ubertesters.Application.XamarinAndroid/files/.__override__/Ubertesters.Application.XamarinAndroid.dll.config'.
//			[Mono] Config attempting to parse: '/Users/builder/data/lanes/monodroid-mlion-monodroid-4.12-series/3e2a6063/source/monodroid/builds/install/mono-x86/etc/mono/assemblies/Ubertesters.Application.XamarinAndroid/Ubertesters.Application.XamarinAndroid.config'.
//			[Mono] Assembly Loader probing location: '/data/data/Ubertesters.Application.XamarinAndroid/files/.__override__/Ubertesters.Bindings.XamarinAndroid.dll'.
//			[Mono] Image addref Ubertesters.Bindings.XamarinAndroid[0xb9e9e750] -> /data/data/Ubertesters.Application.XamarinAndroid/files/.__override__/Ubertesters.Bindings.XamarinAndroid.dll[0xb9ede030]: 2
//			[Mono] Assembly Ubertesters.Bindings.XamarinAndroid[0xb9e9e750] added to domain RootDomain, ref_count=1
//			[Mono] AOT module '/data/data/Ubertesters.Application.XamarinAndroid/files/.__override__/Ubertesters.Bindings.XamarinAndroid.dll.so' not found: Cannot load library: load_library(linker.cpp:745): library "/data/data/Ubertesters.Application.XamarinAndroid/lib//data/data/Ubertesters.Application.XamarinAndroid/files/.__override__/Ubertesters.Bindings.XamarinAndroid.dll.so" not found
//			[Mono] Assembly Loader loaded assembly from location: '/data/data/Ubertesters.Application.XamarinAndroid/files/.__override__/Ubertesters.Bindings.XamarinAndroid.dll'.
//			[Mono] Config attempting to parse: '/data/data/Ubertesters.Application.XamarinAndroid/files/.__override__/Ubertesters.Bindings.XamarinAndroid.dll.config'.
//			[Mono] Config attempting to parse: '/Users/builder/data/lanes/monodroid-mlion-monodroid-4.12-series/3e2a6063/source/monodroid/builds/install/mono-x86/etc/mono/assemblies/Ubertesters.Bindings.XamarinAndroid/Ubertesters.Bindings.XamarinAndroid.config'.
//			[monodroid-gc] GREF GC Threshold: 1800
//			[Mono] Image addref Mono.Android[0xb9ec6540] -> Mono.Android.dll[0xb9e9c510]: 1
//			[Mono] Assembly Mono.Android[0xb9ec6540] added to domain RootDomain, ref_count=1
//			[Mono] AOT module 'Mono.Android.dll.so' not found: Cannot load library: load_library(linker.cpp:745): library "/data/data/Ubertesters.Application.XamarinAndroid/lib/Mono.Android.dll.so" not found
//			[Mono] The request to load the assembly mscorlib v2.0.5.0 was remapped to v2.0.0.0
//			[Mono] Unloading image mscorlib.dll [0xb9f08460].
//			[Mono] Assembly Ref addref Mono.Android[0xb9ec6540] -> mscorlib[0xb9ea2c40]: 2
//			[Mono] The request to load the assembly mscorlib v2.0.5.0 was remapped to v2.0.0.0
//			[Mono] Unloading image mscorlib.dll [0xb9f4a090].
//			[Mono] Assembly Ref addref Ubertesters.Bindings.XamarinAndroid[0xb9e9e750] -> mscorlib[0xb9ea2c40]: 3
//			[Mono] Assembly Ref addref Ubertesters.Bindings.XamarinAndroid[0xb9e9e750] -> Mono.Android[0xb9ec6540]: 2
//			[Mono] The request to load the assembly System.Core v2.0.5.0 was remapped to v3.5.0.0
//			[Mono] Image addref System.Core[0xb9fa8d70] -> System.Core.dll[0xb9f8c420]: 1
//			[Mono] Assembly System.Core[0xb9fa8d70] added to domain RootDomain, ref_count=1
//			[Mono] AOT module 'System.Core.dll.so' not found: Cannot load library: load_library(linker.cpp:745): library "/data/data/Ubertesters.Application.XamarinAndroid/lib/System.Core.dll.so" not found
//			[Mono] Assembly Ref addref Mono.Android[0xb9ec6540] -> System.Core[0xb9fa8d70]: 2
//			[Mono] The request to load the assembly mscorlib v2.0.5.0 was remapped to v2.0.0.0
//			[Mono] Unloading image mscorlib.dll [0xb9f8c7d0].
//			[Mono] Assembly Ref addref System.Core[0xb9fa8d70] -> mscorlib[0xb9ea2c40]: 4
//			[Mono] Assembly Ref addref Ubertesters.Application.XamarinAndroid[0xb9eb03a0] -> Mono.Android[0xb9ec6540]: 3
//			[Mono] DllImport attempting to load: '__Internal'.
//			[Mono] DllImport loaded library '(null)'.
//			[Mono] DllImport searching in: '__Internal' ('(null)').
//			[Mono] Searching for '_monodroid_gc_wait_for_bridge_processing'.
//				[Mono] Probing '_monodroid_gc_wait_for_bridge_processing'.
//				[Mono] Found as '_monodroid_gc_wait_for_bridge_processing'.
//				[Mono] DllImport searching in: '__Internal' ('(null)').
//				[Mono] Searching for '_monodroid_get_identity_hash_code'.
//					[Mono] Probing '_monodroid_get_identity_hash_code'.
//					[Mono] Found as '_monodroid_get_identity_hash_code'.
//					[Mono] DllImport searching in: '__Internal' ('(null)').
//					[Mono] Searching for '_monodroid_gref_inc'.
//						[Mono] Probing '_monodroid_gref_inc'.
//						[Mono] Found as '_monodroid_gref_inc'.
//						[Mono] DllImport searching in: '__Internal' ('(null)').
//						[Mono] Searching for '_monodroid_gref_log_new'.
//							[Mono] Probing '_monodroid_gref_log_new'.
//							[Mono] Found as '_monodroid_gref_log_new'.
//							[Mono] DllImport searching in: '__Internal' ('(null)').
//							[Mono] Searching for '_monodroid_gref_dec'.
//								[Mono] Probing '_monodroid_gref_dec'.
//								[Mono] Found as '_monodroid_gref_dec'.
//								[Mono] DllImport searching in: '__Internal' ('(null)').
//								[Mono] Searching for '_monodroid_gref_log_delete'.
//									[Mono] Probing '_monodroid_gref_log_delete'.
//									[Mono] Found as '_monodroid_gref_log_delete'.

		public Application(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
			return;
		}

		public override void OnCreate()
		{
			base.OnCreate ();

			Ubertesters.Initialize
						(
						  this
						, UbertestersSDK.Common.Models.LockingMode.LockingModeLockAppIfBuildNotExist
						);


			((Application) this.ApplicationContext).Data = "test data";	
			return;
		}

		public string Data {get; set;}
	}
}