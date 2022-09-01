using dotnet6.Interfaces;
using dotnet6.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers()
                .AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.PropertyNamingPolicy = null;
                    options.JsonSerializerOptions.MaxDepth = 64;
                    options.JsonSerializerOptions.IncludeFields = true;
                });

// Add services
builder.Services.AddSingleton<ICartService, CartService>();

builder.WebHost.UseUrls("http://localhost:5050");

var app = builder.Build();

app.UseAuthorization();

app.MapControllers();

app.Run();

