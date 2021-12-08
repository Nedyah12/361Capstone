using System;
using _361Capstone.Models;
using _361Capstone.Accessors;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _361Capstone.Engine
{
    public class RegisterEngine : IRegisterEngine
    {
        UserAccessor Accessor { get; set; } = new UserAccessor();

        public int AddUsers(string username, string password)
        {
            throw new NotImplementedException();
        }

        public void AuthenticateLogin(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
