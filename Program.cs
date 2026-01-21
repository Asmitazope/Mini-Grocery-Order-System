using Microsoft.EntityFrameworkCore;
using MiniGroceryOrderSystem.API.Data;
using MiniGroceryOrderSystem.API.Repositories;
using MiniGroceryOrderSystem.API.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<ApplicationDBContext>(op =>
op.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<ProductRepository>();
builder.Services.AddScoped<OrderRepository>();

builder.Services.AddScoped<OrderService>();

var app = builder.Build();
app.MapControllers();

app.Run();
