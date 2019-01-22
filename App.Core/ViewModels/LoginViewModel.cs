using App.Core.Services;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System.Threading.Tasks;

namespace App.Core.ViewModels
{
    public class LoginViewModel : MvxViewModel
    {
        //private readonly IFirebaseDBService _firebaseDbService;
        private readonly IMvxNavigationService _navigationService;
        //private readonly IFirebaseAuthService _firebaseAuthService;

        //public LoginViewModel(IFirebaseAuthService firebaseAuthService, IFirebaseDBService f, IMvxNavigationService n) 
        //{
            //_firebaseDbService = f;
            //_navigationService = n;
            //_firebaseAuthService = firebaseAuthService;
        //}

        public LoginViewModel(IMvxNavigationService n)
        {
            _navigationService = n;
        }

        public override async Task Initialize()
        {
            await base.Initialize();

            Email = "";
            Password = "";

            // exemplos de chamada
            //_firebaseDbService.Connect();
            //await _firebaseAuthService.SignInAsync("","");
        }

        private string _email;
        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                //RaisePropertyChanged(() => SubTotal);
                //Recalcuate();
            }
        }

        private string _password;
        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                //RaisePropertyChanged(() => Generosity);
                //Recalcuate();
            }
        }

        public MvxCommand<string> ClickCommand
        {
            get
            {
                return new MvxCommand<string>(param =>
                {
                    if (param.Equals("Login"))
                    {
                        _navigationService.Navigate<DashboardViewModel>();
                    }
                    else if (param.Equals("ForgetPassword"))
                    {
                        _navigationService.Navigate<ForgetPasswordViewModel>();
                    }
                    else if (param.Equals("SignUp"))
                    {
                        _navigationService.Navigate<SignUpViewModel>();
                    }
                });
            }
        }
    }
}