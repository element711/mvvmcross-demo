using MvvmCross_Demo.Core.Models;

namespace MvvmCross_Demo.Core.Managers
{
    public class AuthenticationManager : IAuthenticationManager
    {
        private UserCredentials _credentials;
        public UserCredentials Credentials
        {
            get
            {
                return _credentials;
            }
            set
            {
                _credentials = value;
            }
        }
    }
}
