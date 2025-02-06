using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secureuser.Models
{
    public class LoggingActionFilter : ActionFilterAttribute
    {
        private readonly ILogger<LoggingActionFilter> _logger;

        public LoggingActionFilter(ILogger<LoggingActionFilter> logger)
        {
            _logger = logger;

        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            _logger.LogInformation($"Action: {context.ActionDescriptor.DisplayName} is Executing");
            base.OnActionExecuting(context);
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            _logger.LogInformation($"Response {context.ActionDescriptor.DisplayName} is excuted");
            base.OnActionExecuted(context);
        }
    }

}

