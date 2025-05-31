using System.ComponentModel;
using ASP.netCore.MVCCRUD.day14.demo1.Models;
using ASP.netCore.MVCCRUD.day14.demo1.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace ASP.netCore.MVCCRUD.day14.demo1.Controllers;
public class StudentController : Controller
{
   
    public IActionResult Index()
    {
        string myDbConnectionString = AppConfigurationService._configuration.GetConnectionString("myConnectionString");

        ViewBag.connStr = myDbConnectionString;

        // for testing insert one record -executeNonquery
        // inset update delete
        // hard code for testing

        #region MyRegion - not used sql helper

        //        using (SqlConnection conn=new SqlConnection(myDbConnectionString))
        //        {
        //            conn.Open();
        //            string sqlTxt = @"
        //                insert into Students (FirstName,LastName,Email)
        //values('Alice100','Wang100','abc@hotmail.com');
        //                    ";

        //            using (SqlCommand command=new SqlCommand(sqlTxt,conn))
        //            {
        //                int rows= command.ExecuteNonQuery();

        //                if (rows > 0)
        //                {
        //                    ViewBag.mymess = "insert successfully";
        //                }
        //                else
        //                {
        //                    ViewBag.mymess = "insert failure";
        //                }
        //            }


        //        }

        #endregion

        string sqlTxt = @"insert into Students (FirstName,LastName,Email)
values('Alice200','Wang200','abc200@hotmail.com');";

        int rows = MSSQLHelper.ExecuteNoQuery(sqlTxt);

        if (rows > 0)
        {
            ViewBag.mymess = "inset one record";
        }
        else
        {
            ViewBag.mymess = "insert failure";
        }

        return View();
    }

    public IActionResult Details()
    {
       //
       string sqlTxt = @"
          SELECT COUNT(*) FROM Students";

       object totals = MSSQLHelper.GetScalar(sqlTxt);
       int totalStudents = Convert.ToInt32(totals);
       ViewBag.mess = totalStudents;
        return View();
    }
}
