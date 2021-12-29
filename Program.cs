using Microsoft.AspNetCore.HttpOverrides;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();
app.UseForwardedHeaders(new ForwardedHeadersOptions() {
    ForwardedHeaders = ForwardedHeaders.XForwardedProto
});
app.UseHttpsRedirection();
app.MapGet("/", () => "Hello World!");
var port = Environment.GetEnvironmentVariable("PORT") ?? "3100";
app.Run("http://*:" + port);
