// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoMac.Foundation;
using System.CodeDom.Compiler;

namespace Pina.Mac
{
	[Register ("PinaViewController")]
	partial class PinaViewController
	{
		[Outlet]
		MonoMac.AppKit.NSTextField textme { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (textme != null) {
				textme.Dispose ();
				textme = null;
			}
		}
	}

	[Register ("PinaView")]
	partial class PinaView
	{
		
		void ReleaseDesignerOutlets ()
		{
		}
	}
}
