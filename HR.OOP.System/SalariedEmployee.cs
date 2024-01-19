using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.OOP.Syste_
{
    internal class SalariedEmployee : Employee
    {
        public decimal BasicSalary { get; set; }
        public decimal Transportation { get; set; }
        public decimal Housing { get; set; }

        public override IEnumerable<PayItem> GetPayItems()
        {
            return new[] {
                new PayItem("BasicSalary", BasicSalary),
                new PayItem("Transportation", Transportation),
                new PayItem("Housing", Housing)
            };
        }

        public override decimal GetSalary()
        {
            return BasicSalary + Transportation + Housing;
        }
        public decimal GetSalary(int taxPercentage)
        {
            return GetSalary() - (BasicSalary * taxPercentage / 100);
        }
        public decimal GetSalary(int taxPercentage, decimal bonus)
        {
            return GetSalary(taxPercentage) + bonus;
        }
    }
}
