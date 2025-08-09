using ErrorHandlingDeepDive._02_Custom_Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Error_Handling_Deep_Dive._02_Custom_Exceptions
{
    public class DatabaseExceptionImpl
    {
        public static void ExecuteDatabaseOperation()
        {
            string databaseName = "CustomerDB";
            string query = "SELECT * FROM Customers WHERE Id = 999";

            try
            {
                // Simulate database failure
                throw new SqlExceptionSimulator("Unable to connect to SQL Server.");
            }
            catch (Exception ex)
            {
                throw new DatabaseException(
                    "Error occurred while executing database query.",
                    databaseName,
                    query,
                    ex
                );
            }
        }

        // Mocked SqlException for demo purposes
        public class SqlExceptionSimulator : Exception
        {
            public SqlExceptionSimulator(string message) : base(message) { }
        }
    }
}
