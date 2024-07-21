using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.Scenario_Notification_System.Before_OCP
{
    public class Before_OCP_NotificationService
    {
        public void SendNotification(string message, string notificationType)
        {
            if (notificationType == "Email")
            {
                // Send email notification
                Console.WriteLine($"Sending email: {message}");
            }
        }
    }

}
