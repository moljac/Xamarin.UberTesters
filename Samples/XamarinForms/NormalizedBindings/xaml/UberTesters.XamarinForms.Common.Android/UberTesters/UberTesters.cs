using System;

[assembly: Xamarin.Forms.Dependency (typeof (UberTesters.XamarinForms.XamarinAndroid.UberTesters))]

namespace UberTesters.XamarinForms.XamarinAndroid
{
	public class UberTesters : global::UberTesters.XamarinForms.IUberTesters
	{
		public UberTesters ()
		{
			// in Application Object
			//UbertestersSDK.Ubertesters.Initialize
			//			(
			//			  //Context
			//			, UbertestersSDK.Common.Models.LockingMode.LockingModeLockAppIfBuildNotExist
			//			);
		
				// to allow sending information about user actions (touch, click, etc.); 
				//UbertestersSDK.Ubertesters.IsIgnored = false;
				//to allow working with application without connection to server;
				UbertestersSDK.Ubertesters.SetOfflineModeEnabled (true);
		}

		public void SetOfflineModeEnabled (bool offline)
		{
			return;
		}
			
		public void Info (string message)
		{
			message = "Info " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " : " + message;
			UbertestersSDK.Ubertesters.Logger().Info(message); 

			return;
		}

		public void Warn (string message)
		{
			message = "Warn " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " : " + message;
			UbertestersSDK.Ubertesters.Logger().Warn(message);

			return;
		}

		public void Error (string message)
		{
			message = "Error " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " : " + message;
			UbertestersSDK.Ubertesters.Logger().Error(message);

			return;
		}

		public void ShowUtPage ()
		{
			UbertestersSDK.Ubertesters.ShowUtPage();

			return;
		}

		public void HideUtPage ()
		{
			UbertestersSDK.Ubertesters.HideUtPage();

			return;
		}

		public void TakeScreenshot()
		{
			UbertestersSDK.Ubertesters.TakeScreenshot();

			return;
		}
	}
}

