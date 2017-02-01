using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeePayroll.Classes;

namespace Polymorphism.Tests
{
    [TestClass]
    public class SalaryWorkerTest
    {
        [TestMethod]
        public void SalaryWorkerAllTests()
        {
            SalaryWorker salaryTest = new SalaryWorker(114400, "Jacob", "Rutter");
            Assert.AreEqual(2200, salaryTest.CalculateWeeklyPay(10));
            Assert.AreEqual("Jacob", salaryTest.FirstName);
            Assert.AreEqual("Rutter", salaryTest.LastName);
          
        }
    }
}
