using LiteDB;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

using MyTodo.API.Service;

namespace MyTodo.API.Extensions
{
    public static class LiteDbServiceCollectionExtension
    {
        public static IServiceCollection AddLiteDb(this IServiceCollection services, IConfiguration configuration)
        {
            var databasePath = configuration.GetValue<string>("LiteDb:DatabasePath") ?? "TodoDatabase.db";

            services.AddSingleton<LiteDbOptions>(new LiteDbOptions
            {
                DatabaseFilePath = databasePath
            });

            services.AddSingleton<ILiteDatabase>(sp => new LiteDatabase(databasePath));

            services.AddSingleton<IDatabaseService, DatabaseService>();

            return services;
        }
    }
}