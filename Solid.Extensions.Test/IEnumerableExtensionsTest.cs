using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solid.Extensions.Test
{
    [TestClass]
    public class IEnumerableExtensionsTest
    {
        [TestMethod]
        public void IsNullOrEmpty_NullorEmptyの時にTrueを戻す()
        {
            IEnumerable<int> test = null;
            Assert.AreEqual(test.IsNullOrEmpty(), true);

            test = new int[] { };
            Assert.AreEqual(test.IsNullOrEmpty(), true);
        }

        [TestMethod]
        public void IsNullOrEmpty_NullorEmptyでない時にFalseを戻す()
        {
            var test = Enumerable.Range(0, 4);
            Assert.AreEqual(test.IsNullOrEmpty(), false);
        }
    }
}
