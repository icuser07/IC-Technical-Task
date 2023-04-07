namespace BlockCypher.API.Middlewares
{
    public class LoggingMiddleware : IMiddleware
    {
        private readonly ILogger<LoggingMiddleware> _logger;

        public LoggingMiddleware(ILogger<LoggingMiddleware> logger)
        {
            if(logger == null)
                throw new ArgumentNullException(nameof(logger));

            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            _logger.LogInformation("Request Executing....");

            await next(context);

            _logger.LogInformation("Request Executed....");

        }
    }
}