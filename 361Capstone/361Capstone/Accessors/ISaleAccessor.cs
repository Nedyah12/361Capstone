using System;
using System.Collections.Generic;

namespace _361Capstone.Accessors {
    interface ISaleAccessor {
        int InsertSale(string title, int percentage, DateTime startDate, DateTime endDate);
        List<string> GetSaleInfo(int saleId);
        int GetIdFromTitle(string title);
    }
}
