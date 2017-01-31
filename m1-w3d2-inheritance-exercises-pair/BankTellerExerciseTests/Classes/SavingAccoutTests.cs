using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankTellerExercise.Classes;
namespace BankTellerExerciseTests.Classes
{
    [TestClass]
    public class SavingAccoutTests
    {
        [TestMethod]
        public void SavingAccout_Withdraw_Tests()
        {
            DollarAmount testedInstanceExpected = new DollarAmount(1000);
            int expectedCents = testedInstanceExpected.Dollars * 100 + testedInstanceExpected.Cents;
            SavingAccount testedInstanceBankAccount = new SavingAccount();
            testedInstanceBankAccount.Deposit(new DollarAmount(1000));
            Assert.AreEqual("$-2.10", testedInstanceBankAccount.Withdraw(new DollarAmount(1010)).ToString());
            Assert.AreEqual("$-24.10", testedInstanceBankAccount.Withdraw(new DollarAmount(2000)).ToString());
            Assert.AreEqual("$-126.10", testedInstanceBankAccount.Withdraw(new DollarAmount(10000)).ToString());
            testedInstanceBankAccount = new SavingAccount();
            testedInstanceBankAccount.Deposit(new DollarAmount(1000));
            Assert.AreEqual("$5.00", testedInstanceBankAccount.Withdraw(new DollarAmount(500)).ToString());

        }
    }
}
