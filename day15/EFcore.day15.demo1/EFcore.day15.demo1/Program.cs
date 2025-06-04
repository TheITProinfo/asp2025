using EFcore.day15.demo1.Entities;

namespace EFcore.day15.demo1;

internal class Program
{
    static void Main(string[] args)
    {
        // create a new instance of the EFCoreDbContext

        using var dbContext = new EFCoreDbContext();

        //AddBranch(dbContext);

        AddStudent(dbContext);

    

    } // end of main


    #region AddBranch

    // encapsulated to add branch method
    private static void AddBranch(EFCoreDbContext dbContext)
    {
        var branch1 = new Branch
        {
            BranchName = "HR program",
            Description = "This is the branch CAD program",
            PhoneNumber = "123-456-7890",
            Email = "branch1@example.com",

        };

        var branch2 = new Branch
        {
            BranchName = "sales program",
            Description = "This is the branch Electrical Engineering",
            PhoneNumber = "098-765-4321",
            Email = "branch2@example.com",

        };

        // add the branch objects to the context
        dbContext.Branches.Add(branch1);
        dbContext.Branches.Add(branch2);
        dbContext.SaveChanges();
        Console.WriteLine("Branch added successfully!");
    }

    #endregion

    #region AddStudent

    private static void AddStudent(EFCoreDbContext dbContext)
    { 
        // retrieve the branch objects 
            var  branch1 = dbContext.Branches.FirstOrDefault(b => b.BranchName == "CAD program");

            var student = new Student
            {
                Name = "John Doe",
                Email = "john.doe@example.com",
                DateOfBirth = new DateTime(2020, 1, 1),
                PhoneNumber = "555-555-5555",
                EnrollmentDate = DateTime.Now,
               Branch = branch1,

            };

        dbContext.Students.Add(student);
        dbContext.SaveChanges();
        Console.WriteLine("Students added successfully");
    }

    

    #endregion


}// end of program
