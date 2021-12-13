namespace _361Capstone.Managers
{
    interface ILoginManager
    {
        public int CheckUsername(string username);
        public string RetrievePassword(int userId);
    }
}
