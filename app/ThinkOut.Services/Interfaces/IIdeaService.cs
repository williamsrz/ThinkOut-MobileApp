using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using ThinkOut.Models;
using System.Collections.ObjectModel;

namespace ThinkOut.Services
{
	public interface IIdeaService
	{
		Task<Idea> GetIdea(string id);

		Task<ObservableCollection<Idea>> GetIdeasAsync();

		Task AddIdeaAsync(Idea idea);
	}
}

