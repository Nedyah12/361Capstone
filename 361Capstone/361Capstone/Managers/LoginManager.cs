using System;
using _361Capstone.Engine;

namespace _361Capstone.Managers
{
    public class LoginManager : ILoginManager {
        private readonly LoginEngine engine;

        public LoginManager() {
            engine = new LoginEngine();
        }

        // Checks if the username is already in the database.
        public int CheckUsername(string username) {
            int result;
            try {
                result = engine.CheckUsername(username);
            } catch (ArgumentNullException) {
                result = -1;
                return result;
            }
            return result;
        }

        // Returns the password of a user in string form.
        public string RetrievePassword(int userId) {
            return engine.RetrievePassword(userId);
        }
    }
}
