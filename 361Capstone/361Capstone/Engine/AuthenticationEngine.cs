using System;

namespace _361Capstone.Engine
{
    public class AuthenticationEngine : IAuthenticationEngine
    {
        // Checks the integrity of the password (string) that the 
        // user inputted.
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
            // Password requirement: 8 characters.
            return password.Length >= 8;
        }

        // Verifies the integrity of the username (string)
        // that the user inputted.
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
