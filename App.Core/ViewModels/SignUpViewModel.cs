using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System.Threading.Tasks;

namespace App.Core.ViewModels
{
    public class SignUpViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public SignUpViewModel(IMvxNavigationService n)
        {
            _navigationService = n;
        }

        //public SignUpViewModel(IFirebaseDBService f, IMvxNavigationService n) : base(f, n) { }

        public override async Task Initialize()
        {
            await base.Initialize();
        }

        public MvxCommand ClickCommand
        {
            get
            {
                return new MvxCommand(() => _navigationService.Close(this));
            }
        }
    }
}