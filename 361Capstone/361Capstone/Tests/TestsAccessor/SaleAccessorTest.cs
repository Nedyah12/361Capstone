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
    public class SaleAccessorTest
    {
        [Test]
        public void GetSaleInfo_Pass()
        {
            SaleAccessor accessor = new SaleAccessor();

            List<String> saleInfo = accessor.GetSaleInfo(2);

            List<String> expected = { "dev sale", "20", "2021-12-01", "2022-01-01" };
            for (int i = 0; i < 4; i++)
            {
                if (!saleInfo[i].Equals(expected[i]))
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

