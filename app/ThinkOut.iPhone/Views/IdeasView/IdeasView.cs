using System;

using UIKit;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Binding.Touch.Views;
using ThinkOut.ViewModels;


namespace ThinkOut.iPhone
{
	public partial class IdeasView : MvxViewController
	{
		public IdeasViewModel VM {
			get { return base.ViewModel as IdeasViewModel; }
		}

		public IdeasView()
			: base("IdeasView", null)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

			if (VM == null)
				return;

			Title = VM.Title;
		
			var source = new IdeasTableViewSource(ideasTableView);
			ideasTableView.Source = source;

			var set = this.CreateBindingSet<IdeasView, IdeasViewModel>();
			set.Bind(source).To(vm => vm.IdeasVMs);
			set.Apply();

			ideasTableView.ReloadData();
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


