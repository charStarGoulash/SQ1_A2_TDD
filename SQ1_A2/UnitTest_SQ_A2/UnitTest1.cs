﻿using System;
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
    }
}