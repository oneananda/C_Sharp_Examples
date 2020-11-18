using System;
using System.Collections.Generic;
using System.Linq;

namespace C_Sharp_CSV_From_List
{
    class Orders
    {
        public int OrderID { get; set; }
        public string OrderStatus { get; set; }

        public Orders(int pOrderID, string pOrderStatus)
        {
            OrderID = pOrderID;
            OrderStatus = pOrderStatus;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // Suppose you are having a List<String> and you are in need to generate a Comma Seperated Value from this with single quotes attached
            // Say We need to dynamically generate a simple SQL Select statement from a Order table and the filter criteria would be like this
            // Select New ('NO') Orders, Active ('AO') Orders and Successful ('SO') Orders
            // Let's we have a Status Codes in a List<String>

            List<String> StatusCodes = new List<string>() { "NO", "AO", "SO" };

            // The desired output
            // SELECT * FROM ORDERS WHERE STATUS IN ('NO', 'AO', 'SO')

            // Traditional Solution
            //TraditionalSolution(StatusCodes);
            // Output
            // SELECT * FROM ORDERS WHERE STATUS IN ('NO','AO','SO')

            //NewSolution(StatusCodes);


            // Here we are creating a list of orders and each order will contain the status codes what we have seen before,
            // Lets see how to handle this List of Orders collection in the New Logic



            List<Orders> LstOrders = new List<Orders>();
            LstOrders.Add(new Orders(1, "NO"));
            LstOrders.Add(new Orders(2, "AO"));
            LstOrders.Add(new Orders(3, "SO"));
            

            NewSolutionWithClassesInvolved(LstOrders);


            Console.ReadLine();
        }

        private static void NewSolutionWithClassesInvolved(List<Orders> LstOrders)
        {
            string OutputSQL = "SELECT * FROM ORDERS WHERE STATUS IN (";

            OutputSQL += string.Join(", ", LstOrders.Select(X => string.Format("'{0}'", X.OrderStatus)));

            OutputSQL += ")";

            Console.WriteLine(string.Empty);

            Console.WriteLine(OutputSQL);
        }

        private static void NewSolution(List<string> StatusCodes)
        {
            string OutputSQL = "SELECT * FROM ORDERS WHERE STATUS IN (";

            OutputSQL += string.Join(", ", StatusCodes.Select(X => string.Format("'{0}'", X)));

            OutputSQL += ")";

            Console.WriteLine(string.Empty);

            Console.WriteLine(OutputSQL);
        }

        private static void TraditionalSolution(List<string> StatusCodes)
        {
            // Traditionally what we will do is
            // Loop through the List and generate a SQL Statement 

            string OutputSQL = "SELECT * FROM ORDERS WHERE STATUS IN (";

            int Count = StatusCodes.Count();
            foreach (string SingleStatusCode in StatusCodes)
            {
                OutputSQL += "'" + SingleStatusCode + "'";
                Count--;

                // This is critial to avoid the last character comma
                if (Count >= 1)
                {
                    OutputSQL += ", ";
                }

            }
            OutputSQL += ")";

            Console.WriteLine(string.Empty);

            Console.WriteLine(OutputSQL);
        }
    }
}
