using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Touch.Views;
using MvvmCross_Demo.Core.ViewModels;

namespace MvvmCross_Demo.iOS.Views
{
	public partial class LoginView : MvxViewController
	{
		static bool UserInterfaceIdiomIsPhone {
			get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
		}

		public LoginView()
			: base (UserInterfaceIdiomIsPhone ? "LoginView_iPhone" : "LoginView_iPad", null)
		{
		}

		public override void DidReceiveMemoryWarning()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad ();

			var set = this.CreateBindingSet<LoginView, LoginViewModel>();
			set.Bind(usernameTextField).To(vm => vm.Username).TwoWay();
			set.Bind(passwordTextField).To(vm => vm.Password).TwoWay();
			set.Bind(usernameValidationLabel).For(lbl => lbl.Hidden).To(vm => vm.ValidUsername);
			set.Bind(passwordValidationLabel).For(lbl => lbl.Hidden).To(vm => vm.ValidPassword);
			set.Bind(saveCredentialsSwitch).To(vm => vm.SaveCredentials);
			set.Bind(loginButton).To(vm => vm.LoginCommand);
			set.Apply();
		}
	}
}

