using System;
using System.Collections.Generic;
using System.Linq;
using MonoMac.Foundation;
using MonoMac.AppKit;

namespace Pina.Mac
{
	public partial class PinaViewController : MonoMac.AppKit.NSViewController
	{
		#region Constructors
		// Called when created from unmanaged code
		public PinaViewController (IntPtr handle) : base (handle)
		{
			Initialize ();
		}
		// Called when created directly from a XIB file
		[Export ("initWithCoder:")]
		public PinaViewController (NSCoder coder) : base (coder)
		{
			Initialize ();
		}
		// Call to load from the XIB/NIB file
		public PinaViewController () : base ("PinaView", NSBundle.MainBundle)
		{
			Initialize ();
		}
		// Shared initialization code
		void Initialize ()
		{
		}
		#endregion
		//strongly typed view accessor
		public new PinaView View {
			get {
				return (PinaView)base.View;
			}
		}
	}
}

