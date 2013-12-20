using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

using MvvmCross_Demo.Core.Persistance;
using MvvmCross_Demo.Core.Models;

namespace MvvmCross_Demo.iOS.Persistance
{
    public class NSUserDefaultsPersistanceRepository : IPersistanceRepository
    {
        private static readonly string CREDENTIAL_USERNAME_KEY = "CREDENTIALS_USERNAME_KEY";
        private static readonly string CREDENTIAL_PASSWORD_KEY = "CREDENTIALS_PASSWORD_KEY";

        public void SaveUserCredentials(UserCredentials credentials)
        {
            NSUserDefaults.StandardUserDefaults.SetString(CREDENTIAL_USERNAME_KEY, credentials.Username);
            NSUserDefaults.StandardUserDefaults.SetString(CREDENTIAL_PASSWORD_KEY, credentials.Password);
        }

        public UserCredentials GetSavedCredentials()
        {
            var username = NSUserDefaults.StandardUserDefaults.StringForKey(CREDENTIAL_USERNAME_KEY);
            var password = NSUserDefaults.StandardUserDefaults.StringForKey(CREDENTIAL_PASSWORD_KEY);
            return new UserCredentials(username, password);
        }
    }
}