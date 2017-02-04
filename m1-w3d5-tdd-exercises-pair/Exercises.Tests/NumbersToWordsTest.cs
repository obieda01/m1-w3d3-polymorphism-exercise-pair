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
            Assert.AreEqual("five", new NumbersToWords().numberInWords(5));

        }
        [TestMethod]
        public void twoDigitsCalculation()
        {
          Assert.AreEqual("eleven", new NumbersToWords().numberInWords(11));
          Assert.AreEqual("fifty", new NumbersToWords().numberInWords(50));
          Assert.AreEqual("twenty-one", new NumbersToWords().numberInWords(21));
          Assert.AreEqual("fifty-five", new NumbersToWords().numberInWords(55));
        }
        [TestMethod]
        public void threeDigitsCalculation()
        {
            Assert.AreEqual("one hundred", new NumbersToWords().numberInWords(100));
            Assert.AreEqual("one hundred and thirty-three", new NumbersToWords().numberInWords(133));
            Assert.AreEqual("two hundred and fifty-one", new NumbersToWords().numberInWords(251));

        }
        [TestMethod]
        public void fourDigitsCalculation()
        {
            Assert.AreEqual("one thousand", new NumbersToWords().numberInWords(1000));
            Assert.AreEqual("two thousand and one hundred and thirty-three", new NumbersToWords().numberInWords(2133));
            Assert.AreEqual("five thousand and two hundred and fifty-one", new NumbersToWords().numberInWords(5251));

        }
        [TestMethod]
        public void fiveDigitsCalculation()
        {        
            Assert.AreEqual("ten thousand", new NumbersToWords().numberInWords(10000));
            Assert.AreEqual("eleven thousand", new NumbersToWords().numberInWords(11000));
            Assert.AreEqual("thirteen thousand and four hundred and sixty-seven", new NumbersToWords().numberInWords(13467));
        }   
        [TestMethod]
        public void SixDigitsTests()
        {
            Assert.AreEqual("one hundred thousand", new NumbersToWords().numberInWords(100000));
            Assert.AreEqual("one hundred and one thousand", new NumbersToWords().numberInWords(101000));
            Assert.AreEqual("nine hundred and ninety-nine thousand and nine hundred and ninety-nine", new NumbersToWords().numberInWords(999999));

        }
    }
}
