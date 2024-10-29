using Microsoft.AspNetCore.Mvc.ViewFeatures;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<ITempDataProvider, CookieTempDataProvider>();
builder.Services.AddSession();

var app = builder.Build();

app.UseSession();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "register",
    pattern: "Register",
    defaults: new { controller = "Register", action = "GetRegisterPage" });

app.MapControllerRoute(
    name: "recover",
    pattern: "Recover",
    defaults: new { controller = "Recover", action = "Recover" });

app.Run("http://localhost:5000");
