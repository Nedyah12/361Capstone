using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace _361Capstone.Accessors {
    interface IProductAccessor {
        int InsertProduct(int categoryId, string name,
                          string description, string manufInfo,
                          string dimensions, double weight,
                          double rating, int sku, int stockCount);

        List<string> GetProductInfo(int productId);
        int GetIdFromName(string name);
        int IncrementStockCount(int productId, int addNumber);
        int DecrementStockCount(int productId, int removeNumber);
        void AttachSale(int productId, int saleId);
        void DetachSale(int productId);

        List<List<String>> GetAllProductInfo();


    }
}
