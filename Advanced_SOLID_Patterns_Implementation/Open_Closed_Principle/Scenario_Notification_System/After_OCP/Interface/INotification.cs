using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.Scenario_Notification_System.After_OCP.Interface
{
    public interface INotification
    {
        void Send(string message);
    }
}
