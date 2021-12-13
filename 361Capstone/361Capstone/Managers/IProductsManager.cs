using System.Collections.Generic;
using _361Capstone.Models;

namespace _361Capstone.Managers
{
    interface IProductsManager
    {
        List<Product> GetAllStoreProducts();
        List<Category> GetAllCategories();
        Product GetProduct(int productId);
    }
}
