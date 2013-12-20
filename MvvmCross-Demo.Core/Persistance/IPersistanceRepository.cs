using MvvmCross_Demo.Core.Models;

namespace MvvmCross_Demo.Core.Persistance
{
    public interface IPersistanceRepository
    {
        void SaveUserCredentials(UserCredentials credentials);
        UserCredentials GetSavedCredentials();
    }
}
