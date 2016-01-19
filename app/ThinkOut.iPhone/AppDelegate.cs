using Foundation;
using UIKit;
using Cirrious.CrossCore;
using Cirrious.MvvmCross.ViewModels;
using Microsoft.WindowsAzure.MobileServices;
using Cirrious.MvvmCross.Touch.Platform;

namespace ThinkOut.iPhone
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
	[Register("AppDelegate")]
	public class AppDelegate : MvxApplicationDelegate
	{
		UIWindow _window;

		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			_window = new UIWindow(UIScreen.MainScreen.Bounds);

			CurrentPlatform.Init();

			var setup = new Setup(this, _window);
			setup.Initialize();

			var startup = Mvx.Resolve<IMvxAppStart>();
			startup.Start();

			_window.MakeKeyAndVisible();

			SetupUiStyles();

			return true;
		}

		private void SetupUiStyles()
		{
			UINavigationBar.Appearance.TintColor = UIColor.White;
			UIApplication.SharedApplication.StatusBarStyle = UIStatusBarStyle.LightContent;

			// Disable check for delegate in event registration: https://forums.xamarin.com/discussion/39470/installed-5-9-build-431-event-registration-is-overwriting-existing-delegate-error
			UIApplication.CheckForEventAndDelegateMismatches = false;
		}
	}
}


