using Cirrious.CrossCore.IoC;
using MvvmCross_Demo.Core.ViewModels;

namespace MvvmCross_Demo.Core
{
	public class App : Cirrious.MvvmCross.ViewModels.MvxApplication
	{
		public override void Initialize()
		{
            CreatableTypes()
                .EndingWith("Repository")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            CreatableTypes()
                .EndingWith("Manager")
                .AsInterfaces()
                .RegisterAsLazySingleton();
				
			RegisterAppStart<LoginViewModel>();
		}
	}
}