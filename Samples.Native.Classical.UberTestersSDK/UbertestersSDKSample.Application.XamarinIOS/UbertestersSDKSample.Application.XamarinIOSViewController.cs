using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace UbertestersSDKSample.Application.XamarinIOS
{
	public partial class UbertestersSDKSample_Application_XamarinIOSViewController : UIViewController
	{
		static bool UserInterfaceIdiomIsPhone
		{
			get
			{
				return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone;
			}
		}

		public UbertestersSDKSample_Application_XamarinIOSViewController (IntPtr handle) : base (handle)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		#region View lifecycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}

		#endregion

		partial void buttonLoggerInfo_TouchUpInside (UIButton sender)
		{
			string message = "";
			message = editTextLoggerMessage.Text;

			UbertestersSDK.Ubertesters ut = new UbertestersSDK.Ubertesters();
			ut.UTLog(message, UbertestersSDK.UTLogLevel.Info);

			return;
		}

		partial void buttonLoggerWarn_TouchUpInside (UIButton sender)
		{
			string message = "";
			message = editTextLoggerMessage.Text;

			UbertestersSDK.Ubertesters ut = new UbertestersSDK.Ubertesters();
			ut.UTLog(message, UbertestersSDK.UTLogLevel.Warning);

			return;
		}

		partial void buttonLoggerError_TouchUpInside (UIButton sender)
		{
			string message = "";
			message = editTextLoggerMessage.Text;

			UbertestersSDK.Ubertesters ut = new UbertestersSDK.Ubertesters();
			ut.UTLog(message, UbertestersSDK.UTLogLevel.Error);

			return;
		}


		partial void buttonScreenshot_TouchUpInside (UIButton sender)
		{
			UbertestersSDK.Ubertesters.Shared.MakeScreenshot();

			return;
		}


	}
}

