using System;
using AnalaizerClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnalaizerClassTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCheckCurrency()
        {
            analaizerClass.expression = "(2+2(2+3))";

            Assert.AreEqual(true, analaizerClass.CheckCurrency());

            //Assert.AreEqual(5, analaizerClass.Erposition);
        }
    }
}
