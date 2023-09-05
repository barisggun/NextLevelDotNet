var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews(); // web api'de burada withViews'i yazmadan kullanabiliriz.


var app = builder.Build(); // Ýnþa et 

// Configure the HTTP request pipeline.

// Pipeline'ý bir zincirin halkalarý olarak düþünebiliriz. Request bu halkalara uðrayarak çalýþýr. Sýralarýyla ilgili durumlar vardýr.

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles(); // wwwroot'un içerisindeki dosyalarý kullanýr. Kullanmazsak CSS JS dosyalarýna eriþemeyiz.

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
