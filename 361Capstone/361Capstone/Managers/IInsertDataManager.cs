using _361Capstone.Models;
using System;
using System.Collections.Generic;

namespace _361Capstone.Managers
{
    public interface IInsertDataManager
    {
        int SendAddress(int userId, int ccn, int expm, int expy, int cvv);
        int SendPaymentInfo(int userId, string street, string city, string state, int zip, string country);
    }
}