namespace Thursday_ProductManagement.WebApi
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _requestDelegate;
        private readonly ILogger<LoggingMiddleware> _logger;

        public LoggingMiddleware(RequestDelegate requestDelegate, ILogger<LoggingMiddleware> logger)
        {
            _requestDelegate = requestDelegate;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // Log the incoming request
            _logger.LogInformation($"Incoming Request: {context.Request.Path}, {context.Request.Method}");


            await _requestDelegate(context);

            // Log the outgoing response
            _logger.LogInformation($"Outgoing Response: {context.Response.StatusCode}");
        }
    }
}
