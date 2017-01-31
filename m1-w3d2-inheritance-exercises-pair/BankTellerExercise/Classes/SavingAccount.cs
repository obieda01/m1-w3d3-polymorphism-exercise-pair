using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTellerExercise.Classes
{
    public class SavingAccount : BankAccount
    {
        public override DollarAmount Withdraw(DollarAmount amountToWithdraw)

        {

            int balanceToCents = convertBalanceToCents(Balance.Dollars, Balance.Cents) - convertBalanceToCents(amountToWithdraw.Dollars, amountToWithdraw.Cents);

            if (balanceToCents > 0 &&convertBalanceToCents(Balance.Dollars, Balance.Cents) < 15000)
            {
                this.balance = new DollarAmount(balanceToCents - 200);
                return balance;
            }
            else if (balanceToCents <= 0)
            {
                return balance;
            }
            else
            {
                balance = new DollarAmount(balanceToCents);
                return balance;
            }
        }
    }
}
