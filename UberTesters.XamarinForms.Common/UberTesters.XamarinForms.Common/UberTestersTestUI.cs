using System;
using Xamarin.Forms;

namespace UberTesters.XamarinForms.Common
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

			PageAsStackLayout();

			var layout = new StackLayout
			{
				Orientation = StackOrientation.Vertical,
				Padding = 20
			};

			var grid = new Grid
			{
				RowSpacing = 50
			};

			grid.Children.Add(new Label { Text = "This" }, 0, 0); // Left, First element
			grid.Children.Add(new Label { Text = "text is" }, 1, 0); // Right, First element
			grid.Children.Add(new Label { Text = "in a" }, 0, 1); // Left, Second element
			grid.Children.Add(new Label { Text = "grid!" }, 1, 1); // Right, Second element

			int count = 0;
			var gridButton = new Button { Text = "So is this Button! Click me." };
			gridButton.Clicked += delegate
			{
				gridButton.Text = string.Format("Thanks! {0} clicks.", count++);
			};
			grid.Children.Add(gridButton, 0, 2); // Left, Third element

			layout.Children.Add(grid);
			Content = layout;
			var layout1 = new StackLayout
			{
				Orientation = StackOrientation.Vertical,
				Padding = 20
			};

			var grid1 = new Grid
			{
				RowSpacing = 50
			};


			var grid2 = new Grid
			{
				RowSpacing = 50
			};

			grid1.Children.Add(new Label { Text = "This" }, 0, 0); // Left, First element
			grid1.Children.Add(new Label { Text = "text is" }, 1, 0); // Right, First element
			grid1.Children.Add(new Label { Text = "in a" }, 0, 1); // Left, Second element
			grid1.Children.Add(new Label { Text = "grid!" }, 1, 1); // Right, Second element

			var gridButton1 = new Button { Text = "So is this Button! Click me." };
			gridButton1.Clicked += delegate
			{
				gridButton1.Text = string.Format("Thanks! {0} clicks.", count++);
			};
			grid.Children.Add(gridButton, 0, 2); // Left, Third element

			layout.Children.Add(grid);
			Content = layout;
			grid.Children.Add(new Label { Text = "This" }, 0, 0); // Left, First element
			grid.Children.Add(new Label { Text = "text is" }, 1, 0); // Right, First element
			grid.Children.Add(new Label { Text = "in a" }, 0, 1); // Left, Second element
			grid.Children.Add(new Label { Text = "grid!" }, 1, 1); // Right, Second element

			var gridButton2 = new Button { Text = "So is this Button! Click me." };
			gridButton.Clicked += delegate
			{
				gridButton.Text = string.Format("Thanks! {0} clicks.", count++);
			};
			grid.Children.Add(gridButton, 0, 2); // Left, Third element

			layout.Children.Add(grid);
			Content = layout;

		}

		private void PageAsStackLayout()
		{
			StackLayout stack_layout_logger = new StackLayout()
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

			StackLayout stack_layout_message = new StackLayout()
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


			StackLayout stack_layout_buttons_info_warn_error = new StackLayout()
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


			StackLayout stack_layout_screenshot = new StackLayout()
			{
				Orientation = StackOrientation.Horizontal,
				Children = 
				{
					new Label()
					{
						Text = "Screenshots:"
					}
					, new Button()
					{
					  Text = "Screenshot"
					, HorizontalOptions = LayoutOptions.FillAndExpand
					}
				}
			};

			StackLayout stack_layout_ut_page = new StackLayout()
			{
				Orientation = StackOrientation.Horizontal,
				Children = 
				{
					new Label()
					{
						Text = "UT Page:"
					}
					, new Button()
					{
					  Text = "UT Page - Show"
					, HorizontalOptions = LayoutOptions.FillAndExpand
					}
				}
			};

			StackLayout stack_layout_offline_user_info = new StackLayout()
			{
				Orientation = StackOrientation.Horizontal,
				Children = 
				{
					new Label()
					{
						Text = "Offline:"
					}
					, new Switch()
					{
					}
					//, new SwitchCell()
					//{
					//	Text = "User Information:"
					//}
					, new Label()
					{
						Text = "Offline:"
					}
					, new Switch()
					{
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
				, stack_layout_screenshot
				, stack_layout_ut_page
				, stack_layout_offline_user_info
				}
			};
		}
	}
}

