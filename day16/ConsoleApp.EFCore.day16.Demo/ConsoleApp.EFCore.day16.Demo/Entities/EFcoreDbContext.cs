using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp.EFCore.day16.Demo.Entities;
public class EFcoreDbContext:DbContext
{

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //  on configuring is an override method that is allowed to configure the context
        string connectionString = @"Data Source=cstsrv001.westus2.cloudapp.azure.com;Initial Catalog=EFCoreDb02;user ID=sa;Password=Cst001.com;TrustServerCertificate=True;";
        optionsBuilder.UseSqlServer(connectionString);
    }

    //table properties
    public DbSet<Student> Students { get; set; } = null!;
    public DbSet<Branch> Branches { get; set; } = null!;
    




}
