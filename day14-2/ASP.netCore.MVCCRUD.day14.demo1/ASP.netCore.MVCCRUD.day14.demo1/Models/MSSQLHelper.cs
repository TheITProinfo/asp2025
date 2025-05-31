using System.Data;
using ASP.netCore.MVCCRUD.day14.demo1.Services;
using Microsoft.Data.SqlClient;

namespace ASP.netCore.MVCCRUD.day14.demo1.Models;

public static class MSSQLHelper
{
    public static readonly string connStr =
        AppConfigurationService._configuration.GetConnectionString("myConnectionString");

    /// <summary>
    /// pass one sql script, execute noQuery (inset/delete/update)
    /// </summary>
    /// <param name="sqlTxt"></param>
    /// <returns>int affected rows</returns>
    public static int ExecuteNoQuery(string sqlTxt)
    {
        using (SqlConnection SqlConn=new SqlConnection(connStr))
        {
            SqlConn.Open(); // open dataBase
            SqlCommand sqlCommand=SqlConn.CreateCommand();
            sqlCommand.CommandText=sqlTxt;
            sqlCommand.CommandType = CommandType.Text; // not stored procedure

            return sqlCommand.ExecuteNonQuery();



        }

    } //end of executeNoquery

    /// <summary>
    /// get record from the table
    /// </summary>
    /// <param name="sqlTxt"></param>
    /// <returns></returns>
    public static SqlDataReader GetDataReader(string sqlTxt)
    {
        SqlConnection sqlConn = new SqlConnection(connStr);
        sqlConn.Open(); // open database
        SqlCommand sqlCommand=sqlConn.CreateCommand();
        sqlCommand.CommandText=sqlTxt;
        sqlCommand.CommandType=CommandType.Text; // execute sql script, not stored procedure
        // when closed the database, will automaticall close teh connection
        return sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);

    }

    /// <summary>
    /// get value of the first colummn first row
    /// </summary>
    /// <param name="sqlTxt"></param>
    /// <returns></returns>
    public static object GetScalar(string sqlTxt)
    {
        using (SqlConnection sqlConn=new SqlConnection(connStr))
        {
            sqlConn.Open(); // open database
            SqlCommand sqlCommand = sqlConn.CreateCommand();
            sqlCommand.CommandText=sqlTxt;
            sqlCommand.CommandType= CommandType.Text;
            return sqlCommand.ExecuteScalar();

        }
    }


} //end of class
