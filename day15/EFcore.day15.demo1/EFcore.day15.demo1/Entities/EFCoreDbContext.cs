using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// EFcorename apce
using Microsoft.EntityFrameworkCore;

namespace EFcore.day15.demo1.Entities;

public class EFCoreDbContext : DbContext
{
    // constructor to pass options to the base DbContext
    // options are used to configure the context, like the database provider and connection string
    

    // on configuring is an override method that is allowed to configure the context
    // like see the database provider and connection string
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            @"Data Source=cstsrv001.westus2.cloudapp.azure.com;Initial Catalog=EFCoreDb01;user ID=sa;Password=Cst001.com;TrustServerCertificate=True;");

    }




    // define table mapping
    // DbSet<Student> students will be mapped to Students table in the database
    public DbSet<Student> Students { get; set; }

    // DbSet<Branch> branches will be mapped to Branches table in the database
    public DbSet<Branch> Branches { get; set; }




} //end of class

