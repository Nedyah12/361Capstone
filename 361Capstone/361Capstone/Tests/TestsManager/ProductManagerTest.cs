using Microsoft.VisualStudio.TestTools.UnitTesting;
using _361Capstone.Managers;
using _361Capstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _361Capstone.Tests.TestsManager
{
    [TestClass]
    public class ProductManagerTest
    {
        [TestMethod]
        public void getProduct_Pass()
        {
            ProductsManager productsManager = new ProductsManager();

            Product product = productsManager.GetProduct(10);

            if(product.GetProductId() != 10)
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.Fail();
            }

        }
    }
}
