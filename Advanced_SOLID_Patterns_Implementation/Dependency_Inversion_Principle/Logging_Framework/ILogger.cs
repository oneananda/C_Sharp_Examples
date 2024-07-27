using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.Logging_Framework
{
    public interface ILogger
    {
        void Log(string message);
    }

}
