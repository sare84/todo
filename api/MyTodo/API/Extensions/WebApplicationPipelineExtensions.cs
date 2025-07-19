using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

using MyTodo.API.Endpoints.Health;

namespace MyTodo.API.Extensions
{
    public static class WebApplicationPipelineExtensions
    {
        public static WebApplication  ConfigureRequestPipeline(this WebApplication app)
        {
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseRouting();
            app.MapHealthEndpoints();
            app.MapControllers();         

            return app;   
        }
    }
}