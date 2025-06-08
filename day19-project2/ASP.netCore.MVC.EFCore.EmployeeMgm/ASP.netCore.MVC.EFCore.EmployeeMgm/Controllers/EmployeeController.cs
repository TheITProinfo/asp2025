using ASP.netCore.MVC.EFCore.EmployeeMgm.Data;
using ASP.netCore.MVC.EFCore.EmployeeMgm.Models;
using ASP.netCore.MVC.EFCore.EmployeeMgm.Repositories;
using ASP.netCore.MVC.EFCore.EmployeeMgm.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ASP.netCore.MVC.EFCore.EmployeeMgm.Controllers;
public class EmployeeController : Controller
{
    #region constructor 
    // injecting the repository interface to use the methods defined in it
    private readonly IEmployeeRepository _employeeRepository;

    public EmployeeController(IEmployeeRepository employeeRepository)
    {
            _employeeRepository = employeeRepository;
    }
    

    #endregion
    #region index method

    public async Task<IActionResult> Index(string searchString, string sortOrder,int pageNumber)
    {
        // get sorting order from the view
        ViewData["CurrentSort"] = sortOrder;
        //Sorting
        ViewData["NameSortParam"] = string.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
        ViewData["DateOfBirthSortParm"] = sortOrder == "date_asc" ? "date_desc" : "date_asc";
        ViewData["IsActiveSortParam"] = sortOrder == "isactive_asc" ? "isactive_desc" : "isactive_asc";
        // get the data from the database using the repository
        var employees = _employeeRepository.GetAllAsync();
        // search functionality
        if (!string.IsNullOrEmpty(searchString))
        {
            employees = employees.Where(x => x.FirstName.Contains(searchString) || x.LastName.Contains(searchString));
        }
        // sort functionality
        switch (sortOrder)
        {
            case "name_desc":
                employees = employees.OrderByDescending(e => e.FirstName);
                break;

            case "date_asc":
                employees = employees.OrderBy(s => s.DateOfBirth);
                break;
            case "date_desc":
                employees = employees.OrderByDescending(s => s.DateOfBirth);
                break;
            case "isactive_desc":
                employees = employees.OrderByDescending(e => e.IsActive);
                break;
            case "isactive_asc":
                employees = employees.OrderBy(e => e.IsActive);
                break;

            default:
                employees = employees.OrderBy(e => e.FirstName);
                break;
        }

        // return the view with the employees data with page list

        // Ensure pageNumber is at least 1
        if (pageNumber < 1)
        {
            pageNumber = 1;
        }

        int pageSize = 5;
        return View(await PaginatedList<EmployeeViewModel>.CreateAsync(employees, pageNumber, pageSize));
    }

    #endregion

    #region Add method get
    //  Add method post
    //get: /employee/add

    [HttpGet]
    public async Task<IActionResult> Add()
    {
        // pass all departments to the view
        //ViewBag.Departments = await _employeeRepository.GetAllDepartmentsAsync();
        var departments = await _employeeRepository.GetAllDepartmentsAsync();
        // add the departments to select list
        ViewBag.Departments = new SelectList(departments, "DepartmentId", "Name");
        return View();
    }








    #endregion

    #region add method post
    //post: /employee/add
    [HttpPost]
    public async Task<IActionResult> AddAsync(EmployeeViewModel model)
    {
        if (ModelState.IsValid)
        {



          //  add the record into the database
            await _employeeRepository.AddAsync(model);
            // add successfuly message
            TempData["SuccessMessage"] = "Employee added successfully!";
            return RedirectToAction("Index", "Employee");
        }

        return View(model);
    }



    #endregion

    #region Update Employee

    //GET: Employee/Edit
    [HttpGet]
    public async Task<IActionResult> Edit(int id)
    {
        //Fetch department details
        var departments = await _employeeRepository.GetAllDepartmentsAsync();
        ViewBag.Departments = new SelectList(departments, "DepartmentId", "Name");

        //Fetch the employee details
        var employee = await _employeeRepository.GetByIdAsync(id);
        return View(employee);
    }

    //POST: Employee/Edit
    [HttpPost]
    public async Task<IActionResult> Edit(EmployeeViewModel employee)
    {

        if (!ModelState.IsValid)
        {
            return View(employee); // Return to the form with validation errors
        }
        //Update the database with modified details
        await _employeeRepository.UpdateAsync(employee);
        // update successfully message
        TempData["SuccessMessage"] = "Employee updated successfully!";

        // Redirect to List all department page
        return RedirectToAction("Index", "Employee");
    }

    #endregion

    #region delele one employee

    //GET: /Employee/Delete
    [HttpGet]
    public async Task<IActionResult> Delete(int id)
    {
        //Delete the data from database
        await _employeeRepository.DeleteAsync(id);
        // Redirect to List all department page
        return RedirectToAction("Index", "Employee");
    }

    #endregion

    #region Add to export excel
    //GET: /Employee/ExportToExcel
    [HttpGet]
    public async Task<IActionResult> ExportToExcel()
    {
        var employees = await _employeeRepository.GetAllForExportAsync();
        var content = ExcelExportHelper.ExportEmployeesToExcel(employees);
        var fileName = $"Employees_{DateTime.Now:yyyyMMddHHmmss}.xlsx";

        return File(content,
            "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
            fileName);
    }

    #endregion

    #region Add export to PDF 
    //  Add export to PDF
    // GET: /Employee/ExportToPdf
    [HttpGet]

    public async Task<IActionResult> ExportToPdf()
    {
        var employees = await _employeeRepository.GetAllForExportAsync();
        var imagesFolderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images");

        var pdfContent = PdfExportHelper.ExportEmployeesToPdf(employees, imagesFolderPath);

        return File(pdfContent, "application/pdf", $"Employees_{DateTime.Now:yyyyMMddHHmmss}.pdf");
    }


    #endregion
} //end of class
