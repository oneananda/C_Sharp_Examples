using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle.Scenario_Plugin_System.Before_ISP
{
    internal class Before_ISP_DataPlugin
    {
        public void Initialize()
        {
            // Initialization logic
        }

        public void LoadData()
        {
            // Load data logic
        }

        public void SaveData()
        {
            // Save data logic
        }

        public void Render()
        {
            // This plugin does not need to render
            throw new NotImplementedException();
        }

        public void Log(string message)
        {
            // This plugin does not need to log
            throw new NotImplementedException();
        }
    }
}
