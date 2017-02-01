using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankTellerExercise.Classes;

namespace BankTellerExerciseTests.Classes
{
    [TestClass]
    public class BankCustomerTest
    {
        [TestMethod]
        public void BankCustomer_AddAccountTests()
        {
            BankCustomer TestedInstanceBankCustomer = new BankCustomer();
            BankAccount First = new BankAccount();
            BankAccount Second = new BankAccount();
            TestedInstanceBankCustomer.Accounts = new BankAccount[] { First, Second };    

            BankCustomer Tested = new BankCustomer();
            Tested.AddAccount(First);
            Tested.AddAccount(Second);
            Assert.AreEqual(TestedInstanceBankCustomer.Accounts.Length, Tested.Accounts.Length);

        }
        [TestMethod]
        public void BankCustomer_isVIPTests()
        {
            BankCustomer TestedVip = new BankCustomer();
            BankAccount First = new BankAccount();
            BankAccount Second = new BankAccount();
            TestedVip.Accounts = new BankAccount[] { First, Second, new BankAccount()};
            TestedVip.Accounts[0].Deposit(new DollarAmount(100));
            TestedVip.Accounts[1].Deposit(new DollarAmount(500));
            TestedVip.Accounts[2].Deposit(new DollarAmount(1000));
            Assert.IsFalse(TestedVip.isVipCustomer());
            TestedVip.Accounts[0].Deposit(new DollarAmount(250000));
            TestedVip.Accounts[1].Deposit(new DollarAmount(500000000));
            TestedVip.Accounts[2].Deposit(new DollarAmount(1000000));
            Assert.IsTrue(TestedVip.isVipCustomer());
        }
    }
}
