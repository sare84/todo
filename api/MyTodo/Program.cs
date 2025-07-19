using MyTodo.API.Extensions;

DotNetEnv.Env.Load();

var builder = WebApplication.CreateBuilder(args);

builder.Configuration
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddEnvironmentVariables();


builder.Services
    .AddEndpointsApiExplorer()
    .AddSwaggerGen()
    .AddLiteDb(builder.Configuration)
    .AddTodoService(builder.Configuration)
    .AddControllers();

var app = builder.Build();
app.ConfigureRequestPipeline();

app.Run();
