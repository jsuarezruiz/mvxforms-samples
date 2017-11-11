using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using Acr.UserDialogs;

namespace PluginMvxForms.Core.ViewModels
{
    public class PluginViewModel : MvxViewModel
    {
        public PluginViewModel()
        {
        }

        public IMvxCommand DialogCommand => new MvxCommand(Dialog);

        public override Task Initialize()
        {
            //TODO: Add starting logic here
		    
            return base.Initialize();
        }

        private void Dialog()
        {
            Mvx.Resolve<IUserDialogs>().Alert("Using Mvx Plugins!");
        }
    }
}