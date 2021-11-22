using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Accessors {
    interface IPaymentInfoAccessor {
        void InsertPaymentInfo(int userId, int creditCardNumber, int expMonth, int expDay, int cvvCode);
        List<string> GetPaymentInfo(int userId);
    }
}
