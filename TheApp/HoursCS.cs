using System;

using Xamarin.Forms;

namespace TheApp
{
	public class HoursCS : ContentPage
	{
		public HoursCS()
		{
			var backbutton = new Button
			{
				Text = "Back",
				VerticalOptions = LayoutOptions.CenterAndExpand
			};
			backbutton.Clicked += BackButtonClicked;

			Title = "Hours";
			Content = new StackLayout
			{
				Children = {
					new Label {
						Text = "Our opening hours are",
						HorizontalOptions = LayoutOptions.Center,
						VerticalOptions = LayoutOptions.CenterAndExpand
					},
					backbutton
				}
			};
		}

		async void BackButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PopAsync();
		}
	}
}

