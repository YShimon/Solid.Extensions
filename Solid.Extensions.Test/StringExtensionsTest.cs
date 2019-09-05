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

        [TestMethod]
        public void ToIntOrDefault_�����`���̕������INT�^�֕ϊ�()
        {
            Assert.AreEqual("1".ToIntOrDefault(), 1);
            Assert.AreEqual("01".ToIntOrDefault(), 1);
            Assert.AreEqual("1".ToIntOrDefault(5), 1);
            Assert.AreEqual("01".ToIntOrDefault(5), 1);
        }

        [TestMethod]
        public void ToIntOrDefault_�����`���ւ̕ϊ������s�����ꍇ�f�t�H���g�l���߂�()
        {
            Assert.AreEqual("a".ToIntOrDefault(), 0);
            Assert.AreEqual("a".ToIntOrDefault(1), 1);
        }
    }
}
