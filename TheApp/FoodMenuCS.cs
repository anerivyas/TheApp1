using System;
using System.Collections.Generic;
using Xamarin.Forms;



namespace TheApp
{
	public class FoodMenuCS : ContentPage
	{
		public FoodMenuCS()
		{
			
			Title = "Your Menu";
			Content = new StackLayout
			{
				Children = {
					new Label {
						Text = "The menu goes here",
						HorizontalOptions = LayoutOptions.Center,
						VerticalOptions = LayoutOptions.CenterAndExpand,
						TextColor=Color.FromHex("#92CD00")

					}
				}
			};


		}
	}
}

