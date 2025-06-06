using Microsoft.AspNetCore.Mvc;

namespace ASP.netCore.MVC.EFCore.EmployeeMgm.Controllers;
public class EmployeeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
