// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace UbertestersSDKSample.Application.XamarinIOS
{
	[Register ("UbertestersSDKSample_Application_XamarinIOSViewController")]
	partial class UbertestersSDKSample_Application_XamarinIOSViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton buttonLoggerError { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton buttonLoggerInfo { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton buttonLoggerWarn { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton buttonScreenshot { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton buttonUTpage { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISwitch checkBoxOffline { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISwitch checkBoxUserInfo { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField editTextLoggerMessage { get; set; }

		[Action ("buttonLoggerError_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void buttonLoggerError_TouchUpInside (UIButton sender);

		[Action ("buttonLoggerInfo_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void buttonLoggerInfo_TouchUpInside (UIButton sender);

		[Action ("buttonLoggerWarn_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void buttonLoggerWarn_TouchUpInside (UIButton sender);

		[Action ("buttonScreenshot_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void buttonScreenshot_TouchUpInside (UIButton sender);

		[Action ("UIButton15_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void UIButton15_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (buttonLoggerError != null) {
				buttonLoggerError.Dispose ();
				buttonLoggerError = null;
			}
			if (buttonLoggerInfo != null) {
				buttonLoggerInfo.Dispose ();
				buttonLoggerInfo = null;
			}
			if (buttonLoggerWarn != null) {
				buttonLoggerWarn.Dispose ();
				buttonLoggerWarn = null;
			}
			if (buttonScreenshot != null) {
				buttonScreenshot.Dispose ();
				buttonScreenshot = null;
			}
			if (buttonUTpage != null) {
				buttonUTpage.Dispose ();
				buttonUTpage = null;
			}
			if (checkBoxOffline != null) {
				checkBoxOffline.Dispose ();
				checkBoxOffline = null;
			}
			if (checkBoxUserInfo != null) {
				checkBoxUserInfo.Dispose ();
				checkBoxUserInfo = null;
			}
			if (editTextLoggerMessage != null) {
				editTextLoggerMessage.Dispose ();
				editTextLoggerMessage = null;
			}
		}
	}
}
