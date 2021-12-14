using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.UnitTests
{
    [TestClass]
    public class LoginEngineTests
    {
        //arrange
        _361Capstone.Engine.LoginEngine engine = new _361Capstone.Engine.LoginEngine();


        [TestMethod]
        public void CheckUsernameJW_Pass()
        {
            //act
            int result = engine.CheckUsername("Jade Walker");

            //assert
            Assert.AreNotEqual(-1, result);
        }

        [TestMethod]
        public void CheckUsernameP_Pass()
        {
            //act
            int result = engine.CheckUsername("P");

            //assert
            Assert.AreNotEqual(-1, result);
        }
    }
}
