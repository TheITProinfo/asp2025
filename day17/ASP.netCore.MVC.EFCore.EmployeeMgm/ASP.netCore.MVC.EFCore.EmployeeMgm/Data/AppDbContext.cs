using Microsoft.EntityFrameworkCore;
using ASP.netCore.MVC.EFCore.EmployeeMgm.Models;

namespace ASP.netCore.MVC.EFCore.EmployeeMgm.Data;

public class AppDbContext:DbContext
{
    // create constructor to pass the DbContextOptions to the base class
    // ctor tab
    public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
    {
        
    }

    // DbSet properties for the entities-will be created tables in the database
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Department> Departments { get; set; }
}
