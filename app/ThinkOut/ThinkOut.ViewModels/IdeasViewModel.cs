using System;
using ThinkOut.Services;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Linq;

namespace ThinkOut.ViewModels
{
    public class IdeasViewModel : BaseViewModel
    {
        private IIdeaService _ideaService;
        private ObservableCollection<IdeaViewModel> _ideasVM;

        public ObservableCollection<IdeaViewModel> IdeasVMs
        { 
            get { return _ideasVM; }
            set { RaisePropertyChanged(() => IdeasVMs); }
        }

        public IdeasViewModel(IIdeaService ideaService)
        {
            _ideaService = ideaService;
            _ideasVM = new ObservableCollection<IdeaViewModel>();
        }

        public async Task Init()
        {
            var ideas = await _ideaService.GetIdeasAsync();

            _ideasVM = ideas.Select(i => new IdeaViewModel(i))
                .ToObservableCollection();

            RaiseAllPropertiesChanged();
        }
    }
}

