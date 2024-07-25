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
            throw new NotImplementedException();
        }

        void Before_ISP_IPlugin.LoadData()
        {
            // This plugin does not need to load data
            throw new NotImplementedException();
        }

        void Before_ISP_IPlugin.Log(string message)
        {
            // This plugin does not need to log
            throw new NotImplementedException();
        }

        void Before_ISP_IPlugin.Render()
        {
            throw new NotImplementedException();
        }

        void Before_ISP_IPlugin.SaveData()
        {
            // This plugin does not need to save data
            throw new NotImplementedException();
        }
    }
}
