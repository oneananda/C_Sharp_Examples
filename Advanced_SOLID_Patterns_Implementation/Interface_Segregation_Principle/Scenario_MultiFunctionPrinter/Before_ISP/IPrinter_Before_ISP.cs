using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle.Scenario_MultiFunctionPrinter.Before_ISP
{
    public interface IPrinter_Before_ISP
    {
        void Print(Document document);
        void Fax(Document document);
        void Scan(Document document);
        void Staple(Document document);
    }
}
