using System;
using Cirrious.MvvmCross.Touch.Views.Presenters;
using UIKit;
using ThinkOut.ViewModels;
using System.Linq;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.ViewModels;

namespace ThinkOut.iPhone
{
	public class CustomPresenter : MvxModalSupportTouchViewPresenter
	{
		public CustomPresenter(UIApplicationDelegate applicationDelegate, UIWindow window)
			: base(applicationDelegate, window)
		{

		}

		public override void Close(Cirrious.MvvmCross.ViewModels.IMvxViewModel toClose)
		{   
			var lastView = this.MasterNavigationController.ViewControllers.ToList().Where(x => x != this.MasterNavigationController.VisibleViewController).LastOrDefault();

			if (lastView != null) {
				var lastViewController = lastView as MvxViewController;
				if (lastViewController != null) {
					var lastViewModel = lastViewController.ViewModel as IHandlesResult;

					if (lastViewModel != null) {
						lastViewModel.HandlesResult(toClose);
					}
				}
			}

			base.Close(toClose);
		}

		public override void Show(MvxViewModelRequest request)
		{
			if (request.PresentationValues != null) {
				
				if (request.PresentationValues.ContainsKey(PresentationBundleFlagKeys.ClearStack)) {
					foreach (var vc in MasterNavigationController.ViewControllers) {
						vc.DismissViewController(true, null);
					}    

					var nextViewController = this.CreateViewControllerFor(request) as UIViewController;

					if (MasterNavigationController.TopViewController.GetType() != nextViewController.GetType()) {
						MasterNavigationController.PopToRootViewController(false);
						MasterNavigationController.PushViewController(nextViewController, false);
					}

					return;
				}

				if (request.PresentationValues.ContainsKey(PresentationBundleFlagKeys.NoAnimation)) {

					var nextViewController = this.CreateViewControllerFor(request) as UIViewController;
					MasterNavigationController.PushViewController(nextViewController, false);


					return;
				}

				if (request.PresentationValues.ContainsKey(PresentationBundleFlagKeys.TransitionLeftToRight)) {

					var nextViewController = this.CreateViewControllerFor(request) as UIViewController;
					MasterNavigationController.PushControllerWithTransition(nextViewController, UIViewAnimationOptions.TransitionCurlDown);


					return;
				}
			}
			base.Show(request);
		}

		public override void CloseModalViewController()
		{
			base.CloseModalViewController();
		}

		public override void ChangePresentation(Cirrious.MvvmCross.ViewModels.MvxPresentationHint hint)
		{
			base.ChangePresentation(hint);
		}
	}
}

