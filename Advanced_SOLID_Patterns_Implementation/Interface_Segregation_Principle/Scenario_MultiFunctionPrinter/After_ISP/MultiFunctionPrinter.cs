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
            //throw new NotImplementedException();
        }

        void IPrinter.Print(Document document)
        {
            //throw new NotImplementedException();
        }

        void IStapler.Staple(Document document)
        {
            //throw new NotImplementedException();
        }

        void IScanner.Scan(Document document)
        {
            //throw new NotImplementedException();
        }
    }
}
