using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace Emp.Service.Logger
{


    public class LoggingFilter : IActionFilter
    {
        private readonly ILogger<LoggingFilter> _logger;

        public LoggingFilter(ILogger<LoggingFilter> logger)
        {
            _logger = logger;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var request = context.HttpContext.Request;
            _logger.LogInformation($"Request: {request.Method} {request.Path}");
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            var response = context.HttpContext.Response;
            _logger.LogInformation($"Response: {response.StatusCode}");
        }
    }
}


