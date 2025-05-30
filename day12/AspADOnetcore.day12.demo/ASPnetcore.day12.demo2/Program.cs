using Microsoft.Data.SqlClient;

namespace ASPnetcore.day12.demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // define connection string,
            string connectionString = "server=HYPVERHOST\\SQLEXPRESS;Database=StudentDB;User ID=sa;password=Cst001.com;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            { 
                connection.Open();

                # region//Console.WriteLine("database connected successfully!!");

                // create student Table
                //string sqltxt = @"
                //      create Table Students (
                //        ID int primary Key Identity(1,1),
                //        FirstName nvarchar(50),
                //        LastName nvarchar(50),
                //        Email     nvarchar(50)

                //        );";
                # endregion

                string stu_FirstName = "Alice";
                string stu_LastName = "Zhang";
                string stu_Email = "abc@hotmailc.com";


                #region//string insertSql = @"

                //            insert into Students(FirstName,LastName,Email)
                //                        values(@stu_FirstName,@stu_LastName,@stu_Email);";

                //using (SqlCommand command = new SqlCommand(insertSql, connection))
                //{
                //    // add parameter to the command to prevent SQL injection
                //    command.Parameters.AddWithValue("@FirstName", stu_FirstName);
                //    command.Parameters.AddWithValue("@LastName", stu_LastName);
                //    command.Parameters.AddWithValue("@Email", stu_Email);

                //    // non query sql command 
                //    // executeNonQuery returns the numbers if rows affected
                //   int rowsAffected=command.ExecuteNonQuery();
                //    if (rowsAffected > 0)
                //    {
                //        Console.WriteLine(" the data  inserteded successfully");
                //    }
                //    else {

                //        Console.WriteLine("no rows affected, insert data failure");
                //    }


                //} // end of sql command
                #endregion

                string insertSql = @"
                                 INSERT INTO Students (FirstName, LastName, Email)
                                 VALUES (@FirstName, @LastName, @Email);";

                using (SqlCommand command = new SqlCommand(insertSql, connection))
                {
                    // Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@FirstName", stu_FirstName);
                    command.Parameters.AddWithValue("@LastName", stu_LastName);
                    command.Parameters.AddWithValue("@Email", stu_Email);

                    // ExecuteNonQuery returns the number of rows affected
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Data inserted successfully!");
                    }
                    else
                    {
                        Console.WriteLine("No rows affected, insert data failure.");
                    }
                } // End of SqlCommand













            } // end of using connection

            }// end of main function
    }
}
