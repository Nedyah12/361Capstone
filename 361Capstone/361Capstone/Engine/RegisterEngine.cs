using _361Capstone.Accessors;

namespace _361Capstone.Engine
{
    public class RegisterEngine : IRegisterEngine
    {
        UserAccessor Accessor { get; set; } = new UserAccessor();

        public int AddUser(string username, string password)
        {
            int userId = Accessor.InsertUser(username, password);
            return userId;
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
