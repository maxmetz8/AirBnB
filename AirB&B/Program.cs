//Naam: Max Metz
//studentnummer: s1115934

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AirB_B.Data;
using AirB_B.Services;
using AirB_B.Repositories;
using System.Text.Json.Serialization;
using System.Reflection;
using AirB_B.SwaggerOptions;
using Microsoft.AspNetCore.Mvc.ApiExplorer;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AirB_BContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AirB_BContext") ?? throw new InvalidOperationException("Connection string 'AirB_BContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<ISearchService, SearchService>();
builder.Services.AddScoped<IAirB_BRepository, AirB_BRepository>();
builder.Services.AddScoped<IReservationService, ReservationService>();
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});
builder.Services.AddApiVersioning(options =>
{
    options.AssumeDefaultVersionWhenUnspecified = true;

});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.ConfigureOptions<ConfigureSwaggerOptions>();
builder.Services.AddSwaggerGen(options =>
{
    // using System.Reflection;
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});
builder.Services.AddVersionedApiExplorer();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        var provider = app.Services.GetRequiredService<IApiVersionDescriptionProvider>();

        foreach (var description in provider.ApiVersionDescriptions)
        {
            options.SwaggerEndpoint(
                $"/swagger/{description.GroupName}/swagger.json",
                description.ApiVersion.ToString()
                );
        }
    });
    app.UseCors(options => options.AllowAnyHeader().AllowAnyOrigin());
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
