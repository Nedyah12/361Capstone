namespace _361Capstone.Managers
{
    public interface IInsertDataManager
    {
        int SendPaymentInfo(int userId, string ccn, int expm, int expy, int cvv);
        int SendAddress(int userId, string street, string city, string state, int zip, string country);
    }
}