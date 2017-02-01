using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeePayroll.Classes;

namespace Polymorphism.Tests
{
    [TestClass]
    public class HourlyWorkerTest
    {
        [TestMethod]
        public void HourlyWorkerAllTests()
        {
            HourlyWorker hourlyTest = new HourlyWorker(5.50, "Jacob", "Rutter");
            Assert.AreEqual(5.50, hourlyTest.HourlyRate);
            Assert.AreEqual("Jacob", hourlyTest.FirstName);
            Assert.AreEqual("Rutter", hourlyTest.LastName);
            Assert.AreEqual(55, hourlyTest.CalculateWeeklyPay(10));
            Assert.AreEqual(302.5, hourlyTest.CalculateWeeklyPay(50));
        }
    }
}
