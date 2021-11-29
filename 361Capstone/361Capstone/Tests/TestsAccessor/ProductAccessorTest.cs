using System;
using _Capstone.Accessors;
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
            ProdcutAccessor accessor = new ProductAccessor();

            List<String> productInfo = accessor.GetProductInfo(2);

            List<String> expected = { "1", "3", "Driver", "It's a golf club.", "metal", "3.5x0.025", "4.05", "5", "123456", "100000" };
            for (int i = 0; i < 10; i++)
            {
                if (!productInfo[i].Equals(expected[i]))
                {
                    Microsoft.VisualStudio.TestTools.UnitTesting.Assert(false);
                    return;
                }
            }
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert(true);

            return;
        }

        [Test]
        public void GetProductInfo_Fail()
        {
            ProdcutAccessor accessor = new ProductAccessor();

            List<String> productInfo = accessor.GetProductInfo(0);

            List<String> expected = { "1", "3", "Driver", "It's a golf club.", "metal", "3.5x0.025", "4.05", "5", "123456", "100000" };
            for (int i = 0; i < 10; i++)
            {
                if (!productInfo[i].Equals(expected[i]))
                {
                    Microsoft.VisualStudio.TestTools.UnitTesting.Assert(false);
                    return;
                }
            }
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert(true);

            return;
        }
    }
}

