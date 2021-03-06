using System;
using System.Collections.Generic;
using _361Capstone.Models;
using _361Capstone.Accessors;

namespace _361Capstone.Managers
{
    public class ProductsManager : IProductsManager {

        // Returns a list of Product objects of all products in
        // the store to the caller.
        public List<Product> GetAllStoreProducts() {
            ProductAccessor productAccessor = new ProductAccessor();

            List<Product> productList = new List<Product>();
            List<List<String>> allProductInfo = new List<List<String>>();

            allProductInfo = productAccessor.GetAllProductInfo();

            foreach(List<String> list in allProductInfo) {
                productList.Add(new Product(list[0], list[1], list[2], list[3],
                                            list[4], list[5], list[6], list[7],
                                            list[8], list[9], list[10], list[11]));
                
            }

            return productList;
        }

       
        // Returns a list of all categories in the database in
        // category objects to make data-passing easier.
        public List<Category> GetAllCategories() {
            CategoryAccessor categoryAccessor = new CategoryAccessor();
            List<List<String>> allCategories = new List<List<String>>();
            List<Category> categories = new List<Category>();

            allCategories = categoryAccessor.GetAllCategories();

            foreach(List<String> list in allCategories) {
                categories.Add(new Category(Convert.ToInt32(list[0]), list[1], list[2]));
            }


            return categories;
        }

        // Returns a product object that is created from information
        // retrieved from the database.
        public Product GetProduct(int productId) {
            ProductAccessor productAccessor = new ProductAccessor();
            List<String> info = new List<String>();
            info = productAccessor.GetProductInfo(productId);
            Product pulledProduct = new Product(info[0], info[1], info[2], info[3], info[4], info[5],
                                                info[6], info[7], info[8], info[9], info[10], info[11]);
            return pulledProduct;
        }
    }
}
