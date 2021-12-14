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
    public class AddressAccessorTest
    {
        [Test]
        public void GetAddressInfoTest_Pass()
        {
            AddressAccessor accessor = new AddressAccessor();

            List<string> addy = accessor.GetAddressInfo(3);

            bool result = false;

            if (addy[1].Equals("3")
                && addy[2].Equals("123 Ez Street")
                && addy[3].Equals("Unit")
                && addy[4].Equals("Test")
                && addy[5].Equals("12345")
                && addy[6].Equals("US"))
            {
                result = true;
            }
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(result);
            return;

        }
    }
}
