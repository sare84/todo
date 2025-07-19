using MyTodo.API.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddEndpointsApiExplorer()
    .AddSwaggerGen()
    .AddLiteDb(builder.Configuration)
    .AddTodoService(builder.Configuration)
    .AddControllers();

var app = builder.Build();
app.ConfigureRequestPipeline();

app.Run();
