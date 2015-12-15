
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

            var items = (ObservableCollection<IdeaViewModel>)ItemsSource;


            //bool isFirstItem = (position == 0 || items[position].Category != items[position - 1].Category);


            //view.FindViewById<RelativeLayout>(Resource.Id.group).Visibility = isFirstItem ? ViewStates.Visible : ViewStates.Gone;

//            view.FindViewById<TextView>(Resource.Id.goalGroupDetailItemTxtRoutineCategory).Text = items[position].Category;
//            view.FindViewById<TextView>(Resource.Id.goalGroupDetailItemTxtRoutineName).Text = items[position].Name; 
//            view.FindViewById<TextView>(Resource.Id.goalGroupDetailItemTxtRoutineDescription).Text = items[position].Description; 


            return view;
        }



    }
}

