using Microsoft.Data.SqlClient;

namespace ADO.netcore.day13.demo1;

internal class Program
{
    static void Main(string[] args)
    {
        // this example for connect to database and create a table "Student"

        // 1. connection string
        //  using SQL server authentication
        
        string connectionString = "Server=cstsrv001.westus2.cloudapp.azure.com;Database=StudentDB;User Id=sa;Password=Cst001.com;TrustServerCertificate=True;";

        //2.add package
        // create SQL connection object

        using (SqlConnection connection = new SqlConnection(connectionString))
        {


            connection.Open();
            Console.WriteLine("database connected successfully");
            Console.ReadKey();
            // always close the database.
            connection.Close();
        }
    } // end of main function

}
