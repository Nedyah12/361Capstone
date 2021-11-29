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
    public class UserAccessorChangePasswordTest
    {
        [Test]
        public void ChangePassword_ReturnTrue()
        {
            UserListsAccessor accessor = new UserListsAccessor();
            User user = accessor.GetUser(2);
            string newPass = "123dog";

            accessor.changePassword(2, newPass);
            user = accessor.GetUser(2);

            if (!user.GetPassword().Equals(newPass))
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.Fail();
            } 

            return;
        }
    }
}
