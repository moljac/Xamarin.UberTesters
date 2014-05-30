using System;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Runtime.InteropServices;
using MonoTouch.ObjCRuntime;

namespace UbertestersSDK 
{

	[Model, BaseType (typeof (NSObject))]
	public partial interface UTAlertDelegate {

		[Export ("CancelButtonPressed")]
		void CancelButtonPressed ();

		[Export ("SuccessButtonPressed")]
		void SuccessButtonPressed ();
	}

	[BaseType (typeof (UIView))]
	public partial interface UTAlert {

		[Export ("utAlertDelegate", ArgumentSemantic.Assign)]
		UTAlertDelegate UtAlertDelegate { get; set; }

		[Export ("initWithTitle:mesage:cancelButton:otherButton:")]
		IntPtr Constructor (string title, string message, string cancelButton, string otherButton);

		[Export ("Show:")]
		void Show (UIView alert);
	}

		
//---------------------------------------------------------------------------------------
// Objective Sharpies generated
// moved to Structs and Enums
// ...................................................................
//	public enum UbertestersOptions : [unmapped: unexposed: Elaborated] 
//	{
//		TOptionsDefault = 0,
//		TOptionsSlider = 1 << 0,
//		TOptionsShake = 1 << 1,
//		TOptionsManual = 1 << 2,
//		TOptionsLockingModeDisableUbertestersIfBuildNotExist = 1 << 3,
//		TOptionsLockingModeAppIfBuildNotExist = 1 << 4
//	}
//
//	public enum LockingMode : [unmapped: unexposed: Elaborated] {
//		DisableUbertestersIfBuildNotExist = 0,
//		LockAppIfBuildNotExist = 1
//	}
//
//	public enum ActivationMode : [unmapped: unexposed: Elaborated] {
//		UTSlider = 0,
//		UTShake = 1,
//		UTManual = 2
//	}
//
//	public enum UTLogLevel : [unmapped: unexposed: Elaborated] {
//		Error,
//		Warning,
//		Info
//	}
// ...................................................................
//---------------------------------------------------------------------------------------

	[BaseType (typeof (NSObject))]
	public partial interface Ubertesters : IUITextViewDelegate, UTAlertDelegate {

		[Export ("lockScreen")]
		// LockScreenViewControllerUbertesters  // maybe internal?!? make it NSObject
		NSObject 
		LockScreen { get; }

		[Export ("userProfileScreen")]
		// UserProfileViewController 			// maybe internal?!? make it NSObject
		NSObject 
		UserProfileScreen { get; }

		[Export ("apiKey", ArgumentSemantic.Retain)]
		string ApiKey { get; set; }

		[Export ("mainView", ArgumentSemantic.Retain)]
		// CustomViewUbertesters  				// maybe internal?!? make it NSObject
		NSObject 
		MainView { get; set; }

		[Export ("isOpenGL")]
		bool IsOpenGL { get; set; }

		[Export ("isInit")]
		bool IsInit { get; set; }

		[Export ("isHide")]
		bool IsHide { get; set; }

		[Export ("autoUpdate")]
		bool AutoUpdate { get; set; }

		[Export ("offlineMode")]
		bool OfflineMode { get; set; }

		[Export ("uberTrigger")]
		double UberTrigger { get; set; }

		[Export ("isError")]
		bool IsError { get; set; }

		[Export ("lockingMode")]
		LockingMode LockingMode { get; set; }

		[Static, Export ("Shared")
		//, Verify 
		//	(
		//	  "ObjC method massaged into getter property"
		//	, "~/docs/ubertesters.sdk.ios /UbertestersSDK/UbertestersSDK.framework/Versions/A/Headers/Ubertesters.h"
		//	, Line = 102
		//	)
		]
		Ubertesters Shared { get; }

		[Export ("initialize")]
		void Initialize ();

		[Export ("initialize:")]
		void Initialize (LockingMode mode);

		[Export ("InitializeWithOptions:")]
		void InitializeWithOptions (UbertestersOptions options);

		[Export ("MakeScreenshot")]
		void MakeScreenshot ();

		[Export ("ShowMenuSlider")]
		void ShowMenuSlider ();

		[Export ("HideMenuSlider")]
		void HideMenuSlider ();

