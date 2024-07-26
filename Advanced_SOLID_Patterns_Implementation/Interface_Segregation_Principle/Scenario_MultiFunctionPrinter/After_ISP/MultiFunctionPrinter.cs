using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle.Scenario_MultiFunctionPrinter.After_ISP
{
    internal class MultiFunctionPrinter : IPrinter, IFax, IScanner, IStapler
    {
        void IFax.Fax(Document document)
        {
            Console.WriteLine($"Faxing document: {document.Name}");
        }

        void IPrinter.Print(Document document)
        {
            Console.WriteLine($"Printing document: {document.Name}");
        }

        void IStapler.Staple(Document document)
        {
            Console.WriteLine($"Stapling document: {document.Name}");
        }

        void IScanner.Scan(Document document)
        {
            Console.WriteLine($"Scanning document: {document.Name}");
        }
    }
}
