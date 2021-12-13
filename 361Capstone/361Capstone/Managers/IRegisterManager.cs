namespace _361Capstone.Managers
{
    interface IRegisterManager
    {
        void AuthenticateLogin(string username, string password);
        int AddUsers(string username, string password);
    }
}
