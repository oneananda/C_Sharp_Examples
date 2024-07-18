using GeneratedInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4_Template_Implementation
{
    public class Customer : ICustomer
    {
        public int Id { get ; set ; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
