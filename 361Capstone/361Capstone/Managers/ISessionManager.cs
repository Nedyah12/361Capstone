namespace _361Capstone.Managers
{
    public interface ISessionManager
    {
        bool ValidateKey(string key, int userId);
    }
}