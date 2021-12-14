using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Tests.UnitTests
{
    [TestClass]
    public class CheckoutEngineTest
    {
        //arrange
        _361Capstone.Engine.CheckoutEngine CheckoutEngine = new _361Capstone.Engine.CheckoutEngine();

        [TestMethod]
        public void GetPaymentInfo3_Pass()
        {
            //act
            List<String> PaymentInfo = CheckoutEngine.GetPaymentInfo(3);

            //assert
            Assert.AreNotEqual(-1, PaymentInfo);

        }

        [TestMethod]
        public void GetPaymentInfo12_Pass()
        {
            //act
            List<String> PaymentInfo = CheckoutEngine.GetPaymentInfo(12);

            //assert
            Assert.AreNotEqual(-1, PaymentInfo);

        }
    }

}
