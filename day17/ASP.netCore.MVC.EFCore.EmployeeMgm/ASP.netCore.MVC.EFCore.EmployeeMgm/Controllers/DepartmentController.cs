using System.Security.Cryptography;
using ASP.netCore.MVC.EFCore.EmployeeMgm.ViewModels;
using Microsoft.AspNetCore.Mvc;
using ASP.netCore.MVC.EFCore.EmployeeMgm.Repositories;

namespace ASP.netCore.MVC.EFCore.EmployeeMgm.Controllers;
public class DepartmentController : Controller
{
    //  injecting the repository interface to use the methods defined in it
    private readonly IDepartmentRepository _departmentRepository;
    public DepartmentController(IDepartmentRepository departmentRepository)
    {
        _departmentRepository = departmentRepository;
    }   
    
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]

    public IActionResult Add()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Add(DepartmentViewModel model)
    {
        
        //insert the record into the database

        await _departmentRepository.AddAsync(model);

        return RedirectToAction("Index","Department");
        
        // return View();
    }
}
