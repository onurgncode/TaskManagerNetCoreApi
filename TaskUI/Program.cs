using System;
using StaticKimlikKarti.Models;
using Microsoft.EntityFrameworkCore;
using StaticKimlikKarti.Repostiory;
using TaskUI.Repostiory;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
// MSSQL ba�lant�s�n� yap�land�r
builder.Services.AddDbContext<AppContextDb>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<GorevYonet>();
builder.Services.AddScoped<RaporYonet>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStaticFiles();





app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();
app.MapDefaultControllerRoute();
app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Create}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
