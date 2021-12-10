using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using _361Capstone.Models;
using _361Capstone.Accessors;

namespace _361Capstone.Managers
{
    public class ProductsManager : IProductsManager {
        public List<Product> GetAllStoreProducts() {
            ProductAccessor productAccessor = new ProductAccessor();

            List<Product> productList = new List<Product>();
            List<List<String>> allProductInfo = new List<List<String>>();

            allProductInfo = productAccessor.GetAllProductInfo();

            foreach(List<String> list in allProductInfo) {

                    /*productList.Add(new Product(Convert.ToInt32(list[0]), Convert.ToInt32(list[1]),
                                                Convert.ToInt32(list[2]), list[3], list[4], list[5],
                                                list[6], Convert.ToDouble(list[7]),
                                                Convert.ToDouble(list[8]), list[9],
                                                Convert.ToInt32(list[10])));*/

                productList.Add(new Product(list[0], list[1],
                                            list[2], list[3],
                                            list[4], list[5],
                                            list[6], list[7],
                                            list[8], list[9],
                                            list[10]));
                
            }


            return productList;
        }
    }
}
