using System;
using KS_PSPDFKitBindings;

namespace PSPDFKitDemoXamarin.iOS
{
	public class KSBarButtonItem : PSPDFBarButtonItem
	{
		public KSBarButtonItem () : base()
		{
		}

		public KSBarButtonItem (PSPDFViewController controller) : base(controller)
		{
		}

		public KSBarButtonItem (IntPtr handle) : base(handle)
		{
		}

		public override void ovrAction (MonoTouch.Foundation.NSObject sender)
		{
			if(this.Clicked != null)
			{
				this.Clicked(this, null);
			}
		}

		public event EventHandler Clicked;
	}
}

