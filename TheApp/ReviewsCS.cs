using System;

using Xamarin.Forms;

namespace TheApp
{
	public class ReviewsCS : ContentPage
	{
		public ReviewsCS()
		{
			Title = "Reviews";
			Content = new StackLayout
			{
				Children = {
					new Label {
						Text = "Reviews go here of all the customers",
						HorizontalOptions = LayoutOptions.Center,
						VerticalOptions = LayoutOptions.CenterAndExpand
					}
				}
			};
		}
	}
}

