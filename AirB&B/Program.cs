//Naam: Max Metz
//studentnummer: s1115934

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AirB_B.Data;
using AirB_B.Services;
using AirB_B.Repositories;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AirB_BContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AirB_BContext") ?? throw new InvalidOperationException("Connection string 'AirB_BContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<ISearchService, SearchService>();
builder.Services.AddScoped<IAirB_BRepository, AirB_BRepository>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors(options => options.AllowAnyHeader().AllowAnyOrigin());
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
