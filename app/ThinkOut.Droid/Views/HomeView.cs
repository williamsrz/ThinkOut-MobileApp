using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;
using ThinkOut.ViewModels;
using Android.Views;

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

			SetActionBar(false, true);
		}

		public override bool OnCreateOptionsMenu(IMenu menu)
		{
			MenuInflater.Inflate(Resource.Menu.ideas, menu);
			return base.OnCreateOptionsMenu(menu);
		}

		public override bool OnOptionsItemSelected(IMenuItem item)
		{
			if (item.ItemId == Resource.Id.ideas_list_action) {
				ViewModel.GotoIdeasCommand.Execute();
			}

			return base.OnOptionsItemSelected(item);
		}
	}
}