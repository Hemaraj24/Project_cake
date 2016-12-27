using System;
using System.Data;
using System.Data.OleDb;
using System.Web.Configuration;

/// <summary>
/// Summary description for Sql
/// </summary>
public class Sql
{
    public static DataTable GetDataTable(string db, string sqlQuery)
    {
        DataTable dt = new DataTable();

        try
        {
            string connectionString = WebConfigurationManager.ConnectionStrings[db].ConnectionString;
            OleDbConnection conn = new OleDbConnection();
            OleDbDataAdapter da = new OleDbDataAdapter(sqlQuery, connectionString);
            da.Fill(dt);
        }
        catch (Exception ex)
        {
            throw new Exception("GetDataTable Failed", ex);
        }
        return dt;
    }
}