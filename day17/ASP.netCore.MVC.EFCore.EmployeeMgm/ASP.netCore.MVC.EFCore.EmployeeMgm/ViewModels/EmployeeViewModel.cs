using System.ComponentModel.DataAnnotations.Schema;
using ASP.netCore.MVC.EFCore.EmployeeMgm.Models;

namespace ASP.netCore.MVC.EFCore.EmployeeMgm.ViewModels;

public class EmployeeViewModel
{
    public int EmployeeId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public string Gender { get; set; }

    public DateTime DateOfBirth { get; set; }
    public bool IsActive { get; set; }
    // foreign key
    [ForeignKey("Department")]
    public int DepartmentId { get; set; } // Foreign key for the Department
    public Department? Department { get; set; } // Navigation property for the Department
}
