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
    public class CartProductAccessorTest
    {
        [Test]
        public void RemoveFromIllegal_Fail()
        {
            CartProductAccessor accessor = new CartProductAccessor();

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(accessor.RemoveCartProduct(-1, 1));
            
            return;
        }

        [Test]
        public void RemoveIllegalProduct_Fail()
        {
            CartProductAccessor accessor = new CartProductAccessor();

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(accessor.RemoveCartProduct(1, -1));

            return;
        }
    }
}

