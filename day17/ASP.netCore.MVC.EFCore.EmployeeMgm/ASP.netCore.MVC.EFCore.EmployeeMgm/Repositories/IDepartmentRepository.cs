using ASP.netCore.MVC.EFCore.EmployeeMgm.ViewModels;
using ASP.netCore.MVC.EFCore.EmployeeMgm.Models;

namespace ASP.netCore.MVC.EFCore.EmployeeMgm.Repositories;

public interface IDepartmentRepository
{
    Task<List<DepartmentViewModel>> GetAllAsync();
    Task<DepartmentViewModel> GetByIdAsync(int id);
    Task AddAsync(DepartmentViewModel department);
    Task<DepartmentViewModel> UpdateAsync(DepartmentViewModel department);
    Task DeleteAsync(int id);
}
