using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Factory_Method_Basic.Before_Factory_Pattern
{
    public class NotificationService
    {
        public void SendNotification(string type, string message)
        {
            INotification notification;

            // Direct instantiation based on type
            if (type == "Email")
            {
                notification = new EmailNotification();
            }
            else if (type == "SMS")
            {
                notification = new SMSNotification();
            }
            else
            {
                throw new Exception("Unsupported notification type");
            }

            notification.Notify(message);
        }
    }
}
