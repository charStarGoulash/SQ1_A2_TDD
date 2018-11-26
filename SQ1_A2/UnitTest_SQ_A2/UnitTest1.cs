using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SQ1_A2;

namespace UnitTest_SQ_A2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_MissingAngle()
        {
            Triangle obj = new Triangle();
            double result = obj.GetMissingAngle(45, 45);
            Assert.AreEqual(90, result);
        }

        [TestMethod]
        public void Test_MissingAngle_Exception()
        {
            Triangle obj = new Triangle();
            double result = obj.GetMissingAngle(200, 45);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void Test_FindHypotenuse()
        {
            Triangle obj = new Triangle();
            double result = obj.FindHypotenuse(25, 25);
            Assert.AreEqual(35.36, result);
        }
    }
}
