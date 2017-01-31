using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankTellerExercise.Classes;

namespace BankTellerExerciseTests.Classes
{
    [TestClass]
    public class CheckingAccountTests
    {
        [TestMethod]
        public void CheckingAccount_WithdrawTests()
        {
            DollarAmount testedInstanceExpected = new DollarAmount(1000);
            int expectedCents = testedInstanceExpected.Dollars * 100 + testedInstanceExpected.Cents;
            CheckingAccount testedInstanceBankAccount = new CheckingAccount();
            testedInstanceBankAccount.Deposit(new DollarAmount(1000));
            Assert.AreEqual("$-10.10", testedInstanceBankAccount.Withdraw(new DollarAmount(1010)).ToString());
            Assert.AreEqual("$-40.10", testedInstanceBankAccount.Withdraw(new DollarAmount(2000)).ToString());
            Assert.AreEqual("$-40.10", testedInstanceBankAccount.Withdraw(new DollarAmount(10000)).ToString());
            testedInstanceBankAccount = new CheckingAccount();
            testedInstanceBankAccount.Deposit(new DollarAmount(1000));
            Assert.AreEqual("$5.00", testedInstanceBankAccount.Withdraw(new DollarAmount(500)).ToString());


        }
    }
}
