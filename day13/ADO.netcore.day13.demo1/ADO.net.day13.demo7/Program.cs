using Microsoft.Data.SqlClient;

namespace ADO.net.day13.demo7;

internal class Program
{
    static void Main(string[] args)
    {
        // this is an example for deleting one record
        // define connection string
        string connectionString = "Server=cstsrv001.westus2.cloudapp.azure.com;Database=StudentDB;User Id=sa;Password=Cst001.com;TrustServerCertificate=True;";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            // open database
            connection.Open();
            // fetch all records sql scripts
            // string sqlTxt = "select * from Students";

            // delete one record

            string sqlTxt = "delete from Students where Id=2";
            using (SqlCommand command=new SqlCommand(sqlTxt,connection))
            {
                int result= command.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("one record deleted");
                }
                else
                {
                    Console.WriteLine("no record is deleted");
                }
            }

        }
    }
    }
