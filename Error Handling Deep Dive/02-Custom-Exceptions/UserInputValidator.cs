using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Error_Handling_Deep_Dive._02_Custom_Exceptions
{
    public class UserInputValidator
    {
        public void ValidateEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                throw new ValidationException("Email", "Email cannot be empty.");
            }

            if (!email.Contains("@"))
            {
                throw new ValidationException("Email", "Email must contain '@' symbol.");
            }

            Console.WriteLine("Email is valid.");
        }
    }
}
