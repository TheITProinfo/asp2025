using Microsoft.Data.SqlClient;

namespace ASP.core.day13.demo2;

internal class Program
{
    static void Main(string[] args)
    {
        // this is an example insert record
        string connectionString = "Server=cstsrv001.westus2.cloudapp.azure.com;Database=StudentDB;User Id=sa;Password=Cst001.com;TrustServerCertificate=True;";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            // create table "student"

            string sqlTxt = @"

            create table Students(
                         Id int primary key Identity(1,1),
                         FirstName nvarchar(100),
                         LastName  nvarchar(100),
                         Email     nvarchar(100)
            );";

            using (SqlCommand command = new SqlCommand(sqlTxt, connection))
            {
                // execute nonquery // delete insert create
                command.ExecuteNonQuery();
                Console.WriteLine("the table created successfully!");


            } // end of command using





        } //end of using 
    }
}
