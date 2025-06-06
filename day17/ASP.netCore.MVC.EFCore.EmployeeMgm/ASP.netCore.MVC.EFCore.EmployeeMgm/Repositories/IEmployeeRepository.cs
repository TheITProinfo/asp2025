using ASP.netCore.MVC.EFCore.EmployeeMgm.ViewModels;
using ASP.netCore.MVC.EFCore.EmployeeMgm.Models;

namespace ASP.netCore.MVC.EFCore.EmployeeMgm.Repositories;

public interface IEmployeeRepository
{
    Task<EmployeeViewModel> GetByIdAsync(int id);
    IQueryable<EmployeeViewModel> GetAllAsync();
    Task<EmployeeViewModel> AddAsync(EmployeeViewModel employee);
    Task<EmployeeViewModel> UpdateAsync(EmployeeViewModel employee);
    Task DeleteAsync(int id);


    Task<List<Department>> GetAllDepartmentsAsync();

}
