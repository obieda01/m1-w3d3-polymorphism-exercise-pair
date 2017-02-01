using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeePayroll.Classes;

namespace EmployeePayroll.Classes
{
    public class SalaryWorker: IWorker
    {
        private double annualSalary;
        private string firstName;
        private string lastName;
        private double pay;
        private int hoursWorked;
        public int HoursWorked
        {
            get { return hoursWorked; }
            set { hoursWorked = value; }
        }

        public double Pay {
            get { return CalculateWeeklyPay(0); }
            set { pay = CalculateWeeklyPay(1); }
        }

        public string FirstName { get { return firstName; } }
        public string LastName { get { return lastName; } }

        public double AnnualSalary
        {
            get { return annualSalary; }
            set { annualSalary = value; }
        }


        public SalaryWorker(double annualSalary, string firstName, string lastName)
        {
            this.annualSalary = annualSalary;
            this.firstName = firstName;
            this.lastName = lastName;
        }


       

       
       public double CalculateWeeklyPay(int HoursWorked)
        {
            pay = annualSalary / 52;
            return pay;
        }
    }
}
