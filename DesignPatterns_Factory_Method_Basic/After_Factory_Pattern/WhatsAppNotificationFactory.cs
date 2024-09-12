using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Factory_Method_Basic.After_Factory_Pattern
{
    public class WhatsAppNotificationFactory : NotificationFactory
    {
        public override INewNotification CreateNewNotification()
        {
           return new NewWhatsAppNotification();
        }
    }
}
