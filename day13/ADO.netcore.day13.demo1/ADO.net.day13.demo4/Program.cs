using Microsoft.Data.SqlClient;

namespace ADO.net.day13.demo4;

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

            // retrieve the record

            string sqlTxt = "select * from Students where Id>1";
            using (SqlCommand command =new SqlCommand(sqlTxt,connection))
            {
                // command.execute data reader

                // Read all rows from the SQlDataReader

                using (SqlDataReader reader=command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("ID:{0},FirstName:{1},LastName{2},Email{3}", reader["Id"], reader["FirstName"], reader["LastName"], reader["Email"]);
                    }
                } // end of sqlreader using
            }




        }


    }
}
