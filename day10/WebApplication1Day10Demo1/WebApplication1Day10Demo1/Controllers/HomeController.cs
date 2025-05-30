using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1Day10Demo1.Models;

namespace WebApplication1Day10Demo1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // index method

        public IActionResult Index()
        {
            
            return View();
        }

        // privacy method 
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
