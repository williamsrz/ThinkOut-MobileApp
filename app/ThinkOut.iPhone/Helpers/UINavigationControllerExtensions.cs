using System;
using UIKit;

namespace ThinkOut.iPhone
{
	public static class UINavigationControllerExtensions
	{
		public static void PushControllerWithTransition(this UINavigationController 
			target, UIViewController controllerToPush, UIViewAnimationOptions transition)
		{
			UIView.Transition(target.View, 0.75d, transition, delegate() {
				target.PushViewController(controllerToPush, false);
			}, null);
		}
	}
}

