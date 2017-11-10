using MvvmCross.Platform.IoC;
using NavigationMvxForms.Core.ViewModels;

namespace NavigationMvxForms.Core
{
    public class MvxApp : MvvmCross.Core.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterNavigationServiceAppStart<FirstViewModel>();
        }
    }
}