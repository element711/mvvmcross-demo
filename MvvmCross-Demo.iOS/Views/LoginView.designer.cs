// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace MvvmCross_Demo.iOS.Views
{
	[Register ("LoginView")]
	partial class LoginView
	{
		[Outlet]
		MonoTouch.UIKit.UIButton loginButton { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField passwordTextField { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel passwordValidationLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UISwitch saveCredentialsSwitch { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField usernameTextField { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel usernameValidationLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (usernameTextField != null) {
				usernameTextField.Dispose ();
				usernameTextField = null;
			}

			if (passwordTextField != null) {
				passwordTextField.Dispose ();
				passwordTextField = null;
			}

			if (usernameValidationLabel != null) {
				usernameValidationLabel.Dispose ();
				usernameValidationLabel = null;
			}

			if (passwordValidationLabel != null) {
				passwordValidationLabel.Dispose ();
				passwordValidationLabel = null;
			}

			if (saveCredentialsSwitch != null) {
				saveCredentialsSwitch.Dispose ();
				saveCredentialsSwitch = null;
			}

			if (loginButton != null) {
				loginButton.Dispose ();
				loginButton = null;
			}
		}
	}
}
