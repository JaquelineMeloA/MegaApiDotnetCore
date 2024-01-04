using Microsoft.AspNetCore.Builder;

namespace MegamanApi.api.UI.middlewares
{
    public static class MiddlewareLogExtensions
    {
        public static IApplicationBuilder UseMiddlewareLog(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MiddlewareLog>();
        }
    }
}