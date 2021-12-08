using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _361Capstone.Engine
{
    interface IAuthenticationEngine
    {
        bool AuthenticateUser(string username);
        bool AuthenticatePassword(string password);
    }
}
