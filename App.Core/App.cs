using MvvmCross;
using MvvmCross.IoC;
using App.Core.Services;
using App.Core.ViewModels;
using MvvmCross.ViewModels;

namespace App.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            Mvx.IoCProvider.RegisterType<DashboardViewModel>();
            Mvx.IoCProvider.RegisterType<ForgetPasswordViewModel>();
            Mvx.IoCProvider.RegisterType<IFirebaseDBService>();
            Mvx.IoCProvider.RegisterType<IFirebaseAuthService>();
            RegisterAppStart<LoginViewModel>();
        }
    }
}