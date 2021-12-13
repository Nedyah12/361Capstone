using _361Capstone.Accessors;

namespace _361Capstone.Managers
{
    public class InsertDataManager : IInsertDataManager
    {
        AddressAccessor addressAccessor = new AddressAccessor();
        PaymentInfoAccessor paymentInfoAccessor = new PaymentInfoAccessor();
        
        public int SendAddress(int userId, string street, string city, string state, int zip, string country)
        {
            //this return type is void so...
            addressAccessor.InsertAddress(userId, street, city, state, zip, country);
            return 1;
        }

        public int SendPaymentInfo(int userId, string ccn, int expm, int expy, int cvv)
        {
            paymentInfoAccessor.InsertPaymentInfo(userId, ccn, expm, expy, cvv);
            return 1;
        }


    }
}
