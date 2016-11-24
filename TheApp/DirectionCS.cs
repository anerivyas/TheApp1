using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace TheApp
{
	public class DirectionCS : ContentPage
	{
		public DirectionCS()
		{

			var map = new theMap
			{
				MapType = MapType.Street,
				WidthRequest = App.Width,
				HeightRequest = App.Height
			};

			var pin = new thePin
			{
				Pin = new Pin
				{
					Type = PinType.Place,
					Position = new Position(37.79752, -122.40183),
					Label = "Xamarin San Francisco Office",
					Address = "394 Pacific Ave, San Francisco CA"
				},
				id = "Xamarin",
				Url = "http://xamarin.com/about/"
			};

			map.thePin = new List<thePin> { pin };
			map.Pins.Add(pin.Pin);
			map.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(37.79752, -122.40183), Distance.FromMiles(1.0)));

			Content = map;

			var button = new Button
			{
				Text = "Hours",
				VerticalOptions = LayoutOptions.CenterAndExpand
			};
			button.Clicked += HoursButtonClicked;

			Title = "This Week";
			Content = new StackLayout
			{
				Children = {
					new Label {
						Text = "This week's appointments go here",
						HorizontalOptions = LayoutOptions.Center,
						VerticalOptions = LayoutOptions.CenterAndExpand
					},
					button
				}
			};
		}

		async void HoursButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Hours());
		}
	}
}
