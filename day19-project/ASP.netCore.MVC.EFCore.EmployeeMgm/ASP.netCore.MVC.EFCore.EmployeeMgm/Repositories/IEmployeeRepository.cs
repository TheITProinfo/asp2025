using ASP.netCore.MVC.EFCore.EmployeeMgm.ViewModels;
using ASP.netCore.MVC.EFCore.EmployeeMgm.Models;

namespace ASP.netCore.MVC.EFCore.EmployeeMgm.Repositories;

public interface IEmployeeRepository
{
    Task<EmployeeViewModel> GetByIdAsync(int id);
    IQueryable<EmployeeViewModel> GetAllAsync();
    
   Task AddAsync(EmployeeViewModel employee);
    Task UpdateAsync(EmployeeViewModel employee);
    Task DeleteAsync(int id);


    Task<List<Department>> GetAllDepartmentsAsync();
    // add to export to  excel
    Task<List<EmployeeViewModel>> GetAllForExportAsync();

}
