using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.OOP.Syste_
{
    internal class Notifier : INotifier
    {
        public Notifier(string sntpServer,int port, string senderAddress, string senderPassword)
        {
            SntpServer = sntpServer;
            Port = port;
            SenderAddress = senderAddress;
            SenderPassword = senderPassword;
        }
        public string SntpServer { get; }
        public int Port { get; }
        public string SenderAddress { get; }
        public string SenderPassword { get; }

        public void Notify(string email, string subject, string body)
        {
            Console.WriteLine($"You have a new email from {SenderAddress} with {subject} ");
            Console.WriteLine(body);
            Console.WriteLine($"Message sent successfully to {SntpServer}");
            Console.WriteLine("******************");
        }
    }
}
