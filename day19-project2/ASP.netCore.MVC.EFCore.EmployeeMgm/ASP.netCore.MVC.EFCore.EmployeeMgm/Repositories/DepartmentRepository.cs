using ASP.netCore.MVC.EFCore.EmployeeMgm.Data;
using ASP.netCore.MVC.EFCore.EmployeeMgm.Models;
using ASP.netCore.MVC.EFCore.EmployeeMgm.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace ASP.netCore.MVC.EFCore.EmployeeMgm.Repositories;

public class DepartmentRepository : IDepartmentRepository

{
    private readonly AppDbContext _dbContext;

    // constructor to inject the AppDbContext
    public DepartmentRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AddAsync(DepartmentViewModel department)
    {
        //throw new NotImplementedException();


        var departmentEntity = new Department()
        {
            Name = department.Name,
           
        };

        await _dbContext.Departments.AddAsync(departmentEntity);
        await _dbContext.SaveChangesAsync();
    }

    public  async Task DeleteAsync(int Id)
    {
       Department department = await _dbContext.Departments.FindAsync(Id);
        _dbContext.Departments.Remove(department);
        await _dbContext.SaveChangesAsync();

    }

    public async Task<List<DepartmentViewModel>> GetAllAsync()
    {
        // get all departments from the database
        var departments = await _dbContext.Departments.ToListAsync();

        // define departmentViewModels list to store the departmentViewModels
        var departmentViewModels = new List<DepartmentViewModel>();

        foreach (var department in departments)
        {
            var departmentViewModel = new DepartmentViewModel
            {
                DepartmentId = department.DepartmentId,
                Name = department.Name,
            };

            departmentViewModels.Add(departmentViewModel);

        }// end of foreach
         return departmentViewModels;


    }

    /// <summary>
    /// Get one department by id
    /// </summary>
    /// <param name="id"></param>
    /// <returns>departmentviewmodel </returns>
    public async Task<DepartmentViewModel> GetByIdAsync(int id)
    {
        var department = await _dbContext.Departments.FindAsync(id);
        var departmentViewModel = new DepartmentViewModel
        {
            DepartmentId = department.DepartmentId,
            Name = department.Name,
        };
        return departmentViewModel;
    }

    public async Task  UpdateAsync(DepartmentViewModel departmentUpdated)
    {
        //throw new NotImplementedException();
         var department = await _dbContext.Departments.FindAsync(departmentUpdated.DepartmentId);
        department.Name = departmentUpdated.Name;

        //save the changes to the database
        _dbContext.Update(department);
        await _dbContext.SaveChangesAsync();

    }
}
