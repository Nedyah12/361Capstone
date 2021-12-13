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
        InsertDataEngine Engine = new InsertDataEngine();

        public int SendAddress(int userId, int ccn, int expm, int expy, int cvv) {

        }

        public int SendPaymentInfo(int userId, string street, string city, string state, int zip, string country) {

        }


    }
}
