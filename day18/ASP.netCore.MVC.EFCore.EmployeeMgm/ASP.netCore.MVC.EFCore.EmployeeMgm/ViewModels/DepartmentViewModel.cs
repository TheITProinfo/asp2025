


using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace ASP.netCore.MVC.EFCore.EmployeeMgm.ViewModels;

public class DepartmentViewModel
{
    public int DepartmentId { get; set; }
    [Required(ErrorMessage = "Department name is not empty")]
    public string Name { get; set; }
}
