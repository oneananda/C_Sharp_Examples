using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle.Scenario_Plugin_System.Before_ISP
{
    internal class Before_ISP_DataPlugin : Before_ISP_IPlugin
    {
        public void Initialize()
        {
            Console.WriteLine("Initializing the plugin...");
            // Initialization logic
            Console.WriteLine("Plugin initialization complete.");
        }

        public void LoadData()
        {
            Console.WriteLine("Loading data...");
            // Load data logic
            Console.WriteLine("Data loading complete.");
        }

        public void SaveData()
        {
            Console.WriteLine("Saving data...");
            // Save data logic
            Console.WriteLine("Data saving complete.");
        }

        public void Render()
        {
            Console.WriteLine("This plugin does not need to render.");
            throw new NotImplementedException();
        }

        public void Log(string message)
        {
            Console.WriteLine("This plugin does not need to log.");
            throw new NotImplementedException();
        }

    }
}
