using Cirrious.MvvmCross.ViewModels;
using System.Threading.Tasks;
using ThinkOut.Models;
using ThinkOut.Services;
using Cirrious.CrossCore;

namespace ThinkOut.ViewModels
{
	public class HomeViewModel : BaseViewModel
	{
		private readonly IIdeaService _ideaService;

		private Idea Model;
		private string _idea;
		private string _actionMessage = "Qual é a sua ideia?";
		private string _saveText = "Compartilhar";
		private IMvxCommand _saveCommand;
		private IMvxCommand _gotoIdeasCommand;

		private bool _isAddingNew;

		public string IdeaText { 
			get { return _idea; }
			set {
				_idea = value;
				RaisePropertyChanged(() => IdeaText);
			}
		}

		public string ActionMessage {
			get { return _actionMessage; }
			set { 
				_actionMessage = value;
				RaisePropertyChanged(() => ActionMessage);
			}
		}

		public string SaveText {
			get { return _saveText; }
			set { 
				_saveText = value;
				RaisePropertyChanged(() => SaveText);
			}
		}

		public IMvxCommand SaveCommand {
			get {
				_saveCommand = _saveCommand ?? new MvxCommand(async () => await ExecuteSaveCommand());
				return _saveCommand;
			}
		}

		public IMvxCommand GotoIdeasCommand {
			get {
				_gotoIdeasCommand = _gotoIdeasCommand ?? new MvxCommand(() => ShowViewModel<IdeasViewModel>());
				return _gotoIdeasCommand;
			}
		}

		public bool IsAddingNew {
			get { return _isAddingNew; }
			set {
				if (SetProperty(ref _isAddingNew, value)) {
					RaisePropertyChanged(() => IsAddingNew);
				}
			}
		}

		public HomeViewModel(IIdeaService ideaService)
		{
			Title = "ThinkOut";
			_ideaService = ideaService;
		}

		private async Task ExecuteSaveCommand()
		{
			IsAddingNew = true;

			var idea = new Idea {
				Text = IdeaText
			};

			await _ideaService.AddIdeaAsync(idea);

			GotoIdeasCommand.Execute();

			IsAddingNew = false;
			IdeaText = string.Empty;

			RaisePropertyChanged();
		}
	}
}
