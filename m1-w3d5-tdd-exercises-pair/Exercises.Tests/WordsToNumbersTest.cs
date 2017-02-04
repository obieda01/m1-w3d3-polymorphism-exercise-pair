using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDExercises;

namespace TDDExercises.Tests
{
    [TestClass]
    public class WordsToNumbersTest
    {
        [TestMethod]
        public void WordToNumberS_OneWordTest()
        {
            Assert.AreEqual(0, new WordsToNumbers().transformWordToNum("zero"));
            Assert.AreEqual(3, new WordsToNumbers().transformWordToNum("three"));
            Assert.AreEqual(9, new WordsToNumbers().transformWordToNum("nine"));
            Assert.AreEqual(11, new WordsToNumbers().transformWordToNum("eleven"));
            Assert.AreEqual(15, new WordsToNumbers().transformWordToNum("fifteen"));
            Assert.AreEqual(20, new WordsToNumbers().transformWordToNum("twenty"));
            Assert.AreEqual(80, new WordsToNumbers().transformWordToNum("eighty"));

            Assert.AreEqual(41, new WordsToNumbers().transformWordToNum("fourty-one"));
            Assert.AreEqual(99, new WordsToNumbers().transformWordToNum("ninety-nine"));

        }

        [TestMethod]
        public void WordToNumberS_TwoWordTest()
        {
            Assert.AreEqual(100, new WordsToNumbers().transformWordToNum("one hundred"));
            Assert.AreEqual(1000, new WordsToNumbers().transformWordToNum("one thousand"));
            Assert.AreEqual(11000, new WordsToNumbers().transformWordToNum("eleven thousand"));
            Assert.AreEqual(99000, new WordsToNumbers().transformWordToNum("ninety-nine thousand"));
        }

        [TestMethod]
        public void WordToNumberS_FourWordTest()
        {
            Assert.AreEqual(101, new WordsToNumbers().transformWordToNum("one hundred and one"));
            Assert.AreEqual(1001, new WordsToNumbers().transformWordToNum("one thousand and one"));
            Assert.AreEqual(11041, new WordsToNumbers().transformWordToNum("eleven thousand and fourty-one"));
            Assert.AreEqual(99099, new WordsToNumbers().transformWordToNum("ninety-nine thousand and ninety-nine"));
        }

        [TestMethod]
        public void WordToNumberS_FiveWordTest()
        {
            Assert.AreEqual(1100, new WordsToNumbers().transformWordToNum("one thousand and one hundred"));
            Assert.AreEqual(57300, new WordsToNumbers().transformWordToNum("fifty-seven thousand and three hundred"));
        }

        [TestMethod]
        public void WordToNumberS_SevenWordTest()
        {
            Assert.AreEqual(7454, new WordsToNumbers().transformWordToNum("seven thousand and four hundred and fifty-four"));
            Assert.AreEqual(67454, new WordsToNumbers().transformWordToNum("sixty-seven thousand and four hundred and fifty-four"));
        }

        [TestMethod]
        public void WordToNumberS_NineWordTest()
        {
            Assert.AreEqual(999999, new WordsToNumbers().transformWordToNum("nine hundred and ninety-nine thousand and nine hundred and ninety-nine"));
            Assert.AreEqual(679909, new WordsToNumbers().transformWordToNum("six hundred and seventy-nine thousand and nine hundred and nine"));
        }
    }
}
