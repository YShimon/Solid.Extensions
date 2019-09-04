using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solid.Extensions.Test
{
    /// <summary>
    /// StringExtensions�̃e�X�g�N���X
    /// </summary>
    [TestClass]
    public class StringExtensionsTest
    {
        [TestMethod]
        public void IsNullOrEmpty_NullorEmpty�̎���True��߂�()
        {
            var test = string.Empty;
            Assert.AreEqual(test.IsNullOrEmpty(), true);

            test = null;
            Assert.AreEqual(test.IsNullOrEmpty(), true);
        }

        [TestMethod]
        public void IsNullOrEmpty_NullorEmpty�łȂ�����False��߂�()
        {
            var test = "SampleString";
            Assert.AreEqual(test.IsNullOrEmpty(), false);
        }
    }
}
