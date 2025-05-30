using Microsoft.AspNetCore.Mvc;
using WebApplication1Day11Demo.Models;

namespace WebApplication1Day11Demo.Controllers;
public class ProductController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Details()
    {
        // usually fetch data from database
        // this example hard code

        var product = new Product
        {

            Id = 10001,
            Name = "Wireless mouse",
            Price = 12.56m

        };

        return View(product); 

    }
}
