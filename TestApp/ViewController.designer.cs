// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace TestApp
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSButton DuplicatesButton { get; set; }

		[Outlet]
		AppKit.NSButton MissingButton { get; set; }

		[Outlet]
		AppKit.NSButton OrphansButton { get; set; }

		[Outlet]
		AppKit.NSTextField ProcessLog { get; set; }

		[Outlet]
		AppKit.NSButton UnanalyzedButton { get; set; }

		[Outlet]
		AppKit.NSButton UnreferencedButton { get; set; }

		[Outlet]
		AppKit.NSButton UntaggedButton { get; set; }

		[Action ("DuplicateButtonCheck:")]
		partial void DuplicateButtonCheck (Foundation.NSObject sender);

		[Action ("ExecuteButtonCheck:")]
		partial void ExecuteButtonCheck (Foundation.NSObject sender);

		[Action ("MissingButtonCheck:")]
		partial void MissingButtonCheck (Foundation.NSObject sender);

		[Action ("OrphansButtonCheck:")]
		partial void OrphansButtonCheck (Foundation.NSObject sender);

		[Action ("RadioButtonsCheck:")]
		partial void RadioButtonsCheck (Foundation.NSObject sender);

		[Action ("UnanalyzedButtonCheck:")]
		partial void UnanalyzedButtonCheck (Foundation.NSObject sender);

		[Action ("UnreferencedButtonCheck:")]
		partial void UnreferencedButtonCheck (Foundation.NSObject sender);

		[Action ("UntaggedButtonCheck:")]
		partial void UntaggedButtonCheck (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (DuplicatesButton != null) {
				DuplicatesButton.Dispose ();
				DuplicatesButton = null;
			}

			if (MissingButton != null) {
				MissingButton.Dispose ();
				MissingButton = null;
			}

			if (OrphansButton != null) {
				OrphansButton.Dispose ();
				OrphansButton = null;
			}

			if (ProcessLog != null) {
				ProcessLog.Dispose ();
				ProcessLog = null;
			}

			if (UnanalyzedButton != null) {
				UnanalyzedButton.Dispose ();
				UnanalyzedButton = null;
			}

			if (UnreferencedButton != null) {
				UnreferencedButton.Dispose ();
				UnreferencedButton = null;
			}

			if (UntaggedButton != null) {
				UntaggedButton.Dispose ();
				UntaggedButton = null;
			}
		}
	}
}
