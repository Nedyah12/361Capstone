using System;
using _361Capstone.Engine;
using _361Capstone.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace _361Capstone.Tests.UnitTesting.TestsEngine
{
    [TestClass]
    public class AuthenticatePasswordTest
    {
        [TestMethod]
        public void AuthenticatePassword_Pass()
        {
            AuthenticationEngine engine = new AuthenticationEngine();
            string password = "123myPassword";

            bool test = engine.AuthenticatePassword(password);

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(test);
        }
    }
}
