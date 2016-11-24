using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TheApp
{
	public partial class Reviews : ContentPage
	{

		public Reviews()
		{
			InitializeComponent();

			var l = new Label
			{
				Text = "Press link below to view reviews",
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand,
				TextColor = Color.FromHex("#92CD00")
			};

			var openUrl = new Button
			{
				Text = "Fabrikam Food reviews link"
			};
			openUrl.Clicked += (sender, e) =>
			{
				if (Device.OS != TargetPlatform.WinPhone)
				{
					Device.OpenUri(new Uri("https://www.google.co.nz/?gfe_rd=cr&ei=DWc3WPiAIKju8weF-qHQBA&gws_rd=ssl"));
				}
				else
				{
					DisplayAlert("To Do", "Not implemented yet", "OK");
				}
			};



			Content = new StackLayout
			{
				Padding = new Thickness(5, 20, 5, 0),
				HorizontalOptions = LayoutOptions.Fill,
				Children = {
					l,
					openUrl
				}
			};
		}


	}
}