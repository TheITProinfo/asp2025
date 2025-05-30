using Microsoft.Data.SqlClient;

namespace AspADOnetcore.day12.demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // windows Authentication
            //string connectionString = "server=HYPVERHOST\\SQLEXPRESS;DataBase=StudentDB;Trusted_Connection=True;TrustServerCertificate=True";
            // sql server authentication
            string connectionString = "server=HYPVERHOST\\SQLEXPRESS;DataBase=StudentDB;User Id=sa;password=Cst001.com;TrustServerCertificate=True";
            // create a SQL connection 
            SqlConnection connection = new SqlConnection(connectionString);
            // open database
            try
            {
                connection.Open();
                Console.WriteLine("database connected successfully");
                Console.ReadKey();

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error: {ex.Message}");


            }

            finally
            {
                connection.Close();
            }
        
        }// end of main function
    }
}
