using System;
using _Capstone.Engine;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _Capstone.Manager
{
    public class RegisterManager : IRegisterManager
    {
        RegisterEngine Manager { get; set; } = new RegisterEngine();

        public int AddUsers(string username, string password)
        {
            return Manager.AddUsers(username, password);
        }

        public void AuthenticateLogin(string username, string password)
        {
            return Manager.AuthenticateLogin(username, password);
        }
    }
}
