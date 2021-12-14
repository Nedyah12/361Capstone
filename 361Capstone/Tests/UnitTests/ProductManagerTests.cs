using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.UnitTests
{
    [TestClass]
    public class ProductManagerTests
    {
        //arrange
        _361Capstone.Managers.ProductsManager productsManager = new _361Capstone.Managers.ProductsManager();

        [TestMethod]
        public void GetProduct10_Pass()
        {
            
            //act
            _361Capstone.Models.Product product = productsManager.GetProduct(10);
            //assert
            Assert.AreEqual(product.GetProductId(), 10);
            
        }

        [TestMethod]
        public void GetProduct3_Pass()
        {
           
            //act
            _361Capstone.Models.Product product = productsManager.GetProduct(3);
            //assert
            Assert.AreEqual(product.GetProductId(), 3);

        }

        [TestMethod]
        public void GetProduct16_Pass()
        {
           
            //act
            _361Capstone.Models.Product product = productsManager.GetProduct(16);
            //assert
            Assert.AreEqual(product.GetProductId(), 16);

        }
    }
}
