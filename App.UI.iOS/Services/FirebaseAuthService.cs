using System;
using Firebase.Auth;
using TipCalc.Core.Services;
using System.Threading.Tasks;

namespace TipCalc.iOS.Services
{
    class FirebaseAuthService : IFirebaseAuthService
    {
        public async Task<string> SignInAsync(string email, string password)
        {
            var user = await Auth.DefaultInstance.SignInWithPasswordAsync(email, password);
            return await user.User.GetIdTokenAsync();
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