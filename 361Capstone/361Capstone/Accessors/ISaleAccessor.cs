using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _361Capstone.Accessors {
    interface ISaleAccessor {
        int InsertSale(string title, int percentage, DateTime startDate, DateTime endDate);
        List<string> GetSaleInfo(int saleId);
        int GetIdFromTitle(string title);
    }
}
