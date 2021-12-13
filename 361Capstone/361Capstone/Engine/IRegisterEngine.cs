namespace _361Capstone.Engine
{
    interface IRegisterEngine
    {
        void AuthenticateLogin(string username, string password);
        int AddUser(string username, string password);
    }
}
