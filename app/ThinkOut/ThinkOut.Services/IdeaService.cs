using System;
using System.Linq;
using System.Threading.Tasks;
using ThinkOut.Models;
using System.Collections.Generic;

namespace ThinkOut.Services
{
    public class IdeaService : IIdeaService
    {
        private List<Idea> _ideas;

        public IdeaService()
        {
            _ideas = new List<Idea>
            {
                new Idea
                { 
                    Id = "1",
                    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec mi massa, semper vitae accumsan at, sagittis id diam. Morbi non.",
                    CreatedAt = DateTime.Now,    
                },
                new Idea
                { 
                    Id = "2",
                    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec mi massa, semper vitae accumsan at, sagittis id diam. Morbi non.",
                    CreatedAt = DateTime.Now,    
                },
                new Idea
                { 
                    Id = "3",
                    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec mi massa, semper vitae accumsan at, sagittis id diam. Morbi non.",
                    CreatedAt = DateTime.Now,    
                },
                new Idea
                { 
                    Id = "4",
                    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec mi massa, semper vitae accumsan at, sagittis id diam. Morbi non.",
                    CreatedAt = DateTime.Now,    
                },
                new Idea
                { 
                    Id = "5",
                    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec mi massa, semper vitae accumsan at, sagittis id diam. Morbi non.",
                    CreatedAt = DateTime.Now,    
                },
                new Idea
                { 
                    Id = "6",
                    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec mi massa, semper vitae accumsan at, sagittis id diam. Morbi non.",
                    CreatedAt = DateTime.Now,    
                }

            };
        }

        public async Task<Idea> GetIdea(string id)
        {
            return await Task.Factory.StartNew(() =>
                _ideas
                .FirstOrDefault(i => i.Id == id)
            );
        }

        public async Task<List<Idea>> GetIdeasAsync()
        {
            return await Task.Factory.StartNew(() =>
                _ideas
                .OrderByDescending(i => i.CreatedAt)
                .ToList()
            );
        }

        public async Task AddIdea(Idea idea)
        {
            idea.CreatedAt = DateTime.Now;

            await Task.Factory.StartNew(() =>
                _ideas.Add(idea)
            );
        }
          
    }
}

