using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTellerExercise.Classes
{
    public class BankAccount
    {
        private string accountNumber;

        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        private DollarAmount balance = new DollarAmount(0);

        public DollarAmount Balance
        {
            get { return balance; }
        }

        public DollarAmount Deposit(DollarAmount amountToDeposit)

        {
            int balanceToCents = convertBalanceToCents(balance.Dollars, balance.Cents) + convertBalanceToCents(amountToDeposit.Dollars, amountToDeposit.Cents);
            balance = new DollarAmount(balanceToCents/100,balanceToCents%100);
            return balance;
        }

        public DollarAmount Withdraw(DollarAmount amountToWithdraw)

        {
            int balanceToCents = convertBalanceToCents(balance.Dollars, balance.Cents) - convertBalanceToCents(amountToWithdraw.Dollars, amountToWithdraw.Cents);
            balance = new DollarAmount(balanceToCents);
            return balance;
        }

        public int convertBalanceToCents(int D, int cents)
        {
            return (D * 100)+cents;

        }
        public void Transfer(BankAccount destinationAccount, DollarAmount transferAmount)

        {
            //int amountInCentsToTransfer = convertBalanceToCents(transferAmount.Dollars, transferAmount.Cents);
            DollarAmount x = Withdraw(transferAmount);
            destinationAccount.Deposit(x);
        }

    }
}
