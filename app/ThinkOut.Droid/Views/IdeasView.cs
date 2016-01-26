
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ThinkOut.ViewModels;

namespace ThinkOut.Droid
{
	[Activity]            
	public class IdeasView : BaseView<IdeasViewModel>
	{
		public IdeasView()
			: base(Resource.Layout.IdeasView)
		{
		}

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			SetActionBar();
			// Create your application here
		}

		public override bool OnOptionsItemSelected(IMenuItem item)
		{
			if (item.ItemId == Android.Resource.Id.Home) {
				Finish();
				return true;
			}

			return base.OnOptionsItemSelected(item);
		}
	}
}

