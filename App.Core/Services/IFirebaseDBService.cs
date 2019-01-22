using System;

namespace App.Core.Services
{
    public interface IFirebaseDBService
    {
        void Connect();
        void GetMessage();
        void SetMessage(String message);
        String GetMessageKey();
    }
}