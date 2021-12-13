using System;
using System.Collections.Generic;

namespace _361Capstone.Accessors {
    interface ICategoryAccessor {
        int InsertCategory(string title);
        int GetIdFromTitle(string title);
        void AttachSale(int categoryId ,int saleId);
        void DetachSale(int categoryId);
        List<List<String>> GetAllCategories();
    }
}
