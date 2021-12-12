using _361Capstone.Models;
using System.Collections.Generic;

namespace _361Capstone.Managers
{
    public interface ICheckoutManager
    {
        Address GetAddress(int userId);
        PaymentInfo GetPaymentInfo(int userId);
    }
}