using MonoMac.Foundation;
using MonoMac.AppKit;
using Cirrious.CrossCore.Platform;
using Cirrious.MvvmCross.Mac.Platform;
using Cirrious.MvvmCross.Mac.Views.Presenters;
using Cirrious.MvvmCross.ViewModels;

namespace Pina.Mac
{
	public class Setup : MvxMacSetup
	{
		public Setup(MvxApplicationDelegate applicationDelegate, IMvxMacViewPresenter window)
            : base(applicationDelegate, window)
		{
		}

		protected override IMvxApplication CreateApp ()
		{
			return new Core.App();
		}
		
		protected override IMvxTrace CreateDebugTrace()
		{
			return new DebugTrace();
		}
	}
}

