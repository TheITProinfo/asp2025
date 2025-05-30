using System.Data;
using Microsoft.Data.SqlClient;

namespace ADO.net.day13.demo8;

internal class Program
{
    static void Main(string[] args)
    {
        // this is an example with stored procedure
        // define connection string
        string connectionString = "Server=cstsrv001.westus2.cloudapp.azure.com;Database=StudentDB;User Id=sa;Password=Cst001.com;TrustServerCertificate=True;";
        // create sql connection object
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            // open database
            connection.Open();
            // fetch all records sql scripts
            // string sqlTxt = "select * from Students";

            // retrieve the record
            using (SqlCommand command = new SqlCommand("GetStudentNameByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@StudentID", 1);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string firstName = reader["FirstName"].ToString();
                    string lastName = reader["LastName"].ToString();
                    Console.WriteLine("firstname: {0} lastName:{1}", firstName, lastName);
                }
            }
        }
            }


        }

   