using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _Capstone.Engine
{
    interface IAuthenticationEngine
    {
        bool AuthenticateEmail(string email);
        bool AuthenticatePassword(string password);
    }
}
