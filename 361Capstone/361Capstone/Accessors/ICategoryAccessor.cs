using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _361Capstone.Models;

namespace _361Capstone.Accessors {
    interface ICategoryAccessor {
        int InsertCategory(string title);
        int GetIdFromTitle(string title);
        void AttachSale(int categoryId ,int saleId);
        void DetachSale(int categoryId);
        List<List<String>> GetAllCategories();
    }
}
