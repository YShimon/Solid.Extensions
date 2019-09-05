using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solid.Extensions.Test.Utility;
using System;
using System.Linq;

namespace Solid.Extensions.Test
{
    [TestClass]
    public class EnumExtensionsTest
    {
        [TestMethod]
        public void DisplayName_属性名称を取得()
        {
            Enum.GetValues(typeof(TestEnum)).Cast<TestEnum>()
                .ForEach(x => 
                {
                    switch (x)
                    {
                        case TestEnum.One:
                            Assert.AreEqual(x.DisplayName(), "壱");
                            break;

                        case TestEnum.Two:
                            Assert.AreEqual(x.DisplayName(), "弐");
                            break;

                        case TestEnum.Three:
                            Assert.AreEqual(x.DisplayName(), "参");
                            break;

                        case TestEnum.Four:
                            Assert.AreEqual(x.DisplayName(), "Four");
                            break;

                        default:
                            break;
                    }
                });
        }
    }
}
