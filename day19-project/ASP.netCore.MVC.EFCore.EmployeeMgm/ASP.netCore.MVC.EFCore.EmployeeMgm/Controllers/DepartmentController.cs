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
    
    /// <summary>
    /// Index method to display all the departments
    /// </summary>
    /// <returns></returns>
    public IActionResult Index()
    {
        // fetch the data from the database using the repository
        var departments = _departmentRepository.GetAllAsync().Result;
        return View(departments);
    }

    // add method get
    [HttpGet]

    public IActionResult Add()
    {
        return View();
    }
    // post method to add a new department
    [HttpPost]
    public async Task<IActionResult> Add(DepartmentViewModel model)
    {
        if (!ModelState.IsValid)
        {


            return View(model);
        }

        //insert the record into the database

        await _departmentRepository.AddAsync(model);

        return RedirectToAction("Index","Department");
        
        // return View();
    }



    #region Edit department httpget
    [HttpGet]
    public async Task<IActionResult> Edit(int id)
    {
        var department = await _departmentRepository.GetByIdAsync(id);
        return View(department);

    }

    #endregion

    //post /Department/edit
    [HttpPost]
    public async Task<IActionResult> Edit(DepartmentViewModel department)
    {
        if(ModelState.IsValid)
        {// update the department with modified details
        await _departmentRepository.UpdateAsync(department);

        return RedirectToAction("Index","Department");
    }

        // if the model is not valid,return the view with the model

        return View(department);


    }


    #region Delete method

    [HttpGet]
    // department/delete
    public async Task<IActionResult> Delete(int id)



    {

        // delete the department from the database

        await _departmentRepository.DeleteAsync(id);

        // after deleting the department, redirect to the index pages - show all departments

        return RedirectToAction("Index", "Department");
    }

    #endregion





} // end of class


