namespace _361Capstone.Models
{
    public class PaymentInfo : IPaymentInfo
    {
        private int PaymentInfoId { get; set; }
        private int UserId { get; set; }
        private string CardNumber { get; set; }
        private int ExpirationMonth { get; set; }
        private int ExpirationYear { get; set; }
        private int Cvv { get; set; }

        public PaymentInfo(int payInfoId, int userId, string cardNumber, int month, int year, int cvv)
        {
            PaymentInfoId = payInfoId;
            UserId = userId;
            CardNumber = cardNumber;
            ExpirationMonth = month;
            ExpirationYear = year;
            Cvv = cvv;
        }

        public int GetPaymentInfoId()
        {
            return PaymentInfoId;
        }
        public int GetUserId()
        {
            return UserId;
        }
        public string GetCardNumber()
        {
            return CardNumber;
        }
        public int GetExpirationMonth()
        {
            return ExpirationMonth;
        }
        public int GetExpirationYear()
        {
            return ExpirationYear;
        }
        public int GetCvv()
        {
            return Cvv;
        }
    }
}
