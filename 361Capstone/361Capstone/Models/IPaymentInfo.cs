using System;
namespace _361Capstone.Models
{
    public interface IPaymentInfo
    {
        public int GetPaymentInfoId();
        public int GetUserId();
        public string GetCardNumber();
        public int GetExpirationMonth();
        public int GetCvv();
    }
}
