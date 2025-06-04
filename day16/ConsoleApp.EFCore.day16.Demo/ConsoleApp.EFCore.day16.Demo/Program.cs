// namespace
using ConsoleApp.EFCore.day16.Demo.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp.EFCore.day16.Demo;


public class Program
{
    static void Main(string[] args)
    {
        // create a new instance of the EFCoreDbContext
        using var dbContext = new EFcoreDbContext();
        //addBranch(dbContext);

        //AddStudent(dbContext);

        //GetAllStudents(dbContext);

        //GetStudentsByID(dbContext,1);// assuming the student ID is 1
        //UpdateStudent(dbContext,3); //assuming the student ID is 2

        // DeleteStudent(dbContext,2);//assuming the  student ID is 2

        // emmple Lamda expression to get even numbers from 1 to 10
        int[]  numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        // linQ query to get even numbers from 1 to 10 and greater than 5
        var evenNumbers = from number in numbers 
                                        where number >5 && number % 2 == 0 
                                        select number;

        // iterate over the even numbers
        foreach (var number in evenNumbers)
        {
            Console.Write(number+" ");
        }

        Console.WriteLine();

        // with lambda expression 

        var evenNumbers2 = numbers.Where(number => number > 5 && number % 2 == 0)
            .OrderByDescending(number=>number)
            .Select(number => number);

        foreach (var number in evenNumbers2)
        {
            Console.Write(number+" ");

        }

        Console.WriteLine();
            







    } // end of main method



    /// <summary>
    /// add student to the database
    /// </summary>
    /// <param name="dbContext"></param>
    private static void AddStudent(EFcoreDbContext dbContext)
    { 
        var  branch1 = dbContext.Branches.FirstOrDefault(b => b.BranchName == "Civil Engineering");
        var student1 = new Student
        {
            Name = "John Doe",
            Email = "john.doe@example.com",
            DateOfBirth = new DateTime(2020, 1, 1),
            PhoneNumber = "555-555-5555",
            EnrollmentDate = DateTime.Now,
           Branch = branch1,

        };

        var student2 = new Student
        {
            Name = "Jane Doe",
            Email = "jane.doe@example.com",
            DateOfBirth = new DateTime(2020, 1, 1),
            PhoneNumber = "555-555-5555",
            EnrollmentDate = DateTime.Now,
           Branch = branch1,

        };

 dbContext.Students.Add(student1);
 dbContext.Students.Add(student2);
        dbContext.SaveChanges();
        Console.WriteLine("the Student added successfully");

    }



   /// <summary>
   /// add branch to database
   /// </summary>
   /// <param name="dbContext"></param>
  
    private static void addBranch(EFcoreDbContext dbContext)
    {
        // add a new branch
        var branch1 = new Branch
        {
            BranchName = "NTS",
            Description = "Network and Technical Support",
            PhoneNumber = "1234567890",
            Email = "branch1@example.com"
        };

        var branch2 = new Branch
        {
            BranchName = "Civil Engineering",
            Description =
                "This is the branch Civil Engineering Design and TechnologyCivil Engineering Design and Technology",
            PhoneNumber = "0987654321",
            Email = "branch2@example.com"
        };

        dbContext.Branches.Add(branch1);
        dbContext.Branches.Add(branch2);
        //lazy loading is enabled by default
        dbContext.SaveChanges();
        Console.WriteLine("the Branch added successfully");

    }



    #region GetAllStudents
    private static void GetAllStudents(EFcoreDbContext dbContext)
    { 
        var students = dbContext.Students.Include(s=>s.Branch).ToList();
        foreach (var student in students)
        {
            Console.WriteLine($"Student ID: {student.Id}");
            Console.WriteLine($"Student Name: {student.Name}");
            Console.WriteLine($"Student Email: {student.Email}");
            Console.WriteLine($"Student Date of Birth: {student.DateOfBirth.ToShortDateString()}");
            Console.WriteLine($"Student Phone Number: {student.PhoneNumber}");
            Console.WriteLine($"Student Enrollment Date: {student.EnrollmentDate.ToShortDateString()}");
            Console.WriteLine($"Student Branch: {student.Branch.BranchName}");

            Console.WriteLine("----------------");

        }


    }



    #endregion

    #region GetStudentsByID

    private static void GetStudentsByID(EFcoreDbContext dbContext, int studentId)
    {
        var student = dbContext.Students.Find(studentId);
        if (student == null)
        {
            Console.WriteLine("Student not found.");
            return;
        }
        else
        {
            Console.WriteLine($"Student found: {student.Id}- {student.DateOfBirth}-{student.Email}");
        }






    }









    #endregion

    #region UpdateStudent

    private static void UpdateStudent(EFcoreDbContext dbContext, int studentId)
    { 
        var student = dbContext.Students.Find(studentId);
        if (student == null)
        {
            Console.WriteLine("Student not found.");
            return;
        }
        else
        {  // update student information
           
            student.Name = "Mike";
            student.Email = "Mike@gmail.com";
            student.DateOfBirth = new DateTime(2020, 1, 1);
            student.PhoneNumber = "123123123";
            student.EnrollmentDate = DateTime.Now;

            dbContext.SaveChanges();
            Console.WriteLine("Student updated successfully");

        }
    }




    #endregion

    #region DeleteStudent
    private static void DeleteStudent(EFcoreDbContext dbContext, int studentId)
    {
      var student = dbContext.Students.Find(studentId);
        if (student == null)
        {


                Console.WriteLine("Student not found");

        }
        else
        {
            dbContext.Students.Remove(student);
            //lazy loading is enabled by default
            dbContext.SaveChanges();
            Console.WriteLine("Student deleted successfully");
        }
    }   

    

    #endregion


} // end of class Program
