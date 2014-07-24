using System;

namespace UberTesters.XamarinForms
{
	public interface IUberTesters
	{
		void 	SetOfflineModeEnabled(bool offline);

		void 	Info(string message);
		void 	Warn(string message);
		void 	Error(string message);

		void 	ShowUtPage();
		void 	HideUtPage();

		void 	TakeScreenshot();
	}
}

