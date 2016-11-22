using System;

using Xamarin.Forms;

namespace TheApp
{
	public class MainCS : TabbedPage
	{
		public MainCS()
		{
			var navigation = new NavigationPage(new DirectionCS());
			navigation.Title = "Directions";

			Children.Add(new FoodMenuCS());
			Children.Add(navigation);
			Children.Add(new Reviews());
		}
	}
}