		[Export ("ShowMenu")]
		void ShowMenu ();

		[Export ("HideMenu")]
		void HideMenu ();

		[Export ("UTLog:level:")]
		void UTLog (string format, string level);

		[Export ("UTLog:withLevel:")]
		void UTLog (string format, UTLogLevel level);

		[Export ("IsOnline")
		//, Verify 
		//	(
		//	  "ObjC method massaged into getter property"
		//	, "~/docs/ubertesters.sdk.ios /UbertestersSDK/UbertestersSDK.framework/Versions/A/Headers/Ubertesters.h"
		//	, Line = 160
		//	)
		]
		bool IsOnline { get; }

		[Export ("GetPhoneState")
		//, Verify 
		//	(
		//	  "ObjC method massaged into getter property"
		//	, "~/docs/ubertesters.sdk.ios /UbertestersSDK/UbertestersSDK.framework/Versions/A/Headers/Ubertesters.h"
		//	, Line = 161
		//	)
		]
		string GetPhoneState { get; }

		[Export ("MakeAppExit")]
		void MakeAppExit ();

		[Export ("ShowLockScreen")]
		void ShowLockScreen ();

		[Export ("PostLogs:token:")]
		void PostLogs (string logs, string token);

		[Export ("PostCrash:token:state:rid:uid:")]
		void PostCrash (string log, string token, string state, string rid, string uid);

		[Export ("MakeUTLibWindowKeyAndVisible")]
		void MakeUTLibWindowKeyAndVisible ();

		[Export ("GetUTLibWindow")
		//, Verify 
		//	(
		//	  "ObjC method massaged into getter property"
		//	, "~/docs/ubertesters.sdk.ios /UbertestersSDK/UbertestersSDK.framework/Versions/A/Headers/Ubertesters.h"
		//	, Line = 167
		//	)
		]
		UIWindow GetUTLibWindow { get; }

		[Export ("PlaySystemSound:")]
		void PlaySystemSound (int soundID);

		[Export ("EnableTimer:")]
		void EnableTimer (bool res);

		[Export ("ShowUserProfileScreen")]
		void ShowUserProfileScreen ();

		// Error BI1012: 
		//		btouch: No Export or Bind attribute defined on UbertestersSDK.Ubertesters.HandleUbertestersException (BI1012) 
		[Export ("HandleUbertestersException:")]
		// Error CS0601: 
		//		The DllImport attribute must be specified on a method marked `static' and `extern' (CS0601)
		//[DllImport ("~/docs/ubertesters.sdk.ios /UbertestersSDK/UbertestersSDK.framework/Versions/A/Headers/Ubertesters.h")]
		//extern		// Error CS0106: The modifier `extern' is not valid for this item (CS0106) 
		//static		// Error CS0106: The modifier `static' is not valid for this item (CS0106)
		void HandleUbertestersException (NSException exception);

		// Error BI1012: 
		//		btouch: No Export or Bind attribute defined on UbertestersSDK.Ubertesters.HandleUbertestersException (BI1012) 
		[Export ("SignalUbertestersHandler:")]
		// Error CS0601: The DllImport attribute must be specified on a method marked `static' and `extern' (CS0601)
		//[DllImport ("~/docs/ubertesters.sdk.ios /UbertestersSDK/UbertestersSDK.framework/Versions/A/Headers/Ubertesters.h")]
		//extern		// Error CS0106: The modifier `extern' is not valid for this item (CS0106) 
		//static		// Error CS0106: The modifier `static' is not valid for this item (CS0106)
		void SignalUbertestersHandler (int signal);

		// Error BI1012: 
		//		btouch: No Export or Bind attribute defined on UbertestersSDK.Ubertesters.HandleUbertestersException (BI1012) 
		[Export ("installUberErrorHandler")]
		// Error CS0601: The DllImport attribute must be specified on a method marked `static' and `extern' (CS0601)
		//[DllImport ("~/docs/ubertesters.sdk.ios /UbertestersSDK/UbertestersSDK.framework/Versions/A/Headers/Ubertesters.h")]
		//extern		// Error CS0106: The modifier `extern' is not valid for this item (CS0106) 
		//static		// Error CS0106: The modifier `static' is not valid for this item (CS0106)
		void InstallUberErrorHandler ();
	}


}
