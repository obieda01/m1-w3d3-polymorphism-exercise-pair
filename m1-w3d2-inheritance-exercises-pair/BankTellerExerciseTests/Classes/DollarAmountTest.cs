using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankTellerExercise.Classes;
namespace BankTellerExerciseTests.Classes
{
    [TestClass]
    public class DollarAmountTest
    {
        [TestMethod]
        public void DollarAmount_ToStringTest()
        {
            string expected = "$32.10";
            DollarAmount testedInstance = new DollarAmount(32, 10);
            Assert.AreEqual(expected, testedInstance.ToString());
            expected = "$-32.10";
            DollarAmount negativeTestedInstance = new DollarAmount(-32, -10);
            Assert.AreEqual(expected, negativeTestedInstance.ToString());
        }
    }
}
