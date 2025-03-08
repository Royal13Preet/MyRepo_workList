using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace Thursday_ProductManagement.Filters
{
    public class ValidateActionFilter : ActionFilterAttribute
    {
        private readonly ILogger<ValidateActionFilter> _logger;

        public ValidateActionFilter(ILogger<ValidateActionFilter> logger)
        {
            _logger = logger;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                context.Result = new BadRequestObjectResult(context.ModelState);
            }
            _logger.LogInformation("Action: {context.ActionDescriptor.DisplayName} is Executing", context.ActionDescriptor.DisplayName);
            base.OnActionExecuting(context);
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            _logger.LogInformation("Response {context.ActionDescriptor.DisplayName} is excuted",context.ActionDescriptor.DisplayName);
            base.OnActionExecuted(context);
        }
    }
}

