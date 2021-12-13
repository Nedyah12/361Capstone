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

        public int CheckUsername(string username)
        {
            return accessor.GetUserIdFromUsername(username);
        }

        public string RetrievePassword(int userId)
        {
            return null;
        }
    }
}
