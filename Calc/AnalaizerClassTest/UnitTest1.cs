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

        [TestMethod]
        public void TestFormat()
        {
            AnalaizerClass.expression = "6*5";


            Assert.AreEqual("6 * 5", AnalaizerClass.Format());
        }

        //[TestMethod]
        //public void TestCreateStack()
        //{
        //    AnalaizerClass.expression = 

        //    Assert.AreEqual(, AnalaizerClass.CreateStack());
        //}

        [TestMethod]
        public void TestRunEstimate()
        {
            AnalaizerClass.expression = "6*5";

            Assert.AreEqual("30", AnalaizerClass.RunEstimate());
        }

        [TestMethod]
        public void TestEstimate()
        {
            AnalaizerClass.expression = "6*5";

            Assert.AreEqual("30", AnalaizerClass.Estimate());
        }
    }
}
