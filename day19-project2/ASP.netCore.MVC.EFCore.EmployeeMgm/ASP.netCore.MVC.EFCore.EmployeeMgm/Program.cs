
using Microsoft.EntityFrameworkCore;

using ASP.netCore.MVC.EFCore.EmployeeMgm.Data;
using ASP.netCore.MVC.EFCore.EmployeeMgm.Models;
using ASP.netCore.MVC.EFCore.EmployeeMgm.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;

namespace ASP.netCore.MVC.EFCore.EmployeeMgm;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        //builder.Services.AddControllersWithViews();
        //global need identity services
        builder.Services.AddControllersWithViews(options =>
        {
            var policy = new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser()
                .Build();
            options.Filters.Add(new AuthorizeFilter(policy));
        });

        // Add EF Core services to the services container.
        var  connectionString = builder.Configuration.GetConnectionString("EmployeeDBConnection");

        builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(connectionString));
        //  register identity services
        //builder.Services.AddDefaultIdentity<ApplicationUser>()
        //    .AddRoles<IdentityRole>()
        //    .AddEntityFrameworkStores<AppDbContext>();
        //builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
        //    {
        //        options.SignIn.RequireConfirmedAccount = false;
        //    })
        //    .AddEntityFrameworkStores<AppDbContext>();

        // add email service
        builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false; // Require email confirmation
            })
            .AddEntityFrameworkStores<AppDbContext>()
            .AddDefaultTokenProviders(); // Needed for email confirmation tokens

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

       
        app.UseAuthentication();
        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.MapRazorPages(); // this enables routing for Identity UI pages

        app.Run();
    }
}
