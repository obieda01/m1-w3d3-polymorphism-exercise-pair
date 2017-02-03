using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDExercises;

namespace TDDExercises.Tests
{
    [TestClass]
    public class StringCalculatorTest
    {
        [TestMethod]
        public void TestStringForSumOfItems()
        {
            Assert.AreEqual(0, new StringCalculator().add(""));
            Assert.AreEqual(5, new StringCalculator().add("5"));
            Assert.AreEqual(12, new StringCalculator().add("5,7"));
            Assert.AreEqual(25, new StringCalculator().add("5,10,5,3,2"));
            Assert.AreEqual(25, new StringCalculator().add("5\n10,5,3\n2"));
            Assert.AreEqual(25, new StringCalculator().add("//!5,10!5\n3!2"));
        }
    }
}
