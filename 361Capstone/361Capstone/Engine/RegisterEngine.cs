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
            User user = new User(0, username, password, 0);
            // Is this right?
            Accessor.InsertUser(username, password);
            return user.GetUserId();
        }

        public void AuthenticateLogin(string username, string password)
        {
            if (username == null || password == null)
            {
                return;
            }

        }
    }
}
