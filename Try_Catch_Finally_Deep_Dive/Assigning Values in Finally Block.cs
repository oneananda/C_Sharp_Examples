using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch_Finally_Deep_Dive
{
    internal class Assigning_Values_in_Finally_Block
    {
        protected static string passingValue = "Initial Value";
        public static void Example1()
        {
            string returnValue = GetValueFromMethod();
            Console.WriteLine("Returned Value: " + returnValue.ToString());
            Console.WriteLine("Passing Value: " + passingValue);
        }
        private static string GetValueFromMethod()
        {
            try
            {
                int dividedByValue = 0;
                if (100 / dividedByValue == 0)
                {
                }
                return passingValue;
            }
            catch (Exception ex)
            {
                // throw ex;
                return "Catch Value";
            }
            finally
            {
                // The memory will be cleared here, but assigning the values here again
                passingValue = "Finally Value";
            }
        }
    }
}
