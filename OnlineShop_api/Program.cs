using Microsoft.EntityFrameworkCore;
using OnlineShop_api;
using OnlineShop_api.Data;
using OnlineShop_api.logs.Logging;
using OnlineShop_api.Repository;
using OnlineShop_api.Repository.IRepository;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<ApplicationDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultSQLConnection"));
});
builder.Services.AddScoped<IItemRepository,ItemRepository>();
builder.Services.AddAutoMapper(typeof(MappingConfig));

//This is way to use serilog isntead of default features. Serilog has some good features. 
//Log.Logger = new LoggerConfiguration().MinimumLevel.Information()
//   .WriteTo.File("logs/villaLogs.txt",rollingInterval: RollingInterval.Day).CreateLogger();

//builder.Host.UseSerilog();

builder.Services.AddControllers().AddNewtonsoftJson();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<ILogging, Logging>();
var app = builder.Build();
app.UseStaticFiles();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
