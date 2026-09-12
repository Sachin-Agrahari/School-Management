using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SchoolManagementERP.DataAccess;
using SchoolManagementERP.Extensions;
using SchoolManagementERP.Interface;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddSession(o => { o.IdleTimeout = TimeSpan.FromHours(4); });

//ExtensionsService
builder.Services.AddApplicationExtensionsService();

var app = builder.Build();
app.UseStaticFiles();
app.UseSession();
app.UseRouting();
app.MapControllerRoute(name: "default", pattern: "{controller=Login}/{action=Index}/{id?}");
app.Run();
