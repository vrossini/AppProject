using System;
using System.Threading.Tasks;

namespace App.Core.Services
{
    public interface IFirebaseAuthService
    {
        String GetUserId();
        bool IsUserSigned();
        Task<bool> Logout();
        String getAuthKey();
        void SignInWithGoogle();
        Task<bool> SignInWithGoogle(String token);
        Task<bool> SignUp(String email, String password);
        Task<string> SignInAsync(string email, string password);
    }
}