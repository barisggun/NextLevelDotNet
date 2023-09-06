var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//AddControllerWithViews diyip mvc ve web api projesi yapm�� oluruz. AddMvc'de diyebiliriz. Farkl� t�rleri var.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

//app.UseRouting();
//app.UseEndpoints(a => a.MapDefaultControllerRoute());

app.MapControllers(); // yukar�dakinin k�sa hali budur. 
// Bunun anlam� controller �st�ndeki attributeleri kullan demektir.

app.Run();
