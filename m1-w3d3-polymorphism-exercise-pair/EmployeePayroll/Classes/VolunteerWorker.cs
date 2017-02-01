using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll.Classes
{

    public class VolunteerWorker : IWorker
    {
        private string firstName;
        private string lastName;
        private int pay;


        private int hoursWorked;
        public int HoursWorked
        {
            get { return hoursWorked; }
            set { hoursWorked = value; }
        }

        public int Pay
        {
            get { return Pay; }
            set { pay = 0; }
        }
        public string FirstName { get { return firstName; } }
        public string LastName { get { return lastName; } }



        public VolunteerWorker(string firstName, string lastName)
        {

            this.firstName = firstName;
            this.lastName = lastName;
        }

        public double CalculateWeeklyPay(int hoursWorked)
        {
            return 0;
        }
    }
}
