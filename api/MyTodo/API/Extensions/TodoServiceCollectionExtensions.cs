using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection; 

using MyTodo.API.Service;

namespace MyTodo.API.Extensions
{
    public static class TodoServiceCollectionExtensions
    {
        public static IServiceCollection AddTodoService(this IServiceCollection services, IConfiguration configuration)
        {
            // Register the TodoService with the DI container
            services.AddScoped<TodoService>();

            return services;
        }
    }
}