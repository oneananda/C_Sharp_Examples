using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch_Finally_Deep_Dive
{
    internal class Normal_Try_Catch_Finally
    {
        public static void Example1()
        {
            string returnValue = GetValueFromMethod();
            Console.WriteLine(returnValue.ToString());
        }
        private static string GetValueFromMethod()
        {
            string returnValue = "Initial Value";
            try
            {
                int dividedByValue = 0;
                return returnValue;
            }
            catch (Exception ex)
            {
                // throw ex;
                return "Catch Value";
            }
            finally
            {
                // The memory will be cleared here
                returnValue = "Finally Value";
            }
        }
    }
}
