using Microsoft.AspNetCore.Mvc;

namespace WebApplication1Day10Demo1.Controllers
{
    public class StudentController : Controller
    {
        // default index method
        public IActionResult Index()
        {
            return View();
        }

        // create show method --return string

        public string Show()
        {
            return "Hello, this is show page";
        }

        public IActionResult Details()
        {
            return View();
        }
         
        // xxx.com/Student/Show2?id=s100&age=25&name=John
        public string Show2(string id,int age,string name)
        {
            //return "Hello, this is show page";
            return $"id={id},age={age},name{name}";
        }

        // xxx.com/Student/Show2/s100&age=25&name=John
        // default id parameter 
        public string Show3(string id, int age, string name)
        {
            //return "Hello, this is show page";
            return $"id={id},age={age},name{name}";
        }

        public IActionResult Add()
        {
            // no parameter, call add.cshtml
            return View();
        }










    } // end of class










} // end of namespace
