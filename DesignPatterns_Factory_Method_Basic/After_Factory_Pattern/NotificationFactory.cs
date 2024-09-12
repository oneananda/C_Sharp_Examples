using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Factory_Method_Basic.After_Factory_Pattern
{
    public abstract class NotificationFactory
    {
        public abstract INewNotification CreateNewNotification();

        public void SendNotification(string message)
        {
            var notification = CreateNewNotification();

            notification.Notify(message);
        }
    }
}
