using Cirrious.CrossCore;
using Cirrious.CrossCore.Platform;
using Cirrious.MvvmCross.Touch.Platform;
using Cirrious.MvvmCross.ViewModels;
using MonoTouch.UIKit;
using MvvmCross_Demo.Core.Managers;
using MvvmCross_Demo.Core.Persistance;
using MvvmCross_Demo.iOS.Persistance;

namespace MvvmCross_Demo.iOS
{
	public class Setup : MvxTouchSetup
	{
		public Setup(MvxApplicationDelegate applicationDelegate, UIWindow window)
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

		protected override void InitializeLastChance()
		{
			base.InitializeLastChance ();

			Mvx.ConstructAndRegisterSingleton<IPersistanceRepository, NSUserDefaultsPersistanceRepository>();
			Mvx.ConstructAndRegisterSingleton<IAuthenticationManager, AuthenticationManager>();
		}
	}
}