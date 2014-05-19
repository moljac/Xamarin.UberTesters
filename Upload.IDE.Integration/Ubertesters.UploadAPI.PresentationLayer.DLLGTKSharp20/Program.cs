using System;
using Gtk;

namespace Ubertesters.Upload.PresentationLayer.DLLGTKSharp20
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			MainWindow win = new MainWindow ();
			win.Show ();
			Application.Run ();
		}
	}
}
