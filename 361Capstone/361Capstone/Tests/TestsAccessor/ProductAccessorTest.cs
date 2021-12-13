using System;
using _361Capstone.Accessors;
using _361Capstone.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace _361Capstone.Tests.TestsAccessor
{
    [TestClass]
    public class ProductAccessorTest
    {
        [Test]
        public void GetProductInfo_Pass()
        {
            ProductAccessor accessor = new ProductAccessor();

            List<String> productInfo = accessor.GetProductInfo(2);

            bool result = false;

            if (productInfo[0].Equals("3")
                && productInfo[1].Equals("1")
                && productInfo[3].Equals("Football")
                && productInfo[4].Equals("A Standard American football.")
                && productInfo[5].Equals("Manufactured in China. Approved by the NFL.")
                && productInfo[7].Equals("0.9375")
                && productInfo[8].Equals("4.9")
                && productInfo[9].Equals("937563406477")
                && productInfo[10].Equals("3854")
                && productInfo[11].Equals("25"))
            {
                result = true;
            }
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(result);
            return;
        }
    }
}

