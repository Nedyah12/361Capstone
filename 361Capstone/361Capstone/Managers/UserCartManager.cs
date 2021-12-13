using _361Capstone.Engine;
using _361Capstone.Models;
using System;
using System.Collections.Generic;

namespace _361Capstone.Managers
{
    public class UserCartManager : IUserCartManager
    {
        UserCartEngine Engine = new UserCartEngine();
        ProductsManager productsManager = new ProductsManager();
        public List<Product> GetUserCartProducts(int userId)
        {
            List<Product> productList = new List<Product>();
            List<List<String>> allProductInfo = Engine.GetUserCartProductInfo(userId);

            foreach (List<String> list in allProductInfo) {
                productList.Add(new Product(list[0], list[1], list[2], list[3],
                                            list[4], list[5], list[6], list[7],
                                            list[8], list[9], list[12], list[11]));

            }

            return productList;
        }

    }
}
