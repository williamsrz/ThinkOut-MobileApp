// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace ThinkOut.iPhone
{
	[Register ("HomeView")]
	partial class HomeView
	{
		[Outlet]
		UIKit.UILabel ideaLabel { get; set; }

		[Outlet]
		UIKit.UITextField ideaTextField { get; set; }

		[Outlet]
		UIKit.UIButton sendButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ideaLabel != null) {
				ideaLabel.Dispose ();
				ideaLabel = null;
			}

			if (ideaTextField != null) {
				ideaTextField.Dispose ();
				ideaTextField = null;
			}

			if (sendButton != null) {
				sendButton.Dispose ();
				sendButton = null;
			}
		}
	}
}
