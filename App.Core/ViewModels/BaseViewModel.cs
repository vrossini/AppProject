using System;
using App.Core.Services;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace App.Core.ViewModels
{
    public class BaseViewModel : MvxViewModel, IDisposable
    {
        public IFirebaseDBService _firebaseDbService;
        public IMvxNavigationService _navigationService;

        public BaseViewModel(IFirebaseDBService firebaseDbService, IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        //public override async Task Initialize()
        //{
        //    await base.Initialize();
        //}

        public void Dispose()
        {
            _navigationService = null;
        }
    }
}