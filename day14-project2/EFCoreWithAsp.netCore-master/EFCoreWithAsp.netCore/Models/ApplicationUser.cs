using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreWithAsp.netCore.Models;

public class ApplicationUser: IdentityUser
{
    [Required]
    public string FirstName { get; set; }
    public string LastName { get; set; }
    
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public string PostalCode { get; set; }
}
