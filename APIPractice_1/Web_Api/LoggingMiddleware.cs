namespace Web_Api
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<LoggingMiddleware> _logger;

        public LoggingMiddleware(RequestDelegate next, ILogger<LoggingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var request = context.Request;

            // Capture the incoming request body
            var requestBody = await ReadRequestBody(request);
            _logger.LogInformation($"Request Method: {request.Method}, Path: {request.Path}, Body: {requestBody}");

            var originalResponseBodyStream = context.Response.Body;

            using (var responseBodyStream = new MemoryStream())
            {
                context.Response.Body = responseBodyStream;

                // Call the next middleware in the pipeline
                await _next(context);

                // Rewind the response body stream to the beginning
                responseBodyStream.Seek(0, SeekOrigin.Begin);

                // Capture the response body
                var responseBody = await new StreamReader(responseBodyStream).ReadToEndAsync();
                _logger.LogInformation($"Response Status: {context.Response.StatusCode}, Body: {responseBody}");

                // Ensure that the response body is written back to the original response stream
                responseBodyStream.Seek(0, SeekOrigin.Begin);
                await responseBodyStream.CopyToAsync(originalResponseBodyStream);
            }
        }

        private async Task<string> ReadRequestBody(HttpRequest request)
        {
            // Make sure the request body can be read
            request.EnableBuffering();

            using (var reader = new StreamReader(request.Body, leaveOpen: true))
            {
                var body = await reader.ReadToEndAsync();
                request.Body.Seek(0, SeekOrigin.Begin); // Rewind the body stream
                return body;
            }
        }


    }

}
