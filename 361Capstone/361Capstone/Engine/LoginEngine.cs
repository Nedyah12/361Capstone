using _361Capstone.Accessors;

namespace _361Capstone.Engine
{
    public class LoginEngine : ILoginEngine
    {
        private readonly UserAccessor accessor;

        public LoginEngine()
        {
            accessor = new UserAccessor();
        }

        // Checks if the given username already exists in the
        // database or not.
        public int CheckUsername(string username)
        {
            return accessor.GetUserIdFromUsername(username);
        }

        // Returns the password of a specified user.
        public string RetrievePassword(int userId)
        {
            return null;
        }
    }
}
