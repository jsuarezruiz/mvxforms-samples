using MvvmCross.Core.ViewModels;
using MvvmCross.Core.Views;
using MvvmCross.Forms.Platform;
using MvvmCross.Forms.Uwp;
using MvvmCross.Forms.Uwp.Presenters;
using MvvmCross.Platform;
using MvvmCross.Platform.Logging;
using MvvmCross.Uwp.Views;
using Windows.ApplicationModel.Activation;
using Xamarin.Forms;

namespace HelloMvxForms.UWP
{
    public class Setup : MvxFormsWindowsSetup
    {
        private readonly LaunchActivatedEventArgs launchActivatedEventArgs;

        public Setup(Windows.UI.Xaml.Controls.Frame rootFrame, LaunchActivatedEventArgs e) : base(rootFrame, e)
        {
            launchActivatedEventArgs = e;
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.MvxApp();
        }

        protected override IMvxWindowsViewPresenter CreateViewPresenter(IMvxWindowsFrame rootFrame)
        {
            Forms.Init(launchActivatedEventArgs);

            var presenter = new MvxFormsUwpViewPresenter(rootFrame, new MvxFormsApplication());
            Mvx.RegisterSingleton<IMvxViewPresenter>(presenter);

            return presenter;
        }

        /// <summary>
        /// None logger => Known issue in Mvvmcross 5.4
        /// </summary>
        protected override MvxLogProviderType GetDefaultLogProviderType() => MvxLogProviderType.None;
    }
}