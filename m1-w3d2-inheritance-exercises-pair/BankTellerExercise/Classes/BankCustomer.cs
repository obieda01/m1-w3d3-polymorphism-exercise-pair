using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTellerExercise.Classes
{
    public class BankCustomer
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        private string phoneNumber;

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        private BankAccount[]  accounts=new BankAccount[] { };

        public BankAccount[]  Accounts
        {
            get { return accounts; }
            set { accounts = value; }
        }

        public void AddAccount(BankAccount newAccount)
        {

            List<BankAccount> temp = Accounts.ToList<BankAccount>();
            temp.Add(newAccount);
            Accounts = temp.ToArray();

        }
        private bool isVip = false;
        public bool IsVip
        {
            get { return isVipCustomer(); }
            set { isVip = isVipCustomer(); }
        }
        public bool isVipCustomer()
        {
            int sum = 0;
            for (int x=0; x<Accounts.Length; x++)
            {
                sum += Accounts[x].Balance.Dollars*100+ Accounts[x].Balance.Cents;
            }
            if (sum >= 2500000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
