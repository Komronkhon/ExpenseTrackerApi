using AutoMapper;
using ExpenseTracker.Mappers;
using ExpenseTracker.Repositories;
using ExpenseTracker.Repositories.Intetfaces;
using ExpenseTracker.Services;
using ExpenseTracker.Services.Intefaces;
using FluentValidation;
using FluentValidation.AspNetCore;
using Scalar.AspNetCore;
using Serilog;


var builder = WebApplication.CreateBuilder(args);

Log.Logger = new LoggerConfiguration()
    .ReadFrom.Configuration(builder.Configuration)
    .Enrich.FromLogContext()
    .WriteTo.Console()
    .WriteTo.File("logs/log-.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();    

//builder.Services.AddAutoMapper(cfg => cfg.AddProfile<MappingProfiles>());

builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddValidatorsFromAssemblyContaining<Program>();

builder.Services.AddTransient<MappingProfiles>();

builder.Services.AddSingleton<IExpenseRepository, ExpenseRepository>();
builder.Services.AddSingleton<ICategoryRepository, CategoryRepository>();

builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IExpenseService, ExpenseService>();

// Add services to the container.s
builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapScalarApiReference();

app.UseMiddleware<ExceptionMiddleware>();

app.MapControllers();

app.Run();
