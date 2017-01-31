using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankTellerExercise.Classes;

namespace BankTellerExercise.Classes
{
    public class CheckingAccount : BankAccount
    {
        public override DollarAmount Withdraw(DollarAmount amountToWithdraw)

        {

            int balanceToCents = convertBalanceToCents(Balance.Dollars, Balance.Cents) - convertBalanceToCents(amountToWithdraw.Dollars, amountToWithdraw.Cents);

            if (balanceToCents < 0 && balanceToCents > -10000)
            {
                this.balance= new DollarAmount(balanceToCents - 1000);
                return balance;
            }
            else if (balanceToCents < -10000)
            {
                return balance;
            }

            {
                this.balance =balance.Minus( new DollarAmount(balanceToCents));
                return balance;
            }
        }
    }
}
