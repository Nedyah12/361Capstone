using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _361Capstone.Engine;

namespace _361Capstone.Manager
{
    public class LoginManager : ILoginManager {
        private LoginEngine engine;

        public LoginManager() {
            engine = new LoginEngine();
        }

        public int CheckUsername(string username) {
            int result;
            try {
                result = engine.CheckUsername(username);
            } catch (ArgumentNullException) {
                result = -1;
            }
            return result;
        }

        public string RetrievePassword(int userId) {
            return engine.RetrievePassword(userId);
        }
    }
}
