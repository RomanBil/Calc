using System;
using ClassCalc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcClassTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodAdd()
        {                      
            Assert.AreEqual(0, CalcClass.Add(2, 2147483649));
        }


        [TestMethod]
        public void TestMethodSub()
        {
            Assert.AreEqual((decimal)6.0, CalcClass.Sub(9, 3));
        }


        [TestMethod]
        public void TestMethodMult()
        {
            Assert.AreEqual((decimal)6.0, CalcClass.Mult(2, 3));
        }


        [TestMethod]
        public void TestMethodDiv()
        {
            Assert.AreEqual((decimal)4.0, CalcClass.Div(12, 3));
        }


        [TestMethod]
        public void TestMethodMod()
        {
            Assert.AreEqual((decimal)1.0, CalcClass.Mod(5, 2));
        }

        [TestMethod]
        public void TestMethodABS()
        {
            Assert.AreEqual(6.0, CalcClass.ABS(2));
        }

        [TestMethod]
        public void TestMethodABSI()
        {
            Assert.AreEqual(6.0, CalcClass.IABS(3));
        }


    }
}
