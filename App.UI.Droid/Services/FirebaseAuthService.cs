using System;
using Firebase.Auth;
using App.Core.Services;
using System.Threading.Tasks;

namespace App.UI.Droid.Services
{
    class FirebaseAuthService : IFirebaseAuthService
    {
        public async Task<string> SignInAsync(string email, string password)
        {
            var user = await FirebaseAuth.Instance.
                        SignInWithEmailAndPasswordAsync(email, password);
            var token = await user.User.GetIdTokenAsync(false);
            return token.Token;
        }

        public string getAuthKey()
        {
            throw new NotImplementedException();
        }

        public string GetUserId()
        {
            throw new NotImplementedException();
        }

        public bool IsUserSigned()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Logout()
        {
            throw new NotImplementedException();
        }

        public void SignInWithGoogle()
        {
            throw new NotImplementedException();
        }

        public Task<bool> SignInWithGoogle(string token)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SignUp(string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}