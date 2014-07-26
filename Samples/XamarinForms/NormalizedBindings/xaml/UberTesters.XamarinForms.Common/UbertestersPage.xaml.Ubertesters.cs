using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace UberTesters.XamarinForms.Common
{	
	public partial class UbertestersPage 
	{
		IUberTesters ubertesters;

		public UbertestersPage(IUberTesters ut)
			: this()
		{

			ubertesters = ut;

			return;
		}

		protected async void buttonInfo_Clicked(object sender, EventArgs ea)
		{
			DependencyService.Get<IUberTesters>().Info("Info: " + editMessage.Text);

			return;
		}

		protected async void buttonWarn_Clicked(object sender, EventArgs ea)
		{
			DependencyService.Get<IUberTesters>().Warn("Warn: " + editMessage.Text);

			return;
		}

		protected async void buttonError_Clicked(object sender, EventArgs ea)
		{
			DependencyService.Get<IUberTesters>().Error("Error: " + editMessage.Text);

			return;
		}

		protected async void buttonScreenshotTake_Clicked(object sender, EventArgs ea)
		{
			DependencyService.Get<IUberTesters>().TakeScreenshot();

			return;
		}

		protected async void buttonUbertestersPageShow_Clicked(object sender, EventArgs ea)
		{
			string text = buttonUbertestersPageShow.Text;

			if (text.Contains("Show"))
			{
				// to open Ubertesters page; 
				//Ubertesters.ShowUtPage (); 
				//ubertesters_normalized.ShowUtPage();
				DependencyService.Get<IUberTesters>().ShowUtPage();

				buttonUbertestersPageShow.Text.Replace("Show", "Hide");
			}
			else if (text.Contains("Hide"))
			{
				// to close Ubertesters page; 
				//Ubertesters.HideUtPage (); 
				//ubertesters_normalized.HideUtPage();
				DependencyService.Get<IUberTesters>().HideUtPage();

				buttonUbertestersPageShow.Text.Replace("Hide", "Show");
			}

			return;
		}
	}
}
