using UIKit;
using MvvmCross.Core.ViewModels;
using MvvmCross.Forms.Platform;
using MvvmCross.Platform.Platform;
using MvvmCross.iOS.Platform;
using MvvmCross.Forms.iOS;

namespace NavigationMvxForms.iOS
{
    public class Setup : MvxFormsIosSetup
    {
        public Setup(IMvxApplicationDelegate applicationDelegate, UIWindow window)
            : base(applicationDelegate, window)
        {
        }

        protected override MvxFormsApplication CreateFormsApplication()
        {
            return new Core.App();
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.MvxApp();
        }

        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }
    }
}