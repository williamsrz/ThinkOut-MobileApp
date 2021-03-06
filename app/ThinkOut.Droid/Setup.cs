using Android.Content;
using Cirrious.CrossCore.Platform;
using Cirrious.MvvmCross.Droid.Platform;
using Cirrious.MvvmCross.ViewModels;
using ThinkOut.ViewModels;
using Microsoft.WindowsAzure.MobileServices;

namespace ThinkOut.Droid
{
	public class Setup : MvxAndroidSetup
	{
		public Setup(Context applicationContext)
			: base(applicationContext)
		{
			CurrentPlatform.Init();
		}

		protected override IMvxApplication CreateApp()
		{
			return new App();
		}

		protected override IMvxTrace CreateDebugTrace()
		{
			return new DebugTrace();
		}
	}
}