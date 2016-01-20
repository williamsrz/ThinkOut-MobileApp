using System;

using Foundation;
using UIKit;
using Cirrious.MvvmCross.Binding.Touch.Views;
using Cirrious.MvvmCross.Binding.BindingContext;
using ThinkOut.ViewModels;

namespace ThinkOut.iPhone
{
	public partial class IdeasTableViewCell : MvxTableViewCell
	{
		public static readonly NSString Key = new NSString("IdeasTableViewCell");
		public static readonly UINib Nib;

		static IdeasTableViewCell()
		{
			Nib = UINib.FromName("IdeasTableViewCell", NSBundle.MainBundle);
		}

		public IdeasTableViewCell(IntPtr handle)
			: base(handle)
		{
			this.DelayBind(() => {
				var set = this.CreateBindingSet<IdeasTableViewCell, IdeaViewModel>();
				set.Bind(ideaTextLabel).To(vm => vm.IdeaText);
				set.Bind(ideaDateLabel).To(vm => vm.IdeaCreatedAtDate);
				set.Apply();
			});
		}
	}
}
