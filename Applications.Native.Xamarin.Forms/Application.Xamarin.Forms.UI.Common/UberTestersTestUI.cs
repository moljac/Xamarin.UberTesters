using System;
using Xamarin.Forms;

namespace Application.XamarinForms.UI.Common
{
	public class UberTestersTestUI : ContentPage
	{
		public UberTestersTestUI ()
		{
			/*
			Padding = new Thickness(20);
			var red = new Label
			{
				Text = "Stop",
				BackgroundColor = Color.Red,
				Font = Font.SystemFontOfSize (20)
			};
			var yellow = new Label
			{
				Text = "Slow down",
				BackgroundColor = Color.Yellow,
				Font = Font.SystemFontOfSize (20)
			};
			var green = new Label
			{
				Text = "Go",
				BackgroundColor = Color.Green,
				Font = Font.SystemFontOfSize (20)
			};

			Content = new StackLayout
			{
				Spacing = 10,
				Children = { red, yellow, green }
			};
			*/

			StackLayout stack_layout_logger = new StackLayout () 
			{
				Orientation = StackOrientation.Horizontal,
				Children = 
				{
					new Label()
				  {
				   Text = "Logger"
				  }
				}
			};

			StackLayout stack_layout_message = new StackLayout () 
			{
				Orientation = StackOrientation.Horizontal,
				Children = 
				{
					new Label()
					{
						Text = "Message:"
					}
					, new Entry()
					{
						HorizontalOptions = LayoutOptions.FillAndExpand
					}
				}
			};


			StackLayout stack_layout_buttons_info_warn_error = new StackLayout () 
			{
				Orientation = StackOrientation.Horizontal,
				Children = 
				{
					new Button()
					{
					  Text = "Info"
					, HorizontalOptions = LayoutOptions.FillAndExpand
					}
					, new Button()
					{
					  Text = "Warn"
					, HorizontalOptions = LayoutOptions.FillAndExpand
					}
					, new Button()
					{
					  Text = "Error"
					, HorizontalOptions = LayoutOptions.FillAndExpand
					}
				}
			};

			Content = new StackLayout()
			{
				Orientation = StackOrientation.Vertical,
				Children = 
				{
				  stack_layout_logger
				, stack_layout_message
				, stack_layout_buttons_info_warn_error
				}
			};
		}
	}
}

