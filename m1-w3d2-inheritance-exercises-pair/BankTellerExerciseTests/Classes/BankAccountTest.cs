using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankTellerExercise.Classes;


namespace BankTellerExerciseTests.Classes
{
    [TestClass]
    public class BankAccountTest
    {
        [TestMethod]
        public void BankAccount_DepositTests()
        {
            DollarAmount testedInstanceExpected = new DollarAmount(1000);
            int expectedCents = testedInstanceExpected.Dollars * 100 + testedInstanceExpected.Cents;
            BankAccount testedInstanceBankAccount = new BankAccount();


            DollarAmount testedInstanceActualDollarAmount = new DollarAmount(0);

            DollarAmount testedInstanceActualAmountAfterDeposit = testedInstanceBankAccount.Deposit(testedInstanceExpected);

            int actualAmountAfterDeposit = testedInstanceActualAmountAfterDeposit.Dollars * 100 + testedInstanceActualAmountAfterDeposit.Cents;
            Assert.AreEqual(expectedCents, actualAmountAfterDeposit);

        }
        [TestMethod]
        public void BankAccount_WithdrawTests()
        {
            DollarAmount testedInstanceExpected = new DollarAmount(1000);
            int expectedCents = testedInstanceExpected.Dollars * 100 + testedInstanceExpected.Cents;
            BankAccount testedInstanceBankAccount = new BankAccount();


            DollarAmount testedInstanceActualDollarAmount = new DollarAmount(2000);
            testedInstanceBankAccount.Deposit(testedInstanceActualDollarAmount);

            DollarAmount testedInstanceActualAmountAfterWithdraw = testedInstanceBankAccount.Withdraw(testedInstanceExpected);

            int actualAmountAfterWithdraw = testedInstanceActualAmountAfterWithdraw.Dollars * 100 + testedInstanceActualAmountAfterWithdraw.Cents;
            Assert.AreEqual(expectedCents, actualAmountAfterWithdraw);

        }

        [TestMethod]
        public void BankAccount_WithdrawTests()
        {
            DollarAmount testedInstanceExpected = new DollarAmount(1000);
            int expectedCents = testedInstanceExpected.Dollars * 100 + testedInstanceExpected.Cents;
            BankAccount testedInstanceBankAccount = new BankAccount();


            DollarAmount testedInstanceActualDollarAmount = new DollarAmount(2000);
            testedInstanceBankAccount.Deposit(testedInstanceActualDollarAmount);

            DollarAmount testedInstanceActualAmountAfterWithdraw = testedInstanceBankAccount.Withdraw(testedInstanceExpected);

            int actualAmountAfterWithdraw = testedInstanceActualAmountAfterWithdraw.Dollars * 100 + testedInstanceActualAmountAfterWithdraw.Cents;
            Assert.AreEqual(expectedCents, actualAmountAfterWithdraw);

        }

    }
}
