using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace TheApp.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();
			Xamarin.FormsMaps.Init();

			App.Width = UIScreen.MainScreen.Bounds.Width;
			App.Height = UIScreen.MainScreen.Bounds.Height;

			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}

	}

}
