using System;
using _361Capstone.Accessors;
using _361Capstone.Engine;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _361Capstone.Engine
{
    public class LoginEngine : ILoginEngine
    {
        private readonly UserAccessor accessor;

        public LoginEngine()
        {
            accessor = new UserAccessor();
        }

        public int CheckUsername(string username)
        {
            return accessor.GetUserIdFromUsername(username);
        }

        public string RetrievePassword(int userId)
        {
            return null;// accessor.RetrievePassword(userId);
        }
    }
}
