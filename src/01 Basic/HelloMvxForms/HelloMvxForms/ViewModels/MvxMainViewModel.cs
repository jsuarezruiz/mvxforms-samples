using MvvmCross.Core.ViewModels;
using System.Threading.Tasks;

namespace HelloMvxForms.Core.ViewModels
{
    public class MvxMainViewModel : MvxViewModel
    {
        private int _counter;
        private string _message;

        public MvxMainViewModel()
        {
        }

        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public IMvxCommand CounterCommand => new MvxCommand(Counter);

        public override Task Initialize()
        {
            _counter = 0;

            return base.Initialize();
        }

        private void Counter()
        {
            _counter++;

            Message = string.Format("Button clicked {0} times", _counter);
        }
    }
}