using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeePayroll.Classes;

namespace Polymorphism.Tests
{
    [TestClass]
    public class VolunteerWorkerTest
    {
        [TestMethod]
        public void VolunteerWorkerAllTests()
        {
            VolunteerWorker salaryTest = new VolunteerWorker( "Jacob", "Rutter");
            Assert.AreEqual(0, salaryTest.CalculateWeeklyPay(10));
            Assert.AreEqual("Jacob", salaryTest.FirstName);
            Assert.AreEqual("Rutter", salaryTest.LastName);

        }
    }
}
