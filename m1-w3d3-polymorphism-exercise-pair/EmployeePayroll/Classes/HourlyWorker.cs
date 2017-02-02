using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll.Classes
{
    public class HourlyWorker : IWorker
    {
        private double hourlyRate;
        private string firstName;
        private string lastName;
        private int hoursWorked;
        private double pay;
       
        public double Pay {
            get { return CalculateWeeklyPay(HoursWorked); } 
            set {pay = CalculateWeeklyPay(HoursWorked);}
        }

        public int HoursWorked {
            get {return hoursWorked; }
            set { hoursWorked = value; }
        }
        public string FirstName { get { return firstName; } }
        public string LastName { get { return lastName; } }

        public double HourlyRate
        {
            get { return hourlyRate; }
            set { hourlyRate = value; }
        }


        public HourlyWorker(double hourlyRate, string firstName, string lastName)
        {
            this.hourlyRate = hourlyRate;
            this.firstName = firstName;
            this.lastName = lastName;
        }





        public double CalculateWeeklyPay(int HoursWorked)
        {
            pay = HoursWorked * hourlyRate;
            if (HoursWorked > 40)
            {
                int overtime = HoursWorked - 40;
                pay = pay + (hourlyRate * overtime * .5);
            }
            return pay;
        }
    }
}
