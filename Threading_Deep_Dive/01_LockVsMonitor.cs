using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading_Deep_Dive
{
    public static class LockVsMonitor
    {
        private static readonly object _obj = new();
        private static int _counter;

        public static void Run()
        {
            // Classic lock (Monitor.Enter/Exit under the hood)
            lock (_obj)
            {
                _counter++;
            }

            // Equivalent Monitor usage (more verbose, but explicit)
            bool taken = false;
            try
            {
                Monitor.Enter(_obj, ref taken);
                _counter++;
            }
            finally
            {
                if (taken) Monitor.Exit(_obj);
            }

            Console.WriteLine($"Counter={_counter}");
        }
    }
}
