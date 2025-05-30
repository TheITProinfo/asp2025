using Microsoft.AspNetCore.Mvc;
using WebApplication1Day11Demo.Models;

namespace WebApplication1Day11Demo.Controllers;
public class StudentController : Controller
{
    public IActionResult Index()
    {
        return View(); // called default view-index
    }

    // add program method

    public IActionResult Program()
    {
        ViewData["ProgramName"] = "network technical support";
        ViewBag.ProgramDate = DateTime.Now;
       
        return View();
    }

    public IActionResult Profile()
    {
        var model = new UserViewModel
        { Id=100,
            Name="Wang",
            Age=35


        };
        // fetch data from database
        // hard code


        // pass the model to view
        return View( model); // call profiles view
    }
}
