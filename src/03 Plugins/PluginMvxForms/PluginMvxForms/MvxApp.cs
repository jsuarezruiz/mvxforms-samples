using Acr.UserDialogs;
using MvvmCross.Platform;
using MvvmCross.Platform.IoC;
using PluginMvxForms.Core.ViewModels;

namespace PluginMvxForms.Core
{
    public class MvxApp : MvvmCross.Core.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterComponents();

            RegisterNavigationServiceAppStart<PluginViewModel>();
        }

        private void RegisterComponents()
        {
            Mvx.RegisterSingleton<IUserDialogs>(() => UserDialogs.Instance);
        }
    }
}