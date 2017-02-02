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
        static void Main(string[] args)
        {
            Random r = new Random();
            
            List<HourlyWorker> hourlyWorkerList = new List<HourlyWorker>()
            {
                new HourlyWorker(25, "Logi", "Tech"),

            };
            List<SalaryWorker> salaryWorkerList = new List<SalaryWorker>() {

                new SalaryWorker(104000, "John", "Mack"),

             };
            List<VolunteerWorker> volunteerWorkerList = new List<VolunteerWorker>() {
                new VolunteerWorker("Hobs", "Carb"),
             };

            int allHoursWorked = 0;
            double allPay = 0;
            string a = "Employee".PadRight(40) + "Hours Worked".PadRight(40) + "pay";
            Console.WriteLine(a+"\n");

            foreach (HourlyWorker worker in hourlyWorkerList)
            {
                int random = r.Next(0, 100);
                allHoursWorked += random;
                string s = worker.FirstName.PadRight(40) + random.ToString().PadRight(40) + worker.CalculateWeeklyPay(random);
                Console.WriteLine(s);
                allPay += worker.CalculateWeeklyPay(random);
            }
            Console.WriteLine();




            foreach (VolunteerWorker worker in volunteerWorkerList)
            {
                int random = r.Next(0, 100);
                allHoursWorked += random;

                Console.WriteLine(worker.FirstName + "      " + random + "         " + worker.CalculateWeeklyPay(random));
                allPay += worker.CalculateWeeklyPay(random);
            }
            Console.WriteLine();
            foreach (SalaryWorker worker in salaryWorkerList)
            {
                int random = r.Next(0, 100);
                allHoursWorked += random;

                Console.WriteLine(worker.FirstName + " " + random + "              " + worker.CalculateWeeklyPay(random));
                allPay += worker.CalculateWeeklyPay(random);
            }
            Console.WriteLine();

            Console.WriteLine("Total Hours:"+allHoursWorked);
            Console.WriteLine("Total Pay: $"+ allPay);
            Console.ReadKey();
        }
    }
}
