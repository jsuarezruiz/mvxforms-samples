using HelloMvxForms.Core.ViewModels;
using MvvmCross.Platform.IoC;

namespace HelloMvxForms.Core
{
    public class MvxApp : MvvmCross.Core.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterNavigationServiceAppStart<MvxMainViewModel>();
        }
    }
}