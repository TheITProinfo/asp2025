using ASP.netCore.MVC.EFCore.EmployeeMgm.Data;
using ASP.netCore.MVC.EFCore.EmployeeMgm.Models;

using ASP.netCore.MVC.EFCore.EmployeeMgm.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace ASP.netCore.MVC.EFCore.EmployeeMgm.Repositories;

public class EmployeeRepository : IEmployeeRepository

{
    #region constructor
 // add constructor injection for DbContext if needed
    private readonly AppDbContext _dbContext;
    public EmployeeRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    

    #endregion
   

    #region Add to database
public async Task  AddAsync(EmployeeViewModel employee)
    {
        string? uniqueFileName = null;
        // upload the photo if it exists
        // Handle image upload
        // Validate uploaded file
        if (employee.PhotoPath != null && employee.PhotoPath.Length > 0)
        {
            uniqueFileName = await SaveImageAsync(employee.PhotoPath);
        }
        // define employee entity 
        var newEmployee = new Employee()
        {
            FirstName = employee.FirstName,
            LastName = employee.LastName,
            DateOfBirth = employee.DateOfBirth,
            PhoneNumber = employee.PhoneNumber,
            Gender = employee.Gender,
            Email = employee.Email,
            Address = employee.Address,
            IsActive = employee.IsActive,
            DepartmentId = employee.DepartmentId,
            PhotoFileName = uniqueFileName // Save file name to DB
        };
        await _dbContext.Employees.AddAsync(newEmployee);
        await _dbContext.SaveChangesAsync();
    }


    #endregion

    #region delete

    public async Task DeleteAsync(int Id)
    {
        Employee employee = await _dbContext.Employees.FindAsync(Id);
        _dbContext.Employees.Remove(employee);
        await _dbContext.SaveChangesAsync();
    }


    #endregion

    #region get all employees

    
 public IQueryable<EmployeeViewModel> GetAllAsync()
    {
        //Lambda expression to select the properties from the Employee model
        var employees = _dbContext.Employees
            .Select(e => new EmployeeViewModel
            {
                EmployeeId = e.EmployeeId,
                FirstName = e.FirstName,
                LastName = e.LastName,
                DateOfBirth = e.DateOfBirth,
                Gender = e.Gender,
                Email = e.Email,
                PhoneNumber = e.PhoneNumber,
                Address = e.Address,
                IsActive = e.IsActive,
                DepartmentId = e.DepartmentId,
                // add picture
                PhotoFileName=e.PhotoFileName
            });

        return employees;
    }
    #endregion

    #region get all departments from the  database
    // used for dropdown list in  add and edit
 public async Task<List<Department>> GetAllDepartmentsAsync()
    {
        return await _dbContext.Departments.ToListAsync();
    }


    #endregion

    

    #region get one record by id

    public async  Task<EmployeeViewModel> GetByIdAsync(int id)
    {
        var employee = await _dbContext.Employees.FindAsync(id);
        var employeeViewModel = new EmployeeViewModel
        {
            EmployeeId = employee.EmployeeId,
            FirstName = employee.FirstName,
            LastName = employee.LastName,
            DateOfBirth = employee.DateOfBirth,
            Gender = employee.Gender,
            Email = employee.Email,
            PhoneNumber = employee.PhoneNumber,
            Address = employee.Address,
            IsActive = employee.IsActive,
            DepartmentId = employee.DepartmentId,
            PhotoFileName = employee.PhotoFileName
        };
        return employeeViewModel;
    }

    #endregion

    #region update record by id

     public  async Task UpdateAsync(EmployeeViewModel employeeUpdated)
    {
        // get one employee by id and update the properties
        var employee = await _dbContext.Employees.FindAsync(employeeUpdated.EmployeeId);
        if (employee == null) throw new InvalidOperationException("Employee not found.");
        employee.Email = employeeUpdated.Email;
        employee.FirstName = employeeUpdated.FirstName;
        employee.LastName = employeeUpdated.LastName;
        employee.Email = employeeUpdated.Email;
        employee.DateOfBirth = employeeUpdated.DateOfBirth;
        employee.PhoneNumber = employeeUpdated.PhoneNumber;
        employee.Address = employeeUpdated.Address;
        employee.DepartmentId = employeeUpdated.DepartmentId;
        employee.IsActive = employeeUpdated.IsActive;

        //employee.PhotoFileName = employeeUpdated.PhotoFileName; // Save file name to DB
        // Handle photo update
        if (employeeUpdated.PhotoPath != null && employeeUpdated.PhotoPath.Length > 0)
        {
            // Optional: delete old photo
            if (!string.IsNullOrEmpty(employee.PhotoFileName))
            {
                var oldPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", employee.PhotoFileName);
                if (File.Exists(oldPath))
                    File.Delete(oldPath);
            }

            // Save new photo using helper
            var newFileName = await SaveImageAsync(employeeUpdated.PhotoPath);
            employee.PhotoFileName = newFileName;
        }

        // Update the employee in the database
        _dbContext.Employees.Update(employee);
        await _dbContext.SaveChangesAsync();
    }

    #endregion

    #region Add to export to excel
    public async Task<List<EmployeeViewModel>> GetAllForExportAsync()
    {
        return await _dbContext.Employees
            .Include(e => e.Department)
            .Select(e => new EmployeeViewModel
            {
                EmployeeId = e.EmployeeId,
                FirstName = e.FirstName,
                LastName = e.LastName,
                Email = e.Email,
                PhoneNumber = e.PhoneNumber,
                Address = e.Address,
                Gender = e.Gender,
                DateOfBirth = e.DateOfBirth,
                IsActive = e.IsActive,
                DepartmentId = e.DepartmentId,
                DepartmentName = e.Department != null ? e.Department.Name : "",
                PhotoFileName = e.PhotoFileName //
            })
            .ToListAsync();
    }



    #endregion

    #region saveIMage


    private async Task<string?> SaveImageAsync(IFormFile photo)
    {
        var allowedExtensions = new[] { ".jpg", ".jpeg", ".png", ".gif" };
        var extension = Path.GetExtension(photo.FileName).ToLowerInvariant();

        if (!allowedExtensions.Contains(extension))
            throw new InvalidOperationException("Invalid file type. Only image files are allowed.");

        const long maxSizeInBytes = 2 * 1024 * 1024;
        if (photo.Length > maxSizeInBytes)
            throw new InvalidOperationException("File size must be less than 2 MB.");

        var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images");
        Directory.CreateDirectory(uploadsFolder);

        var uniqueFileName = Guid.NewGuid().ToString() + extension;
        var filePath = Path.Combine(uploadsFolder, uniqueFileName);

        using var stream = new FileStream(filePath, FileMode.Create);
        await photo.CopyToAsync(stream);

        return uniqueFileName;
    }
    #endregion
   








} //end of class
