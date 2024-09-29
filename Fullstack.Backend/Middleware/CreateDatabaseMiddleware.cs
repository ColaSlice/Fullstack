using Fullstack.Data;

namespace Fullstack.Backend.Middleware;

public class CreateDatabaseMiddleware
{
    private readonly RequestDelegate _next;
    
    public CreateDatabaseMiddleware(RequestDelegate next)
    {
        _next = next;
    }
    
    // IMessageWriter is injected into InvokeAsync
    public async Task InvokeAsync(HttpContext httpContext, ApplicationDbContext context)
    {
        _ = await context.Database.EnsureCreatedAsync();
        
        await _next(httpContext);
    }
}