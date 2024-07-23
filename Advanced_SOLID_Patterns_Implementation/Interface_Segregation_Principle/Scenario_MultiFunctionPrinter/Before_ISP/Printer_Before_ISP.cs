using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle.Scenario_MultiFunctionPrinter.Before_ISP
{
    public class Printer_Before_ISP : IPrinter_Before_ISP
    {
        public void Print(Document document)
        {
            // Implementation for printing
        }

        public void Fax(Document document)
        {
            // Implementation for faxing
        }

        public void Scan(Document document)
        {
            // Implementation for scanning
        }

        public void Staple(Document document)
        {
            // Implementation for stapling
        }
    }
}
