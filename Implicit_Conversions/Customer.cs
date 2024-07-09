using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implicit_Conversions
{
    internal class Customer
    {
        public string Name { get; set; }
    }

    class Local_Customer : Customer
    {
        public void ContactInPerson()
        {
            Console.WriteLine("ContactInPerson!");
        }
    }
    class National_Customer : Customer
    {
        public void ContactViaPhone()
        {
            Console.WriteLine("ContactViaPhone!");
        }
    }

    class International_Customer : Customer
    {
        public void ContactViaVideoCall()
        {
            Console.WriteLine("ContactViaVideoCall!");
        }
    }
}
