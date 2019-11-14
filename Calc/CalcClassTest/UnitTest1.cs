using System;
using CalcClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcClassTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodAdd()
        {                      
            Assert.AreEqual(5.0, CalcClas.Add(2, 3));
        }


        [TestMethod]
        public void TestMethodSub()
        {
            Assert.AreEqual(6.0, CalcClas.Sub(9, 3));
        }


        [TestMethod]
        public void TestMethodMult()
        {
            Assert.AreEqual(6.0, CalcClas.Mult(2, 3));
        }


        [TestMethod]
        public void TestMethodDiv()
        {
            Assert.AreEqual(4.0, CalcClas.Div(12, 3));
        }


        [TestMethod]
        public void TestMethodMod()
        {
            Assert.AreEqual(1.0, CalcClas.Mod(5, 2));
        }

        [TestMethod]
        public void TestMethodABS()
        {
            Assert.AreEqual(6.0, CalcClas.ABS(2));
        }

        [TestMethod]
        public void TestMethodABSI()
        {
            Assert.AreEqual(6.0, CalcClas.IABS(3));
        }


    }
}
