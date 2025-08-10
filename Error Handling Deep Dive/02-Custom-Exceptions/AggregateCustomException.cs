using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Error_Handling_Deep_Dive._02_Custom_Exceptions
{
        /// <summary>
        /// Represents a custom aggregate exception that groups multiple exceptions into one.
        /// Useful for batch operations where multiple failures can occur.
        /// </summary>
        public class AggregateCustomException : Exception
        {
            public IReadOnlyList<Exception> InnerExceptions { get; }

            public AggregateCustomException(IEnumerable<Exception> innerExceptions)
                : base(CreateMessage(innerExceptions))
            {
                InnerExceptions = innerExceptions.ToList().AsReadOnly();
            }

            private static string CreateMessage(IEnumerable<Exception> innerExceptions)
            {
                if (innerExceptions == null || !innerExceptions.Any())
                    return "No exceptions were provided.";

                return $"AggregateCustomException: {innerExceptions.Count()} errors occurred.";
            }

            public override string ToString()
            {
                var baseMessage = base.ToString();
                var details = string.Join(Environment.NewLine,
                    InnerExceptions.Select((ex, i) => $"[{i + 1}] {ex.GetType().Name}: {ex.Message}"));
                return $"{baseMessage}{Environment.NewLine}--- Inner Exceptions ---{Environment.NewLine}{details}";
            }
        }
}
