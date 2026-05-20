using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using SahilPlanProje.WebApi.Context;
using SahilPlanProje.WebApi.Entities;
using SahilPlanProje.WebApi.ValidationRules;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApiContext>();
builder.Services.AddScoped<IValidator<Product>,ProductValidator>();

// Ýlk parametre: yapýlandýrma aksiyonu (boþ olabilir)
// Ýkinci parametre: taranacak assembly'ler
builder.Services.AddAutoMapper(cfg => { }, Assembly.GetExecutingAssembly());

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";

    options.IncludeXmlComments(
        Path.Combine(AppContext.BaseDirectory, xmlFilename)
    );
});

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowWebUI", policy =>
    {
        policy
            .WithOrigins(
                "https://sahilplanproje.com",
                "https://www.sahilplanproje.com",
                "http://localhost:7095",
                "https://localhost:7095",
                "http://localhost:7072",
                "https://localhost:7072"
            )
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseRouting();

app.UseCors("AllowWebUI");

app.UseAuthorization();

app.MapControllers();

app.Run();
