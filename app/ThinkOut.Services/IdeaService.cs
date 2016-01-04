using System;
using System.Linq;
using System.Threading.Tasks;
using ThinkOut.Models;
using System.Collections.Generic;
using Microsoft.WindowsAzure.MobileServices;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace ThinkOut.Services
{
	public class IdeaService : IIdeaService
	{
		public IdeaService()
		{
		}

		public async Task<Idea> GetIdea(string id)
		{
			var idea = new Idea();

			try {

				using (var client = new MobileServiceClient(Keys.ApplicationURL)) {
					var table = client.GetTable<Idea>();
					idea = await table.LookupAsync(id);
				}

			} catch (Exception ex) {
				Debug.WriteLine(ex);
			}

			return idea;
		}

		public async Task<ObservableCollection<Idea>> GetIdeasAsync()
		{
			var ideas = new ObservableCollection<Idea>();

			try {
				
				using (var client = new MobileServiceClient(Keys.ApplicationURL)) {
					var table = client.GetTable<Idea>();
					ideas = await table.ToCollectionAsync();	
				}
		
			} catch (Exception ex) {
				Debug.WriteLine(ex);
			}

			return ideas;
		}

		public async Task AddIdeaAsync(Idea idea)
		{
			try {
			
				using (var client = new MobileServiceClient(Keys.ApplicationURL)) {
					var table = client.GetTable<Idea>();
					await table.InsertAsync(idea);
				}

			} catch (Exception ex) {
				HandleError(ex);
			}
		}

		private void HandleError(Exception ex)
		{
			//TODO: handle error more efficiently
			Debug.WriteLine(ex);
		}
	}
}
