using Microsoft.AspNetCore.Identity;

namespace ASP.netCore.MVC.EFCore.EmployeeMgm.Models;

public class ApplicationUser:  IdentityUser

{
    
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Address { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Country { get; set; }
    public string? PostalCode { get; set; }


}
