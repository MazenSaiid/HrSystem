using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.OOP.Syste_
{
    internal class PaySlipGenerator
    {
        private readonly INotifier _notifier;

        public PaySlipGenerator(INotifier notifier) 
        {
            _notifier = notifier;
        }
        public void Generate(Employee employee)
        {
            var payItems = employee.GetPayItems();
            var message = new StringBuilder();
            message.AppendLine($"Dear {employee.FirstName} {employee.LastName},");
            message.AppendLine("Kindly find your slip details.");
            foreach (var item in payItems)
            {
                message.AppendLine($"\t {item.Name} {item.Value}");
            }
            message.AppendLine("Best Regards");
            _notifier.Notify(employee.Email,"PaySlip Generated!!",message.ToString());
            
        }
    }
}
