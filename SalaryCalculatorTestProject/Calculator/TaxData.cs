using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class TaxData
    {
        public decimal ProvincialTaxWithheld { get; set; }
        public decimal FederalTaxWithheld { get; set; }
        public decimal DependentDeduction { get; set; }
        public decimal TotalWithheld { get; set; }
        public decimal TotalTakeHome { get; set; }

        //Federal and Provincial tax rates
        decimal provincialTaxRate = 0.06m;
        decimal federalTaxRate = 0.25m;

        public TaxData(decimal weekSalary, int numOfDependents) { 

        this.ProvincialTaxWithheld = weekSalary * (provincialTaxRate);

        this.FederalTaxWithheld = weekSalary * (federalTaxRate);

        this.DependentDeduction = weekSalary * (numOfDependents * 0.02m);

        this.TotalWithheld = ProvincialTaxWithheld + FederalTaxWithheld - DependentDeduction;

        this.TotalTakeHome = weekSalary - TotalWithheld;

        }
    }
}
