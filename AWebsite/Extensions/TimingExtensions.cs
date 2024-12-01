using AWebsite.Middlewares;

namespace AWebsite.Extensions;

public static class TimingExtensions
{
    public static IApplicationBuilder UseTiming(this IApplicationBuilder app)
    {
        return app.UseMiddleware<TimingMiddleware>();
    }
}
