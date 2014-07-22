using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using UbertestersSDK;
//using Ubertesters.Sdk;
using UbertestersSDKSample;

namespace SampleUbertestersSDK
{
	[Activity (Label = "Ubertesters Sample", MainLauncher = true)]
	public partial class MainActivity : Activity
	{
		Button buttonLoggerInfo = null;
		Button buttonLoggerWarn = null;
		Button buttonLoggerError = null;
		EditText editTextLoggerMessage = null;

		Button buttonScreenshot = null;

		Button buttonUTpage = null;

		CheckBox checkBoxOffline = null;
		CheckBox checkBoxUserInfo = null;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);


			editTextLoggerMessage = FindViewById<EditText> (Resource.Id.editTextLoggerMessage);
			buttonLoggerInfo = FindViewById<Button> (Resource.Id.buttonLoggerInfo);
			buttonLoggerWarn = FindViewById<Button> (Resource.Id.buttonLoggerWarn);
			buttonLoggerError = FindViewById<Button> (Resource.Id.buttonLoggerError);

			buttonUTpage = FindViewById<Button> (Resource.Id.buttonUTpage);
			buttonScreenshot = FindViewById<Button> (Resource.Id.buttonScreenshot);

			buttonLoggerInfo.Click += buttonLoggerInfo_Click;
			buttonLoggerWarn.Click += buttonLoggerWarn_Click;
			buttonLoggerError.Click += buttonLoggerError_Click;

			buttonUTpage.Click += buttonUTPage_Click;
			buttonScreenshot.Click += buttonScreenshot_Click;
		}
	}
}


