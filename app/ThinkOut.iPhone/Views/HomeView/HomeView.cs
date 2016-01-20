using System;
using UIKit;
using Cirrious.MvvmCross.Binding.Touch.Views;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.Binding.BindingContext;
using ThinkOut.ViewModels;

namespace ThinkOut.iPhone
{
	public partial class HomeView : MvxViewController
	{
		public HomeViewModel VM { 
			get { return base.ViewModel as HomeViewModel; } 
		}

		public HomeView()
			: base("HomeView", null)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

			if (VM == null)
				return;

			Title = VM.Title;

			var set = this.CreateBindingSet<HomeView, HomeViewModel>();
			set.Bind(ideaLabel).For(l => l.Text).To(vm => vm.ActionMessage);
			set.Bind(ideaTextField).To(vm => vm.IdeaText);
			set.Bind(sendButton).To(vm => vm.SaveCommand);
			set.Apply();

		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


