namespace _361Capstone.Models
{
    public interface IUser
    {
        int GetUserId();
        string GetUsername();
        string GetPassword();
        Cart GetCart();
        Address GetAddress();
        PaymentInfo GetPaymentInfo();

    }
}
