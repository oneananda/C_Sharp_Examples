using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Error_Handling_Deep_Dive._02_Custom_Exceptions
{
    public class ValidationException : Exception
    {
        // The field to store validation error details
        public string Field { get; }

        // A custom message to provide more information about the error
        public string ValidationMessage { get; }

        // The constructor that accepts the field name and validation message
        public ValidationException(string field, string validationMessage)
            : base($"Validation failed for field '{field}': {validationMessage}")
        {
            Field = field;
            ValidationMessage = validationMessage;
        }

        // Optionally, you could add another constructor for more flexibility (e.g., just a message)
        public ValidationException(string message)
            : base(message)
        {
        }
    }
}
