using Android.App;
using Android.Content.PM;
using MvvmCross.Platforms.Android.Views;

namespace App.UI.Droid
{
    [Activity(
        MainLauncher = true,
        Icon = "@drawable/Splash",
        Theme = "@style/Theme.Splash",
        NoHistory = true,
        ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen() : base(Resource.Layout.SplashScreen) {}
    }
}