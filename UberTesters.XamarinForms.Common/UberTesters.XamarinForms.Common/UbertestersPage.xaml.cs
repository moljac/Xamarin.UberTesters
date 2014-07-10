using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UberTesters.XamarinForms.Common
{	
	public partial class UbertestersPage : ContentPage
	{	
		public UbertestersPage ()
		{
			InitializeComponent ();
		}

		protected async void buttonInfo_Clicked (object sender, EventArgs ea)
		{
			Ubertesters.Logger().Info("Info");

			return;
		}

		protected async void buttonWarn_Clicked (object sender, EventArgs ea)
		{
			Ubertesters.Logger().Warn("Warn");

			return;
		}

		protected async void buttonError_Clicked (object sender, EventArgs ea)
		{
			Ubertesters.Logger().Warn("Error");

			return;
		}

		protected async void buttonScreenshotTake_Clicked (object sender, EventArgs ea)
		{
			return;
		}

		protected async void buttonUbertestersPageShow_Clicked (object sender, EventArgs ea)
		{
			return;
		}
	}
}

