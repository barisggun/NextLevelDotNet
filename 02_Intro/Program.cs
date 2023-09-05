var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews(); // web api'de burada withViews'i yazmadan kullanabiliriz.


var app = builder.Build(); // �n�a et 

// Configure the HTTP request pipeline.

// Pipeline'� bir zincirin halkalar� olarak d���nebiliriz. Request bu halkalara u�rayarak �al���r. S�ralar�yla ilgili durumlar vard�r.

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles(); // wwwroot'un i�erisindeki dosyalar� kullan�r. Kullanmazsak CSS JS dosyalar�na eri�emeyiz.

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
