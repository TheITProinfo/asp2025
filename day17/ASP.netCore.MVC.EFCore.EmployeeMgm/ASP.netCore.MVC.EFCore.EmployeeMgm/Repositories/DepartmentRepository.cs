using ASP.netCore.MVC.EFCore.EmployeeMgm.Data;
using ASP.netCore.MVC.EFCore.EmployeeMgm.Models;
using ASP.netCore.MVC.EFCore.EmployeeMgm.ViewModels;

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

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<DepartmentViewModel>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<DepartmentViewModel> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<DepartmentViewModel> UpdateAsync(DepartmentViewModel department)
    {
        throw new NotImplementedException();
    }
}
