using _361Capstone.Models;
using System;
using System.Collections.Generic;

namespace _361Capstone.Managers
{
    public interface IInsertDataManager
    {
        int SendPaymentInfo(int userId, int ccn, int expm, int expy, int cvv);
        int SendAddress(int userId, string street, string city, string state, int zip, string country);
    }
}