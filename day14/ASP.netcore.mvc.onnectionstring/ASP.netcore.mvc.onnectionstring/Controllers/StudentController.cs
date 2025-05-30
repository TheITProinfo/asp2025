using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace ASP.netcore.mvc.onnectionstring.Controllers;
public class StudentController : Controller
{
    //private readonly IConfiguration _configuration;
    private readonly IConfiguration _configuration;

    // Inject IConfiguration through constructor
    public StudentController(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    public IActionResult Index()
    {
        string myDbConnectionString = _configuration.GetConnectionString("MyConnectionString");
        ViewBag.ConnectionString = myDbConnectionString;
        return View();
    }
}
