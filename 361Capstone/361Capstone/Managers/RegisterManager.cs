using _361Capstone.Engine;


namespace _361Capstone.Managers
{
    public class RegisterManager : IRegisterManager
    {
        RegisterEngine Manager { get; set; } = new RegisterEngine();

        // Calls to the manager to add the user to the database.
        public int AddUsers(string username, string password)
        {
            return Manager.AddUser(username, password);
        }

        // Authenticates the login of the user.
        public void AuthenticateLogin(string username, string password)
        {
            Manager.AuthenticateLogin(username, password);
            return;
        }
    }
}
