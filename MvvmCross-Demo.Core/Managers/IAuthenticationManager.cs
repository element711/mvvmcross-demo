using MvvmCross_Demo.Core.Models;

namespace MvvmCross_Demo.Core.Managers
{
    public interface IAuthenticationManager
    {
        UserCredentials Credentials { get; set; }
    }
}
