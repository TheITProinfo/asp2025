using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.netCore.MVC.EFCore.EmployeeMgm.Models;

public class Employee
{
    public int EmployeeId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Gender { get; set; }
    public bool IsActive { get; set; }

    
        // other properties...
    public string? PhotoFileName { get; set; }
                   


    // relationships with the Departments
    [ForeignKey("Department")]
    public int DepartmentId { get; set; } // for the foreign key
    public Department? Department { get; set; } //reference  navigation property

}
