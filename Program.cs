using Microsoft.EntityFrameworkCore; // Replace 'YourNamespace' with the namespace of your MyDatabaseContext class
using IntexDatabaseConnection.Models;
using Npgsql.EntityFrameworkCore.PostgreSQL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddDbContext<MyDatabaseContext>(options =>
//    options.UseNpgsql(builder.Configuration.GetConnectionString("MyDatabase"))
//    );

//builder.Services.AddDbContext<MyDatabaseContext>(options =>
//    options.UseNpgsql(builder.Configuration.GetConnectionString("MyDatabase")));

var authConnectString = builder.Configuration["ConnectionStrings:MyDatabase"];
builder.Services.AddDbContext<mummies_testContext>(options =>
    options.UseNpgsql(authConnectString));
// builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// cross origin research sharing
builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// put the link for local
app.UseCors(p => p.WithOrigins("http://localhost:3000"));

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
