using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using ThinkOut.Models;

namespace ThinkOut.Services
{
    public interface IIdeaService
    {
        Task<Idea> GetIdea(string id);

        Task<List<Idea>> GetIdeasAsync();

        Task AddIdea(Idea idea);

    }
}

