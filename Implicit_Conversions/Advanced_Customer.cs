using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implicit_Conversions
{
    internal class Advanced_Customer
    {
        public string Name { get; set; }

        // This will not compile as we are mixing the 'implicit operator' with inheritence 
        public static implicit operator Advanced_Local_Customer(Advanced_Customer customer)
        {
            return new Advanced_Local_Customer { Name = customer.Name };
        }     
    }

    class Advanced_Local_Customer : Advanced_Customer
    {
        public void ContactInPerson()
        {
            Console.WriteLine("ContactInPerson!");
        }
    }
  
}
