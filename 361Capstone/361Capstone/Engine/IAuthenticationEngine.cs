namespace _361Capstone.Engine
{
    interface IAuthenticationEngine
    {
        bool AuthenticateUser(string username);
        bool AuthenticatePassword(string password);
    }
}
