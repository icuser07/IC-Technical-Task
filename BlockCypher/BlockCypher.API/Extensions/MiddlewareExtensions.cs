using BlockCypher.API.Middlewares;

namespace BlockCypher.API.Extensions
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseLogging(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LoggingMiddleware>();
        }
    }
}