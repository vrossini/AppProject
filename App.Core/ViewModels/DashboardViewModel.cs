using MvvmCross.ViewModels;
using System.Threading.Tasks;

namespace App.Core.ViewModels
{
    public class DashboardViewModel : MvxViewModel
    {
        //public DashboardViewModel(IFirebaseDBService f, IMvxNavigationService n) : base(f, n){}

        public override async Task Initialize()
        {
            await base.Initialize();
        }
    }
}