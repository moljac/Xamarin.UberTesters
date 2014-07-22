using System;

namespace SampleUbertestersSDK
{
	public partial class MainActivity 
	{
		void buttonLoggerInfo_Click (object sender, EventArgs e)
		{
			string message = "";
			message =  "Info: " + editTextLoggerMessage.Text;
			UbertestersSDK.Ubertesters.Logger().Info(message);

			return;
		}

		void buttonLoggerWarn_Click (object sender, EventArgs e)
		{
			string message = "";
			message =  "Warn: " + editTextLoggerMessage.Text;
			UbertestersSDK.Ubertesters.Logger().Warn(message);

			return;
		}

		void buttonLoggerError_Click (object sender, EventArgs e)
		{
			string message = "";
			message =  "Error: " + editTextLoggerMessage.Text;
			UbertestersSDK.Ubertesters.Logger().Error(message);
			return;
		}

		void buttonUTPage_Click (object sender, EventArgs e)
		{
			string text = buttonUTpage.Text;

			if (text.Contains ("Show"))
			{
				// to open Ubertesters page; 
				UbertestersSDK.Ubertesters.ShowUtPage();

				buttonUTpage.Text.Replace ("Show", "Hide");
			}
			else if (text.Contains ("Hide"))
			{
				// to close Ubertesters page; 
				UbertestersSDK.Ubertesters.HideUtPage();

				buttonUTpage.Text.Replace ("Hide", "Show");
			}

			return;
		}

		void buttonScreenshot_Click (object sender, EventArgs e)
		{
			UbertestersSDK.Ubertesters.TakeScreenshot();

			return;
		}
	}
}

