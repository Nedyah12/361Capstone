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
    public class PaymentAccessorTest
    {
        [Test]
        public void GetPaymentInfo_Pass()
        {
            PaymentInfoAccessor accessor = new PaymentInfoAccessor();
            List<string> payment = accessor.GetPaymentInfo(3);

            bool res = false;

            if (payment[0].Equals("3")
                && payment[1].Equals("3")
                && payment[2].Equals("1111222233334444")
                && payment[3].Equals("1")
                && payment[4].Equals("25")
                && payment[5].Equals("123"))
            {
                res = true;
            }
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(res);
            return;
        }
    }
}

