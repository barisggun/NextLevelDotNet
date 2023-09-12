using _10_CustomModelBinder.CustomBinders;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


// Sýnýfýn üzerine veya actionda parametre baþýna attribute ile tanýmlanmadýðýnda ilgili provider yazýlýp buradan projeye eklenebilir.

//builder.Services.AddControllers(config => config.ModelBinderProviders.Insert(0,new ProductCustomBinderProvider()));

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
