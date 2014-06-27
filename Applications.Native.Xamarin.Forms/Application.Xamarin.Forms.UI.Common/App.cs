using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

using Application.XamarinForms.UI.Common;

namespace Application.XamarinForms.UI.Common
{
	public class App
	{
		public static Page GetMainPage()
		{
			return 
				//new UberTestersTestUI ()
				UberTestersPage()
				;
		}
	}
}
