using System;
using System.Collections.Generic;
using System.Linq;
using MonoMac.Foundation;
using MonoMac.AppKit;
using Cirrious.MvvmCross.Mac.Views;
using Cirrious.MvvmCross.Binding.BindingContext;
using Pina.Core.ViewModels;

namespace Pina.Mac
{
	public partial class PinaViewController : MvxViewController
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

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			var set = this.CreateBindingSet<PinaViewController, PinaViewModel> ();
			set.Bind (textme).For(v => v.StringValue).To (vm => vm.Hello);
			set.Apply ();
		}
	}
}

