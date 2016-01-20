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
	[Register ("IdeasTableViewCell")]
	partial class IdeasTableViewCell
	{
		[Outlet]
		UIKit.UILabel ideaDateLabel { get; set; }

		[Outlet]
		UIKit.UILabel ideaTextLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ideaTextLabel != null) {
				ideaTextLabel.Dispose ();
				ideaTextLabel = null;
			}

			if (ideaDateLabel != null) {
				ideaDateLabel.Dispose ();
				ideaDateLabel = null;
			}
		}
	}
}
