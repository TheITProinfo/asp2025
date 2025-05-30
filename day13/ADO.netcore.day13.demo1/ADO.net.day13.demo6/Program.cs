using Microsoft.Data.SqlClient;

namespace ADO.net.day13.demo6;

internal class Program
{
    static void Main(string[] args)
    {
        // this is an example for executescalar

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

            string sqlTxt = "select count(*) from Students";

            using (SqlCommand command=new SqlCommand(sqlTxt,connection))
            {
                object result= command.ExecuteScalar();

                int totalStudents = Convert.ToInt32(result);

                Console.WriteLine("total student:{0}", totalStudents);

            }



        }

    }
    }
