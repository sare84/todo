namespace MyTodo.API.Extensions;

public static class EndpointRouteBuilderExtensions
{
    public static RouteHandlerBuilder MapHealthGet(this WebApplication app, string pattern, Delegate handler, string? tags = null)
    {
        return app.MapGet(pattern, handler)
            .WithName(pattern.Replace("/", "_").TrimStart('_'))
            .WithOpenApi()
            .Produces(200)
            .ProducesProblem(500)
            .WithTags(tags);
    }
    
}

