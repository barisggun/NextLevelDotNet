using FluentValidation.AspNetCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//Fluent validation eklendi.
//builder.Services.AddFluentValidation(config => config.RegisterValidatorsFromAssembly(Assembly.Load("_02_FluentValidation")));


//builder.Services.AddFluentValidation(config => config.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly()));

builder.Services.AddFluentValidation(config => config.RegisterValidatorsFromAssemblyContaining<Program>());


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
