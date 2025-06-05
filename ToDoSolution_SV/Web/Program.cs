using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using NTierTodoApp.Business;
using NTierTodoApp.DataAccess;

var builder = WebApplication.CreateBuilder(args);

// إضافة خدمة MVC
builder.Services.AddControllersWithViews();

// تسجيل مستودع البيانات والطبقة التجارية
builder.Services.AddSingleton<TaskRepository>(); // استخدام Singleton للمحاكاة بالذاكرة
builder.Services.AddTransient<TaskService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
