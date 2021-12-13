using _361Capstone.Models;

namespace _361Capstone.Managers
{
    public interface ICheckoutManager
    {
        Address GetAddress(int userId);
        PaymentInfo GetPaymentInfo(int userId);
        void CompleteTransaction(int userId);
    }
}