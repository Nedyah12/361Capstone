namespace _361Capstone.Engine {
    interface ILoginEngine { 
     public int CheckUsername(string username);
     public string RetrievePassword(int userId);
    }
}
