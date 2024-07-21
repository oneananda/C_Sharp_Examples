using Open_Closed_Principle.Scenario_Notification_System.After_OCP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.Scenario_Notification_System.After_OCP
{
    public class EmailNotification : INotification
    {
        public void Send(string message)
        {
            // Send email notification
            Console.WriteLine($"Sending email: {message}");
        }
    }

    public class SmsNotification : INotification
    {
        public void Send(string message)
        {
            // Send SMS notification
            Console.WriteLine($"Sending SMS: {message}");
        }
    }

    public class PushNotification : INotification
    {
        public void Send(string message)
        {
            // Send push notification
            Console.WriteLine($"Sending push notification: {message}");
        }
    }

}
