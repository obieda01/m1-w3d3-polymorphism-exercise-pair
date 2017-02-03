using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDExercises;

namespace TDDExercises.Tests
{
    [TestClass]
    public class NumbersToWordsTest
    {
        [TestMethod]
        public void SingleDigitTest()
        {
            Assert.AreEqual("zero", new NumbersToWords().numberInWords(0));
        }


        [TestMethod]
        public void TensDigitTest()
        {
          Assert.AreEqual("eleven", new NumbersToWords().numberInWords(11));
          Assert.AreEqual("fifty", new NumbersToWords().numberInWords(50));
          Assert.AreEqual("twenty-one", new NumbersToWords().numberInWords(21));
          Assert.AreEqual("fifty-five", new NumbersToWords().numberInWords(55));
        }
        [TestMethod]
        public void HundredsDigitTest()
        {
            Assert.AreEqual("one hundred", new NumbersToWords().numberInWords(100));
            Assert.AreEqual("one hundred thirty-three", new NumbersToWords().numberInWords(133));
        }

    }
}
