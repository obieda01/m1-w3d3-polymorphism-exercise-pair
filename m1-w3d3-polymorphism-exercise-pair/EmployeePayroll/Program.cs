using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeePayroll.Classes;

namespace EmployeePayroll
{
    class Program
    {

        public static void writeToConsole(string f, string m, string l)
        {
            Console.WriteLine(f.PadRight(35) + m.PadRight(35) + l);

        }

        static void Main(string[] args)
        {
            Random r = new Random();
            int allHoursWorked = 0;
            double allPay = 0;

            List<IWorker> iWorkerList = new List<IWorker>()
            {
                new HourlyWorker(25, "Logi", "Tech"),new SalaryWorker(104000, "John", "Mack"),
                 new VolunteerWorker("Hobs", "Carb"),
            };

            writeToConsole("Employee", "Hours Worked", "pay");
            Console.WriteLine("*********************************************************************************************\n");

            foreach (IWorker worker in iWorkerList)
            {
                int random = r.Next(0, 100);
                allHoursWorked += random;
                writeToConsole(worker.FirstName, random.ToString(), worker.CalculateWeeklyPay(random).ToString());

                allPay += worker.CalculateWeeklyPay(random);
            }


            Console.WriteLine("Total Hours:" + allHoursWorked);
            Console.WriteLine("Total Pay: $" + allPay);
            Console.ReadKey();
        }
    }
}
