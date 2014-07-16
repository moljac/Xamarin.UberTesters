using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using Xamarin.Forms.Platform.Android;

namespace UberTesters.XamarinForms.XamarinAndroid
{
	[Activity(Label = "UberTesters.XamarinForms", MainLauncher = true)]
	public class MainActivity : AndroidActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			global::Xamarin.Forms.Forms.Init(this, bundle);

			SetPage(global::UberTesters.XamarinForms.Common.App.GetMainPage());
		}
	}
}

