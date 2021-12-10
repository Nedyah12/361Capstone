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
    public class AuthenticateUserTest
    {
        //[Test]
        public void AunthenticateUser_Pass()
        {
            AuthenticationEngine engine = new AuthenticationEngine();
            string username = "";

            bool test = engine.AuthenticateUser(username);

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(test);
        }
    }
}