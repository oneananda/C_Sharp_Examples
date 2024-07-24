using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle.Scenario_MultiFunctionPrinter.After_ISP
{
    internal interface IPrinter
    {
        void Print(Document document);
    }
}
