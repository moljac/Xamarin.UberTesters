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
	public class MainActivity : Activity
	{
		Button buttonLoggerInfo = null;
		Button buttonLoggerWarn = null;
		Button buttonLoggerError = null;
		EditText editTextLoggerMessage = null;

		Button buttonScreenshot = null;

		Button buttonUTpage = null;

		CheckBox checkBoxOffline = null;
		CheckBox checkBoxUserInfo = null;

		UberTesters.XamarinForms.XamarinAndroid.UberTesters ubertesters_normalized;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);


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


			ubertesters_normalized = new UberTesters.XamarinForms.XamarinAndroid.UberTesters();

			//button.Click += delegate
			{

				// to allow sending information about user actions (touch, click, etc.); 
				Ubertesters.IsIgnored = false;
				//to allow working with application without connection to server;
				Ubertesters.SetOfflineModeEnabled (true);

			};


		}


		void buttonLoggerInfo_Click (object sender, EventArgs e)
		{
			//Ubertesters.Logger().Info("Info");
			ubertesters_normalized.Info("Info");

			return;
		}

		void buttonLoggerWarn_Click (object sender, EventArgs e)
		{
			//Ubertesters.Logger().Warn("Warn");
			ubertesters_normalized.Warn("Warn");

			return;
		}

		void buttonLoggerError_Click (object sender, EventArgs e)
		{
			//Ubertesters.Logger().Error("Error");
			ubertesters_normalized.Error("Error");

			return;
		}

		void buttonUTPage_Click (object sender, EventArgs e)
		{
			string text = buttonUTpage.Text;

			if (text.Contains ("Show"))
			{
				// to open Ubertesters page; 
				//Ubertesters.ShowUtPage (); 
				ubertesters_normalized.ShowUtPage();

				buttonUTpage.Text.Replace ("Show", "Hide");
			}
			else if (text.Contains ("Hide"))
			{
				// to close Ubertesters page; 
				//Ubertesters.HideUtPage (); 
				ubertesters_normalized.HideUtPage();

				buttonUTpage.Text.Replace ("Hide", "Show");
			}

			return;
		}

		void buttonScreenshot_Click (object sender, EventArgs e)
		{
			//to take screenshot; 
			//Ubertesters.TakeScreenshot(); 
			ubertesters_normalized.TakeScreenshot();

			return;
		}
	}
}


