namespace AWebsite.Middlewares;
public class TimingMiddleware
{
    private readonly ILogger<TimingMiddleware> _logger;
    private readonly RequestDelegate _next;

    public TimingMiddleware(ILogger<TimingMiddleware> logger,RequestDelegate next)
    {
        this._logger = logger;
        this._next = next;
    }

    public async Task Invoke(HttpContext ctx)
    {
        var start = DateTime.UtcNow;
        await _next.Invoke(ctx);
        _logger.LogInformation($"Timing request :{ctx.Request.Path} {(DateTime.UtcNow - start).TotalMicroseconds} ms");
    }
}
