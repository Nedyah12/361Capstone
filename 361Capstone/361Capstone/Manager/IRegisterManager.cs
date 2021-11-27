using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _Capstone.Manager
{
    interface IRegisterManager
    {
        void AuthenticateLogin(string username, string password);
        int AddUsers(string username, string password);
    }
}
