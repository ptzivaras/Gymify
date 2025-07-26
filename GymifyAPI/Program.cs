using GymifyAPI.Data;
using GymifyAPI.Middleware;
using GymifyAPI.Repositories;
using GymifyAPI.Repositories.Interfaces;
using GymifyAPI.Services;
using GymifyAPI.Services.Interfaces;
using GymifyAPI.Validators;
using Microsoft.EntityFrameworkCore;
using FluentValidation.AspNetCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// 1) Controllers + FluentValidation
builder.Services
    .AddControllers()
    .AddFluentValidation(fv =>
    {
        fv.RegisterValidatorsFromAssemblyContaining<CreateCustomerDtoValidator>();
        fv.DisableDataAnnotationsValidation = true;
    });

// 2) DbContext
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// 3) Repositories & Services
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<ICustomerService, CustomerService>();

// 4) Swagger / OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// 5) Middleware pipeline
app.UseHttpsRedirection();
app.UseGlobalExceptionHandling();

app.UseAuthorization();

// 6) Swagger UI (μόνο σε Development)
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.Run();
