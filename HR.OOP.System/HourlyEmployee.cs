using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.OOP.Syste_
{
    internal class HourlyEmployee : Employee
    {
        public decimal HourRate { get; set; }
        public decimal TotalHours { get; set; }

        public override IEnumerable<PayItem> GetPayItems()
        {
            return new[] { new PayItem("Total in Hours", GetSalary()) };
        }

        public override decimal GetSalary()
        {
            return HourRate * TotalHours;
        }
    }
}
