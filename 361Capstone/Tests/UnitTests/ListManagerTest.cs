using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Tests.UnitTests
{
    [TestClass]
    public class ListManagerTest
    {
        //arrange
        _361Capstone.Managers.ListManager ListManager = new _361Capstone.Managers.ListManager();


        [TestMethod]
        public void GetProductInfo2_Pass()
        {
            //act
            List<String> ProductInfo = ListManager.GetProductInfo(2);

            //assert
            Assert.AreNotEqual(-1, ProductInfo);

        }

        [TestMethod]
        public void GetProductInfo17_Pass()
        {
            //act
            List<String> ProductInfo = ListManager.GetProductInfo(17);

            //assert
            Assert.AreNotEqual(-1, ProductInfo);

        }
    }

