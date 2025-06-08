
using Microsoft.EntityFrameworkCore;

using ASP.netCore.MVC.EFCore.EmployeeMgm.Data;
using ASP.netCore.MVC.EFCore.EmployeeMgm.Repositories;

namespace ASP.netCore.MVC.EFCore.EmployeeMgm;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllersWithViews();
        // Add EF Core services to the services container.
        var  connectionString = builder.Configuration.GetConnectionString("EmployeeDBConnection");

        builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(connectionString));

        // register department service
        builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
        //  register employee service
        builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();


        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
        }
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}
