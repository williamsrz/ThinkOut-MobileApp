using System;
using ThinkOut.Models;

namespace ThinkOut.ViewModels
{
	public class IdeaViewModel : BaseViewModel
	{
		private Idea Model;

		public string IdeaId {
			get {
				return Model.Id;
			}
		}

		public string IdeaText {
			get { return Model.Text; }
			set {
				Model.Text = value;
				RaisePropertyChanged(() => IdeaText);
			}
		}

		public DateTime IdeaCreatedAtDate {
			get { return DateTime.Now; }
			set {
//				Model.CreatedAt = value;
				RaisePropertyChanged(() => IdeaCreatedAtDate);
			}
		}

		public IdeaViewModel(Idea model)
		{
			Model = model;
		}
	}
}

