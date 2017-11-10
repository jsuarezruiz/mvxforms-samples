using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using System.Threading.Tasks;

namespace NavigationMvxForms.Core.ViewModels
{
    public class SecondViewModel : MvxViewModel<string>
    {
        private string _parameter;

        private readonly IMvxNavigationService _navigationService;

        public SecondViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public string Parameter
        {
            get { return _parameter; }
            set { SetProperty(ref _parameter, value); }
        }

        public IMvxCommand BackCommand => new MvxCommand(BackAsync);

        public override Task Initialize()
        {
            //TODO: Add starting logic here

            return base.Initialize();
        }

        public override void Prepare(string parameter)
        {
            Parameter = parameter;
        }

        private async void BackAsync()
        {
            await _navigationService.Close(this);
        }
    }
}