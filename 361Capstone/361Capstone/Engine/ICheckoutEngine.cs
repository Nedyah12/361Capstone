using System;
using System.Collections.Generic;

namespace _361Capstone.Engine
{
    public interface ICheckoutEngine
    {
        List<String> GetAddressInfo(int userId);
        List<String> GetPaymentInfo(int userId);   
    }
}