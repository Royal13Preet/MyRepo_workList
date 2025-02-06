using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace Secureuser.Models
{
        public class ErrorHandlerFilterAttribute : ExceptionFilterAttribute
        {
            private readonly ILogger<ErrorHandlerFilterAttribute> _logger;

            public ErrorHandlerFilterAttribute(ILogger<ErrorHandlerFilterAttribute> logger)
            {
                _logger = logger;
            }
            public override void OnException(ExceptionContext context)
            {
                
                _logger.LogError(context.Exception, "An unexpected error occurred.");
                 context.Result = new ObjectResult(new
                    {
                    message = "An unexpected error occurred. Please try again later.",
                    detail = context.Exception.Message 
                    })
                    {
                        StatusCode = 500 
                    };
                context.ExceptionHandled = true;
            }
        }
    }

