var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", (HttpRequest request) => request.Headers["CF-CONNECTING-IP"].ToString())
    .WithName("Get");

app.MapGet("/v6", (HttpRequest request) => request.Headers["CF-CONNECTING-IPv6"].ToString())
    .WithName("GetV6");

app.Run();
