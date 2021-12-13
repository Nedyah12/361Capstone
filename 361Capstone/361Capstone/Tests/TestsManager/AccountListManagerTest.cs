using System;
using _361Capstone.Managers;
using _361Capstone.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace _361Capstone.Tests.UnitTesting.TestsManager
{
    [TestClass]
    public class AccountListManagerTest
    {
        [TestMethod]
        public void getUser_Pass()
        {
            AccountListManager accountListManager = new AccountListManager();

            User user = accountListManager.GetUser(128);

            /*if (user.GetUserId() != 128)
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.Fail();
            }*/
        }
    }
}