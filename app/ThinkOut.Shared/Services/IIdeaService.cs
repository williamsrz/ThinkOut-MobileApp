
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using ThinkOut.Shared.Models;

namespace ThinkOut.Shared.Services
{
    public interface IIdeaService
    {
        Task<Idea> GetIdea(string id);

        Task<ObservableCollection<Idea>> GetIdeasAsync();

        Task AddIdeaAsync(Idea idea);
    }

    public class IdeaService : IIdeaService
    {
        public Task AddIdeaAsync(Idea idea)
        {
            throw new System.NotImplementedException();
        }

        public Task<Idea> GetIdea(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<ObservableCollection<Idea>> GetIdeasAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}

