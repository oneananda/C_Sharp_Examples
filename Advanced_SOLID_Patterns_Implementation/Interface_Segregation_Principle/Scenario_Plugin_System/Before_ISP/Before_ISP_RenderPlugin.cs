using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle.Scenario_Plugin_System.Before_ISP
{
    internal class Before_ISP_RenderPlugin : Before_ISP_IPlugin
    {
        void Before_ISP_IPlugin.Initialize()
        {
            Console.WriteLine("Before_ISP_IPlugin: Initialization is required.");
        }

        void Before_ISP_IPlugin.LoadData()
        {
            Console.WriteLine("Before_ISP_IPlugin: This plugin need to load data.");
        }

        void Before_ISP_IPlugin.Log(string message)
        {
            Console.WriteLine("Before_ISP_IPlugin: This plugin does not need to log.");
        }

        void Before_ISP_IPlugin.Render()
        {
            Console.WriteLine("Before_ISP_IPlugin: Rendering is required.");
        }

        void Before_ISP_IPlugin.SaveData()
        {
            Console.WriteLine("Before_ISP_IPlugin: This plugin does not need to save data.");
        }

    }
}
