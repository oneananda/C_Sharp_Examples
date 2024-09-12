using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Factory_Method_Basic.Before_Factory_Pattern
{
    public class SMSNotification : INotification
    {
        public void Notify(string message)
        {
            Console.WriteLine($"Sending SMS: {message}");
        }
    }
}
