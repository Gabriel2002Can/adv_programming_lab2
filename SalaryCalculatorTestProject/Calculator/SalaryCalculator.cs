using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class SalaryCalculator
    {
        const int HoursInYear = 2080;

        public decimal GetAnnualSalary(decimal hourlyWage)
        {
            decimal annualSalary = hourlyWage * HoursInYear;

            if (annualSalary <= 0)
            {
                throw new InvalidOperationException("Hourly wage cannot be negative or zero");
            }

            return annualSalary;
        }
    
        public decimal GetHourlyWage(int annualSalary)
        {
            decimal hourlysalary = annualSalary / HoursInYear;

            if (hourlysalary <= 0)
            {
                throw new InvalidOperationException("Annual salary cannot be negative or zero");
            }

            return hourlysalary;
        }

        public TaxData GetTaxWeekly(decimal weekSalary, int numberOfDependents)
        {
            TaxData taxData = new TaxData(weekSalary, numberOfDependents);

            return taxData;
        }
    }
}
