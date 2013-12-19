using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmCross_Demo.Core.Models
{
    public class UserCredentials
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public UserCredentials(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
