using Open_Closed_Principle.Scenario_Notification_System.After_OCP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.Scenario_Notification_System.After_OCP
{
    public class NotificationService
    {
        private readonly List<INotification> _notifications;

        public NotificationService()
        {

        }
        public NotificationService(List<INotification> notifications)
        {
            _notifications = notifications;
        }

        public void SendNotification(INotification notification, string message)
        {
            notification.Send(message);
        }
    }

}
