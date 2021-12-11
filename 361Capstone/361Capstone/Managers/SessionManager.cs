using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _361Capstone.Managers
{
    public class SessionManager : ISessionManager
    {
        //Checks whether or not a user has access to a certain page.
        public bool ValidateKey(string key, int userId)
        {
            int keyParsed;
            try
            {
                keyParsed = Int32.Parse(key);
            }
            catch (ArgumentNullException)
            {
                return false;
            }
            catch (FormatException)
            {
                return false;
            }

            if (keyParsed == userId)
            {
                return true;
            }
            return false;
        }
    }
}
