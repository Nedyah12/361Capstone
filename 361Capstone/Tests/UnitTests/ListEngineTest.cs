using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Tests.UnitTests
{
    [TestClass]
    public class ListEngineTest
    {
        //arrange
        _361Capstone.Engine.ListEngine listEngine = new _361Capstone.Engine.ListEngine();
        

        [TestMethod]
        public void GetProductInfo22_Pass()
        {
            //act
            List<String> ProductInfo = listEngine.GetProductInfo(22);
           
            //assert
            Assert.AreNotEqual(-1, ProductInfo);

        }

        [TestMethod]
        public void GetProductInfo9_Pass()
        {
            //act
            List<String> ProductInfo = listEngine.GetProductInfo(9);

            //assert
            Assert.AreNotEqual(-1, ProductInfo);

        }
    }
