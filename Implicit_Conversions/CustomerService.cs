using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implicit_Conversions
{
    internal class CustomerService
    {
        public void ContactCustomer(Customer customer)
        {
            Console.WriteLine($"Contacting {customer.Name}...");
        }

        public void ContactCustomer(Local_Customer localCustomer)
        {
            Console.WriteLine($"Contacting local customer {localCustomer.Name}...");
            localCustomer.ContactInPerson();
        }

        public void ContactCustomer(National_Customer nationalCustomer)
        {
            Console.WriteLine($"Contacting national customer {nationalCustomer.Name}...");
            nationalCustomer.ContactViaPhone();
        }

        public void ContactCustomer(International_Customer internationalCustomer)
        {
            Console.WriteLine($"Contacting international customer {internationalCustomer.Name}...");
            internationalCustomer.ContactViaVideoCall();
        }
    }
}
