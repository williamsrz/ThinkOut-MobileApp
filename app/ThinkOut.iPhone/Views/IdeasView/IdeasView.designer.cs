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
	[Register ("IdeasView")]
	partial class IdeasView
	{
		[Outlet]
		UIKit.UITableView ideasTableView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ideasTableView != null) {
				ideasTableView.Dispose ();
				ideasTableView = null;
			}
		}
	}
}
