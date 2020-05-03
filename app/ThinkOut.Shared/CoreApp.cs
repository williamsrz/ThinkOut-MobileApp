using MvvmCross.IoC;
using MvvmCross.ViewModels;
using ThinkOut.Shared.ViewModels;

namespace ThinkOut.Shared
{
    public class CoreApp : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsSingleton();

            RegisterAppStart<HomeViewModel>();
        }
    }
}
