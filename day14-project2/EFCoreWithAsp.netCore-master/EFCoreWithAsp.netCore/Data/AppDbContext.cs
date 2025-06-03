using EFCoreWithAsp.netCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace EFCoreWithAsp.netCore.Data
{
    public class AppDbContext:IdentityDbContext
    {
        //Constructor
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        //DbSet properties
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        // Identity tables are automatically created by IdentityDbContext
        public DbSet<ApplicationUser> ApplicationUsers { get; set; } // Not needed, IdentityDbContext already handles this

    }
}
