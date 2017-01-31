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
            Assert.AreEqual("$10.00", testedInstanceBankAccount.Withdraw(new DollarAmount(1010)).ToString());
            Assert.AreEqual("$10.00", testedInstanceBankAccount.Withdraw(new DollarAmount(2000)).ToString());
            Assert.AreEqual("$10.00", testedInstanceBankAccount.Withdraw(new DollarAmount(10000)).ToString());
            Assert.AreEqual("$1.00", testedInstanceBankAccount.Withdraw(new DollarAmount(700)).ToString());

            Assert.AreEqual("$1.00", testedInstanceBankAccount.Withdraw(new DollarAmount(900)).ToString());

            testedInstanceBankAccount = new SavingAccount();
            testedInstanceBankAccount.Deposit(new DollarAmount(1000));
            Assert.AreEqual("$3.00", testedInstanceBankAccount.Withdraw(new DollarAmount(500)).ToString());

            testedInstanceBankAccount = new SavingAccount();
            testedInstanceBankAccount.Deposit(new DollarAmount(50000));
            Assert.AreEqual("$490.00", testedInstanceBankAccount.Withdraw(new DollarAmount(1000)).ToString());
        }
    }
}
