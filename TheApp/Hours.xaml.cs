using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TheApp
{
	public partial class Hours : ContentPage
	{
		public Hours()
		{
			InitializeComponent();
		}

		async void BackButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PopAsync();
		}
	}

}
