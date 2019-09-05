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

        [TestMethod]
        public void ToIntOrDefault_整数形式の文字列をINT型へ変換()
        {
            Assert.AreEqual("1".ToIntOrDefault(), 1);
            Assert.AreEqual("01".ToIntOrDefault(), 1);
            Assert.AreEqual("1".ToIntOrDefault(5), 1);
            Assert.AreEqual("01".ToIntOrDefault(5), 1);
        }

        [TestMethod]
        public void ToIntOrDefault_整数形式への変換が失敗した場合デフォルト値が戻る()
        {
            Assert.AreEqual("a".ToIntOrDefault(), 0);
            Assert.AreEqual("a".ToIntOrDefault(1), 1);
        }
    }
}
