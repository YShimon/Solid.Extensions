using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solid.Extensions.Test
{
    /// <summary>
    /// StringExtensionsのテストクラス
    /// </summary>
    [TestClass]
    public class StringExtensionsTest
    {
        [TestMethod]
        public void IsNullOrEmpty_NullorEmptyの時にTrueを戻す()
        {
            var test = string.Empty;
            Assert.AreEqual(test.IsNullOrEmpty(), true);

            test = null;
            Assert.AreEqual(test.IsNullOrEmpty(), true);
        }

        [TestMethod]
        public void IsNullOrEmpty_NullorEmptyでない時にFalseを戻す()
        {
            var test = "SampleString";
            Assert.AreEqual(test.IsNullOrEmpty(), false);
        }
    }
}
