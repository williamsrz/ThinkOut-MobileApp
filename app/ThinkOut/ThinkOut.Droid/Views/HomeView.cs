using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;
using ThinkOut.ViewModels;

namespace ThinkOut.Droid.Views
{
    [Activity]
    public class HomeView : BaseView<HomeViewModel>
    {
        public HomeView()
            : base(Resource.Layout.HomeView)
        {
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
        }
    }
}