using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_SOLID_Patterns_Implementation.SRP
{
    internal class Before_SRP_User
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public void Save()
        {
            // Code to save the user to a database
        }

        public void SendEmail()
        {
            // Code to send an email
        }
    }
}
