
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
using ThinkOut.Droid.Helpers.MvvmCross;
using Cirrious.MvvmCross.ViewModels;
using Android.Graphics.Drawables;

namespace ThinkOut.Droid
{
	public class BaseView<T> : MvxActionBarActivity where T : MvxViewModel
	{
		private int _layoutResourceId;

		public T ViewModel {
			get {
				return base.ViewModel as T;
			}
			set {
				base.ViewModel = value;
			}

		}

		public BaseView(int layoutResourceId)
		{        
			_layoutResourceId = layoutResourceId;
		}

		protected override void OnCreate(Bundle bundle)
		{
			RequestedOrientation = Android.Content.PM.ScreenOrientation.Portrait;
			base.OnCreate(bundle);
			SetContentView(_layoutResourceId);
			CustomPresenter.Presenter.ViewModels.Add(this.ViewModel);
		}


		public void SetActionBar(bool setDisplayHomeAsUpEnabled = true, bool setHomeButtonEnabled = true)
		{
			var toolbar = FindViewById <Android.Support.V7.Widget.Toolbar>(Resource.Id.topToolbar);

			if (toolbar != null) {
				SetSupportActionBar(toolbar);
				SupportActionBar.SetDisplayHomeAsUpEnabled(setDisplayHomeAsUpEnabled);
				SupportActionBar.SetHomeButtonEnabled(setHomeButtonEnabled);
			}
		}

	}
}

