using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.OOP.Syste_
{
    internal interface INotifier
    {
        void Notify(string email, string subject, string body);
    }
}
