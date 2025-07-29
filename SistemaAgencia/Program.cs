using Microsoft.EntityFrameworkCore;
using SistemaAgencia.Models; 

var builder = WebApplication.CreateBuilder(args);

WebApplicationBuilder builder1 = builder;

builder1.Services.AddDbContext<AgenciaDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
