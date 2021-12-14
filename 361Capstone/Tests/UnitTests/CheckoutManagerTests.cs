using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests.UnitTests
{
    [TestClass]
    public class CheckoutManagerTests
    {
        //arrange
        _361Capstone.Managers.CheckoutManager manager = new _361Capstone.Managers.CheckoutManager();

        [TestMethod]
        public void GetAddress_Fail()
        {
            //more arrange
            _361Capstone.Models.Address actual = new _361Capstone.Models.Address(3,
                                                                             3,
                                                                             "123 Ez Street",
                                                                             "Unit",
                                                                             "Test",
                                                                             "12345",
                                                                             "US");
            
            //act
            //account 1000 does not exist
            _361Capstone.Models.Address notRealAccount = manager.GetAddress(1000);
            //assert
            Assert.AreNotEqual(actual, notRealAccount);

        }

        [TestMethod]
        public void GetCardNumber_Pass()
        {
            //arrange
            _361Capstone.Models.PaymentInfo actual = new _361Capstone.Models.PaymentInfo(3, 3, "1111222233334444", 1, 25, 123);

            //act
            _361Capstone.Models.PaymentInfo payment = manager.GetPaymentInfo(3);

            //assert
            Assert.AreEqual(actual.GetCardNumber(), payment.GetCardNumber());

        }

        [TestMethod]
        public void GetCvv_Pass()
        {
            //arrange
            _361Capstone.Models.PaymentInfo actual = new _361Capstone.Models.PaymentInfo(3, 3, "1111222233334444", 1, 25, 123);

            //act
            _361Capstone.Models.PaymentInfo payment = manager.GetPaymentInfo(3);

            //assert
            Assert.AreEqual(actual.GetCvv(), payment.GetCvv());

        }


    }
}
