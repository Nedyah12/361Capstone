using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.UnitTests
{
    [TestClass]
    public class LoginManagerTests
    {
        //arrange
        _361Capstone.Managers.LoginManager manager = new _361Capstone.Managers.LoginManager();

        [TestMethod]
        public void CheckUsernameA_Pass()
        {
            //act
            int ret = manager.CheckUsername("a");
            //assert
            Assert.AreEqual(1, ret);

        }

        [TestMethod]
        public void CheckUsernameIA_Pass()
        {
            //act
            int ret = manager.CheckUsername("Isa_Adrover");
            //assert
            Assert.AreEqual(2, ret);

        }


    }
}
