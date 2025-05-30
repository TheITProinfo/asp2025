using Microsoft.Data.SqlClient;

namespace ASP.net.ADO.day13.demo3;

internal class Program
{
    static void Main(string[] args)
    {
        // this is an example insert  a new record into the table
        // define connection string
        string connectionString = "Server=cstsrv001.westus2.cloudapp.azure.com;Database=StudentDB;User Id=sa;Password=Cst001.com;TrustServerCertificate=True;";
        // create sql connection object
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            // open database
            connection.Open();

            string sqlTxt = @"
             insert into Students (FirstName,LastName,Email)
             values('Gold','Wang','abc@hotmail.com');";

            using (SqlCommand command = new SqlCommand(sqlTxt, connection))
            {
                int rows=command.ExecuteNonQuery();
                if (rows > 0)
                {
                    Console.WriteLine("the record inserted");
                }
                else
                {
                    Console.WriteLine("no record insert!");
                }

            } // end of sqlcommand using


        } // end of sqlconnection using
    }
    }
