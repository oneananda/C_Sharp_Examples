using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implicit_Conversions
{
    internal class Medium_Implicit_Conversions
    {
        public static void Example1()
        {
            Local_Customer localCustomer = new Local_Customer { Name = "Mason Turner" };
            National_Customer nationalCustomer = new National_Customer { Name = "Emma Coleman" };
            International_Customer internationalCustomer = new International_Customer { Name = "Jackson Hayes" };

            CustomerService service = new CustomerService();

            service.ContactCustomer(localCustomer);
            service.ContactCustomer(nationalCustomer);
            service.ContactCustomer(internationalCustomer);

            /*
            Method Overloading: Allows different methods with the same name to handle various types.
            Implicit Conversion: The derived classes are implicitly converted to the base class Customer when needed.
            Polymorphism: The correct method is chosen based on the type of the argument passed, demonstrating polymorphism in action.
            */
        }
    }
}
