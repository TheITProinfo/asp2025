using ASP.netCore.MVC.EFCore.EmployeeMgm.Models;
using ASP.netCore.MVC.EFCore.EmployeeMgm.ViewModels;

namespace ASP.netCore.MVC.EFCore.EmployeeMgm.Repositories;

public class EmployeeRepository : IEmployeeRepository
{
    public Task<EmployeeViewModel> AddAsync(EmployeeViewModel employee)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public IQueryable<EmployeeViewModel> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<List<Department>> GetAllDepartmentsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<EmployeeViewModel> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<EmployeeViewModel> UpdateAsync(EmployeeViewModel employee)
    {
        throw new NotImplementedException();
    }
}
