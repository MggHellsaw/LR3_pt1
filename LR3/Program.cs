using LR3.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;

var builder = WebApplication.CreateBuilder(args);

// Додаємо сервіс CalcService як одиничний (Singleton)
builder.Services.AddSingleton<CalcService>();

// Додаємо сервіс сторінок Razor
builder.Services.AddRazorPages();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// Додаємо сторінки Razor до маршрутів
app.MapRazorPages();

app.Run();