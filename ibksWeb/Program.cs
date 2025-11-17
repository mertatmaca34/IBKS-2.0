using Business.DependencyResolvers;
using Microsoft.AspNetCore.Authentication.Cookies;
using OfficeOpenXml;

ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddBusinessDependencies();
builder.Services.AddMemoryCache();
builder.Services.AddHttpContextAccessor();

// **Authentication ve Authorization Servisleri**
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Account/Login"; // Giri yaplmadysa buraya ynlendir
        options.AccessDeniedPath = "/Account/AccessDenied"; // Yetkisiz eriim
        options.ExpireTimeSpan = TimeSpan.FromMinutes(30); // Oturum sresi (istee bal)
    });

builder.Services.AddAuthorization();

builder.Services.AddControllersWithViews();
builder.Services.AddSession();

// Add services to the container.
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseSession();

app.UseRouting();

// **Authentication ve Authorization Middleware Ekleniyor**
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Login}/{id?}");

app.Run();
