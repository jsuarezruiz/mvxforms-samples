using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using System.Threading.Tasks;

namespace NavigationMvxForms.Core.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public FirstViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public IMvxCommand NavigateCommand => new MvxCommand(NavigateAsync);

        public IMvxCommand NavigateParameterCommand => new MvxCommand(NavigateParameterAsync);

        public override Task Initialize()
        {
            //TODO: Add starting logic here

            return base.Initialize();
        }

        private async void NavigateAsync()
        {
            await _navigationService.Navigate<SecondViewModel>();
        }

        private async void NavigateParameterAsync()
        {
            await _navigationService.Navigate<SecondViewModel, string>("parameter");
        }
    }
}