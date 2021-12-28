var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
var port = Environment.GetEnvironmentVariable("PORT") ?? "3100";
app.Run("http://0.0.0.0:" + port);
