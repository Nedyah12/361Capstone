using _361Capstone.Accessors;

namespace _361Capstone.Engine
{
    public class RegisterEngine : IRegisterEngine
    {
        UserAccessor Accessor { get; set; } = new UserAccessor();

        // Adds a user to the database.
        public int AddUser(string username, string password)
        {
            int userId = Accessor.InsertUser(username, password);
            return userId;
        }

        // Checks that the username and password strings are not null
        // and can be passed on to the database.
        public void AuthenticateLogin(string username, string password)
        {
            if (username == null || password == null)
            {
                return;
            }

        }
    }
}
