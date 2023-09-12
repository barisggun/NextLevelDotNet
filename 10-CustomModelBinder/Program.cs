using _10_CustomModelBinder.CustomBinders;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


// S�n�f�n �zerine veya actionda parametre ba��na attribute ile tan�mlanmad���nda ilgili provider yaz�l�p buradan projeye eklenebilir.

//builder.Services.AddControllers(config => config.ModelBinderProviders.Insert(0,new ProductCustomBinderProvider()));

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
