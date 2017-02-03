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
             
           // Assert.AreEqual("twenty", new NumbersToWords().numberInWords(20));
//Assert.AreEqual("twenty one", new NumbersToWords().numberInWords(21));
        }
        
    }
}
