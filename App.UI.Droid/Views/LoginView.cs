using Firebase;
using Android.OS;
using Android.App;
using Firebase.Auth;
using App.Core.ViewModels;
using MvvmCross.Platforms.Android.Views;

namespace App.UI.Droid.Views
{
    [Activity(Label = "App.UI.Droid")]
    public class LoginView : MvxActivity<LoginViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            FirebaseApp.InitializeApp(Application.Context);
            SetContentView(Resource.Layout.LoginView);
        }

        private void InitFirebaseAuth()
        {
            var options = new FirebaseOptions.Builder()
               .SetApplicationId("1:165063583301:android:cb007e753d67eaa2")
               .SetApiKey("AIzaSyD7UK4O6n5yKDL96pdK1u6kJyxosgEJYmg")
               .Build();
            //if (app == null)
                //app = FirebaseApp.InitializeApp(this, options);
            //auth = FirebaseAuth.GetInstance(app);
        }
    }
}