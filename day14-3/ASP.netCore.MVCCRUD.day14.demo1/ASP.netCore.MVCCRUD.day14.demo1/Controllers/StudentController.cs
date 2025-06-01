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
        //string myDbConnectionString = AppConfigurationService._configuration.GetConnectionString("myConnectionString");

        //ViewBag.connStr = myDbConnectionString;

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
        #region  -for testing purpose

        //        string sqlTxt = @"insert into Students (FirstName,LastName,Email)
        //values('Alice200','Wang200','abc200@hotmail.com');";

        //        int rows = MSSQLHelper.ExecuteNoQuery(sqlTxt);

        //        if (rows > 0)
        //        {
        //            ViewBag.mymess = "inset one record";
        //        }
        //        else
        //        {
        //            ViewBag.mymess = "insert failure";
        //        }
        #endregion

        #region list all students

        List<StudentViewModel> students = new List<StudentViewModel>();

        string sqlTxt = "SELECT Id, FirstName, LastName, Email FROM Students";

        SqlDataReader reader = MSSQLHelper.GetDataReader(sqlTxt);
        while (reader.Read())
        {
            students.Add(new StudentViewModel
            {
                Id = Convert.ToInt32(reader["Id"]),
                FirstName = reader["FirstName"].ToString(),
                LastName = reader["LastName"].ToString(),
                Email = reader["Email"].ToString()
            });
        }


        return View(students);



        #endregion


    }


   
        #region test purpose
        //string sqlTxt = @"
        //   SELECT COUNT(*) FROM Students";

        //object totals = MSSQLHelper.GetScalar(sqlTxt);
        //int totalStudents = Convert.ToInt32(totals);
        //ViewBag.mess = totalStudents;
        // return View();


        #endregion//
        public IActionResult Details(int id)
        {
            string sql = $"SELECT Id, FirstName, LastName, Email FROM Students WHERE Id = {id}";
            var reader = MSSQLHelper.GetDataReader(sql);

            StudentViewModel student = null;

            if (reader.Read())
            {
                student = new StudentViewModel
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    Email = reader["Email"].ToString()
                };
            }

            reader.Close();

            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }





    [HttpGet]
    public IActionResult Edit(int id)
    {
        string sql = $"SELECT Id, FirstName, LastName, Email FROM Students WHERE Id = {id}";
        var reader = MSSQLHelper.GetDataReader(sql);

        StudentViewModel student = null;

        if (reader.Read())
        {
            student = new StudentViewModel
            {
                Id = Convert.ToInt32(reader["Id"]),
                FirstName = reader["FirstName"].ToString(),
                LastName = reader["LastName"].ToString(),
                Email = reader["Email"].ToString()
            };
        }

        reader.Close();

        if (student == null)
        {
            return NotFound();
        }

        return View(student);
    }

    [HttpPost]
    public IActionResult Edit(StudentViewModel model)
    {
        if (ModelState.IsValid)
        {
            string sql = $@"
            UPDATE Students 
            SET FirstName = '{model.FirstName}', 
                LastName = '{model.LastName}', 
                Email = '{model.Email}'
            WHERE Id = {model.Id}";

            MSSQLHelper.ExecuteNonQuery(sql);

            return RedirectToAction("Index");
        }

        return View(model);
    }

    public IActionResult Delete(int id)
    {
        // Example delete logic
        string sql = $"DELETE FROM Students WHERE Id = {id}";
        MSSQLHelper.ExecuteNonQuery(sql);

        return RedirectToAction("Index");
    }
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(StudentViewModel model)
    {
        if (ModelState.IsValid)
        {
            string sql = $@"
            INSERT INTO Students (FirstName, LastName, Email)
            VALUES ('{model.FirstName}', '{model.LastName}', '{model.Email}')";

            MSSQLHelper.ExecuteNonQuery(sql);

            return RedirectToAction("Index");
        }

        return View(model);
    }


}
