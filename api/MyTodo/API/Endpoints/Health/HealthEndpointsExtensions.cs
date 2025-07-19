
using MyTodo.API.Extensions;
using MyTodo.Domain.Health;

namespace MyTodo.API.Endpoints.Health;
public static class HealthEndpointsExtensions
{
    public static IEndpointRouteBuilder MapHealthEndpoints(this WebApplication app)
    {
        app.MapHealthGet("/health/status", GetStatus);
        app.MapHealthGet("/health/server-time", GetServerTime);

        return app;
    }

    private static IResult GetStatus() {
        return Results.Ok(new Info("1.0.0", true));
    }

    private static IResult GetServerTime() {
        return Results.Ok(new ServerTime(DateTime.UtcNow.ToString("o")));
    }
}