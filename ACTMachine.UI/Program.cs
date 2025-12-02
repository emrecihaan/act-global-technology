using Microsoft.AspNetCore.Mvc.Razor;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// Localization servislerini ekle
builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");

builder.Services.AddControllersWithViews()
    .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
    .AddDataAnnotationsLocalization();

var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

var supportedCultures = new[] { "tr", "en" };
var localizationOptions = new RequestLocalizationOptions()
    .SetDefaultCulture("tr")
    .AddSupportedCultures(supportedCultures)
    .AddSupportedUICultures(supportedCultures);

app.UseRequestLocalization(localizationOptions);

app.UseHttpsRedirection();
app.UseStaticFiles();
app.MapDefaultControllerRoute();
app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "about",
    defaults: new { controller = "Home", action = "About" });

app.MapControllerRoute(
    name: "default",
    pattern: "machinery",
    defaults: new { controller = "Home", action = "Machinery" });

app.MapControllerRoute(
    name: "default",
    pattern: "machinery/efs32Detail",
    defaults: new { controller = "Home", action = "EFMDetail" });

app.MapControllerRoute(
    name: "default",
    pattern: "machinery/automoticWorkCellDetail",
    defaults: new { controller = "Home", action = "AutomoticWorkCellDetail" });

app.MapControllerRoute(
    name: "default",
    pattern: "services",
    defaults: new { controller = "Home", action = "Services" });

app.MapControllerRoute(
    name: "default",
    pattern: "contact",
    defaults: new { controller = "Home", action = "Contact" });

app.MapControllerRoute(
    name: "default",
    pattern: "machinery/skw25Detail",
    defaults: new { controller = "Home", action = "Skw25Detail" });

app.MapControllerRoute(
    name: "default",
    pattern: "production",
    defaults: new { controller = "Home", action = "Production" });

app.MapControllerRoute(
    name: "default",
    pattern: "machinery/brazingMachine",
    defaults: new { controller = "Home", action = "BrazingMachine" });

app.Run();
