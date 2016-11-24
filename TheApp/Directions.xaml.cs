using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace TheApp
{
	public partial class Directions : ContentPage
	{
		public Directions()
		{
			InitializeComponent();


			var pin = new thePin
			{
				Pin = new Pin
				{
					Type = PinType.Place,
					Position = new Position(37.79752, -122.40183),
					Label = "Fabrikam Food Restaurant",
					Address = "8070 Redmond, Washington, USA",

				},
				id = "Xamarin",
				Url = "http://xamarin.com/about/"
				};

			theMap.thePin = new List<thePin> { pin };
			theMap.Pins.Add(pin.Pin);
			theMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(37.79752, -122.40183), Distance.FromMiles(1.0)));


		}


		async void HoursButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Hours());
		}



}

}
