using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Select_SelectMany_Ex2
{



    class Order
    {
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderStatus { get; set; }

        public Order(int pOrderNumber, DateTime pOrderDate, string pOrderStatus)
        {
            OrderNumber = pOrderNumber;
            OrderDate = pOrderDate;
            OrderStatus = pOrderStatus;
        }
    }




    class Customer
    {
        public string CusotmerName { get; set; }
        public string CusotmerCode { get; set; }
        public string CusotmerStatus { get; set; }
        public List<Order> OrderList { get; set; }

        public Customer(string pCusotmerName, string pCusotmerCode, string pCusotmerStatus, List<Order> pOrderList)
        {
            CusotmerName = pCusotmerName;
            CusotmerCode = pCusotmerCode;
            CusotmerStatus = pCusotmerStatus;
            OrderList = pOrderList;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            // The requirement
            // We are having a Customer class and Order class,

            // A Customer may generate any number of orders
            // In the following Line we do have a List of customers who are having the list of orders he / she has created inside the Customer Class

            //public List<Order> AllOrdersList = new List<Order>();

            // The question is if we want to see all the orders (only) for particular set of Customers

            // Select in LINQ will help you only to some extent

            // Let's see how it is

            // Let's generate sample data for 3 customers



            List<Customer> LstCustomer = new List<Customer>() 
            { 
                new Customer("Cust 1","CUS1","Active",new List<Order>()
                {
                    new Order(100, DateTime.Now, "New"),
                    new Order(101, DateTime.Now.AddDays(-2), "InProgress"),
                    new Order(102, DateTime.Now, "New"),
                    new Order(103, DateTime.Now.AddDays(-10), "Complete")
                }),


                new Customer("Cust 2","CUS2","Active",new List<Order>()
                {
                    new Order(120, DateTime.Now, "New"),
                    new Order(121, DateTime.Now.AddDays(-2), "InProgress"),
                    new Order(122, DateTime.Now, "New"),
                    new Order(123, DateTime.Now.AddDays(-10), "Complete")
                }),


                new Customer("Cust 3","CUS3","InActive",new List<Order>()
                {
                    new Order(130, DateTime.Now, "OnHold"),
                    new Order(131, DateTime.Now.AddDays(-2), "InProgress"),
                    new Order(132, DateTime.Now, "OnHold"),
                    new Order(133, DateTime.Now.AddDays(-10), "Complete")
                })
            };
            

            var selectResult = LstCustomer.Select(X => X.OrderList);

            // As a output you will get a lit of lists i.e List<List<Order>>
            

            // To dig deeper in this 

            // We are implementing Select Many in this

            var selectManyResult = LstCustomer.SelectMany(X => X.OrderList);

            // The output is really awesome, as this is returning the list of Orders alone

            
            // Let's add more filters to this
            // Getting only the "New" orders

            var selectManyResul2 = LstCustomer
                .SelectMany(X => X.OrderList)
                .Where(X => X.OrderStatus == "New");

            
            // Adding more filters 

            // Getting the Active Customers and 
            // Getting only the "New" orders from those

            var selectManyResult3 = LstCustomer
                .Where(X => X.CusotmerStatus == "Active")
                .SelectMany(X => X.OrderList)
                .Where(X => X.OrderStatus == "New");

        }
    }
}
