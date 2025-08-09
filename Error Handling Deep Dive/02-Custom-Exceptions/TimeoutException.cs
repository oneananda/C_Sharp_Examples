using System;

namespace ErrorHandlingDeepDive._02_Custom_Exceptions
{
    /// <summary>
    /// Represents an error that occurs when an operation exceeds a specified time limit.
    /// </summary>
    public class TimeoutException : Exception
    {
        /// <summary>
        /// Name or description of the operation that timed out.
        /// </summary>
        public string OperationName { get; }

        /// <summary>
        /// The maximum allowed duration before the timeout occurred.
        /// </summary>
        public TimeSpan AllowedTime { get; }

        public TimeoutException() { }

        public TimeoutException(string message) : base(message) { }

        public TimeoutException(string message, Exception innerException)
            : base(message, innerException) { }

        public TimeoutException(string operationName, TimeSpan allowedTime)
            : base($"The operation '{operationName}' exceeded the allowed time limit of {allowedTime.TotalSeconds} seconds.")
        {
            OperationName = operationName;
            AllowedTime = allowedTime;
        }

        public TimeoutException(string operationName, TimeSpan allowedTime, Exception innerException)
            : base($"The operation '{operationName}' exceeded the allowed time limit of {allowedTime.TotalSeconds} seconds.", innerException)
        {
            OperationName = operationName;
            AllowedTime = allowedTime;
        }

        public override string ToString()
        {
            return $"{base.ToString()}{Environment.NewLine}" +
                   $"Operation: {OperationName ?? "N/A"}{Environment.NewLine}" +
                   $"Allowed Time: {(AllowedTime != TimeSpan.Zero ? AllowedTime.ToString() : "N/A")}";
        }
    }
}
