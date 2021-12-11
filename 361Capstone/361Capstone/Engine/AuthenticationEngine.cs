using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _361Capstone.Engine
{
    public class AuthenticationEngine : IAuthenticationEngine
    {
        public bool AuthenticatePassword(string password)
        {
            if (password == null)
            {
                throw new ArgumentNullException();
            }
            else if (password.Equals(string.Empty))
            {
                throw new Exception();
            }
            return password.Length >= 1;
        }

        public bool AuthenticateUser(string username)
        {
            if (username == null)
            {
                throw new ArgumentNullException();
            }
            else if (username.Equals(string.Empty))
            {
                throw new Exception();
            }

            return true;
        }
    }
}
