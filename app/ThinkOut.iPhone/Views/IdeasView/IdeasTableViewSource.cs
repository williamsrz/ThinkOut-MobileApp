using System;
using Cirrious.MvvmCross.Binding.Touch.Views;
using Foundation;
using UIKit;

namespace ThinkOut.iPhone
{
	public class IdeasTableViewSource : MvxTableViewSource
	{
		private const string _cellNibName = "IdeasTableViewCell";
		private static readonly NSString _cellIdentifier = new NSString(_cellNibName);


		public IdeasTableViewSource(UITableView tableView)
			: base(tableView)
		{
			TableView.RegisterNibForCellReuse(UINib.FromName(_cellNibName, NSBundle.MainBundle), _cellIdentifier);
		}


		#region implemented abstract members of MvxBaseTableViewSource

		protected override UITableViewCell GetOrCreateCellFor(UITableView tableView, NSIndexPath indexPath, object item)
		{
			var cell = TableView.DequeueReusableCell(_cellIdentifier) as IdeasTableViewCell;
			return cell;
		}

		#endregion

		public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
		{
			base.RowSelected(tableView, indexPath);
			tableView.DeselectRow(indexPath, true);
		}
	}
}

