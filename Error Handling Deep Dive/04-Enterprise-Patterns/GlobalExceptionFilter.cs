using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Error_Handling_Deep_Dive._04_Enterprise_Patterns
{
    public sealed class GlobalExceptionFilter(
        ILogger<GlobalExceptionFilter> logger,
        ICentralizedErrorLogger errorLogger) : IExceptionFilter
    {
        private readonly ILogger<GlobalExceptionFilter> _logger = logger;
        private readonly ICentralizedErrorLogger _errorLogger = errorLogger;

        public void OnException(ExceptionContext context)
        {
            // Correlation id (set upstream by middleware or generated here)
            var correlationId = context.HttpContext.TraceIdentifier;

            var (status, title, extensions) = ExceptionMapper.Map(context.Exception);

            // Always log centrally (fire-and-forget is fine; service can be non-blocking)
            _errorLogger.Log(context.Exception, correlationId, context.HttpContext);

            _logger.LogError(context.Exception, "Unhandled exception (filter). CorrelationId={CorrelationId}", correlationId);

            var pd = new ProblemDetails
            {
                Status = (int)status,
                Title = title,
                Detail = ShouldExposeDetails(context.Exception) ? context.Exception.Message : null,
                Instance = context.HttpContext.Request.Path
            };

            // Include correlation id + custom fields
            pd.Extensions["correlationId"] = correlationId;
            foreach (var kv in extensions)
                pd.Extensions[kv.Key] = kv.Value;

            context.Result = new ObjectResult(pd) { StatusCode = pd.Status };
            context.ExceptionHandled = true;
        }

        private static bool ShouldExposeDetails(Exception ex)
        {
#if DEBUG
            return true;
#else
        return false;
#endif
        }
    }
}
