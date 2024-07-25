using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle.Scenario_Plugin_System.Before_ISP
{
    internal interface Before_ISP_IPlugin
    {
        void Initialize();
        void LoadData();
        void SaveData();
        void Render();
        void Log(string message);
    }
}
