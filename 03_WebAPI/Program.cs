var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//AddControllerWithViews diyip mvc ve web api projesi yapmýþ oluruz. AddMvc'de diyebiliriz. Farklý türleri var.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

//app.UseRouting();
//app.UseEndpoints(a => a.MapDefaultControllerRoute());

app.MapControllers(); // yukarýdakinin kýsa hali budur. 
// Bunun anlamý controller üstündeki attributeleri kullan demektir.

app.Run();
