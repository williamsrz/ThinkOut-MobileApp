
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
using Cirrious.MvvmCross.Binding.Droid.Views;
using Cirrious.MvvmCross.Binding.Droid.BindingContext;
using System.Collections.ObjectModel;
using ThinkOut.ViewModels;

namespace ThinkOut.Droid
{
	public class IdeaViewAdapter : MvxAdapter
	{
		private Activity _activity;

		public IdeaViewAdapter(Android.Content.Context context, IMvxAndroidBindingContext bindingContext)
			: base(context, bindingContext)
		{
			_activity = context as Activity;
		}

		protected override View GetView(int position, Android.Views.View convertView, Android.Views.ViewGroup parent, int templateId)
		{
			View view = convertView ?? _activity.LayoutInflater.Inflate(Resource.Layout.IdeaItem, null);
			return view;
		}
	}
}