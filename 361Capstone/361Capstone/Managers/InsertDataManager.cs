using _361Capstone.Engine;
using _361Capstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _361Capstone.Managers
{
    public class InsertDataManager : IInsertDataManager
    {
        //InsertDataEngine Engine = new InsertDataEngine();
        
        public int SendAddress(int userId, string street, string city, string state, int zip, string country)
        {

            Accessors.AddressAccessor accessor = new Accessors.AddressAccessor();
            //this return type is void so...
            accessor.InsertAddress(userId, street, city, state, zip, country);
            return 1;
        }

        public int SendPaymentInfo(int userId, int ccn, int expm, int expy, int cvv)
        {
            Accessors.PaymentInfoAccessor acc = new Accessors.PaymentInfoAccessor();

            acc.InsertPaymentInfo(userId, ccn, expm, expy, cvv);
            return 1;
        }


    }
}
