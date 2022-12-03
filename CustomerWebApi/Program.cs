using CustomerWebApi;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


/* Database Context Dependency Injection */
var dbHost = "localhost";
var dbName = "dms_customer";
var dbPassword = "12345";
var connectionString = $"Data Source={dbHost}; Initial Catalog= {dbName}; User ID=sa; Password{dbPassword}";
builder.Services.AddDbContext<CustomerDbContext>(opt => opt.UseSqlServer(connectionString));
/* ======================================= */




var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();




/* https://www.youtube.com/watch?v=2p01iafOxUw&t=28s */