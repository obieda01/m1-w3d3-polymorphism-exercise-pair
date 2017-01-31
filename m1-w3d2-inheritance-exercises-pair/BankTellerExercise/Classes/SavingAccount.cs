using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTellerExercise.Classes
{
    class SavingAccount : BankAccount
    {
        public override DollarAmount Withdraw(DollarAmount amountToWithdraw)

        {

            int balanceToCents = convertBalanceToCents(Balance.Dollars, Balance.Cents) - convertBalanceToCents(amountToWithdraw.Dollars, amountToWithdraw.Cents);

            if (balanceToCents < 15000)
            {
                return new DollarAmount(balanceToCents - 200);
            }
            else if (balanceToCents < 0)
            {
                return Balance;
            }
        }
    }
}
