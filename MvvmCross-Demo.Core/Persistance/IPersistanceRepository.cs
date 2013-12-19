using MvvmCross_Demo.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmCross_Demo.Core.Persistance
{
    public interface IPersistanceRepository
    {
        void SaveUserCredentials(UserCredentials credentials);
        UserCredentials GetSavedCredentials();
    }
}
