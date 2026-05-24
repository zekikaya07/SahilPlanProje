using FluentValidation;
using SahilPlanProje.WebApi.Context;
using SahilPlanProje.WebApi.Entities;
using SahilPlanProje.WebApi.ValidationRules;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApiContext>();
builder.Services.AddScoped<IValidator<Product>, ProductValidator>();

builder.Services.AddAutoMapper(cfg => { }, Assembly.GetExecutingAssembly());

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(options =>
{
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";

    options.IncludeXmlComments(
        Path.Combine(AppContext.BaseDirectory, xmlFilename)
    );

    options.EnableAnnotations();
});

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowWebUI", policy =>
    {
        policy
            .WithOrigins(
                "https://sahilplanproje.com",
                "https://www.sahilplanproje.com",
                "https://admin.sahilplanproje.com",
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

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseRouting();

app.UseCors("AllowWebUI");

app.UseAuthorization();

app.MapControllers();

app.Run();