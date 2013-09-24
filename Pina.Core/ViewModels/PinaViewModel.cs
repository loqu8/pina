using Cirrious.MvvmCross.ViewModels;

namespace Pina.Core.ViewModels
{
    public class PinaViewModel 
		: MvxViewModel
    {
		private string _hello = "Hello Pina";
        public string Hello
		{ 
			get { return _hello; }
			set { _hello = value; RaisePropertyChanged(() => Hello); }
		}
    }
}
