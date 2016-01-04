using Cirrious.CrossCore.IoC;
using ThinkOut.ViewModels;
using Cirrious.CrossCore;
using ThinkOut.Services;

namespace ThinkOut.ViewModels
{
	public class App : Cirrious.MvvmCross.ViewModels.MvxApplication
	{
		public override void Initialize()
		{
			CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

			Mvx.LazyConstructAndRegisterSingleton<IIdeaService, IdeaService>(); 
				
			RegisterAppStart<HomeViewModel>();
		}
	}
}