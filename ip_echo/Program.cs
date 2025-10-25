var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapGet("/", (HttpRequest request) => request.Headers["CF-CONNECTING-IP"].ToString())
    .WithName("Get");

app.MapGet("/v6", (HttpRequest request) => request.Headers["CF-CONNECTING-IPv6"].ToString())
    .WithName("GetV6");

app.Run();
