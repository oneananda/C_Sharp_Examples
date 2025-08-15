using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Error_Handling_Deep_Dive._04_Enterprise_Patterns
{
    public static class ExceptionMapper
    {
        public static (HttpStatusCode status, string title, IDictionary<string, object> extensions)
            Map(Exception ex)
        {
            var extensions = new Dictionary<string, object>();

            return ex switch
            {
                ValidationException vex => (
                    HttpStatusCode.BadRequest,
                    "Validation failed",
                    Add(extensions, "errors", vex.Errors)),

                ResourceNotFoundException rnfe => (
                    HttpStatusCode.NotFound,
                    "Resource not found",
                    Add(extensions, "resource", rnfe.ResourceName)
                       .Add("key", rnfe.ResourceKey ?? string.Empty)),

                UnauthorizedAccessException => (
                    HttpStatusCode.Unauthorized,
                    "Unauthorized",
                    extensions),

                OperationCanceledException => (
                    HttpStatusCode.RequestTimeout,
                    "Request was canceled",
                    extensions),

                _ => (
                    HttpStatusCode.InternalServerError,
                    "An unexpected error occurred",
                    extensions)
            };
        }

        private static IDictionary<string, object> Add(
            IDictionary<string, object> dict, string key, object value)
        {
            dict[key] = value;
            return dict;
        }
    }
}
