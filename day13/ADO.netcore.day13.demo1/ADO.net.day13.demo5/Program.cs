using Microsoft.Data.SqlClient;

namespace ADO.net.day13.demo5;

internal class Program
{
    static void Main(string[] args)
    {
        // this is an example for retriving all records from the table "students"

        // define connection string
        string connectionString = "Server=cstsrv001.westus2.cloudapp.azure.com;Database=StudentDB;User Id=sa;Password=Cst001.com;TrustServerCertificate=True;";
        // create sql connection object
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            // open database
            connection.Open();
            // fetch all records sql scripts
            // string sqlTxt = "select * from Students";

            // update one record

            string sqlTxt = "update Students set FirstName='Frank',Email='Frank@abc.com' where Id=2";

            using (SqlCommand command=new SqlCommand(sqlTxt,connection))
            {
                int rows=command.ExecuteNonQuery();


                if (rows > 0)
                {
                    Console.WriteLine("the record updated");
                }
                else
                {
                    Console.WriteLine("no record updated, something wrong");
                }
            }


        }
    }
    }
