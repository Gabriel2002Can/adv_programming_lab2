using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace SalaryCalculatorTestProject
{
    /*		
        To get hourly, divide annual salary by 2080     
        $100,006.40 / 2080 = $48.08  hr

        To get annual, multiply hourly by 2080 
        $48.08 * 2080 = $100,006.40
    */

    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void AnnualSalaryTest()
        {
            // Arrange
            SalaryCalculator sc = new SalaryCalculator();

            // Act
            try
            {
                decimal annualSalary = sc.GetAnnualSalary(-50);
                // Assert   
                Assert.Fail("This code should not be run");
            }
            catch (InvalidOperationException ex)
            {
                Assert.AreEqual("Hourly wage cannot be negative or zero", ex.Message);
            }

        }

        [TestMethod]
        public void HourlyWageTest()
        {
            // Arrange
            SalaryCalculator sc = new SalaryCalculator();

            // Act
            try
            {
                decimal hourlyWage = sc.GetHourlyWage(-52000);
                // Assert   
                Assert.Fail("This code should not be run");
            }
            catch (InvalidOperationException ex)
            {
                Assert.AreEqual("Annual salary cannot be negative or zero", ex.Message);


            }
        }

        [TestMethod]
        public void TaxWeeklyTest()
        {
            SalaryCalculator sc = new SalaryCalculator();

            TaxData taxData = sc.GetTaxWeekly(1000, 2);

            Assert.AreEqual(60.0m, taxData.ProvincialTaxWithheld);
            Assert.AreEqual(250.0m, taxData.FederalTaxWithheld);
            Assert.AreEqual(40.0m, taxData.DependentDeduction);
            Assert.AreEqual(270.0m, taxData.TotalWithheld);
            Assert.AreEqual(730.0m, taxData.TotalTakeHome);
        }
    }
}

