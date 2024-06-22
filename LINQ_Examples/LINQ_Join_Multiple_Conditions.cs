using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace LinqExamples
{
    internal class Program
    {
        public class Customer
        {
            public string CustomerID { get; set; }
            public string CustomerName { get; set; }
        }
        public class Order
        {
            public string OrderID { get; set; }
            public string CustomerID { get; set; }
            public int Amount { get; set; }
        }
        static void Main(string[] args)
        {
            var customers = new List<Customer>
            {
                new Customer{ CustomerID ="C1", CustomerName= "Jack"},
                new Customer{ CustomerID ="C2", CustomerName= "John"},
            };

            var orders = new List<Order>
            {
                new Order{ OrderID="O1", CustomerID ="C1", Amount = 100},
                new Order{ OrderID="O2", CustomerID ="C1", Amount = 200},
                new Order{ OrderID="O3", CustomerID ="C2", Amount = 500},
                new Order{ OrderID="O4", CustomerID ="C2", Amount = 1500},
                new Order{ OrderID="O5", CustomerID ="C2", Amount = 800}
            };

            // Simple join
            var customerOrders = from c in customers
                                 join o in orders on c.CustomerID equals o.CustomerID
                                 select o;

            Console.WriteLine("Simple join");
            foreach (var item in customerOrders)
            {
                Console.WriteLine("OrderID:" + item.OrderID + " CustomerID:" + item.CustomerID + " " + " Amount:" + item.Amount);
            }

            // Bit complex join with multiple conditions

            var customerOrders2 = from c in customers
                                  join o in orders on c.CustomerID equals o.CustomerID
                                  where o.Amount > 200 && o.Amount < 1000
                                  select new
                                  {
                                      c.CustomerName,
                                      c.CustomerID,
                                      o.OrderID,
                                      o.Amount
                                  };

            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);

            Console.WriteLine("Bit complex join with multiple conditions");
            foreach (var item in customerOrders2)
            {
                Console.WriteLine("OrderID:" + item.OrderID + " CustomerID:" + item.CustomerID + " CustomerName:"+item.CustomerName + " Amount:" + item.Amount);
            }


            Console.ReadLine();
        }
    }
}
