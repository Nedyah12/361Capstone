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
    public class ListManagerTest
    {
        [TestMethod]
        public void getProductInfo_Pass()
        {
            ListManager listManager = new ListManager();

            List<string> productInfo = listManager.GetProductInfo(8);

            if (!productInfo.Equals(8))
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.Fail();
            }


        }
    }
}
