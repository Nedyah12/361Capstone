using System.Collections.Generic;

namespace _361Capstone.Accessors {
    interface IPaymentInfoAccessor {
        void InsertPaymentInfo(int userId, string creditCardNumber, int expMonth, int expYear, int cvvCode);
        List<string> GetPaymentInfo(int userId);
    }
}
