using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using MvvmCross.Forms.Platforms.Android.Views;

namespace ThinkOut.Droid
{
    [Activity(Label = "@string/app_name",
        Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : MvxFormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
        }
    }
}

