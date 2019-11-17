using System;
using ClassAnalaizer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnalaizerClassTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCheckCurrency()
        {
            AnalaizerClass.expression = "(2+2(2+3))";

            Assert.AreEqual(true, AnalaizerClass.CheckCurrency());

            ///Assert.AreEqual(5, analaizerClass.Erposition);
        }
    }
}
