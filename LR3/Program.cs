using LR3.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;

var builder = WebApplication.CreateBuilder(args);

// ������ ����� CalcService �� ��������� (Singleton)
builder.Services.AddSingleton<CalcService>();

// ������ ����� ������� Razor
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

// ������ ������� Razor �� ��������
app.MapRazorPages();

app.Run();