using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.OOP.Syste_
{
    internal class Intern : Employee
    {
        public override IEnumerable<PayItem> GetPayItems()
        {
            return new[] { new PayItem("Basic Salary",2000) };
        }

        public override decimal GetSalary()
        {
            return 2000m;
        }
    }
}
