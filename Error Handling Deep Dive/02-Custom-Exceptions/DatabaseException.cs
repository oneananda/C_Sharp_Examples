using System;

namespace ErrorHandlingDeepDive._02_Custom_Exceptions
{
    /// <summary>
    /// Represents errors that occur during database operations.
    /// Wraps lower-level exceptions like SqlException while adding 
    /// context about the operation being performed.
    /// </summary>
    public class DatabaseException : Exception
    {
        /// <summary>
        /// Gets the name of the database or connection string identifier.
        /// </summary>
        public string DatabaseName { get; }

        /// <summary>
        /// Gets the SQL query that caused the exception, if available.
        /// </summary>
        public string Query { get; }

        public DatabaseException() { }

        public DatabaseException(string message) : base(message) { }

        public DatabaseException(string message, Exception innerException)
            : base(message, innerException) { }

        public DatabaseException(string message, string databaseName, string query, Exception innerException)
            : base(message, innerException)
        {
            DatabaseName = databaseName;
            Query = query;
        }

        public override string ToString()
        {
            return $"{base.ToString()}{Environment.NewLine}" +
                   $"Database: {DatabaseName ?? "N/A"}{Environment.NewLine}" +
                   $"Query: {Query ?? "N/A"}";
        }
    }
}
